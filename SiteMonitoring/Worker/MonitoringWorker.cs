using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiteMonitorings.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SiteMonitorings.Settings;
using OpenQA.Selenium.DevTools.V102.DOMDebugger;
using AngleSharp.Dom;
using System.Xml.Linq;
using System.Collections.ObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Contracts;

namespace SiteMonitorings.Worker
{
    internal class MonitoringWorker : IMonitoringWorker
    {
        /// <summary> Finishing execution </summary>
        /// <param> string is null if no error otherwise contain error message</param>
        public event EventHandler<string> WhenFinish;

        /// <summary> Handle exception during execution </summary>
        public event EventHandler<string> WhenError;

        /// <summary> An error occurred during the execution </summary>
        public event EventHandler<ListingInfo> WhenFound;

        /// <summary> Execution thread </summary>
        private Thread _workerThread;

        public void Start(List<PageSettings> pageSettings, Mutex parametersChangingMutex, WorkMode mode)
        {
            Debug.Assert(!IsWorking(), "Поток уже работает");
            Debug.Assert(WhenFound != null, "No callbacl for on found");
            Debug.Assert(WhenFinish != null, "No callback for finishing");

            foreach (var page in pageSettings)
            {
                try
                {
                    if (page.PathToList == null || page.ParametersList == null)
                        throw new ArgumentException($"Parameter is null in {page.Name}!");

                    if (!page.PathToList.Any())
                        throw new ArgumentException($"Path to list is empty in {page.Name}.");
                    if (!page.ParametersList.Any())
                        throw new ArgumentException($"Parameters list is empty in {page.Name}.");
                    if (string.IsNullOrEmpty(page.SiteLink))
                        throw new ArgumentException($"Site link is empty in {page.Name}.");
                    if (string.IsNullOrEmpty(page.ListingsElementNameInList))
                        throw new ArgumentException($"Listing name is empty in {page.Name}.");

                    foreach (var path in page.PathToList)
                    {
                        if (string.IsNullOrEmpty(path.Name))
                            throw new ArgumentException($"One of paths to the list is empty.");
                    }

                    foreach (var param in page.ParametersList)
                    {
                        var Elements = param.GetPathToParameter();
                        if (!Elements.Any())
                            throw new ArgumentException($"Can't find path to parameter '{param.ParameterName}' in page {page.Name}");
                        foreach (var element in Elements)
                        {
                            if (string.IsNullOrEmpty(element.Name))
                                throw new ArgumentException($"Error in path to parameter '{param.ParameterName}' in page {page.Name}");
                        }
                    }
                }
                catch (Exception exception)
                {
                    WhenFinish?.Invoke(this, exception.Message);
                    return;
                }
            }

            _workerThread = new Thread(() => WorkerThread(mode, pageSettings, parametersChangingMutex));
            _workerThread.Start();
        }

        /// <summary> Interrupting promotion </summary>
        public void Interrupt()
        {
            if (IsWorking())
                _workerThread.Interrupt();
        }

        /// <returns>True if promotion executing</returns>
        public bool IsWorking()
        {
            return _workerThread?.IsAlive == true;
        }

        public void Dispose()
        {
            _workerThread?.Abort();
        }

        private void OnError(string errorMessage)
        {
            WhenError?.Invoke(this, errorMessage);
        }

        private void OnFoundNewElement(ListingInfo parameters)
        {
            WhenFound?.Invoke(this, parameters);
        }

        private void WorkerThread(WorkMode mode, List<PageSettings> pageSettings, Mutex parametersChangingMutex)
        {
            WebDriverHelper webDriverHelper = null;
            try
            {
                do
                {
                    try
                    {
                        webDriverHelper = CreateWebDriver();
                    }
                    catch (Exception exception)
                    {
                        OnError($"Failed to create a web driver\": {exception.Message}");
                        continue;
                    }

                    foreach (var page in pageSettings)
                    {
                        try
                        {
                            webDriverHelper.OpenNewTab(page.SiteLink);

                            for (int i = 0; i < 5; ++i)
                            {
                                try
                                {
                                    IWebElement list = null;

                                    try
                                    {
                                        list = GetListingsListElement(webDriverHelper, page);
                                        if (list == null)
                                            throw new Exception("Element not found");
                                    }
                                    catch (Exception exception)
                                    {
                                        throw new Exception("Failed to get list with listings " + exception.Message);
                                    }

                                    CheckForNewListings(webDriverHelper, list, page, parametersChangingMutex);

                                    break;
                                }
                                catch (Exception)
                                {
                                    if (i == 2)
                                        throw;

                                    Thread.Sleep(new TimeSpan(0, 0, 1));
                                }
                            }
                        }
                        catch (Exception exception)
                        {
                            OnError($"Error during execution for {page.Name}: {exception.Message}");
                        }
                        finally
                        {
                            try
                            {
                                webDriverHelper.CloseCurrentTab();
                            }
                            catch (Exception exception)
                            {
                                OnError($"Can't close chrome driver for {page.Name}: {exception.Message}");
                            }
                        }
                    }

                    try
                    {
                        webDriverHelper.Driver.Quit();
                    }
                    catch (Exception exception)
                    {
                        OnError($"Can't quit chrome {exception.Message}");
                    }
                } while (WaitForNextExecution(mode));
            }
            catch (Exception exception)
            {
                switch (exception)
                {
                    case ThreadInterruptedException _:
                    case ThreadAbortException _:
                        return;
                }

                OnError(exception.ToString());
            }
            finally
            {
                webDriverHelper?.Driver.Quit();
                WhenFinish?.Invoke(this, null);
            }
        }

        static WebDriverHelper CreateWebDriver()
        {
            int attempt = 0, maxAttempts = 5;

            while (true)
            {
                try
                {
                    var webDriverHelper = new WebDriverHelper();
                    webDriverHelper.Driver = WebDriverHelper.CreateWebDriver();
                    return webDriverHelper;
                }
                catch (Exception)
                {
                    if (++attempt == maxAttempts)
                    {
                        throw;
                    }
                }
            }

            throw new InvalidOperationException("Unreachable code");
        }

        IWebElement GetListingsListElement(WebDriverHelper webDriverHelper, PageSettings pageSettings)
        {
            var wait = new WebDriverWait(webDriverHelper.Driver, TimeSpan.FromSeconds(10));

            IWebElement currentElement = null;
            bool first = true;
            foreach (var element in pageSettings.PathToList)
            {
                if (first)
                    currentElement = wait.Until(driver => webDriverHelper.Driver.FindElement(element.GetBy()));
                else
                    currentElement = wait.Until(driver => currentElement.FindElement(element.GetBy()));
                first = false;
            }
            if (currentElement == null)
                throw new Exception("Can't find listings list by path!");
            return currentElement;
        }

        void CheckForNewListings(WebDriverHelper webDriverHelper, IWebElement listElement, PageSettings pageSettings, Mutex parametersChangingMutex)
        {
            ReadOnlyCollection<IWebElement> listElements;

            try
            {
                listElements = listElement.FindElements(ElementInfo.GetBy(ElementInfo.ElementType.Class,
                                                                          pageSettings.ListingsElementNameInList));
                if (listElements == null || !listElements.Any())
                {
                    listElements = listElement.FindElements(ElementInfo.GetBy(ElementInfo.ElementType.ClassContains,
                                                                              pageSettings.ListingsElementNameInList));
                }
                if (listElements == null || !listElements.Any())
                    throw new Exception("Listings list is empty\n");
            }
            catch (Exception exception)
            {
                throw new Exception("Can't find listings in list, check listing name.\nError: " + exception.Message);
            }

            for (int i = listElements.Count - 1; i >= 0; i--)
            {
                var parametersForListing = GetParametersForListing(listElements[i], pageSettings.ParametersList);

                bool needAddToList = true;
                foreach (var paramList in pageSettings.AlreadySendedListings)
                {
                    if (paramList.Parameters.Count != parametersForListing.Parameters.Count)
                        continue;
                    bool parametersFound = true;
                    for (int j = 0; j < paramList.Parameters.Count; ++j)
                    {
                        if (paramList.Parameters[j].ParameterName != parametersForListing.Parameters[j].ParameterName ||
                            paramList.Parameters[j].Content != parametersForListing.Parameters[j].Content)
                        {
                            parametersFound = false;
                            break;
                        }
                    }
                    if (parametersFound)
                    {
                        needAddToList = false;
                        break;
                    }
                }

                if (needAddToList)
                {
                    parametersChangingMutex.WaitOne();
                    pageSettings.AlreadySendedListings.Add(parametersForListing);
                    if (pageSettings.AlreadySendedListings.Count > 150)
                        pageSettings.AlreadySendedListings.RemoveRange(0, pageSettings.AlreadySendedListings.Count - 150);
                    parametersChangingMutex.ReleaseMutex();
                    OnFoundNewElement(parametersForListing);
                }
            }
        }

        ListingInfo GetParametersForListing(IWebElement listing, List<ParameterInfo> parameters)
        {
            List<ParameterResult> result = new List<ParameterResult>();
            foreach (var param in parameters)
            {
                string content;
                try
                {
                    IWebElement parameterElement = listing;
                    foreach (var element in param.GetPathToParameter())
                    {
                        if (!element.NeedFindElement())
                        {
                            Debug.Assert(param.GetPathToParameter().Count == 1);
                            continue;
                        }
                        parameterElement = parameterElement.FindElement(element.GetBy());
                    }

                    var contentVal = ElementInfo.GetContent(parameterElement, param.Type, param.ParameterName);
                    var charsToRemove = new string[]{ "\r", "\n" };
                    foreach (var c in charsToRemove)
                        contentVal = contentVal.Replace(c, string.Empty);

                    content = "\"" + contentVal + "\"";
                }
                catch (Exception exception)
                {
                    content = "Error:\"" + exception.Message + "\"";
                }
                result.Add(new ParameterResult { ParameterName = param.ParameterName, Content = content });
            }
            return new ListingInfo(result);
        }

        // return true if we can continue execution
        bool WaitForNextExecution(WorkMode mode)
        {
            switch (mode)
            {
                case WorkMode.eOnes:
                    return false;
                case WorkMode.eSeconds_1:
                    Thread.Sleep(new TimeSpan(0, 0, 1));
                    break;
                case WorkMode.eSeconds_30:
                    Thread.Sleep(new TimeSpan(0, 0, 30));
                    break;
                case WorkMode.eMinutes_1:
                    Thread.Sleep(new TimeSpan(0, 1, 0));
                    break;
                case WorkMode.eMinutes_5:
                    Thread.Sleep(new TimeSpan(0, 5, 0));
                    break;
                case WorkMode.eMinutes_10:
                    Thread.Sleep(new TimeSpan(0, 10, 0));
                    break;
                case WorkMode.eMinutes_15:
                    Thread.Sleep(new TimeSpan(0, 15, 0));
                    break;
                case WorkMode.eMinutes_30:
                    Thread.Sleep(new TimeSpan(0, 30, 0));
                    break;
                case WorkMode.eHour_1:
                    Thread.Sleep(new TimeSpan(1, 0, 0));
                    break;
                case WorkMode.eHour_5:
                    Thread.Sleep(new TimeSpan(5, 0, 0));
                    break;
                case WorkMode.eDay:
                    Thread.Sleep(new TimeSpan(1, 0, 0, 0));
                    break;
                case WorkMode.eUntilInterrupt:
                    Thread.Sleep(3000);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return true;
        }
    }
}

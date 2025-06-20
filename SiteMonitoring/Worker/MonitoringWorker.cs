using AngleSharp.Dom;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SiteMonitorings.Settings;
using SiteMonitorings.WebDriver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static SiteMonitorings.Settings.ExecutionInfo;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SiteMonitorings.Worker
{
    internal class MonitoringWorker : IMonitoringWorker
    {
        /// <summary> Finishing execution </summary>
        /// <param> string is null if no error otherwise contain error message</param>
        public event EventHandler<string> WhenFinish;

        /// <summary> Handle exception during execution </summary>
        public event EventHandler<string> WhenError;

        /// <summary> Notification about new item found </summary>
        public event FoundHandler WhenFound;

        /// <summary> Execution thread </summary>
        private Thread _workerThread;

        public bool Start(List<PageSettings> pageSettings, Mutex parametersChangingMutex, WorkMode mode)
        {
            Debug.Assert(!IsWorking(), "Поток уже работает");
            Debug.Assert(WhenFound != null, "No callbacl for on found");
            Debug.Assert(WhenFinish != null, "No callback for finishing");

            foreach (var page in pageSettings)
            {
                try
                {
                    if (string.IsNullOrEmpty(page.SiteLink))
                        throw new ArgumentException($"Site link is empty.");
                }
                catch (Exception exception)
                {
                    WhenFinish?.Invoke(this, $"Incorrect page `{page.Name}` setting: {exception.Message}");
                    return false;
                }
            }

            _workerThread = new Thread(() => WorkerThread(mode, pageSettings, parametersChangingMutex));
            _workerThread.Start();
            return true;
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

        private bool OnFoundNewElement(ListingInfo parameters)
        {
            return WhenFound?.Invoke(this, parameters) ?? true;
        }

        private void ValidateParams(PageSettings page)
        {
            if (page.PathToList == null || !page.PathToList.Any())
                throw new ArgumentException($"Path to list is empty in {page.Name}.");
            foreach (var path in page.PathToList)
            {
                if (string.IsNullOrEmpty(path.Name))
                    throw new ArgumentException($"One of paths to the list is empty.");
            }

            if (page.ParametersList == null || !page.ParametersList.Any())
                throw new ArgumentException($"Parameters list is empty in {page.Name}.");
            foreach (var param in page.ParametersList)
            {
                var Elements = ElementInfo.ConvertToElementsInfo(param.FullPath);
                if (!Elements.Any())
                    throw new ArgumentException($"Can't find path to parameter '{param.ParameterName}' in page {page.Name}");
                foreach (var element in Elements)
                {
                    if (string.IsNullOrEmpty(element.Name))
                        throw new ArgumentException($"Error in path to parameter '{param.ParameterName}' in page {page.Name}");
                }
            }

            if (string.IsNullOrEmpty(page.ListingsElementNameInList))
                throw new ArgumentException($"Listing name is empty in {page.Name}.");
        }

        private void checkPage(WebDriverHelper webDriverHelper, PageSettings page, Mutex parametersChangingMutex)
        {
            ExecuteActions(webDriverHelper, page.ExecutionInfo);

            IWebElement list = null;
            try
            {
                list = GetElement(webDriverHelper, page.PathToList);
                if (list == null)
                    throw new Exception("Element not found");
            }
            catch (Exception exception)
            {
                switch (exception)
                {
                    case ThreadInterruptedException _:
                    case ThreadAbortException _:
                        throw;
                }
                throw new Exception($"Failed to get list with listings: {exception.Message}");
            }

            CheckForNewListings(webDriverHelper, list, page, parametersChangingMutex);
        }

        private void WorkerThread(WorkMode mode, List<PageSettings> pageSettings, Mutex parametersChangingMutex)
        {
            foreach (var page in pageSettings)
            {
                try
                {
                    ValidateParams(page);
                }
                catch (Exception exception)
                {
                    switch (exception)
                    {
                        case ThreadInterruptedException _:
                        case ThreadAbortException _:
                            throw;
                    }
                    WhenFinish?.Invoke(this, $"Error in page settings for {page.Name}: {exception.Message}");
                    return;
                }
            }

            var maxAttemptsPerPage = mode == WorkMode.eTestMode ? 1 : 3;

            // In test mode we close the browser only AFTER we show results
            WebDriverHelper webDriverHelper = null;

            try
            {
                do
                {
                    foreach (var page in pageSettings)
                    {
                        for (int attempt = 1; attempt <= maxAttemptsPerPage; ++attempt)
                        {
                            try
                            {
                                try
                                {
                                    // we open web browser for each page separately because we need to hard reset all browser cache
                                    // otherwise some websites may show captcha or block access
                                    webDriverHelper = CreateWebDriver();
                                }
                                catch (Exception exception)
                                {
                                    throw new Exception($"Failed to create a web driver", exception);
                                }

                                try
                                {
                                    webDriverHelper.OpenInCurrentWindow(page.SiteLink);
                                }
                                catch (Exception exception)
                                {
                                    throw new Exception($"Failed to open new tab", exception);
                                }

                                try
                                {
                                    checkPage(webDriverHelper, page, parametersChangingMutex);
                                    break;
                                }
                                finally
                                {
                                    if (mode != WorkMode.eTestMode)
                                    {
                                        // In test mode we close the browser only AFTER we show results
                                        webDriverHelper.Quit();
                                    }
                                }
                            }
                            catch (Exception exception)
                            {
                                Exception currentException = exception;
                                do
                                {
                                    switch (currentException)
                                    {
                                        case ThreadInterruptedException _:
                                        case ThreadAbortException _:
                                            throw currentException;
                                    }

                                    currentException = currentException.InnerException;
                                } while (currentException != null);

                                if (attempt == maxAttemptsPerPage)
                                    OnError($"Error during processing page `{page.Name}`: {exception.ToString()}");
                                else
                                    Thread.Sleep(new TimeSpan(0, 0, 1));
                            }
                        }
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

                Debug.Assert(false, $"Unhandled exception {exception.ToString()}");
            }
            finally
            {
                WhenFinish?.Invoke(this, null);

                try
                {
                    // In test mode we close the browser only AFTER we show results
                    webDriverHelper?.Driver.Quit();
                }
                catch (Exception)
                {
                }
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
                catch (Exception exception)
                {
                    switch (exception)
                    {
                        case ThreadInterruptedException _:
                        case ThreadAbortException _:
                            throw;
                    }
                    if (++attempt == maxAttempts)
                    {
                        throw;
                    }
                }
            }

            throw new InvalidOperationException("Unreachable code");
        }

        void ExecuteActions(WebDriverHelper webDriverHelper, List<ExecutionInfo> executionInfo)
        {
            foreach (var param in executionInfo)
            {
                if (param.action == ExecutionType.eWait)
                {
                    Thread.Sleep(int.Parse(param.value) * 1000);
                    continue;
                }

                try
                {
                    var element = GetElement(webDriverHelper, ElementInfo.ConvertToElementsInfo(param.path));

                    switch (param.action)
                    {
                        case ExecutionType.eClick:
                            element.Click();
                            break;
                        case ExecutionType.eEnterText:
                            element.Clear();
                            element.SendKeys(param.value);
                            break;
                        case ExecutionType.eInterruptIfExistAndText:
                            if (element.Text == param.value)
                                return;
                            break;
                        case ExecutionType.eInterruptIfNotExistOrTextNotEqual:
                            if (element.Text != param.value)
                                return;
                            break;
                        default:
                            throw new Exception($"Unsupported action {param.action} with path {param.path}");
                    }
                }
                catch (Exception ex)
                {
                    switch (ex)
                    {
                        case ThreadInterruptedException _:
                        case ThreadAbortException _:
                            throw;
                    }
                    if (param.action == ExecutionType.eInterruptIfNotExistOrTextNotEqual)
                        return;

                    throw new Exception($"Failed to execute action {param.action} on element with path {param.path}", ex);
                }
            }
        }

        IWebElement GetElement(WebDriverHelper webDriverHelper, List<ElementInfo> elements)
        {
            IWebElement currentElement = null;
            bool first = true;
            foreach (var element in elements)
            {
                if (first)
                {
                    var wait = new WebDriverWait(webDriverHelper.Driver, TimeSpan.FromSeconds(10));
                    currentElement = wait.Until(driver => webDriverHelper.Driver.FindElement(element.GetBy()));
                }
                else
                    currentElement = currentElement.FindElement(element.GetBy());

                first = false;
            }
            if (currentElement == null)
                throw new Exception("Can't find element by path!");
            return currentElement;
        }

        void CheckForNewListings(WebDriverHelper webDriverHelper, IWebElement listElement, PageSettings pageSettings, Mutex parametersChangingMutex)
        {
            ReadOnlyCollection<IWebElement> listElements;

            try
            {
                var name = pageSettings.ListingsElementNameInList;
                if (name.StartsWith(".//") || name.StartsWith("//") || name.StartsWith("./*"))
                {
                    listElements = listElement.FindElements(ElementInfo.GetBy(ElementInfo.ElementType.XPath,
                                                                         pageSettings.ListingsElementNameInList));
                }
                else
                {
                    listElements = listElement.FindElements(ElementInfo.GetBy(ElementInfo.ElementType.Class,
                                                                          pageSettings.ListingsElementNameInList));
                    if (listElements == null || !listElements.Any())
                    {
                        listElements = listElement.FindElements(ElementInfo.GetBy(ElementInfo.ElementType.ClassContains,
                                                                                  pageSettings.ListingsElementNameInList));
                    }
                }

                if (listElements == null || !listElements.Any())
                    throw new Exception("Listings list is empty\n");
            }
            catch (Exception exception)
            {
                switch (exception)
                {
                    case ThreadInterruptedException _:
                    case ThreadAbortException _:
                        throw;
                }
                throw new Exception("Can't find listings in list, check listing name.\nError: " + exception.Message);
            }

            for (int i = 0; i < listElements.Count; i++)
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
                    if (OnFoundNewElement(parametersForListing))
                    {
                        parametersChangingMutex.WaitOne();
                        pageSettings.AlreadySendedListings.Add(parametersForListing);
                        if (pageSettings.AlreadySendedListings.Count > 150)
                            pageSettings.AlreadySendedListings.RemoveRange(0, pageSettings.AlreadySendedListings.Count - 150);
                        parametersChangingMutex.ReleaseMutex();
                    }
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
                    foreach (var element in ElementInfo.ConvertToElementsInfo(param.FullPath))
                    {
                        if (!element.NeedFindElement())
                        {
                            Debug.Assert(ElementInfo.ConvertToElementsInfo(param.FullPath).Count == 1);
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
                    switch (exception)
                    {
                        case ThreadInterruptedException _:
                        case ThreadAbortException _:
                            throw;
                    }
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
                case WorkMode.eTestMode:
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
                    Debug.Assert(false, "Unknown work mode: " + mode);
                    return false;
            }

            return true;
        }
    }
}

using MetroFramework.Forms;
using OpenQA.Selenium;
using SiteMonitorings.WebDriver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Serialization;
using WebTest.Settings;

namespace WebTest.UI
{
    public partial class MainForm : MetroForm
    {
        private ProgramSettings _settings = new ProgramSettings();

        System.Timers.Timer saveTimer = new System.Timers.Timer();
        Mutex parametersChangingMutex = new Mutex();

        private string _settingsFileName = "test_settings.xml";

        private WebDriverHelper _webDriverHelper;

        public MainForm()
        {
            saveTimer.Elapsed += new ElapsedEventHandler(OnSaveTimer);
            saveTimer.Interval = 1000 * 30;

            _settingsFileName = System.AppDomain.CurrentDomain.FriendlyName;
            int pointIndex = _settingsFileName.LastIndexOf('.');
            if (pointIndex > -1)
            {
                _settingsFileName = _settingsFileName.Substring(0, pointIndex) + ".xml";
            }

            InitializeComponent();

            LoadSettings();

            pathTable.DataSource = new BindingSource
            {
                DataSource = new SiteMonitorings.UI.SortableBindingList<PathInfo>(_settings.XPaths),
                AllowNew = true
            };
        }

        private void checkItem()
        {
            if (_webDriverHelper == null)
            {
                MessageBox.Show(this, "Please open a URL first.", "No URL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            parametersChangingMutex.WaitOne();
            saveTimer.Enabled = false;
            GetSettings();
            try
            {
                if (_settings.XPaths.Count == 0 && _settings.ElementXPath == "")
                {
                    MessageBox.Show(this, "Please add at least one XPath.", "No XPaths", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                ISearchContext searchContext = _webDriverHelper.Driver;

                IWebElement element;
                if (_settings.ElementXPath != "")
                {
                    // If ElementXPath is set, we will search for it after processing all XPaths
                    for (int i = 0; i < _settings.XPaths.Count; i++)
                    {
                        try
                        {
                            searchContext = OpenXPath(searchContext, _settings.XPaths[i].Path);
                        }
                        catch (Exception exception)
                        {
                            throw new Exception($"Error processing XPath {i}: {_settings.XPaths[i].Path}", exception);
                        }
                    }

                    try
                    {
                        element = OpenXPath(searchContext, _settings.ElementXPath);
                    }
                    catch (Exception exception)
                    {
                        throw new Exception($"Error processing ElementXPath: {_settings.ElementXPath}", exception);
                    }
                }
                else
                {
                    // If ElementXPath is not set, we will use the last XPath from the list
                    for (int i = 0; i < _settings.XPaths.Count - 1; i++)
                    {
                        try
                        {
                            searchContext = OpenXPath(searchContext, _settings.XPaths[i].Path);
                        }
                        catch (Exception exception)
                        {
                            throw new Exception($"Error processing XPath {i}: {_settings.XPaths[i].Path}", exception);
                        }
                    }

                    try
                    {
                        element = OpenXPath(searchContext, _settings.XPaths.Last().Path);
                    }
                    catch (Exception exception)
                    {
                        throw new Exception($"Error processing last XPath: {_settings.XPaths.Last().Path}", exception);
                    }
                }

                var elementRect = new Rectangle(element.Location, element.Size);
                var elementText = element.Text;
                var elementLink = ByLink.GetElementLink(element);

                textBoxElementPosition.Text = $"{elementRect.X},{elementRect.Y} ({elementRect.Width}x{elementRect.Height})";
                textBoxElementText.Text = elementText;
                textBoxElementLink.Text = elementLink ?? "No link found";

                int childCount = element.FindElements(By.XPath("./*")).Count;
                textBoxElementChilden.Text = $"{childCount} children";

                HighlightElement(_webDriverHelper.Driver, element);
            }
            catch (Exception exception)
            {
                var text = "Element not found";
                textBoxElementPosition.Text = text;
                textBoxElementText.Text = text;
                textBoxElementLink.Text = text;
                textBoxElementChilden.Text = text;

                Globals.HandleException(exception, "Error during check");
            }
            finally
            {
                saveTimer.Enabled = true;
                parametersChangingMutex.ReleaseMutex();
            }
        }

        private IWebElement OpenXPath(ISearchContext context, string XPath)
        {
            // If XPath have format [%d], then we just take a child element by index
            if (XPath.StartsWith("[") && XPath.EndsWith("]") && int.TryParse(XPath.Trim('[', ']'), out int index))
            {
                return context.FindElement(By.XPath($"./*[{index}]"));
            }
            else
            {
                return context.FindElement(By.XPath(XPath));
            }
        }

        public static void HighlightElement(IWebDriver driver, IWebElement element, int durationMs = 1500)
        {
            var jsDriver = (IJavaScriptExecutor)driver;

            string highlightScript = @"
                var element = arguments[0];
                var originalStyle = element.getAttribute('style');
                element.setAttribute('style', originalStyle + '; border: 2px solid red; background-color: yellow;');
                setTimeout(function(){
                    element.setAttribute('style', originalStyle);
                }, arguments[1]);
            ";

            jsDriver.ExecuteScript(highlightScript, element, durationMs);
        }

        private void OnSaveTimer(object source, ElapsedEventArgs e)
        {
            saveTimer.Enabled = false;
            parametersChangingMutex.WaitOne();
            SaveSettings();
            parametersChangingMutex.ReleaseMutex();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveTimer.Enabled = false;

            SaveSettings();

            _webDriverHelper?.Quit();
        }

        private void LoadSettings()
        {
            try
            {
                var smlSerializer = new XmlSerializer(typeof(ProgramSettings));
                using (var rd = new StreamReader(_settingsFileName))
                {
                    _settings = smlSerializer.Deserialize(rd) as ProgramSettings;
                }
            }
            catch (FileNotFoundException)
            {
            }
            catch (Exception exception)
            {
                Globals.HandleException(exception, "Ошибка при загрузке настроек");
            }

            textBoxUrl.Text = _settings.Url;
            textBoxXPath.Text = _settings.ElementXPath;
        }

        private void SaveSettings()
        {
            try
            {
                GetSettings();

                var smlSerializer = new XmlSerializer(typeof(ProgramSettings));
                using (var wr = new StreamWriter(_settingsFileName))
                {
                    smlSerializer.Serialize(wr, _settings);
                }
            }
            catch (Exception exception)
            {
                Globals.HandleException(exception, "Failed to save settings");
            }
        }

        private void GetSettings()
        {
            _settings.Url = textBoxUrl.Text;
            _settings.ElementXPath = textBoxXPath.Text;
        }

        private void buttonUseClassName_Click(object sender, EventArgs e)
        {
            updateElementXPathFromLabel(labelClassName);
        }

        private void buttonUseClassNameContains_Click(object sender, EventArgs e)
        {
            updateElementXPathFromLabel(labelClassNameContains);
        }

        private void buttonUseAttrName_Click(object sender, EventArgs e)
        {
            updateElementXPathFromLabel(labelAttrName);
        }

        private void buttonUseAttrValue_Click(object sender, EventArgs e)
        {
            updateElementXPathFromLabel(labelAttrValue);
        }

        private void buttonUseAttrValueContains_Click(object sender, EventArgs e)
        {
            updateElementXPathFromLabel(labelAttrValueContains);
        }

        private void buttonUseTextContains_Click(object sender, EventArgs e)
        {
            updateElementXPathFromLabel(labelTextContains);
        }

        private void buttonUseIndex_Click(object sender, EventArgs e)
        {
            updateElementXPathFromLabel(labelUseIndex);
        }

        private void updateElementXPathFromLabel(Label label)
        {
            textBoxXPath.Text = label.Text;

            // If text contains {name} or {value}, select it in the text box and change active window to the text box
            var textToReplace = new List<string>{
                "{name}", "{value}", "{index}", "{text}"
            };

            foreach (var text in textToReplace)
            {
                if (label.Text.Contains(text))
                {
                    textBoxXPath.Select(label.Text.IndexOf(text), text.Length);
                    textBoxXPath.Focus();
                    return;
                }
            }
        }

        private void buttonOpenUrl_Click(object sender, EventArgs e)
        {
            _webDriverHelper?.Quit();

            _webDriverHelper = new WebDriverHelper();

            try
            {
                _webDriverHelper.OpenInCurrentWindow(textBoxUrl.Text);
            }
            catch (Exception exception)
            {
                Globals.HandleException(exception, "Failed to open URL");
                return;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            _webDriverHelper?.Quit();
            _webDriverHelper = null;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            checkItem();
        }

        private void buttonAddXPath_Click(object sender, EventArgs e)
        {
            parametersChangingMutex.WaitOne();

            var bindingSource = (BindingSource)pathTable.DataSource;
            var bindingList = (SiteMonitorings.UI.SortableBindingList<PathInfo>)bindingSource.DataSource;
            bindingList.Add(new PathInfo { Path = textBoxXPath.Text });

            parametersChangingMutex.ReleaseMutex();
        }
    }

    static class Globals
    {
        public static void HandleException(Exception exception, string title, IWin32Window window = null)
        {
            MessageBox.Show(window, exception.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Console.Error.WriteLine(exception.ToString());
        }
    }
}
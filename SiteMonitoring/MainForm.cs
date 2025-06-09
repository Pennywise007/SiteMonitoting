using System;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using SiteMonitorings.Settings;
using SiteMonitorings.Worker;
using MetroFramework.Forms;
using SiteMonitoring;
using SiteMonitoring.Properties;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Timers;
using System.Threading;

namespace SiteMonitorings.UI
{
    public partial class MainForm : MetroForm
    {
        private ProgramSettings _settings = new ProgramSettings();

        System.Timers.Timer saveTimer = new System.Timers.Timer();
        Mutex parametersChangingMutex = new Mutex();

        private string _settingsFileName = "settings.xml";

        private readonly IMonitoringWorker _advertisementsWorker;
        private readonly IServiceProvider _serviceProvider;

        private IMonitoringWorker _testWorker;

        public MainForm(IMonitoringWorker worker, IServiceProvider serviceProvider)
        {
            saveTimer.Elapsed += new ElapsedEventHandler(OnSaveTimer);
            saveTimer.Interval = 1000 * 30;

            _serviceProvider = serviceProvider;
            _settingsFileName = System.AppDomain.CurrentDomain.FriendlyName;
            int pointIndex = _settingsFileName.LastIndexOf('.');
            if (pointIndex > -1)
            {
                _settingsFileName = _settingsFileName.Substring(0, pointIndex) + ".xml";
            }

            _advertisementsWorker = worker;

            InitializeComponent();

            WorkModeDetails.SetupWorkMode(ref WorkModeComboBox);

            SetCallbacks();

            PageSettings initialSettings = new PageSettings();
            initialSettings.Name = "Pararius";
            initialSettings.SiteLink = "https://www.pararius.com/apartments/rotterdam/district-rotterdam-centrum/0-2000";
            initialSettings.ListingsElementNameInList = "search-list__item search-list__item--listing";
            initialSettings.PathToList.Add(new ElementInfo { Type = ElementInfo.ElementType.Class, Name = "search-list" });
            initialSettings.ParametersList.Add(new Settings.ParameterInfo
            {
                Type = ElementInfo.ElementType.Link,
                ParameterName = "link",
                FullPath = "listing-search-item__link listing-search-item__link--depiction"
            });
            initialSettings.ParametersList.Add(new Settings.ParameterInfo {
                Type = ElementInfo.ElementType.Text,
                ParameterName = "area",
                FullPath = "illustrated-features__item illustrated-features__item--surface-area"
            });
            initialSettings.ParametersList.Add(new Settings.ParameterInfo {
                Type = ElementInfo.ElementType.Text,
                ParameterName = "price",
                FullPath = "listing-search-item__price"
            });
            _settings.pageSettings.Add(initialSettings);

            _settings.CommandLineOnNewElement = "TelegramNotifier.exe";
            _settings.CommandLineOnError = "TelegramNotifier.exe /error=";

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

            textBoxCommandPathOnFound.Text = _settings.CommandLineOnNewElement;
            textBoxCommandPathOnError.Text = _settings.CommandLineOnError;
            WorkModeComboBox.SelectedIndex = (int)_settings.WorkMode;

            foreach (var page in _settings.pageSettings)
            {
                AddPage(page);
            }
        }

        /// <summary>
        /// Initialize worker and add subscription to events
        /// </summary>
        private void SetCallbacks()
        {
            _advertisementsWorker.WhenFinish += OnFinish;
            _advertisementsWorker.WhenError += OnError;
            _advertisementsWorker.WhenFound += OnFound;
        }

#region WorkerEvents
        void EnableControls(bool onStart)
        {
            Invoke(new MethodInvoker(() =>
            {
                tabControl.Enabled = !onStart;
                buttonAddPage.Enabled = !onStart;
                buttonDeletePage.Enabled = !onStart;
                buttonRenamePage.Enabled = !onStart;
                buttonTestPage.Enabled = !onStart;

                WorkModeComboBox.Enabled = !onStart;
                textBoxCommandPathOnFound.Enabled = !onStart;
                textBoxCommandPathOnError.Enabled = !onStart;

                Run.Enabled = true;
                Run.Text = onStart ? "Отмена" : "Запустить";
            }));
        }

        private void OnFinish(object sender, string error)
        {
            if (!string.IsNullOrEmpty(error))
            {
                OnError(sender, error);
                return;
            }

            Invoke(new MethodInvoker(() =>
            {
                EnableControls(false);
            }));
        }

        private void OnError(object sender, string error)
        {
            Invoke(new MethodInvoker(() =>
            {
                try
                {
                    SetForeground();

                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WorkingDirectory = Application.StartupPath;
                    startInfo.FileName = _settings.CommandLineOnError;
                    startInfo.Arguments = error;
                    process.StartInfo = startInfo;
                    process.Start();
                }
                catch (Exception)
                { }
            }));
        }

        private void SetForeground()
        {
            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
            else
            {
                TopMost = true;
                Focus();
                BringToFront();
                TopMost = false;
            }
        }

        private void OnFound(object sender, ListingInfo parameters)
        {
            Invoke(new MethodInvoker(() =>
            {
                try
                {
                    saveTimer.Enabled = true;

                    string strCmdText = "";
                    foreach (var param in parameters.Parameters)
                    {
                        strCmdText += $"/{param.ParameterName}={param.Content} ";
                    }

                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WorkingDirectory = Application.StartupPath;
                    startInfo.FileName = _settings.CommandLineOnNewElement;
                    startInfo.Arguments = strCmdText;
                    process.StartInfo = startInfo;
                    process.Start();
                }
                catch (Exception exception)
                {
                    Globals.HandleException(exception, "Failed to send data");
                }
            }));
        }
        #endregion

        private void OnSaveTimer(object source, ElapsedEventArgs e)
        {
            saveTimer.Enabled = false;
            parametersChangingMutex.WaitOne();
            SaveSettings();
            parametersChangingMutex.ReleaseMutex();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            var currentWorker = _testWorker ?? _advertisementsWorker;
            if (currentWorker.IsWorking())
            {
                Run.Enabled = false;
                Run.Text = "Прерываем...";

                currentWorker.Interrupt();
                return;
            }

            GetSettings();

            EnableControls(true);
            _advertisementsWorker.Start(_settings.pageSettings, parametersChangingMutex, _settings.WorkMode);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _advertisementsWorker.Interrupt();
            saveTimer.Enabled = false;

            SaveSettings();
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
            _settings.WorkMode = (WorkModeComboBox.SelectedItem as WorkModeDetails).Mode;
            foreach (var control in tabControl.TabPages)
            {
                if (control is Control ctrl)
                {
                    foreach (var pageControl in ctrl.Controls)
                    {
                        if (pageControl is SiteInformation site)
                        {
                            site.StoreSettings(control as TabPage);
                            break;
                        }
                    }
                }
            }
            _settings.CommandLineOnNewElement = textBoxCommandPathOnFound.Text;
            _settings.CommandLineOnError = textBoxCommandPathOnError.Text;
        }

        private void AddPage(PageSettings settings)
        {
            var tabPage = new MetroFramework.Controls.MetroTabPage();

            tabControl.Controls.Add(tabPage);

            SiteInformation page = new SiteInformation(settings, tabPage)
            {
                TopLevel = false,
                Parent = tabControl.TabPages[tabControl.TabPages.Count - 1],
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                Visible = true,
                MaximizeBox = false,
                MinimizeBox = false,
                ControlBox = false
            };
            page.BringToFront();
        }

        private void buttonAddPage_Click(object sender, EventArgs e)
        {
            var newPage = new PageSettings();

            Rename renameDialog = new Rename("", "Имя вкладки");
            newPage.Name = renameDialog.Execute();

            _settings.pageSettings.Add(newPage);
            AddPage(_settings.pageSettings.Last());
        }

        private void buttonDeletePage_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == -1)
            {
                MessageBox.Show("Can't delete tab", "No tabs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _settings.pageSettings.Remove(_settings.pageSettings[tabControl.SelectedIndex]);
            tabControl.Controls.Remove(tabControl.Controls[tabControl.SelectedIndex]);
        }

        private void buttonRenamePage_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == -1)
            {
                MessageBox.Show("Can't rename tab", "No tabs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Rename renameDialog = new Rename(tabControl.TabPages[tabControl.SelectedIndex].Text);
            tabControl.TabPages[tabControl.SelectedIndex].Text = renameDialog.Execute();
        }

        private void buttonTestPage_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == -1)
            {
                MessageBox.Show("Can't test tab", "No tabs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var activePage = tabControl.TabPages[tabControl.SelectedIndex];

            PageSettings settings = null;
            foreach (var pageControl in activePage.Controls)
            {
                if (pageControl is SiteInformation site)
                {
                    site.StoreSettings(activePage);

                    BinaryFormatter s = new BinaryFormatter();
                    using (MemoryStream ms = new MemoryStream())
                    {
                        s.Serialize(ms, site.CurrentSettings);
                        ms.Position = 0;
                        settings = (PageSettings)s.Deserialize(ms);
                        settings.AlreadySendedListings.Clear();
                    }
                    break;
                }
            }

            if (settings == null)
            {
                MessageBox.Show(this, "Can not find current page settings", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _testWorker = _serviceProvider.GetRequiredService<IMonitoringWorker>();

            string result = "";
            _testWorker.WhenFinish += (object s, string error) =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    _testWorker = null;
                    EnableControls(false);
                    if (!string.IsNullOrEmpty(error))
                        MessageBox.Show(this, error, "Выполнено, но во время работы возникли ошибки", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        MessageBox.Show(this, result, "Результат теста", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            };
            _testWorker.WhenError += (object s, string error) =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    MessageBox.Show(this, error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            };
            _testWorker.WhenFound += (object s, ListingInfo info) =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    foreach (var par in info.Parameters)
                    {
                        result += $"{par.ParameterName}: {par.Content}\n";
                    }
                    result += "\n\n";
                }));
            };
            EnableControls(true);

            _testWorker.Start(new System.Collections.Generic.List<PageSettings>
            {
                settings
            }, new Mutex(), WorkMode.eTestMode);
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
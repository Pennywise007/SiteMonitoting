using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiteMonitorings.Settings;
using SiteMonitoring.Properties;
using SiteMonitorings.UI;

namespace SiteMonitoring
{
    public partial class SiteInformation : MetroForm
    {
        public PageSettings CurrentSettings;

        public SiteInformation(PageSettings settings, MetroFramework.Controls.MetroTabPage parent)
        {
            InitializeComponent();

            CurrentSettings = settings;

            textBoxSiteLink.Text = CurrentSettings.SiteLink;
            textBoxListElementName.Text = CurrentSettings.ListingsElementNameInList;

            PathToList.DataSource = new BindingSource
            {
                DataSource = new SortableBindingList<ElementInfo>(CurrentSettings.PathToList),
                AllowNew = true
            };

            ParametersTable.DataSource = new BindingSource
            {
                DataSource = new SortableBindingList<ParameterInfo>(CurrentSettings.ParametersList),
                AllowNew = true
            };

            parent.Text = CurrentSettings.Name == "" ? "__" : CurrentSettings.Name;

            ListPathInfoDetails.SetupElementTypes(ref typeDataGridViewTextBoxColumn1, true);
            ListPathInfoDetails.SetupElementTypes(ref typeDataGridViewTextBoxColumn, false);
        }

        public void StoreSettings(TabPage ctrl)
        {
            CurrentSettings.SiteLink = textBoxSiteLink.Text;
            CurrentSettings.ListingsElementNameInList = textBoxListElementName.Text;
            CurrentSettings.Name = ctrl.Text;
        }

        private void buttonExecuteScript_CheckedChanged(object sender, EventArgs e)
        {
            ScriptExecution executionDialog = new ScriptExecution(CurrentSettings.ExecutionInfo);
            executionDialog.Execute(Control.FromHandle(this.Handle));
        }
    }
}

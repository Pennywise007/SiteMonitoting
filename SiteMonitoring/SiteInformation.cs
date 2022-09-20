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
        public PageSettings CurerntSettings;

        public SiteInformation(PageSettings settings, MetroFramework.Controls.MetroTabPage parent)
        {
            InitializeComponent();

            CurerntSettings = settings;

            textBoxSiteLink.Text = CurerntSettings.SiteLink;
            textBoxListElementName.Text = CurerntSettings.ListingsElementNameInList;

            PathToList.DataSource = new BindingSource
            {
                DataSource = new SortableBindingList<ElementInfo>(CurerntSettings.PathToList),
                AllowNew = true
            };

            ParametersTable.DataSource = new BindingSource
            {
                DataSource = new SortableBindingList<ParameterInfo>(CurerntSettings.ParametersList),
                AllowNew = true
            };

            parent.Text = CurerntSettings.Name;

            ListPathInfoDetails.SetupElementTypes(ref typeDataGridViewTextBoxColumn1, true);
            ListPathInfoDetails.SetupElementTypes(ref typeDataGridViewTextBoxColumn, false);
        }

        public void StoreSettings(TabPage ctrl)
        {
            CurerntSettings.SiteLink = textBoxSiteLink.Text;
            CurerntSettings.ListingsElementNameInList = textBoxListElementName.Text;
            CurerntSettings.Name = ctrl.Text;
        }
    }
}

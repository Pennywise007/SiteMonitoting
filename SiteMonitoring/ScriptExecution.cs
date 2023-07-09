using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiteMonitorings.Settings;
using System.Security.Cryptography;
using MetroFramework.Controls;
using System.Runtime.InteropServices;
using static SiteMonitorings.Settings.ExecutionInfo;

namespace SiteMonitoring
{
    public partial class ScriptExecution : MetroForm
    {
        private List<ExecutionInfo> _parameters;
        public ScriptExecution(List<ExecutionInfo> parameters)
        {
            _parameters = parameters;
            InitializeComponent();

            foreach (var item in _parameters)
            {
                // Add the row to the MetroGrid
                var raw = Table.Rows.Add();
                Table.Rows[raw].Cells[0].Value = item.path;
                Table.Rows[raw].Cells[1].Value = _executionTypes[item.action];
                Table.Rows[raw].Cells[2].Value = item.value;
            }
        }

        public void Execute(IWin32Window owner)
        {
            ShowDialog(owner);
        }

        private void metroButtonOk_Click(object sender, EventArgs e)
        {
            _parameters.Clear();

            for (var i = 0; i < Table.Rows.Count - 1; i++)
            {
                var raw = Table.Rows[i];
                ExecutionInfo info = new ExecutionInfo
                {
                    path = raw.Cells[0].Value as string,
                    action = GetKeyByValue(_executionTypes, raw.Cells[1].Value as string),
                    value = raw.Cells[2].Value as string,
                };
                _parameters.Add(info);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public static TKey GetKeyByValue<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TValue value)
        {
            return dictionary.FirstOrDefault(x => x.Value.Equals(value)).Key;
        }

        readonly Dictionary<ExecutionType, string> _executionTypes = new Dictionary<ExecutionType, string>
        {
            { ExecutionType.eClick, "Click" },
            { ExecutionType.eEnterText, "Enter text" },
            { ExecutionType.eWait, "Wait(sec)" },
            { ExecutionType.eInterruptIfExistAndText, "Interrupt if item exist and text equal" },
            { ExecutionType.eInterruptIfNotExistOrTextNotEqual, "Interrupt if item not exist or text not equal" },
        };
    }
}

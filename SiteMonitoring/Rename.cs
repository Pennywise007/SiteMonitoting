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

namespace SiteMonitoring
{
    public partial class Rename : MetroForm
    {
        readonly string _initialName;
        string _finalName;
        public Rename(string currentName, string title = null)
        {
            InitializeComponent();

            _initialName = currentName;
            textBox.Text = currentName;

            if (!string.IsNullOrEmpty(title))
                this.Text = title;
        }

        public string Execute()
        {
            ShowDialog();
            return _finalName;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            _finalName = textBox.Text;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            _finalName = _initialName;
            Close();
        }

        private void Rename_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonOk_Click(sender, e);
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonOk_Click(sender, e);
        }
    }
}

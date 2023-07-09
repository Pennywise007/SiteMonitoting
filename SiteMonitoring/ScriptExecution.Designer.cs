using static System.Net.Mime.MediaTypeNames;

namespace SiteMonitoring
{
    partial class ScriptExecution
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.metroButtonOk = new MetroFramework.Controls.MetroButton();
            this.Table = new MetroFramework.Controls.MetroGrid();
            this.FullPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButtonCancel.Location = new System.Drawing.Point(349, 401);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(139, 43);
            this.metroButtonCancel.TabIndex = 0;
            this.metroButtonCancel.Text = "Cancel";
            this.metroButtonCancel.UseSelectable = true;
            // 
            // metroButtonOk
            // 
            this.metroButtonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroButtonOk.Location = new System.Drawing.Point(116, 401);
            this.metroButtonOk.Name = "metroButtonOk";
            this.metroButtonOk.Size = new System.Drawing.Size(139, 43);
            this.metroButtonOk.TabIndex = 1;
            this.metroButtonOk.Text = "Ok";
            this.metroButtonOk.UseSelectable = true;
            this.metroButtonOk.Click += new System.EventHandler(this.metroButtonOk_Click);
            // 
            // Table
            // 
            this.Table.AllowUserToOrderColumns = true;
            this.Table.AllowUserToResizeRows = false;
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table.BackgroundColor = System.Drawing.Color.White;
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullPath,
            this.Action,
            this.Value});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle5;
            this.Table.EnableHeadersVisualStyles = false;
            this.Table.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Table.GridColor = System.Drawing.Color.White;
            this.Table.Location = new System.Drawing.Point(12, 63);
            this.Table.Name = "Table";
            this.Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Table.RowHeadersWidth = 62;
            this.Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Table.Size = new System.Drawing.Size(573, 318);
            this.Table.TabIndex = 16;
            // 
            // FullPath
            // 
            this.FullPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullPath.DataPropertyName = "FullPath";
            this.FullPath.FillWeight = 111.9289F;
            this.FullPath.HeaderText = "Полный путь к элементу (для точности можно указать через-> или использовать * есл" +
    "и нужен параметр самого листинга)";
            this.FullPath.MinimumWidth = 8;
            this.FullPath.Name = "FullPath";
            // 
            // ParameterName
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Action.DataPropertyName = "Action";
            this.Action.FillWeight = 76.14214F;
            this.Action.HeaderText = "Action";
            this.Action.Items.AddRange(new object[] {
            "Click",
            "Enter text",
            "Wait(sec)",
            "Interrupt if item exist and text equal",
            "Interrupt if item not exist or text not equal" });
            this.Action.DefaultCellStyle.NullValue = this.Action.Items[0];
            this.Action.MinimumWidth = 8;
            this.Action.Name = "ParameterName";
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Action.Width = 80;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Value.FillWeight = 111.9289F;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Width = 120;
            // 
            // ScriptExecution
            // 
            this.AcceptButton = this.metroButtonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.metroButtonCancel;
            this.ClientSize = new System.Drawing.Size(596, 467);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.metroButtonOk);
            this.Controls.Add(this.metroButtonCancel);
            this.Name = "ScriptExecution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Script execution settings";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private MetroFramework.Controls.MetroButton metroButtonOk;
        private MetroFramework.Controls.MetroGrid Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullPath;
        private System.Windows.Forms.DataGridViewComboBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}
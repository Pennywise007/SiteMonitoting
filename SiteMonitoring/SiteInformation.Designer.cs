namespace SiteMonitoring
{
    partial class SiteInformation
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PathToList = new MetroFramework.Controls.MetroGrid();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PathToListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSiteLink = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.labelListPath = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.textBoxListElementName = new MetroFramework.Controls.MetroTextBox();
            this.ParametersTable = new MetroFramework.Controls.MetroGrid();
            this.ParametersListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelParameters = new MetroFramework.Controls.MetroLabel();
            this.buttonExecuteScript = new System.Windows.Forms.CheckBox();
            this.FullPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ParameterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PathToList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PathToListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametersListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PathToList
            // 
            this.PathToList.AllowUserToOrderColumns = true;
            this.PathToList.AllowUserToResizeRows = false;
            this.PathToList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathToList.AutoGenerateColumns = false;
            this.PathToList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PathToList.BackgroundColor = System.Drawing.Color.White;
            this.PathToList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PathToList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PathToList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PathToList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.PathToList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PathToList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.typeDataGridViewTextBoxColumn1});
            this.PathToList.DataSource = this.PathToListBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PathToList.DefaultCellStyle = dataGridViewCellStyle14;
            this.PathToList.EnableHeadersVisualStyles = false;
            this.PathToList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PathToList.GridColor = System.Drawing.Color.White;
            this.PathToList.Location = new System.Drawing.Point(1, 58);
            this.PathToList.Margin = new System.Windows.Forms.Padding(2);
            this.PathToList.Name = "PathToList";
            this.PathToList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PathToList.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.PathToList.RowHeadersWidth = 62;
            this.PathToList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PathToList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PathToList.Size = new System.Drawing.Size(856, 89);
            this.PathToList.TabIndex = 0;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Имя";
            this.ColumnName.MinimumWidth = 8;
            this.ColumnName.Name = "ColumnName";
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "Тип элемента";
            this.typeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            this.typeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PathToListBindingSource
            // 
            this.PathToListBindingSource.DataSource = typeof(SiteMonitorings.Settings.ElementInfo);
            // 
            // textBoxSiteLink
            // 
            this.textBoxSiteLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxSiteLink.CustomButton.Image = null;
            this.textBoxSiteLink.CustomButton.Location = new System.Drawing.Point(527, 2);
            this.textBoxSiteLink.CustomButton.Name = "";
            this.textBoxSiteLink.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textBoxSiteLink.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxSiteLink.CustomButton.TabIndex = 1;
            this.textBoxSiteLink.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxSiteLink.CustomButton.UseSelectable = true;
            this.textBoxSiteLink.CustomButton.Visible = false;
            this.textBoxSiteLink.Lines = new string[0];
            this.textBoxSiteLink.Location = new System.Drawing.Point(129, 14);
            this.textBoxSiteLink.MaxLength = 32767;
            this.textBoxSiteLink.Name = "textBoxSiteLink";
            this.textBoxSiteLink.PasswordChar = '\0';
            this.textBoxSiteLink.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSiteLink.SelectedText = "";
            this.textBoxSiteLink.SelectionLength = 0;
            this.textBoxSiteLink.SelectionStart = 0;
            this.textBoxSiteLink.ShortcutsEnabled = true;
            this.textBoxSiteLink.Size = new System.Drawing.Size(545, 20);
            this.textBoxSiteLink.TabIndex = 10;
            this.textBoxSiteLink.UseSelectable = true;
            this.textBoxSiteLink.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxSiteLink.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ссылка на сайт";
            // 
            // labelListPath
            // 
            this.labelListPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelListPath.AutoSize = true;
            this.labelListPath.Location = new System.Drawing.Point(333, 37);
            this.labelListPath.Name = "labelListPath";
            this.labelListPath.Size = new System.Drawing.Size(177, 19);
            this.labelListPath.TabIndex = 12;
            this.labelListPath.Text = "Путь к элементу со списком";
            this.labelListPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Имя класса каждого элемента в списке(Class name or XPath)";
            // 
            // textBoxListElementName
            // 
            this.textBoxListElementName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxListElementName.CustomButton.Image = null;
            this.textBoxListElementName.CustomButton.Location = new System.Drawing.Point(580, 2);
            this.textBoxListElementName.CustomButton.Name = "";
            this.textBoxListElementName.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textBoxListElementName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxListElementName.CustomButton.TabIndex = 1;
            this.textBoxListElementName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxListElementName.CustomButton.UseSelectable = true;
            this.textBoxListElementName.CustomButton.Visible = false;
            this.textBoxListElementName.Lines = new string[0];
            this.textBoxListElementName.Location = new System.Drawing.Point(381, 152);
            this.textBoxListElementName.MaxLength = 32767;
            this.textBoxListElementName.Name = "textBoxListElementName";
            this.textBoxListElementName.PasswordChar = '\0';
            this.textBoxListElementName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxListElementName.SelectedText = "";
            this.textBoxListElementName.SelectionLength = 0;
            this.textBoxListElementName.SelectionStart = 0;
            this.textBoxListElementName.ShortcutsEnabled = true;
            this.textBoxListElementName.Size = new System.Drawing.Size(477, 20);
            this.textBoxListElementName.TabIndex = 14;
            this.textBoxListElementName.UseSelectable = true;
            this.textBoxListElementName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxListElementName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ParametersTable
            // 
            this.ParametersTable.AllowUserToOrderColumns = true;
            this.ParametersTable.AllowUserToResizeRows = false;
            this.ParametersTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParametersTable.AutoGenerateColumns = false;
            this.ParametersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ParametersTable.BackgroundColor = System.Drawing.Color.White;
            this.ParametersTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ParametersTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ParametersTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParametersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.ParametersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParametersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullPath,
            this.typeDataGridViewTextBoxColumn,
            this.ParameterName});
            this.ParametersTable.DataSource = this.ParametersListBindingSource;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ParametersTable.DefaultCellStyle = dataGridViewCellStyle17;
            this.ParametersTable.EnableHeadersVisualStyles = false;
            this.ParametersTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParametersTable.GridColor = System.Drawing.Color.White;
            this.ParametersTable.Location = new System.Drawing.Point(1, 200);
            this.ParametersTable.Name = "ParametersTable";
            this.ParametersTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParametersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.ParametersTable.RowHeadersWidth = 62;
            this.ParametersTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ParametersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ParametersTable.Size = new System.Drawing.Size(856, 121);
            this.ParametersTable.TabIndex = 15;
            // 
            // ParametersListBindingSource
            // 
            this.ParametersListBindingSource.DataSource = typeof(SiteMonitorings.Settings.ParameterInfo);
            // 
            // labelParameters
            // 
            this.labelParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelParameters.AutoSize = true;
            this.labelParameters.Location = new System.Drawing.Point(297, 175);
            this.labelParameters.Name = "labelParameters";
            this.labelParameters.Size = new System.Drawing.Size(268, 19);
            this.labelParameters.TabIndex = 16;
            this.labelParameters.Text = "Список путей и параметров для отправки";
            this.labelParameters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExecuteScript
            // 
            this.buttonExecuteScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExecuteScript.Appearance = System.Windows.Forms.Appearance.Button;
            this.buttonExecuteScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonExecuteScript.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonExecuteScript.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExecuteScript.Location = new System.Drawing.Point(678, 11);
            this.buttonExecuteScript.Margin = new System.Windows.Forms.Padding(1);
            this.buttonExecuteScript.Name = "buttonExecuteScript";
            this.buttonExecuteScript.Size = new System.Drawing.Size(179, 26);
            this.buttonExecuteScript.TabIndex = 17;
            this.buttonExecuteScript.Text = "Execute script on open";
            this.buttonExecuteScript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonExecuteScript.UseVisualStyleBackColor = false;
            this.buttonExecuteScript.CheckedChanged += new System.EventHandler(this.buttonExecuteScript_CheckedChanged);
            // 
            // FullPath
            // 
            this.FullPath.DataPropertyName = "FullPath";
            this.FullPath.HeaderText = "Полный путь к элементу (для точности можно указать через-> или использовать * есл" +
    "и нужен параметр самого листинга). If starts with \".//\" \"//\" or XPath will be us" +
    "ed, ClassNameContains otherwise";
            this.FullPath.MinimumWidth = 8;
            this.FullPath.Name = "FullPath";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип элемента";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeDataGridViewTextBoxColumn.Width = 120;
            // 
            // ParameterName
            // 
            this.ParameterName.DataPropertyName = "ParameterName";
            this.ParameterName.HeaderText = "Имя элемента";
            this.ParameterName.MinimumWidth = 8;
            this.ParameterName.Name = "ParameterName";
            // 
            // SiteInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 323);
            this.Controls.Add(this.buttonExecuteScript);
            this.Controls.Add(this.labelParameters);
            this.Controls.Add(this.ParametersTable);
            this.Controls.Add(this.textBoxListElementName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelListPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSiteLink);
            this.Controls.Add(this.PathToList);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Movable = false;
            this.Name = "SiteInformation";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            ((System.ComponentModel.ISupportInitialize)(this.PathToList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PathToListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametersListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid PathToList;
        private System.Windows.Forms.BindingSource PathToListBindingSource;
        private MetroFramework.Controls.MetroTextBox textBoxSiteLink;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel labelListPath;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroTextBox textBoxListElementName;
        private MetroFramework.Controls.MetroGrid ParametersTable;
        private MetroFramework.Controls.MetroLabel labelParameters;
        private System.Windows.Forms.BindingSource ParametersListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.CheckBox buttonExecuteScript;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullPath;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterName;
    }
}
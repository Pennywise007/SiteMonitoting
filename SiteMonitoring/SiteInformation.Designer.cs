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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PathToList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PathToList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PathToList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.typeDataGridViewTextBoxColumn1});
            this.PathToList.DataSource = this.PathToListBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PathToList.DefaultCellStyle = dataGridViewCellStyle2;
            this.PathToList.EnableHeadersVisualStyles = false;
            this.PathToList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PathToList.GridColor = System.Drawing.Color.White;
            this.PathToList.Location = new System.Drawing.Point(2, 91);
            this.PathToList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PathToList.Name = "PathToList";
            this.PathToList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PathToList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PathToList.RowHeadersWidth = 62;
            this.PathToList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PathToList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PathToList.Size = new System.Drawing.Size(1284, 134);
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
            this.textBoxSiteLink.CustomButton.Location = new System.Drawing.Point(1596, 2);
            this.textBoxSiteLink.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSiteLink.CustomButton.Name = "";
            this.textBoxSiteLink.CustomButton.Size = new System.Drawing.Size(44, 45);
            this.textBoxSiteLink.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxSiteLink.CustomButton.TabIndex = 1;
            this.textBoxSiteLink.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxSiteLink.CustomButton.UseSelectable = true;
            this.textBoxSiteLink.CustomButton.Visible = false;
            this.textBoxSiteLink.Lines = new string[0];
            this.textBoxSiteLink.Location = new System.Drawing.Point(194, 22);
            this.textBoxSiteLink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSiteLink.MaxLength = 32767;
            this.textBoxSiteLink.Name = "textBoxSiteLink";
            this.textBoxSiteLink.PasswordChar = '\0';
            this.textBoxSiteLink.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSiteLink.SelectedText = "";
            this.textBoxSiteLink.SelectionLength = 0;
            this.textBoxSiteLink.SelectionStart = 0;
            this.textBoxSiteLink.ShortcutsEnabled = true;
            this.textBoxSiteLink.Size = new System.Drawing.Size(1094, 31);
            this.textBoxSiteLink.TabIndex = 10;
            this.textBoxSiteLink.UseSelectable = true;
            this.textBoxSiteLink.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxSiteLink.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.labelListPath.Location = new System.Drawing.Point(500, 57);
            this.labelListPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListPath.Name = "labelListPath";
            this.labelListPath.Size = new System.Drawing.Size(177, 19);
            this.labelListPath.TabIndex = 12;
            this.labelListPath.Text = "Путь к элементу со списком";
            this.labelListPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Имя класса каждого элемента в списке";
            // 
            // textBoxListElementName
            // 
            this.textBoxListElementName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxListElementName.CustomButton.Image = null;
            this.textBoxListElementName.CustomButton.Location = new System.Drawing.Point(1300, 2);
            this.textBoxListElementName.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxListElementName.CustomButton.Name = "";
            this.textBoxListElementName.CustomButton.Size = new System.Drawing.Size(44, 45);
            this.textBoxListElementName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxListElementName.CustomButton.TabIndex = 1;
            this.textBoxListElementName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxListElementName.CustomButton.UseSelectable = true;
            this.textBoxListElementName.CustomButton.Visible = false;
            this.textBoxListElementName.Lines = new string[0];
            this.textBoxListElementName.Location = new System.Drawing.Point(390, 234);
            this.textBoxListElementName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxListElementName.MaxLength = 32767;
            this.textBoxListElementName.Name = "textBoxListElementName";
            this.textBoxListElementName.PasswordChar = '\0';
            this.textBoxListElementName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxListElementName.SelectedText = "";
            this.textBoxListElementName.SelectionLength = 0;
            this.textBoxListElementName.SelectionStart = 0;
            this.textBoxListElementName.ShortcutsEnabled = true;
            this.textBoxListElementName.Size = new System.Drawing.Size(897, 31);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParametersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ParametersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParametersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullPath,
            this.typeDataGridViewTextBoxColumn,
            this.ParameterName});
            this.ParametersTable.DataSource = this.ParametersListBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ParametersTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.ParametersTable.EnableHeadersVisualStyles = false;
            this.ParametersTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParametersTable.GridColor = System.Drawing.Color.White;
            this.ParametersTable.Location = new System.Drawing.Point(2, 308);
            this.ParametersTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ParametersTable.Name = "ParametersTable";
            this.ParametersTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParametersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ParametersTable.RowHeadersWidth = 62;
            this.ParametersTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ParametersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ParametersTable.Size = new System.Drawing.Size(1284, 186);
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
            this.labelParameters.Location = new System.Drawing.Point(446, 269);
            this.labelParameters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelParameters.Name = "labelParameters";
            this.labelParameters.Size = new System.Drawing.Size(268, 19);
            this.labelParameters.TabIndex = 16;
            this.labelParameters.Text = "Список путей и параметров для отправки";
            this.labelParameters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FullPath
            // 
            this.FullPath.DataPropertyName = "FullPath";
            this.FullPath.HeaderText = "Полный путь к элементу (для точности можно указать через-> или использовать * есл" +
    "и нужен параметр самого листинга)";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 497);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Movable = false;
            this.Name = "SiteInformation";
            this.Padding = new System.Windows.Forms.Padding(30, 46, 30, 31);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn FullPath;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterName;
    }
}
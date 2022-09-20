namespace SiteMonitorings.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Run = new MetroFramework.Controls.MetroButton();
            this.WorkModeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.WorkModeLabel = new MetroFramework.Controls.MetroLabel();
            this.textBoxCommandPathOnFound = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.textBoxCommandPathOnError = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.buttonAddPage = new System.Windows.Forms.Button();
            this.buttonDeletePage = new System.Windows.Forms.Button();
            this.buttonRenamePage = new System.Windows.Forms.Button();
            this.buttonTestPage = new System.Windows.Forms.Button();
            this.PathToListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ParametersListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PathToListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametersListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Run.Location = new System.Drawing.Point(670, 708);
            this.Run.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(598, 45);
            this.Run.TabIndex = 4;
            this.Run.Text = "Запустить";
            this.Run.UseSelectable = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // WorkModeComboBox
            // 
            this.WorkModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkModeComboBox.FormattingEnabled = true;
            this.WorkModeComboBox.ItemHeight = 23;
            this.WorkModeComboBox.Location = new System.Drawing.Point(171, 708);
            this.WorkModeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WorkModeComboBox.Name = "WorkModeComboBox";
            this.WorkModeComboBox.Size = new System.Drawing.Size(466, 29);
            this.WorkModeComboBox.TabIndex = 5;
            this.WorkModeComboBox.UseSelectable = true;
            // 
            // WorkModeLabel
            // 
            this.WorkModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WorkModeLabel.AutoSize = true;
            this.WorkModeLabel.Location = new System.Drawing.Point(14, 717);
            this.WorkModeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WorkModeLabel.Name = "WorkModeLabel";
            this.WorkModeLabel.Size = new System.Drawing.Size(99, 19);
            this.WorkModeLabel.TabIndex = 6;
            this.WorkModeLabel.Text = "Режим работы";
            // 
            // textBoxCommandPathOnFound
            // 
            this.textBoxCommandPathOnFound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxCommandPathOnFound.CustomButton.Image = null;
            this.textBoxCommandPathOnFound.CustomButton.Location = new System.Drawing.Point(1202, 2);
            this.textBoxCommandPathOnFound.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCommandPathOnFound.CustomButton.Name = "";
            this.textBoxCommandPathOnFound.CustomButton.Size = new System.Drawing.Size(44, 45);
            this.textBoxCommandPathOnFound.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxCommandPathOnFound.CustomButton.TabIndex = 1;
            this.textBoxCommandPathOnFound.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxCommandPathOnFound.CustomButton.UseSelectable = true;
            this.textBoxCommandPathOnFound.CustomButton.Visible = false;
            this.textBoxCommandPathOnFound.Lines = new string[0];
            this.textBoxCommandPathOnFound.Location = new System.Drawing.Point(438, 622);
            this.textBoxCommandPathOnFound.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCommandPathOnFound.MaxLength = 32767;
            this.textBoxCommandPathOnFound.Name = "textBoxCommandPathOnFound";
            this.textBoxCommandPathOnFound.PasswordChar = '\0';
            this.textBoxCommandPathOnFound.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxCommandPathOnFound.SelectedText = "";
            this.textBoxCommandPathOnFound.SelectionLength = 0;
            this.textBoxCommandPathOnFound.SelectionStart = 0;
            this.textBoxCommandPathOnFound.ShortcutsEnabled = true;
            this.textBoxCommandPathOnFound.Size = new System.Drawing.Size(831, 31);
            this.textBoxCommandPathOnFound.TabIndex = 18;
            this.textBoxCommandPathOnFound.UseSelectable = true;
            this.textBoxCommandPathOnFound.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxCommandPathOnFound.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 622);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Комадная строка для отправки параметров";
            // 
            // textBoxCommandPathOnError
            // 
            this.textBoxCommandPathOnError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxCommandPathOnError.CustomButton.Image = null;
            this.textBoxCommandPathOnError.CustomButton.Location = new System.Drawing.Point(1202, 2);
            this.textBoxCommandPathOnError.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCommandPathOnError.CustomButton.Name = "";
            this.textBoxCommandPathOnError.CustomButton.Size = new System.Drawing.Size(44, 45);
            this.textBoxCommandPathOnError.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxCommandPathOnError.CustomButton.TabIndex = 1;
            this.textBoxCommandPathOnError.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxCommandPathOnError.CustomButton.UseSelectable = true;
            this.textBoxCommandPathOnError.CustomButton.Visible = false;
            this.textBoxCommandPathOnError.Lines = new string[0];
            this.textBoxCommandPathOnError.Location = new System.Drawing.Point(438, 668);
            this.textBoxCommandPathOnError.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCommandPathOnError.MaxLength = 32767;
            this.textBoxCommandPathOnError.Name = "textBoxCommandPathOnError";
            this.textBoxCommandPathOnError.PasswordChar = '\0';
            this.textBoxCommandPathOnError.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxCommandPathOnError.SelectedText = "";
            this.textBoxCommandPathOnError.SelectionLength = 0;
            this.textBoxCommandPathOnError.SelectionStart = 0;
            this.textBoxCommandPathOnError.ShortcutsEnabled = true;
            this.textBoxCommandPathOnError.Size = new System.Drawing.Size(831, 31);
            this.textBoxCommandPathOnError.TabIndex = 20;
            this.textBoxCommandPathOnError.UseSelectable = true;
            this.textBoxCommandPathOnError.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxCommandPathOnError.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 668);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Командная строка для отправки ошибки";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Location = new System.Drawing.Point(14, 126);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(1256, 486);
            this.tabControl.Style = MetroFramework.MetroColorStyle.Green;
            this.tabControl.TabIndex = 21;
            this.tabControl.UseSelectable = true;
            // 
            // buttonAddPage
            // 
            this.buttonAddPage.Location = new System.Drawing.Point(14, 82);
            this.buttonAddPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddPage.Name = "buttonAddPage";
            this.buttonAddPage.Size = new System.Drawing.Size(279, 35);
            this.buttonAddPage.TabIndex = 22;
            this.buttonAddPage.Text = "Добавить страницу";
            this.buttonAddPage.UseVisualStyleBackColor = true;
            this.buttonAddPage.Click += new System.EventHandler(this.buttonAddPage_Click);
            // 
            // buttonDeletePage
            // 
            this.buttonDeletePage.Location = new System.Drawing.Point(302, 82);
            this.buttonDeletePage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeletePage.Name = "buttonDeletePage";
            this.buttonDeletePage.Size = new System.Drawing.Size(279, 35);
            this.buttonDeletePage.TabIndex = 23;
            this.buttonDeletePage.Text = "Удалить страницу";
            this.buttonDeletePage.UseVisualStyleBackColor = true;
            this.buttonDeletePage.Click += new System.EventHandler(this.buttonDeletePage_Click);
            // 
            // buttonRenamePage
            // 
            this.buttonRenamePage.Location = new System.Drawing.Point(590, 82);
            this.buttonRenamePage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRenamePage.Name = "buttonRenamePage";
            this.buttonRenamePage.Size = new System.Drawing.Size(279, 35);
            this.buttonRenamePage.TabIndex = 24;
            this.buttonRenamePage.Text = "Переименовать страницу";
            this.buttonRenamePage.UseVisualStyleBackColor = true;
            this.buttonRenamePage.Click += new System.EventHandler(this.buttonRenamePage_Click);
            // 
            // buttonTestPage
            // 
            this.buttonTestPage.Location = new System.Drawing.Point(878, 82);
            this.buttonTestPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTestPage.Name = "buttonTestPage";
            this.buttonTestPage.Size = new System.Drawing.Size(279, 35);
            this.buttonTestPage.TabIndex = 25;
            this.buttonTestPage.Text = "Проверить страницу";
            this.buttonTestPage.UseVisualStyleBackColor = true;
            this.buttonTestPage.Click += new System.EventHandler(this.buttonTestPage_Click);
            // 
            // PathToListBindingSource
            // 
            this.PathToListBindingSource.DataSource = typeof(SiteMonitorings.Settings.ElementInfo);
            // 
            // ParametersListBindingSource
            // 
            this.ParametersListBindingSource.DataSource = typeof(SiteMonitorings.Settings.ParameterInfo);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 788);
            this.Controls.Add(this.buttonTestPage);
            this.Controls.Add(this.buttonRenamePage);
            this.Controls.Add(this.buttonDeletePage);
            this.Controls.Add(this.buttonAddPage);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.textBoxCommandPathOnError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCommandPathOnFound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WorkModeLabel);
            this.Controls.Add(this.WorkModeComboBox);
            this.Controls.Add(this.Run);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Мониторинг изменений на сайте";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PathToListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametersListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton Run;
        private System.Windows.Forms.BindingSource PathToListBindingSource;
        private MetroFramework.Controls.MetroComboBox WorkModeComboBox;
        private MetroFramework.Controls.MetroLabel WorkModeLabel;
        private MetroFramework.Controls.MetroTextBox textBoxCommandPathOnFound;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroTextBox textBoxCommandPathOnError;
        private MetroFramework.Controls.MetroLabel label4;
        private System.Windows.Forms.BindingSource ParametersListBindingSource;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private System.Windows.Forms.Button buttonAddPage;
        private System.Windows.Forms.Button buttonDeletePage;
        private System.Windows.Forms.Button buttonRenamePage;
        private System.Windows.Forms.Button buttonTestPage;
    }
}


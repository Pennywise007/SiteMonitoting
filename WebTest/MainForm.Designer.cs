namespace WebTest.UI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonOpenUrl = new MetroFramework.Controls.MetroButton();
            this.buttonClose = new MetroFramework.Controls.MetroButton();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.pathTable = new MetroFramework.Controls.MetroGrid();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.labelClassName = new MetroFramework.Controls.MetroLabel();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.labelClassNameContains = new MetroFramework.Controls.MetroLabel();
            this.label7 = new MetroFramework.Controls.MetroLabel();
            this.labelAttrName = new MetroFramework.Controls.MetroLabel();
            this.label9 = new MetroFramework.Controls.MetroLabel();
            this.label10 = new MetroFramework.Controls.MetroLabel();
            this.labelAttrValue = new MetroFramework.Controls.MetroLabel();
            this.labelAttrValueContains = new MetroFramework.Controls.MetroLabel();
            this.label13 = new MetroFramework.Controls.MetroLabel();
            this.labelTextContains = new MetroFramework.Controls.MetroLabel();
            this.buttonUseClassName = new MetroFramework.Controls.MetroButton();
            this.buttonUseClassNameContains = new MetroFramework.Controls.MetroButton();
            this.buttonUseAttrName = new MetroFramework.Controls.MetroButton();
            this.buttonUseAttrValue = new MetroFramework.Controls.MetroButton();
            this.buttonUseAttrValueContains = new MetroFramework.Controls.MetroButton();
            this.buttonUseTextContains = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUseIndex = new MetroFramework.Controls.MetroButton();
            this.labelUseIndex = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.buttonAddXPath = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxElementLink = new System.Windows.Forms.TextBox();
            this.textBoxElementChilden = new System.Windows.Forms.TextBox();
            this.textBoxElementText = new System.Windows.Forms.TextBox();
            this.textBoxElementPosition = new System.Windows.Forms.TextBox();
            this.label18 = new MetroFramework.Controls.MetroLabel();
            this.buttonOpenLink = new MetroFramework.Controls.MetroButton();
            this.label17 = new MetroFramework.Controls.MetroLabel();
            this.label16 = new MetroFramework.Controls.MetroLabel();
            this.label15 = new MetroFramework.Controls.MetroLabel();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.textBoxXPath = new System.Windows.Forms.TextBox();
            this.buttonCheck = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.labelXPathIndex = new MetroFramework.Controls.MetroLabel();
            this.buttonUseXPathIndex = new MetroFramework.Controls.MetroButton();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PathInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pathTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PathInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenUrl
            // 
            this.buttonOpenUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenUrl.Location = new System.Drawing.Point(850, 58);
            this.buttonOpenUrl.Name = "buttonOpenUrl";
            this.buttonOpenUrl.Size = new System.Drawing.Size(42, 20);
            this.buttonOpenUrl.TabIndex = 4;
            this.buttonOpenUrl.Text = "Open";
            this.buttonOpenUrl.UseSelectable = true;
            this.buttonOpenUrl.Click += new System.EventHandler(this.buttonOpenUrl_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(898, 57);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(48, 20);
            this.buttonClose.TabIndex = 27;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseSelectable = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Web page";
            // 
            // pathTable
            // 
            this.pathTable.AllowUserToOrderColumns = true;
            this.pathTable.AllowUserToResizeRows = false;
            this.pathTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTable.AutoGenerateColumns = false;
            this.pathTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pathTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pathTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.pathTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pathTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pathTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pathTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pathDataGridViewTextBoxColumn});
            this.pathTable.DataSource = this.PathInfoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pathTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.pathTable.EnableHeadersVisualStyles = false;
            this.pathTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pathTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pathTable.Location = new System.Drawing.Point(22, 83);
            this.pathTable.Name = "pathTable";
            this.pathTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pathTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.pathTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.pathTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pathTable.Size = new System.Drawing.Size(924, 217);
            this.pathTable.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Element XPath";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "By class name";
            // 
            // labelClassName
            // 
            this.labelClassName.AutoSize = true;
            this.labelClassName.Location = new System.Drawing.Point(152, 22);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(142, 19);
            this.labelClassName.TabIndex = 34;
            this.labelClassName.Text = ".//div[@class=\'{name}\']";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "By attr name";
            // 
            // labelClassNameContains
            // 
            this.labelClassNameContains.AutoSize = true;
            this.labelClassNameContains.Location = new System.Drawing.Point(152, 45);
            this.labelClassNameContains.Name = "labelClassNameContains";
            this.labelClassNameContains.Size = new System.Drawing.Size(195, 19);
            this.labelClassNameContains.TabIndex = 36;
            this.labelClassNameContains.Text = ".//div[contains(@class, \'{name}\')]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "By attr value";
            // 
            // labelAttrName
            // 
            this.labelAttrName.AutoSize = true;
            this.labelAttrName.Location = new System.Drawing.Point(152, 68);
            this.labelAttrName.Name = "labelAttrName";
            this.labelAttrName.Size = new System.Drawing.Size(111, 19);
            this.labelAttrName.TabIndex = 38;
            this.labelAttrName.Text = ".//{tag}[@{name}]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "By attr value contains";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 19);
            this.label10.TabIndex = 40;
            this.label10.Text = "By class name contains";
            // 
            // labelAttrValue
            // 
            this.labelAttrValue.AutoSize = true;
            this.labelAttrValue.Location = new System.Drawing.Point(152, 92);
            this.labelAttrValue.Name = "labelAttrValue";
            this.labelAttrValue.Size = new System.Drawing.Size(172, 19);
            this.labelAttrValue.TabIndex = 41;
            this.labelAttrValue.Text = ".//{tag}[@{name} = \'{value}\']";
            // 
            // labelAttrValueContains
            // 
            this.labelAttrValueContains.AutoSize = true;
            this.labelAttrValueContains.Location = new System.Drawing.Point(152, 115);
            this.labelAttrValueContains.Name = "labelAttrValueContains";
            this.labelAttrValueContains.Size = new System.Drawing.Size(217, 19);
            this.labelAttrValueContains.TabIndex = 42;
            this.labelAttrValueContains.Text = ".//{tag}[contains(@{name}, \'{value}\')]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 19);
            this.label13.TabIndex = 43;
            this.label13.Text = "By text contains";
            // 
            // labelTextContains
            // 
            this.labelTextContains.AutoSize = true;
            this.labelTextContains.Location = new System.Drawing.Point(154, 138);
            this.labelTextContains.Name = "labelTextContains";
            this.labelTextContains.Size = new System.Drawing.Size(180, 19);
            this.labelTextContains.TabIndex = 44;
            this.labelTextContains.Text = "//{tag}[contains(text(), \'{text}\')]";
            // 
            // buttonUseClassName
            // 
            this.buttonUseClassName.Location = new System.Drawing.Point(385, 19);
            this.buttonUseClassName.Name = "buttonUseClassName";
            this.buttonUseClassName.Size = new System.Drawing.Size(39, 20);
            this.buttonUseClassName.TabIndex = 45;
            this.buttonUseClassName.Text = "Use";
            this.buttonUseClassName.UseSelectable = true;
            this.buttonUseClassName.Click += new System.EventHandler(this.buttonUseClassName_Click);
            // 
            // buttonUseClassNameContains
            // 
            this.buttonUseClassNameContains.Location = new System.Drawing.Point(385, 44);
            this.buttonUseClassNameContains.Name = "buttonUseClassNameContains";
            this.buttonUseClassNameContains.Size = new System.Drawing.Size(39, 20);
            this.buttonUseClassNameContains.TabIndex = 46;
            this.buttonUseClassNameContains.Text = "Use";
            this.buttonUseClassNameContains.UseSelectable = true;
            this.buttonUseClassNameContains.Click += new System.EventHandler(this.buttonUseClassNameContains_Click);
            // 
            // buttonUseAttrName
            // 
            this.buttonUseAttrName.Location = new System.Drawing.Point(385, 67);
            this.buttonUseAttrName.Name = "buttonUseAttrName";
            this.buttonUseAttrName.Size = new System.Drawing.Size(39, 20);
            this.buttonUseAttrName.TabIndex = 47;
            this.buttonUseAttrName.Text = "Use";
            this.buttonUseAttrName.UseSelectable = true;
            this.buttonUseAttrName.Click += new System.EventHandler(this.buttonUseAttrName_Click);
            // 
            // buttonUseAttrValue
            // 
            this.buttonUseAttrValue.Location = new System.Drawing.Point(385, 91);
            this.buttonUseAttrValue.Name = "buttonUseAttrValue";
            this.buttonUseAttrValue.Size = new System.Drawing.Size(39, 20);
            this.buttonUseAttrValue.TabIndex = 48;
            this.buttonUseAttrValue.Text = "Use";
            this.buttonUseAttrValue.UseSelectable = true;
            this.buttonUseAttrValue.Click += new System.EventHandler(this.buttonUseAttrValue_Click);
            // 
            // buttonUseAttrValueContains
            // 
            this.buttonUseAttrValueContains.Location = new System.Drawing.Point(385, 114);
            this.buttonUseAttrValueContains.Name = "buttonUseAttrValueContains";
            this.buttonUseAttrValueContains.Size = new System.Drawing.Size(39, 20);
            this.buttonUseAttrValueContains.TabIndex = 49;
            this.buttonUseAttrValueContains.Text = "Use";
            this.buttonUseAttrValueContains.UseSelectable = true;
            this.buttonUseAttrValueContains.Click += new System.EventHandler(this.buttonUseAttrValueContains_Click);
            // 
            // buttonUseTextContains
            // 
            this.buttonUseTextContains.Location = new System.Drawing.Point(385, 137);
            this.buttonUseTextContains.Name = "buttonUseTextContains";
            this.buttonUseTextContains.Size = new System.Drawing.Size(39, 20);
            this.buttonUseTextContains.TabIndex = 50;
            this.buttonUseTextContains.Text = "Use";
            this.buttonUseTextContains.UseSelectable = true;
            this.buttonUseTextContains.Click += new System.EventHandler(this.buttonUseTextContains_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.buttonUseXPathIndex);
            this.groupBox1.Controls.Add(this.labelXPathIndex);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.buttonUseIndex);
            this.groupBox1.Controls.Add(this.labelUseIndex);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelClassName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelClassNameContains);
            this.groupBox1.Controls.Add(this.buttonUseTextContains);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.buttonUseAttrValueContains);
            this.groupBox1.Controls.Add(this.labelAttrName);
            this.groupBox1.Controls.Add(this.buttonUseAttrValue);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.buttonUseAttrName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.buttonUseClassNameContains);
            this.groupBox1.Controls.Add(this.labelAttrValue);
            this.groupBox1.Controls.Add(this.buttonUseClassName);
            this.groupBox1.Controls.Add(this.labelAttrValueContains);
            this.groupBox1.Controls.Add(this.labelTextContains);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(21, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 210);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XPath examples";
            // 
            // buttonUseIndex
            // 
            this.buttonUseIndex.Location = new System.Drawing.Point(385, 160);
            this.buttonUseIndex.Name = "buttonUseIndex";
            this.buttonUseIndex.Size = new System.Drawing.Size(39, 20);
            this.buttonUseIndex.TabIndex = 53;
            this.buttonUseIndex.Text = "Use";
            this.buttonUseIndex.UseSelectable = true;
            this.buttonUseIndex.Click += new System.EventHandler(this.buttonUseIndex_Click);
            // 
            // labelUseIndex
            // 
            this.labelUseIndex.AutoSize = true;
            this.labelUseIndex.Location = new System.Drawing.Point(154, 160);
            this.labelUseIndex.Name = "labelUseIndex";
            this.labelUseIndex.Size = new System.Drawing.Size(56, 19);
            this.labelUseIndex.TabIndex = 52;
            this.labelUseIndex.Text = "[{index}]";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 160);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 51;
            this.metroLabel1.Text = "By child index";
            // 
            // buttonAddXPath
            // 
            this.buttonAddXPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddXPath.Location = new System.Drawing.Point(859, 308);
            this.buttonAddXPath.Name = "buttonAddXPath";
            this.buttonAddXPath.Size = new System.Drawing.Size(86, 23);
            this.buttonAddXPath.TabIndex = 52;
            this.buttonAddXPath.Text = "Add to table";
            this.buttonAddXPath.UseSelectable = true;
            this.buttonAddXPath.Click += new System.EventHandler(this.buttonAddXPath_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxElementLink);
            this.groupBox2.Controls.Add(this.textBoxElementChilden);
            this.groupBox2.Controls.Add(this.textBoxElementText);
            this.groupBox2.Controls.Add(this.textBoxElementPosition);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.buttonOpenLink);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(466, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 193);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Element info";
            // 
            // textBoxElementLink
            // 
            this.textBoxElementLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxElementLink.Location = new System.Drawing.Point(73, 75);
            this.textBoxElementLink.Multiline = true;
            this.textBoxElementLink.Name = "textBoxElementLink";
            this.textBoxElementLink.ReadOnly = true;
            this.textBoxElementLink.Size = new System.Drawing.Size(327, 37);
            this.textBoxElementLink.TabIndex = 61;
            // 
            // textBoxElementChilden
            // 
            this.textBoxElementChilden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxElementChilden.Location = new System.Drawing.Point(73, 118);
            this.textBoxElementChilden.Name = "textBoxElementChilden";
            this.textBoxElementChilden.ReadOnly = true;
            this.textBoxElementChilden.Size = new System.Drawing.Size(391, 20);
            this.textBoxElementChilden.TabIndex = 60;
            // 
            // textBoxElementText
            // 
            this.textBoxElementText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxElementText.Location = new System.Drawing.Point(73, 49);
            this.textBoxElementText.Name = "textBoxElementText";
            this.textBoxElementText.ReadOnly = true;
            this.textBoxElementText.Size = new System.Drawing.Size(391, 20);
            this.textBoxElementText.TabIndex = 59;
            // 
            // textBoxElementPosition
            // 
            this.textBoxElementPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxElementPosition.Location = new System.Drawing.Point(73, 21);
            this.textBoxElementPosition.Name = "textBoxElementPosition";
            this.textBoxElementPosition.ReadOnly = true;
            this.textBoxElementPosition.Size = new System.Drawing.Size(391, 20);
            this.textBoxElementPosition.TabIndex = 58;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 119);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 19);
            this.label18.TabIndex = 57;
            this.label18.Text = "Children";
            // 
            // buttonOpenLink
            // 
            this.buttonOpenLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenLink.Location = new System.Drawing.Point(406, 75);
            this.buttonOpenLink.Name = "buttonOpenLink";
            this.buttonOpenLink.Size = new System.Drawing.Size(58, 37);
            this.buttonOpenLink.TabIndex = 56;
            this.buttonOpenLink.Text = "Open";
            this.buttonOpenLink.UseSelectable = true;
            this.buttonOpenLink.Click += new System.EventHandler(this.buttonOpenLink_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 19);
            this.label17.TabIndex = 4;
            this.label17.Text = "Link";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 19);
            this.label16.TabIndex = 2;
            this.label16.Text = "Text";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Position";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrl.Location = new System.Drawing.Point(98, 58);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(746, 20);
            this.textBoxUrl.TabIndex = 56;
            // 
            // textBoxXPath
            // 
            this.textBoxXPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxXPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxXPath.Location = new System.Drawing.Point(120, 306);
            this.textBoxXPath.Name = "textBoxXPath";
            this.textBoxXPath.Size = new System.Drawing.Size(677, 24);
            this.textBoxXPath.TabIndex = 57;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheck.Location = new System.Drawing.Point(803, 308);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(50, 23);
            this.buttonCheck.TabIndex = 58;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseSelectable = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 184);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 19);
            this.metroLabel2.TabIndex = 54;
            this.metroLabel2.Text = "By XPath + Index";
            // 
            // labelXPathIndex
            // 
            this.labelXPathIndex.AutoSize = true;
            this.labelXPathIndex.Location = new System.Drawing.Point(154, 185);
            this.labelXPathIndex.Name = "labelXPathIndex";
            this.labelXPathIndex.Size = new System.Drawing.Size(97, 19);
            this.labelXPathIndex.TabIndex = 55;
            this.labelXPathIndex.Text = "{XPath}[{index}]";
            // 
            // buttonUseXPathIndex
            // 
            this.buttonUseXPathIndex.Location = new System.Drawing.Point(385, 184);
            this.buttonUseXPathIndex.Name = "buttonUseXPathIndex";
            this.buttonUseXPathIndex.Size = new System.Drawing.Size(39, 20);
            this.buttonUseXPathIndex.TabIndex = 56;
            this.buttonUseXPathIndex.Text = "Use";
            this.buttonUseXPathIndex.UseSelectable = true;
            this.buttonUseXPathIndex.Click += new System.EventHandler(this.buttonUseXPathIndex_Click);
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "XPath";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            // 
            // PathInfoBindingSource
            // 
            this.PathInfoBindingSource.DataSource = typeof(WebTest.Settings.PathInfo);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 569);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.textBoxXPath);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonAddXPath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOpenUrl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Websites checker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pathTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PathInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton buttonOpenUrl;
        private MetroFramework.Controls.MetroButton buttonClose;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroGrid pathTable;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroLabel labelClassName;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroLabel labelClassNameContains;
        private MetroFramework.Controls.MetroLabel label7;
        private MetroFramework.Controls.MetroLabel labelAttrName;
        private MetroFramework.Controls.MetroLabel label9;
        private MetroFramework.Controls.MetroLabel label10;
        private MetroFramework.Controls.MetroLabel labelAttrValue;
        private MetroFramework.Controls.MetroLabel labelAttrValueContains;
        private MetroFramework.Controls.MetroLabel label13;
        private MetroFramework.Controls.MetroLabel labelTextContains;
        private MetroFramework.Controls.MetroButton buttonUseClassName;
        private MetroFramework.Controls.MetroButton buttonUseClassNameContains;
        private MetroFramework.Controls.MetroButton buttonUseAttrName;
        private MetroFramework.Controls.MetroButton buttonUseAttrValue;
        private MetroFramework.Controls.MetroButton buttonUseAttrValueContains;
        private MetroFramework.Controls.MetroButton buttonUseTextContains;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton buttonAddXPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton buttonOpenLink;
        private MetroFramework.Controls.MetroLabel label17;
        private MetroFramework.Controls.MetroLabel label16;
        private MetroFramework.Controls.MetroLabel label15;
        private MetroFramework.Controls.MetroLabel label18;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.TextBox textBoxElementLink;
        private System.Windows.Forms.TextBox textBoxElementChilden;
        private System.Windows.Forms.TextBox textBoxElementText;
        private System.Windows.Forms.TextBox textBoxElementPosition;
        private System.Windows.Forms.TextBox textBoxXPath;
        private System.Windows.Forms.BindingSource PathInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton buttonCheck;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton buttonUseIndex;
        private MetroFramework.Controls.MetroLabel labelUseIndex;
        private MetroFramework.Controls.MetroButton buttonUseXPathIndex;
        private MetroFramework.Controls.MetroLabel labelXPathIndex;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}


namespace App
{
    partial class formUserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUserInterface));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabGRN = new System.Windows.Forms.TabPage();
            this.txtProdID = new MaterialSkin.Controls.MaterialTextBox();
            this.dataGRNProd = new System.Windows.Forms.DataGridView();
            this.prodid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGRNReset = new MaterialSkin.Controls.MaterialButton();
            this.btnGRNSave = new MaterialSkin.Controls.MaterialButton();
            this.dateGRN = new System.Windows.Forms.DateTimePicker();
            this.txtProdPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.txtProdQty = new MaterialSkin.Controls.MaterialTextBox();
            this.txtProdName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtChecker = new MaterialSkin.Controls.MaterialTextBox();
            this.txtReceiver = new MaterialSkin.Controls.MaterialTextBox();
            this.btnProdDel = new MaterialSkin.Controls.MaterialButton();
            this.btnProdAdd = new MaterialSkin.Controls.MaterialButton();
            this.txtGRNID = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSupplier = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tabGDN = new System.Windows.Forms.TabPage();
            this.cbxIsPaid = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtMethod = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.btnLoadGDN = new MaterialSkin.Controls.MaterialButton();
            this.txtAgentAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAgentPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.comboOrderGDN = new MaterialSkin.Controls.MaterialComboBox();
            this.listViewProdGDN = new MaterialSkin.Controls.MaterialListView();
            this.colProdIDGDN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGDNPrint = new MaterialSkin.Controls.MaterialButton();
            this.dateDelivery = new System.Windows.Forms.DateTimePicker();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAgentName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.tabOrderList = new System.Windows.Forms.TabPage();
            this.btnLoadOrder = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveOL = new MaterialSkin.Controls.MaterialButton();
            this.comboOrderStatusOL = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxIfPayment = new MaterialSkin.Controls.MaterialCheckbox();
            this.dateListEnd = new System.Windows.Forms.DateTimePicker();
            this.dateListStart = new System.Windows.Forms.DateTimePicker();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAgentAddressOL = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAgentPhoneOL = new MaterialSkin.Controls.MaterialTextBox();
            this.comboOrderList = new MaterialSkin.Controls.MaterialComboBox();
            this.listViewProdOL = new MaterialSkin.Controls.MaterialListView();
            this.colProdID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProdQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProdPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAgentNameOL = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.dataGDNrv = new System.Windows.Forms.DataGridView();
            this.gdnid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdnquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdndate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGRNrv = new System.Windows.Forms.DataGridView();
            this.grnid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grndate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOut = new MaterialSkin.Controls.MaterialTextBox();
            this.txtIn = new MaterialSkin.Controls.MaterialTextBox();
            this.btnLoadMonth = new MaterialSkin.Controls.MaterialButton();
            this.txtRevenue = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.dateMonthSelect = new System.Windows.Forms.DateTimePicker();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.btnResetProfile = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveProfile = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.radFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.radMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtFullname = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPass = new System.Windows.Forms.TabPage();
            this.btnReset = new MaterialSkin.Controls.MaterialButton();
            this.btnChangePass = new MaterialSkin.Controls.MaterialButton();
            this.txtConfPass = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNewPass = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCurrPass = new MaterialSkin.Controls.MaterialTextBox();
            this.tabLogout = new System.Windows.Forms.TabPage();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.btnLogout = new MaterialSkin.Controls.MaterialButton();
            this.icon = new System.Windows.Forms.ImageList(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.materialTabControl1.SuspendLayout();
            this.tabGRN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGRNProd)).BeginInit();
            this.tabGDN.SuspendLayout();
            this.tabOrderList.SuspendLayout();
            this.tabStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGDNrv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGRNrv)).BeginInit();
            this.tabProfile.SuspendLayout();
            this.tabPass.SuspendLayout();
            this.tabLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabGRN);
            this.materialTabControl1.Controls.Add(this.tabGDN);
            this.materialTabControl1.Controls.Add(this.tabOrderList);
            this.materialTabControl1.Controls.Add(this.tabStatistics);
            this.materialTabControl1.Controls.Add(this.tabProfile);
            this.materialTabControl1.Controls.Add(this.tabPass);
            this.materialTabControl1.Controls.Add(this.tabLogout);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.ImageList = this.icon;
            this.materialTabControl1.Location = new System.Drawing.Point(1, 64);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(799, 535);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabGRN
            // 
            this.tabGRN.Controls.Add(this.txtProdID);
            this.tabGRN.Controls.Add(this.dataGRNProd);
            this.tabGRN.Controls.Add(this.btnGRNReset);
            this.tabGRN.Controls.Add(this.btnGRNSave);
            this.tabGRN.Controls.Add(this.dateGRN);
            this.tabGRN.Controls.Add(this.txtProdPrice);
            this.tabGRN.Controls.Add(this.txtProdQty);
            this.tabGRN.Controls.Add(this.txtProdName);
            this.tabGRN.Controls.Add(this.txtChecker);
            this.tabGRN.Controls.Add(this.txtReceiver);
            this.tabGRN.Controls.Add(this.btnProdDel);
            this.tabGRN.Controls.Add(this.btnProdAdd);
            this.tabGRN.Controls.Add(this.txtGRNID);
            this.tabGRN.Controls.Add(this.materialLabel4);
            this.tabGRN.Controls.Add(this.txtSupplier);
            this.tabGRN.Controls.Add(this.materialLabel5);
            this.tabGRN.ImageKey = "import-40-32.png";
            this.tabGRN.Location = new System.Drawing.Point(4, 39);
            this.tabGRN.Margin = new System.Windows.Forms.Padding(2);
            this.tabGRN.Name = "tabGRN";
            this.tabGRN.Padding = new System.Windows.Forms.Padding(2);
            this.tabGRN.Size = new System.Drawing.Size(791, 492);
            this.tabGRN.TabIndex = 0;
            this.tabGRN.Text = "Received Note";
            this.tabGRN.UseVisualStyleBackColor = true;
            // 
            // txtProdID
            // 
            this.txtProdID.AnimateReadOnly = false;
            this.txtProdID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdID.Depth = 0;
            this.txtProdID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProdID.Hint = "ID";
            this.txtProdID.LeadingIcon = null;
            this.txtProdID.Location = new System.Drawing.Point(80, 348);
            this.txtProdID.Margin = new System.Windows.Forms.Padding(2);
            this.txtProdID.MaxLength = 50;
            this.txtProdID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProdID.Multiline = false;
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(51, 50);
            this.txtProdID.TabIndex = 46;
            this.txtProdID.Text = "";
            this.txtProdID.TrailingIcon = null;
            // 
            // dataGRNProd
            // 
            this.dataGRNProd.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGRNProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGRNProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodid,
            this.prodName,
            this.prodQuantity,
            this.prodPrice});
            this.dataGRNProd.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGRNProd.Location = new System.Drawing.Point(292, 85);
            this.dataGRNProd.Margin = new System.Windows.Forms.Padding(2);
            this.dataGRNProd.Name = "dataGRNProd";
            this.dataGRNProd.ReadOnly = true;
            this.dataGRNProd.RowHeadersWidth = 51;
            this.dataGRNProd.RowTemplate.Height = 24;
            this.dataGRNProd.Size = new System.Drawing.Size(495, 303);
            this.dataGRNProd.TabIndex = 45;
            this.dataGRNProd.SelectionChanged += new System.EventHandler(this.dataGRNProd_SelectionChanged);
            // 
            // prodid
            // 
            this.prodid.HeaderText = "No.";
            this.prodid.MinimumWidth = 6;
            this.prodid.Name = "prodid";
            this.prodid.ReadOnly = true;
            this.prodid.Width = 125;
            // 
            // prodName
            // 
            this.prodName.HeaderText = "Product Name";
            this.prodName.MinimumWidth = 6;
            this.prodName.Name = "prodName";
            this.prodName.ReadOnly = true;
            this.prodName.Width = 200;
            // 
            // prodQuantity
            // 
            this.prodQuantity.HeaderText = "Quantity";
            this.prodQuantity.MinimumWidth = 6;
            this.prodQuantity.Name = "prodQuantity";
            this.prodQuantity.ReadOnly = true;
            this.prodQuantity.Width = 200;
            // 
            // prodPrice
            // 
            this.prodPrice.HeaderText = "Price ($)";
            this.prodPrice.MinimumWidth = 6;
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.ReadOnly = true;
            this.prodPrice.Width = 200;
            // 
            // btnGRNReset
            // 
            this.btnGRNReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGRNReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGRNReset.Depth = 0;
            this.btnGRNReset.HighEmphasis = true;
            this.btnGRNReset.Icon = null;
            this.btnGRNReset.Location = new System.Drawing.Point(538, 395);
            this.btnGRNReset.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGRNReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGRNReset.Name = "btnGRNReset";
            this.btnGRNReset.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGRNReset.Size = new System.Drawing.Size(107, 36);
            this.btnGRNReset.TabIndex = 44;
            this.btnGRNReset.Text = "reset note";
            this.btnGRNReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGRNReset.UseAccentColor = false;
            this.btnGRNReset.UseVisualStyleBackColor = true;
            this.btnGRNReset.Click += new System.EventHandler(this.btnGRNReset_Click);
            // 
            // btnGRNSave
            // 
            this.btnGRNSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGRNSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGRNSave.Depth = 0;
            this.btnGRNSave.HighEmphasis = true;
            this.btnGRNSave.Icon = null;
            this.btnGRNSave.Location = new System.Drawing.Point(678, 395);
            this.btnGRNSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGRNSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGRNSave.Name = "btnGRNSave";
            this.btnGRNSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGRNSave.Size = new System.Drawing.Size(99, 36);
            this.btnGRNSave.TabIndex = 43;
            this.btnGRNSave.Text = "Save note";
            this.btnGRNSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGRNSave.UseAccentColor = false;
            this.btnGRNSave.UseVisualStyleBackColor = true;
            this.btnGRNSave.Click += new System.EventHandler(this.btnGRNSave_Click);
            // 
            // dateGRN
            // 
            this.dateGRN.CalendarForeColor = System.Drawing.Color.White;
            this.dateGRN.CalendarMonthBackground = System.Drawing.SystemColors.MenuText;
            this.dateGRN.Location = new System.Drawing.Point(399, 61);
            this.dateGRN.Margin = new System.Windows.Forms.Padding(2);
            this.dateGRN.Name = "dateGRN";
            this.dateGRN.Size = new System.Drawing.Size(210, 20);
            this.dateGRN.TabIndex = 34;
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.AnimateReadOnly = false;
            this.txtProdPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdPrice.Depth = 0;
            this.txtProdPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProdPrice.Hint = "Price";
            this.txtProdPrice.LeadingIcon = null;
            this.txtProdPrice.Location = new System.Drawing.Point(213, 413);
            this.txtProdPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtProdPrice.MaxLength = 50;
            this.txtProdPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProdPrice.Multiline = false;
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(75, 50);
            this.txtProdPrice.TabIndex = 42;
            this.txtProdPrice.Text = "";
            this.txtProdPrice.TrailingIcon = null;
            // 
            // txtProdQty
            // 
            this.txtProdQty.AnimateReadOnly = false;
            this.txtProdQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdQty.Depth = 0;
            this.txtProdQty.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProdQty.Hint = "Quantity";
            this.txtProdQty.LeadingIcon = null;
            this.txtProdQty.Location = new System.Drawing.Point(80, 413);
            this.txtProdQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtProdQty.MaxLength = 50;
            this.txtProdQty.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProdQty.Multiline = false;
            this.txtProdQty.Name = "txtProdQty";
            this.txtProdQty.Size = new System.Drawing.Size(104, 50);
            this.txtProdQty.TabIndex = 41;
            this.txtProdQty.Text = "";
            this.txtProdQty.TrailingIcon = null;
            // 
            // txtProdName
            // 
            this.txtProdName.AnimateReadOnly = false;
            this.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdName.Depth = 0;
            this.txtProdName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProdName.Hint = "Product Name";
            this.txtProdName.LeadingIcon = null;
            this.txtProdName.Location = new System.Drawing.Point(150, 348);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProdName.MaxLength = 50;
            this.txtProdName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProdName.Multiline = false;
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(138, 50);
            this.txtProdName.TabIndex = 40;
            this.txtProdName.Text = "";
            this.txtProdName.TrailingIcon = null;
            // 
            // txtChecker
            // 
            this.txtChecker.AnimateReadOnly = false;
            this.txtChecker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChecker.Depth = 0;
            this.txtChecker.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtChecker.Hint = "Checked By";
            this.txtChecker.LeadingIcon = null;
            this.txtChecker.Location = new System.Drawing.Point(80, 215);
            this.txtChecker.Margin = new System.Windows.Forms.Padding(2);
            this.txtChecker.MaxLength = 50;
            this.txtChecker.MouseState = MaterialSkin.MouseState.OUT;
            this.txtChecker.Multiline = false;
            this.txtChecker.Name = "txtChecker";
            this.txtChecker.Size = new System.Drawing.Size(208, 50);
            this.txtChecker.TabIndex = 39;
            this.txtChecker.Text = "";
            this.txtChecker.TrailingIcon = null;
            // 
            // txtReceiver
            // 
            this.txtReceiver.AnimateReadOnly = false;
            this.txtReceiver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceiver.Depth = 0;
            this.txtReceiver.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtReceiver.Hint = "Received By";
            this.txtReceiver.LeadingIcon = null;
            this.txtReceiver.Location = new System.Drawing.Point(80, 144);
            this.txtReceiver.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceiver.MaxLength = 50;
            this.txtReceiver.MouseState = MaterialSkin.MouseState.OUT;
            this.txtReceiver.Multiline = false;
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(208, 50);
            this.txtReceiver.TabIndex = 38;
            this.txtReceiver.Text = "";
            this.txtReceiver.TrailingIcon = null;
            // 
            // btnProdDel
            // 
            this.btnProdDel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProdDel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProdDel.Depth = 0;
            this.btnProdDel.Enabled = false;
            this.btnProdDel.HighEmphasis = true;
            this.btnProdDel.Icon = null;
            this.btnProdDel.Location = new System.Drawing.Point(432, 395);
            this.btnProdDel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnProdDel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProdDel.Name = "btnProdDel";
            this.btnProdDel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProdDel.Size = new System.Drawing.Size(73, 36);
            this.btnProdDel.TabIndex = 37;
            this.btnProdDel.Text = "Delete";
            this.btnProdDel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProdDel.UseAccentColor = false;
            this.btnProdDel.UseVisualStyleBackColor = true;
            this.btnProdDel.Click += new System.EventHandler(this.btnProdDel_Click);
            // 
            // btnProdAdd
            // 
            this.btnProdAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProdAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProdAdd.Depth = 0;
            this.btnProdAdd.HighEmphasis = true;
            this.btnProdAdd.Icon = null;
            this.btnProdAdd.Location = new System.Drawing.Point(332, 395);
            this.btnProdAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnProdAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProdAdd.Name = "btnProdAdd";
            this.btnProdAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProdAdd.Size = new System.Drawing.Size(64, 36);
            this.btnProdAdd.TabIndex = 36;
            this.btnProdAdd.Text = "ADD";
            this.btnProdAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProdAdd.UseAccentColor = false;
            this.btnProdAdd.UseVisualStyleBackColor = true;
            this.btnProdAdd.Click += new System.EventHandler(this.btnProdAdd_Click);
            // 
            // txtGRNID
            // 
            this.txtGRNID.AnimateReadOnly = false;
            this.txtGRNID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGRNID.Depth = 0;
            this.txtGRNID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGRNID.Hint = "Order ID";
            this.txtGRNID.LeadingIcon = null;
            this.txtGRNID.Location = new System.Drawing.Point(80, 283);
            this.txtGRNID.Margin = new System.Windows.Forms.Padding(2);
            this.txtGRNID.MaxLength = 50;
            this.txtGRNID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGRNID.Multiline = false;
            this.txtGRNID.Name = "txtGRNID";
            this.txtGRNID.Size = new System.Drawing.Size(111, 50);
            this.txtGRNID.TabIndex = 35;
            this.txtGRNID.Text = "";
            this.txtGRNID.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(400, 40);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(34, 19);
            this.materialLabel4.TabIndex = 33;
            this.materialLabel4.Text = "Date";
            // 
            // txtSupplier
            // 
            this.txtSupplier.AnimateReadOnly = false;
            this.txtSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupplier.Depth = 0;
            this.txtSupplier.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSupplier.Hint = "Supplier";
            this.txtSupplier.LeadingIcon = null;
            this.txtSupplier.Location = new System.Drawing.Point(80, 85);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplier.MaxLength = 50;
            this.txtSupplier.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSupplier.Multiline = false;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(208, 50);
            this.txtSupplier.TabIndex = 32;
            this.txtSupplier.Text = "";
            this.txtSupplier.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel5.ForeColor = System.Drawing.Color.Black;
            this.materialLabel5.Location = new System.Drawing.Point(73, 18);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(323, 41);
            this.materialLabel5.TabIndex = 31;
            this.materialLabel5.Text = "Goods Received Note";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabGDN
            // 
            this.tabGDN.Controls.Add(this.cbxIsPaid);
            this.tabGDN.Controls.Add(this.txtMethod);
            this.tabGDN.Controls.Add(this.txtTotal);
            this.tabGDN.Controls.Add(this.btnLoadGDN);
            this.tabGDN.Controls.Add(this.txtAgentAddress);
            this.tabGDN.Controls.Add(this.txtAgentPhone);
            this.tabGDN.Controls.Add(this.comboOrderGDN);
            this.tabGDN.Controls.Add(this.listViewProdGDN);
            this.tabGDN.Controls.Add(this.btnGDNPrint);
            this.tabGDN.Controls.Add(this.dateDelivery);
            this.tabGDN.Controls.Add(this.materialLabel6);
            this.tabGDN.Controls.Add(this.txtAgentName);
            this.tabGDN.Controls.Add(this.materialLabel7);
            this.tabGDN.ImageKey = "export-52-32.png";
            this.tabGDN.Location = new System.Drawing.Point(4, 22);
            this.tabGDN.Margin = new System.Windows.Forms.Padding(2);
            this.tabGDN.Name = "tabGDN";
            this.tabGDN.Padding = new System.Windows.Forms.Padding(2);
            this.tabGDN.Size = new System.Drawing.Size(791, 509);
            this.tabGDN.TabIndex = 1;
            this.tabGDN.Text = "Delivery Note";
            this.tabGDN.UseVisualStyleBackColor = true;
            // 
            // cbxIsPaid
            // 
            this.cbxIsPaid.AutoSize = true;
            this.cbxIsPaid.Depth = 0;
            this.cbxIsPaid.Enabled = false;
            this.cbxIsPaid.Location = new System.Drawing.Point(94, 358);
            this.cbxIsPaid.Margin = new System.Windows.Forms.Padding(0);
            this.cbxIsPaid.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxIsPaid.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxIsPaid.Name = "cbxIsPaid";
            this.cbxIsPaid.ReadOnly = false;
            this.cbxIsPaid.Ripple = true;
            this.cbxIsPaid.Size = new System.Drawing.Size(178, 37);
            this.cbxIsPaid.TabIndex = 37;
            this.cbxIsPaid.Text = "Payment Completed";
            this.cbxIsPaid.UseVisualStyleBackColor = true;
            // 
            // txtMethod
            // 
            this.txtMethod.AnimateReadOnly = false;
            this.txtMethod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMethod.Depth = 0;
            this.txtMethod.Enabled = false;
            this.txtMethod.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMethod.Hint = "Payment Method";
            this.txtMethod.LeadingIcon = null;
            this.txtMethod.Location = new System.Drawing.Point(94, 280);
            this.txtMethod.Margin = new System.Windows.Forms.Padding(2);
            this.txtMethod.MaxLength = 50;
            this.txtMethod.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMethod.Multiline = false;
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(137, 50);
            this.txtMethod.TabIndex = 36;
            this.txtMethod.Text = "";
            this.txtMethod.TrailingIcon = null;
            // 
            // txtTotal
            // 
            this.txtTotal.AnimateReadOnly = false;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Depth = 0;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotal.Hint = "Total Amount";
            this.txtTotal.LeadingIcon = null;
            this.txtTotal.Location = new System.Drawing.Point(94, 211);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.MaxLength = 50;
            this.txtTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotal.Multiline = false;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(128, 50);
            this.txtTotal.TabIndex = 35;
            this.txtTotal.Text = "";
            this.txtTotal.TrailingIcon = null;
            // 
            // btnLoadGDN
            // 
            this.btnLoadGDN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadGDN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLoadGDN.Depth = 0;
            this.btnLoadGDN.HighEmphasis = true;
            this.btnLoadGDN.Icon = null;
            this.btnLoadGDN.Location = new System.Drawing.Point(601, 18);
            this.btnLoadGDN.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLoadGDN.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoadGDN.Name = "btnLoadGDN";
            this.btnLoadGDN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLoadGDN.Size = new System.Drawing.Size(64, 36);
            this.btnLoadGDN.TabIndex = 34;
            this.btnLoadGDN.Text = "load ";
            this.btnLoadGDN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLoadGDN.UseAccentColor = false;
            this.btnLoadGDN.UseVisualStyleBackColor = true;
            this.btnLoadGDN.Click += new System.EventHandler(this.btnLoadGDN_Click);
            // 
            // txtAgentAddress
            // 
            this.txtAgentAddress.AnimateReadOnly = false;
            this.txtAgentAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgentAddress.Depth = 0;
            this.txtAgentAddress.Enabled = false;
            this.txtAgentAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAgentAddress.Hint = "Agent Address";
            this.txtAgentAddress.LeadingIcon = null;
            this.txtAgentAddress.Location = new System.Drawing.Point(94, 415);
            this.txtAgentAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgentAddress.MaxLength = 50;
            this.txtAgentAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAgentAddress.Multiline = false;
            this.txtAgentAddress.Name = "txtAgentAddress";
            this.txtAgentAddress.Size = new System.Drawing.Size(385, 50);
            this.txtAgentAddress.TabIndex = 33;
            this.txtAgentAddress.Text = "";
            this.txtAgentAddress.TrailingIcon = null;
            // 
            // txtAgentPhone
            // 
            this.txtAgentPhone.AnimateReadOnly = false;
            this.txtAgentPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgentPhone.Depth = 0;
            this.txtAgentPhone.Enabled = false;
            this.txtAgentPhone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAgentPhone.Hint = "Agent Phone Number";
            this.txtAgentPhone.LeadingIcon = null;
            this.txtAgentPhone.Location = new System.Drawing.Point(94, 138);
            this.txtAgentPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgentPhone.MaxLength = 50;
            this.txtAgentPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAgentPhone.Multiline = false;
            this.txtAgentPhone.Name = "txtAgentPhone";
            this.txtAgentPhone.Size = new System.Drawing.Size(171, 50);
            this.txtAgentPhone.TabIndex = 32;
            this.txtAgentPhone.Text = "";
            this.txtAgentPhone.TrailingIcon = null;
            // 
            // comboOrderGDN
            // 
            this.comboOrderGDN.AutoResize = false;
            this.comboOrderGDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboOrderGDN.Depth = 0;
            this.comboOrderGDN.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboOrderGDN.DropDownHeight = 174;
            this.comboOrderGDN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOrderGDN.DropDownWidth = 121;
            this.comboOrderGDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboOrderGDN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboOrderGDN.FormattingEnabled = true;
            this.comboOrderGDN.Hint = "Choose Order";
            this.comboOrderGDN.IntegralHeight = false;
            this.comboOrderGDN.ItemHeight = 43;
            this.comboOrderGDN.Location = new System.Drawing.Point(443, 13);
            this.comboOrderGDN.Margin = new System.Windows.Forms.Padding(2);
            this.comboOrderGDN.MaxDropDownItems = 4;
            this.comboOrderGDN.MouseState = MaterialSkin.MouseState.OUT;
            this.comboOrderGDN.Name = "comboOrderGDN";
            this.comboOrderGDN.Size = new System.Drawing.Size(129, 49);
            this.comboOrderGDN.StartIndex = 0;
            this.comboOrderGDN.TabIndex = 31;
            this.comboOrderGDN.SelectionChangeCommitted += new System.EventHandler(this.comboOrderGDN_SelectionChangeCommitted);
            // 
            // listViewProdGDN
            // 
            this.listViewProdGDN.AutoSizeTable = false;
            this.listViewProdGDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewProdGDN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewProdGDN.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProdIDGDN,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewProdGDN.Depth = 0;
            this.listViewProdGDN.FullRowSelect = true;
            this.listViewProdGDN.HideSelection = false;
            this.listViewProdGDN.Location = new System.Drawing.Point(278, 121);
            this.listViewProdGDN.Margin = new System.Windows.Forms.Padding(2);
            this.listViewProdGDN.MinimumSize = new System.Drawing.Size(150, 81);
            this.listViewProdGDN.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewProdGDN.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewProdGDN.Name = "listViewProdGDN";
            this.listViewProdGDN.OwnerDraw = true;
            this.listViewProdGDN.Size = new System.Drawing.Size(508, 290);
            this.listViewProdGDN.TabIndex = 30;
            this.listViewProdGDN.UseCompatibleStateImageBehavior = false;
            this.listViewProdGDN.View = System.Windows.Forms.View.Details;
            // 
            // colProdIDGDN
            // 
            this.colProdIDGDN.Text = "Product ID";
            this.colProdIDGDN.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 200;
            // 
            // btnGDNPrint
            // 
            this.btnGDNPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGDNPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGDNPrint.Depth = 0;
            this.btnGDNPrint.HighEmphasis = true;
            this.btnGDNPrint.Icon = null;
            this.btnGDNPrint.Location = new System.Drawing.Point(681, 442);
            this.btnGDNPrint.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGDNPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGDNPrint.Name = "btnGDNPrint";
            this.btnGDNPrint.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGDNPrint.Size = new System.Drawing.Size(105, 36);
            this.btnGDNPrint.TabIndex = 28;
            this.btnGDNPrint.Text = "Print Note";
            this.btnGDNPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGDNPrint.UseAccentColor = false;
            this.btnGDNPrint.UseVisualStyleBackColor = true;
            this.btnGDNPrint.Click += new System.EventHandler(this.btnGDNPrint_Click);
            // 
            // dateDelivery
            // 
            this.dateDelivery.CalendarForeColor = System.Drawing.Color.White;
            this.dateDelivery.CalendarMonthBackground = System.Drawing.SystemColors.MenuText;
            this.dateDelivery.Location = new System.Drawing.Point(298, 97);
            this.dateDelivery.Margin = new System.Windows.Forms.Padding(2);
            this.dateDelivery.Name = "dateDelivery";
            this.dateDelivery.Size = new System.Drawing.Size(172, 20);
            this.dateDelivery.TabIndex = 19;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(298, 74);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(94, 19);
            this.materialLabel6.TabIndex = 18;
            this.materialLabel6.Text = "Delivery Date";
            // 
            // txtAgentName
            // 
            this.txtAgentName.AnimateReadOnly = false;
            this.txtAgentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgentName.Depth = 0;
            this.txtAgentName.Enabled = false;
            this.txtAgentName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAgentName.Hint = "Agent Name";
            this.txtAgentName.LeadingIcon = null;
            this.txtAgentName.Location = new System.Drawing.Point(94, 74);
            this.txtAgentName.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgentName.MaxLength = 50;
            this.txtAgentName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAgentName.Multiline = false;
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(159, 50);
            this.txtAgentName.TabIndex = 17;
            this.txtAgentName.Text = "";
            this.txtAgentName.TrailingIcon = null;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel7.ForeColor = System.Drawing.Color.Black;
            this.materialLabel7.Location = new System.Drawing.Point(87, 13);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(305, 41);
            this.materialLabel7.TabIndex = 16;
            this.materialLabel7.Text = "Goods Delivery Note";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabOrderList
            // 
            this.tabOrderList.Controls.Add(this.btnLoadOrder);
            this.tabOrderList.Controls.Add(this.btnSaveOL);
            this.tabOrderList.Controls.Add(this.comboOrderStatusOL);
            this.tabOrderList.Controls.Add(this.cbxIfPayment);
            this.tabOrderList.Controls.Add(this.dateListEnd);
            this.tabOrderList.Controls.Add(this.dateListStart);
            this.tabOrderList.Controls.Add(this.materialLabel10);
            this.tabOrderList.Controls.Add(this.materialLabel8);
            this.tabOrderList.Controls.Add(this.txtAgentAddressOL);
            this.tabOrderList.Controls.Add(this.txtAgentPhoneOL);
            this.tabOrderList.Controls.Add(this.comboOrderList);
            this.tabOrderList.Controls.Add(this.listViewProdOL);
            this.tabOrderList.Controls.Add(this.txtAgentNameOL);
            this.tabOrderList.Controls.Add(this.materialLabel9);
            this.tabOrderList.ImageKey = "2639879_order_icon.png";
            this.tabOrderList.Location = new System.Drawing.Point(4, 22);
            this.tabOrderList.Margin = new System.Windows.Forms.Padding(2);
            this.tabOrderList.Name = "tabOrderList";
            this.tabOrderList.Size = new System.Drawing.Size(791, 509);
            this.tabOrderList.TabIndex = 6;
            this.tabOrderList.Text = "Order List";
            this.tabOrderList.UseVisualStyleBackColor = true;
            // 
            // btnLoadOrder
            // 
            this.btnLoadOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadOrder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLoadOrder.Depth = 0;
            this.btnLoadOrder.HighEmphasis = true;
            this.btnLoadOrder.Icon = null;
            this.btnLoadOrder.Location = new System.Drawing.Point(395, 10);
            this.btnLoadOrder.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLoadOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoadOrder.Name = "btnLoadOrder";
            this.btnLoadOrder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLoadOrder.Size = new System.Drawing.Size(143, 36);
            this.btnLoadOrder.TabIndex = 52;
            this.btnLoadOrder.Text = "Load Order List";
            this.btnLoadOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLoadOrder.UseAccentColor = false;
            this.btnLoadOrder.UseVisualStyleBackColor = true;
            this.btnLoadOrder.Click += new System.EventHandler(this.btnLoadOrder_Click);
            // 
            // btnSaveOL
            // 
            this.btnSaveOL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveOL.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveOL.Depth = 0;
            this.btnSaveOL.HighEmphasis = true;
            this.btnSaveOL.Icon = null;
            this.btnSaveOL.Location = new System.Drawing.Point(705, 445);
            this.btnSaveOL.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSaveOL.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveOL.Name = "btnSaveOL";
            this.btnSaveOL.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveOL.Size = new System.Drawing.Size(64, 36);
            this.btnSaveOL.TabIndex = 51;
            this.btnSaveOL.Text = "Save";
            this.btnSaveOL.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveOL.UseAccentColor = false;
            this.btnSaveOL.UseVisualStyleBackColor = true;
            this.btnSaveOL.Click += new System.EventHandler(this.btnSaveOL_Click);
            // 
            // comboOrderStatusOL
            // 
            this.comboOrderStatusOL.AutoResize = false;
            this.comboOrderStatusOL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboOrderStatusOL.Depth = 0;
            this.comboOrderStatusOL.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboOrderStatusOL.DropDownHeight = 174;
            this.comboOrderStatusOL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOrderStatusOL.DropDownWidth = 121;
            this.comboOrderStatusOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboOrderStatusOL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboOrderStatusOL.FormattingEnabled = true;
            this.comboOrderStatusOL.Hint = "Order Status";
            this.comboOrderStatusOL.IntegralHeight = false;
            this.comboOrderStatusOL.ItemHeight = 43;
            this.comboOrderStatusOL.Items.AddRange(new object[] {
            "Pending",
            "Being Delivered",
            "Delivered",
            "Cancelled"});
            this.comboOrderStatusOL.Location = new System.Drawing.Point(88, 302);
            this.comboOrderStatusOL.Margin = new System.Windows.Forms.Padding(2);
            this.comboOrderStatusOL.MaxDropDownItems = 4;
            this.comboOrderStatusOL.MouseState = MaterialSkin.MouseState.OUT;
            this.comboOrderStatusOL.Name = "comboOrderStatusOL";
            this.comboOrderStatusOL.Size = new System.Drawing.Size(134, 49);
            this.comboOrderStatusOL.StartIndex = 0;
            this.comboOrderStatusOL.TabIndex = 50;
            // 
            // cbxIfPayment
            // 
            this.cbxIfPayment.AutoSize = true;
            this.cbxIfPayment.Depth = 0;
            this.cbxIfPayment.Location = new System.Drawing.Point(84, 245);
            this.cbxIfPayment.Margin = new System.Windows.Forms.Padding(0);
            this.cbxIfPayment.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxIfPayment.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxIfPayment.Name = "cbxIfPayment";
            this.cbxIfPayment.ReadOnly = false;
            this.cbxIfPayment.Ripple = true;
            this.cbxIfPayment.Size = new System.Drawing.Size(178, 37);
            this.cbxIfPayment.TabIndex = 49;
            this.cbxIfPayment.Text = "Payment Completed";
            this.cbxIfPayment.UseVisualStyleBackColor = true;
            // 
            // dateListEnd
            // 
            this.dateListEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateListEnd.Location = new System.Drawing.Point(246, 54);
            this.dateListEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dateListEnd.Name = "dateListEnd";
            this.dateListEnd.Size = new System.Drawing.Size(85, 20);
            this.dateListEnd.TabIndex = 48;
            // 
            // dateListStart
            // 
            this.dateListStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateListStart.Location = new System.Drawing.Point(129, 53);
            this.dateListStart.Margin = new System.Windows.Forms.Padding(2);
            this.dateListStart.Name = "dateListStart";
            this.dateListStart.Size = new System.Drawing.Size(85, 20);
            this.dateListStart.TabIndex = 47;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(218, 54);
            this.materialLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(24, 19);
            this.materialLabel10.TabIndex = 46;
            this.materialLabel10.Text = "To:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(85, 54);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(42, 19);
            this.materialLabel8.TabIndex = 45;
            this.materialLabel8.Text = "From:";
            // 
            // txtAgentAddressOL
            // 
            this.txtAgentAddressOL.AnimateReadOnly = false;
            this.txtAgentAddressOL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgentAddressOL.Depth = 0;
            this.txtAgentAddressOL.Enabled = false;
            this.txtAgentAddressOL.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAgentAddressOL.Hint = "Agent Address";
            this.txtAgentAddressOL.LeadingIcon = null;
            this.txtAgentAddressOL.Location = new System.Drawing.Point(84, 442);
            this.txtAgentAddressOL.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgentAddressOL.MaxLength = 50;
            this.txtAgentAddressOL.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAgentAddressOL.Multiline = false;
            this.txtAgentAddressOL.Name = "txtAgentAddressOL";
            this.txtAgentAddressOL.Size = new System.Drawing.Size(429, 50);
            this.txtAgentAddressOL.TabIndex = 43;
            this.txtAgentAddressOL.Text = "";
            this.txtAgentAddressOL.TrailingIcon = null;
            // 
            // txtAgentPhoneOL
            // 
            this.txtAgentPhoneOL.AnimateReadOnly = false;
            this.txtAgentPhoneOL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgentPhoneOL.Depth = 0;
            this.txtAgentPhoneOL.Enabled = false;
            this.txtAgentPhoneOL.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAgentPhoneOL.Hint = "Agent Phone Number";
            this.txtAgentPhoneOL.LeadingIcon = null;
            this.txtAgentPhoneOL.Location = new System.Drawing.Point(84, 174);
            this.txtAgentPhoneOL.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgentPhoneOL.MaxLength = 50;
            this.txtAgentPhoneOL.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAgentPhoneOL.Multiline = false;
            this.txtAgentPhoneOL.Name = "txtAgentPhoneOL";
            this.txtAgentPhoneOL.Size = new System.Drawing.Size(144, 50);
            this.txtAgentPhoneOL.TabIndex = 42;
            this.txtAgentPhoneOL.Text = "";
            this.txtAgentPhoneOL.TrailingIcon = null;
            // 
            // comboOrderList
            // 
            this.comboOrderList.AutoResize = false;
            this.comboOrderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboOrderList.Depth = 0;
            this.comboOrderList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboOrderList.DropDownHeight = 174;
            this.comboOrderList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOrderList.DropDownWidth = 121;
            this.comboOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboOrderList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboOrderList.FormattingEnabled = true;
            this.comboOrderList.Hint = "Choose Order";
            this.comboOrderList.IntegralHeight = false;
            this.comboOrderList.ItemHeight = 43;
            this.comboOrderList.Location = new System.Drawing.Point(563, 10);
            this.comboOrderList.Margin = new System.Windows.Forms.Padding(2);
            this.comboOrderList.MaxDropDownItems = 4;
            this.comboOrderList.MouseState = MaterialSkin.MouseState.OUT;
            this.comboOrderList.Name = "comboOrderList";
            this.comboOrderList.Size = new System.Drawing.Size(134, 49);
            this.comboOrderList.StartIndex = 0;
            this.comboOrderList.TabIndex = 41;
            this.comboOrderList.SelectionChangeCommitted += new System.EventHandler(this.comboOrderList_SelectionChangeCommitted);
            this.comboOrderList.SelectedValueChanged += new System.EventHandler(this.comboOrderList_SelectedValueChanged);
            // 
            // listViewProdOL
            // 
            this.listViewProdOL.AutoSizeTable = false;
            this.listViewProdOL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewProdOL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewProdOL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProdID,
            this.colProdName,
            this.colProdQty,
            this.colProdPrice});
            this.listViewProdOL.Depth = 0;
            this.listViewProdOL.FullRowSelect = true;
            this.listViewProdOL.HideSelection = false;
            this.listViewProdOL.Location = new System.Drawing.Point(339, 63);
            this.listViewProdOL.Margin = new System.Windows.Forms.Padding(2);
            this.listViewProdOL.MinimumSize = new System.Drawing.Size(150, 81);
            this.listViewProdOL.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewProdOL.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewProdOL.Name = "listViewProdOL";
            this.listViewProdOL.OwnerDraw = true;
            this.listViewProdOL.Size = new System.Drawing.Size(450, 375);
            this.listViewProdOL.TabIndex = 40;
            this.listViewProdOL.UseCompatibleStateImageBehavior = false;
            this.listViewProdOL.View = System.Windows.Forms.View.Details;
            // 
            // colProdID
            // 
            this.colProdID.Text = "Product ID";
            this.colProdID.Width = 100;
            // 
            // colProdName
            // 
            this.colProdName.Text = "Product Name";
            this.colProdName.Width = 300;
            // 
            // colProdQty
            // 
            this.colProdQty.Text = "Quantity";
            this.colProdQty.Width = 200;
            // 
            // colProdPrice
            // 
            this.colProdPrice.Text = "Price";
            this.colProdPrice.Width = 200;
            // 
            // txtAgentNameOL
            // 
            this.txtAgentNameOL.AnimateReadOnly = false;
            this.txtAgentNameOL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgentNameOL.Depth = 0;
            this.txtAgentNameOL.Enabled = false;
            this.txtAgentNameOL.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAgentNameOL.Hint = "Agent Name";
            this.txtAgentNameOL.LeadingIcon = null;
            this.txtAgentNameOL.Location = new System.Drawing.Point(84, 107);
            this.txtAgentNameOL.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgentNameOL.MaxLength = 50;
            this.txtAgentNameOL.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAgentNameOL.Multiline = false;
            this.txtAgentNameOL.Name = "txtAgentNameOL";
            this.txtAgentNameOL.Size = new System.Drawing.Size(250, 50);
            this.txtAgentNameOL.TabIndex = 36;
            this.txtAgentNameOL.Text = "";
            this.txtAgentNameOL.TrailingIcon = null;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel9.ForeColor = System.Drawing.Color.Black;
            this.materialLabel9.Location = new System.Drawing.Point(81, 10);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(295, 41);
            this.materialLabel9.TabIndex = 35;
            this.materialLabel9.Text = "Order Management";
            this.materialLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabStatistics
            // 
            this.tabStatistics.Controls.Add(this.dataGDNrv);
            this.tabStatistics.Controls.Add(this.dataGRNrv);
            this.tabStatistics.Controls.Add(this.txtOut);
            this.tabStatistics.Controls.Add(this.txtIn);
            this.tabStatistics.Controls.Add(this.btnLoadMonth);
            this.tabStatistics.Controls.Add(this.txtRevenue);
            this.tabStatistics.Controls.Add(this.materialLabel14);
            this.tabStatistics.Controls.Add(this.materialLabel11);
            this.tabStatistics.Controls.Add(this.dateMonthSelect);
            this.tabStatistics.Controls.Add(this.materialLabel12);
            this.tabStatistics.Controls.Add(this.materialLabel13);
            this.tabStatistics.ImageKey = "statistics-26-32.png";
            this.tabStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Size = new System.Drawing.Size(791, 509);
            this.tabStatistics.TabIndex = 5;
            this.tabStatistics.Text = "Statistics";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // dataGDNrv
            // 
            this.dataGDNrv.AllowUserToAddRows = false;
            this.dataGDNrv.AllowUserToDeleteRows = false;
            this.dataGDNrv.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGDNrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGDNrv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gdnid,
            this.gdnquantity,
            this.gdndate});
            this.dataGDNrv.Location = new System.Drawing.Point(445, 186);
            this.dataGDNrv.Margin = new System.Windows.Forms.Padding(2);
            this.dataGDNrv.Name = "dataGDNrv";
            this.dataGDNrv.ReadOnly = true;
            this.dataGDNrv.RowHeadersWidth = 51;
            this.dataGDNrv.RowTemplate.Height = 24;
            this.dataGDNrv.Size = new System.Drawing.Size(329, 230);
            this.dataGDNrv.TabIndex = 68;
            // 
            // gdnid
            // 
            this.gdnid.HeaderText = "ID";
            this.gdnid.MinimumWidth = 6;
            this.gdnid.Name = "gdnid";
            this.gdnid.ReadOnly = true;
            this.gdnid.Width = 125;
            // 
            // gdnquantity
            // 
            this.gdnquantity.HeaderText = "Quantity";
            this.gdnquantity.MinimumWidth = 6;
            this.gdnquantity.Name = "gdnquantity";
            this.gdnquantity.ReadOnly = true;
            this.gdnquantity.Width = 125;
            // 
            // gdndate
            // 
            this.gdndate.HeaderText = "Date";
            this.gdndate.MinimumWidth = 6;
            this.gdndate.Name = "gdndate";
            this.gdndate.ReadOnly = true;
            this.gdndate.Width = 150;
            // 
            // dataGRNrv
            // 
            this.dataGRNrv.AllowUserToAddRows = false;
            this.dataGRNrv.AllowUserToDeleteRows = false;
            this.dataGRNrv.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGRNrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGRNrv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grnid,
            this.quantity,
            this.grndate});
            this.dataGRNrv.Location = new System.Drawing.Point(88, 186);
            this.dataGRNrv.Margin = new System.Windows.Forms.Padding(2);
            this.dataGRNrv.Name = "dataGRNrv";
            this.dataGRNrv.ReadOnly = true;
            this.dataGRNrv.RowHeadersWidth = 51;
            this.dataGRNrv.RowTemplate.Height = 24;
            this.dataGRNrv.Size = new System.Drawing.Size(329, 230);
            this.dataGRNrv.TabIndex = 67;
            // 
            // grnid
            // 
            this.grnid.HeaderText = "ID";
            this.grnid.MinimumWidth = 6;
            this.grnid.Name = "grnid";
            this.grnid.ReadOnly = true;
            this.grnid.Width = 125;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 125;
            // 
            // grndate
            // 
            this.grndate.HeaderText = "Date";
            this.grndate.MinimumWidth = 6;
            this.grndate.Name = "grndate";
            this.grndate.ReadOnly = true;
            this.grndate.Width = 150;
            // 
            // txtOut
            // 
            this.txtOut.AnimateReadOnly = false;
            this.txtOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOut.Depth = 0;
            this.txtOut.Enabled = false;
            this.txtOut.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOut.Hint = "Exported Products Number";
            this.txtOut.LeadingIcon = null;
            this.txtOut.Location = new System.Drawing.Point(432, 76);
            this.txtOut.Margin = new System.Windows.Forms.Padding(2);
            this.txtOut.MaxLength = 50;
            this.txtOut.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOut.Multiline = false;
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(329, 50);
            this.txtOut.TabIndex = 66;
            this.txtOut.Text = "";
            this.txtOut.TrailingIcon = null;
            // 
            // txtIn
            // 
            this.txtIn.AnimateReadOnly = false;
            this.txtIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIn.Depth = 0;
            this.txtIn.Enabled = false;
            this.txtIn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIn.Hint = "Imported Products Number";
            this.txtIn.LeadingIcon = null;
            this.txtIn.Location = new System.Drawing.Point(432, 14);
            this.txtIn.Margin = new System.Windows.Forms.Padding(2);
            this.txtIn.MaxLength = 50;
            this.txtIn.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIn.Multiline = false;
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(329, 50);
            this.txtIn.TabIndex = 65;
            this.txtIn.Text = "";
            this.txtIn.TrailingIcon = null;
            // 
            // btnLoadMonth
            // 
            this.btnLoadMonth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadMonth.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLoadMonth.Depth = 0;
            this.btnLoadMonth.HighEmphasis = true;
            this.btnLoadMonth.Icon = null;
            this.btnLoadMonth.Location = new System.Drawing.Point(303, 423);
            this.btnLoadMonth.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLoadMonth.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoadMonth.Name = "btnLoadMonth";
            this.btnLoadMonth.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLoadMonth.Size = new System.Drawing.Size(64, 36);
            this.btnLoadMonth.TabIndex = 64;
            this.btnLoadMonth.Text = "Load";
            this.btnLoadMonth.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLoadMonth.UseAccentColor = false;
            this.btnLoadMonth.UseVisualStyleBackColor = true;
            this.btnLoadMonth.Click += new System.EventHandler(this.btnLoadMonth_Click);
            // 
            // txtRevenue
            // 
            this.txtRevenue.AnimateReadOnly = false;
            this.txtRevenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRevenue.Depth = 0;
            this.txtRevenue.Enabled = false;
            this.txtRevenue.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRevenue.Hint = "Revenue";
            this.txtRevenue.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtRevenue.LeadingIcon = null;
            this.txtRevenue.Location = new System.Drawing.Point(98, 420);
            this.txtRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.txtRevenue.MaxLength = 50;
            this.txtRevenue.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRevenue.Multiline = false;
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(170, 50);
            this.txtRevenue.TabIndex = 59;
            this.txtRevenue.Text = "";
            this.txtRevenue.TrailingIcon = null;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel14.Location = new System.Drawing.Point(493, 142);
            this.materialLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(232, 29);
            this.materialLabel14.TabIndex = 57;
            this.materialLabel14.Text = "Goods Delivery Notes";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel11.Location = new System.Drawing.Point(121, 142);
            this.materialLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(246, 29);
            this.materialLabel11.TabIndex = 55;
            this.materialLabel11.Text = "Goods Received Notes";
            // 
            // dateMonthSelect
            // 
            this.dateMonthSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateMonthSelect.Location = new System.Drawing.Point(213, 76);
            this.dateMonthSelect.Margin = new System.Windows.Forms.Padding(2);
            this.dateMonthSelect.Name = "dateMonthSelect";
            this.dateMonthSelect.Size = new System.Drawing.Size(84, 20);
            this.dateMonthSelect.TabIndex = 53;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel12.Location = new System.Drawing.Point(84, 74);
            this.materialLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(125, 24);
            this.materialLabel12.TabIndex = 51;
            this.materialLabel12.Text = "Select Month:";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel13.ForeColor = System.Drawing.Color.Black;
            this.materialLabel13.Location = new System.Drawing.Point(81, 14);
            this.materialLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(255, 41);
            this.materialLabel13.TabIndex = 49;
            this.materialLabel13.Text = "Monthly Statistic";
            this.materialLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.btnResetProfile);
            this.tabProfile.Controls.Add(this.btnSaveProfile);
            this.tabProfile.Controls.Add(this.materialLabel3);
            this.tabProfile.Controls.Add(this.txtPhone);
            this.tabProfile.Controls.Add(this.materialLabel2);
            this.tabProfile.Controls.Add(this.dateBirth);
            this.tabProfile.Controls.Add(this.txtAddress);
            this.tabProfile.Controls.Add(this.radFemale);
            this.tabProfile.Controls.Add(this.radMale);
            this.tabProfile.Controls.Add(this.txtFullname);
            this.tabProfile.ImageKey = "edit-profile-32.png";
            this.tabProfile.Location = new System.Drawing.Point(4, 22);
            this.tabProfile.Margin = new System.Windows.Forms.Padding(2);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Size = new System.Drawing.Size(791, 509);
            this.tabProfile.TabIndex = 2;
            this.tabProfile.Text = "Edit Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // btnResetProfile
            // 
            this.btnResetProfile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResetProfile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnResetProfile.Depth = 0;
            this.btnResetProfile.HighEmphasis = true;
            this.btnResetProfile.Icon = null;
            this.btnResetProfile.Location = new System.Drawing.Point(472, 415);
            this.btnResetProfile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnResetProfile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnResetProfile.Name = "btnResetProfile";
            this.btnResetProfile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnResetProfile.Size = new System.Drawing.Size(65, 36);
            this.btnResetProfile.TabIndex = 9;
            this.btnResetProfile.Text = "Reset";
            this.btnResetProfile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnResetProfile.UseAccentColor = false;
            this.btnResetProfile.UseVisualStyleBackColor = true;
            this.btnResetProfile.Click += new System.EventHandler(this.btnResetProfile_Click);
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveProfile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveProfile.Depth = 0;
            this.btnSaveProfile.HighEmphasis = true;
            this.btnSaveProfile.Icon = null;
            this.btnSaveProfile.Location = new System.Drawing.Point(544, 415);
            this.btnSaveProfile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSaveProfile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveProfile.Size = new System.Drawing.Size(64, 36);
            this.btnSaveProfile.TabIndex = 8;
            this.btnSaveProfile.Text = "Save";
            this.btnSaveProfile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveProfile.UseAccentColor = false;
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(440, 110);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(51, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Gender";
            // 
            // txtPhone
            // 
            this.txtPhone.AnimateReadOnly = false;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Depth = 0;
            this.txtPhone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhone.Hint = "Phone Number";
            this.txtPhone.LeadingIcon = null;
            this.txtPhone.Location = new System.Drawing.Point(189, 202);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(404, 50);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.Text = "";
            this.txtPhone.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(188, 110);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(90, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Date of Birth";
            // 
            // dateBirth
            // 
            this.dateBirth.Location = new System.Drawing.Point(189, 150);
            this.dateBirth.Margin = new System.Windows.Forms.Padding(2);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(182, 20);
            this.dateBirth.TabIndex = 4;
            this.dateBirth.Value = new System.DateTime(2022, 1, 4, 5, 21, 19, 0);
            // 
            // txtAddress
            // 
            this.txtAddress.AnimateReadOnly = false;
            this.txtAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Depth = 0;
            this.txtAddress.HideSelection = true;
            this.txtAddress.Hint = "Address";
            this.txtAddress.Location = new System.Drawing.Point(190, 280);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ReadOnly = false;
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(402, 101);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.TabStop = false;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Depth = 0;
            this.radFemale.Location = new System.Drawing.Point(527, 145);
            this.radFemale.Margin = new System.Windows.Forms.Padding(0);
            this.radFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.radFemale.Name = "radFemale";
            this.radFemale.Ripple = true;
            this.radFemale.Size = new System.Drawing.Size(87, 37);
            this.radFemale.TabIndex = 2;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Depth = 0;
            this.radMale.Location = new System.Drawing.Point(436, 145);
            this.radMale.Margin = new System.Windows.Forms.Padding(0);
            this.radMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.radMale.Name = "radMale";
            this.radMale.Ripple = true;
            this.radMale.Size = new System.Drawing.Size(70, 37);
            this.radMale.TabIndex = 1;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // txtFullname
            // 
            this.txtFullname.AnimateReadOnly = false;
            this.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullname.Depth = 0;
            this.txtFullname.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFullname.Hint = "Fullname";
            this.txtFullname.LeadingIcon = null;
            this.txtFullname.Location = new System.Drawing.Point(189, 34);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullname.MaxLength = 50;
            this.txtFullname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFullname.Multiline = false;
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(404, 50);
            this.txtFullname.TabIndex = 0;
            this.txtFullname.Text = "";
            this.txtFullname.TrailingIcon = null;
            // 
            // tabPass
            // 
            this.tabPass.Controls.Add(this.btnReset);
            this.tabPass.Controls.Add(this.btnChangePass);
            this.tabPass.Controls.Add(this.txtConfPass);
            this.tabPass.Controls.Add(this.txtNewPass);
            this.tabPass.Controls.Add(this.txtCurrPass);
            this.tabPass.ImageKey = "change-password-18-32.png";
            this.tabPass.Location = new System.Drawing.Point(4, 22);
            this.tabPass.Margin = new System.Windows.Forms.Padding(2);
            this.tabPass.Name = "tabPass";
            this.tabPass.Size = new System.Drawing.Size(791, 509);
            this.tabPass.TabIndex = 3;
            this.tabPass.Text = "Change Password";
            this.tabPass.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReset.Depth = 0;
            this.btnReset.HighEmphasis = true;
            this.btnReset.Icon = null;
            this.btnReset.Location = new System.Drawing.Point(244, 353);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReset.Size = new System.Drawing.Size(65, 36);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReset.UseAccentColor = false;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangePass.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChangePass.Depth = 0;
            this.btnChangePass.HighEmphasis = true;
            this.btnChangePass.Icon = null;
            this.btnChangePass.Location = new System.Drawing.Point(315, 353);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnChangePass.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChangePass.Size = new System.Drawing.Size(163, 36);
            this.btnChangePass.TabIndex = 6;
            this.btnChangePass.Text = "Change password";
            this.btnChangePass.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChangePass.UseAccentColor = false;
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // txtConfPass
            // 
            this.txtConfPass.AnimateReadOnly = false;
            this.txtConfPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfPass.Depth = 0;
            this.txtConfPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConfPass.Hint = "New Confirm Password";
            this.txtConfPass.LeadingIcon = null;
            this.txtConfPass.Location = new System.Drawing.Point(233, 265);
            this.txtConfPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfPass.MaxLength = 50;
            this.txtConfPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConfPass.Multiline = false;
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.Password = true;
            this.txtConfPass.Size = new System.Drawing.Size(268, 50);
            this.txtConfPass.TabIndex = 5;
            this.txtConfPass.Text = "";
            this.txtConfPass.TrailingIcon = null;
            // 
            // txtNewPass
            // 
            this.txtNewPass.AnimateReadOnly = false;
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPass.Depth = 0;
            this.txtNewPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNewPass.Hint = "New Password";
            this.txtNewPass.LeadingIcon = null;
            this.txtNewPass.Location = new System.Drawing.Point(233, 175);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPass.MaxLength = 50;
            this.txtNewPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNewPass.Multiline = false;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Password = true;
            this.txtNewPass.Size = new System.Drawing.Size(268, 50);
            this.txtNewPass.TabIndex = 4;
            this.txtNewPass.Text = "";
            this.txtNewPass.TrailingIcon = null;
            // 
            // txtCurrPass
            // 
            this.txtCurrPass.AnimateReadOnly = false;
            this.txtCurrPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrPass.Depth = 0;
            this.txtCurrPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCurrPass.Hint = "Current Password";
            this.txtCurrPass.LeadingIcon = null;
            this.txtCurrPass.Location = new System.Drawing.Point(233, 93);
            this.txtCurrPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrPass.MaxLength = 50;
            this.txtCurrPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCurrPass.Multiline = false;
            this.txtCurrPass.Name = "txtCurrPass";
            this.txtCurrPass.Password = true;
            this.txtCurrPass.Size = new System.Drawing.Size(268, 50);
            this.txtCurrPass.TabIndex = 3;
            this.txtCurrPass.Text = "";
            this.txtCurrPass.TrailingIcon = null;
            // 
            // tabLogout
            // 
            this.tabLogout.Controls.Add(this.btnExit);
            this.tabLogout.Controls.Add(this.btnLogout);
            this.tabLogout.ImageKey = "logout-19-32.png";
            this.tabLogout.Location = new System.Drawing.Point(4, 22);
            this.tabLogout.Margin = new System.Windows.Forms.Padding(2);
            this.tabLogout.Name = "tabLogout";
            this.tabLogout.Size = new System.Drawing.Size(791, 509);
            this.tabLogout.TabIndex = 4;
            this.tabLogout.Text = "Logout";
            this.tabLogout.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExit.Depth = 0;
            this.btnExit.HighEmphasis = true;
            this.btnExit.Icon = null;
            this.btnExit.Location = new System.Drawing.Point(355, 226);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExit.Size = new System.Drawing.Size(64, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "exit ";
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogout.Depth = 0;
            this.btnLogout.HighEmphasis = true;
            this.btnLogout.Icon = null;
            this.btnLogout.Location = new System.Drawing.Point(346, 180);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogout.Size = new System.Drawing.Size(82, 36);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log out ";
            this.btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogout.UseAccentColor = false;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // icon
            // 
            this.icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icon.ImageStream")));
            this.icon.TransparentColor = System.Drawing.Color.Transparent;
            this.icon.Images.SetKeyName(0, "change-password-18-32.png");
            this.icon.Images.SetKeyName(1, "edit-profile-32.png");
            this.icon.Images.SetKeyName(2, "export-52-32.png");
            this.icon.Images.SetKeyName(3, "import-40-32.png");
            this.icon.Images.SetKeyName(4, "logout-19-32.png");
            this.icon.Images.SetKeyName(5, "statistics-26-32.png");
            this.icon.Images.SetKeyName(6, "2639879_order_icon.png");
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // formUserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "formUserInterface";
            this.Padding = new System.Windows.Forms.Padding(1, 64, 1, 1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANG TAN Co.,Ltd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formUserInterface_FormClosing);
            this.materialTabControl1.ResumeLayout(false);
            this.tabGRN.ResumeLayout(false);
            this.tabGRN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGRNProd)).EndInit();
            this.tabGDN.ResumeLayout(false);
            this.tabGDN.PerformLayout();
            this.tabOrderList.ResumeLayout(false);
            this.tabOrderList.PerformLayout();
            this.tabStatistics.ResumeLayout(false);
            this.tabStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGDNrv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGRNrv)).EndInit();
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            this.tabPass.ResumeLayout(false);
            this.tabPass.PerformLayout();
            this.tabLogout.ResumeLayout(false);
            this.tabLogout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabGRN;
        private System.Windows.Forms.TabPage tabGDN;
        private System.Windows.Forms.TabPage tabStatistics;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabPass;
        private System.Windows.Forms.TabPage tabLogout;
        private System.Windows.Forms.ImageList icon;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private MaterialSkin.Controls.MaterialTextBox txtCurrPass;
        private MaterialSkin.Controls.MaterialTextBox txtConfPass;
        private MaterialSkin.Controls.MaterialTextBox txtNewPass;
        private MaterialSkin.Controls.MaterialButton btnReset;
        private MaterialSkin.Controls.MaterialButton btnChangePass;
        private MaterialSkin.Controls.MaterialRadioButton radFemale;
        private MaterialSkin.Controls.MaterialRadioButton radMale;
        private MaterialSkin.Controls.MaterialTextBox txtFullname;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtAddress;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txtPhone;
        private MaterialSkin.Controls.MaterialButton btnResetProfile;
        private MaterialSkin.Controls.MaterialButton btnSaveProfile;
        private MaterialSkin.Controls.MaterialButton btnGRNReset;
        private MaterialSkin.Controls.MaterialButton btnGRNSave;
        private System.Windows.Forms.DateTimePicker dateGRN;
        private MaterialSkin.Controls.MaterialTextBox txtProdPrice;
        private MaterialSkin.Controls.MaterialTextBox txtProdQty;
        private MaterialSkin.Controls.MaterialTextBox txtProdName;
        private MaterialSkin.Controls.MaterialTextBox txtChecker;
        private MaterialSkin.Controls.MaterialTextBox txtReceiver;
        private MaterialSkin.Controls.MaterialButton btnProdDel;
        private MaterialSkin.Controls.MaterialButton btnProdAdd;
        private MaterialSkin.Controls.MaterialTextBox txtGRNID;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox txtSupplier;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox comboOrderGDN;
        private MaterialSkin.Controls.MaterialButton btnGDNPrint;
        private System.Windows.Forms.DateTimePicker dateDelivery;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox txtAgentName;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.TabPage tabOrderList;
        private MaterialSkin.Controls.MaterialTextBox txtAgentAddress;
        private MaterialSkin.Controls.MaterialTextBox txtAgentPhone;
        private MaterialSkin.Controls.MaterialTextBox txtAgentAddressOL;
        private MaterialSkin.Controls.MaterialTextBox txtAgentPhoneOL;
        private MaterialSkin.Controls.MaterialComboBox comboOrderList;
        private MaterialSkin.Controls.MaterialListView listViewProdOL;
        private MaterialSkin.Controls.MaterialTextBox txtAgentNameOL;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.DataGridView dataGRNProd;
        private MaterialSkin.Controls.MaterialListView listViewProdGDN;
        private MaterialSkin.Controls.MaterialCheckbox cbxIfPayment;
        private System.Windows.Forms.DateTimePicker dateListEnd;
        private System.Windows.Forms.DateTimePicker dateListStart;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialComboBox comboOrderStatusOL;
        private MaterialSkin.Controls.MaterialButton btnSaveOL;
        private System.Windows.Forms.DateTimePicker dateMonthSelect;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialTextBox txtRevenue;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialTextBox txtProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodid;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPrice;
        private MaterialSkin.Controls.MaterialButton btnLoadOrder;
        private System.Windows.Forms.ColumnHeader colProdID;
        private System.Windows.Forms.ColumnHeader colProdName;
        private System.Windows.Forms.ColumnHeader colProdQty;
        private System.Windows.Forms.ColumnHeader colProdPrice;
        private MaterialSkin.Controls.MaterialButton btnLoadGDN;
        private System.Windows.Forms.ColumnHeader colProdIDGDN;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialCheckbox cbxIsPaid;
        private MaterialSkin.Controls.MaterialTextBox txtMethod;
        private MaterialSkin.Controls.MaterialTextBox txtTotal;
        private System.Windows.Forms.PrintDialog printDialog1;
        private MaterialSkin.Controls.MaterialButton btnLoadMonth;
        private MaterialSkin.Controls.MaterialTextBox txtIn;
        private MaterialSkin.Controls.MaterialTextBox txtOut;
        private System.Windows.Forms.DataGridView dataGDNrv;
        private System.Windows.Forms.DataGridView dataGRNrv;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdnid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdnquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdndate;
        private System.Windows.Forms.DataGridViewTextBoxColumn grnid;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn grndate;
    }
}
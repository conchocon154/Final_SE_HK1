namespace App
{
    partial class Admin
    {
       
        private System.ComponentModel.IContainer components = null;

       
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnAddUser = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsernameAdmin = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPassAdmin = new MaterialSkin.Controls.MaterialTextBox();
            this.btnDelUser = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdateUser = new MaterialSkin.Controls.MaterialButton();
            this.dataUser = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cosmesticDBDataSet = new App.CosmesticDBDataSet();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.userTableAdapter = new App.CosmesticDBDataSetTableAdapters.UserTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmesticDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddUser.Depth = 0;
            this.btnAddUser.HighEmphasis = true;
            this.btnAddUser.Icon = null;
            this.btnAddUser.Location = new System.Drawing.Point(405, 508);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddUser.Size = new System.Drawing.Size(64, 36);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddUser.UseAccentColor = false;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(16, 74);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(281, 41);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "User Management";
            // 
            // txtUsernameAdmin
            // 
            this.txtUsernameAdmin.AnimateReadOnly = false;
            this.txtUsernameAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsernameAdmin.Depth = 0;
            this.txtUsernameAdmin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsernameAdmin.Hint = "Username";
            this.txtUsernameAdmin.LeadingIcon = null;
            this.txtUsernameAdmin.Location = new System.Drawing.Point(32, 306);
            this.txtUsernameAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsernameAdmin.MaxLength = 50;
            this.txtUsernameAdmin.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsernameAdmin.Multiline = false;
            this.txtUsernameAdmin.Name = "txtUsernameAdmin";
            this.txtUsernameAdmin.Size = new System.Drawing.Size(208, 50);
            this.txtUsernameAdmin.TabIndex = 2;
            this.txtUsernameAdmin.Text = "";
            this.txtUsernameAdmin.TrailingIcon = null;
            // 
            // txtPassAdmin
            // 
            this.txtPassAdmin.AnimateReadOnly = false;
            this.txtPassAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassAdmin.Depth = 0;
            this.txtPassAdmin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassAdmin.Hint = "Password";
            this.txtPassAdmin.LeadingIcon = null;
            this.txtPassAdmin.Location = new System.Drawing.Point(32, 369);
            this.txtPassAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassAdmin.MaxLength = 50;
            this.txtPassAdmin.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassAdmin.Multiline = false;
            this.txtPassAdmin.Name = "txtPassAdmin";
            this.txtPassAdmin.Password = true;
            this.txtPassAdmin.Size = new System.Drawing.Size(208, 50);
            this.txtPassAdmin.TabIndex = 3;
            this.txtPassAdmin.Text = "";
            this.txtPassAdmin.TrailingIcon = null;
            // 
            // btnDelUser
            // 
            this.btnDelUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelUser.Depth = 0;
            this.btnDelUser.HighEmphasis = true;
            this.btnDelUser.Icon = null;
            this.btnDelUser.Location = new System.Drawing.Point(493, 508);
            this.btnDelUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDelUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelUser.Size = new System.Drawing.Size(73, 36);
            this.btnDelUser.TabIndex = 4;
            this.btnDelUser.Text = "delete";
            this.btnDelUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelUser.UseAccentColor = false;
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdateUser.Depth = 0;
            this.btnUpdateUser.HighEmphasis = true;
            this.btnUpdateUser.Icon = null;
            this.btnUpdateUser.Location = new System.Drawing.Point(587, 508);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnUpdateUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdateUser.Size = new System.Drawing.Size(77, 36);
            this.btnUpdateUser.TabIndex = 5;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateUser.UseAccentColor = false;
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // dataUser
            // 
            this.dataUser.AutoGenerateColumns = false;
            this.dataUser.BackgroundColor = System.Drawing.Color.Silver;
            this.dataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.bDateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataUser.DataSource = this.userBindingSource;
            this.dataUser.Location = new System.Drawing.Point(293, 131);
            this.dataUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataUser.Name = "dataUser";
            this.dataUser.RowHeadersWidth = 51;
            this.dataUser.RowTemplate.Height = 24;
            this.dataUser.Size = new System.Drawing.Size(474, 361);
            this.dataUser.TabIndex = 6;
            this.dataUser.SelectionChanged += new System.EventHandler(this.dataUser_SelectionChanged);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "fullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // bDateDataGridViewTextBoxColumn
            // 
            this.bDateDataGridViewTextBoxColumn.DataPropertyName = "BDate";
            this.bDateDataGridViewTextBoxColumn.HeaderText = "BDate";
            this.bDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDateDataGridViewTextBoxColumn.Name = "bDateDataGridViewTextBoxColumn";
            this.bDateDataGridViewTextBoxColumn.Width = 140;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.cosmesticDBDataSet;
            // 
            // cosmesticDBDataSet
            // 
            this.cosmesticDBDataSet.DataSetName = "CosmesticDBDataSet";
            this.cosmesticDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(689, 74);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(78, 36);
            this.materialButton1.TabIndex = 7;
            this.materialButton1.Text = "Logout";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 143);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.dataUser);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.txtPassAdmin);
            this.Controls.Add(this.txtUsernameAdmin);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnAddUser);
            this.Name = "Admin";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "DANG TAN Co.,Ltd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmesticDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnAddUser;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtUsernameAdmin;
        private MaterialSkin.Controls.MaterialTextBox txtPassAdmin;
        private MaterialSkin.Controls.MaterialButton btnDelUser;
        private MaterialSkin.Controls.MaterialButton btnUpdateUser;
        private System.Windows.Forms.DataGridView dataUser;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private CosmesticDBDataSet cosmesticDBDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private CosmesticDBDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
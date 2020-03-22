namespace ALT_R_DB_Manager
{
    partial class DbManagementForm
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
            this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.adminPage = new System.Windows.Forms.TabPage();
            this.adminPageTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.registerPage = new System.Windows.Forms.TabPage();
            this.registerPageLoginPanel = new System.Windows.Forms.Panel();
            this.showpasswordCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.registerUserBtn = new MaterialSkin.Controls.MaterialButton();
            this.loadImageBtn = new MaterialSkin.Controls.MaterialButton();
            this.selectRole = new MaterialSkin.Controls.MaterialComboBox();
            this.selectSex = new MaterialSkin.Controls.MaterialComboBox();
            this.lastnameTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.confirmpasswordTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.usernameTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.emailTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.firstnameTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.viewPage = new System.Windows.Forms.TabPage();
            this.adminPageTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.prisonPage = new System.Windows.Forms.TabPage();
            this.prisonerPage = new System.Windows.Forms.TabPage();
            this.visitorPage = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox5 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox6 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox7 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.registerImagepictureBox = new System.Windows.Forms.PictureBox();
            this.adminPageRegisterPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainTabControl.SuspendLayout();
            this.adminPage.SuspendLayout();
            this.adminPageTabControl.SuspendLayout();
            this.registerPage.SuspendLayout();
            this.registerPageLoginPanel.SuspendLayout();
            this.viewPage.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerImagepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminPageRegisterPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.adminPage);
            this.mainTabControl.Controls.Add(this.prisonPage);
            this.mainTabControl.Controls.Add(this.prisonerPage);
            this.mainTabControl.Controls.Add(this.visitorPage);
            this.mainTabControl.Depth = 0;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(920, 500);
            this.mainTabControl.TabIndex = 0;
            // 
            // adminPage
            // 
            this.adminPage.Controls.Add(this.adminPageTabControl);
            this.adminPage.Controls.Add(this.adminPageTabSelector);
            this.adminPage.Location = new System.Drawing.Point(4, 24);
            this.adminPage.Name = "adminPage";
            this.adminPage.Padding = new System.Windows.Forms.Padding(3);
            this.adminPage.Size = new System.Drawing.Size(912, 472);
            this.adminPage.TabIndex = 0;
            this.adminPage.Text = "Administrator";
            this.adminPage.UseVisualStyleBackColor = true;
            // 
            // adminPageTabControl
            // 
            this.adminPageTabControl.Controls.Add(this.registerPage);
            this.adminPageTabControl.Controls.Add(this.viewPage);
            this.adminPageTabControl.Depth = 0;
            this.adminPageTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminPageTabControl.Location = new System.Drawing.Point(3, 38);
            this.adminPageTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.adminPageTabControl.Name = "adminPageTabControl";
            this.adminPageTabControl.SelectedIndex = 0;
            this.adminPageTabControl.Size = new System.Drawing.Size(906, 431);
            this.adminPageTabControl.TabIndex = 1;
            // 
            // registerPage
            // 
            this.registerPage.Controls.Add(this.materialCard1);
            this.registerPage.Controls.Add(this.registerPageLoginPanel);
            this.registerPage.Controls.Add(this.adminPageRegisterPicture);
            this.registerPage.Location = new System.Drawing.Point(4, 24);
            this.registerPage.Name = "registerPage";
            this.registerPage.Padding = new System.Windows.Forms.Padding(3);
            this.registerPage.Size = new System.Drawing.Size(898, 403);
            this.registerPage.TabIndex = 0;
            this.registerPage.Text = "Register";
            this.registerPage.UseVisualStyleBackColor = true;
            // 
            // registerPageLoginPanel
            // 
            this.registerPageLoginPanel.BackColor = System.Drawing.Color.White;
            this.registerPageLoginPanel.Controls.Add(this.showpasswordCheckBox);
            this.registerPageLoginPanel.Controls.Add(this.registerUserBtn);
            this.registerPageLoginPanel.Controls.Add(this.loadImageBtn);
            this.registerPageLoginPanel.Controls.Add(this.selectRole);
            this.registerPageLoginPanel.Controls.Add(this.selectSex);
            this.registerPageLoginPanel.Controls.Add(this.lastnameTextbox);
            this.registerPageLoginPanel.Controls.Add(this.confirmpasswordTextbox);
            this.registerPageLoginPanel.Controls.Add(this.passwordTextbox);
            this.registerPageLoginPanel.Controls.Add(this.usernameTextbox);
            this.registerPageLoginPanel.Controls.Add(this.emailTextbox);
            this.registerPageLoginPanel.Controls.Add(this.firstnameTextbox);
            this.registerPageLoginPanel.Controls.Add(this.registerImagepictureBox);
            this.registerPageLoginPanel.Location = new System.Drawing.Point(16, 17);
            this.registerPageLoginPanel.Name = "registerPageLoginPanel";
            this.registerPageLoginPanel.Size = new System.Drawing.Size(565, 370);
            this.registerPageLoginPanel.TabIndex = 1;
            // 
            // showpasswordCheckBox
            // 
            this.showpasswordCheckBox.AutoSize = true;
            this.showpasswordCheckBox.Depth = 0;
            this.showpasswordCheckBox.Location = new System.Drawing.Point(390, 302);
            this.showpasswordCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.showpasswordCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.showpasswordCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.showpasswordCheckBox.Name = "showpasswordCheckBox";
            this.showpasswordCheckBox.Ripple = true;
            this.showpasswordCheckBox.Size = new System.Drawing.Size(157, 37);
            this.showpasswordCheckBox.TabIndex = 5;
            this.showpasswordCheckBox.Text = "Show Passwords";
            this.showpasswordCheckBox.UseVisualStyleBackColor = true;
            this.showpasswordCheckBox.CheckedChanged += new System.EventHandler(this.materialCheckbox1_CheckedChanged);
            // 
            // registerUserBtn
            // 
            this.registerUserBtn.AutoSize = false;
            this.registerUserBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerUserBtn.Depth = 0;
            this.registerUserBtn.DrawShadows = true;
            this.registerUserBtn.HighEmphasis = true;
            this.registerUserBtn.Icon = null;
            this.registerUserBtn.Location = new System.Drawing.Point(8, 295);
            this.registerUserBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registerUserBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerUserBtn.Name = "registerUserBtn";
            this.registerUserBtn.Size = new System.Drawing.Size(200, 50);
            this.registerUserBtn.TabIndex = 4;
            this.registerUserBtn.Text = "Register User";
            this.registerUserBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.registerUserBtn.UseAccentColor = true;
            this.registerUserBtn.UseVisualStyleBackColor = true;
            this.registerUserBtn.Click += new System.EventHandler(this.registerUserBtn_Click);
            // 
            // loadImageBtn
            // 
            this.loadImageBtn.AutoSize = false;
            this.loadImageBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadImageBtn.Depth = 0;
            this.loadImageBtn.DrawShadows = true;
            this.loadImageBtn.HighEmphasis = true;
            this.loadImageBtn.Icon = null;
            this.loadImageBtn.Location = new System.Drawing.Point(8, 233);
            this.loadImageBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loadImageBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loadImageBtn.Name = "loadImageBtn";
            this.loadImageBtn.Size = new System.Drawing.Size(200, 50);
            this.loadImageBtn.TabIndex = 4;
            this.loadImageBtn.Text = "Load Image";
            this.loadImageBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loadImageBtn.UseAccentColor = false;
            this.loadImageBtn.UseVisualStyleBackColor = true;
            this.loadImageBtn.Click += new System.EventHandler(this.loadImageBtn_Click);
            // 
            // selectRole
            // 
            this.selectRole.AutoResize = false;
            this.selectRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.selectRole.Depth = 0;
            this.selectRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.selectRole.DropDownHeight = 174;
            this.selectRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectRole.DropDownWidth = 121;
            this.selectRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.selectRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.selectRole.FormattingEnabled = true;
            this.selectRole.Hint = "Role";
            this.selectRole.IntegralHeight = false;
            this.selectRole.ItemHeight = 43;
            this.selectRole.Items.AddRange(new object[] {
            "Software Engineer",
            "Database Manager",
            "Data Entry Clerk",
            "System Analyst"});
            this.selectRole.Location = new System.Drawing.Point(390, 121);
            this.selectRole.MaxDropDownItems = 4;
            this.selectRole.MouseState = MaterialSkin.MouseState.OUT;
            this.selectRole.Name = "selectRole";
            this.selectRole.Size = new System.Drawing.Size(169, 49);
            this.selectRole.TabIndex = 3;
            this.selectRole.SelectionChangeCommitted += new System.EventHandler(this.selectRole_SelectionChangeCommitted);
            // 
            // selectSex
            // 
            this.selectSex.AutoResize = false;
            this.selectSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.selectSex.Depth = 0;
            this.selectSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.selectSex.DropDownHeight = 174;
            this.selectSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectSex.DropDownWidth = 121;
            this.selectSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.selectSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.selectSex.FormattingEnabled = true;
            this.selectSex.Hint = "Sex";
            this.selectSex.IntegralHeight = false;
            this.selectSex.ItemHeight = 43;
            this.selectSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.selectSex.Location = new System.Drawing.Point(215, 121);
            this.selectSex.MaxDropDownItems = 4;
            this.selectSex.MouseState = MaterialSkin.MouseState.OUT;
            this.selectSex.Name = "selectSex";
            this.selectSex.Size = new System.Drawing.Size(169, 49);
            this.selectSex.TabIndex = 3;
            this.selectSex.SelectionChangeCommitted += new System.EventHandler(this.selectSex_SelectionChangeCommitted);
            // 
            // lastnameTextbox
            // 
            this.lastnameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastnameTextbox.Depth = 0;
            this.lastnameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lastnameTextbox.Hint = "Last Name";
            this.lastnameTextbox.Location = new System.Drawing.Point(390, 8);
            this.lastnameTextbox.MaxLength = 50;
            this.lastnameTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.lastnameTextbox.Multiline = false;
            this.lastnameTextbox.Name = "lastnameTextbox";
            this.lastnameTextbox.Size = new System.Drawing.Size(170, 50);
            this.lastnameTextbox.TabIndex = 2;
            this.lastnameTextbox.Text = "";
            this.lastnameTextbox.TextChanged += new System.EventHandler(this.lastnameTextbox_TextChanged);
            // 
            // confirmpasswordTextbox
            // 
            this.confirmpasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmpasswordTextbox.Depth = 0;
            this.confirmpasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.confirmpasswordTextbox.Hint = "Confirm Password";
            this.confirmpasswordTextbox.Location = new System.Drawing.Point(389, 176);
            this.confirmpasswordTextbox.MaxLength = 50;
            this.confirmpasswordTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.confirmpasswordTextbox.Multiline = false;
            this.confirmpasswordTextbox.Name = "confirmpasswordTextbox";
            this.confirmpasswordTextbox.Password = true;
            this.confirmpasswordTextbox.Size = new System.Drawing.Size(170, 50);
            this.confirmpasswordTextbox.TabIndex = 2;
            this.confirmpasswordTextbox.Text = "";
            this.confirmpasswordTextbox.TextChanged += new System.EventHandler(this.confirmpasswordTextbox_TextChanged);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextbox.Depth = 0;
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordTextbox.Hint = "Password";
            this.passwordTextbox.Location = new System.Drawing.Point(214, 176);
            this.passwordTextbox.MaxLength = 50;
            this.passwordTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextbox.Multiline = false;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Password = true;
            this.passwordTextbox.Size = new System.Drawing.Size(170, 50);
            this.passwordTextbox.TabIndex = 2;
            this.passwordTextbox.Text = "";
            this.passwordTextbox.TextChanged += new System.EventHandler(this.passwordTextbox_TextChanged);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextbox.Depth = 0;
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameTextbox.Hint = "Username";
            this.usernameTextbox.Location = new System.Drawing.Point(213, 233);
            this.usernameTextbox.MaxLength = 50;
            this.usernameTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameTextbox.Multiline = false;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(346, 50);
            this.usernameTextbox.TabIndex = 2;
            this.usernameTextbox.Text = "";
            // 
            // emailTextbox
            // 
            this.emailTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextbox.Depth = 0;
            this.emailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailTextbox.Hint = "Email Address";
            this.emailTextbox.Location = new System.Drawing.Point(214, 64);
            this.emailTextbox.MaxLength = 50;
            this.emailTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.emailTextbox.Multiline = false;
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(346, 50);
            this.emailTextbox.TabIndex = 2;
            this.emailTextbox.Text = "";
            this.emailTextbox.TextChanged += new System.EventHandler(this.emailTextbox_TextChanged);
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstnameTextbox.Depth = 0;
            this.firstnameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.firstnameTextbox.Hint = "First Name";
            this.firstnameTextbox.Location = new System.Drawing.Point(214, 8);
            this.firstnameTextbox.MaxLength = 50;
            this.firstnameTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.firstnameTextbox.Multiline = false;
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.Size = new System.Drawing.Size(170, 50);
            this.firstnameTextbox.TabIndex = 2;
            this.firstnameTextbox.Text = "";
            this.firstnameTextbox.TextChanged += new System.EventHandler(this.firstnameTextbox_TextChanged);
            // 
            // viewPage
            // 
            this.viewPage.Controls.Add(this.materialListView1);
            this.viewPage.Controls.Add(this.pictureBox1);
            this.viewPage.Location = new System.Drawing.Point(4, 24);
            this.viewPage.Name = "viewPage";
            this.viewPage.Padding = new System.Windows.Forms.Padding(3);
            this.viewPage.Size = new System.Drawing.Size(898, 403);
            this.viewPage.TabIndex = 1;
            this.viewPage.Text = "View";
            this.viewPage.UseVisualStyleBackColor = true;
            // 
            // adminPageTabSelector
            // 
            this.adminPageTabSelector.BaseTabControl = this.adminPageTabControl;
            this.adminPageTabSelector.Depth = 0;
            this.adminPageTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminPageTabSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.adminPageTabSelector.Location = new System.Drawing.Point(3, 3);
            this.adminPageTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.adminPageTabSelector.Name = "adminPageTabSelector";
            this.adminPageTabSelector.Size = new System.Drawing.Size(906, 35);
            this.adminPageTabSelector.TabIndex = 0;
            // 
            // prisonPage
            // 
            this.prisonPage.Location = new System.Drawing.Point(4, 24);
            this.prisonPage.Name = "prisonPage";
            this.prisonPage.Padding = new System.Windows.Forms.Padding(3);
            this.prisonPage.Size = new System.Drawing.Size(912, 472);
            this.prisonPage.TabIndex = 1;
            this.prisonPage.Text = "Prison";
            this.prisonPage.UseVisualStyleBackColor = true;
            // 
            // prisonerPage
            // 
            this.prisonerPage.Location = new System.Drawing.Point(4, 24);
            this.prisonerPage.Name = "prisonerPage";
            this.prisonerPage.Size = new System.Drawing.Size(912, 472);
            this.prisonerPage.TabIndex = 2;
            this.prisonerPage.Text = "Prisoner";
            this.prisonerPage.UseVisualStyleBackColor = true;
            // 
            // visitorPage
            // 
            this.visitorPage.Location = new System.Drawing.Point(4, 24);
            this.visitorPage.Name = "visitorPage";
            this.visitorPage.Size = new System.Drawing.Size(912, 472);
            this.visitorPage.TabIndex = 3;
            this.visitorPage.Text = "Visitor";
            this.visitorPage.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.materialCheckbox7);
            this.materialCard1.Controls.Add(this.materialCheckbox6);
            this.materialCard1.Controls.Add(this.materialCheckbox5);
            this.materialCard1.Controls.Add(this.materialCheckbox4);
            this.materialCard1.Controls.Add(this.materialCheckbox3);
            this.materialCard1.Controls.Add(this.materialCheckbox2);
            this.materialCard1.Controls.Add(this.materialCheckbox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(598, 17);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(283, 246);
            this.materialCard1.TabIndex = 2;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(14, 43);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(130, 37);
            this.materialCheckbox1.TabIndex = 0;
            this.materialCheckbox1.Text = "First Name";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(144, 43);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(130, 37);
            this.materialCheckbox2.TabIndex = 0;
            this.materialCheckbox2.Text = "Last Name";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox3
            // 
            this.materialCheckbox3.Depth = 0;
            this.materialCheckbox3.Location = new System.Drawing.Point(14, 80);
            this.materialCheckbox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox3.Name = "materialCheckbox3";
            this.materialCheckbox3.Ripple = true;
            this.materialCheckbox3.Size = new System.Drawing.Size(171, 37);
            this.materialCheckbox3.TabIndex = 0;
            this.materialCheckbox3.Text = "Email Address";
            this.materialCheckbox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox4
            // 
            this.materialCheckbox4.Depth = 0;
            this.materialCheckbox4.Location = new System.Drawing.Point(14, 116);
            this.materialCheckbox4.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox4.Name = "materialCheckbox4";
            this.materialCheckbox4.Ripple = true;
            this.materialCheckbox4.Size = new System.Drawing.Size(130, 37);
            this.materialCheckbox4.TabIndex = 0;
            this.materialCheckbox4.Text = "Gender";
            this.materialCheckbox4.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox5
            // 
            this.materialCheckbox5.Depth = 0;
            this.materialCheckbox5.Location = new System.Drawing.Point(139, 116);
            this.materialCheckbox5.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox5.Name = "materialCheckbox5";
            this.materialCheckbox5.Ripple = true;
            this.materialCheckbox5.Size = new System.Drawing.Size(130, 37);
            this.materialCheckbox5.TabIndex = 0;
            this.materialCheckbox5.Text = "Role";
            this.materialCheckbox5.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox6
            // 
            this.materialCheckbox6.Depth = 0;
            this.materialCheckbox6.Location = new System.Drawing.Point(14, 190);
            this.materialCheckbox6.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox6.Name = "materialCheckbox6";
            this.materialCheckbox6.Ripple = true;
            this.materialCheckbox6.Size = new System.Drawing.Size(130, 37);
            this.materialCheckbox6.TabIndex = 0;
            this.materialCheckbox6.Text = "Password";
            this.materialCheckbox6.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox7
            // 
            this.materialCheckbox7.Depth = 0;
            this.materialCheckbox7.Location = new System.Drawing.Point(14, 153);
            this.materialCheckbox7.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox7.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox7.Name = "materialCheckbox7";
            this.materialCheckbox7.Ripple = true;
            this.materialCheckbox7.Size = new System.Drawing.Size(171, 37);
            this.materialCheckbox7.TabIndex = 0;
            this.materialCheckbox7.Text = "Confirm Password";
            this.materialCheckbox7.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Required";
            this.materialLabel1.UseAccent = true;
            // 
            // registerImagepictureBox
            // 
            this.registerImagepictureBox.BackColor = System.Drawing.Color.White;
            this.registerImagepictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerImagepictureBox.Location = new System.Drawing.Point(8, 8);
            this.registerImagepictureBox.Name = "registerImagepictureBox";
            this.registerImagepictureBox.Size = new System.Drawing.Size(200, 218);
            this.registerImagepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.registerImagepictureBox.TabIndex = 1;
            this.registerImagepictureBox.TabStop = false;
            // 
            // adminPageRegisterPicture
            // 
            this.adminPageRegisterPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminPageRegisterPicture.Image = global::ALT_R_DB_Manager.Properties.Resources.office3;
            this.adminPageRegisterPicture.Location = new System.Drawing.Point(3, 3);
            this.adminPageRegisterPicture.Name = "adminPageRegisterPicture";
            this.adminPageRegisterPicture.Size = new System.Drawing.Size(892, 397);
            this.adminPageRegisterPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminPageRegisterPicture.TabIndex = 0;
            this.adminPageRegisterPicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ALT_R_DB_Manager.Properties.Resources.Material_Backgrounds_15_1366_x_768;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(892, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(18, 21);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.Size = new System.Drawing.Size(853, 100);
            this.materialListView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.materialListView1.TabIndex = 2;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "First Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Last Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Gender";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Role";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "Email Address";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 5;
            this.columnHeader6.Text = "Username";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 6;
            this.columnHeader7.Text = "AdminID";
            this.columnHeader7.Width = 150;
            // 
            // DbManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 500);
            this.Controls.Add(this.mainTabControl);
            this.DrawerIndicatorWidth = 10;
            this.DrawerTabControl = this.mainTabControl;
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "DbManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DbManagementForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.adminPage.ResumeLayout(false);
            this.adminPageTabControl.ResumeLayout(false);
            this.registerPage.ResumeLayout(false);
            this.registerPageLoginPanel.ResumeLayout(false);
            this.registerPageLoginPanel.PerformLayout();
            this.viewPage.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerImagepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminPageRegisterPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage adminPage;
        private MaterialSkin.Controls.MaterialTabControl adminPageTabControl;
        private System.Windows.Forms.TabPage registerPage;
        private System.Windows.Forms.TabPage viewPage;
        private MaterialSkin.Controls.MaterialTabSelector adminPageTabSelector;
        private System.Windows.Forms.TabPage prisonPage;
        private System.Windows.Forms.TabPage prisonerPage;
        private System.Windows.Forms.TabPage visitorPage;
        private System.Windows.Forms.PictureBox adminPageRegisterPicture;
        private System.Windows.Forms.Panel registerPageLoginPanel;
        private MaterialSkin.Controls.MaterialCheckbox showpasswordCheckBox;
        private MaterialSkin.Controls.MaterialButton registerUserBtn;
        private MaterialSkin.Controls.MaterialButton loadImageBtn;
        private MaterialSkin.Controls.MaterialComboBox selectRole;
        private MaterialSkin.Controls.MaterialComboBox selectSex;
        private MaterialSkin.Controls.MaterialTextBox lastnameTextbox;
        private MaterialSkin.Controls.MaterialTextBox confirmpasswordTextbox;
        private MaterialSkin.Controls.MaterialTextBox passwordTextbox;
        private MaterialSkin.Controls.MaterialTextBox usernameTextbox;
        private MaterialSkin.Controls.MaterialTextBox emailTextbox;
        private MaterialSkin.Controls.MaterialTextBox firstnameTextbox;
        private System.Windows.Forms.PictureBox registerImagepictureBox;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox7;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox6;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox5;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox4;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox3;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}
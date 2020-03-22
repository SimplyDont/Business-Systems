namespace ALT_R_DB_Manager
{
    partial class SignInForm
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
            this.emailTextboc = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.loginBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.SuspendLayout();
            // 
            // emailTextboc
            // 
            this.emailTextboc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextboc.Depth = 0;
            this.emailTextboc.Font = new System.Drawing.Font("Roboto", 12F);
            this.emailTextboc.Hint = "Email";
            this.emailTextboc.Location = new System.Drawing.Point(12, 122);
            this.emailTextboc.MaxLength = 50;
            this.emailTextboc.MouseState = MaterialSkin.MouseState.OUT;
            this.emailTextboc.Multiline = false;
            this.emailTextboc.Name = "emailTextboc";
            this.emailTextboc.Size = new System.Drawing.Size(276, 50);
            this.emailTextboc.TabIndex = 1;
            this.emailTextboc.Text = "";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextbox.Depth = 0;
            this.passwordTextbox.DetectUrls = false;
            this.passwordTextbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.passwordTextbox.Hint = "Password";
            this.passwordTextbox.Location = new System.Drawing.Point(12, 187);
            this.passwordTextbox.MaxLength = 50;
            this.passwordTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextbox.Multiline = false;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Password = true;
            this.passwordTextbox.Size = new System.Drawing.Size(276, 50);
            this.passwordTextbox.TabIndex = 2;
            this.passwordTextbox.Text = "";
            // 
            // loginBtn
            // 
            this.loginBtn.AutoSize = false;
            this.loginBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginBtn.Depth = 0;
            this.loginBtn.DrawShadows = true;
            this.loginBtn.HighEmphasis = true;
            this.loginBtn.Icon = null;
            this.loginBtn.Location = new System.Drawing.Point(13, 252);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.loginBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(274, 58);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loginBtn.UseAccentColor = true;
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.materialLabel1.Location = new System.Drawing.Point(202, 360);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(85, 13);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "© ALT+R Solutions";
            this.materialLabel1.UseAccent = true;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Font = new System.Drawing.Font("Open Sans", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCheckbox1.Location = new System.Drawing.Point(12, 347);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(115, 38);
            this.materialCheckbox1.TabIndex = 4;
            this.materialCheckbox1.Text = "Dark Mode";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            this.materialCheckbox1.CheckedChanged += new System.EventHandler(this.materialCheckbox1_CheckedChanged);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 404);
            this.Controls.Add(this.materialCheckbox1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.emailTextboc);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox emailTextboc;
        private MaterialSkin.Controls.MaterialTextBox passwordTextbox;
        private MaterialSkin.Controls.MaterialButton loginBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
    }
}
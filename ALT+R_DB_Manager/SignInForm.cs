using ALT_R_Management_Library.Api;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALT_R_DB_Manager
{
    public partial class SignInForm : MaterialForm
    {
        ALT_R_ApiProcessor apiProcessor = new ALT_R_ApiProcessor();
        MaterialSkinManager skinManager = MaterialSkinManager.Instance;
        public SignInForm()
        {
            InitializeComponent();
            ALT_R_ApiHelper.IntializeClient();
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Color.Crimson, Color.Black, Color.Black, Color.Crimson, TextShade.WHITE);

        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckbox1.Checked)
                skinManager.Theme = MaterialSkinManager.Themes.DARK;
            else if(!materialCheckbox1.Checked)
                skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var token = await apiProcessor.AuthenticateUser(emailTextboc.Text, passwordTextbox.Text);
                var user = await apiProcessor.SignIn(emailTextboc.Text, passwordTextbox.Text, token.Access_Token);
                CheckLoginRole(user);
            }
            catch(Exception ex)
            {
                MaterialMessageBox.Show(ex.Message, "Error");
            }
        }

        private void CheckLoginRole(ALT_R_Management_Library.Models.Admin.AdministratorModel user)
        {
            switch (user.Role)
            {
                case "Database Manager":DbManagementForm managementForm = new DbManagementForm(apiProcessor);
                    managementForm.Show();
                    this.Hide();
                    ; break;
                default:
                    break;
            }
        }
    }
}

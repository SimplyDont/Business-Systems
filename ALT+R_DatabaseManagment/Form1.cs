using ALT_R_Management_Library.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin.Controls;
using MaterialSkin;
using System.Threading;

namespace ALT_R_DatabaseManagment
{
    public partial class Form1 : MaterialForm
    {
        ALT_R_ApiProcessor _processor = new ALT_R_ApiProcessor();
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public Form1()
        {
            InitializeComponent();
            ALT_R_ApiHelper.IntializeClient();
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan300, Primary.Cyan900, Primary.Cyan600, Accent.Cyan400, TextShade.WHITE);

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var token = await _processor.AuthenticateUser(materialTextBox2.Text, materialTextBox1.Text);
                var user = await _processor.SignIn(materialTextBox2.Text, materialTextBox1.Text,token.Access_Token);
              
                //MaterialMessageBox.Show($"Welcome {user.FirstName} {user.LastName}");
                materialSkinManager.RemoveFormToManage(this);
                //Thread thread = new Thread(new ThreadStart(GoToHomePage));
                //thread.SetApartmentState(ApartmentState.STA);
                //thread.Start();
                HomeForm home = new HomeForm(_processor);
                home.Show();
                this.Hide();



            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message,"Error");

            }

        }

        private void GoToHomePage()
        {


            //Application.Run(new HomeForm(_processor));
            

        }
    }
}

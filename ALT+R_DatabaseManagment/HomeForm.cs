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

namespace ALT_R_DatabaseManagment
{
    public partial class HomeForm : MaterialForm
    {
        ALT_R_ApiProcessor _processor;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public HomeForm(ALT_R_ApiProcessor processor)
        {
            InitializeComponent();
            _processor = processor;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan300, Primary.Cyan900, Primary.Cyan600, Accent.Cyan400, TextShade.WHITE);
            Text = string.Format("{0} {1} {2}", processor.AppUser.FirstName, processor.AppUser.LastName, processor.AppUser.Role);
        }
        public HomeForm()
        {
            InitializeComponent();
            //materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan300, Primary.Cyan900, Primary.Cyan600, Accent.Cyan400, TextShade.WHITE);

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            loginPanel.BackColor = Color.FromArgb(200, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(150, 0, 0, 255);

        }


    }
}

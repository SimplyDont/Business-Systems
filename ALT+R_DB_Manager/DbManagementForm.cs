using ALT_R_Management_Library.Api;
using ALT_R_Management_Library.Models.Admin;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALT_R_DB_Manager
{
    public partial class DbManagementForm : MaterialForm
    {
        ALT_R_ApiProcessor apiProcessor;
        MaterialSkinManager skinManager = MaterialSkinManager.Instance;
        private AdministratorModel user;


        public DbManagementForm(ALT_R_ApiProcessor _apiProcessor)
        {
            InitializeComponent();
            skinManager.AddFormToManage(this);
            apiProcessor = _apiProcessor;
            this.user = apiProcessor.AppUser;
        }

        private void DbManagementForm_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0} {1}", user.FirstName, user.LastName);
            LoadDatIntoListView();
        }

        private async void LoadDatIntoListView()
        {
            var admins = await apiProcessor.GetAllAdmins();
            for (int i = 0; i < admins.Count; i++)
            {
                ListViewItem item = new ListViewItem(admins[i].AdminID.ToString());
                item.SubItems.Add(admins[i].FirstName);
                item.SubItems.Add(admins[i].LastName);
                item.SubItems.Add(admins[i].Gender);
                item.SubItems.Add(admins[i].Role);
                item.SubItems.Add(admins[i].EmailAddress);
                item.SubItems.Add(admins[i].Username);
                //item.SubItems.Add(admins[i].Image);
                materialListView1.Items.Add(item);
            }
        }
        private async void registerUserBtn_Click(object sender, EventArgs e)
        {
            if (CheckForRequired())
            {
                try
                {
                    var status = await apiProcessor.InsertAdmin(firstnameTextbox.Text, lastnameTextbox.Text,
                                         (string)selectSex.SelectedItem, (string)selectRole.SelectedItem,
                                         usernameTextbox.Text, emailTextbox.Text, confirmpasswordTextbox.Text, GetByteFromImage(adminPageRegisterPicture.Image));
                    MaterialMessageBox.Show(status.ToString());
                }
                catch (Exception ex)
                {

                    MaterialMessageBox.Show(ex.Message);
                }
            }
            else
            {
                MaterialMessageBox.Show("Check To See If All Required Controls Are Verified");

            }

            //foreach(Control i in registerPageLoginPanel.Controls)
            //{
            //    i.Invalidate(i.Region);
            //}
            Refresh();
        }

        private bool CheckForRequired()
        {
            var result = false;
            for (int i = 0; i < materialCard1.Controls.Count; i++)
            {
                if (materialCard1.Controls[i].GetType() == typeof(MaterialCheckbox))
                {
                    result= true;
                }
                else
                {
                    result= false;
                }
            }

            return result;
        }

        private byte[] GetByteFromImage(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                var bmp = new Bitmap(image);
                bmp.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
            
        }

        private void loadImageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog open = new OpenFileDialog()
                {
                    Filter = "PNG(*.png)|*.png|JPEG(*.jpeg)|*.jpeg|JPG(*.jpg)|*.jpg|BMP(*.bmp)|*.bmp",
                    Multiselect = false,
                    AddExtension = true,
                    Title = "Select Image"
                })
                {
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        var image_path = open.FileName;
                        registerImagepictureBox.Image = Image.FromFile(image_path);
                    }
                }
            }
            catch
            {

                MaterialMessageBox.Show("File Not Supported \n Or File Corrupted", "Error");
            }
            
        }

        private void emailTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!emailTextbox.Text.Contains("@") || !emailTextbox.Text.Contains(".") || emailTextbox.TextLength >= 150)
            {
                materialCheckbox3.Checked = false;
            }
            else
            {
               materialCheckbox3.Checked = true;
            }
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasswordCheckBox.Checked)
            {
                passwordTextbox.Password = false;
                confirmpasswordTextbox.Password = false;

            }
            else if (!showpasswordCheckBox.Checked)
            {
                passwordTextbox.Password = true;
                confirmpasswordTextbox.Password = true;

            }
            registerPageLoginPanel.Refresh();
        }

        private void firstnameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (firstnameTextbox.TextLength > 0)
            {
                materialCheckbox1.Checked = true;
            }
            else
            {
                materialCheckbox1.Checked = false;

            }
        }

        private void lastnameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (lastnameTextbox.TextLength > 0)
            {
                materialCheckbox2.Checked = true;
            }
            else
            {
              materialCheckbox2.Checked = false;

            }
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextbox.TextLength > 0)
            {
                materialCheckbox6.Checked = true;
            }
            else
            {
                materialCheckbox6.Checked = false;

            }
        }

        private void confirmpasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            if (confirmpasswordTextbox.TextLength > 0&& passwordTextbox.Text == confirmpasswordTextbox.Text)
            {
                materialCheckbox7.Checked = true;
            }
            else
            {
                materialCheckbox7.Checked = false;

            }
        }

        private void selectSex_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (selectSex.SelectedItem != null)
            {
                materialCheckbox4.Checked = true;
            }
            else
            {
                materialCheckbox4.Checked = false;

            }
        }

        private void selectRole_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (selectRole.SelectedItem != null)
            {
                materialCheckbox5.Checked = true;
            }
            else
            {
                materialCheckbox5.Checked = false;

            }
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(SignOutNow));
            thread.Start();
            this.Close();
        }

        private void SignOutNow()
        {
            Application.Run(new SignInFormv2());
        }
    }
}

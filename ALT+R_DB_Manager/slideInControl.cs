using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ALT_R_Management_Library.Api;

namespace ALT_R_DB_Manager
{
    public partial class slideInControl : UserControl
    {
        int y = 0,x=0;
        int count = 0;
        bool lightmode_ = true, darkmode_ = false;
       ALT_R_ApiProcessor processor = new ALT_R_ApiProcessor();
        public slideInControl()
        {
            InitializeComponent();
            lightmode_email.BackColor = Color.FromArgb(223, 111, 70);
            darkmode_email.BackColor = Color.FromArgb(223, 111, 70);
            darkmode_password.BackColor = Color.FromArgb(223, 111, 70);
            lightmode_password.BackColor = Color.FromArgb(223, 111, 70);

            timer1.Tick += Timer1_Tick;
            timer2.Tick += Timer2_Tick;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
                x -= 5;
            
                if (x == -500)
                {
                    timer2.Stop();
                }




            this.Location = new Point(x, y);

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            y -= 5;
            if (y == -300)
            {
                timer1.Stop();
            }
            this.Location = new Point(x, y);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            count++;
            if (count==1)
            {
                for (int i = 0; i < panel2.Controls.Count; i++)
                {
                    if (panel2.Controls[i].GetType() == typeof(customTextbox))
                    {
                        panel2.Controls[i].BackColor = Color.FromArgb(223, 111, 70);
                        panel2.Controls[i].ForeColor = Color.Black;

                    }
                    else if (panel2.Controls[i].GetType() == typeof(Button))
                    {
                        ((Button)panel2.Controls[i]).FlatAppearance.BorderColor = Color.Coral;
                        panel2.Controls[i].ForeColor = Color.Coral;
                        ((Button)panel2.Controls[i]).Text = "Light Mode";
                    }
                    else
                    {
                        panel2.Controls[i].BackColor = Color.Black;
                        panel2.Controls[i].ForeColor = Color.Coral;
                    }
                }
                panel2.BackColor = Color.Black;
            }
            else if(count==2)
            {

                for (int i = 0; i < panel2.Controls.Count; i++)
                {
                    if (panel2.Controls[i].GetType() == typeof(customTextbox))
                    {
                        panel2.Controls[i].BackColor= Color.FromArgb(223, 111, 70);
                        panel2.Controls[i].ForeColor = Color.White;

                    }
                    else if (panel2.Controls[i].GetType() == typeof(Button))
                    {
                        ((Button)panel2.Controls[i]).FlatAppearance.BorderColor = Color.White;
                        panel2.Controls[i].ForeColor = Color.White;
                        ((Button)panel2.Controls[i]).Text = "Dark Mode";


                    }
                    else
                    {
                        panel2.Controls[i].ForeColor = Color.White;
                        panel2.Controls[i].BackColor = Color.Coral;
                    }
                    

                }
                panel2.BackColor = Color.Coral;
                count = 0;
            }
        }

        private void slideInControl_Load(object sender, EventArgs e)
        {
            

            loadingDots1.LoaderDot1Color = Color.White;
            loadingDots1.LoaderDot2Color = Color.White;
            loadingDots1.LoaderDot3Color = Color.White;
            loadingDots2.LoaderDot1Color = Color.Crimson;
            loadingDots2.LoaderDot2Color = Color.Crimson;
            loadingDots2.LoaderDot3Color = Color.Crimson;
            //Thread.Sleep(2000);
            //timer1.Start();

        }

        private void ToLightMode(object sender, EventArgs e)
        {
            darkmode_ = false;
            lightmode_ = true;
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            x += 5;

            if (x == 0)
            {
                timer3.Stop();
            }




            this.Location = new Point(x, y);

        }

        private void customTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            y -= 5;
            if (y == -600)
            {
                timer4.Stop();
                OpenNewForm();
            }
            this.Location = new Point(x, y);
        }

        private void OpenNewForm()
        {
            Thread thread = new Thread(new ThreadStart(NewFormRun));
            thread.Start();
            this.ParentForm.Close();

        }

        private void NewFormRun()
        {
            Application.Run(new DbManagementForm(processor));
            
        }

        private void slideInControl_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Coral;
            button3.ForeColor = Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Coral;
            button3.BackColor = Color.Black;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.ForeColor = Color.FromArgb(223, 111, 70);
            button4.BackColor = Color.White;

        }

        private void button4_MouseLeave(object sender,EventArgs e)
        {
            button4.ForeColor = Color.White;
            button4.BackColor = Color.Coral;
        }

        private void lightmode_email_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void lightmode_password_TextChanged(object sender, EventArgs e)
        {
             darkmode_password.Text= lightmode_password.Text;
        }

        private void darkmode_password_TextChanged(object sender, EventArgs e)
        {
            lightmode_password.Text = darkmode_password.Text;
        }

        private void lightmode_email_TextChanged(object sender, EventArgs e)
        {
            darkmode_email.Text = lightmode_email.Text;
        }

        private void darkmode_email_TextChanged(object sender, EventArgs e)
        {
            lightmode_email.Text = darkmode_email.Text;
        }

        private async void LoginUser(object sender, EventArgs e)
        {
            try
            {
                if (lightmode_ == true)
                {
                    var token = await processor.AuthenticateUser(lightmode_email.Text, lightmode_password.Text);
                    var user = await processor.SignIn(lightmode_email.Text, lightmode_password.Text, token.Access_Token);

                    //MessageBox.Show(user.AdminID.ToString());

                }
                if (darkmode_ == true)
                {
                    var token = await processor.AuthenticateUser(darkmode_email.Text, darkmode_password.Text);
                    var user = await processor.SignIn(darkmode_email.Text, darkmode_password.Text, token.Access_Token);
                   // MessageBox.Show(user.AdminID.ToString());


                }
                timer4.Start();
                if (timer4.Enabled == false)
                {
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ToDarkMode(object sender, EventArgs e)
        {
            darkmode_ = true;
            lightmode_ = false;
            timer2.Start();
        }
    }
}

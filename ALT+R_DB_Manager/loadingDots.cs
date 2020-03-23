using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALT_R_DB_Manager
{
    public partial class loadingDots : UserControl
    {
        Timer t1 = new Timer() { Interval = 1 };
        Timer t2 = new Timer() { Interval = 1 };

        public Color LoaderDot1Color
        {
            get { return pictureBox1.BackColor; }
            set
            {
                pictureBox1.BackColor = value;
                pictureBox1.Invalidate();
            }
        }
        public Color LoaderDot2Color
        {
            get { return pictureBox2.BackColor; }
            set
            {
                pictureBox2.BackColor = value;
                pictureBox2.Invalidate();
            }
        }
        public Color LoaderDot3Color
        {
            get { return pictureBox3.BackColor; }
            set
            {
                pictureBox3.BackColor = value;
                pictureBox3.Invalidate();
            }
        }
        int alpha = 0,alpha2,alpha3;
        public loadingDots()
        {
            InitializeComponent();
            t1.Tick += T_Tick;
            t2.Tick += T2_Tick;
        }

        private void loadingDots_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(70, 65);
        }

        private void loadingDots_Load(object sender, EventArgs e)
        {
            t1.Start();

        }

        private void T2_Tick(object sender, EventArgs e)
        {
            if (alpha3 != 0)
            {
                alpha3--;

            }
            if (alpha3 < 200 && alpha2 != 0)
            {
                alpha2--;
            }
            if (alpha3 < 150 && alpha != 0)
            {
                alpha--;
            }
            if (alpha3 == 0)
            {

                if (alpha2 == 0)
                {
                    if (alpha == 0)
                    {
                        t1.Start();
                        t2.Stop();
                    }
                }

            }
            pictureBox1.BackColor = Color.FromArgb(alpha3, pictureBox1.BackColor.A, pictureBox1.BackColor.G, pictureBox1.BackColor.B);
            pictureBox2.BackColor = Color.FromArgb(alpha2, pictureBox2.BackColor.A, pictureBox2.BackColor.G, pictureBox2.BackColor.B);
            pictureBox3.BackColor = Color.FromArgb(alpha, pictureBox3.BackColor.A, pictureBox3.BackColor.G, pictureBox3.BackColor.B);
        }

        private void T_Tick(object sender, EventArgs e)
        {
            if (alpha != 255)
            {
                alpha++;

            }
            if(alpha> 50 && alpha2 != 255)
            {
                alpha2++;
            }
            if (alpha >100 && alpha3 != 255)
            {
                alpha3++;
            }
            if (alpha == 255)
            {
                
                if (alpha2 == 255)
                {
                    if (alpha3 == 255)
                    {
                        t2.Start();
                        t1.Stop();
                    }
                }
                
            }
            pictureBox1.BackColor = Color.FromArgb(alpha, pictureBox1.BackColor.A, pictureBox1.BackColor.G, pictureBox1.BackColor.B);
            pictureBox2.BackColor = Color.FromArgb(alpha2, pictureBox2.BackColor.A, pictureBox2.BackColor.G, pictureBox2.BackColor.B);
            pictureBox3.BackColor = Color.FromArgb(alpha3, pictureBox3.BackColor.A, pictureBox3.BackColor.G, pictureBox3.BackColor.B);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rast = new Random();
        int gspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Enabled = false;
            int a = rast.Next(0, 5);
            int b = rast.Next(0, 5);
            int c = rast.Next(0, 5);
            int d = rast.Next(0, 5);
            label7.Text = c.ToString(); // BJK
            label6.Text = d.ToString(); // ts 
            label5.Text = a.ToString(); //  gs 
            label4.Text = b.ToString(); // fb 

            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label6.Text))
            {
                bjkpuan = bjkpuan + 3;
                lbbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label7.Text))
            {
                tspuan = tspuan + 3;
                lbtspuan.Text = tspuan.ToString();
            }

            if (Convert.ToInt32(label7.Text) == Convert.ToInt32(label6.Text))
            {
                bjkpuan = bjkpuan + 1;
                tspuan = tspuan + 1;
                lbbjkpuan.Text = bjkpuan.ToString();
                lbtspuan.Text = tspuan.ToString();
            }

            if (Convert.ToInt32(label5.Text) > Convert.ToInt32(label4.Text))
            {
                gspuan = gspuan + 3;
                lbgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label5.Text))
            {
                fbpuan = fbpuan + 3;
                lbfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label4.Text) == Convert.ToInt32(label5.Text))
            {
                fbpuan = fbpuan + 1;
                gspuan = gspuan + 1;
                lbfbpuan.Text = fbpuan.ToString();
                lbgspuan.Text = gspuan.ToString();
            }







        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            button2.Enabled = false;
            int a = rast.Next(0, 5);
            int b = rast.Next(0, 5);
            int c = rast.Next(0, 5);
            int d = rast.Next(0, 5);
            label18.Text = c.ToString(); // BJK 1
            label11.Text = d.ToString(); // ts 
            label21.Text = a.ToString(); //  gs 1
            label12.Text = b.ToString(); // fb 

            if (Convert.ToInt32(label21.Text) > Convert.ToInt32(label18.Text))
            {
                gspuan = gspuan + 3;
                lbgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label18.Text) > Convert.ToInt32(label21.Text))
            {
                bjkpuan = bjkpuan + 3;
                lbbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label21.Text) == Convert.ToInt32(label18.Text))
            {
                gspuan = gspuan + 1;
                bjkpuan = bjkpuan + 1;
                lbgspuan.Text = gspuan.ToString();
                lbbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) > Convert.ToInt32(label12.Text))
            {
                tspuan = tspuan + 3;
                lbtspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label12.Text) > Convert.ToInt32(label11.Text))
            {
                fbpuan = fbpuan + 3;
                lbfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) == Convert.ToInt32(label12.Text))
            {
                tspuan = tspuan + 1;
                fbpuan = fbpuan + 1;
                lbtspuan.Text = tspuan.ToString();
                lbfbpuan.Text = fbpuan.ToString();
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            button3.Enabled = false;
            int a = rast.Next(0, 5);
            int b = rast.Next(0, 5);
            int c = rast.Next(0, 5);
            int d = rast.Next(0, 5);
            label30.Text = c.ToString(); // BJK 1
            label26.Text = d.ToString(); // ts 
            label25.Text = a.ToString(); //  gs 1
            label31.Text = b.ToString(); // fb

            if (Convert.ToInt32(label31.Text) > Convert.ToInt32(label30.Text))
            {
                fbpuan = fbpuan + 3;
                lbfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label30.Text) > Convert.ToInt32(label31.Text))
            {
                bjkpuan = bjkpuan + 3;
                lbbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label31.Text) == Convert.ToInt32(label30.Text))
            {
                fbpuan = fbpuan + 1;
                bjkpuan = bjkpuan + 1;
                lbfbpuan.Text = fbpuan.ToString();
                lbbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label26.Text) > Convert.ToInt32(label25.Text))
            {
                tspuan = tspuan + 3;
                lbtspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label25.Text) > Convert.ToInt32(label26.Text))
            {
                gspuan = gspuan + 3;
                lbgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label25.Text) == Convert.ToInt32(label26.Text))
            {
                tspuan = tspuan + 1;
                gspuan = gspuan + 1;
                lbtspuan.Text = tspuan.ToString();
                lbgspuan.Text = gspuan.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbbjkpuan.Text) > Convert.ToInt32(lbfbpuan.Text) && Convert.ToInt32(lbbjkpuan.Text) > Convert.ToInt32(lbgspuan.Text) && Convert.ToInt32(lbbjkpuan.Text) > Convert.ToInt32(lbtspuan.Text))
            {
                label35.Text = "BJK Şampiyon";
            }
            if (Convert.ToInt32(lbfbpuan.Text) > Convert.ToInt32(lbbjkpuan.Text) && Convert.ToInt32(lbfbpuan.Text) > Convert.ToInt32(lbgspuan.Text) && Convert.ToInt32(lbfbpuan.Text) > Convert.ToInt32(lbtspuan.Text))
            {
                label35.Text = "FB Şampiyon";
            }
            if (Convert.ToInt32(lbgspuan.Text) > Convert.ToInt32(lbfbpuan.Text) && Convert.ToInt32(lbgspuan.Text) > Convert.ToInt32(lbbjkpuan.Text) && Convert.ToInt32(lbgspuan.Text) > Convert.ToInt32(lbtspuan.Text))
            {
                label35.Text = "GS Şampiyon";
            }
            if (Convert.ToInt32(lbtspuan.Text) > Convert.ToInt32(lbfbpuan.Text) && Convert.ToInt32(lbtspuan.Text) > Convert.ToInt32(lbgspuan.Text) && Convert.ToInt32(lbtspuan.Text) > Convert.ToInt32(lbbjkpuan.Text))
            {
                label35.Text = "TS Şampiyon";
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}


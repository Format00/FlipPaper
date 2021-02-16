using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlipPaper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        int can1 = 40;
        int can2 = 40;

        int saldırıa1, savunmaa1;
        int saldırıb1, savunmab1;
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
                button1.Enabled = true;
            }
            else
            {
                checkBox1.Checked = true;
                button4.Enabled = true;
            }

            button3.Enabled = false;
            button5.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            saldırıb1 = rnd.Next(1, 6);
            savunmab1 = rnd.Next(1, 6);

            pictureBox3.Visible = true;
            label3.Text = savunmab1.ToString();
            label4.Text = saldırıb1.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            saldırıa1 = rnd.Next(1, 6);
            savunmaa1 = rnd.Next(1, 6);

            pictureBox2.Visible = true;
            label1.Text = saldırıa1.ToString();
            label2.Text = savunmaa1.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Point konum = new Point();
            konum.X = 439;
            konum.Y = 347;
            pictureBox2.Location = konum;

            Point lbl1 = new Point();
            lbl1.X = 442;
            lbl1.Y = 435;
            label1.Location = lbl1;

            Point lbl2 = new Point();
            lbl2.X = 510;
            lbl2.Y = 435;
            label2.Location = lbl2;

            button3.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = can1.ToString();
            label6.Text = can2.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (saldırıb1 == 5)
            {
                savunmaa1 = savunmaa1 - 5;
                label2.Text = savunmaa1.ToString();
            }
            if (saldırıb1 == 4)
            {
                savunmaa1 = savunmaa1 - 4;
                label2.Text = savunmaa1.ToString();
            }
            if (saldırıb1 == 3)
            {
                savunmaa1 = savunmaa1 - 3;
                label2.Text = savunmaa1.ToString();
            }
            if (saldırıb1 == 2)
            {
                savunmaa1 = savunmaa1 - 2;
                label2.Text = savunmaa1.ToString();
            }
            if (saldırıb1 == 1)
            {
                savunmaa1 = savunmaa1 - 1;
                label2.Text = savunmaa1.ToString();
            }
            button5.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Point konum = new Point();
            konum.X = 439;
            konum.Y = 138;
            pictureBox3.Location = konum;

            Point lbl1 = new Point();
            lbl1.X = 442;
            lbl1.Y = 226;
            label4.Location = lbl1;

            Point lbl2 = new Point();
            lbl2.X = 510;
            lbl2.Y = 226;
            label3.Location = lbl2;
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(saldırıa1 == 5)
            {
                savunmab1 = savunmab1 - 5;
                label3.Text = savunmab1.ToString();
            }
            if (saldırıa1 == 4)
            {
                savunmab1 = savunmab1 -4;
                label3.Text = savunmab1.ToString();
            }
            if (saldırıa1 == 3)
            {
                savunmab1 = savunmab1 - 3;
                label3.Text = savunmab1.ToString();
            }
            if (saldırıa1 == 2)
            {
                savunmab1 = savunmab1 - 2;
                label3.Text = savunmab1.ToString();
            }
            if (saldırıa1 == 1)
            {
                savunmab1 = savunmab1 - 1;
                label3.Text = savunmab1.ToString();
            }
            button3.Enabled = false;
        }
    }
}

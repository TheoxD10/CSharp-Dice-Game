using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbut_
{
    public partial class Open : Form
    {
        int appear=0,checkedtext1=0, checkedtext2 = 0;
        int red,green,blue;
        Random colorselect;
        public Open()
        {
            InitializeComponent();
            appear = 0;
            button1.Enabled = false;
            button2.Enabled = false;
            colorselect = new Random();
            if(Class1.username1 != null && Class1.username2 != null)
            {
                textBox1.Text = Class1.username1;
                textBox2.Text = Class1.username2;
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void Open_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkGray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DimGray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Barbut_extra();
            f.Show();
            this.Hide();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Cornsilk;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.SlateGray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Class1.username1 = textBox1.Text;
            if (checkedtext1 == 0)
            {
                appear += 1;
                checkedtext1 = 1;
            }
            checker(appear);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            red = colorselect.Next(0, 255);
            green = colorselect.Next(0, 255);
            blue = colorselect.Next(0, 255);
            label1.ForeColor = Color.FromArgb(red, green, blue);//rgb 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Class1.username2 = textBox2.Text;
            if (checkedtext2==0)
            {
                appear += 1;
                checkedtext2 = 1;
            }
            checker(appear);
        }
        public void checker(int k)
        {
            if (k==2)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }
    }
}

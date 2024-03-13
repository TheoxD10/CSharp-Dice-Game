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
    public partial class Form1 : Form
    {
        Random zar = new Random();
        int Numar_Random1;
        int Numar_Random2;
        int Numar_Random3;
        int Numar_Random4;
        int ok1 = 0;
        int ok2 = 0;

        public Form1()
        {
            InitializeComponent();
            ///this.ControlBox = false;
            button2.Enabled=false;
            Numar_Random1 = zar.Next(1, 7);
            Numar_Random2 = zar.Next(1, 7);
            Numar_Random3 = zar.Next(1, 7);
            Numar_Random4 = zar.Next(1, 7);
            // label5.Text = Class1.username1;
            // label6.Text = Class1.username2;
            button1.Text = Class1.username1;
            button2.Text = Class1.username2;
            label5.Text = "Este rândul lui " + Class1.username1;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            Numar_Random1 = zar.Next(1, 7);
            Numar_Random2 = zar.Next(1, 7);
            switch (Numar_Random1)
            {
                case 1:
                    pictureBox1.Image = Barbut_.Properties.Resources.dice_1;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox1.Image = Barbut_.Properties.Resources.dice_2;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox1.Image = Barbut_.Properties.Resources.dice_3;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox1.Image = Barbut_.Properties.Resources.dice_4;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox1.Image = Barbut_.Properties.Resources.dice_5;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox1.Image = Barbut_.Properties.Resources.dice_6;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    break;

            }

            switch (Numar_Random2)
            {
                case 1:
                    pictureBox2.Image = Barbut_.Properties.Resources.dice_1;
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox2.Image = Barbut_.Properties.Resources.dice_2;
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox2.Image = Barbut_.Properties.Resources.dice_3;
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox2.Image = Barbut_.Properties.Resources.dice_4;
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox2.Image = Barbut_.Properties.Resources.dice_5;
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox2.Image = Barbut_.Properties.Resources.dice_6;
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    break;

            }
            button1.Enabled = false;
            button2.Enabled = true;
            label5.Text = "Este rândul lui " + Class1.username2;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Numar_Random3 = zar.Next(1, 7);
            Numar_Random4 = zar.Next(1, 7);
            switch (Numar_Random3)
            {
                case 1:
                    pictureBox3.Image = Barbut_.Properties.Resources.dice_1;
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox3.Image = Barbut_.Properties.Resources.dice_2;
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox3.Image = Barbut_.Properties.Resources.dice_3;
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox3.Image = Barbut_.Properties.Resources.dice_4;
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox3.Image = Barbut_.Properties.Resources.dice_5;
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox3.Image = Barbut_.Properties.Resources.dice_6;
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    break;

            }
            switch (Numar_Random4)
            {
                case 1:
                    pictureBox4.Image = Barbut_.Properties.Resources.dice_1;
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox4.Image = Barbut_.Properties.Resources.dice_2;
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox4.Image = Barbut_.Properties.Resources.dice_3;
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox4.Image = Barbut_.Properties.Resources.dice_4;
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox4.Image = Barbut_.Properties.Resources.dice_5;
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox4.Image = Barbut_.Properties.Resources.dice_6;
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    break;
            }
            button2.Enabled = false;
            castig();
            label5.Text = "Este rândul lui " + Class1.username1;

        }
        private void castig()
        {
            if(Numar_Random1==Numar_Random2 && Numar_Random1==1)/// zarurile primului jucator 1/1
            {
                ok1++;
                label2.Text =Convert.ToString(ok1);
                Class1.winner = 1;
                Castigator y = new Castigator();
                y.Show();
                button1.Enabled = true;
                return;
            }
            if(Numar_Random3==Numar_Random4 && Numar_Random3==1)/// zarurile celui de al doilea jucator 1/1
            {
                ok2++;
                label3.Text = Convert.ToString(ok2);
                Class1.winner = 2;
                Castigator y = new Castigator();
                y.Show();
                button1.Enabled = true;
                return;
            }
            //////////////////////////////////////////////////////

            if (Numar_Random3 == Numar_Random4 && Numar_Random3 == 1 && Numar_Random1 == Numar_Random2 && Numar_Random1==1)/// 1 1
            {
                ok1++;
                label2.Text = Convert.ToString(ok1);
                ok2++;
                label3.Text = Convert.ToString(ok2);
                Class1.winner = 3;
                Castigator y = new Castigator();
                y.Show();///zarurile ambilor jucatori 1/1
                button1.Enabled = true;
                return;
            }
            //////////////////////////////////////////////////////

            if (Numar_Random1 == Numar_Random2 && Numar_Random3 != Numar_Random4)///primele 2 zaruri identice
            {
                ok1++;
                label2.Text = Convert.ToString(ok1);
                Class1.winner = 1;
                Castigator y = new Castigator();
                y.Show();
                button1.Enabled = true;
                return;
            }

            if (Numar_Random1 != Numar_Random2 && Numar_Random3 == Numar_Random4)///ultimele 2 zaruri identice
            {
                ok2++;
                label3.Text = Convert.ToString(ok2);
                Class1.winner = 2;
                Castigator y = new Castigator();
                y.Show();
                button1.Enabled = true;
                return;
            }

            /////////////////////////////////////////////////////
            if(Numar_Random1==Numar_Random2 && Numar_Random3==Numar_Random4)                ///ambele zaruri sunt identice doua cate doua
            {
                if (Numar_Random1 > Numar_Random3)                                          //primul zar mai mare decat al treilea
                {
                    ok1++;
                    label2.Text = Convert.ToString(ok1);
                    Class1.winner = 1;
                    Castigator y = new Castigator();
                    y.Show();
                    button1.Enabled = true;
                    return;
                }
                else if(Numar_Random1<Numar_Random3)                                        ///primul zar egal mai mic decat al treilea
                     {
                        ok2++;
                        label3.Text = Convert.ToString(ok2);
                        Class1.winner = 2;
                        Castigator y = new Castigator();
                        y.Show();
                    button1.Enabled = true;
                        return;
                     }
                    else if(Numar_Random1==Numar_Random3)
                {                                          ///primul zar eegal cu al treilea
                    ok1++;
                    label2.Text = Convert.ToString(ok1);
                    ok2++;
                    label3.Text = Convert.ToString(ok2);
                    Class1.winner = 3;
                    Castigator y = new Castigator();
                    y.Show();
                    button1.Enabled = true;
                    return;
                }
            }

            int suma1=0;
            int suma2=0;
            suma1 = Numar_Random1 + Numar_Random2;
            suma2 = Numar_Random3 + Numar_Random4;

            if (suma1 > suma2)                                                      //conditiile de mai sus nu parcurse
            {                                                                       //verificam suma primelor si celorlalte zaruri
                ok1++;
                label2.Text = Convert.ToString(ok1);
                Class1.winner = 1;
                Castigator y = new Castigator();
                y.Show();
            }
            else
                if (suma1 < suma2)
                {
                    ok2++;
                    label3.Text = Convert.ToString(ok2);
                Class1.winner = 2;
                Castigator y = new Castigator();
                y.Show();
            }
                
            else
            {
                ok1++;                                                              ///suma egala
                label2.Text = Convert.ToString(ok1);
                ok2++;
                label3.Text = Convert.ToString(ok2);
                Class1.winner = 3;
                Castigator y = new Castigator();
                y.Show();
            }
            button1.Enabled = true;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Aqua;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.LawnGreen;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightSeaGreen;
        }

        /// private void button4_Click(object sender, EventArgs e)
        /// {
        ///     Form f = new Regulament();
        ///     f.Show();
        ///     this.Hide();
        /// }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Barbut_.Properties.Resources.dice_1;
            pictureBox2.Image = Barbut_.Properties.Resources.dice_2;
            pictureBox3.Image = Barbut_.Properties.Resources.dice_3;
            pictureBox4.Image = Barbut_.Properties.Resources.dice_4;
            ok1 = 0;
            ok2 = 0;
            label2.Text = "0";
            label3.Text = "0";
            button1.Enabled = true;
            button2.Enabled = false;
            label5.Text = "Este rândul lui " + Class1.username1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Dispose();
            Form f = new Open();
            f.Show();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            Regulament g = new Regulament();
            g.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

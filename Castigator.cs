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
    public partial class Castigator : Form
    {
        public Castigator()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval=2000;
            if(Class1.winner == 1)
            {
                label1.Text = "A castigat "+Class1.username1+"!";
                
            }
            else
            {
                if (Class1.winner == 2)
                {
                    label1.Text ="A castigat "+ Class1.username2+"!";
                   
                }
                if(Class1.winner==3)
                {
                    label1.Text = "Este egalitate!" ;
                  
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

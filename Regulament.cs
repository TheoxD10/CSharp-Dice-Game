﻿using System;
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
    public partial class Regulament : Form
    {
        public Regulament()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regulament.ActiveForm.Dispose();
        }

        private void Regulament_Load(object sender, EventArgs e)
        {
            
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso_2do_bloque_JR
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Repaso_1 repaso_1 = new Repaso_1();
            repaso_1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Repaso_2 repaso_2 = new Repaso_2();
            repaso_2.Show();
        }
    }
}

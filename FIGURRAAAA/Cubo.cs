﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIGURRAAAA
{
    public partial class Cubo : Form
    {
        public Cubo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}

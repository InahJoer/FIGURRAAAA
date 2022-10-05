using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int l = int.Parse(txtLados.Text);

            double r = Math.Pow(l, 2);

            txtRESPUESTA.Text = r.ToString();

        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 openPage01 = new Form1();
            this.Hide();
            openPage01.ShowDialog();
            this.Close();

        }

        private void txtRESPUESTA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Esfera : Form
    {
        public Esfera()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 openPage01 = new Form1();
            this.Hide();
            openPage01.ShowDialog();
            this.Close();
        }
    }
}

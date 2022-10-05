namespace FIGURRAAAA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 openPage02 = new Form2();
            this.Hide();
            openPage02.ShowDialog();
            this.Close();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Triangulo openform03 = new Triangulo();
            this.Hide();
            openform03.ShowDialog();
            this.Close();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            Circulo openform4 = new Circulo();
            this.Hide();
            openform4.ShowDialog();
            this.Close();
        }

        private void btnEsfera_Click(object sender, EventArgs e)
        {
            Esfera openform5 = new Esfera();
            this.Hide();
            openform5.ShowDialog();
            this.Close();
        }

        private void btnCubo_Click(object sender, EventArgs e)
        {
            Cubo openform6 = new Cubo();
            this.Hide();
            openform6.ShowDialog();
            this.Close();
        }

        private void btnPiramide_Click(object sender, EventArgs e)
        {
            Piramide openform7 = new Piramide();
            this.Hide();
            openform7.ShowDialog();
            this.Close();
        }
    }
}
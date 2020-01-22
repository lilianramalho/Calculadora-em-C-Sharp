using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AtividadeDS
{
    public partial class telaQuadrado : Form
    {
        Quadrado quadrado = new Quadrado();
        public telaQuadrado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quadrado.lado = Convert.ToDouble(textBox1.Text);
            double retorno_double = quadrado.CalculaerArea();
            label2.Text = Convert.ToString(retorno_double);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Visible = false;
            telaFormas telaformas = new telaFormas();
            telaformas.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Visible = false;
            telaFormas telaformas = new telaFormas();
            telaformas.Show();
        }
    }
}

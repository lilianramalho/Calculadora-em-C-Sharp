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
    public partial class TelaCirculo : Form
    {
        Circulo circulo = new Circulo();
        public TelaCirculo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circulo.raio = Convert.ToDouble(textBox1.Text);
            double retorno_double = circulo.CalculaerArea();
            label2.Text = Convert.ToString(retorno_double);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Visible = false;
            telaFormas telaformas = new telaFormas();
            telaformas.Show();
        }
    }
}

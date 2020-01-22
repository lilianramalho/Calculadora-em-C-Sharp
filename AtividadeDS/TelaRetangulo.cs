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
    public partial class TelaRetangulo : Form
    {
        Retangulo retangulo = new Retangulo();
        public TelaRetangulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            retangulo.altura = Convert.ToDouble(textBox1.Text);
            retangulo.lado = Convert.ToDouble(textBox2.Text);
            double retorno_double = retangulo.CalculaerArea();
            label3.Text = Convert.ToString(retorno_double);
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Visible = false;
            telaFormas telaformas = new telaFormas();
            telaformas.Show();
        }
    }
}

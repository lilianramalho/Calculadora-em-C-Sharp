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
    public partial class TelaTriangulo : Form
    {
        Triangulo triangulo = new Triangulo();
        public TelaTriangulo()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            triangulo.altura = Convert.ToDouble(textBox1.Text);
            triangulo.lado = Convert.ToDouble(textBox2.Text);
            double retorno_double = triangulo.CalculaerArea();
            label3.Text = Convert.ToString(retorno_double);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Visible = false;
            telaFormas telaformas = new telaFormas();
            telaformas.Show();

        }
    }
}

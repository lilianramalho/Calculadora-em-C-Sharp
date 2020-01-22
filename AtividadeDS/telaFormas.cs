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
    public partial class telaFormas : Form
    {
        public telaFormas()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex ==  0) {
                Visible = false;
                TelaTriangulo telaTriangulo = new TelaTriangulo();
                telaTriangulo.Show();
            }

            if (comboBox1.SelectedIndex == 3) {
                Visible = false;
                TelaRetangulo telaRetangulo = new TelaRetangulo();
                telaRetangulo.Show();
            }

            if (comboBox1.SelectedIndex == 2) {
                Visible = false;
                TelaCirculo telaCirculo = new TelaCirculo();
                telaCirculo.Show();    
            }

            if (comboBox1.SelectedIndex == 1) {
                Visible = false;
                telaQuadrado telaQuadrado = new telaQuadrado();
                telaQuadrado.Show();
            
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Visible = false;
            Menu menu = new Menu();
            menu.Show();
        }
    }
}

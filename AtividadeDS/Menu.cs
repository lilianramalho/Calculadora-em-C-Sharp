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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void formas_Click(object sender, EventArgs e)
        {
            Visible = false;
            telaFormas telaFormas = new telaFormas();
            telaFormas.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Visible = false;
            TelaCalcular telaCalcular = new TelaCalcular();
            telaCalcular.Show();
        }
    }
}

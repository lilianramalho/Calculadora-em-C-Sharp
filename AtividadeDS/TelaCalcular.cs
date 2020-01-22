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
    public partial class TelaCalcular : Form
    {
        double result;
        Calculadora calculadora = new Calculadora();
        public TelaCalcular()
        {
            InitializeComponent();
        }

        private void operacoes_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked) && (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "" && textBox4.Text == "")){
               double resultado_double = calculadora.Somar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
               resultado.Text = Convert.ToString(resultado_double);  
            }

            if ((radioButton1.Checked) && (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")) {
               double resultado_double = calculadora.Somar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
               resultado.Text = Convert.ToString(resultado_double);
            }

            if ((radioButton1.Checked) && (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")) {
              double resultado_double =  calculadora.Somar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
              resultado.Text = Convert.ToString(resultado_double);
            }

            if ((radioButton2.Checked) && (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "" && textBox4.Text == "")) {
              double resultado_double = calculadora.Subtrair(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
              resultado.Text = Convert.ToString(resultado_double);
            }

            if ((radioButton2.Checked) && (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")) {
               double resultado_double =  calculadora.Subtrair(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
               resultado.Text = Convert.ToString(resultado_double);
            }

            if ((radioButton2.Checked) && (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")) {
               double resultado_double = calculadora.Subtrair(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
               resultado.Text = Convert.ToString(resultado_double);
            }

            if ((radioButton3.Checked) && (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "" && textBox4.Text == ""))
            {
             double resultado_double = calculadora.Multiplicar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
             resultado.Text = Convert.ToString(resultado_double);
            }

            if ((radioButton3.Checked) && (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == ""))
            {
                double resultado_double = calculadora.Multiplicar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                resultado.Text = Convert.ToString(resultado_double);
            }

            if ((radioButton3.Checked) && (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != ""))
            {
               double resultado_double = calculadora.Multiplicar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
               resultado.Text = Convert.ToString(resultado_double);
            }

            if ((radioButton4.Checked) && (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "" && textBox4.Text == ""))
            {
                double resultado_double = calculadora.Dividir(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                resultado.Text = Convert.ToString(resultado_double);
            }

            if ((radioButton4.Checked) && (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == ""))
            {
              double resultado_double = calculadora.Dividir(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
              resultado.Text = Convert.ToString(resultado_double);
            }

            if ((radioButton4.Checked) && (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != ""))
            {
               double resultado_double = calculadora.Dividir(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
               resultado.Text = Convert.ToString(resultado_double);
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora01
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "9";
        }

        private void btPonto_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += ".";
        }

        

        private void btSoma_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text != "")
            {
                valor1 = decimal.Parse(tbDisplay.Text, CultureInfo.InvariantCulture);
                tbDisplay.Text = "";
                operacao = "soma";
                lbOperador.Text = "+";
            }
        }

        private void btSubtrai_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text != "")
            {
                valor1 = decimal.Parse(tbDisplay.Text, CultureInfo.InvariantCulture);
                tbDisplay.Text = "";
                operacao = "subtracao";
                lbOperador.Text = "-";
            }
        }

        private void btMultiplica_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text != "")
            {
                valor1 = decimal.Parse(tbDisplay.Text, CultureInfo.InvariantCulture);
                tbDisplay.Text = "";
                operacao = "multiplicacao";
                lbOperador.Text = "X";
            }
        }

        private void btDivisao_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text != "")
            {
                valor1 = decimal.Parse(tbDisplay.Text, CultureInfo.InvariantCulture);
                tbDisplay.Text = "";
                operacao = "dividir";
                lbOperador.Text = "/";
            }
        }

        private void btLimpa_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "";
          
        }

        private void btApaga_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "";
            lbOperador.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text != "")
            {
                valor2 = decimal.Parse(tbDisplay.Text, CultureInfo.InvariantCulture);
                if (operacao == "soma")
                {
                    tbDisplay.Text = Convert.ToString(valor1 + valor2);
                }
                else if (operacao == "subtracao")
                {
                    tbDisplay.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operacao == "multiplicacao")
                {
                    tbDisplay.Text = Convert.ToString(valor1 * valor2);
                }
                else if (operacao == "dividir")
                {
                    tbDisplay.Text = Convert.ToString(valor1 / valor2);
                }
            }
        }
    }
}

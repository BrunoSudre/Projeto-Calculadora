using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora.Classes;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        protected string operador;
        protected double primeiroValor = 0;
        protected double segundoValor = 0;
        protected bool hasSinal = false;
        protected bool undefinedResult = false;
        private ICalculo obj;
        public Form1()
        {
            InitializeComponent();
            desativarBotoes();
        }
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (undefinedResult)
            {
                txbTela.Text = (sender as Button).Text;
                undefinedResult = false;
            } else
            {
                txbTela.Text = txbTela.Text + (sender as Button).Text;
            }

            btnLimpar.Enabled = true;
            ativarBotoes();
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            desativarBotoes();            
            this.primeiroValor = double.Parse(txbTela.Text);
            txbTela.Clear();
            this.operador = (sender as Button).Text;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbTela.Clear();
            this.primeiroValor = 0;
            this.segundoValor = 0;
            desativarBotoes();
        }

        private void btnSinal_Click(object sender, EventArgs e)
        {

            if (hasSinal)
            {
                txbTela.Text = txbTela.Text.Substring(1);
                hasSinal = false;
            } else
            {
                txbTela.Text = "-" + txbTela.Text;
                hasSinal = true;
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (txbTela.Text == "") {
                this.segundoValor = this.primeiroValor;
            } else
            {
                this.segundoValor = double.Parse(txbTela.Text);
            }

            switch (this.operador)
            {
                case "+":
                    this.obj = new Soma();
                    break;

                case "-":
                    this.obj = new Subtracao();
                    break;

                case "*":
                    this.obj = new Multiplicacao();
                    break;

                case "/":
                    this.obj = new Divisao();
                    break;
            }

            if (this.segundoValor == 0 && this.operador == "/") {
                txbTela.Text = "Indefinido";
                undefinedResult = true;
                desativarBotoes();
            }
            else
            {
                if (this.obj != null)
                {
                    txbTela.Text = this.obj.calcular(this.primeiroValor, this.segundoValor).ToString();
                }
                else
                {
                    txbTela.Text = "";
                    desativarBotoes();
                }
            }
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!txbTela.Text.Contains("."))
            {
                txbTela.Text = txbTela.Text + ".";
            }
        }

        private void desativarBotoes()
        {
            btnSoma.Enabled = false;
            btnSub.Enabled = false;
            btnMult.Enabled = false;
            btnDiv.Enabled = false;
            btnPonto.Enabled = false;
            btnSinal.Enabled = false;
            btnResultado.Enabled = false;
            btnVoltar.Enabled = false;
            btnQuadrado.Enabled = false;
            btnRaiz.Enabled = false;
        }
        private void ativarBotoes()
        {
            btnSoma.Enabled = true;
            btnSub.Enabled = true;
            btnMult.Enabled = true;
            btnDiv.Enabled = true;
            btnPonto.Enabled = true;
            btnSinal.Enabled = true;
            btnResultado.Enabled = true;
            btnVoltar.Enabled = true;
            btnQuadrado.Enabled = true;
            btnRaiz.Enabled = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (txbTela.Text != "")
            {
                if (txbTela.TextLength == 1)
                {
                    desativarBotoes();
                }
                txbTela.Text = txbTela.Text.Substring(0, txbTela.TextLength - 1);
            }
        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            txbTela.Text = Math.Pow(double.Parse(txbTela.Text), 2).ToString();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            txbTela.Text = Math.Sqrt(double.Parse(txbTela.Text)).ToString();
        }
    }
}

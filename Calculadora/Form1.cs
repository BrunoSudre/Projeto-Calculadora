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
        protected double primeiroValor;
        protected double segundoValor;
        protected bool hasSinal = false;
        private ICalculo obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            lblTela.Text = "";
            lblTela.Text = lblTela.Text + (sender as Button).Text;
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            this.primeiroValor = double.Parse(lblTela.Text);
            this.operador = (sender as Button).Text;
            //lblTela.Clear();
            lblTela.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblTela.Text = "0";
            this.primeiroValor = 0;
            this.segundoValor = 0;
        }

        private void btnSinal_Click(object sender, EventArgs e)
        {
            if (hasSinal)
            {
                lblTela.Text = lblTela.Text.Substring(1);
                hasSinal = false;
            } else
            {
                lblTela.Text = "-" + lblTela.Text;
                hasSinal = true;
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            this.segundoValor = double.Parse(lblTela.Text);

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
                    if (this.segundoValor == 0)
                    {
                        MessageBox.Show("Não é permitido divisão por 0! Digite outro valor.");
                        Application.Exit();
                    } else
                    {
                        this.obj = new Divisao();
                    }
               
                    break;
            }

            lblTela.Text = this.obj.calcular(this.primeiroValor, this.segundoValor).ToString();
        }
    }
}

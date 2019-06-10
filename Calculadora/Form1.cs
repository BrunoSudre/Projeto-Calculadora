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
            btnSoma.Enabled = false;
            btnLimpar.Enabled = false;
            btnSub.Enabled = false;
            btnMult.Enabled = false;
            btnDiv.Enabled = false;
            btnSinal.Enabled = false;
            btnPonto.Enabled = false;
            btnResultado.Enabled = false;
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            lblTela.Text = lblTela.Text + (sender as Button).Text;

            btnLimpar.Enabled = true;
            btnSoma.Enabled = true;
            btnSub.Enabled = true;
            btnMult.Enabled = true;
            btnDiv.Enabled = true;
            btnPonto.Enabled = true;
            btnSinal.Enabled = true;
            btnResultado.Enabled = true;
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            btnSoma.Enabled = false;
            btnSub.Enabled = false;
            btnMult.Enabled = false;
            btnDiv.Enabled = false;
            btnSinal.Enabled = false;
            btnPonto.Enabled = false;
            btnResultado.Enabled = false;
            
            this.primeiroValor = double.Parse(lblTela.Text);
            this.operador = (sender as Button).Text;
            //lblTela.Clear();
            lblTela.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblTela.Text = "";
            this.primeiroValor = 0;
            this.segundoValor = 0;
            btnSoma.Enabled = false;
            btnSub.Enabled = false;
            btnMult.Enabled = false;
            btnDiv.Enabled = false;
            btnPonto.Enabled = false;
            btnSinal.Enabled = false;
            btnResultado.Enabled = false;
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
        getSegundoValor:
            this.segundoValor = double.Parse(lblTela.Text);

            if (this.operador == "/" && this.segundoValor == 0)
            {
                MessageBox.Show("Não é permitido divisão por 0! Digite outro valor.");
                goto getSegundoValor;
            }

            if (this.segundoValor.ToString() == null)
            {
                MessageBox.Show("Digite o segundo valor!");
                goto getSegundoValor; 
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

            lblTela.Text = this.obj.calcular(this.primeiroValor, this.segundoValor).ToString();
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            lblTela.Text = lblTela.Text + ",";
        }
    }
}

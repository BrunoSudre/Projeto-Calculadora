﻿namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSinal = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.txbTela = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnQuadrado = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.Color.IndianRed;
            this.btnSoma.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSoma.Location = new System.Drawing.Point(190, 61);
            this.btnSoma.Margin = new System.Windows.Forms.Padding(1);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(58, 46);
            this.btnSoma.TabIndex = 0;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.IndianRed;
            this.btnLimpar.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Location = new System.Drawing.Point(10, 61);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(1);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 46);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSinal
            // 
            this.btnSinal.BackColor = System.Drawing.Color.IndianRed;
            this.btnSinal.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSinal.Location = new System.Drawing.Point(190, 252);
            this.btnSinal.Margin = new System.Windows.Forms.Padding(1);
            this.btnSinal.Name = "btnSinal";
            this.btnSinal.Size = new System.Drawing.Size(58, 46);
            this.btnSinal.TabIndex = 19;
            this.btnSinal.Text = "+/-";
            this.btnSinal.UseVisualStyleBackColor = false;
            this.btnSinal.Click += new System.EventHandler(this.btnSinal_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.SteelBlue;
            this.btn7.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(10, 109);
            this.btn7.Margin = new System.Windows.Forms.Padding(1);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(58, 46);
            this.btn7.TabIndex = 20;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.SteelBlue;
            this.btn8.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(70, 109);
            this.btn8.Margin = new System.Windows.Forms.Padding(1);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(58, 46);
            this.btn8.TabIndex = 21;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.DarkCyan;
            this.btnResultado.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.ForeColor = System.Drawing.SystemColors.Control;
            this.btnResultado.Location = new System.Drawing.Point(250, 156);
            this.btnResultado.Margin = new System.Windows.Forms.Padding(1);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(58, 142);
            this.btnResultado.TabIndex = 22;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.SteelBlue;
            this.btn3.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(130, 204);
            this.btn3.Margin = new System.Windows.Forms.Padding(1);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(58, 46);
            this.btn3.TabIndex = 23;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.SteelBlue;
            this.btn2.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(70, 205);
            this.btn2.Margin = new System.Windows.Forms.Padding(1);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(58, 46);
            this.btn2.TabIndex = 24;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.SteelBlue;
            this.btn1.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(10, 205);
            this.btn1.Margin = new System.Windows.Forms.Padding(1);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(58, 46);
            this.btn1.TabIndex = 25;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.SteelBlue;
            this.btn6.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(130, 157);
            this.btn6.Margin = new System.Windows.Forms.Padding(1);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(58, 46);
            this.btn6.TabIndex = 26;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.SteelBlue;
            this.btn5.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(70, 157);
            this.btn5.Margin = new System.Windows.Forms.Padding(1);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(58, 46);
            this.btn5.TabIndex = 27;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.SteelBlue;
            this.btn4.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(10, 157);
            this.btn4.Margin = new System.Windows.Forms.Padding(1);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(58, 46);
            this.btn4.TabIndex = 28;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.SteelBlue;
            this.btn9.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(130, 109);
            this.btn9.Margin = new System.Windows.Forms.Padding(1);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(58, 46);
            this.btn9.TabIndex = 29;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.SteelBlue;
            this.btn0.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(10, 252);
            this.btn0.Margin = new System.Windows.Forms.Padding(1);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(118, 46);
            this.btn0.TabIndex = 30;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPonto.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonto.Location = new System.Drawing.Point(130, 252);
            this.btnPonto.Margin = new System.Windows.Forms.Padding(1);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(58, 46);
            this.btnPonto.TabIndex = 31;
            this.btnPonto.Text = ".";
            this.btnPonto.UseVisualStyleBackColor = false;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.IndianRed;
            this.btnSub.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSub.Location = new System.Drawing.Point(190, 108);
            this.btnSub.Margin = new System.Windows.Forms.Padding(1);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(58, 46);
            this.btnSub.TabIndex = 33;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.IndianRed;
            this.btnDiv.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDiv.Location = new System.Drawing.Point(190, 204);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(1);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(58, 46);
            this.btnDiv.TabIndex = 34;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.IndianRed;
            this.btnMult.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMult.Location = new System.Drawing.Point(190, 156);
            this.btnMult.Margin = new System.Windows.Forms.Padding(1);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(58, 46);
            this.btnMult.TabIndex = 35;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // txbTela
            // 
            this.txbTela.BackColor = System.Drawing.Color.DarkBlue;
            this.txbTela.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTela.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txbTela.Location = new System.Drawing.Point(10, 7);
            this.txbTela.Multiline = true;
            this.txbTela.Name = "txbTela";
            this.txbTela.ReadOnly = true;
            this.txbTela.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbTela.Size = new System.Drawing.Size(298, 50);
            this.txbTela.TabIndex = 36;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.IndianRed;
            this.btnVoltar.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoltar.Location = new System.Drawing.Point(130, 61);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(1);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(58, 46);
            this.btnVoltar.TabIndex = 37;
            this.btnVoltar.Text = "←";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnQuadrado
            // 
            this.btnQuadrado.BackColor = System.Drawing.Color.IndianRed;
            this.btnQuadrado.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuadrado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuadrado.Location = new System.Drawing.Point(250, 61);
            this.btnQuadrado.Margin = new System.Windows.Forms.Padding(1);
            this.btnQuadrado.Name = "btnQuadrado";
            this.btnQuadrado.Size = new System.Drawing.Size(58, 46);
            this.btnQuadrado.TabIndex = 38;
            this.btnQuadrado.Text = "x²";
            this.btnQuadrado.UseVisualStyleBackColor = false;
            this.btnQuadrado.Click += new System.EventHandler(this.btnQuadrado_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.Color.IndianRed;
            this.btnRaiz.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRaiz.Location = new System.Drawing.Point(250, 108);
            this.btnRaiz.Margin = new System.Windows.Forms.Padding(1);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(58, 46);
            this.btnRaiz.TabIndex = 39;
            this.btnRaiz.Text = "²√";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(317, 304);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnQuadrado);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txbTela);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnSinal);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSoma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSinal;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.TextBox txbTela;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnQuadrado;
        private System.Windows.Forms.Button btnRaiz;
    }
}


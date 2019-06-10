namespace Calculadora
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
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
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
            this.lblTela = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.Color.IndianRed;
            this.btnSoma.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSoma.Location = new System.Drawing.Point(12, 131);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(143, 130);
            this.btnSoma.TabIndex = 0;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.IndianRed;
            this.btnSub.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSub.Location = new System.Drawing.Point(161, 131);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(143, 130);
            this.btnSub.TabIndex = 15;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.IndianRed;
            this.btnMult.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMult.Location = new System.Drawing.Point(310, 131);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(143, 130);
            this.btnMult.TabIndex = 16;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.IndianRed;
            this.btnDiv.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDiv.Location = new System.Drawing.Point(459, 131);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(143, 130);
            this.btnDiv.TabIndex = 17;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.IndianRed;
            this.btnLimpar.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Location = new System.Drawing.Point(459, 267);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(143, 130);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "CE";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSinal
            // 
            this.btnSinal.BackColor = System.Drawing.Color.IndianRed;
            this.btnSinal.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSinal.Location = new System.Drawing.Point(459, 403);
            this.btnSinal.Name = "btnSinal";
            this.btnSinal.Size = new System.Drawing.Size(143, 130);
            this.btnSinal.TabIndex = 19;
            this.btnSinal.Text = "+/-";
            this.btnSinal.UseVisualStyleBackColor = false;
            this.btnSinal.Click += new System.EventHandler(this.btnSinal_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn7.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 267);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(143, 130);
            this.btn7.TabIndex = 20;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn8.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(161, 267);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(143, 130);
            this.btn8.TabIndex = 21;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnResultado.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnResultado.Location = new System.Drawing.Point(459, 539);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(143, 266);
            this.btnResultado.TabIndex = 22;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn3.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(310, 539);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(143, 130);
            this.btn3.TabIndex = 23;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn2.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(161, 539);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(143, 130);
            this.btn2.TabIndex = 24;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn1.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 539);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(143, 130);
            this.btn1.TabIndex = 25;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn6.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(310, 403);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(143, 130);
            this.btn6.TabIndex = 26;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn5.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(161, 403);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(143, 130);
            this.btn5.TabIndex = 27;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn4.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 403);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(143, 130);
            this.btn4.TabIndex = 28;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn9.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(310, 267);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(143, 130);
            this.btn9.TabIndex = 29;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn0.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(12, 675);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(292, 130);
            this.btn0.TabIndex = 30;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPonto.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonto.Location = new System.Drawing.Point(310, 675);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(143, 130);
            this.btnPonto.TabIndex = 31;
            this.btnPonto.Text = ",";
            this.btnPonto.UseVisualStyleBackColor = false;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // lblTela
            // 
            this.lblTela.AutoSize = true;
            this.lblTela.BackColor = System.Drawing.Color.IndianRed;
            this.lblTela.Font = new System.Drawing.Font("MingLiU-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTela.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTela.Location = new System.Drawing.Point(304, 32);
            this.lblTela.Name = "lblTela";
            this.lblTela.Size = new System.Drawing.Size(0, 56);
            this.lblTela.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 816);
            this.Controls.Add(this.lblTela);
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
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSoma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
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
        private System.Windows.Forms.Label lblTela;
    }
}


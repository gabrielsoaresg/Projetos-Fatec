
namespace CalculadoraForms
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
            this.PONTO = new System.Windows.Forms.Button();
            this.RESULT = new System.Windows.Forms.TextBox();
            this.ZERO = new System.Windows.Forms.Button();
            this.IGUAL = new System.Windows.Forms.Button();
            this.DOIS = new System.Windows.Forms.Button();
            this.TRES = new System.Windows.Forms.Button();
            this.QUATRO = new System.Windows.Forms.Button();
            this.CINCO = new System.Windows.Forms.Button();
            this.MAIS = new System.Windows.Forms.Button();
            this.SETE = new System.Windows.Forms.Button();
            this.OITO = new System.Windows.Forms.Button();
            this.NOVE = new System.Windows.Forms.Button();
            this.MENOS = new System.Windows.Forms.Button();
            this.VEZES = new System.Windows.Forms.Button();
            this.DIVISAO = new System.Windows.Forms.Button();
            this.RAIZQ = new System.Windows.Forms.Button();
            this.PI = new System.Windows.Forms.Button();
            this.FATORIAL = new System.Windows.Forms.Button();
            this.UM = new System.Windows.Forms.Button();
            this.LIMPAR = new System.Windows.Forms.Button();
            this.ELEVADO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOP = new System.Windows.Forms.Label();
            this.SEIS = new System.Windows.Forms.Button();
            this.LIMPARNUM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PONTO
            // 
            this.PONTO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PONTO.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PONTO.Location = new System.Drawing.Point(182, 417);
            this.PONTO.Name = "PONTO";
            this.PONTO.Size = new System.Drawing.Size(70, 46);
            this.PONTO.TabIndex = 0;
            this.PONTO.Text = ".";
            this.PONTO.UseVisualStyleBackColor = true;
            this.PONTO.Click += new System.EventHandler(this.PONTO_Click);
            // 
            // RESULT
            // 
            this.RESULT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RESULT.BackColor = System.Drawing.SystemColors.Desktop;
            this.RESULT.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESULT.ForeColor = System.Drawing.Color.Lime;
            this.RESULT.Location = new System.Drawing.Point(12, 12);
            this.RESULT.Multiline = true;
            this.RESULT.Name = "RESULT";
            this.RESULT.Size = new System.Drawing.Size(301, 132);
            this.RESULT.TabIndex = 1;
            this.RESULT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RESULT.TextChanged += new System.EventHandler(this.RESULT_TextChanged);
            // 
            // ZERO
            // 
            this.ZERO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ZERO.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZERO.Location = new System.Drawing.Point(12, 417);
            this.ZERO.Name = "ZERO";
            this.ZERO.Size = new System.Drawing.Size(164, 46);
            this.ZERO.TabIndex = 2;
            this.ZERO.Text = "0";
            this.ZERO.UseVisualStyleBackColor = true;
            this.ZERO.Click += new System.EventHandler(this.ZERO_Click);
            // 
            // IGUAL
            // 
            this.IGUAL.BackColor = System.Drawing.Color.DarkGray;
            this.IGUAL.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IGUAL.Location = new System.Drawing.Point(258, 365);
            this.IGUAL.Name = "IGUAL";
            this.IGUAL.Size = new System.Drawing.Size(55, 98);
            this.IGUAL.TabIndex = 4;
            this.IGUAL.Text = "=";
            this.IGUAL.UseVisualStyleBackColor = false;
            this.IGUAL.Click += new System.EventHandler(this.IGUAL_Click);
            // 
            // DOIS
            // 
            this.DOIS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DOIS.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOIS.Location = new System.Drawing.Point(100, 365);
            this.DOIS.Name = "DOIS";
            this.DOIS.Size = new System.Drawing.Size(76, 46);
            this.DOIS.TabIndex = 6;
            this.DOIS.Text = "2";
            this.DOIS.UseVisualStyleBackColor = true;
            this.DOIS.Click += new System.EventHandler(this.DOIS_Click);
            // 
            // TRES
            // 
            this.TRES.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TRES.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRES.Location = new System.Drawing.Point(182, 365);
            this.TRES.Name = "TRES";
            this.TRES.Size = new System.Drawing.Size(70, 46);
            this.TRES.TabIndex = 7;
            this.TRES.Text = "3";
            this.TRES.UseVisualStyleBackColor = true;
            this.TRES.Click += new System.EventHandler(this.TRES_Click);
            // 
            // QUATRO
            // 
            this.QUATRO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QUATRO.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.QUATRO.Location = new System.Drawing.Point(12, 313);
            this.QUATRO.Name = "QUATRO";
            this.QUATRO.Size = new System.Drawing.Size(82, 46);
            this.QUATRO.TabIndex = 8;
            this.QUATRO.Text = "4";
            this.QUATRO.UseVisualStyleBackColor = true;
            this.QUATRO.Click += new System.EventHandler(this.QUATRO_Click);
            // 
            // CINCO
            // 
            this.CINCO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CINCO.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.CINCO.Location = new System.Drawing.Point(100, 313);
            this.CINCO.Name = "CINCO";
            this.CINCO.Size = new System.Drawing.Size(76, 46);
            this.CINCO.TabIndex = 9;
            this.CINCO.Text = "5";
            this.CINCO.UseVisualStyleBackColor = true;
            this.CINCO.Click += new System.EventHandler(this.CINCO_Click);
            // 
            // MAIS
            // 
            this.MAIS.BackColor = System.Drawing.Color.DarkGray;
            this.MAIS.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.MAIS.Location = new System.Drawing.Point(258, 313);
            this.MAIS.Name = "MAIS";
            this.MAIS.Size = new System.Drawing.Size(55, 46);
            this.MAIS.TabIndex = 11;
            this.MAIS.Text = "+";
            this.MAIS.UseVisualStyleBackColor = false;
            this.MAIS.Click += new System.EventHandler(this.MAIS_Click);
            // 
            // SETE
            // 
            this.SETE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SETE.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.SETE.Location = new System.Drawing.Point(12, 261);
            this.SETE.Name = "SETE";
            this.SETE.Size = new System.Drawing.Size(82, 46);
            this.SETE.TabIndex = 12;
            this.SETE.Text = "7";
            this.SETE.UseVisualStyleBackColor = true;
            this.SETE.Click += new System.EventHandler(this.SETE_Click);
            // 
            // OITO
            // 
            this.OITO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OITO.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.OITO.Location = new System.Drawing.Point(100, 261);
            this.OITO.Name = "OITO";
            this.OITO.Size = new System.Drawing.Size(76, 46);
            this.OITO.TabIndex = 13;
            this.OITO.Text = "8";
            this.OITO.UseVisualStyleBackColor = true;
            this.OITO.Click += new System.EventHandler(this.OITO_Click);
            // 
            // NOVE
            // 
            this.NOVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NOVE.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.NOVE.Location = new System.Drawing.Point(182, 261);
            this.NOVE.Name = "NOVE";
            this.NOVE.Size = new System.Drawing.Size(70, 46);
            this.NOVE.TabIndex = 14;
            this.NOVE.Text = "9";
            this.NOVE.UseVisualStyleBackColor = true;
            this.NOVE.Click += new System.EventHandler(this.NOVE_Click);
            // 
            // MENOS
            // 
            this.MENOS.BackColor = System.Drawing.Color.DarkGray;
            this.MENOS.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.MENOS.Location = new System.Drawing.Point(258, 261);
            this.MENOS.Name = "MENOS";
            this.MENOS.Size = new System.Drawing.Size(55, 46);
            this.MENOS.TabIndex = 15;
            this.MENOS.Text = "-";
            this.MENOS.UseVisualStyleBackColor = false;
            this.MENOS.Click += new System.EventHandler(this.MENOS_Click);
            // 
            // VEZES
            // 
            this.VEZES.BackColor = System.Drawing.Color.DarkGray;
            this.VEZES.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.VEZES.Location = new System.Drawing.Point(258, 209);
            this.VEZES.Name = "VEZES";
            this.VEZES.Size = new System.Drawing.Size(55, 46);
            this.VEZES.TabIndex = 16;
            this.VEZES.Text = "X";
            this.VEZES.UseVisualStyleBackColor = false;
            this.VEZES.Click += new System.EventHandler(this.VEZES_Click);
            // 
            // DIVISAO
            // 
            this.DIVISAO.BackColor = System.Drawing.Color.DarkGray;
            this.DIVISAO.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIVISAO.Location = new System.Drawing.Point(259, 157);
            this.DIVISAO.Name = "DIVISAO";
            this.DIVISAO.Size = new System.Drawing.Size(54, 46);
            this.DIVISAO.TabIndex = 17;
            this.DIVISAO.Text = "÷";
            this.DIVISAO.UseVisualStyleBackColor = false;
            this.DIVISAO.Click += new System.EventHandler(this.DIVISAO_Click);
            // 
            // RAIZQ
            // 
            this.RAIZQ.BackColor = System.Drawing.Color.DarkGray;
            this.RAIZQ.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAIZQ.Location = new System.Drawing.Point(182, 209);
            this.RAIZQ.Name = "RAIZQ";
            this.RAIZQ.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RAIZQ.Size = new System.Drawing.Size(70, 46);
            this.RAIZQ.TabIndex = 18;
            this.RAIZQ.Text = "²√";
            this.RAIZQ.UseVisualStyleBackColor = false;
            this.RAIZQ.Click += new System.EventHandler(this.RAIZQ_Click);
            // 
            // PI
            // 
            this.PI.BackColor = System.Drawing.Color.DarkGray;
            this.PI.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.PI.Location = new System.Drawing.Point(100, 157);
            this.PI.Name = "PI";
            this.PI.Size = new System.Drawing.Size(76, 46);
            this.PI.TabIndex = 20;
            this.PI.Text = "π";
            this.PI.UseVisualStyleBackColor = false;
            this.PI.Click += new System.EventHandler(this.PI_Click);
            // 
            // FATORIAL
            // 
            this.FATORIAL.BackColor = System.Drawing.Color.DarkGray;
            this.FATORIAL.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FATORIAL.Location = new System.Drawing.Point(182, 157);
            this.FATORIAL.Name = "FATORIAL";
            this.FATORIAL.Size = new System.Drawing.Size(70, 46);
            this.FATORIAL.TabIndex = 21;
            this.FATORIAL.Text = " n!";
            this.FATORIAL.UseVisualStyleBackColor = false;
            this.FATORIAL.Click += new System.EventHandler(this.FATORIAL_Click);
            // 
            // UM
            // 
            this.UM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UM.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UM.Location = new System.Drawing.Point(12, 365);
            this.UM.Name = "UM";
            this.UM.Size = new System.Drawing.Size(82, 46);
            this.UM.TabIndex = 24;
            this.UM.Text = "1";
            this.UM.UseVisualStyleBackColor = true;
            this.UM.Click += new System.EventHandler(this.UM_Click);
            // 
            // LIMPAR
            // 
            this.LIMPAR.BackColor = System.Drawing.Color.DarkGray;
            this.LIMPAR.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIMPAR.Location = new System.Drawing.Point(12, 209);
            this.LIMPAR.Name = "LIMPAR";
            this.LIMPAR.Size = new System.Drawing.Size(82, 46);
            this.LIMPAR.TabIndex = 26;
            this.LIMPAR.Text = "C";
            this.LIMPAR.UseVisualStyleBackColor = false;
            this.LIMPAR.Click += new System.EventHandler(this.LIMPAR_Click);
            // 
            // ELEVADO
            // 
            this.ELEVADO.BackColor = System.Drawing.Color.DarkGray;
            this.ELEVADO.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ELEVADO.Location = new System.Drawing.Point(100, 209);
            this.ELEVADO.Name = "ELEVADO";
            this.ELEVADO.Size = new System.Drawing.Size(76, 46);
            this.ELEVADO.TabIndex = 27;
            this.ELEVADO.Text = "X²";
            this.ELEVADO.UseVisualStyleBackColor = false;
            this.ELEVADO.Click += new System.EventHandler(this.ELEVADO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(34, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 28;
            // 
            // labelOP
            // 
            this.labelOP.AutoSize = true;
            this.labelOP.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelOP.Location = new System.Drawing.Point(271, 113);
            this.labelOP.Name = "labelOP";
            this.labelOP.Size = new System.Drawing.Size(0, 13);
            this.labelOP.TabIndex = 29;
            // 
            // SEIS
            // 
            this.SEIS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SEIS.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.SEIS.Location = new System.Drawing.Point(182, 313);
            this.SEIS.Name = "SEIS";
            this.SEIS.Size = new System.Drawing.Size(70, 46);
            this.SEIS.TabIndex = 10;
            this.SEIS.Text = "6";
            this.SEIS.UseVisualStyleBackColor = true;
            this.SEIS.Click += new System.EventHandler(this.SEIS_Click);
            // 
            // LIMPARNUM
            // 
            this.LIMPARNUM.BackColor = System.Drawing.Color.DarkGray;
            this.LIMPARNUM.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIMPARNUM.Location = new System.Drawing.Point(12, 157);
            this.LIMPARNUM.Name = "LIMPARNUM";
            this.LIMPARNUM.Size = new System.Drawing.Size(82, 46);
            this.LIMPARNUM.TabIndex = 30;
            this.LIMPARNUM.Text = "CE";
            this.LIMPARNUM.UseVisualStyleBackColor = false;
            this.LIMPARNUM.Click += new System.EventHandler(this.LIMPARNUM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(325, 470);
            this.Controls.Add(this.LIMPARNUM);
            this.Controls.Add(this.labelOP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ELEVADO);
            this.Controls.Add(this.LIMPAR);
            this.Controls.Add(this.UM);
            this.Controls.Add(this.FATORIAL);
            this.Controls.Add(this.PI);
            this.Controls.Add(this.RAIZQ);
            this.Controls.Add(this.DIVISAO);
            this.Controls.Add(this.VEZES);
            this.Controls.Add(this.MENOS);
            this.Controls.Add(this.NOVE);
            this.Controls.Add(this.OITO);
            this.Controls.Add(this.SETE);
            this.Controls.Add(this.MAIS);
            this.Controls.Add(this.SEIS);
            this.Controls.Add(this.CINCO);
            this.Controls.Add(this.QUATRO);
            this.Controls.Add(this.TRES);
            this.Controls.Add(this.DOIS);
            this.Controls.Add(this.IGUAL);
            this.Controls.Add(this.ZERO);
            this.Controls.Add(this.RESULT);
            this.Controls.Add(this.PONTO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PONTO;
        private System.Windows.Forms.TextBox RESULT;
        private System.Windows.Forms.Button ZERO;
        private System.Windows.Forms.Button IGUAL;
        private System.Windows.Forms.Button DOIS;
        private System.Windows.Forms.Button TRES;
        private System.Windows.Forms.Button QUATRO;
        private System.Windows.Forms.Button CINCO;
        private System.Windows.Forms.Button MAIS;
        private System.Windows.Forms.Button SETE;
        private System.Windows.Forms.Button OITO;
        private System.Windows.Forms.Button NOVE;
        private System.Windows.Forms.Button MENOS;
        private System.Windows.Forms.Button VEZES;
        private System.Windows.Forms.Button RAIZQ;
        private System.Windows.Forms.Button PI;
        private System.Windows.Forms.Button FATORIAL;
        private System.Windows.Forms.Button DIVISAO;
        private System.Windows.Forms.Button UM;
        private System.Windows.Forms.Button LIMPAR;
        private System.Windows.Forms.Button ELEVADO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOP;
        private System.Windows.Forms.Button SEIS;
        private System.Windows.Forms.Button LIMPARNUM;
    }
}



namespace Calculadora01
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
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btLimpa = new System.Windows.Forms.Button();
            this.btApaga = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btSubtrai = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btPonto = new System.Windows.Forms.Button();
            this.btDivisao = new System.Windows.Forms.Button();
            this.btMultiplica = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.btSoma = new System.Windows.Forms.Button();
            this.lbOperador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(22, 22);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(254, 61);
            this.tbDisplay.TabIndex = 41;
            this.tbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btLimpa
            // 
            this.btLimpa.Location = new System.Drawing.Point(230, 89);
            this.btLimpa.Name = "btLimpa";
            this.btLimpa.Size = new System.Drawing.Size(46, 42);
            this.btLimpa.TabIndex = 40;
            this.btLimpa.Text = "CE";
            this.btLimpa.UseVisualStyleBackColor = true;
            this.btLimpa.Click += new System.EventHandler(this.btLimpa_Click);
            // 
            // btApaga
            // 
            this.btApaga.Location = new System.Drawing.Point(230, 137);
            this.btApaga.Name = "btApaga";
            this.btApaga.Size = new System.Drawing.Size(46, 42);
            this.btApaga.TabIndex = 39;
            this.btApaga.Text = "C";
            this.btApaga.UseVisualStyleBackColor = true;
            this.btApaga.Click += new System.EventHandler(this.btApaga_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(22, 89);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(46, 42);
            this.bt7.TabIndex = 38;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.button13_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(74, 89);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(46, 42);
            this.bt8.TabIndex = 37;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(126, 89);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(46, 42);
            this.bt9.TabIndex = 36;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // btSubtrai
            // 
            this.btSubtrai.Location = new System.Drawing.Point(178, 137);
            this.btSubtrai.Name = "btSubtrai";
            this.btSubtrai.Size = new System.Drawing.Size(46, 42);
            this.btSubtrai.TabIndex = 34;
            this.btSubtrai.Text = "-";
            this.btSubtrai.UseVisualStyleBackColor = true;
            this.btSubtrai.Click += new System.EventHandler(this.btSubtrai_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(126, 137);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(46, 42);
            this.bt6.TabIndex = 33;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.button10_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(74, 137);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(46, 42);
            this.bt5.TabIndex = 32;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.button11_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(22, 137);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(46, 42);
            this.bt4.TabIndex = 31;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.button12_Click);
            // 
            // btIgual
            // 
            this.btIgual.Location = new System.Drawing.Point(230, 185);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(46, 90);
            this.btIgual.TabIndex = 30;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(22, 233);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(98, 42);
            this.bt0.TabIndex = 29;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btPonto
            // 
            this.btPonto.Location = new System.Drawing.Point(126, 233);
            this.btPonto.Name = "btPonto";
            this.btPonto.Size = new System.Drawing.Size(46, 42);
            this.btPonto.TabIndex = 28;
            this.btPonto.Text = ".";
            this.btPonto.UseVisualStyleBackColor = true;
            this.btPonto.Click += new System.EventHandler(this.btPonto_Click);
            // 
            // btDivisao
            // 
            this.btDivisao.Location = new System.Drawing.Point(178, 233);
            this.btDivisao.Name = "btDivisao";
            this.btDivisao.Size = new System.Drawing.Size(46, 42);
            this.btDivisao.TabIndex = 27;
            this.btDivisao.Text = "/";
            this.btDivisao.UseVisualStyleBackColor = true;
            this.btDivisao.Click += new System.EventHandler(this.btDivisao_Click);
            // 
            // btMultiplica
            // 
            this.btMultiplica.Location = new System.Drawing.Point(178, 185);
            this.btMultiplica.Name = "btMultiplica";
            this.btMultiplica.Size = new System.Drawing.Size(46, 42);
            this.btMultiplica.TabIndex = 26;
            this.btMultiplica.Text = "x";
            this.btMultiplica.UseVisualStyleBackColor = true;
            this.btMultiplica.Click += new System.EventHandler(this.btMultiplica_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(126, 185);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(46, 42);
            this.bt3.TabIndex = 25;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(74, 185);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(46, 42);
            this.bt2.TabIndex = 24;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(22, 185);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(46, 42);
            this.bt1.TabIndex = 23;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSoma
            // 
            this.btSoma.Location = new System.Drawing.Point(178, 89);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(46, 42);
            this.btSoma.TabIndex = 42;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // lbOperador
            // 
            this.lbOperador.AutoSize = true;
            this.lbOperador.Location = new System.Drawing.Point(35, 49);
            this.lbOperador.Name = "lbOperador";
            this.lbOperador.Size = new System.Drawing.Size(0, 13);
            this.lbOperador.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 311);
            this.Controls.Add(this.lbOperador);
            this.Controls.Add(this.btSoma);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.btLimpa);
            this.Controls.Add(this.btApaga);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.btSubtrai);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btPonto);
            this.Controls.Add(this.btDivisao);
            this.Controls.Add(this.btMultiplica);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btLimpa;
        private System.Windows.Forms.Button btApaga;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btSubtrai;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btPonto;
        private System.Windows.Forms.Button btDivisao;
        private System.Windows.Forms.Button btMultiplica;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Label lbOperador;
    }
}


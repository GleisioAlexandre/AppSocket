namespace AppSocket
{
    partial class AppSoket
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPorta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxNPreco = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(134, 371);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(132, 53);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Alterar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servidor";
            // 
            // txtServidor
            // 
            this.txtServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServidor.Location = new System.Drawing.Point(29, 62);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(180, 31);
            this.txtServidor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Porta";
            // 
            // cbxPorta
            // 
            this.cbxPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPorta.FormattingEnabled = true;
            this.cbxPorta.Items.AddRange(new object[] {
            "2001",
            "1771",
            "7002"});
            this.cbxPorta.Location = new System.Drawing.Point(250, 60);
            this.cbxPorta.Name = "cbxPorta";
            this.cbxPorta.Size = new System.Drawing.Size(121, 33);
            this.cbxPorta.TabIndex = 4;
            this.cbxPorta.Text = "2001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Código do Bico";
            // 
            // txtBico
            // 
            this.txtBico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBico.Location = new System.Drawing.Point(29, 158);
            this.txtBico.Name = "txtBico";
            this.txtBico.Size = new System.Drawing.Size(61, 31);
            this.txtBico.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nivel de Preço";
            // 
            // cbxNPreco
            // 
            this.cbxNPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNPreco.FormattingEnabled = true;
            this.cbxNPreco.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxNPreco.Location = new System.Drawing.Point(250, 156);
            this.cbxNPreco.Name = "cbxNPreco";
            this.cbxNPreco.Size = new System.Drawing.Size(43, 33);
            this.cbxNPreco.TabIndex = 8;
            this.cbxNPreco.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(29, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 31);
            this.textBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Preço";
            // 
            // AppSoket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxNPreco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxPorta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConectar);
            this.Name = "AppSoket";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPorta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxNPreco;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}


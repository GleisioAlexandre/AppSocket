namespace AppSocket.view
{
    partial class FrmAbastecimentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAbastecimentos = new System.Windows.Forms.TextBox();
            this.btnLerAbastecimento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAbastecimentos
            // 
            this.txtAbastecimentos.Location = new System.Drawing.Point(187, 12);
            this.txtAbastecimentos.Multiline = true;
            this.txtAbastecimentos.Name = "txtAbastecimentos";
            this.txtAbastecimentos.Size = new System.Drawing.Size(329, 561);
            this.txtAbastecimentos.TabIndex = 0;
            // 
            // btnLerAbastecimento
            // 
            this.btnLerAbastecimento.Location = new System.Drawing.Point(12, 550);
            this.btnLerAbastecimento.Name = "btnLerAbastecimento";
            this.btnLerAbastecimento.Size = new System.Drawing.Size(118, 23);
            this.btnLerAbastecimento.TabIndex = 1;
            this.btnLerAbastecimento.Text = "Ler Abastecimentos";
            this.btnLerAbastecimento.UseVisualStyleBackColor = true;
            this.btnLerAbastecimento.Click += new System.EventHandler(this.btnLerAbastecimento_Click);
            // 
            // FrmAbastecimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 585);
            this.Controls.Add(this.btnLerAbastecimento);
            this.Controls.Add(this.txtAbastecimentos);
            this.Name = "FrmAbastecimentos";
            this.Text = "FrmAbastecimentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAbastecimentos;
        private System.Windows.Forms.Button btnLerAbastecimento;
    }
}
namespace AppSocket.view
{
    partial class FrmLeituraDeAbasteciemnto
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
            this.btnLerAbastecimento = new System.Windows.Forms.Button();
            this.txtRespostaAbastecimento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLerAbastecimento
            // 
            this.btnLerAbastecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLerAbastecimento.Location = new System.Drawing.Point(43, 562);
            this.btnLerAbastecimento.Name = "btnLerAbastecimento";
            this.btnLerAbastecimento.Size = new System.Drawing.Size(202, 54);
            this.btnLerAbastecimento.TabIndex = 0;
            this.btnLerAbastecimento.Text = "Ler Abastecimentos";
            this.btnLerAbastecimento.UseVisualStyleBackColor = true;
            this.btnLerAbastecimento.Click += new System.EventHandler(this.btnLerAbastecimento_Click);
            // 
            // txtRespostaAbastecimento
            // 
            this.txtRespostaAbastecimento.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRespostaAbastecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespostaAbastecimento.ForeColor = System.Drawing.Color.Red;
            this.txtRespostaAbastecimento.Location = new System.Drawing.Point(296, 12);
            this.txtRespostaAbastecimento.Multiline = true;
            this.txtRespostaAbastecimento.Name = "txtRespostaAbastecimento";
            this.txtRespostaAbastecimento.ReadOnly = true;
            this.txtRespostaAbastecimento.Size = new System.Drawing.Size(811, 604);
            this.txtRespostaAbastecimento.TabIndex = 1;
            // 
            // FrmLeituraDeAbasteciemnto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 628);
            this.Controls.Add(this.txtRespostaAbastecimento);
            this.Controls.Add(this.btnLerAbastecimento);
            this.Name = "FrmLeituraDeAbasteciemnto";
            this.Text = "FrmLeituraDeAbasteciemnto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLerAbastecimento;
        private System.Windows.Forms.TextBox txtRespostaAbastecimento;
    }
}
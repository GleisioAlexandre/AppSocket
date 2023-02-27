namespace AppSocket.view
{
    partial class FrmConfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.cbxPorta = new System.Windows.Forms.ComboBox();
            this.btnSalvarConfig = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.preçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocaDePreçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identifidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCartãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Porta";
            // 
            // txtHost
            // 
            this.txtHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHost.Location = new System.Drawing.Point(26, 73);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(160, 29);
            this.txtHost.TabIndex = 2;
            // 
            // cbxPorta
            // 
            this.cbxPorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPorta.FormattingEnabled = true;
            this.cbxPorta.Items.AddRange(new object[] {
            "1771",
            "2001",
            "7002",
            "857",
            "771"});
            this.cbxPorta.Location = new System.Drawing.Point(299, 70);
            this.cbxPorta.Name = "cbxPorta";
            this.cbxPorta.Size = new System.Drawing.Size(95, 32);
            this.cbxPorta.TabIndex = 3;
            // 
            // btnSalvarConfig
            // 
            this.btnSalvarConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarConfig.Location = new System.Drawing.Point(312, 122);
            this.btnSalvarConfig.Name = "btnSalvarConfig";
            this.btnSalvarConfig.Size = new System.Drawing.Size(82, 42);
            this.btnSalvarConfig.TabIndex = 4;
            this.btnSalvarConfig.Text = "Salvar";
            this.btnSalvarConfig.UseVisualStyleBackColor = true;
            this.btnSalvarConfig.Click += new System.EventHandler(this.btnSalvarConfig_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preçoToolStripMenuItem,
            this.identifidToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(431, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // preçoToolStripMenuItem
            // 
            this.preçoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trocaDePreçoToolStripMenuItem});
            this.preçoToolStripMenuItem.Name = "preçoToolStripMenuItem";
            this.preçoToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.preçoToolStripMenuItem.Text = "Preço";
            // 
            // trocaDePreçoToolStripMenuItem
            // 
            this.trocaDePreçoToolStripMenuItem.Name = "trocaDePreçoToolStripMenuItem";
            this.trocaDePreçoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trocaDePreçoToolStripMenuItem.Text = "Troca de Preço";
            this.trocaDePreçoToolStripMenuItem.Click += new System.EventHandler(this.trocaDePreçoToolStripMenuItem_Click);
            // 
            // identifidToolStripMenuItem
            // 
            this.identifidToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeCartãoToolStripMenuItem});
            this.identifidToolStripMenuItem.Name = "identifidToolStripMenuItem";
            this.identifidToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.identifidToolStripMenuItem.Text = "Identifid";
            // 
            // cadastroDeCartãoToolStripMenuItem
            // 
            this.cadastroDeCartãoToolStripMenuItem.Name = "cadastroDeCartãoToolStripMenuItem";
            this.cadastroDeCartãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroDeCartãoToolStripMenuItem.Text = "Cadastro de Cartão";
            this.cadastroDeCartãoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCartãoToolStripMenuItem_Click);
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 182);
            this.Controls.Add(this.btnSalvarConfig);
            this.Controls.Add(this.cbxPorta);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "1771";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.ComboBox cbxPorta;
        private System.Windows.Forms.Button btnSalvarConfig;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem preçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocaDePreçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identifidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCartãoToolStripMenuItem;
    }
}
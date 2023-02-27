namespace AppSocket.view
{
    partial class FrmIdentifid
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
            this.btnGravarRfid = new System.Windows.Forms.Button();
            this.cbxControle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxA = new System.Windows.Forms.CheckBox();
            this.cbxB = new System.Windows.Forms.CheckBox();
            this.horaAI = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.horaAF = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.horaBF = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.horaBI = new System.Windows.Forms.DateTimePicker();
            this.lblHost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGravarRfid
            // 
            this.btnGravarRfid.Location = new System.Drawing.Point(154, 427);
            this.btnGravarRfid.Name = "btnGravarRfid";
            this.btnGravarRfid.Size = new System.Drawing.Size(89, 32);
            this.btnGravarRfid.TabIndex = 0;
            this.btnGravarRfid.Text = "Gravar";
            this.btnGravarRfid.UseVisualStyleBackColor = true;
            this.btnGravarRfid.Click += new System.EventHandler(this.btnGravarRfid_Click);
            // 
            // cbxControle
            // 
            this.cbxControle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxControle.FormattingEnabled = true;
            this.cbxControle.Items.AddRange(new object[] {
            "Tag veículo",
            "Tag máquina de lavar",
            "Reservado",
            "Cliente nível 1",
            "Cliente nível 2",
            "Cliente nível 3",
            "Funcionário nível 1",
            "Funcionário nível 2",
            "Funcionário nível 3",
            "Funcionário nível 4",
            "Funcionário nível 5",
            "Funcionário nível 6",
            "Gerente nível 1",
            "Gerente nível 2",
            "Controle total"});
            this.cbxControle.Location = new System.Drawing.Point(300, 85);
            this.cbxControle.Name = "cbxControle";
            this.cbxControle.Size = new System.Drawing.Size(117, 21);
            this.cbxControle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Controle do Cartão";
            // 
            // txtTag
            // 
            this.txtTag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTag.Location = new System.Drawing.Point(12, 86);
            this.txtTag.MaxLength = 16;
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(158, 20);
            this.txtTag.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código do Cartão";
            // 
            // cbxA
            // 
            this.cbxA.AutoSize = true;
            this.cbxA.Location = new System.Drawing.Point(12, 136);
            this.cbxA.Name = "cbxA";
            this.cbxA.Size = new System.Drawing.Size(64, 17);
            this.cbxA.TabIndex = 5;
            this.cbxA.Text = "Turno A";
            this.cbxA.UseVisualStyleBackColor = true;
            // 
            // cbxB
            // 
            this.cbxB.AutoSize = true;
            this.cbxB.Location = new System.Drawing.Point(12, 178);
            this.cbxB.Name = "cbxB";
            this.cbxB.Size = new System.Drawing.Size(64, 17);
            this.cbxB.TabIndex = 6;
            this.cbxB.Text = "Turno B";
            this.cbxB.UseVisualStyleBackColor = true;
            // 
            // horaAI
            // 
            this.horaAI.CustomFormat = "HH:mm";
            this.horaAI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horaAI.Location = new System.Drawing.Point(82, 136);
            this.horaAI.Name = "horaAI";
            this.horaAI.ShowUpDown = true;
            this.horaAI.Size = new System.Drawing.Size(64, 20);
            this.horaAI.TabIndex = 7;
            this.horaAI.Value = new System.DateTime(2023, 2, 26, 11, 43, 34, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Início";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fim";
            // 
            // horaAF
            // 
            this.horaAF.CustomFormat = "HH:mm";
            this.horaAF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horaAF.Location = new System.Drawing.Point(167, 136);
            this.horaAF.Name = "horaAF";
            this.horaAF.ShowUpDown = true;
            this.horaAF.Size = new System.Drawing.Size(64, 20);
            this.horaAF.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fim";
            // 
            // horaBF
            // 
            this.horaBF.CustomFormat = "HH:mm";
            this.horaBF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horaBF.Location = new System.Drawing.Point(167, 178);
            this.horaBF.Name = "horaBF";
            this.horaBF.ShowUpDown = true;
            this.horaBF.Size = new System.Drawing.Size(64, 20);
            this.horaBF.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Início";
            // 
            // horaBI
            // 
            this.horaBI.CustomFormat = "HH:mm";
            this.horaBI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horaBI.Location = new System.Drawing.Point(82, 178);
            this.horaBI.Name = "horaBI";
            this.horaBI.ShowUpDown = true;
            this.horaBI.Size = new System.Drawing.Size(64, 20);
            this.horaBI.TabIndex = 11;
            this.horaBI.Value = new System.DateTime(2023, 2, 26, 11, 17, 0, 0);
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(9, 473);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(29, 13);
            this.lblHost.TabIndex = 15;
            this.lblHost.Text = "Host";
            // 
            // FrmIdentifid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 495);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.horaBF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.horaBI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.horaAF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.horaAI);
            this.Controls.Add(this.cbxB);
            this.Controls.Add(this.cbxA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxControle);
            this.Controls.Add(this.btnGravarRfid);
            this.MaximizeBox = false;
            this.Name = "FrmIdentifid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIdentifid";
            this.Load += new System.EventHandler(this.FrmIdentifid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravarRfid;
        private System.Windows.Forms.ComboBox cbxControle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxA;
        private System.Windows.Forms.CheckBox cbxB;
        private System.Windows.Forms.DateTimePicker horaAI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker horaAF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker horaBF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker horaBI;
        private System.Windows.Forms.Label lblHost;
    }
}
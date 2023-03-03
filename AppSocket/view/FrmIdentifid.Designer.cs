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
			this.components = new System.ComponentModel.Container();
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
			this.rbReservado = new System.Windows.Forms.RadioButton();
			this.rbBomba = new System.Windows.Forms.RadioButton();
			this.rbTurno = new System.Windows.Forms.RadioButton();
			this.rbBombaTurno = new System.Windows.Forms.RadioButton();
			this.rbMaquina = new System.Windows.Forms.RadioButton();
			this.rbBombaMaquina = new System.Windows.Forms.RadioButton();
			this.cbxPortTcu = new System.Windows.Forms.ComboBox();
			this.portaSerial = new System.IO.Ports.SerialPort(this.components);
			this.btnTcu = new System.Windows.Forms.Button();
			this.cbxTagManual = new System.Windows.Forms.CheckBox();
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
			this.cbxControle.Location = new System.Drawing.Point(298, 51);
			this.cbxControle.Name = "cbxControle";
			this.cbxControle.Size = new System.Drawing.Size(117, 21);
			this.cbxControle.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(295, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Controle do Cartão";
			// 
			// txtTag
			// 
			this.txtTag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTag.Location = new System.Drawing.Point(12, 51);
			this.txtTag.MaxLength = 16;
			this.txtTag.Name = "txtTag";
			this.txtTag.ReadOnly = true;
			this.txtTag.Size = new System.Drawing.Size(158, 20);
			this.txtTag.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 35);
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
			// rbReservado
			// 
			this.rbReservado.AutoSize = true;
			this.rbReservado.Location = new System.Drawing.Point(12, 250);
			this.rbReservado.Name = "rbReservado";
			this.rbReservado.Size = new System.Drawing.Size(77, 17);
			this.rbReservado.TabIndex = 16;
			this.rbReservado.TabStop = true;
			this.rbReservado.Text = "Reservado";
			this.rbReservado.UseVisualStyleBackColor = true;
			// 
			// rbBomba
			// 
			this.rbBomba.AutoSize = true;
			this.rbBomba.Checked = true;
			this.rbBomba.Location = new System.Drawing.Point(13, 273);
			this.rbBomba.Name = "rbBomba";
			this.rbBomba.Size = new System.Drawing.Size(90, 17);
			this.rbBomba.TabIndex = 17;
			this.rbBomba.TabStop = true;
			this.rbBomba.Text = "Libera Bomba";
			this.rbBomba.UseVisualStyleBackColor = true;
			// 
			// rbTurno
			// 
			this.rbTurno.AutoSize = true;
			this.rbTurno.Location = new System.Drawing.Point(13, 296);
			this.rbTurno.Name = "rbTurno";
			this.rbTurno.Size = new System.Drawing.Size(94, 17);
			this.rbTurno.TabIndex = 18;
			this.rbTurno.TabStop = true;
			this.rbTurno.Text = "Respeita turno";
			this.rbTurno.UseVisualStyleBackColor = true;
			// 
			// rbBombaTurno
			// 
			this.rbBombaTurno.AutoSize = true;
			this.rbBombaTurno.Location = new System.Drawing.Point(13, 319);
			this.rbBombaTurno.Name = "rbBombaTurno";
			this.rbBombaTurno.Size = new System.Drawing.Size(164, 17);
			this.rbBombaTurno.TabIndex = 19;
			this.rbBombaTurno.TabStop = true;
			this.rbBombaTurno.Text = "Libera bomba / respeita turno";
			this.rbBombaTurno.UseVisualStyleBackColor = true;
			// 
			// rbMaquina
			// 
			this.rbMaquina.AutoSize = true;
			this.rbMaquina.Location = new System.Drawing.Point(13, 342);
			this.rbMaquina.Name = "rbMaquina";
			this.rbMaquina.Size = new System.Drawing.Size(138, 17);
			this.rbMaquina.TabIndex = 20;
			this.rbMaquina.TabStop = true;
			this.rbMaquina.Text = "Libera máquina de lavar";
			this.rbMaquina.UseVisualStyleBackColor = true;
			// 
			// rbBombaMaquina
			// 
			this.rbBombaMaquina.AutoSize = true;
			this.rbBombaMaquina.Location = new System.Drawing.Point(12, 365);
			this.rbBombaMaquina.Name = "rbBombaMaquina";
			this.rbBombaMaquina.Size = new System.Drawing.Size(214, 17);
			this.rbBombaMaquina.TabIndex = 21;
			this.rbBombaMaquina.TabStop = true;
			this.rbBombaMaquina.Text = "Libera bombas / libera máquina de lavar";
			this.rbBombaMaquina.UseVisualStyleBackColor = true;
			// 
			// cbxPortTcu
			// 
			this.cbxPortTcu.FormattingEnabled = true;
			this.cbxPortTcu.Location = new System.Drawing.Point(298, 87);
			this.cbxPortTcu.Name = "cbxPortTcu";
			this.cbxPortTcu.Size = new System.Drawing.Size(117, 21);
			this.cbxPortTcu.TabIndex = 23;
			// 
			// portaSerial
			// 
			this.portaSerial.PortName = "COM6";
			// 
			// btnTcu
			// 
			this.btnTcu.Location = new System.Drawing.Point(193, 51);
			this.btnTcu.Name = "btnTcu";
			this.btnTcu.Size = new System.Drawing.Size(82, 23);
			this.btnTcu.TabIndex = 24;
			this.btnTcu.Text = "Copiar Código";
			this.btnTcu.UseVisualStyleBackColor = true;
			this.btnTcu.Click += new System.EventHandler(this.btnTcu_Click);
			// 
			// cbxTagManual
			// 
			this.cbxTagManual.AutoSize = true;
			this.cbxTagManual.Checked = true;
			this.cbxTagManual.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxTagManual.Location = new System.Drawing.Point(12, 91);
			this.cbxTagManual.Name = "cbxTagManual";
			this.cbxTagManual.Size = new System.Drawing.Size(83, 17);
			this.cbxTagManual.TabIndex = 25;
			this.cbxTagManual.Text = "Tag Manual";
			this.cbxTagManual.UseVisualStyleBackColor = true;
			this.cbxTagManual.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// FrmIdentifid
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 495);
			this.Controls.Add(this.cbxTagManual);
			this.Controls.Add(this.btnTcu);
			this.Controls.Add(this.cbxPortTcu);
			this.Controls.Add(this.rbBombaMaquina);
			this.Controls.Add(this.rbMaquina);
			this.Controls.Add(this.rbBombaTurno);
			this.Controls.Add(this.rbTurno);
			this.Controls.Add(this.rbBomba);
			this.Controls.Add(this.rbReservado);
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
        private System.Windows.Forms.RadioButton rbReservado;
        private System.Windows.Forms.RadioButton rbBomba;
        private System.Windows.Forms.RadioButton rbTurno;
        private System.Windows.Forms.RadioButton rbBombaTurno;
        private System.Windows.Forms.RadioButton rbMaquina;
        private System.Windows.Forms.RadioButton rbBombaMaquina;
        private System.Windows.Forms.ComboBox cbxPortTcu;
        private System.IO.Ports.SerialPort portaSerial;
        private System.Windows.Forms.Button btnTcu;
		private System.Windows.Forms.CheckBox cbxTagManual;
	}
}
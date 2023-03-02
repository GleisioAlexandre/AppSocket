namespace AppSocket.view
{
    partial class FrmTcu
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
            this.txtTeste = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.portaSerial = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // txtTeste
            // 
            this.txtTeste.Location = new System.Drawing.Point(477, 59);
            this.txtTeste.Multiline = true;
            this.txtTeste.Name = "txtTeste";
            this.txtTeste.Size = new System.Drawing.Size(283, 462);
            this.txtTeste.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // portaSerial
            // 
            this.portaSerial.PortName = "COM6";
            // 
            // FrmTcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTeste);
            this.Name = "FrmTcu";
            this.Text = "FrmTcu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTeste;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort portaSerial;
    }
}
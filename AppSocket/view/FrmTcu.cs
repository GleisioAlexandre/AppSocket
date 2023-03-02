using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSocket.view
{
    public partial class FrmTcu : Form
    {
        public FrmTcu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           SerialPort serialPort = new SerialPort ("COM6", 9600, Parity.None, 8, StopBits.One);
            byte[] dados = Encoding.ASCII.GetBytes("(%MA$D7)");
            serialPort.Open();
            if (serialPort.IsOpen) {
                lblteste.Text = "Conectado";
               serialPort.WriteLine(dados.ToString());
                string data = serialPort.ReadLine();
                serialPort.Close();
                txtTeste.Text = Encoding.ASCII.GetString(dados);
                
                
               
            }
        }
    }
}

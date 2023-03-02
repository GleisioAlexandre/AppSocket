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
            
            portaSerial.Open();
            string Rfid = portaSerial.ReadExisting().Replace("(", "").Replace(")", "").Replace("#", "").Replace("R", "").Substring(0, Text.Length + 10);
            portaSerial.WriteLine("(%MD$DA)");
            txtTeste.AppendText(Rfid) ;
            portaSerial.Close();
          
           
           




        }

    }
}




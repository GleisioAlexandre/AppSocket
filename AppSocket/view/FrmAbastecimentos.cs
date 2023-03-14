using AppSocket.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSocket.view
{
    public partial class FrmAbastecimentos : Form
    {
        string host = ConfigurationManager.AppSettings["host"];
        string porta = ConfigurationManager.AppSettings["porta"];
        public FrmAbastecimentos()
        {
            InitializeComponent();
        }

        private void btnLerAbastecimento_Click(object sender, EventArgs e)
        {
            ComunicacaoSocket skt = new ComunicacaoSocket();
            string datain = "(&A)";
            string pula = "(&I)";
            
            
                skt.Comunicacao(host, int.Parse(porta), datain);
            txtAbastecimentos.AppendText(skt.retorno());
            skt.Comunicacao(host, int.Parse(porta), pula);














        }
    }
}

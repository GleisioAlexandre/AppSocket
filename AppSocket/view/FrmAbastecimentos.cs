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
            string datain = "(&A)";
           string retorno;
            ComunicacaoSocket skt = new ComunicacaoSocket();
            

            retorno = skt.retorno();
            try
            {
                skt.Comunicacao(host, int.Parse(porta), datain);
                retorno = skt.retorno();
                txtAbastecimentos.AppendText(retorno + "\r\n");
                            



            }
            catch (Exception ex)
            {
                btnLerAbastecimento.Focus();
                MessageBox.Show("Erro: " + ex, "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
                       
        }
    }
}

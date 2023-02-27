using AppSocket.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AppSocket
{
    public partial class AppSoket : Form
    {
        string host = ConfigurationManager.AppSettings["host"];
        string porta = ConfigurationManager.AppSettings["porta"];
        public AppSoket()
        {
            InitializeComponent();
        }
        
                      
        private void btnConectar_Click(object sender, EventArgs e)
        {
            string cabecalho = null;
            if (gpbTrocaPreco.Checked)
            {
                cabecalho = "&U";
            }
            // Pegas as informações e cria o checksum
            Checksum calculadorChecksum = new Checksum();
            string checksum = calculadorChecksum.ChecksumAlteraPReco(cabecalho, txtBico.Text, cbxNPreco.SelectedItem.ToString(), int.Parse(txtPreco.Text.Replace(",", "")).ToString());
            //Envia as infomrções ao servidor junto com checksumn
            try
            {
                ComunicacaoSocket sckt = new ComunicacaoSocket();
                string dataIn = "(" + cabecalho + txtBico.Text + cbxNPreco.SelectedItem + txtPreco.Text.Replace(",", "") + checksum + ")";
                sckt.Comunicacao(host, int.Parse(porta), dataIn);
                string str = sckt.retorno();
                txtResposta.AppendText("Preço do Bico: " + str.Substring(2, str.Length - 3) + ", alterado com sucesso!\r\n");
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar o servidor!\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtPrazo_ValueChanged(object sender, EventArgs e)
        {
           // dataFinal = dtPrazo.Value;
        }
        private void teste_Click(object sender, EventArgs e)
        {
           // Console.WriteLine("Data inicial: " + dataInicial + "\r\nData Final: " + dataFinal);
        }
        private void txtPreco_Leave(object sender, EventArgs e)
        {
            if (txtPreco.Text.Length < 5)
            {
                txtPreco.Text = txtPreco.Text.PadRight(5,'0');
            }
        }

        
        private void dtInicio_ValueChanged(object sender, EventArgs e)
        {
           // dataInicial = dtInicio.Value;
        }

        private void AppSoket_Load(object sender, EventArgs e)
        {
            txtServidor.Text = host;
            txtPorta.Text = porta;
        }
    }
}

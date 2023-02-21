using AppSocket.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSocket.view
{
    public partial class FrmLeituraDeAbasteciemnto : Form
    {
        public FrmLeituraDeAbasteciemnto()
        {
            InitializeComponent();
        }

        private void btnLerAbastecimento_Click(object sender, EventArgs e)
        {
            TrocaDePreco trocaPreco = new TrocaDePreco();

            TcpClient cliente = new TcpClient();

            cliente.Connect("127.0.0.1", 2001);

            NetworkStream stream = cliente.GetStream();

            byte[] menssagem = System.Text.Encoding.ASCII.GetBytes("(&A)");
            stream.Write(menssagem, 0, menssagem.Length);

            byte[] resposta = new byte[256];
            int bytesRead = stream.Read(resposta, 0, resposta.Length);
            string respostaMenssagem = System.Text.Encoding.ASCII.GetString(resposta, 0, bytesRead);
            txtRespostaAbastecimento.AppendText(respostaMenssagem + "\r\n");

            stream.Close();
            cliente.Close();
            Console.ReadLine();

        }
    }
}

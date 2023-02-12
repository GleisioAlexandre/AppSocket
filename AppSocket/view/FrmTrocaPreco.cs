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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSocket
{
    public partial class AppSoket : Form
    {
        public AppSoket()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string cabecalho = null;
            if (gpbTrocaPreco.Checked) {
                 cabecalho = "&U";
            }
            CalculadorChecksum calculadorChecksum = new CalculadorChecksum();
            string checksum = calculadorChecksum.calcular(cabecalho, txtBico.Text, cbxNPreco.SelectedItem.ToString(), txtPreco.Text);
            Console.WriteLine(checksum);
            try
            {

                ClassSocket sckt = new ClassSocket();
                string dataIn = "(" + cabecalho + txtBico.Text + cbxNPreco.SelectedItem + txtPreco.Text + checksum + ")";
                Console.WriteLine(dataIn);
                sckt.TrocaDePreco(txtServidor.Text, int.Parse(cbxPorta.SelectedItem.ToString()), dataIn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar o servidor!\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

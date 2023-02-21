﻿using AppSocket.controller;
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
            if (gpbTrocaPreco.Checked)
            {
                cabecalho = "&U";
            }
            // Pegas as informações e cria o checksum
            CalculadorChecksum calculadorChecksum = new CalculadorChecksum();
            string checksum = calculadorChecksum.calcular(cabecalho, txtBico.Text, cbxNPreco.SelectedItem.ToString(), int.Parse(txtPreco.Text).ToString());

            //Envia as infomrções ao servidor junto com checksumn
            try
            {

                TrocaDePreco sckt = new TrocaDePreco();
                string dataIn = "(" + cabecalho + txtBico.Text + cbxNPreco.SelectedItem + txtPreco.Text + checksum + ")";
                sckt.AlteraDePreco(txtServidor.Text, int.Parse(cbxPorta.SelectedItem.ToString()), dataIn);

                string retorno = sckt.Resposta();
                txtResposta.AppendText("O Preço do Bico " + retorno.Substring(2, retorno.Length - 3) + ", foi alterado com sucesso.\r\n");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar o servidor!\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}

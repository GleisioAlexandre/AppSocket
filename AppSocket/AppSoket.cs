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

            string entradaDeDados = "&U" + txtBico.Text + cbxNPreco.SelectedItem + txtPreco.Text;
            byte[] data = Encoding.UTF8.GetBytes(entradaDeDados);

            int checksum = 0;
            foreach (byte b in data)
            {
                checksum = (checksum + b) % 256;
            }

               try {
                    string hostName = txtServidor.Text;
                    // IPAddress ip = IPAddress.Parse("127.0.0.1");
                    int porta = int.Parse(cbxPorta.SelectedItem.ToString());

                    TcpClient cliente = new TcpClient();

                    cliente.Connect(hostName, porta);

                    NetworkStream stream = cliente.GetStream();

                    byte[] menssagem = System.Text.Encoding.UTF8.GetBytes("(&U" + txtBico.Text + cbxNPreco.SelectedItem + txtPreco.Text + checksum.ToString("x2").ToUpper() + ")");

                    stream.Write(menssagem, 0, menssagem.Length);

                    stream.Close();
                    cliente.Close();
                    Console.WriteLine(menssagem);
                    Console.ReadLine();
                }
                catch (Exception ex) {
                    MessageBox.Show("Erro ao conectar o servidor!\n" + ex, "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}

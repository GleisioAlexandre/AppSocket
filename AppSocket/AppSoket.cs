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
            try {
                string hostName = txtServidor.Text;
                // IPAddress ip = IPAddress.Parse("127.0.0.1");
                int porta = int.Parse(cbxPorta.SelectedItem.ToString());

                TcpClient cliente = new TcpClient();

                cliente.Connect(hostName, porta);

                NetworkStream stream = cliente.GetStream();

                byte[] menssagem = System.Text.Encoding.ASCII.GetBytes("(&U" + ")");

                stream.Write(menssagem, 0, menssagem.Length);

                stream.Close();
                cliente.Close();
                Console.WriteLine("Conexão Fechada.");
                Console.ReadLine();
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao conectar o servidor!\n" + ex, "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

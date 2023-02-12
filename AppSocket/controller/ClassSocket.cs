using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AppSocket.controller
{
    class ClassSocket
    {
        public void TrocaDePreco(string namehost, int port, string dataIn){

            try
            {
                TcpClient client = new TcpClient();

                client.Connect(namehost, port);

                NetworkStream stream = client.GetStream();

                byte[] message = System.Text.Encoding.ASCII.GetBytes(dataIn);
                stream.Write(message, 0, message.Length);

                /* byte[] resposta = new byte[256];
                 int bytesRead = stream.Read(resposta, 0, resposta.Length);
                 string menssagemResposta = System.Text.Encoding.ASCII.GetString(resposta, 0, bytesRead);
                 Console.WriteLine("Rtorno: " + menssagemResposta);*/
                stream.Close();
                client.Close();

                
            }
            catch
            {

            }
        }


    }
}

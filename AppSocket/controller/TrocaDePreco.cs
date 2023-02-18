using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AppSocket.controller
{
    class TrocaDePreco
    {
        public void AlteraDePreco(string namehost, int port, string dataIn){

            try
            {
                TcpClient client = new TcpClient();

                client.Connect(namehost, port);

                NetworkStream stream = client.GetStream();

                byte[] message = System.Text.Encoding.ASCII.GetBytes(dataIn);
                stream.Write(message, 0, message.Length);

                stream.Close();
                client.Close();

                
            }
            catch
            {

            }
        }


    }
}

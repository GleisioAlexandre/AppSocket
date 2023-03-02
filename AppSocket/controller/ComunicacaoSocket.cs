using AppSocket.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AppSocket.controller
{
    class ComunicacaoSocket
    {
        ClassSocket sk = new ClassSocket();
        public void Comunicacao(string namehost, int port, string dataIn)
        {
            sk.NameHost = namehost;
            sk.Porta = port;
            //Socket Cliente
            TcpClient client = new TcpClient();
            //Conexao do socket cliente com o servidor
            client.Connect(sk.NameHost, sk.Porta);
            //Obtem o fluxo de rede do socket
            NetworkStream stream = client.GetStream();
            //Envia uma mensssagem ao servidor
            byte[] message = System.Text.Encoding.ASCII.GetBytes(dataIn);
            stream.Write(message, 0, message.Length);
            //Recebe a resposta do servidor
            byte[] resposta = new byte[256];
            int byteRead = stream.Read(resposta, 0, resposta.Length);
            string menssagemResposta = System.Text.Encoding.ASCII.GetString(resposta, 0, byteRead);
            sk.Retorno = menssagemResposta.ToString();
            stream.Close();
            client.Close();
            Console.ReadLine();

          
        }
        public string retorno() {

            
            return sk.Retorno;
        }
    }
}

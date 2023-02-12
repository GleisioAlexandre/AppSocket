using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSocket.controller
{
    class CalculadorChecksum
    {
        public string calcular(string cabecalho, string codigoBico, string nivelDePreco, string preco) {
            //String de entrada
            string entradaDeDadoa = cabecalho + codigoBico + nivelDePreco + preco;

            //Codificação da string de entrada
            byte[] data = Encoding.UTF8.GetBytes(entradaDeDadoa);

            //Variavel checksum criada e iniciada com o valor 0
            int checksum = 0;

            //loop percorrendo cada byte na string que foi codificada loga acima
            foreach (byte b in data)
            {
                //adiciona o byte atual à variavel checksum
                checksum = (checksum + b) % 256;
            }

            //Converte o valor da variavel checksum em uma string hexadecimal com letras maiúsculas
            string hexChecksum = checksum.ToString("x2").ToUpper();

            return hexChecksum;


        }
        
    }
}

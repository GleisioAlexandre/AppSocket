using AppSocket.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSocket.controller
{
    class Checksum
    {
        public string ChecksumAlteraPReco(string cabecalho, string codigoBico, string nivelDePreco, string preco) {

            ClassChecksum cks = new ClassChecksum(cabecalho, codigoBico, nivelDePreco, preco);
            
            
            //String de entrada
            string entradaDeDadoa = cks.Cabecalho + cks.CodigoBico + cks.NivelPreco + cks.Preco;

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

        public string ChecksumCadastraIdentifid(string cabecalho, string contorle, string parametro, string tag, string turnoAInicio, string turnoAFinal, string turnoBInicio, string turnoBFinal)
        {
            ClassChecksum cks = new ClassChecksum(cabecalho, contorle, parametro, tag, turnoAInicio, turnoAFinal, turnoBInicio, turnoBFinal);
            //String de entrada
            string entradaDeDados = cks.Cabecalho + cks.ControleIdentifd + cks.ParamentroIdentifid + cks.TagIdentifid + cks.TurnoAInicial + cks.TurnoAFinal + cks.TurnoBInicial + cks.TurnoBFinal;

            //Codificação da string de entrada
            byte[] data = Encoding.UTF8.GetBytes(entradaDeDados);

            //Variavel checksum criada e iniciada com 0
            int checksum = 0;

            //loop percorrendo cada  byte na string que foi codificada logo acima
            foreach (byte b in data)
            {
                //adiciona o valor atual a variavel checksum
                checksum = (checksum + b) % 256;

            }
            //Converte o valor da variavel checksum em um string hexadecimal com letras maiúsculas
            string hexChecksum = checksum.ToString("x2").ToUpper();

            return hexChecksum;
        }
        
    }
}

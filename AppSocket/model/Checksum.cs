using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSocket.model
{
    class Checksum
    {
        private string cabecalho;
        private string codigoBico;
        private string nivelPreco;
        private string preco;
        private string resposta;

        public Checksum(string cabecalho, string codigoBico, string nivelPreco, string preco, string checksum)
        {
            this.Cabecalho = cabecalho;
            this.CodigoBico = codigoBico;
            this.NivelPreco = nivelPreco;
            this.Preco = preco;
            this.Resposta = Resposta;
        }

        public string Cabecalho { get => cabecalho; set => cabecalho = value; }
        public string CodigoBico { get => codigoBico; set => codigoBico = value; }
        public string NivelPreco { get => nivelPreco; set => nivelPreco = value; }
        public string Preco { get => preco; set => preco = value; }
        public string Resposta { get => resposta; set => resposta = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSocket.model
{
    class ClassChecksum
    {
        private string cabecalho;
        private string codigoBico;
        private string nivelPreco;
        private string preco;

        public ClassChecksum(string cabecalho, string codigoBico, string nivelPreco, string preco)
        {
            this.Cabecalho = cabecalho;
            this.CodigoBico = codigoBico;
            this.NivelPreco = nivelPreco;
            this.Preco = preco;
        }

        public string Cabecalho { get => cabecalho; set => cabecalho = value; }
        public string CodigoBico { get => codigoBico; set => codigoBico = value; }
        public string NivelPreco { get => nivelPreco; set => nivelPreco = value; }
        public string Preco { get => preco; set => preco = value; }
    }
}

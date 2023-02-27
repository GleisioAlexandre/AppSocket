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
        private string controleIdentifd;
        private string paramentroIdentifid;
        private string tagIdentifid;
        private string turnoAInicial;
        private string turnoAFinal;
        private string turnoBInicial;
        private string turnoBFinal;

        public ClassChecksum(string cabecalho, string codigoBico, string nivelPreco, string preco)
        {
            this.Cabecalho = cabecalho;
            this.CodigoBico = codigoBico;
            this.NivelPreco = nivelPreco;
            this.Preco = preco;
        }

        public ClassChecksum(string cabecalho, string controleIdentifd, string paramentroIdentifid, string tagIdentifid, string turnoAInicial, string turnoAFinal, string turnoBInicial, string turnoBFinal)
        {
            this.cabecalho = cabecalho;
            this.controleIdentifd = controleIdentifd;
            this.paramentroIdentifid = paramentroIdentifid;
            this.tagIdentifid = tagIdentifid;
            this.turnoAInicial = turnoAInicial;
            this.turnoAFinal = turnoAFinal;
            this.turnoBInicial = turnoBInicial;
            this.turnoBFinal = turnoBFinal;
        }

        public string Cabecalho { get => cabecalho; set => cabecalho = value; }
        public string CodigoBico { get => codigoBico; set => codigoBico = value; }
        public string NivelPreco { get => nivelPreco; set => nivelPreco = value; }
        public string Preco { get => preco; set => preco = value; }
        public string ControleIdentifd { get => controleIdentifd; set => controleIdentifd = value; }
        public string ParamentroIdentifid { get => paramentroIdentifid; set => paramentroIdentifid = value; }
        public string TagIdentifid { get => tagIdentifid; set => tagIdentifid = value; }
        public string TurnoAInicial { get => turnoAInicial; set => turnoAInicial = value; }
        public string TurnoAFinal { get => turnoAFinal; set => turnoAFinal = value; }
        public string TurnoBInicial { get => turnoBInicial; set => turnoBInicial = value; }
        public string TurnoBFinal { get => turnoBFinal; set => turnoBFinal = value; }
    }
}

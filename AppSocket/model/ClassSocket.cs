using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSocket.model
{
    class ClassSocket
    {
        private string nameHost;
        private int porta;
        private string retorno;

        public ClassSocket()
        {
        }
        public ClassSocket(string nameHost, int porta)
        {
            this.NameHost = nameHost;
            this.Porta = porta;
        }
        public void print() {
            Console.WriteLine(nameHost + porta + retorno);
        }
        public string NameHost { get => nameHost; set => nameHost = value; }
        public int Porta { get => porta; set => porta = value; }
        public string Retorno { get => retorno; set => retorno = value; }
    }
}

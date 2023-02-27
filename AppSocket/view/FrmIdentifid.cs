using AppSocket.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSocket.view
{
    public partial class FrmIdentifid : Form
    {
        string host = ConfigurationManager.AppSettings["host"];
        string porta = ConfigurationManager.AppSettings["porta"];
        public FrmIdentifid()
        {
            InitializeComponent();
        }

        private void btnGravarRfid_Click(object sender, EventArgs e)
        {

            GeradorDeCodigoIdentFid();
            Console.WriteLine(GeradorDeCodigoIdentFid());
           enviaTagIdentifid();
        }


        public string controleTag(string controle)
        {
            switch (cbxControle.SelectedItem)
            {
                case "Tag veículo":
                    controle = "21";
                    break;
                case "Tag máquina de lavar":
                    controle = "22";
                    break;
                case "Reservado":
                    controle = "23";
                    break;
                case "Cliente nível 1":
                    controle = "24";
                    break;
                case "Cliente nível 2":
                    controle = "25";
                    break;
                case "Cliente nível 3":
                    controle = "26";
                    break;
                case "Funcionário nível 1":
                    controle = "27";
                    break;
                case "Funcionário nível 2":
                    controle = "28";
                    break;
                case "Funcionário nível 3":
                    controle = "29";
                    break;
                case "Funcionário nível 4":
                    controle = "2A";
                    break;
                case "Funcionário nível 5":
                    controle = "2B";
                    break;
                case "Funcionário nível 6":
                    controle = "2C";
                    break;
                case "Gerente nível 1":
                    controle = "2D";
                    break;
                case "Gerente nível 2":
                    controle = "2E";
                    break;
                case "Controle total":
                    controle = "2F";
                    break;
            }
            return controle;
        }
        public string GeradorDeCodigoIdentFid()
        {
           
            string controle = null;
            string cabecalho = "?F";
            string parametro = "G";
            string turnoAI, turnoAF, turnoBI, turnoBF;
            turnoAI = null;
            turnoAF = null;
            turnoBI = null;
            turnoBF = null;


            if (cbxA.Checked && cbxB.Checked)
            {
                turnoAI = "0000";
                turnoAF = "0000";
                turnoBF = "0000";
                turnoBI = "0000";
            }
            else if (cbxA.Checked)
            {
                turnoAI = horaAI.Value.Hour.ToString().PadLeft(2, '0').ToString() + horaAI.Value.Minute.ToString().PadRight(2, '0').Replace(":", "").ToString();
                turnoAF = horaAF.Value.Hour.ToString().PadLeft(2, '0').ToString() + horaAF.Value.Minute.ToString().PadRight(2, '0').Replace(":", "").ToString();
                turnoBF = "0000";
                turnoBI = "0000";
            }
            else
            {
                turnoAI = "0000";
                turnoAF = "0000";
                ; turnoBI = horaBI.Value.Hour.ToString().PadLeft(2, '0').ToString() + horaBI.Value.Minute.ToString().PadRight(2, '0').Replace(":", "").ToString();
                turnoBF = horaBF.Value.Hour.ToString().PadLeft(2, '0').ToString() + horaBF.Value.Minute.ToString().PadRight(2, '0').Replace(":", "").ToString();
            }

            controle = controleTag(controle);
            Checksum ck = new Checksum();
            string retorno = ck.ChecksumCadastraIdentifid(cabecalho, controle, parametro, txtTag.Text.ToUpper(), turnoAI, turnoAF, turnoBI, turnoBF);

            string saida = null;


            return  saida = "(" + cabecalho + controle + parametro + txtTag.Text.ToUpper() + turnoAI + turnoAF + turnoBI + turnoBF + retorno + ")";

            
        }

        public string enviaTagIdentifid() {

            try{
                ComunicacaoSocket sckt = new ComunicacaoSocket();
                sckt.Comunicacao(host, int.Parse(porta), GeradorDeCodigoIdentFid());
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            return null;
        }

            
            
    
        private void FrmIdentifid_Load(object sender, EventArgs e)
        {
            horaAI.Value = DateTime.Now.Date.Add(TimeSpan.Zero);
            horaAF.Value = DateTime.Now.Date.Add(TimeSpan.Zero);
            horaBI.Value = DateTime.Now.Date.Add(TimeSpan.Zero);
            horaBF.Value = DateTime.Now.Date.Add(TimeSpan.Zero);
            lblHost.Text = "Host: " + host + " Porta: " + porta;
        }
    }
}

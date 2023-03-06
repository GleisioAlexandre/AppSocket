using AppSocket.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO.Ports;
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

        public void Rfid(){

            try
            {
                if (txtTag.Equals(""))
                {
                    MessageBox.Show("O campos da tag não pode ser vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    portaSerial.Open();
                    portaSerial.WriteLine("(%MA$D7)");
                    string Rfid = portaSerial.ReadExisting().Replace("(", "").Replace(")", "").Replace("#", "").Replace("R", "").Replace("$", "").Substring(0, Text.Length + 4);
                    txtTag.Text = Rfid;
                    portaSerial.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                txtTag.Focus();
            }
            finally
            {
                portaSerial.Close();
            }
        }
        private void btnGravarRfid_Click(object sender, EventArgs e)
        {

            GeradorDeCodigoIdentFid();
            enviaTagIdentifid();
        }
        public string portasDisponiveis() {

            string[] portasDisponiveis = SerialPort.GetPortNames();

            cbxPortTcu.Items.AddRange(portasDisponiveis);
            return portasDisponiveis.ToString();
        }
        public string controleTag(string tipo)
        {
            switch (cbxControle.SelectedIndex)
            {
                case 0:
                    tipo = "1";
                    break;
                case 1:
                    tipo = "2";
                    break;
                case 2:
                    tipo = "3";
                    break;
                case 3:
                    tipo = "4";
                    break;
                case 4:
                    tipo = "5";
                    break;
                case 5:
                    tipo = "6";
                    break;
                case 6:
                    tipo = "7";
                    break;
                case 7:
                    tipo = "8";
                    break;
                case 8:
                    tipo = "9";
                    break;
                case 9:
                    tipo = "A";
                    break;
                case 10:
                    tipo = "B";
                    break;
                case 11:
                    tipo = "C";
                    break;
                case 12:
                    tipo = "D";
                    break;
                case 13:
                    tipo = "E";
                    break;
                case 14:
                    tipo = "F";
                    break;
            }
            return tipo;
        }
        public string permicao(string teste)
        {
            if (rbReservado.Checked) { teste = "1"; }
            else if (rbBomba.Checked) { teste = "2"; }
            else if (rbTurno.Checked) { teste = "4"; }
            else if (rbBombaTurno.Checked) { teste = "6"; }
            else if (rbMaquina.Checked) { teste = "8"; }
            else  { teste = "A"; }

            return teste;
        }
        public string GeradorDeCodigoIdentFid()
        {
            string tipo = null;
            string teste = null;
            string controle = null;
            string cabecalho = "?F";
            string parametro = "G";
            string turnoAI, turnoAF, turnoBI, turnoBF;
            string saida = null;
            string retorno = null;
            if (cbxA.Checked && cbxB.Checked)
            {
                turnoAI = horaAI.Value.Hour.ToString().PadLeft(2, '0').ToString() + horaAI.Value.Minute.ToString().PadRight(2, '0').Replace(":", "").ToString();
                turnoAF = horaAF.Value.Hour.ToString().PadLeft(2, '0').ToString() + horaAF.Value.Minute.ToString().PadRight(2, '0').Replace(":", "").ToString();
                turnoBF = horaBI.Value.Hour.ToString().PadLeft(2, '0').ToString() + horaBI.Value.Minute.ToString().PadRight(2, '0').Replace(":", "").ToString();
                turnoBI = horaBF.Value.Hour.ToString().PadLeft(2, '0').ToString() + horaBF.Value.Minute.ToString().PadRight(2, '0').Replace(":", "").ToString();
            }
            else if (cbxA.Checked)
            {
                turnoAI = horaAI.Value.Hour.ToString().PadLeft(2, '0').ToString() + horaAI.Value.Minute.ToString().PadRight(2, '0').Replace(":", "").ToString();
                turnoAF = horaAF.Value.Hour.ToString().PadLeft(2, '0').ToString() + horaAF.Value.Minute.ToString().PadRight(2, '0').Replace(":", "").ToString();
                turnoBF = "0000";
                turnoBI = "0000";
            }
            else if (cbxB.Checked)
            {
                turnoAI = "0000";
                turnoAF = "0000";
                turnoBI = horaBI.Value.Hour.ToString().PadLeft(2, '0').ToString() + horaBI.Value.Minute.ToString().PadRight(2, '0').Replace(":", "").ToString();
                turnoBF = horaBF.Value.Hour.ToString().PadLeft(2, '0').ToString() + horaBF.Value.Minute.ToString().PadRight(2, '0').Replace(":", "").ToString();
            }
            else
            {
                turnoAI = "0000";
                turnoAF = "0000";
                turnoBI = "0000";
                turnoBF = "0000";
            }
            try
            {
                controle = permicao(teste) + controleTag(tipo);
                Checksum ck = new Checksum();
                retorno = ck.ChecksumCadastraIdentifid(cabecalho, controle, parametro, txtTag.Text.ToUpper(), turnoAI, turnoAF, turnoBI, turnoBF);
            }
            catch (Exception ex)
            {

            }
            return saida = "(" + cabecalho + controle + parametro + txtTag.Text.ToUpper() + turnoAI + turnoAF + turnoBI + turnoBF + retorno + ")";
        }
        public void enviaTagIdentifid() {
            ComunicacaoSocket sckt = new ComunicacaoSocket();
            try
            {
                sckt.Comunicacao(host, int.Parse(porta), GeradorDeCodigoIdentFid());
                MessageBox.Show("A tag" + "foi cadastrado com sucesso!", "Rfid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmIdentifid_Load(object sender, EventArgs e)
        {
            horaAI.Value = DateTime.Now.Date.Add(TimeSpan.Zero);
            horaAF.Value = DateTime.Now.Date.Add(TimeSpan.Zero);
            horaBI.Value = DateTime.Now.Date.Add(TimeSpan.Zero);
            horaBF.Value = DateTime.Now.Date.Add(TimeSpan.Zero);
            lblHost.Text = "Host: " + host + " Porta: " + porta;
            cbxControle.SelectedIndex = 6;
            portasDisponiveis();
            txtTag.Focus();
           
        }
        
        private void btnTcu_Click(object sender, EventArgs e)
        {
            try
            {

                portaSerial.Open();
                portaSerial.WriteLine("(%MA$D7)");
                string Rfid = portaSerial.ReadExisting().Replace("(", "").Replace(")", "").Replace("#", "").Replace("R", "").Replace("$", "").Substring(0, Text.Length + 4);
                txtTag.Text = Rfid;
                portaSerial.Close();
                /* if (txtTag.Equals("")) {
                     MessageBox.Show("O campos da tag não pode ser vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                 else
                 {
                     portaSerial.PortName = cbxPortTcu.SelectedItem.ToString();
                     portaSerial.Open();
                     portaSerial.WriteLine("(%MA$D7)");
                     string Rfid = portaSerial.ReadExisting().Replace("(", "").Replace(")", "").Replace("#", "").Replace("R", "").Replace("$", "").Substring(0, Text.Length + 4);
                     txtTag.Text = Rfid;
                     portaSerial.Close();
                 }*/
            }
            catch 
            {
                MessageBox.Show("Aproxime o cartão da leitora , antes de copiar código!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTag.Focus();
            }
            finally
            {
                portaSerial.Close();
            }
        }
		private void cbxTagManual_CheckedChanged(object sender, EventArgs e)
		{
			if (cbxTagManual.Checked)
			{
				txtTag.ReadOnly = true;
                btnTcu.Enabled = true;
			}
			else {
				txtTag.ReadOnly = false;
                btnTcu.Enabled = false;
			}
		}
        private void button1_Click(object sender, EventArgs e)
        {
            portaSerial.PortName = cbxPortTcu.SelectedItem.ToString();
            Console.WriteLine(portaSerial.PortName);
            portaSerial.Open();
            if (portaSerial.IsOpen == true)
            {
                Console.WriteLine("Conectado");
            }
            else
            {
                Console.WriteLine("Erro");
            }
        }

        private void cbxPortTcu_SelectedIndexChanged(object sender, EventArgs e)
        {
            portaSerial.PortName = cbxPortTcu.SelectedItem.ToString();
        }
    }
}

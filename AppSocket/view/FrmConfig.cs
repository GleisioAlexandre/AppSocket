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
   
    public partial class FrmConfig : Form
    {
        
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void btnSalvarConfig_Click(object sender, EventArgs e)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["host"].Value = txtHost.Text;
                config.AppSettings.Settings["porta"].Value = cbxPorta.SelectedItem.ToString();
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                MessageBox.Show("Configurações realizadas e armazenadas com sucesso!", "Configuração", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            txtHost.Text = ConfigurationManager.AppSettings["host"];
            cbxPorta.SelectedItem = ConfigurationManager.AppSettings["porta"];
        }

        private void trocaDePreçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppSoket FrmtrocaPreco = new AppSoket();
            FrmtrocaPreco.Show();
        }

        private void cadastroDeCartãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIdentifid CadIdentifid = new FrmIdentifid();
            CadIdentifid.Show();
        }
    }
}

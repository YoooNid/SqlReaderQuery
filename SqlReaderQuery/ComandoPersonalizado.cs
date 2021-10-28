using ArquivoIni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlReaderQuery
{
    public partial class ComandoPersonalizado : Form
    {
        public ComandoPersonalizado()
        {
            InitializeComponent();
        }
        IniFiles ini = new IniFiles(@"C:\rrsoft\agiospdv\pdv.ini");
        private void Bt_GravarComandoPersonalizado_Click(object sender, EventArgs e)
        {
            string PreencherNome = Cb_PosicaoComando.Text;
            ini.IniWriteValue("COMANDOS", PreencherNome, Tx_EditarComando.Text);
            ini.IniWriteValue("COMANDOS", "NOME"+ PreencherNome, Tx_NomeComando.Text);

            MessageBox.Show("Comando Salvo na posição " + Tx_NomeComando.Text);
            this.Close();
           
                
        }
        private void Bt_FecharForm2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComandoPersonalizado_Load(object sender, EventArgs e)
        {
            Cb_PosicaoComando.SelectedIndex = 1;
        }
    }
}

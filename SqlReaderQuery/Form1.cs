﻿using ArquivoIni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlReaderQuery
{
    public partial class Fm_Principal : Form
    {
        IniFiles ini = new IniFiles(@"C:\rrsoft\agiospdv\pdv.ini"); // caminho para as configurações da instancia do banco de dados 
        SqlConnection con = new SqlConnection(); // instanciando sqlconnection 
        string Conexao = string.Empty;
        SqlCommand com = new SqlCommand();
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        DataSet ds;
        public Fm_Principal()
        {
            InitializeComponent();
            Conexao = @"Data Source = " + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Integrated Security = True";
        }

        private void Bt_Aplicar_Click(object sender, EventArgs e)
        {
            Gr_data.DataSource = null; // o que tiver no grid sera apagado
            //executa o que estiver no Tx_ComandoAplicar e joga as informações para a grid
            Gr_data.DataSource = ExecutarComando(Tx_ComandoAplicar.Text, @"Data Source = " + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Initial Catalog = " + Cb_Database.Text + "; Integrated Security = True");
            Lb_Contagem.Text = (Gr_data.Rows.Count - 1).ToString();

        }
        private void Fm_Principal_Load(object sender, EventArgs e)
        {
            Gr_data.AllowUserToOrderColumns = true; // habilita a ordenação no grid
            con.ConnectionString = (Conexao); // faz a conexão com o banco de dados 
            con.Open(); // abre a conexão com o banco
            com.Connection = con;
            com.CommandText = "select name from sys.databases"; // comando Sql que traz o nome das databases. 
            SqlDataReader dr = com.ExecuteReader();
            dt.Load(dr);
            Cb_Database.DisplayMember = "name";
            Cb_Database.DataSource = dt; // os dados listados são armazenados dentro do Combobox.
            con.Close(); // fecha a conexão 


            Lb_Contagem.Text = Gr_data.Rows.Count.ToString();
        }

        private void Cb_Database_SelectedValueChanged(object sender, EventArgs e)
        {

            con.Close();
            con.ConnectionString = (@"Data Source = " + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Initial Catalog = " + Cb_Database.Text + "; Integrated Security = True");
            con.Open();
            com.Connection = con;
            com.CommandText = "select TABLE_NAME from " + Cb_Database.Text + ".information_schema.columns where TABLE_CATALOG ='" + Cb_Database.Text + "' group by TABLE_NAME";

            SqlDataReader dr1 = com.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(dr1);
            Cb_Tables.DisplayMember = "TABLE_NAME";
            Cb_Tables.DataSource = dt1;
            con.Close();
        }

        private void Cb_Tables_SelectedValueChanged(object sender, EventArgs e)
        {
            Tx_ComandoAplicar.Text = "select * from " + Cb_Tables.Text;
        }

        private void Bt_Filtrar_Click(object sender, EventArgs e)
        {
            string valores;
            valores = Convert.ToString(Tx_ComandoAplicar.Text); // texto que esta armazenado no campo 
            string nome = Gr_data.CurrentCell.Value.ToString(); //pega a informação da celula selecionada e importa para texto
            nome = nome.Replace(',', '.');//troca as virgulas por ponto.

            if (Tx_ComandoAplicar.Text.Contains("Where") == true ^ Tx_ComandoAplicar.Text.Contains("where") == true)
            {

                Tx_ComandoAplicar.Text = valores + " and " + Gr_data.CurrentCell.OwningColumn.Name + "='" + nome + "'";
                Gr_data.DataSource = null;
                Gr_data.DataSource = ExecutarComando(Tx_ComandoAplicar.Text, @"Data Source = " + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Initial Catalog = " + Cb_Database.Text + "; Integrated Security = True");
                Lb_Contagem.Text = (Gr_data.Rows.Count - 1).ToString();
            }
            else
            {
                Tx_ComandoAplicar.Text += " Where " + Gr_data.CurrentCell.OwningColumn.Name + " ='" + nome + "'";
                Gr_data.DataSource = null;
                Gr_data.DataSource = ExecutarComando(Tx_ComandoAplicar.Text, @"Data Source = " + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Initial Catalog = " + Cb_Database.Text + "; Integrated Security = True");
                Lb_Contagem.Text = (Gr_data.Rows.Count - 1).ToString();
            }

        }

        private DataTable ExecutarComando(string Comando, string StringConexaoBancoDeDados)
        {
            ds = new DataSet();
            con.ConnectionString = StringConexaoBancoDeDados;
            da = new SqlDataAdapter(Comando , con);
            try
            {
                
                    con.Open();
                    da.Fill(ds, "all");
                    con.Close();
                    Lb_Contagem.Text = (Gr_data.Rows.Count - 1).ToString();
                    return ds.Tables["all"];
                
            }
            catch
            {
                MessageBox.Show("entrada invalida");
                con.Close();
                return ds.Tables["all"];
            }
            
        }

        private void Bt_Executar_Click(object sender, EventArgs e)
        {

            ds = new DataSet();
            Gr_data.DataSource = null;
            Gr_data.DataSource = ExecutarComando(Tx_ComandoExecutar.Text, @"Data Source = " + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Initial Catalog = " + Cb_Database.Text + "; Integrated Security = True");
            Lb_Contagem.Text = (Gr_data.Rows.Count - 1).ToString();
        }

        private void Bt_Excel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
            if (Gr_data.Rows.Count > 0) // se o datagrid tiver informações. 
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    //preenche o cabeçalho com as informações do nome das colunas
                    for (int i = 1; i < Gr_data.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = Gr_data.Columns[i - 1].HeaderText;
                    }
                    //preencher cada coluna e linha com as informações do grid
                    for (int i = 0; i < Gr_data.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < Gr_data.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = Gr_data.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //formata as colunas de forma automatica de acordo com os dados passados 
                    XcelApp.Columns.AutoFit();
                    //mostra o excel na frente com os dados processados 
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }
    }
}

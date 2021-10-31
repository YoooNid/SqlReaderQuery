using ArquivoIni;
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
            Lb_Contagem.Text = (Gr_data.Rows.Count - 1).ToString(); // contagem de rows na grid (tirando -1 por conta de uma linha gerada em branco )

        } // executa o comando do campo Tx_ComandoAplicar
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
            CarregarCamposPersonalizados(); // função para puxar do arquivo de configuração caso haja algum comando personalizado.



            Lb_Contagem.Text = Gr_data.Rows.Count.ToString();
        }

        private void Cb_Database_SelectedValueChanged(object sender, EventArgs e)
        {
            
            con.Close(); // caso a conexão venha aberta,  ela é fechada
            con.ConnectionString = (@"Data Source = " + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Initial Catalog = " + Cb_Database.Text + "; Integrated Security = True"); // inicia a conexão de acordo com o campo escolhido pelo usuario. 
            con.Open(); // abre a conexão com o banco de dados 
            com.Connection = con;
            com.CommandText = "select TABLE_NAME from " + Cb_Database.Text + ".information_schema.columns where TABLE_CATALOG ='" + Cb_Database.Text + "' group by TABLE_NAME"; // carrega o combobox com as informações das colunas da tabela selecionada. 

            SqlDataReader dr1 = com.ExecuteReader(); // executa o comando. 
            DataTable dt1 = new DataTable();
            dt1.Load(dr1); // carrega as informações. 
            Cb_Tables.DisplayMember = "TABLE_NAME";
            Cb_Tables.DataSource = dt1; // carrega as informações no combobox
            con.Close();
        } // ao selecionar o banco, carrega o combobox com as tabelas referentes ao banco selecionado

        private void Cb_Tables_SelectedValueChanged(object sender, EventArgs e)
        {
            Tx_ComandoAplicar.Text = "select * from " + Cb_Tables.Text; // assim que selecionado os dois combobox ele pega e transforma em comando de acordo com os dados. 
        }

        private void Bt_Filtrar_Click(object sender, EventArgs e)
        {
            string Comando = Tx_ComandoAplicar.Text.ToLower(); // transforma a string para caracteres minusculos. 
            string valores = Convert.ToString(Tx_ComandoAplicar.Text); // texto que esta armazenado no campo 
            string nome = Gr_data.CurrentCell.Value.ToString(); //pega a informação da celula selecionada e importa para texto
            nome = nome.Replace(',', '.');//troca as virgulas por ponto.

            if (Tx_ComandoAplicar.Text.Contains("where") == true) // se houver na string a palavra where, o programa em vez de colocar mais um where no filtro, ele coloca "and" 
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

        } // pega a celula selecionada e faz o filtro de acordo com a informação da celula clicada. 

        private DataTable ExecutarComando(string Comando, string StringConexaoBancoDeDados)
        {
            ds = new DataSet();
            con.ConnectionString = StringConexaoBancoDeDados;
            da = new SqlDataAdapter(Comando, con);
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

        } // função para "compilar" o comando.. passando como parametros o comando digitado e a string de conexão.

        private void ExecutarScript(string Comando, string StringConexaoBancoDeDados)
        {
            ds = new DataSet();
            con.ConnectionString = StringConexaoBancoDeDados;
            da = new SqlDataAdapter(Comando, con);
            try
            {
                con.Open();
                da.Fill(ds, "all");
                con.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show("entrada invalida" + e);
                con.Close();

            }
        } // Comando para executar um script digitado;

        public void CarregarCamposPersonalizados()
        {

            //melhorar usando case
            if (ini.IniReadValue("COMANDOS", "C1") != "")
            {
                LL_C1.Text = ini.IniReadValue("COMANDOS", "NOMEC1");
                LL_C1.Visible = true;
               
            }
            if (ini.IniReadValue("COMANDOS", "C2") != "")
            {
                LL_C2.Text = ini.IniReadValue("COMANDOS", "NOMEC2");
                LL_C2.Visible = true;
               
            }
            if (ini.IniReadValue("COMANDOS", "C3") != "")
            {
                LL_C3.Text = ini.IniReadValue("COMANDOS", "NOMEC3");
                LL_C3.Visible = true;
            }
            if (ini.IniReadValue("COMANDOS", "C4") != "")
            {
                LL_C4.Text = ini.IniReadValue("COMANDOS", "NOMEC4");
                LL_C4.Visible = true;
            }
            if (ini.IniReadValue("COMANDOS", "C5") != "")
            {
                LL_C5.Text = ini.IniReadValue("COMANDOS", "NOMEC5");
                LL_C5.Visible = true;
            }
        }

        private void Bt_Executar_Click(object sender, EventArgs e)
        {

            ds = new DataSet();
            Gr_data.DataSource = null;
            ExecutarScript(Tx_ComandoExecutar.Text, @"Data Source = " + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Initial Catalog = " + Cb_Database.Text + "; Integrated Security = True");
            Gr_data.DataSource = ExecutarComando(Tx_ComandoAplicar.Text, @"Data Source = " + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Initial Catalog = " + Cb_Database.Text + "; Integrated Security = True");
            Lb_Contagem.Text = (Gr_data.Rows.Count - 1).ToString();
        } // executa o comando dentro do Tx_ComandoExecutar. 

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
        } // grava os dados do grid em excel

        private void Gr_data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int Coluna = e.ColumnIndex;
            int Linha = e.RowIndex;
            string Valor = Gr_data.Rows[Linha].Cells[Coluna].Value.ToString();
            string NomeDaColuna = Gr_data.Columns[Coluna].Name;
            string NumeroDaLinha = Gr_data.Rows[Linha].Index.ToString();
            int NumeroDeLinhasView = Gr_data.Rows.Count - 1;
            //int cont;
            //int contColuna = 0;
            //int contLinha = 0;
            //for (cont = 0; cont <= NumeroDeLinhasView; cont++)
            //{
            //    if (dataGridView1.Rows[contLinha].Cells[contColuna].Value == dataGridView1.Rows[cont].Cells[contColuna].Value)

            //    {
            //        contColuna = contColuna + 1;
            //        cont = 0;
            //        MessageBox.Show("pulo de coluna");
            //    }


            //}
            string ChavePrimaria = Gr_data.Columns[0].Name;
            string ValorChavePrimaria = Gr_data.Rows[Linha].Cells[0].Value.ToString();

            string ComandoUpdate = "update " + Cb_Database.Text + ".." + Cb_Tables.Text + " set " + NomeDaColuna + " = '"+ Valor + "' where " + ChavePrimaria + " = '" + ValorChavePrimaria + "'";//nome da chave primaria+
            ExecutarScript(ComandoUpdate, @"Data Source = " + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Initial Catalog = " + Cb_Database.Text + "; Integrated Security = True");
            Gr_data.DataSource = ExecutarComando(Tx_ComandoAplicar.Text, @"Data Source = " + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Initial Catalog = " + Cb_Database.Text + "; Integrated Security = True");
        } // caso um valor for alterado no grid, o sistema irá carregar os dados e executar um comando para alterar no banco de dados. 

        private void Bt_Exportar_Click(object sender, EventArgs e)
        {
            string StringConexao = @"Data Source = " + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Initial Catalog = " + Cb_Database.Text + "; Integrated Security = True";

            string Where = Tx_ComandoAplicar.Text.ToLower();
            int Resultado = Where.IndexOf("where");
            if (Resultado > 1)
            {
                string ResultadoPosWhere = Where.Substring(Resultado);
                ExecutarScript("select * into DbSqltemp from " + Cb_Tables.Text + " " + ResultadoPosWhere, StringConexao);
            }
            else
                ExecutarScript("select * into DbSqltemp from " + Cb_Tables.Text, StringConexao);

            Gr_data.DataSource = ExecutarComando(Tx_ComandoAplicar.Text, StringConexao);
            MessageBox.Show("Dados Exportados com sucesso para a tabela temporaria");
        } // exporta os dados selecionados para uma tabela temporaria no banco de dados. 

        private void Bt_Delete_Click(object sender, EventArgs e)
        {
            string DeletarComando = "delete from " + Cb_Tables.Text+" ";
            int Resultado = Tx_ComandoAplicar.Text.ToLower().IndexOf("where");
            if (Resultado > 1)
            {
                string ResultadoPosWhere = Tx_ComandoAplicar.Text.Substring(Resultado);
                Tx_ComandoExecutar.Text = DeletarComando + ResultadoPosWhere;
            }
            else
                Tx_ComandoExecutar.Text = DeletarComando;

        } // caso o usuario quiser deletar, ao apertar o botão ele filtra a tabela que quer deletar e prepara o comando, caso tiver where no comando tudo que estiver a frente ele faz o filtro. 

        private void Bt_Importar_Click(object sender, EventArgs e)
        {
            string StringConexao = @"Data Source = " + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Initial Catalog = " + Cb_Database.Text + "; Integrated Security = True";
            string Where = Tx_ComandoAplicar.Text.ToLower();
            int Resultado = Where.IndexOf("where");
            if (Resultado > 1)
            {
                string ResultadoPosWhere = Where.Substring(Resultado);
                ExecutarScript("insert into " + Cb_Tables.Text + " select * from DbSqltemp " + ResultadoPosWhere, StringConexao);
                
            }
            else
                ExecutarScript("insert into " + Cb_Tables.Text + " select * from DbSqltemp ", StringConexao);

           // ExecutarScript("Drop table DbSqltemp", StringConexao);
            Gr_data.DataSource = ExecutarComando(Tx_ComandoAplicar.Text, StringConexao);

        } // pega os dados exportados anteriormente e joga nas tabelas selecionadas (caso a tabela seja diferente da exportada anteriormente o banco de dados retorna um erro.)

        private void LL_C1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ComandoPersonalizado TelaCadastroComandos = new ComandoPersonalizado();
            
            TelaCadastroComandos.Show();
        }
        private void LL_C1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tx_ComandoAplicar.Text = ini.IniReadValue("COMANDOS", "C1");
        }





    }
}


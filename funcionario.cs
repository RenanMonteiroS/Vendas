using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace testemenubd2
{
    public partial class funcionario : Form
    {
        public int Indice = 0;
        public int Id = 0;
        public MySqlDataReader rdr = null;
        public MySqlConnection conn = null;
        public MySqlCommand cmd = null;

        public funcionario()
        {
            InitializeComponent();
            Limpar();
            CarregaGrid();
            CarregaComboBox();
        }
        private void Gravar()
        {
            conn = new MySqlConnection("server=localhost;database=Banco_Cadastro;uid=root;pwd=");
            conn.Open();
            string sql = string.Empty;

            sql = "Insert into Tbl_Funcionario (Nomefunc,Enderecofunc,Emailfunc,Celular,Funcao) values (@Nome, @Endereco, @Email, @Celular, @Funcao)";
            

            MySqlCommand cm = new MySqlCommand(sql, conn);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = txtnomefunc.Text;
            cm.Parameters.Add("@Endereco", MySqlDbType.VarChar).Value = txtenderecofunc.Text;
            cm.Parameters.Add("@Email", MySqlDbType.VarChar).Value = txtemailfunc.Text;
            cm.Parameters.Add("@Celular", MySqlDbType.VarChar).Value = txtcelularfunc.Text;
            cm.Parameters.Add("@Funcao", MySqlDbType.VarChar).Value = combofuncaofunc.Text;
            cm.ExecuteNonQuery();
            



            CarregaGrid();
            Limpar();
        }

        private void Alterar()
        {
            conn = new MySqlConnection("server=localhost;database=Banco_Cadastro;uid=root;pwd=");
            conn.Open();
            string sql = string.Empty;

             
            sql = "Update Tbl_Funcionario set Nomefunc=@Nome,Enderecofunc=@Endereco,Emailfunc=@Email,Celular=@Celular,Funcao=@Funcao where Codigofunc=@Codigo";
            MySqlCommand cm = new MySqlCommand(sql, conn);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add("@Codigo", MySqlDbType.Int32).Value = Id;
            cm.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = txtnomefunc.Text;
            cm.Parameters.Add("@Endereco", MySqlDbType.VarChar).Value = txtenderecofunc.Text;
            cm.Parameters.Add("@Email", MySqlDbType.VarChar).Value = txtemailfunc.Text;
            cm.Parameters.Add("@Celular", MySqlDbType.VarChar).Value = txtcelularfunc.Text;
            cm.Parameters.Add("@Funcao", MySqlDbType.VarChar).Value = combofuncaofunc.Text;
            cm.ExecuteNonQuery();
        }
        private void Limpar()
        {
            Id = 0;
            txtnomefunc.Text = string.Empty;
            txtenderecofunc.Text = string.Empty;
            txtemailfunc.Text = string.Empty;
            txtcelularfunc.Text = string.Empty;
            txtnomefunc.Focus();
        }

        private void Excluir()
        {
            conn = new MySqlConnection("server=localhost;database=Banco_Cadastro;uid=root;pwd=");
            conn.Open();
            string sql = string.Empty;

            sql = "Delete from tbl_funcionario where Codigofunc=@Codigo";

            MySqlCommand cm = new MySqlCommand(sql, conn);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add("@Codigo", MySqlDbType.Int32).Value = Id;
            cm.ExecuteNonQuery();

            CarregaGrid();
            Limpar();
        }

        private void CarregaGrid()
        {
            conn = new MySqlConnection("server=localhost;database= Banco_Cadastro;uid=root;pwd=");
            conn.Open();
            string sql = "select Codigofunc, Nomefunc, Enderecofunc, Emailfunc, Celular, Funcao from Tbl_Funcionario order by Nomefunc";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grdDados.DataSource = dt;
        }

        private void Buscar()
        {
            conn = new MySqlConnection("server=localhost;database= Banco_Cadastro;uid=root;pwd=");
            conn.Open();
            string sql = "select Codigofunc, Nomefunc, Enderecofunc, Emailfunc, Celular, Funcao from Tbl_Funcionario WHERE Codigofunc LIKE '%" + txtBusca.Text + "%' OR Nomefunc LIKE '%" + txtBusca.Text + 
                "%' OR Enderecofunc LIKE '%" + txtBusca.Text + "%' OR Celular LIKE '%" + txtBusca.Text + "%' OR Funcao LIKE '%" + txtBusca.Text + "%' order by Nomefunc";

            if (txtBusca.Text == "")
            {
                sql = "SELECT * FROM Tbl_Funcionario";
            }
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grdDados.DataSource = dt;
        }
            private void CarregaComboBox()
        {
            conn = new MySqlConnection("server=localhost;database=Banco_Cadastro;uid=root;pwd=");
            conn.Open();
            string sql = "select Funcao from funcao";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    combofuncaofunc.Items.Add(dt.Rows[i]["Funcao"]);

                }

            }
            catch (MySqlException erro)
            {

                throw erro;
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdDados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Indice = e.RowIndex;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Id != 0)
                Alterar();
            else
                MessageBox.Show("Nenhum registro selecionado!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            CarregaGrid();
        }

        private void grdDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Limpar();
            Id = Convert.ToInt32(grdDados.Rows[Indice].Cells[0].Value);
            if (Id != 0)
            {
                txtnomefunc.Text = grdDados.Rows[Indice].Cells[1].Value.ToString();
                txtenderecofunc.Text = grdDados.Rows[Indice].Cells[2].Value.ToString();
                txtemailfunc.Text = grdDados.Rows[Indice].Cells[3].Value.ToString();
                txtcelularfunc.Text = grdDados.Rows[Indice].Cells[4].Value.ToString();
                combofuncaofunc.Text = grdDados.Rows[Indice].Cells[5].Value.ToString();
            }
            else
                MessageBox.Show("Registro nulo!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Id != 0)
                Excluir();
            else
                MessageBox.Show("Nenhum registro selecionado!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}

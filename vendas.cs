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
    public partial class vendas : Form
    {
        public vendas()
        {
            InitializeComponent();
            Limpar();
            CarregaGrid();
        }
        public int Indice = 0;
        public int Id = 0;
        public MySqlDataReader rdr = null;
        public MySqlConnection conn = null;
        public MySqlCommand cmd = null;

        private void Gravar()
        {
            conn = new MySqlConnection("server=localhost;database=Banco_Cadastro;uid=root;pwd=");
            conn.Open();
            string sql = string.Empty;

            sql = "Insert into tbl_venda (vendedor,produto,preco,data_venda) values (@vendedor, @produto, @preco, @data_venda)";


            MySqlCommand cm = new MySqlCommand(sql, conn);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add("@vendedor", MySqlDbType.VarChar).Value = txtVendedor.Text;
            cm.Parameters.Add("@produto", MySqlDbType.VarChar).Value = txtProduto.Text;
            cm.Parameters.Add("@preco", MySqlDbType.VarChar).Value = txtPreco.Text;
            cm.Parameters.Add("@data_venda", MySqlDbType.VarChar).Value = dateTimePicker1.Text;
            cm.ExecuteNonQuery();




            CarregaGrid();
            Limpar();
        }

        private void Alterar()
        {
            conn = new MySqlConnection("server=localhost;database=Banco_Cadastro;uid=root;pwd=");
            conn.Open();
            string sql = string.Empty;


            sql = "Update tbl_venda set vendedor=@vendedor,produto=@produto,preco=@preco,data_venda=@data_venda where num_pedido=@num_pedido";
            MySqlCommand cm = new MySqlCommand(sql, conn);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add("@num_pedido", MySqlDbType.VarChar).Value = Id;
            cm.Parameters.Add("@vendedor", MySqlDbType.VarChar).Value = txtVendedor.Text;
            cm.Parameters.Add("@produto", MySqlDbType.VarChar).Value = txtProduto.Text;
            cm.Parameters.Add("@preco", MySqlDbType.VarChar).Value = txtPreco.Text;
            cm.Parameters.Add("@data_venda", MySqlDbType.VarChar).Value = dateTimePicker1.Text;
            cm.ExecuteNonQuery();
        }

        private void Buscar()
        {
            conn = new MySqlConnection("server=localhost;database= Banco_Cadastro;uid=root;pwd=");
            conn.Open();
            string sql = "select num_pedido, vendedor, produto, preco, data_venda from tbl_venda WHERE num_pedido LIKE '%" + txtBusca.Text + "%' OR vendedor LIKE '%" + txtBusca.Text +
                "%' OR produto LIKE '%" + txtBusca.Text + "%' OR preco LIKE '%" + txtBusca.Text + "%' OR data_venda LIKE '%" + txtBusca.Text + "%' order by num_pedido";

            if (txtBusca.Text == "")
            {
                sql = "SELECT * FROM tbl_venda";
            }
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grdDados.DataSource = dt;
        }
        private void Limpar()
        {
            Id = 0;
            txtVendedor.Text = string.Empty;
            txtProduto.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtVendedor.Focus();
        }

        private void Excluir()
        {
            conn = new MySqlConnection("server=localhost;database=Banco_Cadastro;uid=root;pwd=");
            conn.Open();
            string sql = string.Empty;

            sql = "Delete from tbl_venda where num_pedido=@num_pedido";

            MySqlCommand cm = new MySqlCommand(sql, conn);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add("@num_pedido", MySqlDbType.Int32).Value = Id;
            cm.ExecuteNonQuery();

            CarregaGrid();
            Limpar();
        }

        private void CarregaGrid()
        {
            conn = new MySqlConnection("server=localhost;database= Banco_Cadastro;uid=root;pwd=");
            conn.Open();
            string sql = "select num_pedido, vendedor, produto, preco, data_venda from tbl_venda order by num_pedido";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grdDados.DataSource = dt;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(grdDados.Rows[Indice].Cells[0].Value);
            if (Id != 0)
                Alterar();
            else
                MessageBox.Show("Nenhum registro selecionado!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            CarregaGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(grdDados.Rows[Indice].Cells[0].Value);
            if (Id != 0)
                Excluir();
            else
                MessageBox.Show("Nenhum registro selecionado!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void grdDados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Indice = e.RowIndex;
        }

        private void grdDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Limpar();
            Id = Convert.ToInt32(grdDados.Rows[Indice].Cells[0].Value);
            if (Id != 0)
            {
                txtVendedor.Text = grdDados.Rows[Indice].Cells[1].Value.ToString();
                txtProduto.Text = grdDados.Rows[Indice].Cells[2].Value.ToString();
                txtPreco.Text = grdDados.Rows[Indice].Cells[3].Value.ToString();
                dateTimePicker1.Text = grdDados.Rows[Indice].Cells[4].Value.ToString();
            }

            else
               MessageBox.Show("Registro nulo!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}

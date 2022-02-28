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
    public partial class inicio : Form
    {
        public int login = 0;
        public MySqlDataReader rdr = null;
        public MySqlConnection conn = null;
        public MySqlCommand cmd = null;
        public inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;database=Banco_Cadastro;uid=root;pwd=");
            conn.Open();
            string sql = string.Empty;
            try
            {
                sql = "Insert into login (usuario,senha) values (@Usuario, @Senha)";

                MySqlCommand cm = new MySqlCommand(sql, conn);
                cm.CommandType = CommandType.Text;
                cm.Parameters.Add("@Usuario", MySqlDbType.VarChar).Value = txtUser.Text;
                cm.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = txtSenha.Text;
                cm.ExecuteNonQuery();
                MessageBox.Show("Dados cadastrados");
            }
            catch
            {
                MessageBox.Show("Dados inválidos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            conn = new MySqlConnection("server=localhost;database=Banco_Cadastro;uid=root;pwd=");
            conn.Open();
            string sql = string.Empty;

            sql = "Select usuario, senha from login";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

             try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToString(dt.Rows[i]["usuario"]) == txtUser.Text)
                    {
                        if (Convert.ToString(dt.Rows[i]["senha"]) == txtSenha.Text)
                        {
                            login = 1;
                        }

                    }
                }
                if (login == 1)
                {
                    this.Hide();

                    Form1 form1 = new Form1();
                    form1.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login/senha invalidos!");
                    txtSenha.Clear();
                }

            }
            catch (MySqlException erro)
            {

                throw erro;
            }
      


        }
    }
}

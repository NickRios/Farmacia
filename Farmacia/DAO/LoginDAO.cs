using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Farmacia.DAO
{
    class LoginDAO
    {
        private Model.Login loginDAO;
        private MySqlConnection con;
        private Utils.Conexao conexao;
        private Views.Menu menu;

        public void Cadastrar(String usuario, String senha)
        {
            con = new MySqlConnection();
            loginDAO = new Model.Login();
            conexao = new Utils.Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "INSERT INTO login(Usuario, Senha)";
            query += " VALUES (?Usuario, ?Senha)";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?Usuario", usuario);
                cmd.Parameters.AddWithValue("?Senha", senha);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

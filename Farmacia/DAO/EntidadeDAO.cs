using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Farmacia.DAO
{
    class EntidadeDAO
    {
        private Model.Entidade entModel;
        private MySqlConnection con;
        private Utils.Conexao conexao;

        public void InserirDados(String Nome, String Registro, DateTime DataNas, String Email, String Contato)
        {
            con = new MySqlConnection();
            entModel = new Model.Entidade();
            conexao = new Utils.Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "INSERT INTO entidade(Nome, Registro, Data_Nascimento,Email, Contato)";
            query += " VALUES (?Nome, ?Registro, ?Data_Nascimento, ?Email, ?Contato)";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?Nome", Nome);
                cmd.Parameters.AddWithValue("?Registro", Registro);
                cmd.Parameters.AddWithValue("?Data_Nascimento", DataNas.Date);
                cmd.Parameters.AddWithValue("?Email", Email);
                cmd.Parameters.AddWithValue("?Contato", Contato);
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
        public void AtualizarDados(String Nome, String Registro, DateTime DataNas, String Email, String Contato)
        {
            con = new MySqlConnection();
            entModel = new Model.Entidade();
            conexao = new Utils.Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE Entidade SET Nome = ?Nome, Data_Nascimento = ?Data_Nascimento, Email = ?Email, Contato = ?Contato WHERE Registro = ?Registro";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?Nome", Nome);
                cmd.Parameters.AddWithValue("?Registro", Registro);
                cmd.Parameters.AddWithValue("?Data_Nascimento", DataNas.Date);
                cmd.Parameters.AddWithValue("?Email", Email);
                cmd.Parameters.AddWithValue("?Contato", Contato);
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
        public void RemoverDados(String Registro)
        {
            con = new MySqlConnection();
            conexao = new Utils.Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM Entidade where Registro = ?Registro";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?Registro", Registro);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
    }
}

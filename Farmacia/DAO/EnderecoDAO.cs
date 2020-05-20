using Farmacia.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia.DAO
{
    class EnderecoDAO
    {
        private MySqlConnection con;
        private Model.Endereco enderecomode;
        private Utils.Conexao conexao;

        public void InserirDados(String CEP, String Cidade, String Bairro, String Rua, String Numero, int ID_Entidade)
        {
            con = new MySqlConnection();
            enderecomode = new Model.Endereco();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "INSERT INTO endereco(CEP, Cidade, Bairro, Rua, Numero, ID_Entidade)";
            query += " VALUES (?CEP, ?Cidade, ?Bairro, ?Rua, ?Numero, ?ID_Entidade, ?ID_Entidade)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?CEP", CEP);
                cmd.Parameters.AddWithValue("?Cidade", Cidade);
                cmd.Parameters.AddWithValue("?Bairro", Bairro);
                cmd.Parameters.AddWithValue("?Rua", Rua);
                cmd.Parameters.AddWithValue("?Numero", Numero);
                cmd.Parameters.AddWithValue("?ID_Entidade", ID_Entidade);
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
        public void AtualizarDados(String CEP, String Cidade, String Bairro, String Rua, String Numero)
        {
            con = new MySqlConnection();
            enderecomode = new Model.Endereco();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE endereco SET Bairro = ? Bairro, Cidade = ? Cidade, Numero = ? Numero, CEP = ? CEP, Rua = ? Rua WHERE Id_Endereco = ? Id_Endereco";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?CEP", CEP);
                cmd.Parameters.AddWithValue("?Cidade", Cidade);
                cmd.Parameters.AddWithValue("?Bairro", Bairro);
                cmd.Parameters.AddWithValue("?Rua", Rua);
                cmd.Parameters.AddWithValue("?Numero", Numero);
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
        public void RemoverDados(int ID_endereco)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM endereco where ID_Endereco = ?ID_Endereco";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?ID_endereco", ID_endereco);
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

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
    class TipoProdutoDAO
    {
        private Model.TipoProduto TipoProdModel;
        private MySqlConnection con;
        private Utils.Conexao conexao;

        public void InserirDados(String Tipo_Produto)
        {
            con = new MySqlConnection();
            TipoProdModel = new Model.TipoProduto();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "INSERT INTO tipo_produto(Tipo)";
            query += "VALUES (?Tipo)";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?Tipo", Tipo_Produto);
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

        public void AtualizarDados(String Descricao, int ID)
        {
            con = new MySqlConnection();
            TipoProdModel = new Model.TipoProduto();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE Tipo_Produto SET Tipo = ?Tipo WHERE ID_Tipo = ?ID_Tipo";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?Tipo", Descricao);
                cmd.Parameters.AddWithValue("?ID_Tipo", ID);
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

        public void RemoverDados(Int32 ID_Tipo)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM tipo_produto where ID_Tipo = ?ID_Tipo";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?ID_Tipo", ID_Tipo);
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

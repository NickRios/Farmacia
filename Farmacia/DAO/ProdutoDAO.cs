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
    class ProdutoDAO
    {
        private MySqlConnection con;
        private Model.Produto prodModel;
        private Utils.Conexao conexao;


        public void InserirDados(String Nome, int CodigoBarras, String Fornecedor, Decimal PrecoCompra, Decimal PrecoVenda, int QuantidadeEstoque, DateTime DataVencimento)
        {
            con = new MySqlConnection();
            prodModel = new Model.Produto();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "INSERT INTO Produto(Nome, Codigo_Barras, Fornecedor, Preco_Compra, Preco_Venda, Quantidade_Estoque, Data_Vencimento)";

            query += " VALUES (?Nome, ?Codigo_Barras, ?Fornecedor, ?Preco_Compra, ?Preco_Venda, ?Quantidade_Estoque, ?Data_Vencimento)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?Nome", Nome);
                cmd.Parameters.AddWithValue("?Codigo_Barras", CodigoBarras);
                cmd.Parameters.AddWithValue("?Fornecedor", Fornecedor);
                cmd.Parameters.AddWithValue("?Preco_Compra", PrecoCompra);
                cmd.Parameters.AddWithValue("?Preco_Venda", PrecoVenda);
                cmd.Parameters.AddWithValue("?Quantidade_Estoque", QuantidadeEstoque);
                cmd.Parameters.AddWithValue("?Data_Vencimento", DataVencimento.Date);

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

        public void AtualizarDados(String Nome, int CodigoBarras, String Fornecedor, Decimal PrecoCompra, Decimal PrecoVenda, int QuantidadeEstoque, DateTime DataVencimento)
        {
            con = new MySqlConnection();
            prodModel = new Model.Produto();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE produto SET Nome = ?Nome, Codigo_Barras = ?Codigo_Barras, Fornecedor = ?Fornecedor, Data_Vencimento = ?Data_Vencimento, Preco_Compra = ?Preco_Compra, Preco_Venda = ?Preco_Venda, Quantidade_Estoque = ?Quantidade_Estoque WHERE Codigo_Barras = ?Codigo_Barras";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?Nome", Nome);
                cmd.Parameters.AddWithValue("?Fornecedor", Fornecedor);
                cmd.Parameters.AddWithValue("?Codigo_Barras", CodigoBarras);
                cmd.Parameters.AddWithValue("?Preco_Compra", PrecoCompra);
                cmd.Parameters.AddWithValue("?Preco_Venda", PrecoVenda);
                cmd.Parameters.AddWithValue("?Quantidade_Estoque", QuantidadeEstoque);
                cmd.Parameters.AddWithValue("?Data_Vencimento", DataVencimento.Date);
  

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

        public void RemoverDados(Int32 CodigoBarras)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM produto where Codigo_Barras = ?Codigo_Barras";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?Codigo_Barras", CodigoBarras);
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

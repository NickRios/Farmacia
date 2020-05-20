using Farmacia.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia.Model
{
    class Produto
    {
        private String nome;
        private String fornecedor;
        private int categoria;
        private decimal precocompra;
        private decimal precovenda;
        private int quantidadeestoque;
        private int codigobarras;
        private DateTime datavencimento;

        public string Nome { get => nome; set => nome = value; }
        public string Fornecedor { get => fornecedor; set => fornecedor = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public decimal Precocompra { get => precocompra; set => precocompra = value; }
        public decimal Precovenda { get => precovenda; set => precovenda = value; }
        public int Quantidadeestoque { get => quantidadeestoque; set => quantidadeestoque = value; }
        public int Codigobarras { get => codigobarras; set => codigobarras = value; }
        public DateTime Datavencimento { get => datavencimento; set => datavencimento = value; }

        private DAO.ProdutoDAO prodDao;

        public void InserirDados()
        {
            prodDao = new DAO.ProdutoDAO();
            prodDao.InserirDados(nome, codigobarras, fornecedor, precocompra, precovenda, quantidadeestoque, datavencimento);


        }

        public void Atualizar()
        {
            prodDao = new DAO.ProdutoDAO();
            prodDao.AtualizarDados(Nome, codigobarras, fornecedor, precocompra, precovenda, quantidadeestoque, datavencimento);
        }

        public void Deletar()
        {
            prodDao = new DAO.ProdutoDAO();
            prodDao.RemoverDados(codigobarras);
        }
    }
}

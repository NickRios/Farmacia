using Farmacia.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Farmacia.Model
{
    class TipoProduto
    {

        private String tipo;
        private int id_Tipo;


        public string Tipo { get => tipo; set => tipo = value; }
        public int Id_Tipo { get => id_Tipo; set => id_Tipo = value; }

        private DAO.TipoProdutoDAO tipoDAO;

        public void InserirDados()
        {
            tipoDAO = new DAO.TipoProdutoDAO();
            tipoDAO.InserirDados( tipo );

        }

        public void Atualizar()
        {
            tipoDAO = new DAO.TipoProdutoDAO();
            tipoDAO.AtualizarDados( tipo, id_Tipo );
        }

        public void Deletar()
        {
            tipoDAO = new DAO.TipoProdutoDAO();
            tipoDAO.RemoverDados( Id_Tipo );
        }
    }
}

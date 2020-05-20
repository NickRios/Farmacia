using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia.Utils;
using MySql.Data.MySqlClient;

namespace Farmacia.Model
{
    class Entidade
    {
        
        private String registro;
        private String nome;
        private String email;
        private String contato;
        private DateTime dataNasc;


        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Contato { get => contato; set => contato = value; }
        public string Registro { get => registro; set => registro = value; }
        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
        

        private DAO.EntidadeDAO EntDao;

        public void InserirDados()
        {
            EntDao = new DAO.EntidadeDAO();
            EntDao.InserirDados( Nome, Registro, DataNasc,  Email, Contato);

        }

        public void Atualizar()
        {
            EntDao = new DAO.EntidadeDAO();
            EntDao.AtualizarDados(Nome, Registro, DataNasc, Email, Contato);
        }

        public void Deletar()
        {
            EntDao = new DAO.EntidadeDAO();
            EntDao.RemoverDados(Registro);
        }

    }


}
    





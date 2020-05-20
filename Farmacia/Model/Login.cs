using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    class Login
    {
        private String usuario;
        private String senha;
        private string permissao;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Permissao { get => permissao; set => permissao = value; }


        private DAO.LoginDAO loginDAO;
       public void Cadastrar()
       {
            loginDAO = new DAO.LoginDAO();
            loginDAO.Cadastrar(Usuario, Senha);
       }
 

    }
}

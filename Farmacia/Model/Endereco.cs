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
    class Endereco
    {
        private int idEndereco;
        private String bairro;
        private String cidade;
        private String numero;
        private String cep;
        private String rua;

        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Rua { get => rua; set => rua = value; }
        public int IdEndereco { get => idEndereco; set => idEndereco = value; }

        public void InserirDados()
        {


        }

        public void Atualizar()
        {

        }

        public void DeletarCliente()
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    class Entrega
    {
        private int idEntrega;
        private string prazoEntrega;
        private double taxa;

        public int IdEntrega { get => idEntrega; set => idEntrega = value; }
        public string PrazoEntrega { get => prazoEntrega; set => prazoEntrega = value; }
        public double Taxa { get => taxa; set => taxa = value; }

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

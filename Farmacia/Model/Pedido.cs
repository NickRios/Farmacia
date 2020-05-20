using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    class Pedido
    {
        private int idPedido;
        private decimal soma;
        private string tipoEntrega;

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public decimal Soma { get => soma; set => soma = value; }
        public string TipoEntrega { get => tipoEntrega; set => tipoEntrega = value; }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    class Pagamento
    {
        private int idPagamento;
        private String tipoPagamento;
        private int quantParcelas;

        public int IdPagamento { get => idPagamento; set => idPagamento = value; }
        public string TipoPagamento { get => tipoPagamento; set => tipoPagamento = value; }
        public int QuantParcelas { get => quantParcelas; set => quantParcelas = value; }

        public void QuitarConta()
        {

        }
    }
}

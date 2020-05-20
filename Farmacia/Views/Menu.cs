using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia.Views
{
    public partial class Menu : Form
    {
        private Boolean timedrop;
        public Menu()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timedrop)
            {
                panel2.Height += 10;
                if (panel2.Size == panel2.MaximumSize)
                {
                    timer1.Stop();
                    timedrop = false;
                }
            }
            else
            {
                panel2.Height -= 10;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timer1.Stop();
                    timedrop = true;
                }
            }
        }

        private void btnCadastroMenu_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timedrop)
            {
                panel1.Height += 10;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer2.Stop();
                    timedrop = false;
                }
            }
            else
            {
                panel1.Height -= 10;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer2.Stop();
                    timedrop = true;
                }
            }
        } 
        private void btnPagamento_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (timedrop)
            {
                panel6.Height += 10;
                if (panel6.Size == panel6.MaximumSize)
                {
                    timer3.Stop();
                    timedrop = false;
                }
            }
            else
            {
                panel6.Height -= 10;
                if (panel6.Size == panel6.MinimumSize)
                {
                    timer3.Stop();
                    timedrop = true;
                }
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }  
      
      
        private void btnEntidade_Click(object sender, EventArgs e)
        {
            Cadastro_Entidade cadastro = new Cadastro_Entidade();
            cadastro.Visible = true;
            this.Visible = false;
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            Cadastro_Produto cadastro = new Cadastro_Produto();
            cadastro.Visible = true;
            this.Visible = false;
        }
 
        private void btnPedido_Click(object sender, EventArgs e)
        {
            Cadastro_Pedido cadastro = new Cadastro_Pedido();
            cadastro.Visible = true;
            this.Visible = false;
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Relatorio_Estoque relatorio = new Relatorio_Estoque();
            relatorio.Visible = true;
            this.Visible = false;
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Relatorio_Produtos relatorio = new Relatorio_Produtos();
            relatorio.Visible = true;
            this.Visible = false;
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            Relatorio_Vendas relatorio = new Relatorio_Vendas();
            relatorio.Visible = true;
            this.Visible = false;
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta_Pagamento consulta = new Consulta_Pagamento();
            consulta.Visible = true;
            this.Visible = false;
        }
        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            Carrinho carrinho = new Carrinho();
            carrinho.Visible = true;
            this.Visible = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTipoProduto_Click(object sender, EventArgs e)
        {
            Cadastro_Tipo tipo = new Cadastro_Tipo();
            tipo.Visible = true;
            this.Visible = false;
        }
    }
}

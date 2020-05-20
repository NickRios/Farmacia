using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Farmacia.Views
{
    public partial class Cadastro_Produto : Form
    {
        public Cadastro_Produto()
        {
            InitializeComponent();
            carregarDados();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Views.Menu menu = new Views.Menu();
            menu.Visible = true;
            this.Visible = false;
        }


        private Model.Produto prodModel;
        private Utils.Conexao conexao;
        private Int32 catchRowIndex;

        private void carregarDados()
        {

            conexao = new Utils.Conexao();
            CadastroTabela.DataSource = null;
            CadastroTabela.Rows.Clear();
            CadastroTabela.Refresh();

            string connectionString = conexao.getConnectionString();
            string query = "SELECT Nome, Codigo_Barras, Fornecedor, Preco_Compra, Preco_Venda, Quantidade_Estoque, Data_Vencimento from produto";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            CadastroTabela.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4], dataTable.Rows[i][5], dataTable.Rows[i][6]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }

            }

        }
        public void Limpar()
        {
            nomeTextBox.Clear();
            codigoTextBox.ResetText();
            fornecedorTextBox.Clear();
            precoCompralTextBox.Clear();
            precoVendaTextBox.Clear();
            QuantidadeEstoque.ResetText();
            dataTexteBox.Clear();


        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            prodModel = new Model.Produto();

            try
            {
                prodModel.Nome = nomeTextBox.Text;
                prodModel.Codigobarras = Convert.ToInt32(codigoTextBox.Text);
                prodModel.Fornecedor = fornecedorTextBox.Text;
                prodModel.Precocompra = Convert.ToDecimal(precoCompralTextBox.Text);
                prodModel.Precovenda = Convert.ToDecimal(precoVendaTextBox.Text);
                prodModel.Quantidadeestoque = Convert.ToInt32(QuantidadeEstoque.Value);
                prodModel.Datavencimento = Convert.ToDateTime(dataTexteBox.Text);

                prodModel.InserirDados();


                MessageBox.Show("Produto foi Cadastrado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {

            }
            carregarDados();
            Limpar();
        }

        private void CadastroTabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            catchRowIndex = CadastroTabela.SelectedCells[0].RowIndex;

            foreach (DataGridViewRow row in CadastroTabela.SelectedRows)
            {
                nomeTextBox.Text = row.Cells[0].Value.ToString();
                codigoTextBox.Text = row.Cells[1].Value.ToString();
                fornecedorTextBox.Text = row.Cells[2].Value.ToString();
                precoCompralTextBox.Text = row.Cells[3].Value.ToString();
                precoVendaTextBox.Text = row.Cells[4].Value.ToString();
                QuantidadeEstoque.Text = row.Cells[5].Value.ToString();
                dataTexteBox.Text = Convert.ToDateTime(row.Cells[6].Value.ToString()).ToString("dd/MM/yyyy");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            prodModel = new Model.Produto();

            try
            {
                prodModel.Nome = nomeTextBox.Text;
                prodModel.Codigobarras = Convert.ToInt32(codigoTextBox.Text);
                prodModel.Fornecedor = fornecedorTextBox.Text;
                prodModel.Precocompra = Convert.ToDecimal(precoCompralTextBox.Text);
                prodModel.Precovenda = Convert.ToDecimal(precoVendaTextBox.Text);
                prodModel.Quantidadeestoque = Convert.ToInt32(QuantidadeEstoque.Value);
                prodModel.Datavencimento = Convert.ToDateTime(dataTexteBox.Text);

                prodModel.Atualizar();
                carregarDados();
                Limpar();

                MessageBox.Show("Seu Produto foi atualizado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Erro ao editar este produto " + ex);
            }
            finally
            {

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir este produto: " + codigoTextBox.Text + "?", "Excluindo Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                prodModel = new Model.Produto();

                try
                {
                    prodModel.Codigobarras = Convert.ToInt32(codigoTextBox.Text);
                    prodModel.Deletar();
                    carregarDados();
                    Limpar();

                    MessageBox.Show("Produto foi removido", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao EXCLUIR o Produto!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

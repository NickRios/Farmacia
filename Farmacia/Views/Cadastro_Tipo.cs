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
using Farmacia.Utils;

namespace Farmacia.Views
{
    public partial class Cadastro_Tipo : Form
    {
        private Model.TipoProduto tipomodel;
        private Utils.Conexao conexao;
        private Int32 catchRowIndex;
        int id;

        public Cadastro_Tipo()
        {
            InitializeComponent();
            carregarDados();
        }

        private void carregarDados()
        {

            conexao = new Utils.Conexao();
            CadastroTipo.DataSource = null;
            CadastroTipo.Rows.Clear();
            CadastroTipo.Refresh();

            string connectionString = conexao.getConnectionString();
            string query = "SELECT ID_Tipo , Tipo FROM Tipo_Produto";

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
                            CadastroTipo.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1]);
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
            TipoNomeTextBox.Clear();
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tipomodel = new Model.TipoProduto();

            try
            {
                tipomodel.Tipo = TipoNomeTextBox.Text;
                

                tipomodel.InserirDados();
                Limpar();

                MessageBox.Show("Tipo de produto foi cadastrado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {

            }
            carregarDados();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tipomodel = new Model.TipoProduto();

            try
            {
                tipomodel.Tipo = TipoNomeTextBox.Text;
                tipomodel.Id_Tipo = id;
                
                tipomodel.Atualizar();
                carregarDados();
                Limpar();

                MessageBox.Show("Tipo de produto foi atualizado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Erro ao editar este tipo de produto " + ex);
            }
            finally
            {

            }
        }

        
        private void CadastroTipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            catchRowIndex = CadastroTipo.SelectedCells[0].RowIndex;

            TipoNomeTextBox.Text = CadastroTipo.Rows[e.RowIndex].Cells[1].Value.ToString();
            id = Convert.ToInt32(CadastroTipo.Rows[e.RowIndex].Cells[0].Value.ToString());

            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir este tipo de produto: " + TipoNomeTextBox.Text + "?", "Excluindo Tipo de Produto ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tipomodel = new Model.TipoProduto();

                try
                {
                   
                    tipomodel.Id_Tipo = id;
                    tipomodel.Deletar();
                    carregarDados();
                    Limpar();

                    MessageBox.Show("Tipo de Produto foi removido", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao EXCLUIR Tipo de Produto!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

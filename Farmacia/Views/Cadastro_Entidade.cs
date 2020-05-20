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
    public partial class Cadastro_Entidade : Form
    {
        private Model.Entidade entidademodel;
        private Utils.Conexao conexao;
        private Int32 catchRowIndex;

        public Cadastro_Entidade()
        {
            InitializeComponent();
            carregarDados();
        }

        private void carregarDados()
        {
            
            conexao = new Utils.Conexao();
            CadastroTabela.DataSource = null;
            CadastroTabela.Rows.Clear();
            CadastroTabela.Refresh();
           
            string connectionString = conexao.getConnectionString();
            string query = "SELECT Nome, Registro, Data_Nascimento, Email, Contato from Entidade";

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
                            CadastroTabela.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4]);
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
            cpfTextBox.Clear();
            emailTextBox.Clear();
            contatoTextBox.Clear();
            dataTextBox.Clear();
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Views.Menu menu = new Views.Menu();
            menu.Visible = true;
            this.Visible = false;
        }

        private void checkClient_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                checkForn.Enabled = false;
            }
            else
            {
                checkForn.Enabled = true;
            }
        }

        private void checkForn_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                checkClient.Enabled = false;
            }
            else
            {
                checkClient.Enabled = true;
            }

            if (((CheckBox)sender).Checked)
            {
                checkForn.Enabled = true;
                label6.Text = "CNPJ";
            }
            else
            {
                checkForn.Enabled = true;
                label6.Text = "CPF";
               
            }
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            entidademodel = new Model.Entidade();
            
            try
            {

                
                entidademodel.Nome = nomeTextBox.Text;
                entidademodel.Registro = cpfTextBox.Text;
                entidademodel.Email = emailTextBox.Text;
                entidademodel.Contato = contatoTextBox.Text;
                entidademodel.DataNasc = Convert.ToDateTime(dataTextBox.Text);

                entidademodel.InserirDados();

                MessageBox.Show("Entidade foi Cadastrada!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            
            entidademodel = new Model.Entidade();

            try
            {
                entidademodel.Nome = nomeTextBox.Text;
                entidademodel.Registro = cpfTextBox.Text;
                entidademodel.Email = emailTextBox.Text;
                entidademodel.Contato = contatoTextBox.Text;
                entidademodel.DataNasc = Convert.ToDateTime(dataTextBox.Text);

                entidademodel.Atualizar();
                carregarDados();
                Limpar();

                MessageBox.Show("Entidade foi atualizada!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Erro ao editar esta entidade " + ex);
            }
            finally
            {

            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Deseja excluir esta entidade: " + nomeTextBox.Text + "?", "Excluindo Entidade", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                entidademodel = new Model.Entidade();

                try
                {
                    entidademodel.Registro = cpfTextBox.Text;
                    entidademodel.Deletar();
                    carregarDados();
                    Limpar();

                    MessageBox.Show("Entidade foi removida", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao EXCLUIR Entidade!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void CadastroTabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            catchRowIndex = CadastroTabela.SelectedCells[0].RowIndex;

            foreach (DataGridViewRow row in CadastroTabela.SelectedRows)
            {
                nomeTextBox.Text = row.Cells[0].Value.ToString();
                cpfTextBox.Text = row.Cells[1].Value.ToString();
                emailTextBox.Text = row.Cells[3].Value.ToString();
                contatoTextBox.Text = row.Cells[4].Value.ToString();
                dataTextBox.Text = Convert.ToDateTime(row.Cells[2].Value.ToString()).ToString("dd/MM/yyyy");

            }
        }
    }
}

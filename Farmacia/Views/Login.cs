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
    public partial class Login : Form
    {
        private Model.Login loginmodel;
        private Utils.Conexao conexao;

        public Login()
        {
            InitializeComponent();
            panel2.Visible = false;
        }

        private void registrarlabel_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void btnvoltar_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void UsernameTextBox_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Clear();
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Clear();
            PasswordTextBox.PasswordChar = ('*');
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Views.Menu menu = new Views.Menu();
            menu.Visible = true;
            this.Visible = false;
        }

        public void Limpar()
        {
            
            UserTextBox.ResetText();
            SenhaTextBox.ResetText();
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            loginmodel = new Model.Login();

            try
            {
                loginmodel.Usuario = UsernameTextBox.Text;
                loginmodel.Senha = SenhaTextBox.Text;

                loginmodel.Cadastrar();

                MessageBox.Show("Cadastrado Efetuado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Não foi possível efetuar o cadastro " + ex);
            }
            finally
            {

            }
            Limpar();
        }
    }
}
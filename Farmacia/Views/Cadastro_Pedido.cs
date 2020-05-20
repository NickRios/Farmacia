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
    public partial class Cadastro_Pedido : Form
    {
        public Cadastro_Pedido()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Views.Menu menu = new Views.Menu();
            menu.Visible = true;
            this.Visible = false;
        }

        private void checkEntrega_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                checkRetirada.Enabled = false;
                
            }
            else
            {
                checkRetirada.Enabled = true;
            }
        }

        private void checkRetirada_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                checkEntrega.Enabled = false;
                Tempo.Enabled = false;
                label12.Enabled = false;
                cepTextBox.Enabled = false;
                cidadeTextBox.Enabled = false;
                ruaTextBox.Enabled = false;
                numeroTextBox.Enabled = false;
                bairroTextBox.Enabled = false;

            }
            else
            {
                checkEntrega.Enabled = true;
                Tempo.Enabled = true;
                label12.Enabled = true;
                cepTextBox.Enabled = true;
                cidadeTextBox.Enabled = true;
                ruaTextBox.Enabled = true;
                numeroTextBox.Enabled = true;
                bairroTextBox.Enabled = true;

            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Buscar_Cliente buscar = new Buscar_Cliente();
            buscar.Visible = true;
            this.Visible = false;
        }
    }
}

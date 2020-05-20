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
    public partial class Relatorio_Vendas : Form
    {
        public Relatorio_Vendas()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Views.Menu menu = new Views.Menu();
            menu.Visible = true;
            this.Visible = false;
        }
    }
}

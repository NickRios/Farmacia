﻿using System;
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
    public partial class Buscar_Cliente : Form
    {
        public Buscar_Cliente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Cadastro_Pedido cadastro = new Cadastro_Pedido();
            cadastro.Visible = true;
            this.Visible = false;
        }

        
    }
}

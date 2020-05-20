namespace Farmacia.Views
{
    partial class Cadastro_Produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Produto));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CadastroTabela = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreçoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreçoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.precoVendaTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.fornecedorTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.precoCompralTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.codigoTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nomeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataTexteBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QuantidadeEstoque = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CadastroTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantidadeEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(623, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 127);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 41);
            this.label1.TabIndex = 49;
            this.label1.Text = "Produto";
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(56, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(38, 37);
            this.btnVoltar.TabIndex = 50;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 51;
            this.label11.Text = "Voltar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 499);
            this.panel1.TabIndex = 52;
            // 
            // CadastroTabela
            // 
            this.CadastroTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CadastroTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Codigo_Barras,
            this.Fornecedor,
            this.PreçoCompra,
            this.PreçoVenda,
            this.Quantidade,
            this.DataVencimento});
            this.CadastroTabela.Location = new System.Drawing.Point(446, 199);
            this.CadastroTabela.Name = "CadastroTabela";
            this.CadastroTabela.Size = new System.Drawing.Size(341, 288);
            this.CadastroTabela.TabIndex = 53;
            this.CadastroTabela.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CadastroTabela_CellClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Codigo_Barras
            // 
            this.Codigo_Barras.HeaderText = "Código de Barras";
            this.Codigo_Barras.Name = "Codigo_Barras";
            // 
            // Fornecedor
            // 
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            // 
            // PreçoCompra
            // 
            this.PreçoCompra.HeaderText = "Preço de Compra";
            this.PreçoCompra.Name = "PreçoCompra";
            // 
            // PreçoVenda
            // 
            this.PreçoVenda.HeaderText = "Preço de venda";
            this.PreçoVenda.Name = "PreçoVenda";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // DataVencimento
            // 
            this.DataVencimento.HeaderText = "Data de Vencimento";
            this.DataVencimento.Name = "DataVencimento";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(402, 362);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(38, 37);
            this.btnSalvar.TabIndex = 54;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(402, 405);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(38, 37);
            this.btnEditar.TabIndex = 55;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(402, 450);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(38, 37);
            this.btnExcluir.TabIndex = 56;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // precoVendaTextBox
            // 
            this.precoVendaTextBox.BorderRadius = 5;
            this.precoVendaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.precoVendaTextBox.DefaultText = "";
            this.precoVendaTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.precoVendaTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.precoVendaTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.precoVendaTextBox.DisabledState.Parent = this.precoVendaTextBox;
            this.precoVendaTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.precoVendaTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.precoVendaTextBox.FocusedState.Parent = this.precoVendaTextBox;
            this.precoVendaTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoVendaTextBox.ForeColor = System.Drawing.Color.Black;
            this.precoVendaTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.precoVendaTextBox.HoverState.Parent = this.precoVendaTextBox;
            this.precoVendaTextBox.Location = new System.Drawing.Point(246, 312);
            this.precoVendaTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.precoVendaTextBox.Name = "precoVendaTextBox";
            this.precoVendaTextBox.PasswordChar = '\0';
            this.precoVendaTextBox.PlaceholderText = "";
            this.precoVendaTextBox.SelectedText = "";
            this.precoVendaTextBox.ShadowDecoration.Parent = this.precoVendaTextBox;
            this.precoVendaTextBox.Size = new System.Drawing.Size(140, 32);
            this.precoVendaTextBox.TabIndex = 66;
            // 
            // fornecedorTextBox
            // 
            this.fornecedorTextBox.BorderRadius = 5;
            this.fornecedorTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fornecedorTextBox.DefaultText = "";
            this.fornecedorTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fornecedorTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fornecedorTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fornecedorTextBox.DisabledState.Parent = this.fornecedorTextBox;
            this.fornecedorTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fornecedorTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fornecedorTextBox.FocusedState.Parent = this.fornecedorTextBox;
            this.fornecedorTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fornecedorTextBox.ForeColor = System.Drawing.Color.Black;
            this.fornecedorTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fornecedorTextBox.HoverState.Parent = this.fornecedorTextBox;
            this.fornecedorTextBox.Location = new System.Drawing.Point(45, 225);
            this.fornecedorTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fornecedorTextBox.Name = "fornecedorTextBox";
            this.fornecedorTextBox.PasswordChar = '\0';
            this.fornecedorTextBox.PlaceholderText = "";
            this.fornecedorTextBox.SelectedText = "";
            this.fornecedorTextBox.ShadowDecoration.Parent = this.fornecedorTextBox;
            this.fornecedorTextBox.Size = new System.Drawing.Size(173, 32);
            this.fornecedorTextBox.TabIndex = 65;
            // 
            // precoCompralTextBox
            // 
            this.precoCompralTextBox.BorderRadius = 5;
            this.precoCompralTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.precoCompralTextBox.DefaultText = "";
            this.precoCompralTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.precoCompralTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.precoCompralTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.precoCompralTextBox.DisabledState.Parent = this.precoCompralTextBox;
            this.precoCompralTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.precoCompralTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.precoCompralTextBox.FocusedState.Parent = this.precoCompralTextBox;
            this.precoCompralTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoCompralTextBox.ForeColor = System.Drawing.Color.Black;
            this.precoCompralTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.precoCompralTextBox.HoverState.Parent = this.precoCompralTextBox;
            this.precoCompralTextBox.Location = new System.Drawing.Point(45, 312);
            this.precoCompralTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.precoCompralTextBox.Name = "precoCompralTextBox";
            this.precoCompralTextBox.PasswordChar = '\0';
            this.precoCompralTextBox.PlaceholderText = "";
            this.precoCompralTextBox.SelectedText = "";
            this.precoCompralTextBox.ShadowDecoration.Parent = this.precoCompralTextBox;
            this.precoCompralTextBox.Size = new System.Drawing.Size(140, 32);
            this.precoCompralTextBox.TabIndex = 64;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.BorderRadius = 5;
            this.codigoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codigoTextBox.DefaultText = "";
            this.codigoTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.codigoTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.codigoTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codigoTextBox.DisabledState.Parent = this.codigoTextBox;
            this.codigoTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codigoTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codigoTextBox.FocusedState.Parent = this.codigoTextBox;
            this.codigoTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoTextBox.ForeColor = System.Drawing.Color.Black;
            this.codigoTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codigoTextBox.HoverState.Parent = this.codigoTextBox;
            this.codigoTextBox.Location = new System.Drawing.Point(227, 143);
            this.codigoTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.PasswordChar = '\0';
            this.codigoTextBox.PlaceholderText = "";
            this.codigoTextBox.SelectedText = "";
            this.codigoTextBox.ShadowDecoration.Parent = this.codigoTextBox;
            this.codigoTextBox.Size = new System.Drawing.Size(242, 32);
            this.codigoTextBox.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(242, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 21);
            this.label9.TabIndex = 62;
            this.label9.Text = "Preço da Venda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 21);
            this.label8.TabIndex = 61;
            this.label8.Text = "Fornecedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(223, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 21);
            this.label6.TabIndex = 60;
            this.label6.Text = "Código de Barras";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BorderRadius = 5;
            this.nomeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nomeTextBox.DefaultText = "";
            this.nomeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nomeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nomeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nomeTextBox.DisabledState.Parent = this.nomeTextBox;
            this.nomeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nomeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nomeTextBox.FocusedState.Parent = this.nomeTextBox;
            this.nomeTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.ForeColor = System.Drawing.Color.Black;
            this.nomeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nomeTextBox.HoverState.Parent = this.nomeTextBox;
            this.nomeTextBox.Location = new System.Drawing.Point(45, 143);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.PasswordChar = '\0';
            this.nomeTextBox.PlaceholderText = "";
            this.nomeTextBox.SelectedText = "";
            this.nomeTextBox.ShadowDecoration.Parent = this.nomeTextBox;
            this.nomeTextBox.Size = new System.Drawing.Size(152, 32);
            this.nomeTextBox.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 21);
            this.label5.TabIndex = 58;
            this.label5.Text = "Preço da Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 57;
            this.label4.Text = "Nome";
            // 
            // dataTexteBox
            // 
            this.dataTexteBox.BorderRadius = 5;
            this.dataTexteBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataTexteBox.DefaultText = "";
            this.dataTexteBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dataTexteBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dataTexteBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dataTexteBox.DisabledState.Parent = this.dataTexteBox;
            this.dataTexteBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dataTexteBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dataTexteBox.FocusedState.Parent = this.dataTexteBox;
            this.dataTexteBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTexteBox.ForeColor = System.Drawing.Color.Black;
            this.dataTexteBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dataTexteBox.HoverState.Parent = this.dataTexteBox;
            this.dataTexteBox.Location = new System.Drawing.Point(246, 225);
            this.dataTexteBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataTexteBox.Name = "dataTexteBox";
            this.dataTexteBox.PasswordChar = '\0';
            this.dataTexteBox.PlaceholderText = "";
            this.dataTexteBox.SelectedText = "";
            this.dataTexteBox.ShadowDecoration.Parent = this.dataTexteBox;
            this.dataTexteBox.Size = new System.Drawing.Size(140, 32);
            this.dataTexteBox.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 21);
            this.label2.TabIndex = 67;
            this.label2.Text = "Data de Vencimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 69;
            this.label3.Text = "Quantidade";
            // 
            // QuantidadeEstoque
            // 
            this.QuantidadeEstoque.BackColor = System.Drawing.Color.Transparent;
            this.QuantidadeEstoque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantidadeEstoque.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QuantidadeEstoque.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QuantidadeEstoque.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantidadeEstoque.DisabledState.Parent = this.QuantidadeEstoque;
            this.QuantidadeEstoque.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.QuantidadeEstoque.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.QuantidadeEstoque.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantidadeEstoque.FocusedState.Parent = this.QuantidadeEstoque;
            this.QuantidadeEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantidadeEstoque.ForeColor = System.Drawing.Color.Black;
            this.QuantidadeEstoque.Location = new System.Drawing.Point(271, 393);
            this.QuantidadeEstoque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuantidadeEstoque.Name = "QuantidadeEstoque";
            this.QuantidadeEstoque.ShadowDecoration.Parent = this.QuantidadeEstoque;
            this.QuantidadeEstoque.Size = new System.Drawing.Size(61, 29);
            this.QuantidadeEstoque.TabIndex = 71;
            this.QuantidadeEstoque.UpDownButtonFillColor = System.Drawing.Color.Crimson;
            this.QuantidadeEstoque.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(45, 392);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(127, 36);
            this.guna2ComboBox1.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 21);
            this.label7.TabIndex = 73;
            this.label7.Text = "Tipo de Produto";
            // 
            // Cadastro_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 499);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.QuantidadeEstoque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataTexteBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.precoVendaTextBox);
            this.Controls.Add(this.fornecedorTextBox);
            this.Controls.Add(this.precoCompralTextBox);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.CadastroTabela);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro_Produto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CadastroTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantidadeEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView CadastroTabela;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private Guna.UI2.WinForms.Guna2TextBox precoVendaTextBox;
        private Guna.UI2.WinForms.Guna2TextBox fornecedorTextBox;
        private Guna.UI2.WinForms.Guna2TextBox precoCompralTextBox;
        private Guna.UI2.WinForms.Guna2TextBox codigoTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox nomeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox dataTexteBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown QuantidadeEstoque;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreçoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreçoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVencimento;
    }
}
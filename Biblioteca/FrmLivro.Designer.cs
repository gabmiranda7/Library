namespace Biblioteca
{
    partial class FrmLivro
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
            GrdItens = new DataGridView();
            CmbEditora = new ComboBox();
            CmbGenero = new ComboBox();
            CmbIdioma = new ComboBox();
            TxtNome = new TextBox();
            LblNome = new Label();
            TxtCodigo = new TextBox();
            LblCodigo = new Label();
            BtnFechar = new Button();
            BtnSalvar = new Button();
            TxtISBN = new TextBox();
            LbISBN = new Label();
            LblEdicao = new Label();
            TxtQtdPaginas = new TextBox();
            LblQtdPaginas = new Label();
            TxtEdicao = new TextBox();
            LblDescricao = new Label();
            LblEditora = new Label();
            LblGenero = new Label();
            LblIdioma = new Label();
            TxtDescricao = new RichTextBox();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            IdEditora = new DataGridViewTextBoxColumn();
            IdGenero = new DataGridViewTextBoxColumn();
            IdIdioma = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GrdItens
            // 
            GrdItens.AllowUserToAddRows = false;
            GrdItens.AllowUserToDeleteRows = false;
            GrdItens.BackgroundColor = SystemColors.ButtonHighlight;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, Descricao, IdEditora, IdGenero, IdIdioma, BtnAlterar, BtnExcluir });
            GrdItens.Dock = DockStyle.Bottom;
            GrdItens.Location = new Point(0, 166);
            GrdItens.Margin = new Padding(3, 2, 3, 2);
            GrdItens.Name = "GrdItens";
            GrdItens.RowHeadersVisible = false;
            GrdItens.RowHeadersWidth = 51;
            GrdItens.Size = new Size(1072, 287);
            GrdItens.TabIndex = 8;
            GrdItens.CellClick += GrdItens_CellClick;
            // 
            // CmbEditora
            // 
            CmbEditora.FormattingEnabled = true;
            CmbEditora.Location = new Point(385, 81);
            CmbEditora.Margin = new Padding(3, 2, 3, 2);
            CmbEditora.Name = "CmbEditora";
            CmbEditora.Size = new Size(133, 23);
            CmbEditora.TabIndex = 9;
            // 
            // CmbGenero
            // 
            CmbGenero.FormattingEnabled = true;
            CmbGenero.Location = new Point(524, 81);
            CmbGenero.Margin = new Padding(3, 2, 3, 2);
            CmbGenero.Name = "CmbGenero";
            CmbGenero.Size = new Size(133, 23);
            CmbGenero.TabIndex = 10;
            // 
            // CmbIdioma
            // 
            CmbIdioma.FormattingEnabled = true;
            CmbIdioma.Location = new Point(663, 81);
            CmbIdioma.Margin = new Padding(3, 2, 3, 2);
            CmbIdioma.Name = "CmbIdioma";
            CmbIdioma.Size = new Size(133, 23);
            CmbIdioma.TabIndex = 11;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(66, 30);
            TxtNome.Margin = new Padding(3, 2, 3, 2);
            TxtNome.MaxLength = 50;
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(250, 23);
            TxtNome.TabIndex = 12;
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNome.Location = new Point(66, 13);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(41, 15);
            LblNome.TabIndex = 13;
            LblNome.Text = "Nome";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Enabled = false;
            TxtCodigo.Location = new Point(10, 30);
            TxtCodigo.Margin = new Padding(3, 2, 3, 2);
            TxtCodigo.MaxLength = 4;
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(44, 23);
            TxtCodigo.TabIndex = 14;
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCodigo.Location = new Point(10, 13);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(45, 15);
            LblCodigo.TabIndex = 15;
            LblCodigo.Text = "Código";
            // 
            // BtnFechar
            // 
            BtnFechar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFechar.Location = new Point(73, 135);
            BtnFechar.Margin = new Padding(3, 2, 3, 2);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(57, 27);
            BtnFechar.TabIndex = 17;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalvar.Location = new Point(10, 135);
            BtnSalvar.Margin = new Padding(3, 2, 3, 2);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(57, 27);
            BtnSalvar.TabIndex = 16;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // TxtISBN
            // 
            TxtISBN.Location = new Point(329, 30);
            TxtISBN.Margin = new Padding(3, 2, 3, 2);
            TxtISBN.MaxLength = 20;
            TxtISBN.Name = "TxtISBN";
            TxtISBN.Size = new Size(44, 23);
            TxtISBN.TabIndex = 18;
            // 
            // LbISBN
            // 
            LbISBN.AutoSize = true;
            LbISBN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbISBN.Location = new Point(329, 13);
            LbISBN.Name = "LbISBN";
            LbISBN.Size = new Size(35, 15);
            LbISBN.TabIndex = 20;
            LbISBN.Text = "ISBN";
            // 
            // LblEdicao
            // 
            LblEdicao.AutoSize = true;
            LblEdicao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblEdicao.Location = new Point(377, 13);
            LblEdicao.Name = "LblEdicao";
            LblEdicao.Size = new Size(42, 15);
            LblEdicao.TabIndex = 21;
            LblEdicao.Text = "Edição";
            // 
            // TxtQtdPaginas
            // 
            TxtQtdPaginas.Location = new Point(455, 30);
            TxtQtdPaginas.Margin = new Padding(3, 2, 3, 2);
            TxtQtdPaginas.MaxLength = 50;
            TxtQtdPaginas.Name = "TxtQtdPaginas";
            TxtQtdPaginas.Size = new Size(44, 23);
            TxtQtdPaginas.TabIndex = 22;
            // 
            // LblQtdPaginas
            // 
            LblQtdPaginas.AutoSize = true;
            LblQtdPaginas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblQtdPaginas.Location = new Point(455, 13);
            LblQtdPaginas.Name = "LblQtdPaginas";
            LblQtdPaginas.Size = new Size(48, 15);
            LblQtdPaginas.TabIndex = 23;
            LblQtdPaginas.Text = "Páginas";
            // 
            // TxtEdicao
            // 
            TxtEdicao.Location = new Point(379, 30);
            TxtEdicao.Margin = new Padding(3, 2, 3, 2);
            TxtEdicao.MaxLength = 50;
            TxtEdicao.Name = "TxtEdicao";
            TxtEdicao.Size = new Size(70, 23);
            TxtEdicao.TabIndex = 24;
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDescricao.Location = new Point(10, 64);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(61, 15);
            LblDescricao.TabIndex = 26;
            LblDescricao.Text = "Descrição";
            // 
            // LblEditora
            // 
            LblEditora.AutoSize = true;
            LblEditora.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblEditora.Location = new Point(385, 64);
            LblEditora.Name = "LblEditora";
            LblEditora.Size = new Size(46, 15);
            LblEditora.TabIndex = 27;
            LblEditora.Text = "Editora";
            // 
            // LblGenero
            // 
            LblGenero.AutoSize = true;
            LblGenero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblGenero.Location = new Point(524, 64);
            LblGenero.Name = "LblGenero";
            LblGenero.Size = new Size(49, 15);
            LblGenero.TabIndex = 28;
            LblGenero.Text = "Gênero";
            // 
            // LblIdioma
            // 
            LblIdioma.AutoSize = true;
            LblIdioma.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblIdioma.Location = new Point(663, 64);
            LblIdioma.Name = "LblIdioma";
            LblIdioma.Size = new Size(45, 15);
            LblIdioma.TabIndex = 29;
            LblIdioma.Text = "Idioma";
            // 
            // TxtDescricao
            // 
            TxtDescricao.Location = new Point(10, 81);
            TxtDescricao.Margin = new Padding(3, 2, 3, 2);
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(369, 50);
            TxtDescricao.TabIndex = 30;
            TxtDescricao.Text = "";
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Id";
            Codigo.HeaderText = "ID";
            Codigo.MaxInputLength = 4;
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Width = 40;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MaxInputLength = 50;
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 180;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Descricao";
            Descricao.MaxInputLength = 50;
            Descricao.MinimumWidth = 6;
            Descricao.Name = "Descricao";
            Descricao.Width = 500;
            // 
            // IdEditora
            // 
            IdEditora.DataPropertyName = "idEditora";
            IdEditora.HeaderText = "Editora";
            IdEditora.MaxInputLength = 4;
            IdEditora.MinimumWidth = 6;
            IdEditora.Name = "IdEditora";
            IdEditora.Width = 70;
            // 
            // IdGenero
            // 
            IdGenero.DataPropertyName = "idGenero";
            IdGenero.HeaderText = "Genero";
            IdGenero.MaxInputLength = 4;
            IdGenero.MinimumWidth = 6;
            IdGenero.Name = "IdGenero";
            IdGenero.Width = 70;
            // 
            // IdIdioma
            // 
            IdIdioma.DataPropertyName = "idIdioma";
            IdIdioma.HeaderText = "Idioma";
            IdIdioma.MaxInputLength = 4;
            IdIdioma.MinimumWidth = 6;
            IdIdioma.Name = "IdIdioma";
            IdIdioma.Width = 70;
            // 
            // BtnAlterar
            // 
            BtnAlterar.HeaderText = "Alterar";
            BtnAlterar.MinimumWidth = 6;
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Width = 70;
            // 
            // BtnExcluir
            // 
            BtnExcluir.HeaderText = "Excluir";
            BtnExcluir.MinimumWidth = 6;
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Width = 70;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources._3462525_200;
            pictureBox1.Location = new Point(970, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // FrmLivro
            // 
            AcceptButton = BtnSalvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            CancelButton = BtnFechar;
            ClientSize = new Size(1072, 453);
            Controls.Add(pictureBox1);
            Controls.Add(TxtDescricao);
            Controls.Add(LblIdioma);
            Controls.Add(LblGenero);
            Controls.Add(LblEditora);
            Controls.Add(LblDescricao);
            Controls.Add(TxtEdicao);
            Controls.Add(LblQtdPaginas);
            Controls.Add(TxtQtdPaginas);
            Controls.Add(LblEdicao);
            Controls.Add(LbISBN);
            Controls.Add(TxtISBN);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(LblCodigo);
            Controls.Add(TxtCodigo);
            Controls.Add(LblNome);
            Controls.Add(TxtNome);
            Controls.Add(CmbIdioma);
            Controls.Add(CmbGenero);
            Controls.Add(CmbEditora);
            Controls.Add(GrdItens);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLivro";
            Text = "Biblioteca - Cadastro de Livros";
            Activated += FrmLivro_Activated;
            FormClosed += FrmLivro_FormClosed;
            Load += FrmLivro_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView GrdItens;
        private ComboBox CmbEditora;
        private ComboBox CmbGenero;
        private ComboBox CmbIdioma;
        private TextBox TxtNome;
        private Label LblNome;
        private TextBox TxtCodigo;
        private Label LblCodigo;
        private Button BtnFechar;
        private Button BtnSalvar;
        private TextBox TxtISBN;
        private Label LbISBN;
        private Label LblEdicao;
        private TextBox TxtQtdPaginas;
        private Label LblQtdPaginas;
        private TextBox TxtEdicao;
        private Label LblDescricao;
        private Label LblEditora;
        private Label LblGenero;
        private Label LblIdioma;
        private RichTextBox TxtDescricao;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn IdEditora;
        private DataGridViewTextBoxColumn IdGenero;
        private DataGridViewTextBoxColumn IdIdioma;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
        private PictureBox pictureBox1;
    }
}
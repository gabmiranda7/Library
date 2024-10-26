namespace Biblioteca
{
    partial class FrmIdioma
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
            BtnSalvar = new Button();
            BtnFechar = new Button();
            TxtNome = new TextBox();
            TxtCodigo = new TextBox();
            LblCodigo = new Label();
            LblNome = new Label();
            pictureBox1 = new PictureBox();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
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
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, BtnAlterar, BtnExcluir });
            GrdItens.Dock = DockStyle.Bottom;
            GrdItens.Location = new Point(0, 107);
            GrdItens.Margin = new Padding(3, 2, 3, 2);
            GrdItens.Name = "GrdItens";
            GrdItens.RowHeadersVisible = false;
            GrdItens.RowHeadersWidth = 51;
            GrdItens.Size = new Size(613, 231);
            GrdItens.TabIndex = 7;
            GrdItens.CellClick += GrdItens_CellClick;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalvar.Location = new Point(6, 75);
            BtnSalvar.Margin = new Padding(3, 2, 3, 2);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(57, 27);
            BtnSalvar.TabIndex = 8;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFechar.Location = new Point(68, 75);
            BtnFechar.Margin = new Padding(3, 2, 3, 2);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(57, 27);
            BtnFechar.TabIndex = 9;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(60, 29);
            TxtNome.Margin = new Padding(3, 2, 3, 2);
            TxtNome.MaxLength = 50;
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(409, 23);
            TxtNome.TabIndex = 10;
            // 
            // TxtCodigo
            // 
            TxtCodigo.Enabled = false;
            TxtCodigo.Location = new Point(10, 29);
            TxtCodigo.Margin = new Padding(3, 2, 3, 2);
            TxtCodigo.MaxLength = 4;
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(44, 23);
            TxtCodigo.TabIndex = 11;
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCodigo.Location = new Point(10, 11);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(45, 15);
            LblCodigo.TabIndex = 12;
            LblCodigo.Text = "Código";
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNome.Location = new Point(60, 11);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(41, 15);
            LblNome.TabIndex = 13;
            LblNome.Text = "Nome";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources._3462525_200;
            pictureBox1.Location = new Point(515, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Id";
            Codigo.HeaderText = "ID";
            Codigo.MaxInputLength = 4;
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Width = 50;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MaxInputLength = 50;
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 380;
            // 
            // BtnAlterar
            // 
            BtnAlterar.HeaderText = "Alterar";
            BtnAlterar.MinimumWidth = 6;
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Width = 90;
            // 
            // BtnExcluir
            // 
            BtnExcluir.HeaderText = "Excluir";
            BtnExcluir.MinimumWidth = 6;
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Width = 90;
            // 
            // FrmIdioma
            // 
            AcceptButton = BtnSalvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            CancelButton = BtnFechar;
            ClientSize = new Size(613, 338);
            Controls.Add(pictureBox1);
            Controls.Add(LblNome);
            Controls.Add(LblCodigo);
            Controls.Add(TxtCodigo);
            Controls.Add(TxtNome);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(GrdItens);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmIdioma";
            Text = "Biblioteca - Cadastro de Idiomas";
            Activated += FrmGenero_Activated;
            FormClosed += FrmIdioma_FormClosed;
            Load += FrmIdioma_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GrdItens;
        private Button BtnSalvar;
        private Button BtnFechar;
        private TextBox TxtNome;
        private TextBox TxtCodigo;
        private Label LblCodigo;
        private Label LblNome;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
    }
}
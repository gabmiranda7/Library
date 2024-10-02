namespace Biblioteca
{
    partial class FrmUsuario
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
            LblCodigo = new Label();
            LblNome = new Label();
            TxtCodigo = new TextBox();
            TxtNome = new TextBox();
            BtnSalvar = new Button();
            BtnFechar = new Button();
            GrdItens = new DataGridView();
            pictureBox1 = new PictureBox();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCodigo.Location = new Point(10, 17);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(45, 15);
            LblCodigo.TabIndex = 1;
            LblCodigo.Text = "Código";
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNome.Location = new Point(66, 17);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(41, 15);
            LblNome.TabIndex = 2;
            LblNome.Text = "Nome";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Enabled = false;
            TxtCodigo.Location = new Point(10, 34);
            TxtCodigo.Margin = new Padding(3, 2, 3, 2);
            TxtCodigo.MaxLength = 4;
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(44, 23);
            TxtCodigo.TabIndex = 3;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(66, 34);
            TxtNome.Margin = new Padding(3, 2, 3, 2);
            TxtNome.MaxLength = 50;
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(409, 23);
            TxtNome.TabIndex = 4;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalvar.Location = new Point(10, 80);
            BtnSalvar.Margin = new Padding(3, 2, 3, 2);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(57, 27);
            BtnSalvar.TabIndex = 5;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFechar.Location = new Point(73, 80);
            BtnFechar.Margin = new Padding(3, 2, 3, 2);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(57, 27);
            BtnFechar.TabIndex = 6;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // GrdItens
            // 
            GrdItens.AllowUserToAddRows = false;
            GrdItens.AllowUserToDeleteRows = false;
            GrdItens.BackgroundColor = SystemColors.ButtonHighlight;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, BtnAlterar, BtnExcluir });
            GrdItens.Dock = DockStyle.Bottom;
            GrdItens.Location = new Point(0, 111);
            GrdItens.Margin = new Padding(3, 2, 3, 2);
            GrdItens.Name = "GrdItens";
            GrdItens.RowHeadersVisible = false;
            GrdItens.RowHeadersWidth = 51;
            GrdItens.Size = new Size(611, 270);
            GrdItens.TabIndex = 7;
            GrdItens.CellClick += GrdItens_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources._3462525_200;
            pictureBox1.Location = new Point(513, 5);
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
            Codigo.Width = 70;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MaxInputLength = 50;
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 360;
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
            // FrmUsuario
            // 
            AcceptButton = BtnSalvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            CancelButton = BtnFechar;
            ClientSize = new Size(611, 381);
            Controls.Add(pictureBox1);
            Controls.Add(GrdItens);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(TxtNome);
            Controls.Add(TxtCodigo);
            Controls.Add(LblNome);
            Controls.Add(LblCodigo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmUsuario";
            Text = "Biblioteca - Cadastro de Usuários";
            Activated += FrmUsuario_Activated;
            FormClosed += FrmUsuario_FormClosed;
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblCodigo;
        private Label LblNome;
        private TextBox TxtCodigo;
        private TextBox TxtNome;
        private Button BtnSalvar;
        private Button BtnFechar;
        private DataGridView GrdItens;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
        private PictureBox pictureBox1;
    }
}
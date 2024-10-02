namespace Biblioteca
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            MnuAutor = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            MnuEditora = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            MnuIdioma = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            MnuGenero = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            MnuLivro = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            MnuUsuario = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripSeparator();
            MnuSair = new ToolStripMenuItem();
            MnuSuspenso = new ContextMenuStrip(components);
            MnuSAutor = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripSeparator();
            MnuSEditora = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripSeparator();
            MnuSIdioma = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripSeparator();
            MnuSGenero = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripSeparator();
            MnuSLivro = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripSeparator();
            MnuSUsuario = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            LblDisplay = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            MnuSuspenso.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Window;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuAutor, toolStripMenuItem1, MnuEditora, toolStripMenuItem2, MnuIdioma, toolStripMenuItem3, MnuGenero, toolStripMenuItem4, MnuLivro, toolStripMenuItem5, MnuUsuario, toolStripMenuItem6, MnuSair });
            cadastrosToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(89, 24);
            cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // MnuAutor
            // 
            MnuAutor.Name = "MnuAutor";
            MnuAutor.Size = new Size(145, 26);
            MnuAutor.Text = "Autor";
            MnuAutor.Click += MnuAutor_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(142, 6);
            // 
            // MnuEditora
            // 
            MnuEditora.Name = "MnuEditora";
            MnuEditora.Size = new Size(145, 26);
            MnuEditora.Text = "Editora";
            MnuEditora.Click += MnuEditora_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(142, 6);
            // 
            // MnuIdioma
            // 
            MnuIdioma.Name = "MnuIdioma";
            MnuIdioma.Size = new Size(145, 26);
            MnuIdioma.Text = "Idioma";
            MnuIdioma.Click += MnuIdioma_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(142, 6);
            // 
            // MnuGenero
            // 
            MnuGenero.Name = "MnuGenero";
            MnuGenero.Size = new Size(145, 26);
            MnuGenero.Text = "Gênero";
            MnuGenero.Click += MnuGenero_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(142, 6);
            // 
            // MnuLivro
            // 
            MnuLivro.Name = "MnuLivro";
            MnuLivro.Size = new Size(145, 26);
            MnuLivro.Text = "Livros";
            MnuLivro.Click += MnuLivro_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(142, 6);
            // 
            // MnuUsuario
            // 
            MnuUsuario.Name = "MnuUsuario";
            MnuUsuario.Size = new Size(145, 26);
            MnuUsuario.Text = "Usuário";
            MnuUsuario.Click += MnuUsuario_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(142, 6);
            // 
            // MnuSair
            // 
            MnuSair.Name = "MnuSair";
            MnuSair.Size = new Size(145, 26);
            MnuSair.Text = "Sair";
            MnuSair.Click += MnuSair_Click;
            // 
            // MnuSuspenso
            // 
            MnuSuspenso.ImageScalingSize = new Size(20, 20);
            MnuSuspenso.Items.AddRange(new ToolStripItem[] { MnuSAutor, toolStripMenuItem7, MnuSEditora, toolStripMenuItem8, MnuSIdioma, toolStripMenuItem9, MnuSGenero, toolStripMenuItem10, MnuSLivro, toolStripMenuItem11, MnuSUsuario });
            MnuSuspenso.Name = "MnuSuspenso";
            MnuSuspenso.Size = new Size(129, 178);
            // 
            // MnuSAutor
            // 
            MnuSAutor.Name = "MnuSAutor";
            MnuSAutor.Size = new Size(128, 24);
            MnuSAutor.Text = "Autor";
            MnuSAutor.Click += MnuSAutor_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(125, 6);
            // 
            // MnuSEditora
            // 
            MnuSEditora.Name = "MnuSEditora";
            MnuSEditora.Size = new Size(128, 24);
            MnuSEditora.Text = "Editora";
            MnuSEditora.Click += MnuSEditora_Click;
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(125, 6);
            // 
            // MnuSIdioma
            // 
            MnuSIdioma.Name = "MnuSIdioma";
            MnuSIdioma.Size = new Size(128, 24);
            MnuSIdioma.Text = "Idioma";
            MnuSIdioma.Click += MnuSIdioma_Click;
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(125, 6);
            // 
            // MnuSGenero
            // 
            MnuSGenero.Name = "MnuSGenero";
            MnuSGenero.Size = new Size(128, 24);
            MnuSGenero.Text = "Gênero";
            MnuSGenero.Click += MnuSGenero_Click;
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(125, 6);
            // 
            // MnuSLivro
            // 
            MnuSLivro.Name = "MnuSLivro";
            MnuSLivro.Size = new Size(128, 24);
            MnuSLivro.Text = "Livro";
            MnuSLivro.Click += MnuSLivro_Click;
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(125, 6);
            // 
            // MnuSUsuario
            // 
            MnuSUsuario.Name = "MnuSUsuario";
            MnuSUsuario.Size = new Size(128, 24);
            MnuSUsuario.Text = "Usuário";
            MnuSUsuario.Click += MnuSUsuario_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.Window;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblDisplay });
            statusStrip1.Location = new Point(0, 427);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 24);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblDisplay
            // 
            LblDisplay.AutoSize = false;
            LblDisplay.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            LblDisplay.Name = "LblDisplay";
            LblDisplay.Size = new Size(300, 18);
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 451);
            ContextMenuStrip = MnuSuspenso;
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "Biblioteca - Menu Principal";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            MnuSuspenso.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem MnuSair;
        private ToolStripSeparator toolStripMenuItem7;
        private ToolStripSeparator toolStripMenuItem8;
        private ToolStripSeparator toolStripMenuItem9;
        private ToolStripSeparator toolStripMenuItem10;
        private ToolStripSeparator toolStripMenuItem11;
        public MenuStrip menuStrip1;
        public ContextMenuStrip MnuSuspenso;
        public ToolStripMenuItem MnuGenero;
        public ToolStripMenuItem MnuAutor;
        public ToolStripMenuItem MnuEditora;
        public ToolStripMenuItem MnuIdioma;
        public ToolStripMenuItem MnuLivro;
        public ToolStripMenuItem MnuUsuario;
        public ToolStripMenuItem MnuSAutor;
        public ToolStripMenuItem MnuSEditora;
        public ToolStripMenuItem MnuSIdioma;
        public ToolStripMenuItem MnuSGenero;
        public ToolStripMenuItem MnuSLivro;
        public ToolStripMenuItem MnuSUsuario;
        private StatusStrip statusStrip1;
        public ToolStripStatusLabel LblDisplay;
    }
}

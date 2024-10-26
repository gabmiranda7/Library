namespace Biblioteca
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void MnuAutor_Click(object sender, EventArgs e)
        {
            FrmAutor oFrm = new FrmAutor();
            oFrm.MdiParent = this;
            MnuAutor.Enabled = false;
            MnuSAutor.Enabled = false;
            oFrm.Show();
        }

        private void MnuSAutor_Click(object sender, EventArgs e)
        {
            MnuAutor_Click(sender, e);
        }

        private void MnuEditora_Click(object sender, EventArgs e)
        {
            FrmEditora oFrm = new FrmEditora();
            oFrm.MdiParent = this;
            MnuEditora.Enabled = false;
            MnuSEditora.Enabled = false;
            oFrm.Show();
        }

        private void MnuSEditora_Click(object sender, EventArgs e)
        {
            MnuEditora_Click(sender, e);
        }

        private void MnuIdioma_Click(object sender, EventArgs e)
        {
            FrmIdioma oFrm = new FrmIdioma();
            oFrm.MdiParent = this;
            MnuIdioma.Enabled = false;
            MnuSIdioma.Enabled = false;
            oFrm.Show();
        }

        private void MnuSIdioma_Click(object sender, EventArgs e)
        {
            MnuIdioma_Click(sender, e);
        }

        private void MnuGenero_Click(object sender, EventArgs e)
        {
            FrmGenero oFrm = new FrmGenero();
            oFrm.MdiParent = this;
            MnuGenero.Enabled = false;
            MnuSGenero.Enabled = false;
            oFrm.Show();
        }

        private void MnuSGenero_Click(object sender, EventArgs e)
        {
            MnuGenero_Click(sender, e);
        }

        private void MnuLivro_Click(object sender, EventArgs e)
        {
            FrmLivro oFrm = new FrmLivro();
            oFrm.MdiParent = this;
            MnuLivro.Enabled = false;
            MnuSLivro.Enabled = false;
            oFrm.Show();
        }

        private void MnuSLivro_Click(object sender, EventArgs e)
        {
            MnuLivro_Click(sender, e);
        }

        private void MnuUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario oFrm = new FrmUsuario();
            oFrm.MdiParent = this;
            MnuUsuario.Enabled = false;
            MnuSUsuario.Enabled = false;
            oFrm.Show();
        }

        private void MnuSUsuario_Click(object sender, EventArgs e)
        {
            MnuUsuario_Click(sender, e);
        }

        private void MnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
using Biblioteca.Helper;
using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FrmEditora : Form
    {
        public bool Incluir = true;

        public FrmEditora()
        {
            InitializeComponent();
        }

        private void FrmEditora_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmMenu)this.MdiParent).MnuEditora.Enabled = true;
            ((FrmMenu)this.MdiParent).MnuSEditora.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }

        private void FrmEditora_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Editoras";
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidaControles()
        {
            int Codigo;

            if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("O campo nome é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNome.Focus();
                return false;
            }

            return true;
        }

        private void LimpaControles()
        {
            TxtCodigo.Text = "";
            TxtNome.Text = "";
            TxtCodigo.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (Incluir)
                {
                    Editora oEditora = new Editora
                    {
                        Nome = TxtNome.Text
                    };

                    try
                    {
                        oEditora.Incluir();
                        CarregaGrid();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir a editora: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }

                }
                else
                {
                    Editora oEditora = new Editora
                    {
                        Id = int.Parse(TxtCodigo.Text),
                        Nome = TxtNome.Text
                    };
                    try
                    {
                        Editora.Alterar(oEditora);
                        CarregaGrid();
                        LimpaControles();
                        Incluir = true;
                        TxtCodigo.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao alterar a editora: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }
                }

            }
        }

        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Editora.ListarTodos();
        }

        private void FrmEditora_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Editora objSelecionado = (Editora)GrdItens.Rows[e.RowIndex].DataBoundItem;
                if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    TxtCodigo.Text = objSelecionado.Id.ToString();
                    TxtNome.Text = objSelecionado.Nome;
                    TxtCodigo.Enabled = false;
                    TxtNome.Focus();
                    Incluir = false;
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Confirme a exclusão.", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objSelecionado.Excluir();
                        CarregaGrid();
                    }
                }
            }
        }
    }
}

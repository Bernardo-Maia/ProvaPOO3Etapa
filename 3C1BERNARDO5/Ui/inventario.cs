using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3C1BERNARDO5.Code.DTO;
using _3C1BERNARDO5.Code.BLL;

namespace _3C1BERNARDO5
{
    public partial class frm_items : Form
    {

        InventarioBLL invbll = new InventarioBLL();
        InventarioDTO invdto = new InventarioDTO();

        public frm_items()
        {
            InitializeComponent();
        }

        private void frm_items_Load(object sender, EventArgs e)
        {
            dgvItens.DataSource = invbll.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            invdto.Produto = txtProduto.Text;
            invdto.Quantidade = int.Parse(txtQuantidade.Text);
            MessageBox.Show("Cadastro com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            invbll.Inserir(invdto);
            dgvItens.DataSource = invbll.Listar();
            txtId.Clear();
            txtProduto.Clear();
            txtQuantidade.Clear();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            invdto.Id = int.Parse(txtId.Text);
            invdto.Produto = txtProduto.Text;
            invdto.Quantidade = int.Parse(txtQuantidade.Text);
            invbll.Editar(invdto);
            MessageBox.Show("Editado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvItens.DataSource = invbll.Listar();
            txtId.Clear();
            txtProduto.Clear();
            txtQuantidade.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            invdto.Id = int.Parse(txtId.Text);
            invbll.Excluir(invdto);
            MessageBox.Show("Excluido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvItens.DataSource = invbll.Listar();
            txtId.Clear();
            txtProduto.Clear();
            txtQuantidade.Clear();

        }

        private void dgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProduto.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtQuantidade.Text = dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}

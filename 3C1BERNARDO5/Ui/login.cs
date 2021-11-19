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

namespace _3C1BERNARDO5.Ui
{
    public partial class frmLogin : Form
    {
        loginBLL lgnBLL = new loginBLL();
        loginDTO lgnDTO = new loginDTO();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lgnDTO.Email = txtEmail.Text;
            lgnDTO.Senha = txtSenha.Text;

            if (lgnBLL.RealizarLogin(lgnDTO) == true)
            {
                frm_items Frm_items = new frm_items();
                Frm_items.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using GestaoManutencao.Modelo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace GestaoManutencao.Visual
{
    public partial class frmCadastrarProduto : MetroForm
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
        }

        private void frmCadastrarProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrarProduto (txtNomedoProduto.Text);
            if (controle.tem)//msg de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(controle.mensagem); //msg de erro
            }
        }
    }
}

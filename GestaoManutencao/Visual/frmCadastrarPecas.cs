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
    public partial class frmCadastrarPecas : MetroForm
    {
        public frmCadastrarPecas()
        {
            InitializeComponent();
        }

        private void frmCadastrarPecas_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarPecas_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrarPecas(txtDescricao.Text, cbxTipoUniComp.Text, txtQuantidade.Text);
            if(controle.tem)//msg de sucesso
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

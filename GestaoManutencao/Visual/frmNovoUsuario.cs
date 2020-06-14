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
    public partial class frmNovoUsuario : MetroForm
    {
        public frmNovoUsuario()
        {
            InitializeComponent();
        }

        private void NovoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txtNome.Text, txtSobrenome.Text, cbxSetor.Text, txtCracha.Text, txtSenha.Text, TxtConfirmarSenha.Text);
            if(controle.tem)//msg de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(controle.mensagem); //msg de erro             
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

using GestaoManutencao.Modelo;
using GestaoManutencao.Utilidade;
using GestaoManutencao.Visual;
using System;
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
    public partial class frmTelaDeLogin : MetroForm
    {
        public frmTelaDeLogin()
        {
            InitializeComponent();
        }

        private void frmTelaDeLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCoordenação_Click(object sender, EventArgs e)
        {
            frmAcessoCoordenador f = new frmAcessoCoordenador();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnAcessarManu_Click(object sender, EventArgs e)
        {
            frmAcessoManutencao f = new frmAcessoManutencao();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnAnalista_Click(object sender, EventArgs e)
        {
            frmAcessoAnalista f = new frmAcessoAnalista();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnAcessarProd_Click(object sender, EventArgs e)
        {
            frmAcessoProducao f = new frmAcessoProducao();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            {
                Controle controle = new Controle();
                controle.acessar(txtUsuario.Text, txtSenha.Text);
                if (controle.mensagem.Equals(""))
                {
                    if (controle.tem)
                    {
                        MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmAcessoCoordenador f = new frmAcessoCoordenador();
                        f.ShowDialog();
                        f.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Login não encontrado, verifique login e senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(controle.mensagem);
                }
            }
        }
    }
}

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
using GestaoManutencao.Visual;
using GestaoManutencao.Ordens;

namespace GestaoManutencao
{
    public partial class frmPrincipal : MetroForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            frmNovoUsuario f = new frmNovoUsuario();
            f.ShowDialog();
            f.Dispose();

        }

        private void btnRecadastrarSenha_Click(object sender, EventArgs e)
        {
            frmRecadastrarSenha f = new frmRecadastrarSenha();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAcessarManu_Click(object sender, EventArgs e)
        {
            frmAcessoManutencao f = new frmAcessoManutencao();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnAcessarProd_Click(object sender, EventArgs e)
        {
            frmAcessoProducao f = new frmAcessoProducao();
            f.ShowDialog();
            f.Dispose();
        }
    }
}

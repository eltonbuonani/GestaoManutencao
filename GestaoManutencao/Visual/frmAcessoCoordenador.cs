using System;
using GestaoManutencao.Ordens;
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
    public partial class frmAcessoCoordenador : MetroForm
    {
        public frmAcessoCoordenador()
        {
            InitializeComponent();
        }

        private void frmAcessoCoordenador_Load(object sender, EventArgs e)
        {

        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            frmNovoUsuario f = new frmNovoUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        private void btDefinirProducaoMensal_Click(object sender, EventArgs e)
        {
            frmDefinirProdMensal f = new frmDefinirProdMensal();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnCadastrarPecas_Click(object sender, EventArgs e)
        {
            frmCadastrarPecas f = new frmCadastrarPecas();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnLancarProducao_Click(object sender, EventArgs e)
        {
            frmLancarProducao f = new frmLancarProducao();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnOrdensVencidas_Click(object sender, EventArgs e)
        {
            frmOrdensVencidas f = new frmOrdensVencidas();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnOrdensNoPrazo_Click(object sender, EventArgs e)
        {
            frmOrdensNoPrazo f = new frmOrdensNoPrazo();
            f.ShowDialog();
            f.Dispose();
        }

        private void OrdensNaFila_Click(object sender, EventArgs e)
        {
            frmOrdensNaFila f = new frmOrdensNaFila();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnCritiUrgente_Click(object sender, EventArgs e)
        {
            frmUrgentes f = new frmUrgentes();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnCritiAlta_Click(object sender, EventArgs e)
        {
            frmAlta f = new frmAlta();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnCritiNormal_Click(object sender, EventArgs e)
        {
            frmNormal f = new frmNormal();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnInspecaoTecnicas_Click(object sender, EventArgs e)
        {
            frmListadeInspecoes f = new frmListadeInspecoes();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnProducao_Click(object sender, EventArgs e)
        {
            frmDadosDeProducao f = new frmDadosDeProducao();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnEquipamentos_Click(object sender, EventArgs e)
        {
            frmEquipamentos f = new frmEquipamentos();
            f.ShowDialog();
            f.Dispose();
        }

        private void BtnConsultarOrdem_Click(object sender, EventArgs e)
        {
            frmListaDeOrdens f = new frmListaDeOrdens();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnEstoquePecas_Click(object sender, EventArgs e)
        {
            frmEstoqueDePecas f = new frmEstoqueDePecas();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnEncerrarOrdem_Click(object sender, EventArgs e)
        {
            frmEncerrarOrdem f = new frmEncerrarOrdem();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnCadPecas_Click(object sender, EventArgs e)
        {
            frmCadastrarPecas f = new frmCadastrarPecas();
            f.ShowDialog();
            f.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLancarProducao f = new frmLancarProducao();
            f.ShowDialog();
            f.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDefinirProdMensal f = new frmDefinirProdMensal();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnCadastrarproduto_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto f = new frmCadastrarProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnOrdenVencida_Click(object sender, EventArgs e)
        {
            frmOrdensVencidas f = new frmOrdensVencidas();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnOrdenPrazo_Click(object sender, EventArgs e)
        {
            frmOrdensNoPrazo f = new frmOrdensNoPrazo();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnOrdenFila_Click(object sender, EventArgs e)
        {
            frmOrdensNaFila f = new frmOrdensNaFila();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnUrgente_Click(object sender, EventArgs e)
        {
            frmUrgentes f = new frmUrgentes();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAlta f = new frmAlta();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            frmNormal f = new frmNormal();
            f.ShowDialog();
            f.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmNovoUsuario f = new frmNovoUsuario();
            f.ShowDialog();
            f.Dispose();
        }
    }
}

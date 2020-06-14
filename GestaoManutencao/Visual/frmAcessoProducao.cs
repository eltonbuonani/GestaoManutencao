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
using GestaoManutencao.Ordens;

namespace GestaoManutencao.Visual
{
    public partial class frmAcessoProducao : MetroForm
    {
        public frmAcessoProducao()
        {
            InitializeComponent();
        }

        private void frmAcessoProducao_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdensVencidas_Click(object sender, EventArgs e)
        {
            frmOrdensVencidas f = new frmOrdensVencidas();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnAbrirOrdem_Click(object sender, EventArgs e)
        {
            frmAbrirOrdem f = new frmAbrirOrdem();
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
    }
}

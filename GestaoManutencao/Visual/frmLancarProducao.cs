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
    public partial class frmLancarProducao : MetroForm
    {
        public frmLancarProducao()
        {
            InitializeComponent();
        }

        private void frmLancarProducao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gestaoManutencaoDataSet.tbl_Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_ProdutoTableAdapter.Fill(this.gestaoManutencaoDataSet.tbl_Produto);
            txtDataProducao.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            txtHoraProducao.Text = DateTime.Now.Date.ToString("00:00");
                
        }

        private void btnGravarLancProducao_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.lancarProducao(txtDataProducao.Text, txtHoraProducao.Text, cbxProduto.Text, txtProducaoPorHora.Text, txtProducaoObservacao.Text);
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

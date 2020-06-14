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
    public partial class frmAbrirOrdem : MetroForm
    {
        public frmAbrirOrdem()
        {
            InitializeComponent();
        }

        private void frmAbrirOrdem_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gestaoManutencaoDataSet1.tbl_Criticidade'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_CriticidadeTableAdapter.Fill(this.gestaoManutencaoDataSet1.tbl_Criticidade);
            // TODO: esta linha de código carrega dados na tabela 'gestaoManutencaoDataSet1.tbl_Ordem'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_OrdemTableAdapter.Fill(this.gestaoManutencaoDataSet1.tbl_Ordem);
            txtDataEntrada.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarOrdem_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.abrirOrdem(txtDescricaoOrdem.Text, cbxTipoManutencao.Text, cbxSetorResp.Text, txtPessoaResp.Text, cbxCriticidade.Text, txtDataEntrada.Text, txtDescriServico.Text, txtPecasNecessarias.Text, cbxEquipamento.Text); 
            if (controle.tem)//msg de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(controle.mensagem); //msg de erro
            }
        }
        
        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

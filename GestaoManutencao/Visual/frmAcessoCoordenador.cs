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

        }
    }
}

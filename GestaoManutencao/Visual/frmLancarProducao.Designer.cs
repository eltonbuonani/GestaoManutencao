namespace GestaoManutencao.Visual
{
    partial class frmLancarProducao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDataProducao = new MetroFramework.Controls.MetroTextBox();
            this.txtHoraProducao = new MetroFramework.Controls.MetroTextBox();
            this.txtProdutoProducao = new MetroFramework.Controls.MetroTextBox();
            this.txtProducaoPorHora = new MetroFramework.Controls.MetroTextBox();
            this.txtProducaoObservacao = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(80, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Data:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(80, 140);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Hora:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(80, 181);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Produto:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(80, 221);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 20);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Produção:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(80, 259);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(95, 20);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Obeservação:";
            // 
            // txtDataProducao
            // 
            this.txtDataProducao.Location = new System.Drawing.Point(190, 102);
            this.txtDataProducao.Name = "txtDataProducao";
            this.txtDataProducao.Size = new System.Drawing.Size(87, 23);
            this.txtDataProducao.TabIndex = 5;
            // 
            // txtHoraProducao
            // 
            this.txtHoraProducao.Location = new System.Drawing.Point(190, 140);
            this.txtHoraProducao.Name = "txtHoraProducao";
            this.txtHoraProducao.Size = new System.Drawing.Size(87, 23);
            this.txtHoraProducao.TabIndex = 6;
            // 
            // txtProdutoProducao
            // 
            this.txtProdutoProducao.Location = new System.Drawing.Point(190, 178);
            this.txtProdutoProducao.Name = "txtProdutoProducao";
            this.txtProdutoProducao.Size = new System.Drawing.Size(87, 23);
            this.txtProdutoProducao.TabIndex = 7;
            // 
            // txtProducaoPorHora
            // 
            this.txtProducaoPorHora.Location = new System.Drawing.Point(190, 218);
            this.txtProducaoPorHora.Name = "txtProducaoPorHora";
            this.txtProducaoPorHora.Size = new System.Drawing.Size(87, 23);
            this.txtProducaoPorHora.TabIndex = 8;
            // 
            // txtProducaoObservacao
            // 
            this.txtProducaoObservacao.Location = new System.Drawing.Point(190, 256);
            this.txtProducaoObservacao.Name = "txtProducaoObservacao";
            this.txtProducaoObservacao.Size = new System.Drawing.Size(87, 23);
            this.txtProducaoObservacao.TabIndex = 9;
            // 
            // frmLancarProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtProducaoObservacao);
            this.Controls.Add(this.txtProducaoPorHora);
            this.Controls.Add(this.txtProdutoProducao);
            this.Controls.Add(this.txtHoraProducao);
            this.Controls.Add(this.txtDataProducao);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmLancarProducao";
            this.Text = "Lançar Produção";
            this.Load += new System.EventHandler(this.frmLancarProducao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtDataProducao;
        private MetroFramework.Controls.MetroTextBox txtHoraProducao;
        private MetroFramework.Controls.MetroTextBox txtProdutoProducao;
        private MetroFramework.Controls.MetroTextBox txtProducaoPorHora;
        private MetroFramework.Controls.MetroTextBox txtProducaoObservacao;
    }
}
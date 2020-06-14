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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDataProducao = new MetroFramework.Controls.MetroTextBox();
            this.txtHoraProducao = new MetroFramework.Controls.MetroTextBox();
            this.txtProducaoPorHora = new MetroFramework.Controls.MetroTextBox();
            this.txtProducaoObservacao = new MetroFramework.Controls.MetroTextBox();
            this.btnGravarLancProducao = new MetroFramework.Controls.MetroButton();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.tblProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestaoManutencaoDataSet = new GestaoManutencao.gestaoManutencaoDataSet();
            this.tbl_ProdutoTableAdapter = new GestaoManutencao.gestaoManutencaoDataSetTableAdapters.tbl_ProdutoTableAdapter();
            this.gestaoManutencaoDataSet1 = new GestaoManutencao.gestaoManutencaoDataSet();
            this.gestaoManutencaoDataSet2 = new GestaoManutencao.gestaoManutencaoDataSet();
            this.gestaoManutencaoDataSet3 = new GestaoManutencao.gestaoManutencaoDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet3)).BeginInit();
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
            // btnGravarLancProducao
            // 
            this.btnGravarLancProducao.Location = new System.Drawing.Point(112, 325);
            this.btnGravarLancProducao.Name = "btnGravarLancProducao";
            this.btnGravarLancProducao.Size = new System.Drawing.Size(150, 70);
            this.btnGravarLancProducao.TabIndex = 40;
            this.btnGravarLancProducao.Text = "Gravar";
            this.btnGravarLancProducao.Click += new System.EventHandler(this.btnGravarLancProducao_Click);
            // 
            // cbxProduto
            // 
            this.cbxProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblProdutoBindingSource, "ID_Produto", true));
            this.cbxProduto.DataSource = this.tblProdutoBindingSource;
            this.cbxProduto.DisplayMember = "produto_Nome";
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(190, 177);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(121, 24);
            this.cbxProduto.TabIndex = 41;
            this.cbxProduto.ValueMember = "ID_Produto";
            // 
            // tblProdutoBindingSource
            // 
            this.tblProdutoBindingSource.DataMember = "tbl_Produto";
            this.tblProdutoBindingSource.DataSource = this.gestaoManutencaoDataSet;
            // 
            // gestaoManutencaoDataSet
            // 
            this.gestaoManutencaoDataSet.DataSetName = "gestaoManutencaoDataSet";
            this.gestaoManutencaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ProdutoTableAdapter
            // 
            this.tbl_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // gestaoManutencaoDataSet1
            // 
            this.gestaoManutencaoDataSet1.DataSetName = "gestaoManutencaoDataSet";
            this.gestaoManutencaoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestaoManutencaoDataSet2
            // 
            this.gestaoManutencaoDataSet2.DataSetName = "gestaoManutencaoDataSet";
            this.gestaoManutencaoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestaoManutencaoDataSet3
            // 
            this.gestaoManutencaoDataSet3.DataSetName = "gestaoManutencaoDataSet";
            this.gestaoManutencaoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmLancarProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxProduto);
            this.Controls.Add(this.btnGravarLancProducao);
            this.Controls.Add(this.txtProducaoObservacao);
            this.Controls.Add(this.txtProducaoPorHora);
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
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet3)).EndInit();
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
        private MetroFramework.Controls.MetroTextBox txtProducaoPorHora;
        private MetroFramework.Controls.MetroTextBox txtProducaoObservacao;
        private MetroFramework.Controls.MetroButton btnGravarLancProducao;
        private System.Windows.Forms.ComboBox cbxProduto;
        private gestaoManutencaoDataSet gestaoManutencaoDataSet;
        private System.Windows.Forms.BindingSource tblProdutoBindingSource;
        private gestaoManutencaoDataSetTableAdapters.tbl_ProdutoTableAdapter tbl_ProdutoTableAdapter;
        private gestaoManutencaoDataSet gestaoManutencaoDataSet1;
        private gestaoManutencaoDataSet gestaoManutencaoDataSet2;
        private gestaoManutencaoDataSet gestaoManutencaoDataSet3;
    }
}
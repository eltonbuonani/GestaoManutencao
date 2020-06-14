namespace GestaoManutencao.Visual
{
    partial class frmAbrirOrdem
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
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtNumOrdemdeServico = new MetroFramework.Controls.MetroTextBox();
            this.txtPecasNecessarias = new MetroFramework.Controls.MetroTextBox();
            this.txtDescriServico = new MetroFramework.Controls.MetroTextBox();
            this.txtDescricaoOrdem = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtDataEntrada = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.btnSalvarOrdem = new MetroFramework.Controls.MetroButton();
            this.cbxTipoManutencao = new System.Windows.Forms.ComboBox();
            this.cbxSetorResp = new System.Windows.Forms.ComboBox();
            this.cbxCriticidade = new System.Windows.Forms.ComboBox();
            this.cbxEquipamento = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtPessoaResp = new MetroFramework.Controls.MetroTextBox();
            this.gestaoManutencaoDataSet = new GestaoManutencao.gestaoManutencaoDataSet();
            this.gestaoManutencaoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestaoManutencaoDataSet1 = new GestaoManutencao.gestaoManutencaoDataSet1();
            this.tblOrdemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_OrdemTableAdapter = new GestaoManutencao.gestaoManutencaoDataSet1TableAdapters.tbl_OrdemTableAdapter();
            this.tblCriticidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CriticidadeTableAdapter = new GestaoManutencao.gestaoManutencaoDataSet1TableAdapters.tbl_CriticidadeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCriticidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(128, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Número da ordem:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(137, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Descrição da ordem:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 165);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(139, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Tipo da manutenção:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 211);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(125, 20);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Setor Responsável:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(25, 309);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(77, 20);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Criticidade:";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(25, 343);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(244, 20);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Descrição do serviço a ser executado:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(25, 422);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(122, 20);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Peças necessárias:";
            // 
            // txtNumOrdemdeServico
            // 
            this.txtNumOrdemdeServico.Location = new System.Drawing.Point(235, 75);
            this.txtNumOrdemdeServico.Name = "txtNumOrdemdeServico";
            this.txtNumOrdemdeServico.Size = new System.Drawing.Size(130, 23);
            this.txtNumOrdemdeServico.TabIndex = 8;
            // 
            // txtPecasNecessarias
            // 
            this.txtPecasNecessarias.Location = new System.Drawing.Point(27, 461);
            this.txtPecasNecessarias.Name = "txtPecasNecessarias";
            this.txtPecasNecessarias.Size = new System.Drawing.Size(852, 23);
            this.txtPecasNecessarias.TabIndex = 11;
            // 
            // txtDescriServico
            // 
            this.txtDescriServico.Location = new System.Drawing.Point(27, 376);
            this.txtDescriServico.Name = "txtDescriServico";
            this.txtDescriServico.Size = new System.Drawing.Size(852, 23);
            this.txtDescriServico.TabIndex = 12;
            // 
            // txtDescricaoOrdem
            // 
            this.txtDescricaoOrdem.Location = new System.Drawing.Point(235, 117);
            this.txtDescricaoOrdem.Name = "txtDescricaoOrdem";
            this.txtDescricaoOrdem.Size = new System.Drawing.Size(384, 23);
            this.txtDescricaoOrdem.TabIndex = 16;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(520, 309);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(111, 20);
            this.metroLabel10.TabIndex = 19;
            this.metroLabel10.Text = "Data de entrada:";
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(663, 309);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(103, 23);
            this.txtDataEntrada.TabIndex = 21;
            this.txtDataEntrada.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(25, 505);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(94, 20);
            this.metroLabel12.TabIndex = 23;
            this.metroLabel12.Text = "Equipamento:";
            // 
            // btnSalvarOrdem
            // 
            this.btnSalvarOrdem.Location = new System.Drawing.Point(395, 654);
            this.btnSalvarOrdem.Name = "btnSalvarOrdem";
            this.btnSalvarOrdem.Size = new System.Drawing.Size(150, 70);
            this.btnSalvarOrdem.TabIndex = 17;
            this.btnSalvarOrdem.Text = "Salvar ordem";
            this.btnSalvarOrdem.Click += new System.EventHandler(this.btnSalvarOrdem_Click);
            // 
            // cbxTipoManutencao
            // 
            this.cbxTipoManutencao.FormattingEnabled = true;
            this.cbxTipoManutencao.Items.AddRange(new object[] {
            "Preventiva",
            "Corretiva",
            "Inspeção técnica"});
            this.cbxTipoManutencao.Location = new System.Drawing.Point(235, 161);
            this.cbxTipoManutencao.Name = "cbxTipoManutencao";
            this.cbxTipoManutencao.Size = new System.Drawing.Size(203, 24);
            this.cbxTipoManutencao.TabIndex = 25;
            // 
            // cbxSetorResp
            // 
            this.cbxSetorResp.FormattingEnabled = true;
            this.cbxSetorResp.Items.AddRange(new object[] {
            "Mecânica",
            "Elétrica",
            "Automação"});
            this.cbxSetorResp.Location = new System.Drawing.Point(235, 202);
            this.cbxSetorResp.Name = "cbxSetorResp";
            this.cbxSetorResp.Size = new System.Drawing.Size(203, 24);
            this.cbxSetorResp.TabIndex = 26;
            // 
            // cbxCriticidade
            // 
            this.cbxCriticidade.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblOrdemBindingSource, "ID_Criticidade", true));
            this.cbxCriticidade.DataSource = this.tblCriticidadeBindingSource;
            this.cbxCriticidade.DisplayMember = "crit_Tipo";
            this.cbxCriticidade.FormattingEnabled = true;
            this.cbxCriticidade.Location = new System.Drawing.Point(190, 305);
            this.cbxCriticidade.Name = "cbxCriticidade";
            this.cbxCriticidade.Size = new System.Drawing.Size(153, 24);
            this.cbxCriticidade.TabIndex = 27;
            this.cbxCriticidade.ValueMember = "ID_Criticidade";
            // 
            // cbxEquipamento
            // 
            this.cbxEquipamento.FormattingEnabled = true;
            this.cbxEquipamento.ItemHeight = 24;
            this.cbxEquipamento.Items.AddRange(new object[] {
            "Despaletizador",
            "Inspetor latas vazias",
            "Enchedora ",
            "Lacrador ",
            "Inspetor latas cheias ",
            "Pasteurizador ",
            "Embaladora ",
            "Mesa programadora ",
            "Paletizador ",
            "Envolvedor "});
            this.cbxEquipamento.Location = new System.Drawing.Point(159, 505);
            this.cbxEquipamento.Name = "cbxEquipamento";
            this.cbxEquipamento.Size = new System.Drawing.Size(345, 30);
            this.cbxEquipamento.TabIndex = 28;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(26, 259);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(132, 20);
            this.metroLabel8.TabIndex = 29;
            this.metroLabel8.Text = "Pessoa responsável:";
            this.metroLabel8.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // txtPessoaResp
            // 
            this.txtPessoaResp.Location = new System.Drawing.Point(235, 256);
            this.txtPessoaResp.Name = "txtPessoaResp";
            this.txtPessoaResp.Size = new System.Drawing.Size(195, 23);
            this.txtPessoaResp.TabIndex = 30;
            this.txtPessoaResp.Click += new System.EventHandler(this.metroTextBox1_Click_1);
            // 
            // gestaoManutencaoDataSet
            // 
            this.gestaoManutencaoDataSet.DataSetName = "gestaoManutencaoDataSet";
            this.gestaoManutencaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestaoManutencaoDataSetBindingSource
            // 
            this.gestaoManutencaoDataSetBindingSource.DataSource = this.gestaoManutencaoDataSet;
            this.gestaoManutencaoDataSetBindingSource.Position = 0;
            // 
            // gestaoManutencaoDataSet1
            // 
            this.gestaoManutencaoDataSet1.DataSetName = "gestaoManutencaoDataSet1";
            this.gestaoManutencaoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOrdemBindingSource
            // 
            this.tblOrdemBindingSource.DataMember = "tbl_Ordem";
            this.tblOrdemBindingSource.DataSource = this.gestaoManutencaoDataSet1;
            // 
            // tbl_OrdemTableAdapter
            // 
            this.tbl_OrdemTableAdapter.ClearBeforeFill = true;
            // 
            // tblCriticidadeBindingSource
            // 
            this.tblCriticidadeBindingSource.DataMember = "tbl_Criticidade";
            this.tblCriticidadeBindingSource.DataSource = this.gestaoManutencaoDataSet1;
            // 
            // tbl_CriticidadeTableAdapter
            // 
            this.tbl_CriticidadeTableAdapter.ClearBeforeFill = true;
            // 
            // frmAbrirOrdem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 800);
            this.Controls.Add(this.txtPessoaResp);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.cbxEquipamento);
            this.Controls.Add(this.cbxCriticidade);
            this.Controls.Add(this.cbxSetorResp);
            this.Controls.Add(this.cbxTipoManutencao);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.btnSalvarOrdem);
            this.Controls.Add(this.txtDescricaoOrdem);
            this.Controls.Add(this.txtDescriServico);
            this.Controls.Add(this.txtPecasNecessarias);
            this.Controls.Add(this.txtNumOrdemdeServico);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmAbrirOrdem";
            this.Text = "Abrir Ordem de Serviço";
            this.Load += new System.EventHandler(this.frmAbrirOrdem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCriticidadeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtNumOrdemdeServico;
        private MetroFramework.Controls.MetroTextBox txtPecasNecessarias;
        private MetroFramework.Controls.MetroTextBox txtDescriServico;
        private MetroFramework.Controls.MetroTextBox txtDescricaoOrdem;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtDataEntrada;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton btnSalvarOrdem;
        private System.Windows.Forms.ComboBox cbxTipoManutencao;
        private System.Windows.Forms.ComboBox cbxSetorResp;
        private System.Windows.Forms.ComboBox cbxCriticidade;
        private MetroFramework.Controls.MetroComboBox cbxEquipamento;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtPessoaResp;
        private System.Windows.Forms.BindingSource gestaoManutencaoDataSetBindingSource;
        private gestaoManutencaoDataSet gestaoManutencaoDataSet;
        private gestaoManutencaoDataSet1 gestaoManutencaoDataSet1;
        private System.Windows.Forms.BindingSource tblOrdemBindingSource;
        private gestaoManutencaoDataSet1TableAdapters.tbl_OrdemTableAdapter tbl_OrdemTableAdapter;
        private System.Windows.Forms.BindingSource tblCriticidadeBindingSource;
        private gestaoManutencaoDataSet1TableAdapters.tbl_CriticidadeTableAdapter tbl_CriticidadeTableAdapter;
    }
}
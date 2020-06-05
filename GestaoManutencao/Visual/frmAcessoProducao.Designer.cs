namespace GestaoManutencao.Visual
{
    partial class frmAcessoProducao
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
            this.BtnConsultarOrdem = new MetroFramework.Controls.MetroButton();
            this.btnEquipamentos = new MetroFramework.Controls.MetroButton();
            this.btnProducao = new MetroFramework.Controls.MetroButton();
            this.btnAbrirOrdem = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnOrdensVencidas = new MetroFramework.Controls.MetroButton();
            this.btnOrdensNoPrazo = new MetroFramework.Controls.MetroButton();
            this.OrdensNaFila = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnCritiNormal = new MetroFramework.Controls.MetroButton();
            this.btnCritiAlta = new MetroFramework.Controls.MetroButton();
            this.btnCritiUrgente = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(105, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Usuário";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(419, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Setor";
            // 
            // BtnConsultarOrdem
            // 
            this.BtnConsultarOrdem.Location = new System.Drawing.Point(615, 436);
            this.BtnConsultarOrdem.Name = "BtnConsultarOrdem";
            this.BtnConsultarOrdem.Size = new System.Drawing.Size(150, 70);
            this.BtnConsultarOrdem.TabIndex = 2;
            this.BtnConsultarOrdem.Text = "Consultar Ordens";
            this.BtnConsultarOrdem.Click += new System.EventHandler(this.BtnConsultarOrdem_Click);
            // 
            // btnEquipamentos
            // 
            this.btnEquipamentos.Location = new System.Drawing.Point(615, 342);
            this.btnEquipamentos.Name = "btnEquipamentos";
            this.btnEquipamentos.Size = new System.Drawing.Size(150, 70);
            this.btnEquipamentos.TabIndex = 3;
            this.btnEquipamentos.Text = "Equipamentos";
            this.btnEquipamentos.Click += new System.EventHandler(this.btnEquipamentos_Click);
            // 
            // btnProducao
            // 
            this.btnProducao.Location = new System.Drawing.Point(615, 257);
            this.btnProducao.Name = "btnProducao";
            this.btnProducao.Size = new System.Drawing.Size(150, 70);
            this.btnProducao.TabIndex = 4;
            this.btnProducao.Text = "Produção";
            this.btnProducao.Click += new System.EventHandler(this.btnProducao_Click);
            // 
            // btnAbrirOrdem
            // 
            this.btnAbrirOrdem.Location = new System.Drawing.Point(615, 167);
            this.btnAbrirOrdem.Name = "btnAbrirOrdem";
            this.btnAbrirOrdem.Size = new System.Drawing.Size(150, 70);
            this.btnAbrirOrdem.TabIndex = 5;
            this.btnAbrirOrdem.Text = "Abrir Ordem";
            this.btnAbrirOrdem.Click += new System.EventHandler(this.btnAbrirOrdem_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(231, 145);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(107, 20);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Ordens Abertas";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // btnOrdensVencidas
            // 
            this.btnOrdensVencidas.Location = new System.Drawing.Point(34, 189);
            this.btnOrdensVencidas.Name = "btnOrdensVencidas";
            this.btnOrdensVencidas.Size = new System.Drawing.Size(150, 70);
            this.btnOrdensVencidas.TabIndex = 8;
            this.btnOrdensVencidas.Text = "Ordens Vencidas";
            this.btnOrdensVencidas.Click += new System.EventHandler(this.btnOrdensVencidas_Click);
            // 
            // btnOrdensNoPrazo
            // 
            this.btnOrdensNoPrazo.Location = new System.Drawing.Point(208, 189);
            this.btnOrdensNoPrazo.Name = "btnOrdensNoPrazo";
            this.btnOrdensNoPrazo.Size = new System.Drawing.Size(150, 70);
            this.btnOrdensNoPrazo.TabIndex = 9;
            this.btnOrdensNoPrazo.Text = "Ordens no Prazo";
            this.btnOrdensNoPrazo.Click += new System.EventHandler(this.btnOrdensNoPrazo_Click);
            // 
            // OrdensNaFila
            // 
            this.OrdensNaFila.Location = new System.Drawing.Point(389, 189);
            this.OrdensNaFila.Name = "OrdensNaFila";
            this.OrdensNaFila.Size = new System.Drawing.Size(150, 70);
            this.OrdensNaFila.TabIndex = 10;
            this.OrdensNaFila.Text = "Ordens na Fila";
            this.OrdensNaFila.Click += new System.EventHandler(this.OrdensNaFila_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(209, 436);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(149, 20);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Criticidade das Ordens";
            // 
            // btnCritiNormal
            // 
            this.btnCritiNormal.Location = new System.Drawing.Point(389, 480);
            this.btnCritiNormal.Name = "btnCritiNormal";
            this.btnCritiNormal.Size = new System.Drawing.Size(150, 70);
            this.btnCritiNormal.TabIndex = 14;
            this.btnCritiNormal.Text = "C - Normal";
            this.btnCritiNormal.Click += new System.EventHandler(this.btnCritiNormal_Click);
            // 
            // btnCritiAlta
            // 
            this.btnCritiAlta.Location = new System.Drawing.Point(208, 480);
            this.btnCritiAlta.Name = "btnCritiAlta";
            this.btnCritiAlta.Size = new System.Drawing.Size(150, 70);
            this.btnCritiAlta.TabIndex = 13;
            this.btnCritiAlta.Text = "B - Alta";
            this.btnCritiAlta.Click += new System.EventHandler(this.btnCritiAlta_Click);
            // 
            // btnCritiUrgente
            // 
            this.btnCritiUrgente.Location = new System.Drawing.Point(34, 480);
            this.btnCritiUrgente.Name = "btnCritiUrgente";
            this.btnCritiUrgente.Size = new System.Drawing.Size(150, 70);
            this.btnCritiUrgente.TabIndex = 12;
            this.btnCritiUrgente.Text = "A - Urgente";
            this.btnCritiUrgente.Click += new System.EventHandler(this.btnCritiUrgente_Click);
            // 
            // frmAcessoProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 610);
            this.Controls.Add(this.btnCritiNormal);
            this.Controls.Add(this.btnCritiAlta);
            this.Controls.Add(this.btnCritiUrgente);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.OrdensNaFila);
            this.Controls.Add(this.btnOrdensNoPrazo);
            this.Controls.Add(this.btnOrdensVencidas);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnAbrirOrdem);
            this.Controls.Add(this.btnProducao);
            this.Controls.Add(this.btnEquipamentos);
            this.Controls.Add(this.BtnConsultarOrdem);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmAcessoProducao";
            this.Text = "Acesso Produção";
            this.Load += new System.EventHandler(this.frmAcessoProducao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton BtnConsultarOrdem;
        private MetroFramework.Controls.MetroButton btnEquipamentos;
        private MetroFramework.Controls.MetroButton btnProducao;
        private MetroFramework.Controls.MetroButton btnAbrirOrdem;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnOrdensVencidas;
        private MetroFramework.Controls.MetroButton btnOrdensNoPrazo;
        private MetroFramework.Controls.MetroButton OrdensNaFila;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnCritiNormal;
        private MetroFramework.Controls.MetroButton btnCritiAlta;
        private MetroFramework.Controls.MetroButton btnCritiUrgente;
    }
}
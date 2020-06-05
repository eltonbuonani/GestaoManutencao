namespace GestaoManutencao.Visual
{
    partial class frmAcessoManutencao
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
            this.btnCritiNormal = new MetroFramework.Controls.MetroButton();
            this.btnCritiAlta = new MetroFramework.Controls.MetroButton();
            this.btnCritiUrgente = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.OrdensNaFila = new MetroFramework.Controls.MetroButton();
            this.btnOrdensNoPrazo = new MetroFramework.Controls.MetroButton();
            this.btnOrdensVencidas = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnAbrirOrdem = new MetroFramework.Controls.MetroButton();
            this.btnProducao = new MetroFramework.Controls.MetroButton();
            this.btnEquipamentos = new MetroFramework.Controls.MetroButton();
            this.BtnConsultarOrdem = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnCritiNormal
            // 
            this.btnCritiNormal.Location = new System.Drawing.Point(403, 489);
            this.btnCritiNormal.Name = "btnCritiNormal";
            this.btnCritiNormal.Size = new System.Drawing.Size(150, 70);
            this.btnCritiNormal.TabIndex = 28;
            this.btnCritiNormal.Text = "C - Normal";
            this.btnCritiNormal.Click += new System.EventHandler(this.btnCritiNormal_Click);
            // 
            // btnCritiAlta
            // 
            this.btnCritiAlta.Location = new System.Drawing.Point(222, 489);
            this.btnCritiAlta.Name = "btnCritiAlta";
            this.btnCritiAlta.Size = new System.Drawing.Size(150, 70);
            this.btnCritiAlta.TabIndex = 27;
            this.btnCritiAlta.Text = "B - Alta";
            this.btnCritiAlta.Click += new System.EventHandler(this.btnCritiAlta_Click);
            // 
            // btnCritiUrgente
            // 
            this.btnCritiUrgente.Location = new System.Drawing.Point(48, 489);
            this.btnCritiUrgente.Name = "btnCritiUrgente";
            this.btnCritiUrgente.Size = new System.Drawing.Size(150, 70);
            this.btnCritiUrgente.TabIndex = 26;
            this.btnCritiUrgente.Text = "A - Urgente";
            this.btnCritiUrgente.Click += new System.EventHandler(this.btnCritiUrgente_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(223, 445);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(149, 20);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "Criticidade das Ordens";
            // 
            // OrdensNaFila
            // 
            this.OrdensNaFila.Location = new System.Drawing.Point(403, 198);
            this.OrdensNaFila.Name = "OrdensNaFila";
            this.OrdensNaFila.Size = new System.Drawing.Size(150, 70);
            this.OrdensNaFila.TabIndex = 24;
            this.OrdensNaFila.Text = "Ordens na Fila";
            this.OrdensNaFila.Click += new System.EventHandler(this.OrdensNaFila_Click);
            // 
            // btnOrdensNoPrazo
            // 
            this.btnOrdensNoPrazo.Location = new System.Drawing.Point(222, 198);
            this.btnOrdensNoPrazo.Name = "btnOrdensNoPrazo";
            this.btnOrdensNoPrazo.Size = new System.Drawing.Size(150, 70);
            this.btnOrdensNoPrazo.TabIndex = 23;
            this.btnOrdensNoPrazo.Text = "Ordens no Prazo";
            this.btnOrdensNoPrazo.Click += new System.EventHandler(this.btnOrdensNoPrazo_Click);
            // 
            // btnOrdensVencidas
            // 
            this.btnOrdensVencidas.Location = new System.Drawing.Point(48, 198);
            this.btnOrdensVencidas.Name = "btnOrdensVencidas";
            this.btnOrdensVencidas.Size = new System.Drawing.Size(150, 70);
            this.btnOrdensVencidas.TabIndex = 22;
            this.btnOrdensVencidas.Text = "Ordens Vencidas";
            this.btnOrdensVencidas.Click += new System.EventHandler(this.btnOrdensVencidas_Click);
            this.btnOrdensVencidas.Paint += new System.Windows.Forms.PaintEventHandler(this.btnOrdensVencidas_Paint);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(245, 154);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(107, 20);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Ordens Abertas";
            // 
            // btnAbrirOrdem
            // 
            this.btnAbrirOrdem.Location = new System.Drawing.Point(622, 33);
            this.btnAbrirOrdem.Name = "btnAbrirOrdem";
            this.btnAbrirOrdem.Size = new System.Drawing.Size(150, 70);
            this.btnAbrirOrdem.TabIndex = 20;
            this.btnAbrirOrdem.Text = "Abrir Ordem";
            this.btnAbrirOrdem.Click += new System.EventHandler(this.btnAbrirOrdem_Click);
            // 
            // btnProducao
            // 
            this.btnProducao.Location = new System.Drawing.Point(622, 212);
            this.btnProducao.Name = "btnProducao";
            this.btnProducao.Size = new System.Drawing.Size(150, 70);
            this.btnProducao.TabIndex = 19;
            this.btnProducao.Text = "Produção";
            this.btnProducao.Click += new System.EventHandler(this.btnProducao_Click);
            // 
            // btnEquipamentos
            // 
            this.btnEquipamentos.Location = new System.Drawing.Point(622, 300);
            this.btnEquipamentos.Name = "btnEquipamentos";
            this.btnEquipamentos.Size = new System.Drawing.Size(150, 70);
            this.btnEquipamentos.TabIndex = 18;
            this.btnEquipamentos.Text = "Equipamentos";
            this.btnEquipamentos.Click += new System.EventHandler(this.btnEquipamentos_Click);
            // 
            // BtnConsultarOrdem
            // 
            this.BtnConsultarOrdem.Location = new System.Drawing.Point(622, 394);
            this.BtnConsultarOrdem.Name = "BtnConsultarOrdem";
            this.BtnConsultarOrdem.Size = new System.Drawing.Size(150, 70);
            this.BtnConsultarOrdem.TabIndex = 17;
            this.BtnConsultarOrdem.Text = "Consultar Ordens";
            this.BtnConsultarOrdem.Click += new System.EventHandler(this.BtnConsultarOrdem_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(433, 83);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 20);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Setor";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(119, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 20);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Usuário";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(622, 483);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(150, 70);
            this.metroButton1.TabIndex = 29;
            this.metroButton1.Text = "Estoque de Peças";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(622, 121);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(150, 70);
            this.metroButton2.TabIndex = 30;
            this.metroButton2.Text = "Inspeções Técnicas";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(622, 579);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(150, 70);
            this.metroButton3.TabIndex = 31;
            this.metroButton3.Text = "Encerrar ordem";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // frmAcessoManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 662);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
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
            this.Name = "frmAcessoManutencao";
            this.Text = "Acesso Manutenção";
            this.Load += new System.EventHandler(this.frmAcessar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCritiNormal;
        private MetroFramework.Controls.MetroButton btnCritiAlta;
        private MetroFramework.Controls.MetroButton btnCritiUrgente;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton OrdensNaFila;
        private MetroFramework.Controls.MetroButton btnOrdensNoPrazo;
        private MetroFramework.Controls.MetroButton btnOrdensVencidas;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnAbrirOrdem;
        private MetroFramework.Controls.MetroButton btnProducao;
        private MetroFramework.Controls.MetroButton btnEquipamentos;
        private MetroFramework.Controls.MetroButton BtnConsultarOrdem;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}
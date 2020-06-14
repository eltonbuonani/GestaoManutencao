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
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnUrgente = new System.Windows.Forms.Button();
            this.btnOrdenFila = new System.Windows.Forms.Button();
            this.btnOrdenPrazo = new System.Windows.Forms.Button();
            this.btnOrdenVencida = new System.Windows.Forms.Button();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(162, 109);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Usuário";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(510, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Setor";
            // 
            // BtnConsultarOrdem
            // 
            this.BtnConsultarOrdem.Location = new System.Drawing.Point(713, 509);
            this.BtnConsultarOrdem.Name = "BtnConsultarOrdem";
            this.BtnConsultarOrdem.Size = new System.Drawing.Size(150, 70);
            this.BtnConsultarOrdem.TabIndex = 2;
            this.BtnConsultarOrdem.Text = "Consultar Ordens";
            this.BtnConsultarOrdem.Click += new System.EventHandler(this.BtnConsultarOrdem_Click);
            // 
            // btnEquipamentos
            // 
            this.btnEquipamentos.Location = new System.Drawing.Point(713, 415);
            this.btnEquipamentos.Name = "btnEquipamentos";
            this.btnEquipamentos.Size = new System.Drawing.Size(150, 70);
            this.btnEquipamentos.TabIndex = 3;
            this.btnEquipamentos.Text = "Equipamentos";
            this.btnEquipamentos.Click += new System.EventHandler(this.btnEquipamentos_Click);
            // 
            // btnProducao
            // 
            this.btnProducao.Location = new System.Drawing.Point(713, 330);
            this.btnProducao.Name = "btnProducao";
            this.btnProducao.Size = new System.Drawing.Size(150, 70);
            this.btnProducao.TabIndex = 4;
            this.btnProducao.Text = "Produção";
            this.btnProducao.Click += new System.EventHandler(this.btnProducao_Click);
            // 
            // btnAbrirOrdem
            // 
            this.btnAbrirOrdem.Location = new System.Drawing.Point(713, 240);
            this.btnAbrirOrdem.Name = "btnAbrirOrdem";
            this.btnAbrirOrdem.Size = new System.Drawing.Size(150, 70);
            this.btnAbrirOrdem.TabIndex = 5;
            this.btnAbrirOrdem.Text = "Abrir Ordem";
            this.btnAbrirOrdem.Click += new System.EventHandler(this.btnAbrirOrdem_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(307, 213);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(107, 20);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Ordens Abertas";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.BackColor = System.Drawing.Color.Green;
            this.btnNormal.Location = new System.Drawing.Point(464, 434);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(150, 80);
            this.btnNormal.TabIndex = 101;
            this.btnNormal.Text = "C -Normal";
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.Yellow;
            this.btnAlta.Location = new System.Drawing.Point(283, 434);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(150, 80);
            this.btnAlta.TabIndex = 100;
            this.btnAlta.Text = "B - Alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnUrgente
            // 
            this.btnUrgente.BackColor = System.Drawing.Color.Red;
            this.btnUrgente.Location = new System.Drawing.Point(100, 434);
            this.btnUrgente.Name = "btnUrgente";
            this.btnUrgente.Size = new System.Drawing.Size(150, 80);
            this.btnUrgente.TabIndex = 99;
            this.btnUrgente.Text = "A - Urgente";
            this.btnUrgente.UseVisualStyleBackColor = false;
            this.btnUrgente.Click += new System.EventHandler(this.btnUrgente_Click);
            // 
            // btnOrdenFila
            // 
            this.btnOrdenFila.BackColor = System.Drawing.Color.Green;
            this.btnOrdenFila.Location = new System.Drawing.Point(454, 259);
            this.btnOrdenFila.Name = "btnOrdenFila";
            this.btnOrdenFila.Size = new System.Drawing.Size(150, 80);
            this.btnOrdenFila.TabIndex = 98;
            this.btnOrdenFila.Text = "Ordens na Fila";
            this.btnOrdenFila.UseVisualStyleBackColor = false;
            this.btnOrdenFila.Click += new System.EventHandler(this.btnOrdenFila_Click);
            // 
            // btnOrdenPrazo
            // 
            this.btnOrdenPrazo.BackColor = System.Drawing.Color.Yellow;
            this.btnOrdenPrazo.Location = new System.Drawing.Point(283, 259);
            this.btnOrdenPrazo.Name = "btnOrdenPrazo";
            this.btnOrdenPrazo.Size = new System.Drawing.Size(150, 80);
            this.btnOrdenPrazo.TabIndex = 97;
            this.btnOrdenPrazo.Text = "Ordens no Prazo";
            this.btnOrdenPrazo.UseVisualStyleBackColor = false;
            this.btnOrdenPrazo.Click += new System.EventHandler(this.btnOrdenPrazo_Click);
            // 
            // btnOrdenVencida
            // 
            this.btnOrdenVencida.BackColor = System.Drawing.Color.Red;
            this.btnOrdenVencida.Location = new System.Drawing.Point(90, 259);
            this.btnOrdenVencida.Name = "btnOrdenVencida";
            this.btnOrdenVencida.Size = new System.Drawing.Size(150, 80);
            this.btnOrdenVencida.TabIndex = 96;
            this.btnOrdenVencida.Text = "Ordens Vencidas";
            this.btnOrdenVencida.UseVisualStyleBackColor = false;
            this.btnOrdenVencida.Click += new System.EventHandler(this.btnOrdenVencida_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(284, 390);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(149, 20);
            this.metroLabel5.TabIndex = 94;
            this.metroLabel5.Text = "Criticidade das Ordens";
            // 
            // frmAcessoProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 800);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnUrgente);
            this.Controls.Add(this.btnOrdenFila);
            this.Controls.Add(this.btnOrdenPrazo);
            this.Controls.Add(this.btnOrdenVencida);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnAbrirOrdem);
            this.Controls.Add(this.btnProducao);
            this.Controls.Add(this.btnEquipamentos);
            this.Controls.Add(this.BtnConsultarOrdem);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "frmAcessoProducao";
            this.Resizable = false;
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
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnUrgente;
        private System.Windows.Forms.Button btnOrdenFila;
        private System.Windows.Forms.Button btnOrdenPrazo;
        private System.Windows.Forms.Button btnOrdenVencida;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnAbrirOrdem = new MetroFramework.Controls.MetroButton();
            this.btnProducao = new MetroFramework.Controls.MetroButton();
            this.btnEquipamentos = new MetroFramework.Controls.MetroButton();
            this.BtnConsultarOrdem = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnUrgente = new System.Windows.Forms.Button();
            this.btnOrdenFila = new System.Windows.Forms.Button();
            this.btnOrdenPrazo = new System.Windows.Forms.Button();
            this.btnOrdenVencida = new System.Windows.Forms.Button();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(292, 428);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(149, 20);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "Criticidade das Ordens";
            // 
            // btnAbrirOrdem
            // 
            this.btnAbrirOrdem.Location = new System.Drawing.Point(742, 121);
            this.btnAbrirOrdem.Name = "btnAbrirOrdem";
            this.btnAbrirOrdem.Size = new System.Drawing.Size(150, 70);
            this.btnAbrirOrdem.TabIndex = 20;
            this.btnAbrirOrdem.Text = "Abrir Ordem";
            this.btnAbrirOrdem.Click += new System.EventHandler(this.btnAbrirOrdem_Click);
            // 
            // btnProducao
            // 
            this.btnProducao.Location = new System.Drawing.Point(742, 300);
            this.btnProducao.Name = "btnProducao";
            this.btnProducao.Size = new System.Drawing.Size(150, 70);
            this.btnProducao.TabIndex = 19;
            this.btnProducao.Text = "Produção";
            this.btnProducao.Click += new System.EventHandler(this.btnProducao_Click);
            // 
            // btnEquipamentos
            // 
            this.btnEquipamentos.Location = new System.Drawing.Point(742, 388);
            this.btnEquipamentos.Name = "btnEquipamentos";
            this.btnEquipamentos.Size = new System.Drawing.Size(150, 70);
            this.btnEquipamentos.TabIndex = 18;
            this.btnEquipamentos.Text = "Equipamentos";
            this.btnEquipamentos.Click += new System.EventHandler(this.btnEquipamentos_Click);
            // 
            // BtnConsultarOrdem
            // 
            this.BtnConsultarOrdem.Location = new System.Drawing.Point(742, 482);
            this.BtnConsultarOrdem.Name = "BtnConsultarOrdem";
            this.BtnConsultarOrdem.Size = new System.Drawing.Size(150, 70);
            this.BtnConsultarOrdem.TabIndex = 17;
            this.BtnConsultarOrdem.Text = "Consultar Ordens";
            this.BtnConsultarOrdem.Click += new System.EventHandler(this.BtnConsultarOrdem_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(529, 83);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 20);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Setor";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(186, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 20);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Usuário";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(742, 571);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(150, 70);
            this.metroButton1.TabIndex = 29;
            this.metroButton1.Text = "Estoque de Peças";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(742, 209);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(150, 70);
            this.metroButton2.TabIndex = 30;
            this.metroButton2.Text = "Inspeções Técnicas";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(742, 667);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(150, 70);
            this.metroButton3.TabIndex = 31;
            this.metroButton3.Text = "Encerrar ordem";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.BackColor = System.Drawing.Color.Green;
            this.btnNormal.Location = new System.Drawing.Point(472, 472);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(150, 80);
            this.btnNormal.TabIndex = 93;
            this.btnNormal.Text = "C -Normal";
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.Yellow;
            this.btnAlta.Location = new System.Drawing.Point(291, 472);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(150, 80);
            this.btnAlta.TabIndex = 92;
            this.btnAlta.Text = "B - Alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnUrgente
            // 
            this.btnUrgente.BackColor = System.Drawing.Color.Red;
            this.btnUrgente.Location = new System.Drawing.Point(108, 472);
            this.btnUrgente.Name = "btnUrgente";
            this.btnUrgente.Size = new System.Drawing.Size(150, 80);
            this.btnUrgente.TabIndex = 91;
            this.btnUrgente.Text = "A - Urgente";
            this.btnUrgente.UseVisualStyleBackColor = false;
            this.btnUrgente.Click += new System.EventHandler(this.btnUrgente_Click);
            // 
            // btnOrdenFila
            // 
            this.btnOrdenFila.BackColor = System.Drawing.Color.Green;
            this.btnOrdenFila.Location = new System.Drawing.Point(471, 209);
            this.btnOrdenFila.Name = "btnOrdenFila";
            this.btnOrdenFila.Size = new System.Drawing.Size(150, 80);
            this.btnOrdenFila.TabIndex = 90;
            this.btnOrdenFila.Text = "Ordens na Fila";
            this.btnOrdenFila.UseVisualStyleBackColor = false;
            this.btnOrdenFila.Click += new System.EventHandler(this.btnOrdenFila_Click);
            // 
            // btnOrdenPrazo
            // 
            this.btnOrdenPrazo.BackColor = System.Drawing.Color.Yellow;
            this.btnOrdenPrazo.Location = new System.Drawing.Point(300, 209);
            this.btnOrdenPrazo.Name = "btnOrdenPrazo";
            this.btnOrdenPrazo.Size = new System.Drawing.Size(150, 80);
            this.btnOrdenPrazo.TabIndex = 89;
            this.btnOrdenPrazo.Text = "Ordens no Prazo";
            this.btnOrdenPrazo.UseVisualStyleBackColor = false;
            this.btnOrdenPrazo.Click += new System.EventHandler(this.btnOrdenPrazo_Click);
            // 
            // btnOrdenVencida
            // 
            this.btnOrdenVencida.BackColor = System.Drawing.Color.Red;
            this.btnOrdenVencida.Location = new System.Drawing.Point(107, 209);
            this.btnOrdenVencida.Name = "btnOrdenVencida";
            this.btnOrdenVencida.Size = new System.Drawing.Size(150, 80);
            this.btnOrdenVencida.TabIndex = 88;
            this.btnOrdenVencida.Text = "Ordens Vencidas";
            this.btnOrdenVencida.UseVisualStyleBackColor = false;
            this.btnOrdenVencida.Click += new System.EventHandler(this.btnOrdenVencida_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(308, 171);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(107, 20);
            this.metroLabel6.TabIndex = 86;
            this.metroLabel6.Text = "Ordens Abertas";
            // 
            // frmAcessoManutencao
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
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnAbrirOrdem);
            this.Controls.Add(this.btnProducao);
            this.Controls.Add(this.btnEquipamentos);
            this.Controls.Add(this.BtnConsultarOrdem);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "frmAcessoManutencao";
            this.Resizable = false;
            this.Text = "Acesso Manutenção";
            this.Load += new System.EventHandler(this.frmAcessar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnAbrirOrdem;
        private MetroFramework.Controls.MetroButton btnProducao;
        private MetroFramework.Controls.MetroButton btnEquipamentos;
        private MetroFramework.Controls.MetroButton BtnConsultarOrdem;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnUrgente;
        private System.Windows.Forms.Button btnOrdenFila;
        private System.Windows.Forms.Button btnOrdenPrazo;
        private System.Windows.Forms.Button btnOrdenVencida;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}
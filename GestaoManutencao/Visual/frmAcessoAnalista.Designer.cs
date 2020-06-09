﻿namespace GestaoManutencao.Visual
{
    partial class frmAcessoAnalista
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
            this.btnEncerrarOrdem = new MetroFramework.Controls.MetroButton();
            this.btnInspecaoTecnicas = new MetroFramework.Controls.MetroButton();
            this.btnEstoquePecas = new MetroFramework.Controls.MetroButton();
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
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnCadastrarPecas = new MetroFramework.Controls.MetroButton();
            this.btnLancarProducao = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnEncerrarOrdem
            // 
            this.btnEncerrarOrdem.Location = new System.Drawing.Point(596, 564);
            this.btnEncerrarOrdem.Name = "btnEncerrarOrdem";
            this.btnEncerrarOrdem.Size = new System.Drawing.Size(150, 70);
            this.btnEncerrarOrdem.TabIndex = 48;
            this.btnEncerrarOrdem.Text = "Encerrar ordem";
            this.btnEncerrarOrdem.Click += new System.EventHandler(this.btnEncerrarOrdem_Click);
            // 
            // btnInspecaoTecnicas
            // 
            this.btnInspecaoTecnicas.Location = new System.Drawing.Point(596, 106);
            this.btnInspecaoTecnicas.Name = "btnInspecaoTecnicas";
            this.btnInspecaoTecnicas.Size = new System.Drawing.Size(150, 70);
            this.btnInspecaoTecnicas.TabIndex = 47;
            this.btnInspecaoTecnicas.Text = "Inspeções Técnicas";
            this.btnInspecaoTecnicas.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btnEstoquePecas
            // 
            this.btnEstoquePecas.Location = new System.Drawing.Point(596, 468);
            this.btnEstoquePecas.Name = "btnEstoquePecas";
            this.btnEstoquePecas.Size = new System.Drawing.Size(150, 70);
            this.btnEstoquePecas.TabIndex = 46;
            this.btnEstoquePecas.Text = "Estoque de Peças";
            this.btnEstoquePecas.Click += new System.EventHandler(this.btnEstoquePecas_Click);
            // 
            // btnCritiNormal
            // 
            this.btnCritiNormal.Location = new System.Drawing.Point(377, 474);
            this.btnCritiNormal.Name = "btnCritiNormal";
            this.btnCritiNormal.Size = new System.Drawing.Size(150, 70);
            this.btnCritiNormal.TabIndex = 45;
            this.btnCritiNormal.Text = "C - Normal";
            this.btnCritiNormal.Click += new System.EventHandler(this.btnCritiNormal_Click);
            // 
            // btnCritiAlta
            // 
            this.btnCritiAlta.Location = new System.Drawing.Point(196, 474);
            this.btnCritiAlta.Name = "btnCritiAlta";
            this.btnCritiAlta.Size = new System.Drawing.Size(150, 70);
            this.btnCritiAlta.TabIndex = 44;
            this.btnCritiAlta.Text = "B - Alta";
            this.btnCritiAlta.Click += new System.EventHandler(this.btnCritiAlta_Click);
            // 
            // btnCritiUrgente
            // 
            this.btnCritiUrgente.Location = new System.Drawing.Point(22, 474);
            this.btnCritiUrgente.Name = "btnCritiUrgente";
            this.btnCritiUrgente.Size = new System.Drawing.Size(150, 70);
            this.btnCritiUrgente.TabIndex = 43;
            this.btnCritiUrgente.Text = "A - Urgente";
            this.btnCritiUrgente.Click += new System.EventHandler(this.btnCritiUrgente_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(197, 430);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(149, 20);
            this.metroLabel4.TabIndex = 42;
            this.metroLabel4.Text = "Criticidade das Ordens";
            // 
            // OrdensNaFila
            // 
            this.OrdensNaFila.Location = new System.Drawing.Point(381, 309);
            this.OrdensNaFila.Name = "OrdensNaFila";
            this.OrdensNaFila.Size = new System.Drawing.Size(150, 70);
            this.OrdensNaFila.TabIndex = 41;
            this.OrdensNaFila.Text = "Ordens na Fila";
            this.OrdensNaFila.Click += new System.EventHandler(this.OrdensNaFila_Click);
            // 
            // btnOrdensNoPrazo
            // 
            this.btnOrdensNoPrazo.Location = new System.Drawing.Point(200, 309);
            this.btnOrdensNoPrazo.Name = "btnOrdensNoPrazo";
            this.btnOrdensNoPrazo.Size = new System.Drawing.Size(150, 70);
            this.btnOrdensNoPrazo.TabIndex = 40;
            this.btnOrdensNoPrazo.Text = "Ordens no Prazo";
            this.btnOrdensNoPrazo.Click += new System.EventHandler(this.btnOrdensNoPrazo_Click);
            // 
            // btnOrdensVencidas
            // 
            this.btnOrdensVencidas.Location = new System.Drawing.Point(26, 309);
            this.btnOrdensVencidas.Name = "btnOrdensVencidas";
            this.btnOrdensVencidas.Size = new System.Drawing.Size(150, 70);
            this.btnOrdensVencidas.TabIndex = 39;
            this.btnOrdensVencidas.Text = "Ordens Vencidas";
            this.btnOrdensVencidas.Click += new System.EventHandler(this.btnOrdensVencidas_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(223, 265);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(107, 20);
            this.metroLabel3.TabIndex = 38;
            this.metroLabel3.Text = "Ordens Abertas";
            // 
            // btnAbrirOrdem
            // 
            this.btnAbrirOrdem.Location = new System.Drawing.Point(596, 18);
            this.btnAbrirOrdem.Name = "btnAbrirOrdem";
            this.btnAbrirOrdem.Size = new System.Drawing.Size(150, 70);
            this.btnAbrirOrdem.TabIndex = 37;
            this.btnAbrirOrdem.Text = "Abrir Ordem";
            this.btnAbrirOrdem.Click += new System.EventHandler(this.btnAbrirOrdem_Click);
            // 
            // btnProducao
            // 
            this.btnProducao.Location = new System.Drawing.Point(596, 197);
            this.btnProducao.Name = "btnProducao";
            this.btnProducao.Size = new System.Drawing.Size(150, 70);
            this.btnProducao.TabIndex = 36;
            this.btnProducao.Text = "Produção";
            this.btnProducao.Click += new System.EventHandler(this.btnProducao_Click);
            // 
            // btnEquipamentos
            // 
            this.btnEquipamentos.Location = new System.Drawing.Point(596, 285);
            this.btnEquipamentos.Name = "btnEquipamentos";
            this.btnEquipamentos.Size = new System.Drawing.Size(150, 70);
            this.btnEquipamentos.TabIndex = 35;
            this.btnEquipamentos.Text = "Equipamentos";
            this.btnEquipamentos.Click += new System.EventHandler(this.btnEquipamentos_Click);
            // 
            // BtnConsultarOrdem
            // 
            this.BtnConsultarOrdem.Location = new System.Drawing.Point(596, 379);
            this.BtnConsultarOrdem.Name = "BtnConsultarOrdem";
            this.BtnConsultarOrdem.Size = new System.Drawing.Size(150, 70);
            this.BtnConsultarOrdem.TabIndex = 34;
            this.BtnConsultarOrdem.Text = "Consultar Ordens";
            this.BtnConsultarOrdem.Click += new System.EventHandler(this.BtnConsultarOrdem_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(407, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 20);
            this.metroLabel2.TabIndex = 33;
            this.metroLabel2.Text = "Setor";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(93, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 20);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "Usuário";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(223, 125);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(0, 0);
            this.metroLabel5.TabIndex = 49;
            // 
            // btnCadastrarPecas
            // 
            this.btnCadastrarPecas.Location = new System.Drawing.Point(114, 165);
            this.btnCadastrarPecas.Name = "btnCadastrarPecas";
            this.btnCadastrarPecas.Size = new System.Drawing.Size(150, 70);
            this.btnCadastrarPecas.TabIndex = 50;
            this.btnCadastrarPecas.Text = "Cadastrar Peças";
            this.btnCadastrarPecas.Click += new System.EventHandler(this.btnCadastrarPecas_Click);
            // 
            // btnLancarProducao
            // 
            this.btnLancarProducao.Location = new System.Drawing.Point(288, 165);
            this.btnLancarProducao.Name = "btnLancarProducao";
            this.btnLancarProducao.Size = new System.Drawing.Size(150, 70);
            this.btnLancarProducao.TabIndex = 51;
            this.btnLancarProducao.Text = "Lançar Produção";
            // 
            // frmAcessoAnalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 660);
            this.Controls.Add(this.btnLancarProducao);
            this.Controls.Add(this.btnCadastrarPecas);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnEncerrarOrdem);
            this.Controls.Add(this.btnInspecaoTecnicas);
            this.Controls.Add(this.btnEstoquePecas);
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
            this.Name = "frmAcessoAnalista";
            this.Text = "Acesso Analista";
            this.Load += new System.EventHandler(this.frmAcessoAnalista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnEncerrarOrdem;
        private MetroFramework.Controls.MetroButton btnInspecaoTecnicas;
        private MetroFramework.Controls.MetroButton btnEstoquePecas;
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
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnCadastrarPecas;
        private MetroFramework.Controls.MetroButton btnLancarProducao;
    }
}
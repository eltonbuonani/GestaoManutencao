﻿namespace GestaoManutencao.Visual
{
    partial class frmDefinirProdMensal
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
            this.txtProduto = new MetroFramework.Controls.MetroTextBox();
            this.txtQuantidadeMensal = new MetroFramework.Controls.MetroTextBox();
            this.btnDefinirProd = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(311, 175);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Produto:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(240, 222);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(132, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Quantidade mensal:";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(417, 175);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(182, 23);
            this.txtProduto.TabIndex = 2;
            // 
            // txtQuantidadeMensal
            // 
            this.txtQuantidadeMensal.Location = new System.Drawing.Point(417, 222);
            this.txtQuantidadeMensal.Name = "txtQuantidadeMensal";
            this.txtQuantidadeMensal.Size = new System.Drawing.Size(182, 23);
            this.txtQuantidadeMensal.TabIndex = 3;
            // 
            // btnDefinirProd
            // 
            this.btnDefinirProd.Location = new System.Drawing.Point(336, 298);
            this.btnDefinirProd.Name = "btnDefinirProd";
            this.btnDefinirProd.Size = new System.Drawing.Size(150, 70);
            this.btnDefinirProd.TabIndex = 41;
            this.btnDefinirProd.Text = "Gravar";
            this.btnDefinirProd.Click += new System.EventHandler(this.btnDefinirProd_Click);
            // 
            // frmDefinirProdMensal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnDefinirProd);
            this.Controls.Add(this.txtQuantidadeMensal);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmDefinirProdMensal";
            this.Resizable = false;
            this.Text = "Definir Produção Mensal";
            this.Load += new System.EventHandler(this.frmDefinirProdMensal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtProduto;
        private MetroFramework.Controls.MetroTextBox txtQuantidadeMensal;
        private MetroFramework.Controls.MetroButton btnDefinirProd;
    }
}
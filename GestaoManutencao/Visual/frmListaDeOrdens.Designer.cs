﻿namespace GestaoManutencao.Visual
{
    partial class frmListaDeOrdens
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
            this.SuspendLayout();
            // 
            // frmListaDeOrdens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 800);
            this.MaximizeBox = false;
            this.Name = "frmListaDeOrdens";
            this.Resizable = false;
            this.Text = "Lista De Ordens";
            this.Load += new System.EventHandler(this.frmListaDeOrdens_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
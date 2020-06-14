namespace GestaoManutencao.Visual
{
    partial class frmEncerrarOrdem
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
            this.btnSalvarOrdem = new MetroFramework.Controls.MetroButton();
            this.txtNumOrdemdeServico = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnSalvarOrdem
            // 
            this.btnSalvarOrdem.Location = new System.Drawing.Point(379, 681);
            this.btnSalvarOrdem.Name = "btnSalvarOrdem";
            this.btnSalvarOrdem.Size = new System.Drawing.Size(150, 70);
            this.btnSalvarOrdem.TabIndex = 39;
            this.btnSalvarOrdem.Text = "Encerrar ordem";
            // 
            // txtNumOrdemdeServico
            // 
            this.txtNumOrdemdeServico.Location = new System.Drawing.Point(220, 130);
            this.txtNumOrdemdeServico.Name = "txtNumOrdemdeServico";
            this.txtNumOrdemdeServico.Size = new System.Drawing.Size(162, 23);
            this.txtNumOrdemdeServico.TabIndex = 31;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(70, 133);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(128, 20);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Número da ordem:";
            // 
            // frmEncerrarOrdem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 800);
            this.Controls.Add(this.btnSalvarOrdem);
            this.Controls.Add(this.txtNumOrdemdeServico);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "frmEncerrarOrdem";
            this.Resizable = false;
            this.Text = "Encerrar Ordem";
            this.Load += new System.EventHandler(this.frmEncerrarOrdem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnSalvarOrdem;
        private MetroFramework.Controls.MetroTextBox txtNumOrdemdeServico;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
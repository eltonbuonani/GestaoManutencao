namespace GestaoManutencao.Visual
{
    partial class frmCadastrarProduto
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
            this.txtNomedoProduto = new MetroFramework.Controls.MetroTextBox();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(136, 147);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(124, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nome do produto:";
            // 
            // txtNomedoProduto
            // 
            this.txtNomedoProduto.Location = new System.Drawing.Point(277, 147);
            this.txtNomedoProduto.Name = "txtNomedoProduto";
            this.txtNomedoProduto.Size = new System.Drawing.Size(228, 23);
            this.txtNomedoProduto.TabIndex = 1;
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Image = global::GestaoManutencao.Properties.Resources.icons8_salvar_e_fechar_641;
            this.btnCadastrarProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(291, 249);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(150, 90);
            this.btnCadastrarProduto.TabIndex = 2;
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.btnCadastrarProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // frmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.txtNomedoProduto);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "frmCadastrarProduto";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "Cadastrar Produto";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.frmCadastrarProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNomedoProduto;
        private System.Windows.Forms.Button btnCadastrarProduto;
    }
}
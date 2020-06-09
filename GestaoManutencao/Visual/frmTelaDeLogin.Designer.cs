namespace GestaoManutencao.Visual
{
    partial class frmTelaDeLogin
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
            this.btnCoordenação = new MetroFramework.Controls.MetroButton();
            this.btnAnalista = new MetroFramework.Controls.MetroButton();
            this.btnAcessarProd = new MetroFramework.Controls.MetroButton();
            this.btnAcessarManu = new MetroFramework.Controls.MetroButton();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAcessar = new MetroFramework.Controls.MetroButton();
            this.btnRecadastrarSenha = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnCoordenação
            // 
            this.btnCoordenação.Location = new System.Drawing.Point(527, 244);
            this.btnCoordenação.Name = "btnCoordenação";
            this.btnCoordenação.Size = new System.Drawing.Size(125, 39);
            this.btnCoordenação.TabIndex = 21;
            this.btnCoordenação.Text = "Acessar Coordenação";
            this.btnCoordenação.Click += new System.EventHandler(this.btnCoordenação_Click);
            // 
            // btnAnalista
            // 
            this.btnAnalista.Location = new System.Drawing.Point(527, 184);
            this.btnAnalista.Name = "btnAnalista";
            this.btnAnalista.Size = new System.Drawing.Size(125, 39);
            this.btnAnalista.TabIndex = 20;
            this.btnAnalista.Text = "Acessar Analista";
            this.btnAnalista.Click += new System.EventHandler(this.btnAnalista_Click);
            // 
            // btnAcessarProd
            // 
            this.btnAcessarProd.Location = new System.Drawing.Point(367, 244);
            this.btnAcessarProd.Name = "btnAcessarProd";
            this.btnAcessarProd.Size = new System.Drawing.Size(125, 39);
            this.btnAcessarProd.TabIndex = 19;
            this.btnAcessarProd.Text = "Acessar produção";
            this.btnAcessarProd.Click += new System.EventHandler(this.btnAcessarProd_Click);
            // 
            // btnAcessarManu
            // 
            this.btnAcessarManu.Location = new System.Drawing.Point(367, 184);
            this.btnAcessarManu.Name = "btnAcessarManu";
            this.btnAcessarManu.Size = new System.Drawing.Size(125, 39);
            this.btnAcessarManu.TabIndex = 18;
            this.btnAcessarManu.Text = "Acessar Manutenção";
            this.btnAcessarManu.Click += new System.EventHandler(this.btnAcessarManu_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(172, 151);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(163, 23);
            this.txtSenha.TabIndex = 17;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(97, 151);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 20);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(172, 97);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(163, 23);
            this.txtUsuario.TabIndex = 15;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(97, 97);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 20);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Usuário:";
            // 
            // btnAcessar
            // 
            this.btnAcessar.Location = new System.Drawing.Point(172, 213);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(150, 70);
            this.btnAcessar.TabIndex = 13;
            this.btnAcessar.Text = "Acessar ";
            // 
            // btnRecadastrarSenha
            // 
            this.btnRecadastrarSenha.Location = new System.Drawing.Point(172, 325);
            this.btnRecadastrarSenha.Name = "btnRecadastrarSenha";
            this.btnRecadastrarSenha.Size = new System.Drawing.Size(150, 70);
            this.btnRecadastrarSenha.TabIndex = 12;
            this.btnRecadastrarSenha.Text = "Recadastrar Senha";
            // 
            // frmTelaDeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCoordenação);
            this.Controls.Add(this.btnAnalista);
            this.Controls.Add(this.btnAcessarProd);
            this.Controls.Add(this.btnAcessarManu);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.btnRecadastrarSenha);
            this.Name = "frmTelaDeLogin";
            this.Text = "Tela De Login";
            this.Load += new System.EventHandler(this.frmTelaDeLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCoordenação;
        private MetroFramework.Controls.MetroButton btnAnalista;
        private MetroFramework.Controls.MetroButton btnAcessarProd;
        private MetroFramework.Controls.MetroButton btnAcessarManu;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAcessar;
        private MetroFramework.Controls.MetroButton btnRecadastrarSenha;
    }
}
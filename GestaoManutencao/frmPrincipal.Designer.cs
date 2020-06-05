namespace GestaoManutencao
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnNovoUsuario = new MetroFramework.Controls.MetroButton();
            this.btnRecadastrarSenha = new MetroFramework.Controls.MetroButton();
            this.btnAcessar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.btnAcessarManu = new MetroFramework.Controls.MetroButton();
            this.btnAcessarProd = new MetroFramework.Controls.MetroButton();
            this.btnAnalista = new MetroFramework.Controls.MetroButton();
            this.btnCoordenação = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Location = new System.Drawing.Point(23, 357);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(150, 70);
            this.btnNovoUsuario.TabIndex = 0;
            this.btnNovoUsuario.Text = "Novo Usuário";
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // btnRecadastrarSenha
            // 
            this.btnRecadastrarSenha.Location = new System.Drawing.Point(229, 357);
            this.btnRecadastrarSenha.Name = "btnRecadastrarSenha";
            this.btnRecadastrarSenha.Size = new System.Drawing.Size(150, 70);
            this.btnRecadastrarSenha.TabIndex = 1;
            this.btnRecadastrarSenha.Text = "Recadastrar Senha";
            this.btnRecadastrarSenha.Click += new System.EventHandler(this.btnRecadastrarSenha_Click);
            // 
            // btnAcessar
            // 
            this.btnAcessar.Location = new System.Drawing.Point(138, 237);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(150, 70);
            this.btnAcessar.TabIndex = 2;
            this.btnAcessar.Text = "Acessar ";
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(63, 121);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(138, 121);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(163, 23);
            this.txtUsuario.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(63, 175);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(138, 175);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(163, 23);
            this.txtSenha.TabIndex = 6;
            // 
            // btnAcessarManu
            // 
            this.btnAcessarManu.Location = new System.Drawing.Point(333, 208);
            this.btnAcessarManu.Name = "btnAcessarManu";
            this.btnAcessarManu.Size = new System.Drawing.Size(125, 39);
            this.btnAcessarManu.TabIndex = 7;
            this.btnAcessarManu.Text = "Acessar Manutenção";
            this.btnAcessarManu.Click += new System.EventHandler(this.btnAcessarManu_Click);
            // 
            // btnAcessarProd
            // 
            this.btnAcessarProd.Location = new System.Drawing.Point(333, 268);
            this.btnAcessarProd.Name = "btnAcessarProd";
            this.btnAcessarProd.Size = new System.Drawing.Size(125, 39);
            this.btnAcessarProd.TabIndex = 8;
            this.btnAcessarProd.Text = "Acessar produção";
            this.btnAcessarProd.Click += new System.EventHandler(this.btnAcessarProd_Click);
            // 
            // btnAnalista
            // 
            this.btnAnalista.Location = new System.Drawing.Point(493, 208);
            this.btnAnalista.Name = "btnAnalista";
            this.btnAnalista.Size = new System.Drawing.Size(125, 39);
            this.btnAnalista.TabIndex = 9;
            this.btnAnalista.Text = "Acessar Analista";
            this.btnAnalista.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnCoordenação
            // 
            this.btnCoordenação.Location = new System.Drawing.Point(493, 268);
            this.btnCoordenação.Name = "btnCoordenação";
            this.btnCoordenação.Size = new System.Drawing.Size(125, 39);
            this.btnCoordenação.TabIndex = 10;
            this.btnCoordenação.Text = "Acessar Coordenação";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 535);
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
            this.Controls.Add(this.btnNovoUsuario);
            this.Name = "frmPrincipal";
            this.Text = "Software de Gestão de Manutenção";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private MetroFramework.Controls.MetroButton btnNovoUsuario;
        private MetroFramework.Controls.MetroButton btnRecadastrarSenha;
        private MetroFramework.Controls.MetroButton btnAcessar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroButton btnAcessarManu;
        private MetroFramework.Controls.MetroButton btnAcessarProd;
        private MetroFramework.Controls.MetroButton btnAnalista;
        private MetroFramework.Controls.MetroButton btnCoordenação;
    }
}


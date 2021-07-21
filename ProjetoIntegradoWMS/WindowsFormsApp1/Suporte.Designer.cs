
namespace ProjetoIntegradoArmazem
{
    partial class frmSuporteAoUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuporteAoUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDataeHora = new System.Windows.Forms.Label();
            this.timerDataHora = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.picCabecalho = new System.Windows.Forms.PictureBox();
            this.mnuOpcoes = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.optionPreferencias = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionVerMatricula = new System.Windows.Forms.ToolStripMenuItem();
            this.optionPermissoes = new System.Windows.Forms.ToolStripMenuItem();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.tipDicas = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCabecalho)).BeginInit();
            this.mnuOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(140, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forms com algumas instruções e ajudas básicas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label2.Location = new System.Drawing.Point(254, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Rapid Express";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(423, 51);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(111, 15);
            this.lblUsuario.TabIndex = 20;
            this.lblUsuario.Text = "Usuário: 00000000";
            // 
            // lblDataeHora
            // 
            this.lblDataeHora.AutoSize = true;
            this.lblDataeHora.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDataeHora.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDataeHora.Location = new System.Drawing.Point(210, 61);
            this.lblDataeHora.Name = "lblDataeHora";
            this.lblDataeHora.Size = new System.Drawing.Size(110, 15);
            this.lblDataeHora.TabIndex = 23;
            this.lblDataeHora.Text = "dd/mm/yyyy, 00:00";
            // 
            // timerDataHora
            // 
            this.timerDataHora.Enabled = true;
            this.timerDataHora.Interval = 1;
            this.timerDataHora.Tick += new System.EventHandler(this.timerDataHora_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(427, 246);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 13);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mais informações";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(12, 282);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 26);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "   Voltar";
            this.tipDicas.SetToolTip(this.btnVoltar, "Clique para retornar à tela anterior.");
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // picCabecalho
            // 
            this.picCabecalho.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picCabecalho.Location = new System.Drawing.Point(-1, 24);
            this.picCabecalho.Name = "picCabecalho";
            this.picCabecalho.Size = new System.Drawing.Size(539, 60);
            this.picCabecalho.TabIndex = 4;
            this.picCabecalho.TabStop = false;
            // 
            // mnuOpcoes
            // 
            this.mnuOpcoes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuOpcoes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuOpcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.mnuOpcoes.Location = new System.Drawing.Point(0, 0);
            this.mnuOpcoes.MaximumSize = new System.Drawing.Size(538, 24);
            this.mnuOpcoes.MinimumSize = new System.Drawing.Size(538, 24);
            this.mnuOpcoes.Name = "mnuOpcoes";
            this.mnuOpcoes.Size = new System.Drawing.Size(538, 24);
            this.mnuOpcoes.TabIndex = 27;
            this.mnuOpcoes.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSair,
            this.toolStripMenuItem1,
            this.optionPreferencias});
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.arquivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("arquivoToolStripMenuItem.Image")));
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.arquivoToolStripMenuItem.Text = "Sistema";
            // 
            // optionSair
            // 
            this.optionSair.Image = ((System.Drawing.Image)(resources.GetObject("optionSair.Image")));
            this.optionSair.Name = "optionSair";
            this.optionSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.optionSair.Size = new System.Drawing.Size(179, 22);
            this.optionSair.Text = "Sair";
            this.optionSair.Click += new System.EventHandler(this.optionSair_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 6);
            // 
            // optionPreferencias
            // 
            this.optionPreferencias.Image = ((System.Drawing.Image)(resources.GetObject("optionPreferencias.Image")));
            this.optionPreferencias.Name = "optionPreferencias";
            this.optionPreferencias.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.optionPreferencias.Size = new System.Drawing.Size(179, 22);
            this.optionPreferencias.Text = "Preferências";
            this.optionPreferencias.Click += new System.EventHandler(this.optionPreferencias_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionVerMatricula,
            this.optionPermissoes});
            this.editarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.editarToolStripMenuItem.Text = "Usuário";
            // 
            // optionVerMatricula
            // 
            this.optionVerMatricula.Image = ((System.Drawing.Image)(resources.GetObject("optionVerMatricula.Image")));
            this.optionVerMatricula.Name = "optionVerMatricula";
            this.optionVerMatricula.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.optionVerMatricula.Size = new System.Drawing.Size(184, 22);
            this.optionVerMatricula.Text = "Ver matrícula";
            this.optionVerMatricula.Click += new System.EventHandler(this.optionVerMatricula_Click);
            // 
            // optionPermissoes
            // 
            this.optionPermissoes.Image = ((System.Drawing.Image)(resources.GetObject("optionPermissoes.Image")));
            this.optionPermissoes.Name = "optionPermissoes";
            this.optionPermissoes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.optionPermissoes.Size = new System.Drawing.Size(184, 22);
            this.optionPermissoes.Text = "Permissões";
            this.optionPermissoes.Click += new System.EventHandler(this.optionPermissoes_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(10, 30);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(103, 44);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 28;
            this.picLogo.TabStop = false;
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.lblNomeEmpresa.Location = new System.Drawing.Point(410, 34);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(78, 15);
            this.lblNomeEmpresa.TabIndex = 29;
            this.lblNomeEmpresa.Text = "Rapid Express";
            // 
            // tipDicas
            // 
            this.tipDicas.IsBalloon = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(200, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "FATEC Warehouse System";
            // 
            // frmSuporteAoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(538, 318);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNomeEmpresa);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.mnuOpcoes);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblDataeHora);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picCabecalho);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(554, 357);
            this.MinimumSize = new System.Drawing.Size(554, 357);
            this.Name = "frmSuporteAoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suporte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSuporteAoUsuario_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picCabecalho)).EndInit();
            this.mnuOpcoes.ResumeLayout(false);
            this.mnuOpcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCabecalho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDataeHora;
        private System.Windows.Forms.Timer timerDataHora;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MenuStrip mnuOpcoes;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionSair;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionPreferencias;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionVerMatricula;
        private System.Windows.Forms.ToolStripMenuItem optionPermissoes;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.ToolTip tipDicas;
        private System.Windows.Forms.Label label3;
    }
}
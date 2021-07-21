
namespace ProjetoIntegradoArmazem
{
    partial class frmMapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMapa));
            this.grpDadosLocalizacao = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome_do_Produto = new System.Windows.Forms.TextBox();
            this.txtCodigo_do_Produto = new System.Windows.Forms.TextBox();
            this.txtEAN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDataeHora = new System.Windows.Forms.Label();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.timerDataHora = new System.Windows.Forms.Timer(this.components);
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picMapaArmazem = new System.Windows.Forms.PictureBox();
            this.picCabecalho = new System.Windows.Forms.PictureBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tipDicas = new System.Windows.Forms.ToolTip(this.components);
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.optionPreferencias = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionVerMatricula = new System.Windows.Forms.ToolStripMenuItem();
            this.optionPermissoes = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSuporte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcaoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.opcaoPreferencias = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcaoVerMatricula = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.opcaoPermissoes = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcaoSuporte = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDadosLocalizacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMapaArmazem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCabecalho)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDadosLocalizacao
            // 
            this.grpDadosLocalizacao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpDadosLocalizacao.Controls.Add(this.label1);
            this.grpDadosLocalizacao.Location = new System.Drawing.Point(12, 107);
            this.grpDadosLocalizacao.Name = "grpDadosLocalizacao";
            this.grpDadosLocalizacao.Size = new System.Drawing.Size(279, 149);
            this.grpDadosLocalizacao.TabIndex = 1;
            this.grpDadosLocalizacao.TabStop = false;
            this.grpDadosLocalizacao.Text = "Localização";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dados da localização";
            // 
            // txtNome_do_Produto
            // 
            this.txtNome_do_Produto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNome_do_Produto.Location = new System.Drawing.Point(35, 361);
            this.txtNome_do_Produto.Name = "txtNome_do_Produto";
            this.txtNome_do_Produto.Size = new System.Drawing.Size(212, 20);
            this.txtNome_do_Produto.TabIndex = 1;
            this.txtNome_do_Produto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_do_Produto_KeyPress);
            // 
            // txtCodigo_do_Produto
            // 
            this.txtCodigo_do_Produto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCodigo_do_Produto.Location = new System.Drawing.Point(35, 430);
            this.txtCodigo_do_Produto.Name = "txtCodigo_do_Produto";
            this.txtCodigo_do_Produto.Size = new System.Drawing.Size(212, 20);
            this.txtCodigo_do_Produto.TabIndex = 2;
            this.txtCodigo_do_Produto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_do_Produto_KeyPress);
            // 
            // txtEAN
            // 
            this.txtEAN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEAN.Location = new System.Drawing.Point(35, 501);
            this.txtEAN.Name = "txtEAN";
            this.txtEAN.Size = new System.Drawing.Size(212, 20);
            this.txtEAN.TabIndex = 3;
            this.txtEAN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEAN_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo do produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "EAN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(568, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "FATEC Warehouse System";
            // 
            // lblDataeHora
            // 
            this.lblDataeHora.AutoSize = true;
            this.lblDataeHora.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDataeHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataeHora.Location = new System.Drawing.Point(570, 63);
            this.lblDataeHora.Name = "lblDataeHora";
            this.lblDataeHora.Size = new System.Drawing.Size(146, 21);
            this.lblDataeHora.TabIndex = 33;
            this.lblDataeHora.Text = "dd/mm/yyyy, 00:00";
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresa.Location = new System.Drawing.Point(922, 35);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(125, 25);
            this.lblNomeEmpresa.TabIndex = 34;
            this.lblNomeEmpresa.Text = "Rapid Express";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(963, 60);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(111, 15);
            this.lblUsuario.TabIndex = 35;
            this.lblUsuario.Text = "Usuário: 00000000";
            // 
            // timerDataHora
            // 
            this.timerDataHora.Enabled = true;
            this.timerDataHora.Interval = 1;
            this.timerDataHora.Tick += new System.EventHandler(this.timerDataHora_Tick);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(94, 32);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(190, 60);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 30;
            this.picLogo.TabStop = false;
            // 
            // picMapaArmazem
            // 
            this.picMapaArmazem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picMapaArmazem.Image = ((System.Drawing.Image)(resources.GetObject("picMapaArmazem.Image")));
            this.picMapaArmazem.InitialImage = null;
            this.picMapaArmazem.Location = new System.Drawing.Point(297, 107);
            this.picMapaArmazem.Name = "picMapaArmazem";
            this.picMapaArmazem.Size = new System.Drawing.Size(777, 636);
            this.picMapaArmazem.TabIndex = 29;
            this.picMapaArmazem.TabStop = false;
            // 
            // picCabecalho
            // 
            this.picCabecalho.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picCabecalho.Location = new System.Drawing.Point(0, 12);
            this.picCabecalho.Name = "picCabecalho";
            this.picCabecalho.Size = new System.Drawing.Size(1083, 87);
            this.picCabecalho.TabIndex = 28;
            this.picCabecalho.TabStop = false;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVisualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizar.Location = new System.Drawing.Point(35, 570);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(219, 35);
            this.btnVisualizar.TabIndex = 4;
            this.btnVisualizar.Text = "Visualizar";
            this.tipDicas.SetToolTip(this.btnVisualizar, "Clique para visualizar o local do produto.");
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
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
            this.btnVoltar.Location = new System.Drawing.Point(12, 737);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(94, 34);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "      Voltar";
            this.tipDicas.SetToolTip(this.btnVoltar, "Clique para retornar à tela anterior.");
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tipDicas
            // 
            this.tipDicas.IsBalloon = true;
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.arquivoToolStripMenuItem.Text = "Sistema";
            // 
            // optionSair
            // 
            this.optionSair.Name = "optionSair";
            this.optionSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.optionSair.Size = new System.Drawing.Size(180, 22);
            this.optionSair.Text = "Sair";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // optionPreferencias
            // 
            this.optionPreferencias.Name = "optionPreferencias";
            this.optionPreferencias.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.optionPreferencias.Size = new System.Drawing.Size(180, 22);
            this.optionPreferencias.Text = "Preferências";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.editarToolStripMenuItem.Text = "Usuário";
            // 
            // optionVerMatricula
            // 
            this.optionVerMatricula.Name = "optionVerMatricula";
            this.optionVerMatricula.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.optionVerMatricula.Size = new System.Drawing.Size(184, 22);
            this.optionVerMatricula.Text = "Ver matrícula";
            // 
            // optionPermissoes
            // 
            this.optionPermissoes.Name = "optionPermissoes";
            this.optionPermissoes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.optionPermissoes.Size = new System.Drawing.Size(184, 22);
            this.optionPermissoes.Text = "Permissões";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.exibirToolStripMenuItem.Text = "Ajuda";
            // 
            // optionSuporte
            // 
            this.optionSuporte.Name = "optionSuporte";
            this.optionSuporte.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.optionSuporte.Size = new System.Drawing.Size(180, 22);
            this.optionSuporte.Text = "Suporte";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(79, 20);
            this.toolStripMenuItem2.Text = " Sistema";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Sair";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "Preferências";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(75, 20);
            this.toolStripMenuItem5.Text = "Usuário";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem6.Image")));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.toolStripMenuItem6.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItem6.Text = "Ver matrícula";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem7.Image")));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.toolStripMenuItem7.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItem7.Text = "Permissões";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem8.Image")));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem8.Text = "Ajuda";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem9.Image")));
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.toolStripMenuItem9.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem9.Text = "Suporte";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemasToolStripMenuItem,
            this.usuárioToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemasToolStripMenuItem
            // 
            this.sistemasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcaoSair,
            this.toolStripSeparator2,
            this.opcaoPreferencias});
            this.sistemasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sistemasToolStripMenuItem.Image")));
            this.sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            this.sistemasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.sistemasToolStripMenuItem.Text = "Sistema";
            // 
            // opcaoSair
            // 
            this.opcaoSair.Image = ((System.Drawing.Image)(resources.GetObject("opcaoSair.Image")));
            this.opcaoSair.Name = "opcaoSair";
            this.opcaoSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.opcaoSair.Size = new System.Drawing.Size(179, 22);
            this.opcaoSair.Text = "Sair";
            this.opcaoSair.Click += new System.EventHandler(this.opcaoSair_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            // 
            // opcaoPreferencias
            // 
            this.opcaoPreferencias.Image = ((System.Drawing.Image)(resources.GetObject("opcaoPreferencias.Image")));
            this.opcaoPreferencias.Name = "opcaoPreferencias";
            this.opcaoPreferencias.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.opcaoPreferencias.Size = new System.Drawing.Size(179, 22);
            this.opcaoPreferencias.Text = "Preferências";
            this.opcaoPreferencias.Click += new System.EventHandler(this.opcaoPreferencias_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcaoVerMatricula,
            this.toolStripSeparator3,
            this.opcaoPermissoes});
            this.usuárioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuárioToolStripMenuItem.Image")));
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // opcaoVerMatricula
            // 
            this.opcaoVerMatricula.Image = ((System.Drawing.Image)(resources.GetObject("opcaoVerMatricula.Image")));
            this.opcaoVerMatricula.Name = "opcaoVerMatricula";
            this.opcaoVerMatricula.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.opcaoVerMatricula.Size = new System.Drawing.Size(184, 22);
            this.opcaoVerMatricula.Text = "Ver matrícula";
            this.opcaoVerMatricula.Click += new System.EventHandler(this.opcaoVerMatricula_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(181, 6);
            // 
            // opcaoPermissoes
            // 
            this.opcaoPermissoes.Image = ((System.Drawing.Image)(resources.GetObject("opcaoPermissoes.Image")));
            this.opcaoPermissoes.Name = "opcaoPermissoes";
            this.opcaoPermissoes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.opcaoPermissoes.Size = new System.Drawing.Size(184, 22);
            this.opcaoPermissoes.Text = "Permissões";
            this.opcaoPermissoes.Click += new System.EventHandler(this.opcaoPermissoes_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcaoSuporte});
            this.ajudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripMenuItem.Image")));
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // opcaoSuporte
            // 
            this.opcaoSuporte.Image = ((System.Drawing.Image)(resources.GetObject("opcaoSuporte.Image")));
            this.opcaoSuporte.Name = "opcaoSuporte";
            this.opcaoSuporte.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.opcaoSuporte.Size = new System.Drawing.Size(158, 22);
            this.opcaoSuporte.Text = "Suporte";
            this.opcaoSuporte.Click += new System.EventHandler(this.opcaoSuporte_Click);
            // 
            // frmMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1082, 783);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNomeEmpresa);
            this.Controls.Add(this.lblDataeHora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picMapaArmazem);
            this.Controls.Add(this.picCabecalho);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEAN);
            this.Controls.Add(this.txtCodigo_do_Produto);
            this.Controls.Add(this.txtNome_do_Produto);
            this.Controls.Add(this.grpDadosLocalizacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1098, 822);
            this.MinimumSize = new System.Drawing.Size(1098, 822);
            this.Name = "frmMapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMapa_FormClosing);
            this.grpDadosLocalizacao.ResumeLayout(false);
            this.grpDadosLocalizacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMapaArmazem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCabecalho)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpDadosLocalizacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome_do_Produto;
        private System.Windows.Forms.TextBox txtCodigo_do_Produto;
        private System.Windows.Forms.TextBox txtEAN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.PictureBox picCabecalho;
        private System.Windows.Forms.PictureBox picMapaArmazem;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDataeHora;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Timer timerDataHora;
        private System.Windows.Forms.ToolTip tipDicas;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionSair;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionPreferencias;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionVerMatricula;
        private System.Windows.Forms.ToolStripMenuItem optionPermissoes;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionSuporte;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcaoSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem opcaoPreferencias;
        private System.Windows.Forms.ToolStripMenuItem opcaoVerMatricula;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem opcaoPermissoes;
        private System.Windows.Forms.ToolStripMenuItem opcaoSuporte;
    }
}
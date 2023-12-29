namespace Biblioteca
{
    partial class FUsuario
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUsuario));
            PnSideBar = new Panel();
            PnInfo = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            PnInicio = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            PnHeader = new Panel();
            PbLogo = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            PnInfoPessoais = new Panel();
            LbConfirmacao = new Label();
            LbEmail = new Label();
            LbNomeCompleto = new Label();
            LbSenha = new Label();
            LbNome = new Label();
            LbID = new Label();
            LbOpcao2 = new Label();
            TbConfirmacao = new TextBox();
            TbSenha = new TextBox();
            LbOpcao1 = new Label();
            TbEmail = new TextBox();
            TbNome = new TextBox();
            TbNomeCompleto = new TextBox();
            TbID = new TextBox();
            TmCampos = new System.Windows.Forms.Timer(components);
            PnSideBar.SuspendLayout();
            PnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PnInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            PnInfoPessoais.SuspendLayout();
            SuspendLayout();
            // 
            // PnSideBar
            // 
            PnSideBar.BackColor = Color.Transparent;
            PnSideBar.Controls.Add(PnInfo);
            PnSideBar.Controls.Add(PnInicio);
            PnSideBar.Controls.Add(PnHeader);
            PnSideBar.Dock = DockStyle.Left;
            PnSideBar.Location = new Point(0, 0);
            PnSideBar.Name = "PnSideBar";
            PnSideBar.Size = new Size(247, 526);
            PnSideBar.TabIndex = 0;
            // 
            // PnInfo
            // 
            PnInfo.Controls.Add(label2);
            PnInfo.Controls.Add(pictureBox2);
            PnInfo.Cursor = Cursors.Hand;
            PnInfo.Location = new Point(-38, 128);
            PnInfo.Name = "PnInfo";
            PnInfo.Size = new Size(283, 44);
            PnInfo.TabIndex = 2;
            PnInfo.Click += PnInfo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(16, 16, 16);
            label2.Location = new Point(80, 12);
            label2.Name = "label2";
            label2.Size = new Size(166, 19);
            label2.TabIndex = 1;
            label2.Text = "Informações Pessoais";
            label2.Click += PnInfo_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.personVcard;
            pictureBox2.Location = new Point(50, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += PnInfo_Click;
            // 
            // PnInicio
            // 
            PnInicio.Controls.Add(label1);
            PnInicio.Controls.Add(pictureBox1);
            PnInicio.Cursor = Cursors.Hand;
            PnInicio.Location = new Point(-38, 78);
            PnInicio.Name = "PnInicio";
            PnInicio.Size = new Size(283, 44);
            PnInicio.TabIndex = 1;
            PnInicio.Click += PnInicio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(16, 16, 16);
            label1.Location = new Point(80, 12);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 1;
            label1.Text = "Início";
            label1.Click += PnInicio_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.personCircle;
            pictureBox1.Location = new Point(50, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PnInicio_Click;
            // 
            // PnHeader
            // 
            PnHeader.BackColor = Color.Transparent;
            PnHeader.Controls.Add(PbLogo);
            PnHeader.Dock = DockStyle.Top;
            PnHeader.Location = new Point(0, 0);
            PnHeader.Name = "PnHeader";
            PnHeader.Size = new Size(247, 72);
            PnHeader.TabIndex = 0;
            // 
            // PbLogo
            // 
            PbLogo.Image = Properties.Resources.logoLibraryFilipeMedioPequeno;
            PbLogo.Location = new Point(12, 12);
            PbLogo.Name = "PbLogo";
            PbLogo.Size = new Size(113, 48);
            PbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PbLogo.TabIndex = 0;
            PbLogo.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(247, 109);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(553, 42);
            label3.TabIndex = 1;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.personVcardGrande;
            pictureBox3.Location = new Point(247, 35);
            pictureBox3.Margin = new Padding(12, 0, 12, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(553, 74);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // PnInfoPessoais
            // 
            PnInfoPessoais.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PnInfoPessoais.BackColor = Color.Transparent;
            PnInfoPessoais.Controls.Add(LbConfirmacao);
            PnInfoPessoais.Controls.Add(LbEmail);
            PnInfoPessoais.Controls.Add(LbNomeCompleto);
            PnInfoPessoais.Controls.Add(LbSenha);
            PnInfoPessoais.Controls.Add(LbNome);
            PnInfoPessoais.Controls.Add(LbID);
            PnInfoPessoais.Controls.Add(LbOpcao2);
            PnInfoPessoais.Controls.Add(TbConfirmacao);
            PnInfoPessoais.Controls.Add(TbSenha);
            PnInfoPessoais.Controls.Add(LbOpcao1);
            PnInfoPessoais.Controls.Add(TbEmail);
            PnInfoPessoais.Controls.Add(TbNome);
            PnInfoPessoais.Controls.Add(TbNomeCompleto);
            PnInfoPessoais.Controls.Add(TbID);
            PnInfoPessoais.Location = new Point(283, 175);
            PnInfoPessoais.Margin = new Padding(0);
            PnInfoPessoais.Name = "PnInfoPessoais";
            PnInfoPessoais.Padding = new Padding(36);
            PnInfoPessoais.Size = new Size(481, 315);
            PnInfoPessoais.TabIndex = 2;
            // 
            // LbConfirmacao
            // 
            LbConfirmacao.AutoSize = true;
            LbConfirmacao.BackColor = Color.White;
            LbConfirmacao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LbConfirmacao.ForeColor = Color.FromArgb(60, 60, 80);
            LbConfirmacao.Location = new Point(265, 159);
            LbConfirmacao.Name = "LbConfirmacao";
            LbConfirmacao.Size = new Size(111, 19);
            LbConfirmacao.TabIndex = 17;
            LbConfirmacao.Text = "Confirmar Senha";
            // 
            // LbEmail
            // 
            LbEmail.AutoSize = true;
            LbEmail.BackColor = Color.White;
            LbEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LbEmail.ForeColor = Color.FromArgb(60, 60, 80);
            LbEmail.Location = new Point(265, 93);
            LbEmail.Name = "LbEmail";
            LbEmail.Size = new Size(47, 19);
            LbEmail.TabIndex = 16;
            LbEmail.Text = "E-mail";
            // 
            // LbNomeCompleto
            // 
            LbNomeCompleto.AutoSize = true;
            LbNomeCompleto.BackColor = Color.White;
            LbNomeCompleto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LbNomeCompleto.ForeColor = Color.FromArgb(60, 60, 80);
            LbNomeCompleto.Location = new Point(129, 27);
            LbNomeCompleto.Name = "LbNomeCompleto";
            LbNomeCompleto.Size = new Size(110, 19);
            LbNomeCompleto.TabIndex = 15;
            LbNomeCompleto.Text = "Nome Completo";
            // 
            // LbSenha
            // 
            LbSenha.AutoSize = true;
            LbSenha.BackColor = Color.White;
            LbSenha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LbSenha.ForeColor = Color.FromArgb(60, 60, 80);
            LbSenha.Location = new Point(43, 159);
            LbSenha.Name = "LbSenha";
            LbSenha.Size = new Size(46, 19);
            LbSenha.TabIndex = 14;
            LbSenha.Text = "Senha";
            // 
            // LbNome
            // 
            LbNome.AutoSize = true;
            LbNome.BackColor = Color.White;
            LbNome.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LbNome.ForeColor = Color.FromArgb(60, 60, 80);
            LbNome.Location = new Point(43, 93);
            LbNome.Name = "LbNome";
            LbNome.Size = new Size(46, 19);
            LbNome.TabIndex = 13;
            LbNome.Text = "Nome";
            // 
            // LbID
            // 
            LbID.AutoSize = true;
            LbID.BackColor = Color.White;
            LbID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LbID.ForeColor = Color.FromArgb(60, 60, 80);
            LbID.Location = new Point(43, 27);
            LbID.Name = "LbID";
            LbID.Size = new Size(23, 19);
            LbID.TabIndex = 12;
            LbID.Text = "ID";
            // 
            // LbOpcao2
            // 
            LbOpcao2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LbOpcao2.Cursor = Cursors.Hand;
            LbOpcao2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LbOpcao2.ForeColor = Color.White;
            LbOpcao2.Location = new Point(258, 239);
            LbOpcao2.Margin = new Padding(0);
            LbOpcao2.Name = "LbOpcao2";
            LbOpcao2.Size = new Size(187, 40);
            LbOpcao2.TabIndex = 11;
            LbOpcao2.Text = "Alterar";
            LbOpcao2.TextAlign = ContentAlignment.MiddleCenter;
            LbOpcao2.Click += LbOpcao2_Click;
            // 
            // TbConfirmacao
            // 
            TbConfirmacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbConfirmacao.BackColor = SystemColors.Window;
            TbConfirmacao.BorderStyle = BorderStyle.None;
            TbConfirmacao.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TbConfirmacao.ForeColor = Color.FromArgb(20, 20, 60);
            TbConfirmacao.Location = new Point(268, 178);
            TbConfirmacao.Margin = new Padding(36, 0, 0, 56);
            TbConfirmacao.Name = "TbConfirmacao";
            TbConfirmacao.Size = new Size(167, 20);
            TbConfirmacao.TabIndex = 5;
            TbConfirmacao.Enter += TbEntrada_EnterLeave;
            TbConfirmacao.Leave += TbEntrada_EnterLeave;
            // 
            // TbSenha
            // 
            TbSenha.BackColor = Color.White;
            TbSenha.BorderStyle = BorderStyle.None;
            TbSenha.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TbSenha.ForeColor = Color.FromArgb(20, 20, 60);
            TbSenha.Location = new Point(46, 178);
            TbSenha.Margin = new Padding(0, 0, 0, 56);
            TbSenha.Name = "TbSenha";
            TbSenha.Size = new Size(166, 20);
            TbSenha.TabIndex = 4;
            TbSenha.Enter += TbEntrada_EnterLeave;
            TbSenha.Leave += TbEntrada_EnterLeave;
            // 
            // LbOpcao1
            // 
            LbOpcao1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LbOpcao1.Cursor = Cursors.Hand;
            LbOpcao1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LbOpcao1.ForeColor = Color.FromArgb(17, 96, 170);
            LbOpcao1.Location = new Point(36, 239);
            LbOpcao1.Margin = new Padding(0);
            LbOpcao1.Name = "LbOpcao1";
            LbOpcao1.Size = new Size(186, 40);
            LbOpcao1.TabIndex = 10;
            LbOpcao1.Text = "Cancelar";
            LbOpcao1.TextAlign = ContentAlignment.MiddleCenter;
            LbOpcao1.Click += LbOpcao1_Click;
            // 
            // TbEmail
            // 
            TbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbEmail.BackColor = SystemColors.Window;
            TbEmail.BorderStyle = BorderStyle.None;
            TbEmail.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TbEmail.ForeColor = Color.FromArgb(20, 20, 60);
            TbEmail.Location = new Point(268, 112);
            TbEmail.Margin = new Padding(36, 0, 0, 56);
            TbEmail.Name = "TbEmail";
            TbEmail.Size = new Size(167, 20);
            TbEmail.TabIndex = 3;
            TbEmail.Enter += TbEntrada_EnterLeave;
            TbEmail.Leave += TbEntrada_EnterLeave;
            // 
            // TbNome
            // 
            TbNome.BackColor = Color.White;
            TbNome.BorderStyle = BorderStyle.None;
            TbNome.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TbNome.ForeColor = Color.FromArgb(20, 20, 60);
            TbNome.Location = new Point(46, 112);
            TbNome.Margin = new Padding(0, 0, 0, 56);
            TbNome.Name = "TbNome";
            TbNome.Size = new Size(166, 20);
            TbNome.TabIndex = 2;
            TbNome.Enter += TbEntrada_EnterLeave;
            TbNome.Leave += TbEntrada_EnterLeave;
            // 
            // TbNomeCompleto
            // 
            TbNomeCompleto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbNomeCompleto.BackColor = SystemColors.Window;
            TbNomeCompleto.BorderStyle = BorderStyle.None;
            TbNomeCompleto.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TbNomeCompleto.ForeColor = Color.FromArgb(20, 20, 60);
            TbNomeCompleto.Location = new Point(132, 46);
            TbNomeCompleto.Margin = new Padding(36, 0, 0, 56);
            TbNomeCompleto.Name = "TbNomeCompleto";
            TbNomeCompleto.Size = new Size(303, 20);
            TbNomeCompleto.TabIndex = 1;
            TbNomeCompleto.Enter += TbEntrada_EnterLeave;
            TbNomeCompleto.Leave += TbEntrada_EnterLeave;
            // 
            // TbID
            // 
            TbID.BackColor = Color.White;
            TbID.BorderStyle = BorderStyle.None;
            TbID.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TbID.ForeColor = Color.FromArgb(20, 20, 60);
            TbID.Location = new Point(46, 46);
            TbID.Margin = new Padding(0, 0, 0, 56);
            TbID.Name = "TbID";
            TbID.ReadOnly = true;
            TbID.Size = new Size(30, 20);
            TbID.TabIndex = 0;
            TbID.Enter += TbEntrada_EnterLeave;
            TbID.Leave += TbEntrada_EnterLeave;
            // 
            // TmCampos
            // 
            TmCampos.Enabled = true;
            TmCampos.Interval = 1;
            TmCampos.Tick += TmCampos_Tick;
            // 
            // FUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 526);
            Controls.Add(PnInfoPessoais);
            Controls.Add(label3);
            Controls.Add(PnSideBar);
            Controls.Add(pictureBox3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(816, 565);
            Name = "FUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informações do Usuário";
            FormClosed += FUsuario_FormClosed;
            Load += FUsuario_Load;
            SizeChanged += FUsuario_SizeChanged;
            PnSideBar.ResumeLayout(false);
            PnInfo.ResumeLayout(false);
            PnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PnInicio.ResumeLayout(false);
            PnInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            PnInfoPessoais.ResumeLayout(false);
            PnInfoPessoais.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnSideBar;
        private Panel PnHeader;
        private PictureBox PbLogo;
        private Panel PnInicio;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel PnInfo;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private Panel PnInfoPessoais;
        private TextBox TbID;
        private TextBox TbNomeCompleto;
        private TextBox TbEmail;
        private TextBox TbNome;
        private TextBox TbConfirmacao;
        private TextBox TbSenha;
        private Label LbOpcao2;
        private Label LbOpcao1;
        private Label LbID;
        private Label LbSenha;
        private Label LbNome;
        private Label LbConfirmacao;
        private Label LbEmail;
        private Label LbNomeCompleto;
        private System.Windows.Forms.Timer TmCampos;
    }
}
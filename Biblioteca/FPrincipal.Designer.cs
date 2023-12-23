namespace Biblioteca
{
    partial class FPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrincipal));
            LbDireitosAutorais = new Label();
            PbLogo = new PictureBox();
            TbPesquisa = new TextBox();
            BtnPesquisar = new Label();
            BtnLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)PbLogo).BeginInit();
            SuspendLayout();
            // 
            // LbDireitosAutorais
            // 
            LbDireitosAutorais.Dock = DockStyle.Bottom;
            LbDireitosAutorais.ForeColor = Color.FromArgb(60, 60, 80);
            LbDireitosAutorais.Location = new Point(0, 411);
            LbDireitosAutorais.Name = "LbDireitosAutorais";
            LbDireitosAutorais.Size = new Size(800, 30);
            LbDireitosAutorais.TabIndex = 6;
            LbDireitosAutorais.Text = "Copyright (c) 2023 Filipe Emanuel Macarini Roco";
            LbDireitosAutorais.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PbLogo
            // 
            PbLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PbLogo.BackgroundImage = Properties.Resources.logoLibraryFilipeGrande;
            PbLogo.BackgroundImageLayout = ImageLayout.Center;
            PbLogo.Location = new Point(9, 80);
            PbLogo.Margin = new Padding(0);
            PbLogo.MinimumSize = new Size(286, 127);
            PbLogo.Name = "PbLogo";
            PbLogo.Size = new Size(782, 127);
            PbLogo.TabIndex = 2;
            PbLogo.TabStop = false;
            // 
            // TbPesquisa
            // 
            TbPesquisa.Anchor = AnchorStyles.Top;
            TbPesquisa.BackColor = Color.White;
            TbPesquisa.BorderStyle = BorderStyle.None;
            TbPesquisa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TbPesquisa.ForeColor = Color.FromArgb(20, 20, 60);
            TbPesquisa.Location = new Point(85, 218);
            TbPesquisa.Margin = new Padding(6);
            TbPesquisa.Name = "TbPesquisa";
            TbPesquisa.PlaceholderText = "Coloque o nome do livro aqui";
            TbPesquisa.Size = new Size(568, 18);
            TbPesquisa.TabIndex = 3;
            TbPesquisa.WordWrap = false;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.BackColor = Color.Transparent;
            BtnPesquisar.Cursor = Cursors.Hand;
            BtnPesquisar.Image = Properties.Resources.iconeLupaPesquisar;
            BtnPesquisar.Location = new Point(665, 218);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(50, 25);
            BtnPesquisar.TabIndex = 7;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnLogin.BackColor = Color.Transparent;
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(688, 12);
            BtnLogin.Margin = new Padding(6);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(100, 33);
            BtnLogin.TabIndex = 8;
            BtnLogin.Text = "Login";
            BtnLogin.TextAlign = ContentAlignment.MiddleCenter;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // FPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 441);
            Controls.Add(BtnLogin);
            Controls.Add(BtnPesquisar);
            Controls.Add(LbDireitosAutorais);
            Controls.Add(PbLogo);
            Controls.Add(TbPesquisa);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(400, 480);
            Name = "FPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca - Library Filipe";
            SizeChanged += FPrincipal_SizeChanged;
            Resize += FPrincipal_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)PbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LbDireitosAutorais;
        private PictureBox PbLogo;
        private TextBox TbPesquisa;
        public Bitmap BackgroundImageIncial;
        private Label BtnPesquisar;
        private Label BtnLogin;
    }
}
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
            BtnLogin = new Button();
            LbDireitosAutorais = new Label();
            PbLogo = new PictureBox();
            TbPesquisa = new TextBox();
            BtnPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)PbLogo).BeginInit();
            SuspendLayout();
            // 
            // BtnLogin
            // 
            BtnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnLogin.BackColor = Color.FromArgb(60, 128, 238);
            BtnLogin.BackgroundImageLayout = ImageLayout.None;
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(685, 12);
            BtnLogin.Margin = new Padding(12);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(100, 33);
            BtnLogin.TabIndex = 1;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // LbDireitosAutorais
            // 
            LbDireitosAutorais.Dock = DockStyle.Bottom;
            LbDireitosAutorais.ForeColor = Color.FromArgb(64, 64, 64);
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
            PbLogo.Location = new Point(12, 80);
            PbLogo.MinimumSize = new Size(286, 127);
            PbLogo.Name = "PbLogo";
            PbLogo.Size = new Size(776, 127);
            PbLogo.TabIndex = 2;
            PbLogo.TabStop = false;
            // 
            // TbPesquisa
            // 
            TbPesquisa.BackColor = Color.White;
            TbPesquisa.BorderStyle = BorderStyle.FixedSingle;
            TbPesquisa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TbPesquisa.ForeColor = Color.FromArgb(64, 64, 64);
            TbPesquisa.Location = new Point(80, 215);
            TbPesquisa.Margin = new Padding(6);
            TbPesquisa.Name = "TbPesquisa";
            TbPesquisa.PlaceholderText = "Coloque o nome do livro aqui";
            TbPesquisa.Size = new Size(578, 25);
            TbPesquisa.TabIndex = 3;
            TbPesquisa.WordWrap = false;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Anchor = AnchorStyles.Top;
            BtnPesquisar.BackColor = Color.FromArgb(60, 128, 238);
            BtnPesquisar.BackgroundImage = Properties.Resources.iconeLupaPesquisar;
            BtnPesquisar.BackgroundImageLayout = ImageLayout.Center;
            BtnPesquisar.Cursor = Cursors.Hand;
            BtnPesquisar.FlatAppearance.BorderSize = 0;
            BtnPesquisar.FlatStyle = FlatStyle.Flat;
            BtnPesquisar.Location = new Point(670, 215);
            BtnPesquisar.Margin = new Padding(6);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(50, 25);
            BtnPesquisar.TabIndex = 4;
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // FPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 441);
            Controls.Add(BtnPesquisar);
            Controls.Add(LbDireitosAutorais);
            Controls.Add(PbLogo);
            Controls.Add(BtnLogin);
            Controls.Add(TbPesquisa);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(400, 480);
            Name = "FPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca - Library Filipe";
            SizeChanged += FPrincipal_SizeChanged;
            Paint += FPrincipal_Paint;
            Resize += FPrincipal_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)PbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnLogin;
        private Label LbDireitosAutorais;
        private PictureBox PbLogo;
        private TextBox TbPesquisa;
        private Button BtnPesquisar;
    }
}
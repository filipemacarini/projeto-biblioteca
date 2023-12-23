namespace Biblioteca
{
    partial class FUserInfo
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
            PbLogo = new PictureBox();
            PnConta = new Panel();
            LbTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)PbLogo).BeginInit();
            PnConta.SuspendLayout();
            SuspendLayout();
            // 
            // PbLogo
            // 
            PbLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PbLogo.BackgroundImage = Properties.Resources.logoLibraryFilipeMedioPequeno;
            PbLogo.BackgroundImageLayout = ImageLayout.Zoom;
            PbLogo.Location = new Point(0, 36);
            PbLogo.Margin = new Padding(0);
            PbLogo.Name = "PbLogo";
            PbLogo.Size = new Size(450, 37);
            PbLogo.TabIndex = 0;
            PbLogo.TabStop = false;
            // 
            // PnConta
            // 
            PnConta.Anchor = AnchorStyles.Top;
            PnConta.BackColor = Color.Transparent;
            PnConta.Controls.Add(LbTitulo);
            PnConta.Controls.Add(PbLogo);
            PnConta.Location = new Point(36, 36);
            PnConta.Name = "PnConta";
            PnConta.Size = new Size(450, 500);
            PnConta.TabIndex = 1;
            // 
            // LbTitulo
            // 
            LbTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LbTitulo.Font = new Font("Noto Sans", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Location = new Point(0, 77);
            LbTitulo.Margin = new Padding(3, 20, 3, 0);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(450, 36);
            LbTitulo.TabIndex = 4;
            LbTitulo.Text = "Fazer login";
            LbTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // FUserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(522, 576);
            Controls.Add(PnConta);
            MinimumSize = new Size(538, 615);
            Name = "FUserInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informações do Usuário";
            ((System.ComponentModel.ISupportInitialize)PbLogo).EndInit();
            PnConta.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PbLogo;
        private Panel PnConta;
        private Label LbTitulo;
    }
}
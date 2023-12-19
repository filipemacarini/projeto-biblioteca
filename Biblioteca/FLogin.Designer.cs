namespace Biblioteca
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            PnConta = new Panel();
            BtnNegar = new Button();
            LbEsqueceu = new Label();
            LbTitulo = new Label();
            LbTipo = new Label();
            TbEntrada = new TextBox();
            pictureBox1 = new PictureBox();
            PnConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PnConta
            // 
            PnConta.Anchor = AnchorStyles.Top;
            PnConta.BackColor = Color.Transparent;
            PnConta.Controls.Add(BtnNegar);
            PnConta.Controls.Add(LbEsqueceu);
            PnConta.Controls.Add(LbTitulo);
            PnConta.Controls.Add(LbTipo);
            PnConta.Controls.Add(TbEntrada);
            PnConta.Controls.Add(pictureBox1);
            PnConta.Location = new Point(36, 36);
            PnConta.Name = "PnConta";
            PnConta.Size = new Size(450, 500);
            PnConta.TabIndex = 0;
            // 
            // BtnNegar
            // 
            BtnNegar.BackColor = Color.Transparent;
            BtnNegar.FlatAppearance.BorderSize = 0;
            BtnNegar.FlatStyle = FlatStyle.Flat;
            BtnNegar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnNegar.ForeColor = FormatacoesPadrao.CorPadraoCinza;
            BtnNegar.Location = new Point(36, 441);
            BtnNegar.Margin = new Padding(36);
            BtnNegar.Name = "BtnNegar";
            BtnNegar.Size = new Size(171, 33);
            BtnNegar.TabIndex = 6;
            BtnNegar.Text = "Voltar";
            BtnNegar.UseVisualStyleBackColor = false;
            // 
            // LbEsqueceu
            // 
            LbEsqueceu.AutoSize = true;
            LbEsqueceu.Font = new Font("Noto Sans", 10.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            LbEsqueceu.ForeColor = Color.FromArgb(27, 102, 201);
            LbEsqueceu.Location = new Point(32, 210);
            LbEsqueceu.Margin = new Padding(36, 0, 3, 0);
            LbEsqueceu.Name = "LbEsqueceu";
            LbEsqueceu.Size = new Size(154, 22);
            LbEsqueceu.TabIndex = 5;
            LbEsqueceu.Text = "Esqueceu seu nome?";
            LbEsqueceu.Click += LbEsqueceu_Click;
            // 
            // LbTitulo
            // 
            LbTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LbTitulo.Font = new Font("Noto Sans", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Location = new Point(0, 96);
            LbTitulo.Margin = new Padding(3, 20, 3, 0);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(450, 36);
            LbTitulo.TabIndex = 4;
            LbTitulo.Text = "Fazer login";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LbTipo
            // 
            LbTipo.AutoSize = true;
            LbTipo.BackColor = Color.White;
            LbTipo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LbTipo.ForeColor = Color.FromArgb(60, 60, 80);
            LbTipo.Location = new Point(48, 143);
            LbTipo.Name = "LbTipo";
            LbTipo.Size = new Size(46, 19);
            LbTipo.TabIndex = 3;
            LbTipo.Text = "Nome";
            // 
            // TbEntrada
            // 
            TbEntrada.BackColor = Color.White;
            TbEntrada.BorderStyle = BorderStyle.None;
            TbEntrada.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TbEntrada.ForeColor = Color.FromArgb(20, 20, 60);
            TbEntrada.Location = new Point(53, 168);
            TbEntrada.Margin = new Padding(36);
            TbEntrada.Name = "TbEntrada";
            TbEntrada.Size = new Size(344, 20);
            TbEntrada.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = Properties.Resources.logoLibraryFilipeMedioPequeno;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 37);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(522, 576);
            Controls.Add(PnConta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(538, 615);
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conta";
            SizeChanged += FLogin_SizeChanged;
            PnConta.ResumeLayout(false);
            PnConta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnConta;
        private PictureBox pictureBox1;
        private TextBox TbEntrada;
        private Label LbTipo;
        private Label LbTitulo;
        private Label LbEsqueceu;
        private Button BtnNegar;
    }
}
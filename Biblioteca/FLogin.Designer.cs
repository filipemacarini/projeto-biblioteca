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
            LbUsuario = new Label();
            PbAlerta = new PictureBox();
            LbAlerta = new Label();
            LbOpcao2 = new Label();
            LbOpcao1 = new Label();
            LbEsqueceu = new Label();
            LbTitulo = new Label();
            LbTipo = new Label();
            TbEntrada = new TextBox();
            pictureBox1 = new PictureBox();
            LbMensagem = new Label();
            PnConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbAlerta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PnConta
            // 
            PnConta.Anchor = AnchorStyles.Top;
            PnConta.BackColor = Color.Transparent;
            PnConta.Controls.Add(LbUsuario);
            PnConta.Controls.Add(PbAlerta);
            PnConta.Controls.Add(LbAlerta);
            PnConta.Controls.Add(LbOpcao2);
            PnConta.Controls.Add(LbOpcao1);
            PnConta.Controls.Add(LbEsqueceu);
            PnConta.Controls.Add(LbTitulo);
            PnConta.Controls.Add(LbTipo);
            PnConta.Controls.Add(TbEntrada);
            PnConta.Controls.Add(pictureBox1);
            PnConta.Controls.Add(LbMensagem);
            PnConta.Location = new Point(36, 36);
            PnConta.Name = "PnConta";
            PnConta.Size = new Size(450, 500);
            PnConta.TabIndex = 0;
            // 
            // LbUsuario
            // 
            LbUsuario.AutoSize = true;
            LbUsuario.Font = new Font("Noto Sans", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            LbUsuario.Location = new Point(205, 142);
            LbUsuario.Name = "LbUsuario";
            LbUsuario.Size = new Size(52, 23);
            LbUsuario.TabIndex = 13;
            LbUsuario.Text = "label1";
            LbUsuario.Visible = false;
            // 
            // PbAlerta
            // 
            PbAlerta.BackgroundImageLayout = ImageLayout.Stretch;
            PbAlerta.Image = Properties.Resources.iconeAlertaPequeno;
            PbAlerta.Location = new Point(38, 249);
            PbAlerta.Name = "PbAlerta";
            PbAlerta.Size = new Size(16, 16);
            PbAlerta.TabIndex = 11;
            PbAlerta.TabStop = false;
            // 
            // LbAlerta
            // 
            LbAlerta.AutoSize = true;
            LbAlerta.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            LbAlerta.ForeColor = Color.FromArgb(217, 48, 37);
            LbAlerta.Location = new Point(55, 250);
            LbAlerta.Name = "LbAlerta";
            LbAlerta.Size = new Size(92, 13);
            LbAlerta.TabIndex = 10;
            LbAlerta.Text = "Digite seu Nome";
            // 
            // LbOpcao2
            // 
            LbOpcao2.Cursor = Cursors.Hand;
            LbOpcao2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LbOpcao2.ForeColor = Color.White;
            LbOpcao2.Location = new Point(243, 419);
            LbOpcao2.Margin = new Padding(36);
            LbOpcao2.Name = "LbOpcao2";
            LbOpcao2.Size = new Size(171, 45);
            LbOpcao2.TabIndex = 9;
            LbOpcao2.Text = "Opção 2";
            LbOpcao2.TextAlign = ContentAlignment.MiddleCenter;
            LbOpcao2.Click += LbOpcao2_Click;
            // 
            // LbOpcao1
            // 
            LbOpcao1.Cursor = Cursors.Hand;
            LbOpcao1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LbOpcao1.ForeColor = Color.FromArgb(17, 96, 170);
            LbOpcao1.Location = new Point(36, 419);
            LbOpcao1.Margin = new Padding(36);
            LbOpcao1.Name = "LbOpcao1";
            LbOpcao1.Size = new Size(171, 45);
            LbOpcao1.TabIndex = 8;
            LbOpcao1.Text = "Voltar";
            LbOpcao1.TextAlign = ContentAlignment.MiddleCenter;
            LbOpcao1.Click += LbOpcao1_Click;
            // 
            // LbEsqueceu
            // 
            LbEsqueceu.AutoSize = true;
            LbEsqueceu.Cursor = Cursors.Hand;
            LbEsqueceu.Font = new Font("Noto Sans", 10.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            LbEsqueceu.ForeColor = Color.FromArgb(27, 102, 201);
            LbEsqueceu.Location = new Point(264, 250);
            LbEsqueceu.Margin = new Padding(36, 0, 36, 0);
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
            LbTitulo.Size = new Size(450, 69);
            LbTitulo.TabIndex = 4;
            LbTitulo.Text = "Fazer login";
            LbTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // LbTipo
            // 
            LbTipo.AutoSize = true;
            LbTipo.BackColor = Color.White;
            LbTipo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LbTipo.ForeColor = Color.FromArgb(60, 60, 80);
            LbTipo.Location = new Point(48, 183);
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
            TbEntrada.Location = new Point(53, 208);
            TbEntrada.Margin = new Padding(36);
            TbEntrada.Name = "TbEntrada";
            TbEntrada.Size = new Size(344, 20);
            TbEntrada.TabIndex = 2;
            TbEntrada.KeyDown += TbEntrada_KeyDown;
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
            // LbMensagem
            // 
            LbMensagem.ForeColor = Color.FromArgb(60, 60, 80);
            LbMensagem.Location = new Point(36, 271);
            LbMensagem.Margin = new Padding(36);
            LbMensagem.Name = "LbMensagem";
            LbMensagem.Padding = new Padding(20, 0, 20, 0);
            LbMensagem.Size = new Size(378, 49);
            LbMensagem.TabIndex = 7;
            LbMensagem.Text = "Digite seu e-mail acima. Caso o e-mail estiver certo, será enviado para seu e-mail, uma mensagem contendo seus dados pessoais.";
            LbMensagem.TextAlign = ContentAlignment.TopCenter;
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
            FormClosed += FLogin_FormClosed;
            SizeChanged += FLogin_SizeChanged;
            PnConta.ResumeLayout(false);
            PnConta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbAlerta).EndInit();
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
        private Label LbMensagem;
        private Label LbOpcao2;
        private Label LbOpcao1;
        private Label LbAlerta;
        private PictureBox PbAlerta;
        private Button button1;
        private Label LbUsuario;
    }
}
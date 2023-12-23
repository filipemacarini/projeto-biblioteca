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
            PbAlerta3 = new PictureBox();
            LbAlerta3 = new Label();
            PbAlerta2 = new PictureBox();
            LbAlerta2 = new Label();
            LbTipo3 = new Label();
            TbEntrada3 = new TextBox();
            LbTipo2 = new Label();
            TbEntrada2 = new TextBox();
            PbAlerta = new PictureBox();
            LbUsuario = new Label();
            LbAlerta = new Label();
            LbOpcao2 = new Label();
            LbOpcao1 = new Label();
            LbEsqueceu = new Label();
            LbTitulo = new Label();
            LbTipo = new Label();
            LbMensagem = new Label();
            PbLogo = new PictureBox();
            TbEntrada = new TextBox();
            PnConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbAlerta3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbAlerta2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbAlerta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbLogo).BeginInit();
            SuspendLayout();
            // 
            // PnConta
            // 
            PnConta.Anchor = AnchorStyles.Top;
            PnConta.BackColor = Color.Transparent;
            PnConta.Controls.Add(PbAlerta3);
            PnConta.Controls.Add(LbAlerta3);
            PnConta.Controls.Add(PbAlerta2);
            PnConta.Controls.Add(LbAlerta2);
            PnConta.Controls.Add(LbTipo3);
            PnConta.Controls.Add(TbEntrada3);
            PnConta.Controls.Add(LbTipo2);
            PnConta.Controls.Add(TbEntrada2);
            PnConta.Controls.Add(PbAlerta);
            PnConta.Controls.Add(LbUsuario);
            PnConta.Controls.Add(LbAlerta);
            PnConta.Controls.Add(LbOpcao2);
            PnConta.Controls.Add(LbOpcao1);
            PnConta.Controls.Add(LbEsqueceu);
            PnConta.Controls.Add(LbTitulo);
            PnConta.Controls.Add(LbTipo);
            PnConta.Controls.Add(LbMensagem);
            PnConta.Controls.Add(PbLogo);
            PnConta.Controls.Add(TbEntrada);
            PnConta.Location = new Point(36, 36);
            PnConta.Name = "PnConta";
            PnConta.Size = new Size(450, 500);
            PnConta.TabIndex = 0;
            // 
            // PbAlerta3
            // 
            PbAlerta3.BackgroundImageLayout = ImageLayout.Stretch;
            PbAlerta3.Image = Properties.Resources.iconeAlertaPequeno;
            PbAlerta3.Location = new Point(38, 373);
            PbAlerta3.Name = "PbAlerta3";
            PbAlerta3.Size = new Size(16, 16);
            PbAlerta3.TabIndex = 21;
            PbAlerta3.TabStop = false;
            // 
            // LbAlerta3
            // 
            LbAlerta3.AutoSize = true;
            LbAlerta3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            LbAlerta3.ForeColor = Color.FromArgb(217, 48, 37);
            LbAlerta3.Location = new Point(55, 385);
            LbAlerta3.Name = "LbAlerta3";
            LbAlerta3.Size = new Size(92, 13);
            LbAlerta3.TabIndex = 20;
            LbAlerta3.Text = "Digite seu Nome";
            // 
            // PbAlerta2
            // 
            PbAlerta2.BackgroundImageLayout = ImageLayout.Stretch;
            PbAlerta2.Image = Properties.Resources.iconeAlertaPequeno;
            PbAlerta2.Location = new Point(38, 303);
            PbAlerta2.Name = "PbAlerta2";
            PbAlerta2.Size = new Size(16, 16);
            PbAlerta2.TabIndex = 19;
            PbAlerta2.TabStop = false;
            // 
            // LbAlerta2
            // 
            LbAlerta2.AutoSize = true;
            LbAlerta2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            LbAlerta2.ForeColor = Color.FromArgb(217, 48, 37);
            LbAlerta2.Location = new Point(55, 304);
            LbAlerta2.Name = "LbAlerta2";
            LbAlerta2.Size = new Size(92, 13);
            LbAlerta2.TabIndex = 18;
            LbAlerta2.Text = "Digite seu Nome";
            // 
            // LbTipo3
            // 
            LbTipo3.AutoSize = true;
            LbTipo3.BackColor = Color.White;
            LbTipo3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LbTipo3.ForeColor = Color.FromArgb(60, 60, 80);
            LbTipo3.Location = new Point(48, 318);
            LbTipo3.Name = "LbTipo3";
            LbTipo3.Size = new Size(47, 19);
            LbTipo3.TabIndex = 17;
            LbTipo3.Text = "E-mail";
            LbTipo3.Visible = false;
            // 
            // TbEntrada3
            // 
            TbEntrada3.BackColor = Color.White;
            TbEntrada3.BorderStyle = BorderStyle.None;
            TbEntrada3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TbEntrada3.ForeColor = Color.FromArgb(20, 20, 60);
            TbEntrada3.Location = new Point(53, 343);
            TbEntrada3.Margin = new Padding(36);
            TbEntrada3.Name = "TbEntrada3";
            TbEntrada3.Size = new Size(344, 20);
            TbEntrada3.TabIndex = 16;
            TbEntrada3.Visible = false;
            TbEntrada3.KeyDown += TbEntrada3_KeyDown;
            // 
            // LbTipo2
            // 
            LbTipo2.AutoSize = true;
            LbTipo2.BackColor = Color.White;
            LbTipo2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LbTipo2.ForeColor = Color.FromArgb(60, 60, 80);
            LbTipo2.Location = new Point(48, 237);
            LbTipo2.Name = "LbTipo2";
            LbTipo2.Size = new Size(110, 19);
            LbTipo2.TabIndex = 15;
            LbTipo2.Text = "Nome Completo";
            LbTipo2.Visible = false;
            // 
            // TbEntrada2
            // 
            TbEntrada2.BackColor = Color.White;
            TbEntrada2.BorderStyle = BorderStyle.None;
            TbEntrada2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TbEntrada2.ForeColor = Color.FromArgb(20, 20, 60);
            TbEntrada2.Location = new Point(53, 262);
            TbEntrada2.Margin = new Padding(36);
            TbEntrada2.Name = "TbEntrada2";
            TbEntrada2.Size = new Size(344, 20);
            TbEntrada2.TabIndex = 14;
            TbEntrada2.Visible = false;
            TbEntrada2.KeyDown += TbEntrada2_KeyDown;
            // 
            // PbAlerta
            // 
            PbAlerta.BackgroundImageLayout = ImageLayout.Stretch;
            PbAlerta.Image = Properties.Resources.iconeAlertaPequeno;
            PbAlerta.Location = new Point(38, 222);
            PbAlerta.Name = "PbAlerta";
            PbAlerta.Size = new Size(16, 16);
            PbAlerta.TabIndex = 11;
            PbAlerta.TabStop = false;
            // 
            // LbUsuario
            // 
            LbUsuario.AutoSize = true;
            LbUsuario.Font = new Font("Noto Sans", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            LbUsuario.Location = new Point(197, 113);
            LbUsuario.Name = "LbUsuario";
            LbUsuario.Size = new Size(52, 23);
            LbUsuario.TabIndex = 13;
            LbUsuario.Text = "label1";
            LbUsuario.Visible = false;
            // 
            // LbAlerta
            // 
            LbAlerta.AutoSize = true;
            LbAlerta.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            LbAlerta.ForeColor = Color.FromArgb(217, 48, 37);
            LbAlerta.Location = new Point(55, 223);
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
            LbEsqueceu.Location = new Point(264, 223);
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
            LbTitulo.Location = new Point(0, 77);
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
            LbTipo.Location = new Point(48, 156);
            LbTipo.Name = "LbTipo";
            LbTipo.Size = new Size(46, 19);
            LbTipo.TabIndex = 3;
            LbTipo.Text = "Nome";
            // 
            // LbMensagem
            // 
            LbMensagem.ForeColor = Color.FromArgb(60, 60, 80);
            LbMensagem.Location = new Point(36, 259);
            LbMensagem.Margin = new Padding(36);
            LbMensagem.Name = "LbMensagem";
            LbMensagem.Padding = new Padding(20, 0, 20, 0);
            LbMensagem.Size = new Size(378, 63);
            LbMensagem.TabIndex = 7;
            LbMensagem.Text = "Digite seu e-mail acima. Caso o e-mail estiver certo, será enviado para seu e-mail, uma mensagem contendo seus dados pessoais. Nota: Não funciona, por motivos de segurança.";
            LbMensagem.TextAlign = ContentAlignment.TopCenter;
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
            // TbEntrada
            // 
            TbEntrada.BackColor = Color.White;
            TbEntrada.BorderStyle = BorderStyle.None;
            TbEntrada.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TbEntrada.ForeColor = Color.FromArgb(20, 20, 60);
            TbEntrada.Location = new Point(53, 181);
            TbEntrada.Margin = new Padding(36);
            TbEntrada.Name = "TbEntrada";
            TbEntrada.Size = new Size(344, 20);
            TbEntrada.TabIndex = 2;
            TbEntrada.KeyDown += TbEntrada_KeyDown;
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
            ((System.ComponentModel.ISupportInitialize)PbAlerta3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbAlerta2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbAlerta).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnConta;
        private PictureBox PbLogo;
        private TextBox TbEntrada;
        private Label LbTipo;
        private Label LbTitulo;
        private Label LbEsqueceu;
        private Label LbMensagem;
        private Label LbOpcao2;
        private Label LbOpcao1;
        private Label LbAlerta;
        private Button button1;
        private Label LbUsuario;
        private PictureBox PbAlerta;
        private Label LbTipo3;
        private TextBox TbEntrada3;
        private Label LbTipo2;
        private TextBox TbEntrada2;
        private PictureBox PbAlerta2;
        private Label LbAlerta2;
        private PictureBox PbAlerta3;
        private Label LbAlerta3;
    }
}
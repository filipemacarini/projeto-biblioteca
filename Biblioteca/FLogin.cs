using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Biblioteca
{
    public partial class FLogin : Form
    {
        private Borda BordaPnConta { get; set; }
        private Borda BordaTbEntrada { get; set; }
        private Borda BordaTbEntrada2 { get; set; }
        private Borda BordaTbEntrada3 { get; set; }
        private Color CorTema1 { get; set; }
        private Color CorTema2 { get; set; }
        private Color CorTemaTipo { get; set; }
        private Color CorTemaTipo2 { get; set; }
        private Color CorTemaTipo3 { get; set; }
        private bool ErroTbEntrada { get; set; }
        private bool ErroTbEntrada2 { get; set; }
        private bool ErroTbEntrada3 { get; set; }
        private Bitmap BackgroundOriginal { get; set; }
        private Borda BordaLbOpcao1 { get; set; }
        private Borda BordaLbOpcao2 { get; set; }
        private Borda[] Bordas { get; set; }
        private byte Tela { get; set; }
        private Borda BordaLbUsuario { get; set; }
        private Color CorBordaLbUsuario { get; set; }
        private DataTable Usuario { get; set; }
        private Usuario NovoUsuario { get; set; }

        public FLogin()
        {
            InitializeComponent();

            BackgroundImage = new Bitmap(ClientSize.Width, ClientSize.Height);
            BackgroundOriginal = new Bitmap(BackgroundImage);
            CorTema1 = FormatacoesPadrao.CorPadraoBorda;
            CorTema2 = FormatacoesPadrao.CorPadraoAzul;
            CorTemaTipo = FormatacoesPadrao.CorPadraoCinza;
            CorBordaLbUsuario = Color.White;
            ErroTbEntrada = false;

            MudarParaNome();

            // Eventos de Foco
            TbEntrada.Enter += (sender, e) => { BordaTbEntrada.Focused = true; DesenharBordas(); CorTemaTipo = ErroTbEntrada ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoAzul; LbTipo.ForeColor = CorTemaTipo; };
            TbEntrada.Leave += (sender, e) => { BordaTbEntrada.Focused = false; DesenharBordas(); CorTemaTipo = ErroTbEntrada ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoCinza; LbTipo.ForeColor = CorTemaTipo; };

            TbEntrada2.Enter += (sender, e) => { BordaTbEntrada2.Focused = true; DesenharBordas(); CorTemaTipo2 = ErroTbEntrada2 ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoAzul; LbTipo2.ForeColor = CorTemaTipo2; };
            TbEntrada2.Leave += (sender, e) => { BordaTbEntrada2.Focused = false; DesenharBordas(); CorTemaTipo2 = ErroTbEntrada2 ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoCinza; LbTipo2.ForeColor = CorTemaTipo2; };

            TbEntrada3.Enter += (sender, e) => { BordaTbEntrada3.Focused = true; DesenharBordas(); CorTemaTipo3 = ErroTbEntrada3 ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoAzul; LbTipo3.ForeColor = CorTemaTipo3; };
            TbEntrada3.Leave += (sender, e) => { BordaTbEntrada3.Focused = false; DesenharBordas(); CorTemaTipo3 = ErroTbEntrada3 ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoCinza; LbTipo3.ForeColor = CorTemaTipo3; };

            AtualizarLayout();

            //LbOpcao1.MouseEnter += (sender, e) => { BordaLbOpcao1.Focused = true; DesenharBordas(); };
            //LbOpcao1.MouseLeave += (sender, e) => { BordaLbOpcao2.Focused = false; DesenharBordas(); };
        }

        // Funções de atualização do layout
        private void InicializarBordas()
        {
            // Cria as bordas
            BordaPnConta = new Borda(PnConta, new int[] { 0, 0 }, FormatacoesPadrao.CorPadraoBorda, FormatacoesPadrao.CorPadraoAzul, Color.White, 1, 10);
            BordaLbOpcao1 = new Borda(LbOpcao1, new int[] { 0, 0 }, FormatacoesPadrao.CorPadraoBorda, FormatacoesPadrao.CorPadraoAzul, Color.White);
            BordaLbOpcao2 = new Borda(LbOpcao2, new int[] { 0, 0 }, FormatacoesPadrao.CorPadraoAzul, FormatacoesPadrao.CorPadraoAzul, FormatacoesPadrao.CorPadraoAzul);
            Bordas = new Borda[] { BordaPnConta, BordaLbOpcao1, BordaLbOpcao2 };
            CorTema2 = ErroTbEntrada ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoAzul;
            CorTema1 = ErroTbEntrada ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoBorda;
            BordaTbEntrada = new Borda(TbEntrada, new int[] { 16, 16 }, CorTema1, CorTema2, Color.White);

            CorTema2 = ErroTbEntrada2 ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoAzul;
            CorTema1 = ErroTbEntrada2 ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoBorda;
            if (Tela < 4) { CorTema1 = Color.White; }
            BordaTbEntrada2 = new Borda(TbEntrada2, new int[] { 16, 16 }, CorTema1, CorTema2, Color.White);

            CorTema2 = ErroTbEntrada3 ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoAzul;
            CorTema1 = ErroTbEntrada3 ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoBorda;
            if (Tela != 4) { CorTema1 = Color.White; }
            BordaTbEntrada3 = new Borda(TbEntrada3, new int[] { 16, 16 }, CorTema1, CorTema2, Color.White);

            CorTema1 = FormatacoesPadrao.CorPadraoBorda;
            BordaLbUsuario = new Borda(LbUsuario, new int[] { 10, 3 }, CorBordaLbUsuario, CorBordaLbUsuario, Color.White);
            Bordas = new Borda[] { BordaPnConta, BordaTbEntrada, BordaTbEntrada2, BordaTbEntrada3, BordaLbOpcao1, BordaLbOpcao2, BordaLbUsuario };
        }

        private void DesenharBordas()
        {
            Borda.DesenharBordas(Bordas, this, BackgroundOriginal);
        }

        private void AtualizarLayout()
        {
            PnConta.Location = new Point((ClientSize.Width - PnConta.Width) / 2, PnConta.Location.Y);

            // Cria e Desenha as Bordas
            InicializarBordas();
            DesenharBordas();
            Invalidate();
        }

        private void FLogin_SizeChanged(object sender, EventArgs e)
        {
            AtualizarLayout();
        }
        // Fim

        // Funções da tela 1
        private void LbEsqueceu_Click(object sender, EventArgs e)
        {
            MudarParaRecuperacao();
        }

        private void MudarParaNome()
        {
            EsconderAlertas();
            TbEntrada.Clear();
            TbEntrada.Focus();
            LbTipo2.Visible = false;
            LbTipo3.Visible = false;
            TbEntrada2.Visible = false;
            TbEntrada3.Visible = false;
            CorTemaTipo = FormatacoesPadrao.CorPadraoAzul;
            LbTipo.ForeColor = CorTemaTipo;
            LbTipo.Text = "Nome";
            BordaTbEntrada.Focused = true;
            LbTitulo.Text = "Fazer login";
            LbUsuario.Visible = false;
            LbEsqueceu.Visible = true;
            LbMensagem.Visible = false;
            LbAlerta.Visible = false;
            LbOpcao1.Text = "Criar conta";
            LbOpcao2.Text = "Avançar";
            CorBordaLbUsuario = Color.White;
            PbAlerta.Visible = false;
            Tela = 1;
            InicializarBordas();
            DesenharBordas();
        }
        // Fim

        // Funcões da tela 2
        private void MudarParaSenha(DataRow usuario)
        {
            EsconderAlertas();
            TbEntrada.Clear();
            TbEntrada.Focus();
            CorTemaTipo = FormatacoesPadrao.CorPadraoAzul;
            LbTipo.ForeColor = CorTemaTipo;
            LbUsuario.Visible = true;
            LbUsuario.Text = usuario[4].ToString();
            LbUsuario.Location = new Point((450 - LbUsuario.Width) / 2, LbUsuario.Location.Y);
            CorBordaLbUsuario = FormatacoesPadrao.CorPadraoBorda;
            LbTitulo.Text = usuario[3].ToString();
            LbTipo.Text = "Senha";
            LbOpcao1.Text = "Voltar";
            LbOpcao2.Text = "Entrar";
            LbEsqueceu.Text = "Esqueceu sua senha?";
            LbEsqueceu.Visible = true;
            LbMensagem.Visible = false;
            PbAlerta.Visible = false;
            LbAlerta.Visible = false;
            Tela = 2;
            InicializarBordas();
            DesenharBordas();
        }
        // Fim

        // Funções da tela 3
        private void MudarParaRecuperacao()
        {
            EsconderAlertas();
            LbTitulo.Text = "Recuperar dados";
            TbEntrada.Focus();
            CorTemaTipo = FormatacoesPadrao.CorPadraoAzul;
            LbTipo.ForeColor = CorTemaTipo;
            TbEntrada.Clear();
            LbOpcao1.Text = "Voltar";
            LbUsuario.Visible = false;
            CorBordaLbUsuario = Color.White;
            LbTipo.Text = "E-mail";
            LbEsqueceu.Visible = false;
            LbMensagem.Visible = true;
            LbOpcao2.Text = "Enviar";
            Tela = 3;
            InicializarBordas();
            DesenharBordas();
        }
        // Fim

        // Funções da tela 4
        private void MudarParaCriar1()
        {
            TbEntrada.Clear();
            TbEntrada2.Clear();
            TbEntrada3.Clear();
            EsconderAlertas();
            LbTipo2.Visible = true;
            LbTipo3.Visible = true;
            TbEntrada2.Visible = true;
            TbEntrada3.Visible = true;
            LbUsuario.Visible = false;
            LbTitulo.Text = "Fazer signin";
            TbEntrada.Focus();
            CorTemaTipo = FormatacoesPadrao.CorPadraoAzul;
            LbTipo.ForeColor = CorTemaTipo;
            LbOpcao1.Text = "Voltar";
            LbOpcao2.Text = "Avançar";
            CorBordaLbUsuario = Color.White;
            LbTipo.Text = "Nome";
            LbTipo2.Text = "Nome Completo";
            LbTipo3.Text = "E-mail";
            LbEsqueceu.Visible = false;
            LbMensagem.Visible = false;
            Tela = 4;
            InicializarBordas();
            DesenharBordas();
        }
        // Fim

        // Funções da tela 5
        private void MudarParaCriar2()
        {
            TbEntrada.Clear();
            TbEntrada2.Clear();
            TbEntrada3.Clear();
            EsconderAlertas();
            LbTipo2.Visible = true;
            LbTipo3.Visible = false;
            TbEntrada2.Visible = true;
            TbEntrada3.Visible = false;
            LbUsuario.Visible = true;
            LbUsuario.Location = new Point((450 - LbUsuario.Width) / 2, LbUsuario.Location.Y);
            CorBordaLbUsuario = FormatacoesPadrao.CorPadraoBorda;
            TbEntrada.Focus();
            CorTemaTipo = FormatacoesPadrao.CorPadraoAzul;
            LbTipo.ForeColor = CorTemaTipo;
            LbOpcao1.Text = "Voltar";
            LbOpcao2.Text = "Criar";
            LbTipo.Text = "Senha";
            LbTipo2.Text = "Confirmar Senha";
            Tela = 5;
            InicializarBordas();
            DesenharBordas();
        }
        // Fim

        // Funções das opções
        private void LbOpcao1_Click(object sender, EventArgs e)
        {
            if (Tela == 1 | Tela == 5)
            {
                MudarParaCriar1();
            }
            else
            {
                MudarParaNome();
            }
        }

        private void LbOpcao2_Click(object sender, EventArgs e)
        {
            switch (Tela)
            {
                case 1:
                    if (string.IsNullOrWhiteSpace(TbEntrada.Text))
                    {
                        NegarLogin("Digite seu nome", LbTipo, PbAlerta, LbAlerta, 1);
                    }
                    else
                    {
                        string consulta = $@"
                            select 
                                *
                            from 
                                Usuarios
                            where
                                Nome = @Nome
                        ";
                        SQLiteCommand comando = GerenciadorDados.CriarComando(consulta, new SQLiteParameter("@Nome", TbEntrada.Text.Trim()));
                        Usuario = GerenciadorDados.DQL(comando);
                        if (Usuario.Rows.Count > 0)
                        {
                            MudarParaSenha(Usuario.Rows[0]);
                        }
                        else
                        {
                            NegarLogin("Não foi possível encontrar sua conta", LbTipo, PbAlerta, LbAlerta, 1);
                        }
                    }
                    break;
                case 2:
                    if (string.IsNullOrWhiteSpace(TbEntrada.Text))
                    {
                        NegarLogin("Digite sua senha", LbTipo, PbAlerta, LbAlerta, 1);
                    }
                    else if (TbEntrada.Text != Usuario.Rows[0][2].ToString())
                    {
                        NegarLogin("Senha inválida. Tente novamente!", LbTipo, PbAlerta, LbAlerta, 1);
                    }
                    else
                    {
                        Globais.Id = Convert.ToInt32(Usuario.Rows[0][0]);
                        Globais.Nome = Usuario.Rows[0][1].ToString();
                        Globais.Senha = Usuario.Rows[0][2].ToString();
                        Globais.Nome_Completo = Usuario.Rows[0][3].ToString();
                        Globais.Email = Usuario.Rows[0][4].ToString();
                        Globais.Logado = true;
                        Close();
                    }
                    break;
                case 3:
                    // Se você quiser, você faz!
                    break;
                case 4:
                    EsconderAlertas();
                    if (string.IsNullOrWhiteSpace(TbEntrada.Text) | string.IsNullOrWhiteSpace(TbEntrada2.Text) | string.IsNullOrWhiteSpace(TbEntrada3.Text))
                    {
                        if (string.IsNullOrWhiteSpace(TbEntrada.Text))
                        {
                            NegarLogin("Digite seu nome", LbTipo, PbAlerta, LbAlerta, 1);
                        }
                        if (string.IsNullOrWhiteSpace(TbEntrada2.Text))
                        {
                            NegarLogin("Digite seu nome completo", LbTipo2, PbAlerta2, LbAlerta2, 2);
                        }
                        if (string.IsNullOrWhiteSpace(TbEntrada3.Text))
                        {
                            NegarLogin("Digite seu email", LbTipo3, PbAlerta3, LbAlerta3, 3);
                        }
                    }
                    else
                    {
                        string consulta = $@"select * from Usuarios where Nome = @Nome";
                        SQLiteCommand comando = GerenciadorDados.CriarComando(consulta, new SQLiteParameter("@Nome", TbEntrada.Text.Trim()));
                        Usuario = GerenciadorDados.DQL(comando);
                        if (Usuario.Rows.Count > 0)
                        {
                            NegarLogin("Esse nome já está em uso", LbTipo, PbAlerta, LbAlerta, 1);
                        }
                        consulta = $@"select * from Usuarios where Email = @Email";
                        comando = GerenciadorDados.CriarComando(consulta, new SQLiteParameter("@Email", TbEntrada3.Text.Trim()));
                        Usuario = GerenciadorDados.DQL(comando);
                        if (Usuario.Rows.Count > 0)
                        {
                            NegarLogin("Esse email já está em uso", LbTipo3, PbAlerta3, LbAlerta3, 3);
                        }
                        if (!ErroTbEntrada & !ErroTbEntrada3)
                        {
                            NovoUsuario = new Usuario(TbEntrada.Text, null, TbEntrada2.Text, TbEntrada3.Text);
                            LbUsuario.Text = NovoUsuario.Email;
                            LbTitulo.Text = NovoUsuario.Nome_Completo;
                            MudarParaCriar2();
                        }
                    }
                    break;
                case 5:
                    EsconderAlertas();
                    if (TbEntrada.Text != TbEntrada2.Text | string.IsNullOrWhiteSpace(TbEntrada.Text))
                    {
                        if (string.IsNullOrWhiteSpace(TbEntrada.Text))
                        {
                            NegarLogin("Senha inválida", LbTipo, PbAlerta, LbAlerta, 1);
                        }
                        if (string.IsNullOrWhiteSpace(TbEntrada2.Text) | TbEntrada.Text != TbEntrada2.Text)
                        {
                            NegarLogin("Senha inválida", LbTipo2, PbAlerta2, LbAlerta2, 2);
                        }
                    }
                    else
                    {
                        NovoUsuario.Senha = TbEntrada.Text;
                        GerenciadorDados.AdicionarUsuario(NovoUsuario.Nome, NovoUsuario.Senha, NovoUsuario.Nome_Completo, NovoUsuario.Email);

                        MudarParaNome();
                    }
                    break;
            }
        }

        private void NegarLogin(string erro, Label lbTipo, PictureBox pbAlerta, Label lbAlerta, byte corTemaTipo)
        {
            if (corTemaTipo == 1)
            {
                CorTema1 = CorTema2 = CorTemaTipo = FormatacoesPadrao.CorPadraoVermelho;
                lbTipo.ForeColor = CorTemaTipo;
                ErroTbEntrada = true;
            }
            else if (corTemaTipo == 2)
            {
                CorTema1 = CorTema2 = CorTemaTipo2 = FormatacoesPadrao.CorPadraoVermelho;
                lbTipo.ForeColor = CorTemaTipo2;
                ErroTbEntrada2 = true;
            }
            else
            {
                CorTema1 = CorTema2 = CorTemaTipo3 = FormatacoesPadrao.CorPadraoVermelho;
                lbTipo.ForeColor = CorTemaTipo3;
                ErroTbEntrada3 = true;
            }
            lbAlerta.Text = erro;
            lbAlerta.Visible = true;
            pbAlerta.Visible = true;
            InicializarBordas();
            DesenharBordas();
        }

        private void EsconderAlertas()
        {
            ErroTbEntrada = false;
            ErroTbEntrada2 = false;
            ErroTbEntrada3 = false;
            CorTema1 = FormatacoesPadrao.CorPadraoBorda;
            CorTema2 = FormatacoesPadrao.CorPadraoAzul;
            CorTemaTipo = TbEntrada.Focused ? FormatacoesPadrao.CorPadraoAzul : FormatacoesPadrao.CorPadraoCinza;
            CorTemaTipo2 = TbEntrada2.Focused ? FormatacoesPadrao.CorPadraoAzul : FormatacoesPadrao.CorPadraoCinza;
            CorTemaTipo3 = TbEntrada3.Focused ? FormatacoesPadrao.CorPadraoAzul : FormatacoesPadrao.CorPadraoCinza;
            LbTipo.ForeColor = CorTemaTipo;
            LbTipo2.ForeColor = CorTemaTipo2;
            LbTipo3.ForeColor = CorTemaTipo3;
            LbAlerta.Visible = false;
            LbAlerta2.Visible = false;
            LbAlerta3.Visible = false;
            PbAlerta.Visible = false;
            PbAlerta2.Visible = false;
            PbAlerta3.Visible = false;
            InicializarBordas();
            DesenharBordas();
        }

        private void FLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Globais.thread = new Thread((sender) => { Application.Run(new FPrincipal()); });
            Globais.thread.SetApartmentState(ApartmentState.STA);
            Globais.thread.Start();
        }

        private void TbEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LbOpcao2_Click(sender, new EventArgs());
            }
        }

        private void TbEntrada2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LbOpcao2_Click(sender, new EventArgs());
            }
        }

        private void TbEntrada3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LbOpcao2_Click(sender, new EventArgs());
            }
        }
    }
}

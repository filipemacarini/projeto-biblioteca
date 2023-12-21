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
        private Color CorTema1 { get; set; }
        private Color CorTema2 { get; set; }
        private Color CorTema3 { get; set; }
        private bool ErroTbEntrada { get; set; }
        private Bitmap BackgroundOriginal { get; set; }
        private Borda BordaLbOpcao1 { get; set; }
        private Borda BordaLbOpcao2 { get; set; }
        private Borda[] Bordas { get; set; }
        private byte Tela { get; set; }
        private Borda BordaLbUsuario { get; set; }
        private Color CorBordaLbUsuario { get; set; }
        private DataTable Usuario { get; set; }

        public FLogin()
        {
            InitializeComponent();

            BackgroundImage = new Bitmap(ClientSize.Width, ClientSize.Height);
            BackgroundOriginal = new Bitmap(BackgroundImage);
            CorTema1 = FormatacoesPadrao.CorPadraoBorda;
            CorTema2 = FormatacoesPadrao.CorPadraoAzul;
            CorTema3 = FormatacoesPadrao.CorPadraoCinza;
            CorBordaLbUsuario = Color.White;
            ErroTbEntrada = false;

            MudarParaNome();

            // Eventos de Foco
            TbEntrada.Enter += (sender, e) => { BordaTbEntrada.Focused = true; DesenharBordas(); CorTema3 = ErroTbEntrada ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoAzul; LbTipo.ForeColor = CorTema3; };
            TbEntrada.Leave += (sender, e) => { BordaTbEntrada.Focused = false; DesenharBordas(); CorTema3 = ErroTbEntrada ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoCinza; LbTipo.ForeColor = CorTema3; };

            //LbOpcao1.MouseEnter += (sender, e) => { BordaLbOpcao1.Focused = true; DesenharBordas(); };
            //LbOpcao1.MouseLeave += (sender, e) => { BordaLbOpcao2.Focused = false; DesenharBordas(); };

            AtualizarLayout();
        }

        // Funções de atualização do layout
        private void InicializarBordas()
        {
            // Cria as bordas
            BordaPnConta = new Borda(PnConta, new int[] { 0, 0 }, FormatacoesPadrao.CorPadraoBorda, FormatacoesPadrao.CorPadraoAzul, Color.White, 1, 10);
            BordaTbEntrada = new Borda(TbEntrada, new int[] { 16, 16 }, CorTema1, CorTema2, Color.White);
            BordaLbOpcao1 = new Borda(LbOpcao1, new int[] { 0, 0 }, FormatacoesPadrao.CorPadraoBorda, FormatacoesPadrao.CorPadraoAzul, Color.White);
            BordaLbOpcao2 = new Borda(LbOpcao2, new int[] { 0, 0 }, FormatacoesPadrao.CorPadraoAzul, FormatacoesPadrao.CorPadraoAzul, FormatacoesPadrao.CorPadraoAzul);
            BordaLbUsuario = new Borda(LbUsuario, new int[] { 10, 3 }, CorBordaLbUsuario, CorBordaLbUsuario, Color.White);
            Bordas = new Borda[] { BordaPnConta, BordaTbEntrada, BordaLbOpcao1, BordaLbOpcao2, BordaLbUsuario };
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
        }

        private void FLogin_SizeChanged(object sender, EventArgs e)
        {
            AtualizarLayout();
            Invalidate();
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
            CorTema3 = FormatacoesPadrao.CorPadraoAzul;
            LbTipo.ForeColor = CorTema3;
            LbTipo.Text = "Nome";
            TbEntrada.Focus();
            TbEntrada.Clear();
            LbTitulo.Text = "Fazer login";
            LbUsuario.Visible = false;
            LbEsqueceu.Visible = true;
            LbMensagem.Visible = false;
            LbAlerta.Visible = false;
            LbOpcao1.Text = "Criar conta";
            LbOpcao2.Text = "Avançar";
            CorBordaLbUsuario = Color.White;
            InicializarBordas();
            DesenharBordas();
            PbAlerta.Visible = false;
            Tela = 1;
        }
        // Fim

        // Funcões da tela 2
        private void MudarParaSenha(DataRow usuario)
        {
            EsconderAlertas();
            TbEntrada.Focus();
            CorTema3 = FormatacoesPadrao.CorPadraoAzul;
            LbTipo.ForeColor = CorTema3;
            TbEntrada.Clear();
            LbUsuario.Visible = true;
            LbUsuario.Text = usuario[4].ToString();
            LbUsuario.Location = new Point((450 - LbUsuario.Width) / 2, LbUsuario.Location.Y);
            LbTitulo.Text = usuario[3].ToString();
            LbTipo.Text = "Senha";
            LbOpcao1.Text = "Voltar";
            LbOpcao2.Text = "Entrar";
            CorBordaLbUsuario = FormatacoesPadrao.CorPadraoBorda;
            InicializarBordas();
            DesenharBordas();
            LbEsqueceu.Text = "Esqueceu sua senha?";
            LbEsqueceu.Visible = true;
            LbMensagem.Visible = false;
            PbAlerta.Visible = false;
            LbAlerta.Visible = false;
            Tela = 2;
        }
        // Fim

        // Funções da tela 3
        private void MudarParaRecuperacao()
        {
            EsconderAlertas();
            LbTitulo.Text = "Recuperar dados";
            TbEntrada.Focus();
            CorTema3 = FormatacoesPadrao.CorPadraoAzul;
            LbTipo.ForeColor = CorTema3;
            TbEntrada.Clear();
            LbOpcao1.Text = "Voltar";
            LbUsuario.Visible = false;
            CorBordaLbUsuario = Color.White;
            InicializarBordas();
            DesenharBordas();
            LbTipo.Text = "E-mail";
            LbEsqueceu.Visible = false;
            LbMensagem.Visible = true;
            LbOpcao2.Text = "Enviar";
            Tela = 3;
        }
        // Fim

        // Funções das opções
        private void LbOpcao1_Click(object sender, EventArgs e)
        {
            if (Tela == 1)
            {

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
                        NegarLogin("Digite seu nome");
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
                            NegarLogin("Não foi possível encontrar sua conta");
                        }
                    }
                    break;
                case 2:
                    if (string.IsNullOrWhiteSpace(TbEntrada.Text))
                    {
                        NegarLogin("Digite sua senha");
                    }
                    else if (TbEntrada.Text != Usuario.Rows[0][2].ToString())
                    {
                        NegarLogin("Senha inválida. Tente novamente!");
                    }
                    else
                    {
                        Globais.Id = Convert.ToInt32(Usuario.Rows[0][0]);
                        Globais.Nome = Usuario.Rows[0][1].ToString();
                        Globais.Senha = Usuario.Rows[0][2].ToString();
                        Globais.Nome_Completo = Usuario.Rows[0][3].ToString();
                        Globais.Email = Usuario.Rows[0][4].ToString();
                        Close();
                    }
                    break;
                case 3:
                    break;
            }
        }

        private void NegarLogin(string erro)
        {
            ErroTbEntrada = true;
            CorTema1 = CorTema2 = CorTema3 = FormatacoesPadrao.CorPadraoVermelho;
            LbTipo.ForeColor = CorTema3;
            InicializarBordas();
            DesenharBordas();
            LbAlerta.Text = erro;
            LbAlerta.Visible = true;
            PbAlerta.Visible = true;
        }

        private void EsconderAlertas()
        {
            ErroTbEntrada = false;
            CorTema1 = FormatacoesPadrao.CorPadraoBorda;
            CorTema2 = FormatacoesPadrao.CorPadraoAzul;
            CorTema3 = FormatacoesPadrao.CorPadraoCinza;
            LbTipo.ForeColor = CorTema3;
            InicializarBordas();
            DesenharBordas();
            LbAlerta.Visible = false;
            PbAlerta.Visible = false;
        }

        private void VoltarInicio()
        {
            Globais.thread = new Thread((sender) => { Application.Run(new FPrincipal()); });
            Globais.thread.SetApartmentState(ApartmentState.STA);
            Globais.thread.Start();
        }

        private void FLogin_FormClosed(object sender, FormClosedEventArgs e) => VoltarInicio();

        private void TbEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LbOpcao2_Click(sender, new EventArgs());
            }
        }
    }
}

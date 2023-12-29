using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FUsuario : Form
    {
        private byte Tela { get; set; } = 1;
        private Bitmap BackgroundOriginal { get; set; }
        private bool Alterar { get; set; } = false;
        private bool[] Erros { get; set; } = new[] { false, false, false, false, false, false };

        // Relacionados
        private TextBox[] tbTipos;
        private Label[] lbTipos;
        private Borda[] bordaTipos;

        // Bordas
        private Borda BordaPnInicio { get; set; }
        private Borda BordaPnInfo { get; set; }
        private Borda BordaPnInformacoes { get; set; }
        private Borda BordaTbID { get; set; }
        private Borda BordaTbNomeCompleto { get; set; }
        private Borda BordaTbNome { get; set; }
        private Borda BordaTbEmail { get; set; }
        private Borda BordaTbSenha { get; set; }
        private Borda BordaTbConfirmacao { get; set; }
        private Borda BordaLbOpcao1 { get; set; }
        private Borda BordaLbOpcao2 { get; set; }

        private Borda[] Bordas { get; set; }

        // Cores
        private Color CorPnInicio { get; set; }
        private Color CorPnInfo { get; set; }
        private Color CorTbEntrada1 { get; set; }
        private Color CorTbEntrada2 { get; set; }
        private Color CorLbOpcao1 { get; set; }

        public FUsuario()
        {
            InitializeComponent();

            BackgroundImage = new Bitmap(ClientSize.Width, ClientSize.Height);
            BackgroundOriginal = new Bitmap(BackgroundImage);
            label3.Text = $"Bem-vindo, {Globais.Nome_Completo}";
            CorTbEntrada2 = FormatacoesPadrao.CorPadraoAzul;

            tbTipos = new[] { TbID, TbNomeCompleto, TbNome, TbEmail, TbSenha, TbConfirmacao };
            lbTipos = new[] { LbID, LbNomeCompleto, LbNome, LbEmail, LbSenha, LbConfirmacao };
            bordaTipos = new[] { BordaTbID, BordaTbNomeCompleto, BordaTbNome, BordaTbEmail, BordaTbSenha, BordaTbConfirmacao };

            ResetarTela2();

            AtualizarLayout();
        }

        private void ResetarTela2()
        {
            // Informações
            TbID.Text = Globais.Id.ToString();
            TbNomeCompleto.Text = Globais.Nome_Completo;
            TbNome.Text = Globais.Nome;
            TbEmail.Text = Globais.Email;
            TbSenha.Text = Globais.Senha;
            TbConfirmacao.Text = "";
            AtualizarLayout();
        }

        private void InicializarBordas()
        {
            CorPnInicio = Tela == 1 ? FormatacoesPadrao.CorPadraoAzulClaro : Color.White;
            CorPnInfo = Tela == 2 ? FormatacoesPadrao.CorPadraoAzulClaro : Color.White;
            CorTbEntrada1 = Tela == 2 ? FormatacoesPadrao.CorPadraoBorda : Color.White;

            // Entradas
            CorTbEntrada2 = FormatacoesPadrao.CorPadraoAzul;
            BordaTbID = new(TbID, new int[] { 10, 10 }, CorTbEntrada1, CorTbEntrada2, Color.White);

            if (Tela == 2) { CorTbEntrada1 = Erros[1] ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoBorda; } else { CorTbEntrada1 = Color.White; }
            CorTbEntrada2 = Erros[1] ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoAzul;
            BordaTbNomeCompleto = new(TbNomeCompleto, new int[] { 10, 10 }, CorTbEntrada1, CorTbEntrada2, Color.White);

            if (Tela == 2) { CorTbEntrada1 = Erros[2] ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoBorda; } else { CorTbEntrada1 = Color.White; }
            CorTbEntrada2 = Erros[2] ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoAzul;
            BordaTbNome = new(TbNome, new int[] { 10, 10 }, CorTbEntrada1, CorTbEntrada2, Color.White);

            if (Tela == 2) { CorTbEntrada1 = Erros[3] ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoBorda; } else { CorTbEntrada1 = Color.White; }
            CorTbEntrada2 = Erros[3] ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoAzul;
            BordaTbEmail = new(TbEmail, new int[] { 10, 10 }, CorTbEntrada1, CorTbEntrada2, Color.White);

            if (Tela == 2) { CorTbEntrada1 = Erros[4] ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoBorda; } else { CorTbEntrada1 = Color.White; }
            CorTbEntrada2 = Erros[4] ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoAzul;
            BordaTbSenha = new(TbSenha, new int[] { 10, 10 }, CorTbEntrada1, CorTbEntrada2, Color.White);

            if (Tela == 2) { CorTbEntrada1 = Erros[5] ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoBorda; } else { CorTbEntrada1 = Color.White; }
            CorTbEntrada2 = Erros[5] ? FormatacoesPadrao.CorPadraoVermelho : FormatacoesPadrao.CorPadraoAzul;
            BordaTbConfirmacao = new(TbConfirmacao, new int[] { 10, 10 }, CorTbEntrada1, CorTbEntrada2, Color.White);

            CorLbOpcao1 = Alterar ? FormatacoesPadrao.CorPadraoBorda : Color.White;
            // Opcoes
            BordaLbOpcao1 = new Borda(LbOpcao1, new int[] { 0, 0 }, CorLbOpcao1, FormatacoesPadrao.CorPadraoAzul, Color.White);
            BordaLbOpcao2 = new Borda(LbOpcao2, new int[] { 0, 0 }, FormatacoesPadrao.CorPadraoAzul, FormatacoesPadrao.CorPadraoAzul, FormatacoesPadrao.CorPadraoAzul);

            BordaPnInicio = new(PnInicio, new[] { 0, 0 }, CorPnInicio, CorPnInicio, CorPnInicio, 0, 20);
            BordaPnInfo = new(PnInfo, new[] { 0, 0 }, CorPnInfo, CorPnInfo, CorPnInfo, 0, 20);
            BordaPnInformacoes = new(PnInfoPessoais, new[] { 0, 0 }, FormatacoesPadrao.CorPadraoBorda, FormatacoesPadrao.CorPadraoBorda, Color.White, 1, 10);
            Bordas = new[] { BordaPnInicio, BordaPnInfo, BordaPnInformacoes, BordaLbOpcao1, BordaLbOpcao2, BordaTbID, BordaTbNomeCompleto, BordaTbEmail, BordaTbSenha, BordaTbNome };
            if (Alterar)
                Bordas = new[] { BordaPnInicio, BordaPnInfo, BordaPnInformacoes, BordaLbOpcao1, BordaLbOpcao2, BordaTbID, BordaTbNomeCompleto, BordaTbEmail, BordaTbSenha, BordaTbNome, BordaTbConfirmacao };
        }

        private void DesenharBordas()
        {
            Borda.DesenharBordas(Bordas, this, BackgroundOriginal);
            Invalidate();
        }

        private void AtualizarLayout()
        {
            LbOpcao1.Visible = true;
            LbOpcao2.Text = "Confirmar";
            LbConfirmacao.Visible = TbConfirmacao.Visible = true;
            TbNomeCompleto.ReadOnly = TbNome.ReadOnly = TbEmail.ReadOnly = TbSenha.ReadOnly = TbConfirmacao.ReadOnly = false;
            if (!Alterar)
            {
                LbOpcao1.Visible = false;
                LbOpcao2.Text = "Alterar";
                LbConfirmacao.Visible = TbConfirmacao.Visible = false;
                TbNomeCompleto.ReadOnly = TbNome.ReadOnly = TbEmail.ReadOnly = TbSenha.ReadOnly = TbConfirmacao.ReadOnly = true;
            }

            for (byte i = 0; i < tbTipos.Length; i++)
            {
                lbTipos[i].ForeColor = tbTipos[i].Focused ? FormatacoesPadrao.CorPadraoAzul : FormatacoesPadrao.CorPadraoCinza;
                lbTipos[i].ForeColor = Erros[i] ? FormatacoesPadrao.CorPadraoVermelho : lbTipos[i].ForeColor;
            }

            InicializarBordas();
            DesenharBordas();
        }

        private void FUsuario_SizeChanged(object sender, EventArgs e)
        {
            AtualizarLayout();
        }

        private void PnInicio_Click(object sender, EventArgs e)
        {
            Tela = 1;

            AtualizarLayout();
        }

        private void PnInfo_Click(object sender, EventArgs e)
        {
            Tela = 2;

            AtualizarLayout();
        }

        private void FUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Globais.thread = new Thread((sender) => { Application.Run(new FPrincipal()); });
            Globais.thread.SetApartmentState(ApartmentState.STA);
            Globais.thread.Start();
        }

        private void LbOpcao1_Click(object sender, EventArgs e)
        {
            Alterar = false;
            ResetarTela2();
        }

        private void LbOpcao2_Click(object sender, EventArgs e)
        {
            DataTable Usuarios;
            if (Alterar)
            {
                EsconderErros();
                if (string.IsNullOrWhiteSpace(TbNomeCompleto.Text) | string.IsNullOrWhiteSpace(TbNome.Text) | string.IsNullOrWhiteSpace(TbEmail.Text) | string.IsNullOrWhiteSpace(TbSenha.Text) | string.IsNullOrWhiteSpace(TbConfirmacao.Text) | TbConfirmacao.Text.Trim() != TbSenha.Text.Trim())
                {
                    if (string.IsNullOrWhiteSpace(TbNomeCompleto.Text))
                    {
                        NegarEntrada(1);
                    }
                    if (string.IsNullOrWhiteSpace(TbNome.Text))
                    {
                        NegarEntrada(2);
                    }
                    if (string.IsNullOrWhiteSpace(TbEmail.Text))
                    {
                        NegarEntrada(3);
                    }
                    if (string.IsNullOrWhiteSpace(TbSenha.Text))
                    {
                        NegarEntrada(4);
                    }
                    if (string.IsNullOrWhiteSpace(TbConfirmacao.Text) | TbConfirmacao.Text.Trim() != TbSenha.Text.Trim())
                    {
                        NegarEntrada(5);
                    }
                }
                else
                {
                    Usuarios = GerenciadorDados.PegarUsuarios("Nome", TbNome.Text.Trim(), Globais.Id);
                    if (Usuarios.Rows.Count > 0)
                    {
                        NegarEntrada(2);
                    }
                    Usuarios = GerenciadorDados.PegarUsuarios("Email", TbEmail.Text.Trim(), Globais.Id);
                    if (Usuarios.Rows.Count > 0)
                    {
                        NegarEntrada(3);
                    }

                    // Atualiza o usuário se os dados estiverem certos 
                    if (ContarErros() == 0)
                    {
                        GerenciadorDados.AtualizarUsuario(Globais.Id, TbNome.Text.Trim(), TbSenha.Text.Trim(), TbNomeCompleto.Text.Trim(), TbEmail.Text.Trim());
                    }
                }
            } 
            else
            {
                Alterar = true;
            }
            AtualizarLayout();
        }

        private void NegarEntrada(byte i)
        {
            Erros[i] = true;
        }

        private void EsconderErros()
        {
            LbID.ForeColor = LbNomeCompleto.ForeColor = LbNome.ForeColor = LbEmail.ForeColor = LbSenha.ForeColor = LbConfirmacao.ForeColor = FormatacoesPadrao.CorPadraoCinza;
            Erros  = new[] { false, false, false, false, false, false };
        }

        private int ContarErros()
        {
            int qtdeErros = 0;
            for (byte i = 0; i < Erros.Length; i++)
            {
                qtdeErros += Erros[i] ? 1 : 0;
            }
            return qtdeErros;
        }

        private void FUsuario_Load(object sender, EventArgs e)
        {

        }

        private void TbEntrada_EnterLeave(object sender, EventArgs e)
        {
            TmCampos.Start();
        }

        private void TmCampos_Tick(object sender, EventArgs e)
        {
            AtualizarLayout();
            TmCampos.Stop();
        }
    }
}

using Biblioteca.Properties;
using System.Data;
using System.Data.SQLite;
using System.Drawing.Drawing2D;
using System.Windows.Forms.VisualStyles;

namespace Biblioteca
{
    public partial class FPrincipal : Form
    {
        private Borda BordaTbPesquisa { get; set; }
        private Borda BordaBtnPesquisa { get; set; }
        private Borda BordaBtnConta { get; set; }
        private Bitmap BackgroundOriginal { get; set; }
        private Borda[] Bordas { get; set; }

        public FPrincipal()
        {
            InitializeComponent();

            BackgroundImage = new Bitmap(ClientSize.Width, ClientSize.Height);
            BackgroundOriginal = new Bitmap(BackgroundImage);

            // Eventos de Foco
            TbPesquisa.Enter += (sender, e) => { BordaTbPesquisa.Focused = true; DesenharBordas(); };
            TbPesquisa.Leave += (sender, e) => { BordaTbPesquisa.Focused = false; DesenharBordas(); };

            AtualizarLayout();
        }

        private void InicializarBordas()
        {
            // Cria as bordas
            BordaTbPesquisa = new Borda(TbPesquisa, new int[] { 5, 5 }, FormatacoesPadrao.CorPadraoBorda, FormatacoesPadrao.CorPadraoAzul, Color.White);
            BordaBtnPesquisa = new Borda(BtnPesquisar, new int[] { 0, 0 }, FormatacoesPadrao.CorPadraoAzul, FormatacoesPadrao.CorPadraoAzul, FormatacoesPadrao.CorPadraoAzul);
            BordaBtnConta = new Borda(BtnConta, new int[] { 0, 0 }, FormatacoesPadrao.CorPadraoAzul, FormatacoesPadrao.CorPadraoAzul, FormatacoesPadrao.CorPadraoAzul);
            Bordas = new Borda[] { BordaTbPesquisa, BordaBtnPesquisa, BordaBtnConta };
        }

        private void DesenharBordas()
        {
            Borda.DesenharBordas(Bordas, this, BackgroundOriginal);
        }

        private void AtualizarTbPesquisa(Point ponto, int largura)
        {
            TbPesquisa.Location = ponto;
            TbPesquisa.Width = largura;
        }

        private void AtualizarLayout()
        {
            BtnConta.Text = Globais.Logado ? "Conta" : "Login";
            PbLogo.BackgroundImage = Resources.logoLibraryFilipeMedioPequeno;
            AtualizarTbPesquisa(new Point(17, 218), this.Width - BtnPesquisar.Width - 62);

            if (this.Width >= 690)
            {
                PbLogo.BackgroundImage = Resources.logoLibraryFilipeGrande;
                AtualizarTbPesquisa(new Point((this.Width - 16) / 2 - 323, 218), 584);
            }

            BtnPesquisar.Location = new Point(TbPesquisa.Location.X + TbPesquisa.Width + 17, TbPesquisa.Location.Y - 5);
            BtnPesquisar.Height = TbPesquisa.Height + 10;

            // Cria e Desenha as bordas
            InicializarBordas();
            DesenharBordas();
        }

        private void FPrincipal_SizeChanged(object sender, EventArgs e)
        {
            AtualizarLayout();
            this.Invalidate();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Close();
            if (Globais.Logado)
            {
                Globais.thread = new Thread((sender) => { Application.Run(new FUsuario()); });
            }
            else
            {
                Globais.thread = new Thread((sender) => { Application.Run(new FLogin()); });
            }
            Globais.thread.SetApartmentState(ApartmentState.STA);
            Globais.thread.Start();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
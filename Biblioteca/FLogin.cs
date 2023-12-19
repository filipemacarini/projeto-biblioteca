using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Biblioteca
{
    public partial class FLogin : Form
    {
        private Preenchimento BordaPnConta { get; set; }
        private Preenchimento BordaTbNome { get; set; }
        private Bitmap BackgroundOriginal { get; set; }
        private Preenchimento[] Bordas { get; set; }

        public FLogin()
        {
            InitializeComponent();

            BackgroundImage = new Bitmap(ClientSize.Width, ClientSize.Height);
            BackgroundOriginal = new Bitmap(BackgroundImage);

            // Eventos de Foco
            TbEntrada.Enter += (sender, e) => { BordaTbNome.Focused = true; DesenharBordas(); LbTipo.ForeColor = FormatacoesPadrao.CorPadraoAzul; };
            TbEntrada.Leave += (sender, e) => { BordaTbNome.Focused = false; DesenharBordas(); LbTipo.ForeColor = FormatacoesPadrao.CorPadraoCinza; };

            AtualizarLayout();
        }

        private void InicializarBordas()
        {
            // Cria as bordas
            BordaPnConta = new Preenchimento(PnConta, new int[] { 0, 0 }, FormatacoesPadrao.CorPadraoBorda, FormatacoesPadrao.CorPadraoAzul, FormatacoesPadrao.CorPadraoCinza, 1, 10);
            BordaTbNome = new Preenchimento(TbEntrada, new int[] { 16, 16 }, FormatacoesPadrao.CorPadraoBorda, FormatacoesPadrao.CorPadraoAzul, FormatacoesPadrao.CorPadraoCinza);
            Bordas = new Preenchimento[] { BordaPnConta, BordaTbNome };
        }

        private void DesenharBordas()
        {
            Preenchimento.DesenharBordas(Bordas, this, BackgroundOriginal);
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

        private void LbEsqueceu_Click(object sender, EventArgs e)
        {
            LbTitulo.Text = "Recuperar nome";
            LbTipo.Text = "E-mail";
            LbEsqueceu.Visible = false;
        }
    }
}

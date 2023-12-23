using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FUserInfo : Form
    {
        // Bordas Ocas
        private Borda BordaPnConta { get; set; }
        private Borda[] Bordas { get; set; }

        // Relacionado ao Fundo
        private Bitmap BackgroundOriginal {  get; set; }

        public FUserInfo()
        {
            InitializeComponent();

            // Inicializando as Variaveis
            BackgroundOriginal = new Bitmap(this.BackgroundImage);
        }

        // Funções das Bordas
        private void InicializarBordas()
        {
            BordaPnConta = new Borda(PnConta, new int[] { 0, 0 }, FormatacoesPadrao.CorPadraoBorda, FormatacoesPadrao.CorPadraoAzul, Color.White, 1, 10);
            Bordas = new Borda[] { BordaPnConta };
        }

        private void DesenharBordas()
        {
            Borda.DesenharBordas(Bordas, this, BackgroundOriginal);
        }
    }
}

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
        private Borda BordaPnConta { get; set; }
        private Bitmap BackgroundOriginal { get; set; }

        public FLogin()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(ClientSize.Width, ClientSize.Height);
            BackgroundOriginal = new Bitmap(BackgroundImage);
            AtualizarLayout();
        }

        private void AtualizarLayout()
        {
            PnConta.Location = new Point((ClientSize.Width - PnConta.Width) / 2, (ClientSize.Height - PnConta.Height) / 2);
            BordaPnConta = new Borda(PnConta, new int[] { 1, 1 }, FormatacoesPadrao.CorPadraoBorda, 1, 5);
            Borda.DesenharBordas(new Borda[] { BordaPnConta }, this, BackgroundOriginal); PnConta.Location = new Point((ClientSize.Width - PnConta.Width) / 2, (ClientSize.Height - PnConta.Height) / 2);
        }

        private void FLogin_SizeChanged(object sender, EventArgs e)
        {
            AtualizarLayout();
            Invalidate();
        }
    }
}

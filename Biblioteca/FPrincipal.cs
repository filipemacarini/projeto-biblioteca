/*
  Copyright (c) 2023 Filipe Emanuel Macarini Roco

  Permission is hereby granted, free of charge, to any person obtaining a copy
  of this software and associated documentation files (the "Software"), to deal
  in the Software without restriction, including without limitation the rights
  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
  copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

  The above copyright notice and this permission notice shall be included in all
  copies or substantial portions of the Software.

  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
  SOFTWARE.
*/

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
            BordaTbPesquisa = new Borda(TbPesquisa, new int[] { 5, 3 }, FormatacoesPadrao.CorPadraoBorda, FormatacoesPadrao.CorPadraoAzul, Color.White);
            Bordas = new Borda[] { BordaTbPesquisa };
        }

        private void DesenharBordas()
        {
            Borda.DesenharBordas(Bordas, this, BackgroundOriginal);
        }

        private void AtualizarPbLogo(Bitmap imagem, int altura)
        {
            PbLogo.BackgroundImage = imagem;
            PbLogo.Size = new Size(this.Width - 24, altura);
            PbLogo.Location = new Point(12, 80);
        }

        private void AtualizarBtnLogin(Point ponto, Font fonte, String texto, Size tamanho)
        {
            BtnLogin.Location = ponto;
            BtnLogin.Font = fonte;
            BtnLogin.Text = texto;
            BtnLogin.Size = tamanho;
        }

        private void AtualizarTbPesquisa(Point ponto, int largura)
        {
            TbPesquisa.Location = ponto;
            TbPesquisa.Width = largura;
        }

        private void AtualizarLayout()
        {
            if (this.Width >= 690)
            {
                AtualizarPbLogo(Properties.Resources.logoLibraryFilipeGrande, 127);
                AtualizarBtnLogin(new Point(this.Width - 16 - BtnLogin.Margin.Right - BtnLogin.Width, 12), FormatacoesPadrao.FontePadraoBtnGrande, "LOGIN", new Size(100, 33));
                AtualizarTbPesquisa(new Point((this.Width - 16) / 2 - 323, 218), 584);
                BtnPesquisar.Location = new Point(TbPesquisa.Location.X + TbPesquisa.Width + 12 + 3, TbPesquisa.Location.Y - 3);
            }
            else if (this.Width >= 450)
            {
                AtualizarPbLogo(Properties.Resources.logoLibraryFilipeMedioPequeno, 107);
                AtualizarBtnLogin(new Point(12, 12), FormatacoesPadrao.FontePadraoBtnGrande, "LOGIN", new Size(100, 33));
                AtualizarTbPesquisa(new Point(17, 218), this.Width - BtnPesquisar.Width - 62);
                BtnPesquisar.Location = new Point(TbPesquisa.Location.X + TbPesquisa.Width + 15, TbPesquisa.Location.Y - 3);
            }
            else
            {
                AtualizarPbLogo(Properties.Resources.logoLibraryFilipeMedioPequeno, 107);
                AtualizarBtnLogin(new Point(BtnPesquisar.Width + 24, BtnPesquisar.Location.Y), FormatacoesPadrao.FontePadraoBtnPequeno, "FAZER LOGIN", new Size(TbPesquisa.Width - 52, 24));
                AtualizarTbPesquisa(new Point(17, 218), this.Width - 50);
                BtnPesquisar.Location = new Point(12, TbPesquisa.Location.Y + TbPesquisa.Height + 16);
            }
            BtnPesquisar.Height = TbPesquisa.Height + 6;

            // Cria e Desenha as bordas
            InicializarBordas();
            DesenharBordas();
        }

        private void FPrincipal_SizeChanged(object sender, EventArgs e)
        {
            AtualizarLayout();
            this.Invalidate();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Close();
            Globais.thread = new Thread((sender) => { Application.Run(new FLogin()); });
            Globais.thread.SetApartmentState(ApartmentState.STA);
            Globais.thread.Start();
        }
    }
}
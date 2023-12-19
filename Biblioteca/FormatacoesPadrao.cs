using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class FormatacoesPadrao
    {
        public static Font FontePadraoBtnGrande = new Font(new FontFamily("Segoe UI"), 12.0f, FontStyle.Bold);
        public static Font FontePadraoBtnPequeno = new Font(new FontFamily("Segoe UI"), 9.0f, FontStyle.Bold);
        public static Font FontePadraoTextoGrande = new Font(new FontFamily("Segoe UI"), 10.0f, FontStyle.Regular);
        public static Color CorPadraoAzul = Color.FromArgb(27, 102, 201);
        public static Color CorPadraoAzulEscuro = Color.FromArgb(17, 96, 170);
        public static Color CorPadraoBorda = Color.FromArgb(190, 190, 230);
        public static Color CorPadraoCinza = Color.FromArgb(60, 60, 80);
        public static Color CorPadraoCinzaDestaque = Color.FromArgb(20, 20, 60);
    }
}

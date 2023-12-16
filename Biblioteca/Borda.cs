using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    internal class Borda
    {
        public int BorderRadius { get; set; }
        public int BorderWidth { get; set; }
        public Color BorderColor { get; set; }
        public object Objetc { get; }
        public int[] Padding { get; set; }
        public Bitmap Background { get; }
        private Graphics Desenhador { get; set; }

        public Borda(Form form, object borderObjetc, int[] borderPadding, Color borderColor, int borderWidth = 1, int borderRadius = 5, bool suavizado = false)
        {
            // Desenho
            Background = new Bitmap(form.Width, form.Height);
            Desenhador = Graphics.FromImage(Background);
            
            // Propriedades da Borda
            Padding = borderPadding;
            if (borderPadding == null) { Padding = new int[] { 10, 8 }; }
            Objetc = borderObjetc;
            BorderColor = borderColor;
            BorderWidth = borderWidth;
            BorderRadius = borderRadius;
            if (suavizado ) { Desenhador.SmoothingMode = SmoothingMode.AntiAlias; }

            // Desenha efetivamente a borda em Background e coloca de fundo no form especificado
            DesenharBorda();
            form.BackgroundImage = Background;
        }

        private void DesenharBorda()
        {
            int x, y, largura, altura;
            int TBW = 2 * BorderWidth;
            int TBR = 2 * BorderRadius;
            int diametro = TBR;

            using (Brush brush = new SolidBrush(BorderColor))
            using (Brush erase = new SolidBrush(Color.White))
            {
                PropertyInfo locationObjeto = Objetc.GetType().GetProperty("Location");
                PropertyInfo widthObjeto = Objetc.GetType().GetProperty("Width");
                PropertyInfo heightObjeto = Objetc.GetType().GetProperty("Height");

                if (locationObjeto != null && widthObjeto != null && heightObjeto != null)
                {
                    Point location = (Point)locationObjeto.GetValue(Objetc);
                    int width = (int)widthObjeto.GetValue(Objetc);
                    int height = (int)heightObjeto.GetValue(Objetc);

                    // Circulo Superior Esquerdo
                    x = location.X - Padding[0];
                    y = location.Y - Padding[1];
                    Desenhador.FillEllipse(brush, x, y, diametro, diametro);
                    Desenhador.FillEllipse(erase, x + BorderWidth, y + BorderWidth, diametro - TBW, diametro - TBW);

                    // Circulo Superior Direito
                    x = location.X + width + Padding[0] - TBR;
                    y = location.Y - Padding[1];
                    Desenhador.FillEllipse(brush, x, y, diametro, diametro);
                    Desenhador.FillEllipse(erase, x + BorderWidth, y + BorderWidth, diametro - TBW, diametro - TBW);

                    // Circulo Inferior Direito
                    x = location.X + width + Padding[0] - TBR;
                    y = location.Y + height + Padding[1] - TBR;
                    Desenhador.FillEllipse(brush, x, y, diametro, diametro);
                    Desenhador.FillEllipse(erase, x + BorderWidth, y + BorderWidth, diametro - TBW, diametro - TBW);

                    // Circulo Inferior Esquerdo
                    x = location.X - Padding[0];
                    y = location.Y + height + Padding[1] - TBR;
                    Desenhador.FillEllipse(brush, x, y, diametro, diametro);
                    Desenhador.FillEllipse(erase, x + BorderWidth, y + BorderWidth, diametro - TBW, diametro - TBW);

                    // Retangulo Horizontal
                    x = location.X - Padding[0];
                    y = location.Y - Padding[1] + BorderRadius;
                    largura = width + 2 * Padding[0];
                    altura = (location.Y + height + Padding[1] - BorderRadius) - y;
                    Desenhador.FillRectangle(brush, x, y, largura, altura);
                    Desenhador.FillRectangle(erase, x + BorderWidth, y - 1, largura - TBW, altura + 2);

                    // Retangulo Vertical
                    x = location.X - Padding[0] + BorderRadius;
                    y = location.Y - Padding[1];
                    largura = location.X + width + Padding[0] - BorderRadius - x;
                    altura = height + 2 * Padding[1];
                    Desenhador.FillRectangle(brush, x, y, largura, altura);
                    Desenhador.FillRectangle(erase, x - 1, y + BorderWidth, largura + 2, altura - TBW);
                }
            }
        }
    }
}

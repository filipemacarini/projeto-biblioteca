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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Biblioteca
{
    internal class Borda
    {
        public int BorderRadius { get; set; }
        public int BorderWidth { get; set; }
        public Color BorderColor { get; set; }
        public Color BackColor { get; set; }
        public object Objetc { get; }
        public int[] Padding { get; set; }
        public Color ColorFocus { get; set; }
        public bool Button { get; set; }
        public bool Focused { get; set; }


        public Borda(object borderObjetc, int[] borderPadding, Color borderColor, Color colorFocus, Color backColor, int borderWidth = 1, int borderRadius = 4, bool button = false)
        {
            // Propriedades da Borda
            Padding = borderPadding;
            if (borderPadding == null) { Padding = new int[] { 10, 8 }; }
            Objetc = borderObjetc;
            BorderColor = borderColor;
            BorderWidth = borderWidth;
            BorderRadius = borderRadius;
            ColorFocus = colorFocus;
            if (borderObjetc is Control control)
            {
                Focused = control.Focused;
            }
            BackColor = backColor;
            Button = button;
        }

        public static void DesenharBordas(Borda[] bordas, Form form, Bitmap backgroundOriginal)
        {
            // Desenho
            Bitmap resultado = new(form.Width, form.Height);
            Graphics desenhador = Graphics.FromImage(resultado);


            foreach (Borda borda in bordas)
            {
                // Possíveis modificações para quando estar em foco
                int borderWidth = borda.BorderWidth;
                Color borderColor = borda.BorderColor;
                Color backColor = borda.BackColor;
                if (borda.Focused)
                {
                    borderColor = borda.ColorFocus;
                    borderWidth = borda.BorderWidth + 1;
                    if (borda.Button) { backColor = borderColor; }
                }

                // Propriedades para a criação dos círculos e retângulos
                int x, y, largura, altura;
                int TBW = 2 * borderWidth;
                int TBR = 2 * borda.BorderRadius;
                int diametro = TBR;
                int diferencial = borderWidth - 1;

                using (Brush brush = new SolidBrush(borderColor))
                using (Brush erase = new SolidBrush(backColor))
                {
                    PropertyInfo locationObjeto = borda.Objetc.GetType().GetProperty("Location");
                    PropertyInfo widthObjeto = borda.Objetc.GetType().GetProperty("Width");
                    PropertyInfo heightObjeto = borda.Objetc.GetType().GetProperty("Height");
                    MethodInfo locationAbsolutoMetodo = borda.Objetc.GetType().GetMethod("PointToScreen");

                    if (locationObjeto != null && widthObjeto != null && heightObjeto != null && locationAbsolutoMetodo != null)
                    {
                        Point locationRelativo = (Point)locationObjeto.GetValue(borda.Objetc);
                        int width = (int)widthObjeto.GetValue(borda.Objetc);
                        int height = (int)heightObjeto.GetValue(borda.Objetc);
                        Point locationAbsoluto = (Point)locationAbsolutoMetodo.Invoke(borda.Objetc, new object[] { Point.Empty });
                        Point location = new Point(locationAbsoluto.X - form.Location.X - 8, locationAbsoluto.Y - form.Location.Y - 31); // SystemInformation.CaptionHeight

                        // Círculo Superior Esquerdo
                        x = location.X - borda.Padding[0];
                        y = location.Y - borda.Padding[1];
                        desenhador.FillEllipse(brush, x, y, diametro, diametro);
                        desenhador.FillEllipse(erase, x + borderWidth, y + borderWidth, diametro - TBW, diametro - TBW);

                        // Círculo Superior Direito
                        x = location.X + width + borda.Padding[0] - TBR - borderWidth + diferencial;
                        y = location.Y - borda.Padding[1];
                        desenhador.FillEllipse(brush, x, y, diametro, diametro);
                        desenhador.FillEllipse(erase, x + borderWidth, y + borderWidth, diametro - TBW, diametro - TBW);

                        // Círculo Inferior Direito
                        x = location.X + width + borda.Padding[0] - TBR - borderWidth + diferencial;
                        y = location.Y + height + borda.Padding[1] - TBR - borderWidth + diferencial;
                        desenhador.FillEllipse(brush, x, y, diametro, diametro);
                        desenhador.FillEllipse(erase, x + borderWidth, y + borderWidth, diametro - TBW, diametro - TBW);

                        // Círculo Inferior Esquerdo
                        x = location.X - borda.Padding[0];
                        y = location.Y + height + borda.Padding[1] - TBR - borderWidth + diferencial;
                        desenhador.FillEllipse(brush, x, y, diametro, diametro);
                        desenhador.FillEllipse(erase, x + borderWidth, y + borderWidth, diametro - TBW, diametro - TBW);

                        // Retângulo Horizontal
                        x = location.X - borda.Padding[0];
                        y = location.Y - borda.Padding[1] + borda.BorderRadius;
                        largura = width + 2 * borda.Padding[0];
                        altura = (location.Y + height + borda.Padding[1] - borda.BorderRadius) - y;
                        desenhador.FillRectangle(brush, x, y, largura, altura);
                        desenhador.FillRectangle(erase, x + borderWidth, y, largura - TBW, altura);

                        // Retângulo Vertical
                        x = location.X - borda.Padding[0] + borda.BorderRadius;
                        y = location.Y - borda.Padding[1];
                        largura = location.X + width + borda.Padding[0] - borda.BorderRadius - x;
                        altura = height + 2 * borda.Padding[1];
                        desenhador.FillRectangle(brush, x, y, largura, altura);
                        desenhador.FillRectangle(erase, x, y + borderWidth, largura, altura - TBW);
                    }
                }
            }

            // Desenha efetivamente a borda do resultado em BackgroundImage do Form
            desenhador = Graphics.FromImage(backgroundOriginal);
            desenhador.DrawImage(resultado, new Point(0, 0));
            form.BackgroundImage = resultado;
            desenhador.Dispose();
        }
    }
}
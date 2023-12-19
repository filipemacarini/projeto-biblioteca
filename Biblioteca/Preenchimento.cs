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
    internal class Preenchimento
    {
        public int BorderRadius { get; set; }
        public int BorderWidth { get; set; }
        public Color BorderColor { get; set; }
        public Color BackColor { get; set; }
        public object Objetc { get; }
        public int[] Padding { get; set; }
        public Color ColorFocus { get; set; }
        public bool Focused { get; set; }

        public Preenchimento(object borderObjetc, int[] borderPadding, Color borderColor, Color colorFocus, Color backColor, int borderWidth = 1, int borderRadius = 4)
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
        }

        public static void DesenharFundo(Preenchimento[] preenchimentos, Form form, Bitmap backgroundOriginal)
        {
            // Desenho
            Bitmap resultado = new(form.Width, form.Height);
            Graphics desenhador = Graphics.FromImage(resultado);


            foreach (Preenchimento preenchimento in preenchimentos)
            {
                // Propriedades para a criação dos círculos e retângulos
                int x, y, largura, altura;
                int TBR = 2 * preenchimento.BorderRadius;
                int diametro = TBR;

                using (Brush brush = new SolidBrush(preenchimento.BackColor))
                {
                    PropertyInfo locationObjeto = preenchimento.Objetc.GetType().GetProperty("Location");
                    PropertyInfo widthObjeto = preenchimento.Objetc.GetType().GetProperty("Width");
                    PropertyInfo heightObjeto = preenchimento.Objetc.GetType().GetProperty("Height");
                    MethodInfo locationAbsolutoMetodo = preenchimento.Objetc.GetType().GetMethod("PointToScreen");

                    if (locationObjeto != null && widthObjeto != null && heightObjeto != null && locationAbsolutoMetodo != null)
                    {
                        Point locationRelativo = (Point)locationObjeto.GetValue(preenchimento.Objetc);
                        int width = (int)widthObjeto.GetValue(preenchimento.Objetc);
                        int height = (int)heightObjeto.GetValue(preenchimento.Objetc);
                        Point locationAbsoluto = (Point)locationAbsolutoMetodo.Invoke(preenchimento.Objetc, new object[] { Point.Empty });
                        Point location = new Point(locationAbsoluto.X - form.Location.X - 8, locationAbsoluto.Y - form.Location.Y - 31); // SystemInformation.CaptionHeight

                        // Círculo Superior Esquerdo
                        x = location.X - preenchimento.Padding[0];
                        y = location.Y - preenchimento.Padding[1];
                        desenhador.FillEllipse(brush, x, y, diametro, diametro);

                        // Círculo Superior Direito
                        x = location.X + width + preenchimento.Padding[0] - TBR;
                        y = location.Y - preenchimento.Padding[1];
                        desenhador.FillEllipse(brush, x, y, diametro, diametro);

                        // Círculo Inferior Direito
                        x = location.X + width + preenchimento.Padding[0] - TBR;
                        y = location.Y + height + preenchimento.Padding[1] - TBR;
                        desenhador.FillEllipse(brush, x, y, diametro, diametro);

                        // Círculo Inferior Esquerdo
                        x = location.X - preenchimento.Padding[0];
                        y = location.Y + height + preenchimento.Padding[1] - TBR;
                        desenhador.FillEllipse(brush, x, y, diametro, diametro);

                        // Retângulo Horizontal
                        x = location.X - preenchimento.Padding[0];
                        y = location.Y - preenchimento.Padding[1] + preenchimento.BorderRadius;
                        largura = width + 2 * preenchimento.Padding[0];
                        altura = (location.Y + height + preenchimento.Padding[1] - preenchimento.BorderRadius) - y;
                        desenhador.FillRectangle(brush, x, y, largura, altura);

                        // Retângulo Vertical
                        x = location.X - preenchimento.Padding[0] + preenchimento.BorderRadius;
                        y = location.Y - preenchimento.Padding[1];
                        largura = location.X + width + preenchimento.Padding[0] - preenchimento.BorderRadius - x;
                        altura = height + 2 * preenchimento.Padding[1];
                        desenhador.FillRectangle(brush, x, y, largura, altura);
                    }
                }
            }

            // Desenha efetivamente a borda do resultado em BackgroundImage do Form
            desenhador = Graphics.FromImage(backgroundOriginal);
            desenhador.DrawImage(resultado, new Point(0, 0));
            form.BackgroundImage = resultado;
            desenhador.Dispose();
        }

        public static void DesenharBordas(Preenchimento[] preenchimentos, Form form, Bitmap backgroundOriginal)
        {
            // Desenho
            Bitmap resultado = new(form.Width, form.Height);
            Graphics desenhador = Graphics.FromImage(resultado);


            foreach (Preenchimento preenchimento in preenchimentos)
            {
                // Possíveis modificações para quando estar em foco
                int borderWidth = preenchimento.BorderWidth;
                Color borderColor = preenchimento.BorderColor;
                if (preenchimento.Focused)
                {
                    borderColor = preenchimento.ColorFocus;
                    borderWidth = preenchimento.BorderWidth + 1;
                }

                // Propriedades para a criação dos círculos e retângulos
                int x, y, largura, altura;
                int TBW = 2 * borderWidth;
                int TBR = 2 * preenchimento.BorderRadius;
                int diametro = TBR;
                int diferencial = borderWidth - 1;

                using (Brush brush = new SolidBrush(borderColor))
                using (Brush erase = new SolidBrush(Color.White))
                {
                    PropertyInfo locationObjeto = preenchimento.Objetc.GetType().GetProperty("Location");
                    PropertyInfo widthObjeto = preenchimento.Objetc.GetType().GetProperty("Width");
                    PropertyInfo heightObjeto = preenchimento.Objetc.GetType().GetProperty("Height");
                    MethodInfo locationAbsolutoMetodo = preenchimento.Objetc.GetType().GetMethod("PointToScreen");

                    if (locationObjeto != null && widthObjeto != null && heightObjeto != null && locationAbsolutoMetodo != null)
                    {
                        Point locationRelativo = (Point)locationObjeto.GetValue(preenchimento.Objetc);
                        int width = (int)widthObjeto.GetValue(preenchimento.Objetc);
                        int height = (int)heightObjeto.GetValue(preenchimento.Objetc);
                        Point locationAbsoluto = (Point)locationAbsolutoMetodo.Invoke(preenchimento.Objetc, new object[] { Point.Empty });
                        Point location = new Point(locationAbsoluto.X - form.Location.X - 8, locationAbsoluto.Y - form.Location.Y - 31); // SystemInformation.CaptionHeight

                        // Círculo Superior Esquerdo
                        x = location.X - preenchimento.Padding[0];
                        y = location.Y - preenchimento.Padding[1];
                        desenhador.FillEllipse(brush, x, y, diametro, diametro);
                        desenhador.FillEllipse(erase, x + borderWidth, y + borderWidth, diametro - TBW, diametro - TBW);

                        // Círculo Superior Direito
                        x = location.X + width + preenchimento.Padding[0] - TBR - borderWidth + diferencial;
                        y = location.Y - preenchimento.Padding[1];
                        desenhador.FillEllipse(brush, x, y, diametro, diametro);
                        desenhador.FillEllipse(erase, x + borderWidth, y + borderWidth, diametro - TBW, diametro - TBW);

                        // Círculo Inferior Direito
                        x = location.X + width + preenchimento.Padding[0] - TBR - borderWidth + diferencial;
                        y = location.Y + height + preenchimento.Padding[1] - TBR - borderWidth + diferencial;
                        desenhador.FillEllipse(brush, x, y, diametro, diametro);
                        desenhador.FillEllipse(erase, x + borderWidth, y + borderWidth, diametro - TBW, diametro - TBW);

                        // Círculo Inferior Esquerdo
                        x = location.X - preenchimento.Padding[0];
                        y = location.Y + height + preenchimento.Padding[1] - TBR - borderWidth + diferencial;
                        desenhador.FillEllipse(brush, x, y, diametro, diametro);
                        desenhador.FillEllipse(erase, x + borderWidth, y + borderWidth, diametro - TBW, diametro - TBW);

                        // Retângulo Horizontal
                        x = location.X - preenchimento.Padding[0];
                        y = location.Y - preenchimento.Padding[1] + preenchimento.BorderRadius;
                        largura = width + 2 * preenchimento.Padding[0];
                        altura = (location.Y + height + preenchimento.Padding[1] - preenchimento.BorderRadius) - y;
                        desenhador.FillRectangle(brush, x, y, largura, altura);
                        desenhador.FillRectangle(erase, x + borderWidth, y, largura - TBW, altura);

                        // Retângulo Vertical
                        x = location.X - preenchimento.Padding[0] + preenchimento.BorderRadius;
                        y = location.Y - preenchimento.Padding[1];
                        largura = location.X + width + preenchimento.Padding[0] - preenchimento.BorderRadius - x;
                        altura = height + 2 * preenchimento.Padding[1];
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
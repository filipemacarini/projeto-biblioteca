﻿using System;
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
        public object Objetc { get; }
        public int[] Padding { get; set; }

        public Borda(object borderObjetc, int[] borderPadding, Color borderColor, int borderWidth = 1, int borderRadius = 5)
        {            
            // Propriedades da Borda
            Padding = borderPadding;
            if (borderPadding == null) { Padding = new int[] { 10, 8 }; }
            Objetc = borderObjetc;
            BorderColor = borderColor;
            BorderWidth = borderWidth;
            BorderRadius = borderRadius;
        }

        public static void DesenharBordas(Borda[] bordas, Form form, Bitmap backgroundOriginal)
        {
            // Desenho
            Bitmap resultado = new(form.Width, form.Height);
            Graphics desenhador = Graphics.FromImage(resultado);


            foreach (Borda borda in bordas)
            {
                int x, y, largura, altura;
                int TBW = 2 * borda.BorderWidth;
                int TBR = 2 * borda.BorderRadius;
                int diametro = TBR;

                using (Brush brush = new SolidBrush(borda.BorderColor))
                using (Brush erase = new SolidBrush(Color.White))
                {
                    PropertyInfo locationObjeto = borda.Objetc.GetType().GetProperty("Location");
                    PropertyInfo widthObjeto = borda.Objetc.GetType().GetProperty("Width");
                    PropertyInfo heightObjeto = borda.Objetc.GetType().GetProperty("Height");

                    if (locationObjeto != null && widthObjeto != null && heightObjeto != null)
                    {
                        Point location = (Point)locationObjeto.GetValue(borda.Objetc);
                        int width = (int)widthObjeto.GetValue(borda.Objetc);
                        int height = (int)heightObjeto.GetValue(borda.Objetc);

                        // Circulo Superior Esquerdo
                        x = location.X - borda.Padding[0];
                        y = location.Y - borda.Padding[1];
                        desenhador.FillEllipse(brush, x, y, diametro, diametro);
                        //Desenhador.SmoothingMode = SmoothingMode.None;
                        desenhador.FillEllipse(erase, x + borda.BorderWidth, y + borda.BorderWidth, diametro - TBW, diametro - TBW);
                        //Desenhador.SmoothingMode = SmoothingMode.AntiAlias;

                        // Circulo Superior Direito
                        x = location.X + width + borda.Padding[0] - TBR - borda.BorderWidth;
                        y = location.Y - borda.Padding[1];
                        desenhador.FillEllipse(brush, x, y, diametro, diametro);
                        //Desenhador.SmoothingMode = SmoothingMode.None;
                        desenhador.FillEllipse(erase, x + borda.BorderWidth, y + borda.BorderWidth, diametro - TBW, diametro - TBW);
                        //Desenhador.SmoothingMode = SmoothingMode.AntiAlias;

                        // Circulo Inferior Direito
                        x = location.X + width + borda.Padding[0] - TBR - borda.BorderWidth;
                        y = location.Y + height + borda.Padding[1] - TBR - borda.BorderWidth;
                        desenhador.FillEllipse(brush, x, y, diametro, diametro);
                        //Desenhador.SmoothingMode = SmoothingMode.None;
                        desenhador.FillEllipse(erase, x + borda.BorderWidth, y + borda.BorderWidth, diametro - TBW, diametro - TBW);
                        //Desenhador.SmoothingMode = SmoothingMode.AntiAlias;

                        // Circulo Inferior Esquerdo
                        x = location.X - borda.Padding[0];
                        y = location.Y + height + borda.Padding[1] - TBR - borda.BorderWidth;
                        desenhador.FillEllipse(brush, x, y, diametro, diametro);
                        //Desenhador.SmoothingMode = SmoothingMode.None;
                        desenhador.FillEllipse(erase, x + borda.BorderWidth, y + borda.BorderWidth, diametro - TBW, diametro - TBW);
                        //Desenhador.SmoothingMode = SmoothingMode.AntiAlias;

                        // Retangulo Horizontal
                        x = location.X - borda.Padding[0];
                        y = location.Y - borda.Padding[1] + borda.BorderRadius;
                        largura = width + 2 * borda.Padding[0];
                        altura = (location.Y + height + borda.Padding[1] - borda.BorderRadius) - y;
                        desenhador.FillRectangle(brush, x, y, largura, altura);
                        //Desenhador.SmoothingMode = SmoothingMode.None;
                        desenhador.FillRectangle(erase, x + borda.BorderWidth, y, largura - TBW, altura);
                        //Desenhador.SmoothingMode = SmoothingMode.AntiAlias;

                        // Retangulo Vertical
                        x = location.X - borda.Padding[0] + borda.BorderRadius;
                        y = location.Y - borda.Padding[1];
                        largura = location.X + width + borda.Padding[0] - borda.BorderRadius - x;
                        altura = height + 2 * borda.Padding[1];
                        desenhador.FillRectangle(brush, x, y, largura, altura);
                        //Desenhador.SmoothingMode = SmoothingMode.None;
                        desenhador.FillRectangle(erase, x, y + borda.BorderWidth, largura, altura - TBW);
                        //Desenhador.SmoothingMode = SmoothingMode.AntiAlias;
                    }
                }
            }

            // Desenha efetivamente a borda feita em Desenho, em BackgroundImage do Form
            desenhador = Graphics.FromImage(backgroundOriginal);
            desenhador.DrawImage(resultado, new Point(0, 0));
            form.BackgroundImage = resultado;
            desenhador.Dispose();
        }
    }
}

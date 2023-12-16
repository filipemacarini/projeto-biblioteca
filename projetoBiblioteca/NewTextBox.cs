using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class NewTextBox
    {
        public int borderRadius;
        public int borderWidth;
        public Color borderColor;
        public TextBox textBox;
        public int[] padding;
        
        public NewTextBox(TextBox textBox, int paddingX = 10, int paddingY = 8)
        {
            this.textBox = textBox;
            this.padding = new int[] { paddingX, paddingY };
        }

        public void CriarBorda(Graphics graphics, Color borderColor, int borderWidth, int borderRadius = 0)
        {
            this.borderColor = borderColor;
            this.borderWidth = borderWidth;
            this.borderRadius = borderRadius;

            //graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Brush brush = new SolidBrush(borderColor);
            int x = textBox.Location.X - this.padding[0];
            int y = textBox.Location.Y - this.padding[1];
            int largura = textBox.Width + 2 * this.padding[0];
            int altura = textBox.Height + 2 * this.padding[1];
            graphics.FillRectangle(brush, x, y, largura, altura);

            brush = new SolidBrush(Color.White);
            x += borderWidth;
            y += borderWidth;
            largura = textBox.Width + 2 * (this.padding[0] - borderWidth);
            altura = textBox.Height + 2 * (this.padding[1] - borderWidth);
            graphics.FillRectangle(brush, x, y, largura, altura);

            //g.FillRectangle(redBrush, x, y + raioBordas, largura, altura - 2 * raioBordas);
            //g.FillEllipse(redBrush, x, y, 2 * raioBordas, 2 * raioBordas);
            //g.FillEllipse(redBrush, x + largura - 2 * raioBordas, y, 2 * raioBordas, 2 * raioBordas);

            brush.Dispose();
        }
    }
}

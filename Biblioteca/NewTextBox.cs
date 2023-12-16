using System;
using System.Collections.Generic;
using System.Drawing;
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

        public void CriarBorda(Graphics graphics, Color bColor, int bWidth, int bRadius = 5)
        {
            this.borderColor = bColor;
            this.borderWidth = bWidth;
            this.borderRadius = bRadius;

            //graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Brush brush = new SolidBrush(borderColor);
            Brush erase = new SolidBrush(Color.White);

            /*
            int x = textBox.Location.X - this.padding[0];
            int y = textBox.Location.Y - this.padding[1];
            int largura = textBox.Width + 2 * this.padding[0];
            int altura = textBox.Height + 2 * this.padding[1];
            graphics.FillRectangle(brush, x, y, largura, altura);
            graphics.FillRectangle(erase, x + borderWidth, y + borderWidth, largura - 2 * borderWidth, altura - 2 * borderWidth);
            */

            int x = textBox.Location.X - this.padding[0];
            int y = textBox.Location.Y - this.padding[1];
            int largura = 2 * borderRadius;
            int altura = 2 * borderRadius;
            graphics.FillEllipse(brush, x, y, largura, altura);
            graphics.FillEllipse(erase, x + borderWidth, y + borderWidth, largura - 2 * borderWidth, altura - 2 * borderWidth);

            x = textBox.Location.X + textBox.Width + this.padding[0] - 2 * borderRadius;
            y = textBox.Location.Y - this.padding[1];
            graphics.FillEllipse(brush, x, y, largura, altura);
            graphics.FillEllipse(erase, x + borderWidth, y + borderWidth, largura - 2 * borderWidth, altura - 2 * borderWidth);

            x = textBox.Location.X - this.padding[0];
            y = textBox.Location.Y + textBox.Height + this.padding[1] - 2 * borderRadius;
            graphics.FillEllipse(brush, x, y, largura, altura);
            graphics.FillEllipse(erase, x + borderWidth, y + borderWidth, largura - 2 * borderWidth, altura - 2 * borderWidth);

            x = textBox.Location.X + textBox.Width + this.padding[0] - 2 * borderRadius;
            y = textBox.Location.Y + textBox.Height + this.padding[1] - 2 * borderRadius;
            graphics.FillEllipse(brush, x, y, largura, altura);
            graphics.FillEllipse(erase, x + borderWidth, y + borderWidth, largura - 2 * borderWidth, altura - 2 * borderWidth);
                
            x = textBox.Location.X - this.padding[0];
            y = textBox.Location.Y - this.padding[1] + borderRadius;
            largura = textBox.Width + 2 * this.padding[0];
            altura = (textBox.Location.Y + textBox.Height + this.padding[1] - borderRadius) - y;
            graphics.FillRectangle(brush, x, y, largura, altura);
            graphics.FillRectangle(erase, x + borderWidth, y, largura - 2 * borderWidth, altura);

            x = textBox.Location.X - this.padding[0] + borderRadius;
            y = textBox.Location.Y - this.padding[1];
            largura = (textBox.Location.X + textBox.Width + this.padding[0] - borderRadius) - x;
            altura = textBox.Height + 2 * this.padding[1];
            graphics.FillRectangle(brush, x, y, largura, altura);
            graphics.FillRectangle(erase, x, y + borderWidth, largura, altura - 2 * borderWidth);

            brush.Dispose();
            erase.Dispose();
        }
    }
}

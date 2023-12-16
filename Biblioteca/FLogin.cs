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

namespace Biblioteca
{
    public partial class FLogin : Form
    {

        public FLogin()
        {
            InitializeComponent();
        }
        private void FLogin_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
        }

        private void FLogin_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}

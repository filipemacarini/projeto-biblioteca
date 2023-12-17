namespace Biblioteca
{
    partial class FLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            PnConta = new Panel();
            pictureBox1 = new PictureBox();
            PnConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PnConta
            // 
            PnConta.Anchor = AnchorStyles.Top;
            PnConta.BackColor = Color.Transparent;
            PnConta.Controls.Add(pictureBox1);
            PnConta.Location = new Point(12, 12);
            PnConta.Name = "PnConta";
            PnConta.Size = new Size(392, 500);
            PnConta.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logoLibraryFilipeMedioPequeno;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(392, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(416, 522);
            Controls.Add(PnConta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conta";
            SizeChanged += FLogin_SizeChanged;
            PnConta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnConta;
        private PictureBox pictureBox1;
    }
}
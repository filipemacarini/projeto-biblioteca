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
            textBox1 = new TextBox();
            TbTeste = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gray;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(86, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 18);
            textBox1.TabIndex = 1;
            textBox1.Text = "Um pequeno teste";
            // 
            // TbTeste
            // 
            TbTeste.BackColor = Color.White;
            TbTeste.BorderStyle = BorderStyle.None;
            TbTeste.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TbTeste.Location = new Point(86, 130);
            TbTeste.Name = "TbTeste";
            TbTeste.Size = new Size(135, 18);
            TbTeste.TabIndex = 0;
            TbTeste.Text = "Um pequeno teste";
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(339, 361);
            Controls.Add(textBox1);
            Controls.Add(TbTeste);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conta";
            Paint += FLogin_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox TbTeste;
    }
}

namespace Loja.UI
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.Consulta = new System.Windows.Forms.ToolStripMenuItem();
            this.Sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cadastro,
            this.Consulta,
            this.Sobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Cadastro
            // 
            this.Cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(66, 20);
            this.Cadastro.Text = "&Cadastro";
            // 
            // Consulta
            // 
            this.Consulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem1});
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(66, 20);
            this.Consulta.Text = "Consulta";
            // 
            // Sobre
            // 
            this.Sobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.Sobre.Name = "Sobre";
            this.Sobre.Size = new System.Drawing.Size(49, 20);
            this.Sobre.Text = "&Sobre";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // estoqueToolStripMenuItem1
            // 
            this.estoqueToolStripMenuItem1.Name = "estoqueToolStripMenuItem1";
            this.estoqueToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.estoqueToolStripMenuItem1.Text = "Estoque";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Cadastro;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Consulta;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Sobre;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
    }
}
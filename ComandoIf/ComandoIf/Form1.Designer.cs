
namespace ComandoIf
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIdade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIdade
            // 
            this.btnIdade.Location = new System.Drawing.Point(406, 253);
            this.btnIdade.Name = "btnIdade";
            this.btnIdade.Size = new System.Drawing.Size(75, 23);
            this.btnIdade.TabIndex = 0;
            this.btnIdade.Text = "Ok";
            this.btnIdade.UseVisualStyleBackColor = true;
            this.btnIdade.Click += new System.EventHandler(this.btnIdade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite a idade para saber se é maior de idade ou não";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(405, 164);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 23);
            this.txtIdade.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIdade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIdade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdade;
    }
}


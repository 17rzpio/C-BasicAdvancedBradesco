
namespace ComandoWhile
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
            this.btnWhile = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.lstContador = new System.Windows.Forms.ListBox();
            this.btnContador = new System.Windows.Forms.Button();
            this.lstResposta = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnTabuada = new System.Windows.Forms.Button();
            this.cboAnos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboAnos2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(699, 36);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(75, 23);
            this.btnWhile.TabIndex = 0;
            this.btnWhile.Text = "Contar";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(699, 9);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(57, 15);
            this.lblContador.TabIndex = 1;
            this.lblContador.Text = "Contador";
            // 
            // lstContador
            // 
            this.lstContador.FormattingEnabled = true;
            this.lstContador.ItemHeight = 15;
            this.lstContador.Location = new System.Drawing.Point(654, 299);
            this.lstContador.Name = "lstContador";
            this.lstContador.Size = new System.Drawing.Size(120, 94);
            this.lstContador.TabIndex = 2;
            // 
            // btnContador
            // 
            this.btnContador.Location = new System.Drawing.Point(681, 399);
            this.btnContador.Name = "btnContador";
            this.btnContador.Size = new System.Drawing.Size(75, 23);
            this.btnContador.TabIndex = 3;
            this.btnContador.Text = "Contar";
            this.btnContador.UseVisualStyleBackColor = true;
            this.btnContador.Click += new System.EventHandler(this.btnContador_Click);
            // 
            // lstResposta
            // 
            this.lstResposta.FormattingEnabled = true;
            this.lstResposta.ItemHeight = 15;
            this.lstResposta.Location = new System.Drawing.Point(297, 150);
            this.lstResposta.Name = "lstResposta";
            this.lstResposta.Size = new System.Drawing.Size(120, 94);
            this.lstResposta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(326, 71);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 6;
            // 
            // btnTabuada
            // 
            this.btnTabuada.Location = new System.Drawing.Point(297, 110);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(115, 23);
            this.btnTabuada.TabIndex = 7;
            this.btnTabuada.Text = "Calcular Tabuada";
            this.btnTabuada.UseVisualStyleBackColor = true;
            this.btnTabuada.Click += new System.EventHandler(this.btnTabuada_Click);
            // 
            // cboAnos
            // 
            this.cboAnos.FormattingEnabled = true;
            this.cboAnos.Location = new System.Drawing.Point(294, 329);
            this.cboAnos.Name = "cboAnos";
            this.cboAnos.Size = new System.Drawing.Size(121, 23);
            this.cboAnos.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "com laço for:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "com while";
            // 
            // cboAnos2
            // 
            this.cboAnos2.FormattingEnabled = true;
            this.cboAnos2.Location = new System.Drawing.Point(287, 404);
            this.cboAnos2.Name = "cboAnos2";
            this.cboAnos2.Size = new System.Drawing.Size(121, 23);
            this.cboAnos2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboAnos2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboAnos);
            this.Controls.Add(this.btnTabuada);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstResposta);
            this.Controls.Add(this.btnContador);
            this.Controls.Add(this.lstContador);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnWhile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.ListBox lstContador;
        private System.Windows.Forms.Button btnContador;
        private System.Windows.Forms.ListBox lstResposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnTabuada;
        private System.Windows.Forms.ComboBox cboAnos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboAnos2;
    }
}


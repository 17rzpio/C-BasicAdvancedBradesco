using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Loja.UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Cadastro_usuario();
          //  childForm.Form2 = this;
            childForm.Show();
        }
    }
}

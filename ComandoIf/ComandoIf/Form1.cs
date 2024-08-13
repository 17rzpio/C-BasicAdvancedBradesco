using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComandoIf
{
    public partial class Form1 : Form
    {
        int aux = 0;
        public Form1()
        {
            

            InitializeComponent();

            txtIdade.Text = aux.ToString();
        }

        private void btnIdade_Click(object sender, EventArgs e)
        {
            aux = Convert.ToInt32(txtIdade.Text);
            if (aux >= 18)
            {
                MessageBox.Show("Maior de Idade","Resposta");
            }
            else
            {
                MessageBox.Show("Menor de Idade","Resposta");
            }

        }
    }
}

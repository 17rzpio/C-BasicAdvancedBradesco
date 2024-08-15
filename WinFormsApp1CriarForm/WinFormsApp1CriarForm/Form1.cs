using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1CriarForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World","Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string nome;
            nome = "Seja Bem Vindo!";
            txtNome.Text = nome;
        }
    }
}

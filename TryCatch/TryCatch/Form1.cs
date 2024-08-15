using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            try
            {
                num1 = int.Parse(txtNum1.Text);
                num2 = int.Parse(txtNum2.Text);
                resultado = num1 + num2;
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite apenas valores numéricos", "Catch");
            }
            finally
            {
                MessageBox.Show("Apert ok p sair");
                Close();
            }

        }
    }
}

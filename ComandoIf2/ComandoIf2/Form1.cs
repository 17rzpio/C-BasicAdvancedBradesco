using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComandoIf2
{
    public partial class Form1 : Form
    {
        double aux = 0, Altura, Peso;

        private void cboSelecao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aux2;
            aux2=Convert.ToString(cboSelecao.SelectedItem);
            switch (aux2)
            {
                case "A": 
                MessageBox.Show("escolheu a", "Resposta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;
                case "B": 
                MessageBox.Show("escolheu b", "Resposta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;
                default: MessageBox.Show("escolheu c", "Resposta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();

            txtAltura.Text = Convert.ToString(aux);
            txtPeso.Text = Convert.ToString(aux);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Altura = Convert.ToDouble(txtAltura.Text);
            Peso = Convert.ToDouble(txtPeso.Text);
            aux = (Peso) / (Altura * Altura);
            if (aux <= 18.49){
                MessageBox.Show("Você está abaixo do peso.","Resposta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            } else if (aux <= 24.99)
            {
                MessageBox.Show("Você está com peso dentro da normalidade.", "Resposta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else if (aux <= 29.99)
            {
                MessageBox.Show("Você está acima do peso.", "Resposta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else if (aux <= 34.99)
            {
                MessageBox.Show("Atenção você está com Obesidade Grau I", "Resposta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (aux <= 39.99)
            {
                MessageBox.Show("Atenção você está com Obesidade grau II", "Resposta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (aux > 39.99)
            {
                MessageBox.Show("Atenção, você está com Obesidade Grau III", "Resposta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace login2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[4];
            vetor[0] = 7;
            vetor[1] = 3;
            vetor[2] = 5;
            vetor[3] = 1;
            int valor = vetor[1];
            System.Array.Sort(vetor);
            for(int index =0; index<4; index++)
            {
                MessageBox.Show(vetor[index].ToString(),"Array");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] semana = new string[7];
            semana[0] = "Domingo";
            semana[1] = "Segunda-feira";
            semana[2] = "Terça-feira";
            semana[3] = "Quarta-feira";
            semana[4] = "Quinta-feira";
            semana[5] = "Sexta-feira";
            semana[6] = "Sábado";

            string valor = semana[1];
            for(int index=0; index < semana.Length; index++)
            {
                MessageBox.Show(semana[index],"Array",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double[,] media = new double[2, 4];
            double media2=0;
            media[0, 0] = Convert.ToDouble(txtNota1Curso1.Text);
            media[0, 1] = Convert.ToDouble(txtNota2Curso1.Text);
            media[0, 2] = Convert.ToDouble(txtNota3Curso1.Text);
            media[1, 0] = Convert.ToDouble(txtNota1Curso2.Text);
            media[1, 1] = Convert.ToDouble(txtNota2Curso2.Text);
            media[1, 2] = Convert.ToDouble(txtNota3Curso2.Text);
            for(int index = 0; index < 3; index++)
            {
                media2 = (media[0, index] + media2) / 2;
            }
            MessageBox.Show("media curso 1: "+ media2);
            for(int index = 0; index < 3; index++)
            {
                media2 = (media[1, index] + media2) / 2;
            }
            MessageBox.Show("media curso 2: "+ media2);

        }
    }
}

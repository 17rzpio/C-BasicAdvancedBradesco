using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComandoWhile
{
    public partial class Form1 : Form
    {
        int nulo = 0;
        public Form1()
        {
            InitializeComponent();

            txtNumero.Text = Convert.ToString(nulo);

            for(int ano = 2021; ano > 0; ano--) { 

            cboAnos.Items.Add(ano);
                }

            int ano2 = 2016;
            while (ano2 > 1950)
            {
                cboAnos2.Items.Add(ano2);
                ano2--;
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int c = 0;
            while (c < 1000)
            {
                c++;
                lblContador.Text = Convert.ToString(c);
                lblContador.Refresh();
            }
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            int numero = 0;
            while (numero <= 10)
            {
                lstContador.Items.Add(numero);
                numero++;
            }
            numero = 0;

            int numero2 = 11;
            
            do
            {
                lstContador.Items.Add(numero2);
                numero2+=3;
            } while (numero2 < 100);

            for (numero2 = 0; numero2 < 10; numero2++)
            {
                lstContador.Items.Add(numero2);
            }
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            int aux = 0;
            int aux2, resposta;
            aux2 = int.Parse(txtNumero.Text);
            while (aux < 11)
            {
                resposta = aux2 * aux;
                lstResposta.Items.Add(String.Concat(aux, " * ", aux2, " = ", resposta));

                aux++;
                
            }

        }
    }
}

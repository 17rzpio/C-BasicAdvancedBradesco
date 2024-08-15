using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cantina
{
    public partial class Form1 : Form
    {
        string[] produtos = new string[10];
        string[] codigo = new string[10];
        double[] valor = new double[10];
        double soma;


        public Form1()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {/*
            if (txtCodigo.Text.Length == 5)
            {
                lstCaixa.Items.Add(txtCodigo.Text);
                txtCodigo.Text = "";
                txtCodigo.Focus();
            }*/
            if (txtCodigo.Text.Length == 3)
            {
                int indice = 0;
                for(int prod = 1; prod < codigo.Length; prod++)
                {
                    if (txtCodigo.Text == codigo[prod])
                    {
                        indice = prod;
                    }
                }
                if (indice== 0)
                    {
                        MessageBox.Show("Produto nao encrontrado");
                    }
                    else
                    {
                        lstCaixa.Items.Add(txtCodigo.Text + " -- " + produtos[indice] + "-- R$" + valor[indice]);
                        soma = soma + valor[indice];
                        label3.Text = ("Valor Total R$ " + soma);
                        picImagem.ImageLocation = "C:/imagem/" + codigo[indice] + ".jpg";
                        txtCodigo.Text = "";
                        txtCodigo.Focus();

                    }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarArray();
            soma = 0;

        }
        private void carregarArray()
        {
            codigo[1] = "001";
            codigo[2] = "002";
            codigo[3] = "003";
            codigo[4] = "004";
            codigo[5] = "005";
            produtos[1] = "Pastel";
            produtos[2] = "hot dog";
            produtos[3] = "Pastelzinho";
            produtos[4] = "sanduiche";
            produtos[5] = "sanduichinho";
            valor[1] = 9;
            valor[2] = 8;
            valor[3] = 39;
            valor[4] = 18;
            valor[5] = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1Calculadora2
{
    
    public partial class Form1 : Form
    {
        float valor1=0;
        public int digito = 0;
        string display;
        Boolean valorInicial = true;
        Boolean valorInicialmenos = true;
        Boolean valorInicialvezes = true;
        Boolean valorInicialdivisao = true;
        Boolean valorInicialresto = true;
        float valor3=0;
        public int valorDigitado(int valor2)
        {
            int valor4;
            if (digito == 0)
            {

                txtResposta.Text = valor2.ToString();
                digito++;
                return (valor2);
                
            } else if (digito == 7)
            {
                valor4 = (int)valor1;
                return (valor4);
            }
            valor1 *= 10;
            valor4=(int)valor1;
            valor2 += valor4;
            valor1 = valor2;
            txtResposta.Text= valor2.ToString();
            digito++;
            return (valor2);
        }
        public void operacao(string operador)
        {
            
            
                if (operador == "soma") {
                if (valorInicial == true)
                {
                    valorInicialmenos = true;
                    valorInicialvezes = true;
                    valorInicialdivisao = true;
                    valorInicialresto = true;
                    valorInicial = false;
                    valor3 = valor1;
                    digito = 0;
                }
                else
                {
                    valor1 += valor3;
                    valorInicial = true;
                }
                }
                if (operador == "menos")
                {
                if (valorInicialmenos == true)
                {
                    valorInicial = true;
                    valorInicialvezes = true;
                    valorInicialdivisao = true;
                    valorInicialresto = true;
                    valorInicialmenos = false;
                    valor3 = valor1;
                    digito = 0;
                }
                else
                {
                    valor3 -= valor1;
                    valor1 = valor3;
                    valorInicialmenos = true;
                }
                }
                if (operador == "vezes")
                {
                if (valorInicialvezes == true)
                {
                    valorInicialmenos = true;
                    valorInicial = true;
                    valorInicialdivisao = true;
                    valorInicialresto = true;
                    valorInicialvezes = false;
                    valor3 = valor1;
                    digito = 0;
                }
                else
                {
                    valor1 *= valor3;

                    valorInicialvezes = true;
                }
                }
                if (operador == "divisao")
                {
                if (valorInicialdivisao == true)
                {
                    valorInicialmenos = true;
                    valorInicialvezes = true;
                    valorInicial = true;
                    valorInicialresto = true;
                    valorInicialdivisao = false;
                    valor3 = valor1;
                    digito = 0;
                }
                else
                {
                    valor3 /= valor1;
                    valor1 = valor3;

                    valorInicialdivisao = true;
                }
                }
                if (operador == "resto")
                {
                if (valorInicialresto == true)
                {
                    valorInicialmenos = true;
                    valorInicialvezes = true;
                    valorInicialdivisao = true;
                    valorInicial = true;
                    valorInicialresto = false;
                    valor3 = valor1;
                    digito = 0;
                }
                else
                {
                    valor3 %= valor1;
                    valor1 = valor3;

                    valorInicialresto = true;
                }
                }
                txtResposta.Text = valor1.ToString();
                valor3 = valor1;
                valor1 = 0;
                digito = 0;
            
        }

public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            valor1 = valorDigitado(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valor1 = valorDigitado(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor1 = valorDigitado(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = valorDigitado(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            valor1 = valorDigitado(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            valor1 = valorDigitado(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            valor1 = valorDigitado(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            valor1 = valorDigitado(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            valor1 = valorDigitado(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            valor1 = valorDigitado(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operacao("soma");

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (digito != 0)
            {
                operacao("menos");
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (digito != 0)
            {
                operacao("vezes");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (digito != 0)
            {
                operacao("divisao");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (digito != 0)
            {
                operacao("resto");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (digito == 0)
            {
                txtResposta.Text = valor1.ToString();

            }
            if(digito!=0)
            {
                if (valorInicial == false)
                {
                    valor1 += valor3;
                    txtResposta.Text = valor1.ToString();
                    valor3 = valor1;
                    valor1 = 0;
                    digito = 0;
                    valorInicial = true;
                }
                if (valorInicialmenos == false)
                {

                    valor3 -= valor1;
                    valor1 = valor3;
                    txtResposta.Text = valor1.ToString();
                    valor3 = valor1;
                    valor1 = 0;
                    digito = 0;
                    valorInicialmenos = true;
                }
                if (valorInicialvezes == false)
                {
                    valor1 *= valor3;
                    txtResposta.Text = valor1.ToString();
                    valor3 = valor1;
                    valor1 = 0;
                    digito = 0;
                    valorInicialvezes = true;

                }
                if (valorInicialdivisao == false)
                {
                    valor3 /= valor1;
                    valor1 = valor3;
                    txtResposta.Text = valor1.ToString();
                    valor3 = valor1;
                    valor1 = 0;
                    digito = 0;
                    valorInicialdivisao = true;

                }
                if (valorInicialresto == false)
                {

                    valor3 %= valor1;
                    valor1 = valor3;
                    txtResposta.Text = valor1.ToString();
                    valor3 = valor1;
                    valor1 = 0;
                    digito = 0;
                    valorInicialresto = true;
                }
            }
        }
    }
}

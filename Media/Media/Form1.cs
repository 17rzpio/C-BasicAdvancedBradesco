using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int nulo = 0;
            txtNota1.Text=nulo.ToString();
            txtNota2.Text=nulo.ToString();
            txtNota3.Text=nulo.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1=0, nota2=0, nota3=0;
            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            nota3 = Convert.ToDouble(txtNota3.Text);
            double[] media ={ nota1,nota2,nota3};
            double media2 = media.Average();
            lblResposta.Text = Convert.ToString(media2);

        }
    }
}

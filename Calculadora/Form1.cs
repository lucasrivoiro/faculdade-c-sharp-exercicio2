using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            ClassSair saida = new ClassSair();
            saida.fim();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double[] nota = new double[4];

            nota[0] = Convert.ToDouble(n1.Text);
            nota[1] = Convert.ToDouble(n2.Text);
            nota[2] = Convert.ToDouble(n3.Text);
            nota[3] = Convert.ToDouble(n4.Text);

            double acumulado = 0;

            foreach (var soma in nota)
            {
                acumulado += soma;
            }

            double media = Math.Round((acumulado / 4), 4);

            MessageBox.Show(Convert.ToString(media));
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            n1.Clear();
            n2.Clear();
            n3.Clear();
            n4.Clear();
        }
    }
}

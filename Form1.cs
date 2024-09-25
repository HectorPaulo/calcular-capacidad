using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularCapacidad
{
    public partial class CalcularCapacidad : Form
    {
        public CalcularCapacidad()
        {
            InitializeComponent();
        }

        private void CalcularCapacidad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v;

            if (ckCubo.Checked)
            {
                if (txtBase.Text == txtAltura.Text && txtAltura.Text == txtAltura2.Text)
                {
                    double lado = Convert.ToDouble(txtBase.Text);
                    v = Math.Pow(lado, 3);
                    MessageBox.Show("Volumen del cubo = " + v);
                }
                else
                {
                    MessageBox.Show("Para un cubo, todas las dimensiones deben ser iguales.");
                }
            }

            if (ckPrismaRectangular.Checked)
            {
                double largo = Convert.ToDouble(txtBase.Text);
                double ancho = Convert.ToDouble(txtAltura.Text);
                double altura = Convert.ToDouble(txtAltura2.Text);
                v = largo * ancho * altura;
                MessageBox.Show("Volumen del prisma rectangular = " + v);
            }

            if (ckPrismaCuadrangular.Checked)
            {
                double lado = Convert.ToDouble(txtBase.Text);
                double altura = Convert.ToDouble(txtAltura2.Text);
                v = Math.Pow(lado, 2) * altura;
                MessageBox.Show("Volumen del prisma cuadrangular = " + v);
            }

            if (ckCilindro.Checked)
            {
                double pi = 3.14159;
                double radio = Convert.ToDouble(txtBase.Text);
                double altura = Convert.ToDouble(txtAltura2.Text);
                v = pi * (radio * radio) * altura;
                MessageBox.Show("Volumen del cilindro = " + v);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosPositivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            double valor1 = 0;
            double valor2 = 0;
            double result = 0;

            valor1 = Convert.ToDouble(txtPrimerValor.Text);
            valor2 = Convert.ToDouble(txtSegundoValor.Text );

            if(valor1 > valor2) 
            {
                result = valor1 - valor2;

                txtResultado.Text = Convert.ToString(result);
            }

            if (valor2 > valor1)
            {
                result = valor2 - valor1;

                txtResultado.Text = Convert.ToString(result);

            }






        }
    }
}

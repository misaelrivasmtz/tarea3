using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double resultado, altura, peso;
            altura = Convert.ToDouble(txtValorEstatura.Text);
            peso = Convert.ToDouble(txtValorPeso.Text);
            resultado = Math.Round((peso / Math.Pow(altura, 2)), 2);
            MessageBox.Show("IMC: " + resultado);
        }

        public void btnEndocrinologia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visitar sitio Web");
        }
    }
}
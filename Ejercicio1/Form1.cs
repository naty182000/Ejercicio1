using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void respuesta_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string opcion = comboBox1.Text;
            double v1 = double.Parse(txtvalor1.Text);
            double v2 = double.Parse(txtvalor2.Text);
            double resultado = 0;

            switch (opcion)
            {
                case "Suma":
                    resultado = v1 + v2;
                    MessageBox.Show("El resultado de la suma es: " + resultado);
                    break;
                case "Resta":
                    resultado = v1 - v2;
                    MessageBox.Show("El resultado de la resta es: " + resultado);
                    break;
                case "Multiplicacion":
                    resultado = v1 * v2;
                    MessageBox.Show("El resultado de la multiplicacion es: " + resultado);
                    break;
                case "Division":
                    resultado = v1 / v2;
                    MessageBox.Show("El resultado de la division es: " + resultado);
                    break;

            }
        }

        
        private void txtvalor1_TextChanged(object sender, EventArgs e)
        {
            string num1;
            num1 = txtvalor1.Text;

            if(num1 == "")
            {
                MessageBox.Show("Debe ingresar un numero");
            }
         
        }

        private void txtvalor2_TextChanged(object sender, EventArgs e)
        {
            string num2;
            num2 = txtvalor2.Text;

            if (num2 == "")
            {
                MessageBox.Show("Debe ingresar un numero");
            }

        }
    }

}

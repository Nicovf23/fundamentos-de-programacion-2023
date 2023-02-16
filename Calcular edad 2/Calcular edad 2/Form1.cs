using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_edad_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaDeNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - dtpFechaDeNacimiento.Value.Year;
            if (fechaActual < dtpFechaDeNacimiento.Value.AddYears(edad)) edad--;
            lblEdad.Text = "Tienes:" + edad.ToString() + "años"; 
            
            }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }  
}

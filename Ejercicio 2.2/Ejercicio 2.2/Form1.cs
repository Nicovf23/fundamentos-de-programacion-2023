using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Adicionar elementos 
            lstFrutas.Items.Add("Banana");
            lstFrutas.Items.Add("Durazno");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            lstFrutas.Items.Add(txtFruta.Text);

            lstFruta.Text = "string.Emty;
        }
    }
}

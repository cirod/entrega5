using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMayorEdad
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona1 = new Persona(txtNombre.Text, int.Parse(txtEdad.Text));

            if (persona1.Edad >= 18)
            {
                MessageBox.Show("La edad de " + persona1.Nombre + " tiene: " + persona1.Edad + " es mayor de Edad");
            }
            else
            {
                MessageBox.Show("La edad de " + persona1.Nombre + " tiene: " + persona1.Edad + " es menor de Edad");
            }
            }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComboBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox2.Items.Add("Rojo");
            comboBox2.Items.Add("verde");
            comboBox2.Items.Add("Azul");
            comboBox2.Items.Add("Amarillo");
            comboBox2.Items.Add("gris");
            comboBox2.Items.Add("marron");
            comboBox2.Items.Add("violeta");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a=comboBox2.Text;
            label1.Text=a;
        }

       
    }
}

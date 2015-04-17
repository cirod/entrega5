using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i <= 255; i++)
            {
                rbdrojo.Items.Add(i.ToString());
                rbdVerde.Items.Add(i.ToString());
                rbdAzul.Items.Add(i.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rojo, verde, azul;
            rojo = int.Parse(rbdrojo.Text);
            verde = int.Parse(rbdVerde.Text);
            azul = int.Parse(rbdAzul.Text);
            BackColor = Color.FromArgb(rojo, verde, azul);

        }
    }
}

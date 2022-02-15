using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           

        }

        private void button2_Click(object sender, EventArgs e)
        {

                
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice=cmbPeliculas.SelectedIndex;
            if (indice == 0)
            {
                pictureBox1.Image = proyecto1.Properties.Resources.Avengers;
            }
            if (indice == 1)
            {
                pictureBox1.Image = proyecto1.Properties.Resources.Spide_rman;
            }
            if (indice == 2)
            {
                pictureBox1.Image = proyecto1.Properties.Resources.Insidious;
            }
            if (indice == 3)
            {
                pictureBox1.Image = proyecto1.Properties.Resources.John_Wick;
            }
            if (indice == 4)
            {
                pictureBox1.Image = proyecto1.Properties.Resources.Son_como_niños;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

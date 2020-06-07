using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Prestamo_de_Libros
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            fanta_UC1.BringToFront();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            romance_UC1.BringToFront();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            juveniles_UC1.BringToFront();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            ciencia_UC3.BringToFront();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            comedia_UC1.BringToFront();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            carrito_UC1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usuaPrinc1.BringToFront();
        }
    }
}

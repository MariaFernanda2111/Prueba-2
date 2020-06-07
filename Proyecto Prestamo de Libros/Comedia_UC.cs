using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Prestamo_de_Libros
{
    public partial class Comedia_UC : UserControl
    {
        public Comedia_UC()
        {
            InitializeComponent();
        }

        private void Comedia_UC_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new H1().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new H2().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            new H3().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            new H4().ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            new H5().ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            new H6().ShowDialog();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            new H7().ShowDialog();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            new H8().ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            new H9().ShowDialog();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            new H10().ShowDialog();
        }
    }
}

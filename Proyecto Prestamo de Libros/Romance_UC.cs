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
    public partial class Romance_UC : UserControl
    {
        public Romance_UC()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new R1().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new R2().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            new R3().ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            new R4().ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            new R5().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            new R6().ShowDialog();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            new R7().ShowDialog();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            new R8().ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            new R9().ShowDialog();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            new R10().ShowDialog();
        }
    }
}

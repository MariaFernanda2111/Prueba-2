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
    public partial class Juveniles_UC : UserControl
    {
        public Juveniles_UC()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new J1().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new J2().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            new J3().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            new J4cs().ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            new J5().ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            new J6().ShowDialog();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            new J7().ShowDialog();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            new J8().ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            new J9().ShowDialog();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            new J10().ShowDialog();
        }
    }
}

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
    public partial class Fanta_UC : UserControl
    {
        public Fanta_UC()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F1().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F2().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F3cs().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F4().ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F5().ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F6().ShowDialog();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F7().ShowDialog();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F8().ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F9().ShowDialog();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F10().ShowDialog();
        }
    }
}

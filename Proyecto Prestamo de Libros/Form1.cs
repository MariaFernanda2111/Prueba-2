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
    public partial class Form1 : Form
    {
        int valor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            valor += 1;
            bunifuCircleProgressbar1.Value = valor;
            if (bunifuCircleProgressbar1.Value == 100)
            {
                bunifuCircleProgressbar1.Value = 0;
                timer1.Stop();
                this.Hide();
                new Elegir().ShowDialog();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

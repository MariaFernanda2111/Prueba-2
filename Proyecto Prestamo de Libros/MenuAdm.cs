﻿using System;
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
    public partial class MenuAdm : Form
    {
        public MenuAdm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            invF1.BringToFront();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            usuario_UC1.BringToFront();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            invH1.BringToFront();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            invFi1.BringToFront();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            invR1.BringToFront();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            invJ1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admPrinc1.BringToFront();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Proyecto_Prestamo_de_Libros
{
    public partial class LoginAdm : Form
    {
        conexion f = new conexion();
        public LoginAdm()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\AM_Morales\Documents\Book.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox1.Text;
            if (usuario == " " || contraseña == " ")
            {

                MessageBox.Show("Llene todos los campos");
                return;
            }
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM RegistroAdm WHERE Nombre='"+textBox1.Text+"'and Contraseña='"+textBox2.Text+"'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            this.Hide();
            new MenuAdm().ShowDialog();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegistroAdm().ShowDialog();
        }
    }
}

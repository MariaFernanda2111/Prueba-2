using System;
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
    public partial class Registrarse : Form
    {
        conexion f = new conexion();
        public Registrarse()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\AM_Morales\Documents\Book.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            con.Open();
            sql = "INSERT INTO Registro(Nombre, Apellido, Edad, Sexo, Telefono, Contraseña) VALUES(@Nombre, @Apellido, @Edad, @Sexo, @Telefono, @Contraseña)";
            f.cmd = new OleDbCommand(sql, con);
            f.cmd.Parameters.AddWithValue("@Nombre", textBox1.Text);
            f.cmd.Parameters.AddWithValue("@Apellido", textBox2.Text);
            f.cmd.Parameters.AddWithValue("@Edad", textBox3.Text);
            f.cmd.Parameters.AddWithValue("@Sexo", comboBox1.Text);
            f.cmd.Parameters.AddWithValue("@Telefono", textBox4.Text);
            f.cmd.Parameters.AddWithValue("@Contraseña", textBox5.Text);
            f.cmd.ExecuteNonQuery();
            MessageBox.Show("Registrado");
            con.Close();
            this.Hide();
            new Login().ShowDialog();
            
        }
    }
}

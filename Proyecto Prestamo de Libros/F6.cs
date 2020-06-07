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
    public partial class F6 : Form
    {
        conexion f = new conexion();
        public F6()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\AM_Morales\Documents\Book.mdb");
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            string sql;
            con.Open();
            sql = "INSERT INTO Carrito(Libro, Precio, Unidades) VALUES(@Nombre, @Precio, @Unidades)";
            f.cmd = new OleDbCommand(sql, con);
            f.cmd.Parameters.AddWithValue("@Libro", textBox1.Text);
            f.cmd.Parameters.AddWithValue("@Precio", textBox2.Text);
            f.cmd.Parameters.AddWithValue("@Unidades", textBox3.Text);

            f.cmd.ExecuteNonQuery();
            MessageBox.Show("COMPRA EXITOSA");
            con.Close();
            this.Hide();
            new Menu().ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\AM_Morales\Documents\Visual Studio 2015\Projects\Proyecto Prestamo de Libros\alibros\fantasia\ElInvitadoTigre.pdf");
        }
    }
}

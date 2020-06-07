using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Proyecto_Prestamo_de_Libros
{
    public partial class F1_UC : UserControl
    {
        conexion f = new conexion();
        public F1_UC()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\AM_Morales\Documents\Book.mdb");
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
            string sql;
            con.Open();
            sql = "INSERT INTO Carrito(Libro, Unidades, Precio) VALUES(@Nombre, @Unidades, @Precio)";
            f.cmd = new OleDbCommand(sql, con);
            f.cmd.Parameters.AddWithValue("@Nombre", textBox1.Text);
            f.cmd.Parameters.AddWithValue("@Unidades", textBox2.Text);
            f.cmd.Parameters.AddWithValue("@Precio", textBox3.Text);
            
            f.cmd.ExecuteNonQuery();
            MessageBox.Show("COMPRA EXITOSA");
            con.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\AM_Morales\Documents\alibros\fantasia");
        }
    }
}

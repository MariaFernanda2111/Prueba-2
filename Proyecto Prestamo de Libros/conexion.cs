using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Proyecto_Prestamo_de_Libros
{
    class conexion
    {
        public OleDbCommand cmd = new OleDbCommand();
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\AM_Morales\Documents\Book.mdb");
        public void conectar()
        {
            try
            {
                con.Open();
                MessageBox.Show("Conectado");
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede conectar");
            }
        }
        public void consultas(DataGridView tabla, string sql)
        {
            try
            {
                OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tabla.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
        public void operaciones(DataGridView tabla, string sql)
        {
            con.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            con.Close();
        }
    }

}

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
    public partial class Usuario_UC : UserControl
    {
        conexion f = new conexion();
        public Usuario_UC()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\AM_Morales\Documents\Book.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            string ver;
            ver = "SELECT * FROM Registro";
            f.consultas(dataGridView1, ver);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string eliminar;
            eliminar = "DELETE FROM Registro WHERE Nombre";
            f.operaciones(dataGridView1, eliminar);
            f.consultas(dataGridView1, "SELECT * FROM Registro WHERE Nombre");
        }
    }
}

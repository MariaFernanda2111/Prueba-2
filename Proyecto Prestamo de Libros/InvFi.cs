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
    public partial class InvFi : UserControl
    {
        conexion f = new conexion();
        public InvFi()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\AM_Morales\Documents\Book.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            string ver;
            ver = "SELECT * FROM InventarioC";
            f.consultas(dataGridView1, ver);
        }
    }
}

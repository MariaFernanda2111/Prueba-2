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
    public partial class InventarioF_UC : Form
    {
        conexion f = new conexion();
        public InventarioF_UC()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\AM_Morales\Documents\Book.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            string ver;
            ver = "SELECT * FROM InventarioF";
            f.consultas(dataGridView1, ver);
        }
    }
}

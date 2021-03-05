using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Conexion conectandose = new Conexion();

        private void Button1_Click(object sender, EventArgs e)
        {
            
            conectandose.Insertar("2021-03-04", 40, "cesar", true, 4);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conectandose.Buscar();
            var id = dataGridView1.Rows[0].Cells[0].Value;
        }
    }
}

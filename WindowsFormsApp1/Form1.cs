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
            habilitar(false);
        }

        Conexion conectandose = new Conexion();

        //private void Button1_Click(object sender, EventArgs e)
        //{
            
        //    //conectandose.Insertar("2021-03-04", 40, "cesar", true, 4);
        //}

        private void Button2_Click(object sender, EventArgs e)
        {
            
            int x;

            if (!int.TryParse(txtIdentificacion.Text, out x))
            {
                MessageBox.Show("Campo identificacion debe ser numerico");
                return;
            }

            if (txtIdentificacion.Text.Length > 0)
            {
                consultar(Convert.ToInt32(txtIdentificacion.Text));
            }
            else
            {
                MessageBox.Show("La identificacio no existe");
                return;
            }
            //dataGridView1.DataSource = conectandose.Buscar();
            //var id = dataGridView1.Rows[0].Cells[0].Value;
            
        }

        private void TxtIdentificacion_Enter(object sender, EventArgs e)
        {
            //consultar(Convert.ToInt32(txtIdentificacion.Text));
        }

        private void consultar(int identificacion)
        {
            dataGridView1.DataSource = conectandose.Buscar(identificacion);
            habilitar(true);
        }

        private void habilitar(Boolean estado)
        {
            txtperiodo.Enabled = estado;
            txthoraslaboradas.Enabled = estado;
            txthoradiurna.Enabled = estado;
            txtnocturna.Enabled = estado;
            txthoradomilical.Enabled = estado;
            txthorafestivo.Enabled = estado;
            txtdescuento.Enabled = estado;
            btnpunto2.Enabled = estado;
        }

        private void Btnpunto2_Click(object sender, EventArgs e)
        {
            var id = dataGridView1.Rows[0].Cells[4].Value;

            if (txtperiodo.Text.Length > 0 && txthoraslaboradas.Text.Length > 0 && txthoradiurna.Text.Length > 0 && txtnocturna.Text.Length > 0
                && txthoradomilical.Text.Length > 0 && txthorafestivo.Text.Length > 0 && txtdescuento.Text.Length > 0)
            {
                conectandose.Insertar(Convert.ToInt32(id), txtperiodo.Text, Convert.ToInt32(txthoraslaboradas.Text), Convert.ToInt32(txthoradiurna.Text), Convert.ToInt32(txtnocturna.Text), Convert.ToInt32(txthoradomilical.Text),
                    Convert.ToInt32(txthorafestivo.Text), Convert.ToInt32(txtdescuento.Text), "cesar", "2021-03-05");
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar");
                return;
            }
        }
    }
}

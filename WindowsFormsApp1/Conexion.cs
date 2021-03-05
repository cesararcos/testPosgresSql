using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public class Conexion
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id= postgres; Password = cesar; Database = BDPruebaTecnica");

        public void Conectar()
        {
            //conn.Open();
            MessageBox.Show("Listo");


        }

        public void Insertar(string fecha, int valor, string usuario, Boolean habilitado, int id)
        {
            //fecha = DateTime.Now;

            string query = "Insert into \"arl\" values (" + id + "," + valor + ",'" + usuario + "','" + fecha + "','" + habilitado + "')";

            conn.Open();
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();
            MessageBox.Show("hecho ya guardo");
            conn.Close();
        }

        public DataTable Buscar()
        {
            string query = "select * from \"contratoslaborales\" ORDER BY idcontrato DESC LIMIT 1";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;

            //string query = "select * from \"contratoslaborales\" where \"numerodocumento\" = '31378091' ";
        }

    }
}

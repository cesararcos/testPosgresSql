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

        // PUNTO 2
        public void Insertar(int idcontrato, string periodo, int horaslabo, int horadiur, int horanoct, int horadomili, int horafestivo, int descuento, string usuario, string fecha)
        {
            //fecha = DateTime.Now;
            DataTable a = BuscarNovedad();
            int id;
            if (a != null || a.Rows.Count > 0)
            {
                id = Convert.ToInt32(a.Rows[0][0].ToString()) + 1;
            }
            else
            {
                id = 1;
            }
            //string query = "Insert into \"arl\" values (" + id + "," + valor + ",'" + usuario + "','" + fecha + "','" + habilitado + "')";
            string query = "Insert into \"novedadesnomina\" values (" + id + "," + idcontrato + ",'" + periodo + "'," + horaslabo + "," + horadiur + "," + horanoct + "," + horadomili + "," + horafestivo + "," + descuento + ",'" + usuario + "','" + fecha + "')";

            conn.Open();
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();
            MessageBox.Show("hecho ya guardo");
            conn.Close();
        }

        public DataTable Buscar(int buscar)
        {
            string query = "select a.idtipodocumento, a.numerodocumento, a.primerapellido, a.primernombre, a.idcontrato, c.nombre, b.valor, a.fechainicio, a.salario from \"contratoslaborales\" a inner join public.arl b on a.idarl = b.idarl inner join public.cargos c on a.idcargo = c.idcargo where \"numerodocumento\" = " + buscar + " ORDER BY idcontrato DESC LIMIT 1";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;

            //string query = "select * from \"contratoslaborales\" where \"numerodocumento\" = '31378091' ";
        }

        public DataTable BuscarNovedad()
        {
            string query = "select idnovedadnomina from \"novedadesnomina\" ORDER BY idcontrato DESC LIMIT 1";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;

            //string query = "select * from \"contratoslaborales\" where \"numerodocumento\" = '31378091' ";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_Abogados
{
    public class servicios
    {
        // create class construct for storing services data.
        public string ID { get; set; }
        public string Servicio { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }
        public string Abono { get; set; }
        // construct for base services Object
        public servicios()
        {
        }
        public servicios(string pid, string pservicio, string pdes, string ppre, string abono)
        {
            ID = pid;
            Servicio = pservicio;
            Descripcion = pdes;
            Precio = ppre;
            Abono = abono;
        }
        // end custructors building.
        // method for to register services to the database.
        public static int registerService(servicios pServicio)
        {
            int re = -1;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("insert into services (cService, explanation, price, pre_bono) values ('{0}', '{1}', '{2}', '{3}')",
                    pServicio.Servicio, pServicio.Descripcion, pServicio.Precio, pServicio.Abono), con);
                re = comand.ExecuteNonQuery();
                con.Close();
            }
            return re;
        }
    }
}

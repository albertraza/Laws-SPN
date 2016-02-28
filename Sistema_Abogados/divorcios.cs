using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_Abogados
{
    public class divorcios
    {
        // properties declaration;
        public string ID { get; set; }
        public string Nombre_Demandante { get; set; }
        public string Apellido_Demandante { get; set; }
        public string Nombre_Demandado { get; set; }
        public string Apellido_Demandado { get; set; }
        public string Honorarios { get; set; }
        public string Precio { get; set; }
        public string Abono { get; set; }
        // contruct building.
        public divorcios()
        {

        }
        public divorcios(string id, string nombree, string apellidoe, string nombreo, string apellidoo, string honorarios, string precio, string abono)
        {
            ID = id;
            Nombre_Demandado = nombreo;
            Nombre_Demandante = nombree;
            Apellido_Demandado = apellidoo;
            Apellido_Demandante = apellidoe;
            Honorarios = honorarios;
            Precio = precio;
            Abono = abono;
        }
        // method for registering users;
        public static int register(string ServiceID, string DemandadoID, string DemandanteID, string Pagos, string Honorarios, string Abono)
        {
            int r = -1;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("INSERT INTO divorcios (ServiceID, DemandadoID, DemandanteID, Pagos, Honorarios, Abono) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                    ServiceID, DemandadoID, DemandanteID, Pagos, Honorarios, Abono), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
    }
}

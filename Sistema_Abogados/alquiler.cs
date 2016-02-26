using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_Abogados
{
    public class alquiler
    {
        public string ID { get; set; }
        public string Ubicacion { get; set; }
        public string Detalles { get; set; }
        public string Nombre_Inquilino { get; set; }
        public string Apellido_Inquilino { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Apellido_Cliente { get; set; }
        public string Nombre_Garante { get; set; }
        public string Apellido_Garante { get; set; }
        public string Mensualidad { get; set; }
        public string Deposito { get; set; }

        public static int register(string ClienteID, string InquilinoID, string GaranteID, string ServicioID, string Mensualidad, string Honorario, string Detalles, string Direccion, string SectorID, string Deposito, string Abono)
        {
            int r = -1;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("insert into Rent (CLienteID, InquilinoID, GaranteID, ServicioID, Mensualidad, Honorario, detalles, direccion, City, Deposito, Abono) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}' ,'{6}' ,'{7}', '{8}', '{9}', '{10}')",
                    ClienteID, InquilinoID, GaranteID, ServicioID, Mensualidad, Honorario, Detalles, Direccion, SectorID, Deposito, Abono), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
    }
}

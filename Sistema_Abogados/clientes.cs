using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_Abogados
{
    public class clientes
    {
        // creating clientes variables for storing data.
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }
        public string Fecha_Registro { get; set; }

        // creating constructs for building objects.
        public clientes() { }
        public clientes(string pid, string pnombre, string papellido, string pcedula, string pstatus, string pimage, string pfecha)
        {
            ID = pid;
            Nombre = pnombre;
            Apellido = papellido;
            Cedula = pcedula;
            Status = pstatus;
            Image = pimage;
            Fecha_Registro = pfecha;
        }
        // end of building constructs ///
        // method for registering customers.
        public static int customerRegistration(clientes pClientes)
        {
            int r = -1;
            using(SqlConnection con  = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("INSERT INTO customers (name, lastname, idcard, estatus, picture, registerdate) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                    pClientes.Nombre, pClientes.Apellido, pClientes.Cedula, pClientes.Status, pClientes.Image, pClientes.Fecha_Registro), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        // method for getting customers.
        public static string getID(string name, string idcard)
        {
            string r = null;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT * FROM customers WHERE name = '{0}' AND idcard = '{1}'", name, idcard), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        r = re["ID"].ToString();
                    }
                }
                else
                {
                    r = null;
                }
                con.Close();
            }
            return r;
        }
    }
}

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
        public string Fecha_Registro { get; set; }

        // creating constructs for building objects.
        public clientes() { }
        public clientes(string pid, string pnombre, string papellido, string pcedula, string pstatus, string pfecha)
        {
            ID = pid;
            Nombre = pnombre;
            Apellido = papellido;
            Cedula = pcedula;
            Status = pstatus;
            Fecha_Registro = pfecha;
        }
        // end of building constructs ///
        // method for registering customers.
        public static int customerRegistration(clientes pClientes, string image)
        {
            int r = -1;
            using(SqlConnection con  = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("INSERT INTO customers (name, lastname, idcard, estatus, picture, registerdate) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                    pClientes.Nombre, pClientes.Apellido, pClientes.Cedula, pClientes.Status, image, pClientes.Fecha_Registro), con);
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
        // method for listing all customers.
        public static List<clientes> listAllCustomers()
        {
            List<clientes> list = new List<clientes>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand("select * from customers", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    clientes pClientes = new clientes();
                    pClientes.ID = re["ID"].ToString();
                    pClientes.Nombre = re["name"].ToString();
                    pClientes.Apellido = re["lastname"].ToString();
                    pClientes.Cedula = re["idcard"].ToString();
                    pClientes.Status = re["estatus"].ToString();
                    pClientes.Fecha_Registro = re["registerdate"].ToString();

                    list.Add(pClientes);
                }
                con.Close();
            }
            return list;
        }
        // search engine for listing customers.
        public static List<clientes> searchCustomers(string ID, string name, string lastName, string cedula, string status, string registerDate)
        {
            List<clientes> list = new List<clientes>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT * FROM customers WHERE ID LIKE '{0}%' AND name LIKE '{1}%' AND lastname LIKE '{2}%' AND idcard LIKE '{3}%' AND estatus LIKE '{4}%' AND registerdate LIKE '{5}%' ",
                    ID, name, lastName, cedula, status, registerDate), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    clientes pClientes = new clientes();
                    pClientes.ID = re["ID"].ToString();
                    pClientes.Nombre = re["name"].ToString();
                    pClientes.Apellido = re["lastname"].ToString();
                    pClientes.Cedula = re["idcard"].ToString();
                    pClientes.Status = re["estatus"].ToString();
                    pClientes.Fecha_Registro = re["registerdate"].ToString();

                    list.Add(pClientes);
                }
                con.Close();
            }
            return list;
        }
    }
}

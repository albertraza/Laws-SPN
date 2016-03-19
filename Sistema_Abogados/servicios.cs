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
                SqlCommand comand = new SqlCommand(string.Format("INSERT INTO services (cService, explanation, price, pre_bono) VALUES ('{0}', '{1}', '{2}', '{3}')",
                    pServicio.Servicio, pServicio.Descripcion, pServicio.Precio, pServicio.Abono), con);
                re = comand.ExecuteNonQuery();
                con.Close();
            }
            return re;
        }
        // method for listing all services.
        public static List<servicios> listAllServices()
        {
            List<servicios> list = new List<servicios>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand("SELECT * FROM services", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    servicios pServicios = new servicios();
                    pServicios.ID = re["ID"].ToString();
                    pServicios.Servicio = re["cService"].ToString();
                    pServicios.Descripcion = re["explanation"].ToString();
                    pServicios.Precio = re["price"].ToString();
                    pServicios.Abono = re["pre_bono"].ToString();

                    list.Add(pServicios);
                }
                con.Close();
            }
            return list;
        }
        // search engine for services
        public static List<servicios> searchServices(string id, string service, string description, string price, string pre_bono)
        {
            List<servicios> list = new List<servicios>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from services where ID like '{0}%' and cService like '{1}%' and explanation like '{2}%' and price like '{3}%' and pre_bono like '{4}%'",
                    id, service, description, price, pre_bono), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    servicios pServicios = new servicios();
                    pServicios.ID = re["ID"].ToString();
                    pServicios.Servicio = re["cService"].ToString();
                    pServicios.Descripcion = re["explanation"].ToString();
                    pServicios.Precio = re["price"].ToString();
                    pServicios.Abono = re["pre_bono"].ToString();

                    list.Add(pServicios);
                }
                con.Close();
            }
            return list;
        }
        // method for getting service info from database.
        public static servicios getServiceInfo(string ID)
        {
            servicios pServicios = new servicios();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT * FROM services WHERE ID = {0}", ID), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    pServicios.ID = re["ID"].ToString();
                    pServicios.Servicio = re["cService"].ToString();
                    pServicios.Descripcion = re["explanation"].ToString();
                    pServicios.Precio = re["price"].ToString();
                    pServicios.Abono = re["pre_bono"].ToString();
                }
                con.Close();
            }
            return pServicios;
        }
        // method for getting service ID.
        public static string getServiceID(string Servicio)
        {
            string r = null;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT ID FROM services WHERE cService = '{0}'", Servicio), con);
                r = comand.ExecuteScalar().ToString();
                con.Close();
            }
            return r;
        }
    }
}

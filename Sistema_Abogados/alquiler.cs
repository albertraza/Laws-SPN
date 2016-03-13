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
        // properties for creating an object.
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
        // **************** end properties ***************** //
        // declaring construct
        public alquiler() { }
        public alquiler(string id, string ubicacion, string detalles, string nombrein, string apellidoin, string nombrecl, string apellidocl, string nombrega, string apellidoga, string mensualidad, string deposito)
        {
            ID = id;
            Ubicacion = ubicacion;
            Detalles = detalles;
            Nombre_Inquilino = nombrein;
            Apellido_Inquilino = apellidoin;
            Nombre_Cliente = nombrecl;
            Apellido_Cliente = apellidocl;
            Nombre_Garante = nombrega;
            Apellido_Garante = apellidoga;
            Mensualidad = mensualidad;
            Deposito = deposito;
        }
        // ***************** end cosuntruts ****************** //
        // method for registering the users.
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
        // method for listing all rent
        public static List<alquiler> listAll()
        {
            List<alquiler> list = new List<alquiler>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT Rent.ID, Rent.direccion, Cities.City, Rent.detalles, Rent.Mensualidad, Rent.Honorario, Rent.Abono, Rent.Deposito, CLIENTE.name AS NombreCli, CLIENTE.lastname AS ApellidoCli, INQUILINO.name AS NombreInqui, INQUILINO.lastname AS ApellidoInqui, GARANTE.name AS NombreGara, GARANTE.lastname AS ApellidoGara FROM Rent INNER JOIN Cities ON Cities.ID = Rent.City INNER JOIN customers AS CLIENTE ON CLIENTE.ID = Rent.CLienteID INNER JOIN customers AS INQUILINO ON INQUILINO.ID = Rent.InquilinoID INNER JOIN customers AS GARANTE ON GARANTE.ID = Rent.GaranteID"), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    alquiler pAlquiler = new alquiler();
                    pAlquiler.ID = re["ID"].ToString();
                    pAlquiler.Apellido_Cliente = re["ApellidoCli"].ToString();
                    pAlquiler.Apellido_Garante = re["ApellidoGara"].ToString();
                    pAlquiler.Apellido_Inquilino = re["ApellidoInqui"].ToString();
                    pAlquiler.Deposito = re["Deposito"].ToString();
                    pAlquiler.Detalles = re["detalles"].ToString();
                    pAlquiler.Mensualidad = re["Mensualidad"].ToString();
                    pAlquiler.Nombre_Cliente = re["NombreCli"].ToString();
                    pAlquiler.Nombre_Garante = re["NombreGara"].ToString();
                    pAlquiler.Nombre_Inquilino = re["NombreInqui"].ToString();
                    pAlquiler.Ubicacion = re["direccion"].ToString();

                    list.Add(pAlquiler);
                }
                con.Close();
            }
            return list;
        }
        // method with the search engine.
        public static List<alquiler> search(string ID, string NombreIn, string ApellidoIn, string Nombrecl, string Apellidocl, string Nombrega, string Apellidoga)
        {
            List<alquiler> list = new List<alquiler>();
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT Rent.ID, Rent.direccion, Cities.City, Rent.detalles, Rent.Mensualidad, Rent.Honorario, Rent.Abono, Rent.Deposito, CLIENTE.name AS NombreCli, CLIENTE.lastname AS ApellidoCli, INQUILINO.name AS NombreInqui, INQUILINO.lastname AS ApellidoInqui, GARANTE.name AS NombreGara, GARANTE.lastname AS ApellidoGara FROM Rent INNER JOIN Cities ON Cities.ID = Rent.City INNER JOIN customers AS CLIENTE ON CLIENTE.ID = Rent.CLienteID INNER JOIN customers AS INQUILINO ON INQUILINO.ID = Rent.InquilinoID INNER JOIN customers AS GARANTE ON GARANTE.ID = Rent.GaranteID"+
                    " WHERE CLIENTE.name like '{0}%' AND CLIENTE.lastname like '{1}%' AND GARANTE.name like '{2}%' AND GARANTE.lastname like '{3}%' AND INQUILINO.name like '{4}%' AND INQUILINO.lastname like '{5}%' AND Rent.ID like '{6}%'",
                    Nombrecl, Apellidocl, Nombrega, Apellidoga, NombreIn, ApellidoIn, ID), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    alquiler pAlquiler = new alquiler();
                    pAlquiler.ID = re["ID"].ToString();
                    pAlquiler.Apellido_Cliente = re["ApellidoCli"].ToString();
                    pAlquiler.Apellido_Garante = re["ApellidoGara"].ToString();
                    pAlquiler.Apellido_Inquilino = re["ApellidoInqui"].ToString();
                    pAlquiler.Deposito = re["Deposito"].ToString();
                    pAlquiler.Detalles = re["detalles"].ToString();
                    pAlquiler.Mensualidad = re["Mensualidad"].ToString();
                    pAlquiler.Nombre_Cliente = re["NombreCli"].ToString();
                    pAlquiler.Nombre_Garante = re["NombreGara"].ToString();
                    pAlquiler.Nombre_Inquilino = re["NombreInqui"].ToString();
                    pAlquiler.Ubicacion = re["direccion"].ToString();

                    list.Add(pAlquiler);
                }
                con.Close();
            }
            return list;
        }
        public static string getID(string NombreIn, string ApellidoIn, string Nombrecl, string Apellidocl, string Nombrega, string Apellidoga, string cedulaIn, string cedulaCli, string cedulaGa)
        {
            string r = null;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("Select * FROM Rent INNER JOIN Cities ON Cities.ID = Rent.City INNER JOIN customers AS CLIENTE ON CLIENTE.ID = Rent.CLienteID INNER JOIN customers AS INQUILINO ON INQUILINO.ID = Rent.InquilinoID INNER JOIN customers AS GARANTE ON GARANTE.ID = Rent.GaranteID " + 
                    " WHERE CLIENTE.name = '{0}' AND CLIENTE.lastname = '{1}' AND CLIENTE.idcard = '{2}' AND GARANTE.name = '{3}' AND GARANTE.lastname = '{4}' AND GARANTE.idcard = '{5}' AND INQUILINO.name = '{6}' AND INQUILINO.lastname = '{7}' AND INQUILINO.idcard = '{8}'",
                    Nombrecl, Apellidocl, cedulaCli, Nombrega, Apellidoga, cedulaGa, NombreIn, ApellidoIn, cedulaIn), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    re.Close();
                    r = comand.ExecuteScalar().ToString();
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

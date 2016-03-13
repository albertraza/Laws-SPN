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
        // method for listing all Divorcios.
        public static List<divorcios> listAll()
        {
            List<divorcios> list = new List<divorcios>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT divorcios.ID, DEMANDANTE.name AS NombreDemandante, DEMANDANTE.lastname AS ApellidoDemandante, DEMANDADO.name AS NombreDemandado, DEMANDADO.lastname AS ApellidoDemandado, divorcios.Pagos, divorcios.Honorarios, divorcios.Abono FROM divorcios INNER JOIN customers AS DEMANDANTE ON DEMANDANTE.ID = divorcios.DemandanteID INNER JOIN customers AS DEMANDADO ON DEMANDADO.ID = divorcios.DemandadoID"), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    divorcios pDivorcios = new divorcios();
                    pDivorcios.ID = re["ID"].ToString();
                    pDivorcios.Nombre_Demandante = re["NombreDemandante"].ToString();
                    pDivorcios.Apellido_Demandante = re["ApellidoDemandante"].ToString();
                    pDivorcios.Nombre_Demandado = re["NombreDemandado"].ToString();
                    pDivorcios.Apellido_Demandado = re["ApellidoDemandado"].ToString();
                    pDivorcios.Honorarios = re["Honorarios"].ToString();
                    pDivorcios.Precio = re["Pagos"].ToString();
                    pDivorcios.Abono = re["Abono"].ToString();

                    list.Add(pDivorcios);
                }
                con.Close();
            }
            return list;
        }
        // method for searching Divorcios.
        public static List<divorcios> search(string ID, string pNombreDemandante, string ApellidoDemandante, string NombreDemandado, string ApellidoDemandado)
        {
            List<divorcios> list = new List<divorcios>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT divorcios.ID, DEMANDANTE.name AS NombreDemandante, DEMANDANTE.lastname AS ApellidoDemandante, DEMANDADO.name AS NombreDemandado, DEMANDADO.lastname AS ApellidoDemandado, divorcios.Pagos, divorcios.Honorarios, divorcios.Abono FROM divorcios INNER JOIN customers AS DEMANDANTE ON DEMANDANTE.ID = divorcios.DemandanteID INNER JOIN customers AS DEMANDADO ON DEMANDADO.ID = divorcios.DemandadoID" +
                    " WHERE divorcios.ID LIKE '{0}%' AND DEMANDANTE.name LIKE '{1}%' AND DEMANDANTE.lastname LIKE '{2}%' AND DEMANDADO.name LIKE '{3}%' AND DEMANDADO.lastname LIKE '{4}%'",
                    ID, pNombreDemandante, ApellidoDemandante, NombreDemandado, ApellidoDemandado), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    divorcios pDivorcios = new divorcios();
                    pDivorcios.ID = re["ID"].ToString();
                    pDivorcios.Nombre_Demandante = re["NombreDemandante"].ToString();
                    pDivorcios.Apellido_Demandante = re["ApellidoDemandante"].ToString();
                    pDivorcios.Nombre_Demandado = re["NombreDemandado"].ToString();
                    pDivorcios.Apellido_Demandado = re["ApellidoDemandado"].ToString();
                    pDivorcios.Honorarios = re["Honorarios"].ToString();
                    pDivorcios.Precio = re["Pagos"].ToString();
                    pDivorcios.Abono = re["Abono"].ToString();

                    list.Add(pDivorcios);
                }
                con.Close();
            }
            return list;
        }
        // method for getting ID.
        public static string getID(string Abono, string pNombreDemandante, string ApellidoDemandante, string NombreDemandado, string ApellidoDemandado, string cedulaDemandante, string cedulaDemandado)
        {
            string r = null;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT divorcios.ID FROM divorcios INNER JOIN customers AS DEMANDANTE ON DEMANDANTE.ID = divorcios.DemandanteID INNER JOIN customers AS DEMANDADO ON DEMANDADO.ID = divorcios.DemandadoID " +
                    " WHERE DEMANDANTE.name = '{0}' AND DEMANDANTE.lastname = '{1}' AND DEMANDANTE.idcard = '{2}' AND DEMANDADO.name = '{3}' AND DEMANDADO.lastname = '{4}' AND DEMANDADO.idcard = '{5}' AND divorcios.Abono = '{6}'",
                    pNombreDemandante, ApellidoDemandante, cedulaDemandante, NombreDemandado, ApellidoDemandado, cedulaDemandado, Abono), con);
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

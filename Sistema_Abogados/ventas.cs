using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_Abogados
{
    public class ventas
    {
        // Start construct building.
        public string ID { get; set; }
        public string Servicio { get; set; }
        public string Detalles { get; set; }
        public string Honorarios { get; set; }
        public string Precio_venta { get; set; }
        public string Nombre_comprador { get; set; }
        public string Apellido_comprador { get; set; }
        public string Nombre_vendedor { get; set; }
        public string Apellido_vendedor { get; set; }
        // End construct building.
        // method for registering sellings.
        public static int register(string SellerID, string BuyID, string Description, string SellingPrice, string Honorarios, string Abono, string ServiceID)
        {
            int r = -1;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("INSERT INTO Venta (VendedorID, CompradorID, Descripcion, MontoVenta, Honorarios, Abono, ServiceID) VALUES ('{0}', '{1}', '{2}', '{3}' ,'{4}' ,'{5}', '{6}')", 
                    SellerID, BuyID, Description, SellingPrice, Honorarios, Abono, ServiceID), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        // method for listing all ventas.
        public static List<ventas> listAll()
        {
            List<ventas> list = new List<ventas>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand("SELECT Venta.ID, SERVICIO.cService AS Servicio, VENDEDOR.name AS NombreVe, VENDEDOR.lastname AS ApellidoVe, COMPRADOR.name AS NombreCo, COMPRADOR.lastname AS ApellidoCo, Venta.Descripcion, Venta.Abono, Venta.Honorarios, Venta.MontoVenta FROM Venta INNER JOIN customers as VENDEDOR ON VENDEDOR.ID = Venta.VendedorID INNER JOIN customers AS COMPRADOR ON COMPRADOR.ID = Venta.CompradorID INNER JOIN services AS SERVICIO ON SERVICIO.ID = Venta.ServiceID", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    ventas pVenta = new ventas();
                    pVenta.Apellido_comprador = re["ApellidoCo"].ToString();
                    pVenta.Apellido_vendedor = re["ApellidoVe"].ToString();
                    pVenta.Detalles = re["Descripcion"].ToString();
                    pVenta.Honorarios = re["Honorarios"].ToString();
                    pVenta.ID = re["ID"].ToString();
                    pVenta.Nombre_comprador = re["NombreCo"].ToString();
                    pVenta.Nombre_vendedor = re["NombreVe"].ToString();
                    pVenta.Precio_venta = re["MontoVenta"].ToString();
                    pVenta.Servicio = re["Servicio"].ToString();

                    list.Add(pVenta);
                }
                con.Close();
            }
            return list;
        }
        // method for searching ventas.
        public static List<ventas> search(string NombreV, string ApellidoV, string NombreC, string ApellidoC, string ID)
        {
            List<ventas> list = new List<ventas>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT Venta.ID, SERVICIO.cService AS Servicio, VENDEDOR.name AS NombreVe, VENDEDOR.lastname AS ApellidoVe, COMPRADOR.name AS NombreCo, COMPRADOR.lastname AS ApellidoCo, Venta.Descripcion, Venta.Abono, Venta.Honorarios, Venta.MontoVenta FROM Venta INNER JOIN customers as VENDEDOR ON VENDEDOR.ID = Venta.VendedorID INNER JOIN customers AS COMPRADOR ON COMPRADOR.ID = Venta.CompradorID INNER JOIN services AS SERVICIO ON SERVICIO.ID = Venta.ServiceID" +
                    " WHERE VENDEDOR.name LIKE '{0}%' AND VENDEDOR.lastname LIKE '{1}%' AND COMPRADOR.name LIKE '{2}%' AND COMPRADOR.lastname LIKE '{3}%' AND Venta.ID LIKE '{4}%'",
                    NombreV, ApellidoV, NombreC, ApellidoC, ID), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    ventas pVenta = new ventas();
                    pVenta.Apellido_comprador = re["ApellidoCo"].ToString();
                    pVenta.Apellido_vendedor = re["ApellidoVe"].ToString();
                    pVenta.Detalles = re["Descripcion"].ToString();
                    pVenta.Honorarios = re["Honorarios"].ToString();
                    pVenta.ID = re["ID"].ToString();
                    pVenta.Nombre_comprador = re["NombreCo"].ToString();
                    pVenta.Nombre_vendedor = re["NombreVe"].ToString();
                    pVenta.Precio_venta = re["MontoVenta"].ToString();
                    pVenta.Servicio = re["Servicio"].ToString();

                    list.Add(pVenta);
                }
                con.Close();
            }
            return list;
        }
        // method for getting ID.
        public static string getID(string NombreV, string ApellidoV, string NombreC, string ApellidoC, string Descripcion, string cedulaV, string cedulaC)
        {
            string r = null;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT Venta.ID, SERVICIO.cService AS Servicio, VENDEDOR.name AS NombreVe, VENDEDOR.lastname AS ApellidoVe, COMPRADOR.name AS NombreCo, COMPRADOR.lastname AS ApellidoCo, Venta.Descripcion, Venta.Abono, Venta.Honorarios, Venta.MontoVenta FROM Venta INNER JOIN customers as VENDEDOR ON VENDEDOR.ID = Venta.VendedorID INNER JOIN customers AS COMPRADOR ON COMPRADOR.ID = Venta.CompradorID INNER JOIN services AS SERVICIO ON SERVICIO.ID = Venta.ServiceID " + 
                    " WHERE VENDEDOR.name = '{0}' AND VENDEDOR.lastname = '{1}' AND VENDEDOR.idcard = '{2}' AND COMPRADOR.name = '{3}' AND COMPRADOR.lastname = '{4}' AND COMPRADOR.idcard = '{5}' AND Venta.Descripcion = '{6}'",
                    NombreV, ApellidoV, cedulaV, NombreC, ApellidoC, cedulaC, Descripcion), con);
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

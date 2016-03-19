using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_Abogados
{
    public class factura
    {
        // properties building //
        public string ID_Factura { get; set; }
        public string Caso_NO { get; set; }
        public string Servicio { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Apellido_Cliente { get; set; }
        public string Balance_Total { get; set; }
        public string Pago_Realizado { get; set; }
        public string Nuevo_Balance { get; set; }
        public string Fecha_Proximo_Pago { get; set; }
        // construct for facturas.
        public factura() { }
        public factura(string id, string ncaso, string servi, string nombre, string apellido, string balance, string pago, string nbalance, string fecha)
        {
            ID_Factura = id;
            Caso_NO = ncaso;
            Servicio = servi;
            Nombre_Cliente = nombre;
            Apellido_Cliente = apellido;
            Balance_Total = balance;
            Pago_Realizado = pago;
            Nuevo_Balance = nbalance;
            Fecha_Proximo_Pago = fecha;
        }
        // methods for registering new facturas.
        public static int registerFacturaRent(string clienteID, string servicioID, string casoID, string pago, string pagoRestante, string TotalPagar, string proximoPago, string nuevoBalance, string Detalles)
        {
            int r = -1;
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("INSERT INTO facturasAlquiler (clienteID, servicioID, casoID, TotalBalance, Pago, NuevoBalance, ProximoPago, Detalles) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                    clienteID, servicioID, casoID, TotalPagar, pago, nuevoBalance, proximoPago, Detalles), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        public static int registerFacturaDivorciosAccidente(string clienteID, string servicioID, string casoID, string TotalBalance, string pago, string nuevoBalance, string fechaPago, string Detalles)
        {
            int r = -1;
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("INSERT INTO facturasDivorciosAccidente (clienteID, servicioID, casoID, TotalBalance, Pago, NuevoBalance, FechaPago, Detalles) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", clienteID, servicioID, casoID, TotalBalance, pago, nuevoBalance, fechaPago, Detalles), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        public static int registerFacturaVenta(string clienteID, string servicioID, string casoID, string TotalBalance, string pago, string nuevoBalance, string fechaPago, string Detalles)
        {
            int r = -1;
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("INSERT INTO facturasVenta (clienteID, servicioID, casoID, TotalBalance, Pago, NuevoBalance, fechaPago, Detalles) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", clienteID, servicioID, casoID, TotalBalance, pago, nuevoBalance, fechaPago, Detalles), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        // methods for listing all facturas
        public static List<factura> listAllRentFacturas()
        {
            List<factura> list = new List<factura>();
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand("SELECT facturasAlquiler.ID AS CodigoFactura, facturasAlquiler.casoID AS NumeroCaso, facturasAlquiler.TotalBalance AS BalanceTotal, facturasAlquiler.Pago AS PagoRealizado, facturasAlquiler.NuevoBalance, facturasAlquiler.ProximoPago AS FechaProximoPago, customers.name AS NombreCli, customers.lastname AS ApellidCli, customers.idcard AS CedulaoPasaporte, services.cService AS Servicio, facturasAlquiler.Detalles AS DetallesPago FROM facturasAlquiler INNER JOIN customers ON customers.ID = facturasAlquiler.clienteID INNER JOIN services ON services.ID = facturasAlquiler.servicioID", con);
                SqlDataReader re = comand.ExecuteReader();
                while(re.Read())
                {
                    factura pFactura = new factura();
                    pFactura.ID_Factura = re["CodigoFactura"].ToString();
                    pFactura.Apellido_Cliente = re["ApellidCli"].ToString();
                    pFactura.Balance_Total = re["BalanceTotal"].ToString();
                    pFactura.Caso_NO = re["NumeroCaso"].ToString();
                    pFactura.Fecha_Proximo_Pago = re["FechaProximoPago"].ToString();
                    pFactura.Nombre_Cliente = re["NombreCli"].ToString();
                    pFactura.Nuevo_Balance = re["NuevoBalance"].ToString();
                    pFactura.Pago_Realizado = re["PagoRealizado"].ToString();
                    pFactura.Servicio = re["Servicio"].ToString();
                    list.Add(pFactura);
                }
                con.Close();
            }
            return list;
        }
        public static List<factura> listAllDivorciosAccidenteFacturas()
        {
            List<factura> list = new List<factura>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand("SELECT facturasDivorciosAccidente.ID, facturasDivorciosAccidente.casoID AS NumeroCaso, services.cService, customers.name, customers.lastname, facturasDivorciosAccidente.TotalBalance, facturasDivorciosAccidente.Pago, facturasDivorciosAccidente.NuevoBalance FROM facturasDivorciosAccidente INNER JOIN customers ON customers.ID = facturasDivorciosAccidente.ClienteID INNER JOIN services ON services.ID = facturasDivorciosAccidente.servicioID", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    factura pFactura = new factura();
                    pFactura.ID_Factura = re["ID"].ToString();
                    pFactura.Apellido_Cliente = re["lastname"].ToString();
                    pFactura.Balance_Total = re["TotalBalance"].ToString();
                    pFactura.Caso_NO = re["NumeroCaso"].ToString();
                    pFactura.Fecha_Proximo_Pago = "No se ha registrado";
                    pFactura.Nombre_Cliente = re["name"].ToString();
                    pFactura.Nuevo_Balance = re["NuevoBalance"].ToString();
                    pFactura.Pago_Realizado = re["Pago"].ToString();
                    pFactura.Servicio = re["cService"].ToString();
                    list.Add(pFactura);
                }
                con.Close();
            }
            return list;
        }
        public static List<factura> listAllVentafacturas()
        {
            List<factura> list = new List<factura>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand("SELECT facturasVenta.ID, facturasVenta.casoID AS NumeroCaso, services.cService, customers.name, customers.lastname, facturasVenta.TotalBalance, facturasVenta.Pago, facturasVenta.NuevoBalance FROM facturasVenta INNER JOIN customers ON customers.ID = facturasVenta.ClienteID INNER JOIN services ON services.ID = facturasVenta.servicioID", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    factura pFactura = new factura();
                    pFactura.ID_Factura = re["ID"].ToString();
                    pFactura.Apellido_Cliente = re["lastname"].ToString();
                    pFactura.Balance_Total = re["TotalBalance"].ToString();
                    pFactura.Caso_NO = re["NumeroCaso"].ToString();
                    pFactura.Fecha_Proximo_Pago = "No se ha registrado";
                    pFactura.Nombre_Cliente = re["name"].ToString();
                    pFactura.Nuevo_Balance = re["NuevoBalance"].ToString();
                    pFactura.Pago_Realizado = re["Pago"].ToString();
                    pFactura.Servicio = re["cService"].ToString();
                    list.Add(pFactura);
                }
                con.Close();
            }
            return list;
        }
        // methods for searching all facturas.
        public static List<factura> searchFacturasRent(string CasoNO, string CedulaPasaporte, string nombre, string apellido)
        {
            List<factura> list = new List<factura>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT facturasAlquiler.ID AS CodigoFactura, facturasAlquiler.casoID AS NumeroCaso, facturasAlquiler.TotalBalance AS BalanceTotal, facturasAlquiler.Pago AS PagoRealizado, facturasAlquiler.NuevoBalance, facturasAlquiler.ProximoPago AS FechaProximoPago, customers.name AS NombreCli, customers.lastname AS ApellidCli, customers.idcard AS CedulaoPasaporte, services.cService AS Servicio, facturasAlquiler.Detalles AS DetallesPago FROM facturasAlquiler INNER JOIN customers ON customers.ID = facturasAlquiler.clienteID INNER JOIN services ON services.ID = facturasAlquiler.servicioID " + 
                    " WHERE facturasAlquiler.casoID LIKE '{0}%' AND customers.name LIKE '{1}%' AND customers.lastname LIKE '{2}%' AND customers.idcard LIKE '{3}%'",
                    CasoNO, nombre, apellido, CedulaPasaporte), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    factura pFactura = new factura();
                    pFactura.ID_Factura = re["CodigoFactura"].ToString();
                    pFactura.Apellido_Cliente = re["ApellidCli"].ToString();
                    pFactura.Balance_Total = re["BalanceTotal"].ToString();
                    pFactura.Caso_NO = re["NumeroCaso"].ToString();
                    pFactura.Fecha_Proximo_Pago = re["FechaProximoPago"].ToString();
                    pFactura.Nombre_Cliente = re["NombreCli"].ToString();
                    pFactura.Nuevo_Balance = re["NuevoBalance"].ToString();
                    pFactura.Pago_Realizado = re["PagoRealizado"].ToString();
                    pFactura.Servicio = re["Servicio"].ToString();
                    list.Add(pFactura);
                }
                con.Close();
            }
            return list;
        }
        public static List<factura> searchFacturasDivorciosAccidente(string CasoNO, string CedulaPasaporte, string nombre, string apellido)
        {
            List<factura> list = new List<factura>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT facturasDivorciosAccidente.ID, facturasDivorciosAccidente.casoID AS NumeroCaso, services.cService, customers.name, customers.lastname, facturasDivorciosAccidente.TotalBalance, facturasDivorciosAccidente.Pago, facturasDivorciosAccidente.NuevoBalance FROM facturasDivorciosAccidente INNER JOIN customers ON customers.ID = facturasDivorciosAccidente.ClienteID INNER JOIN services ON services.ID = facturasDivorciosAccidente.servicioID " + 
                    " WHERE facturasDivorciosAccidente.casoID LIKE '{0}%' AND customers.name LIKE '{1}%' AND customers.lastname LIKE '{2}%' AND customers.idcard LIKE '{3}%'",
                    CasoNO, nombre, apellido, CedulaPasaporte), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    factura pFactura = new factura();
                    pFactura.ID_Factura = re["ID"].ToString();
                    pFactura.Apellido_Cliente = re["lastname"].ToString();
                    pFactura.Balance_Total = re["TotalBalance"].ToString();
                    pFactura.Caso_NO = re["NumeroCaso"].ToString();
                    pFactura.Fecha_Proximo_Pago = "No se ha registrado";
                    pFactura.Nombre_Cliente = re["name"].ToString();
                    pFactura.Nuevo_Balance = re["NuevoBalance"].ToString();
                    pFactura.Pago_Realizado = re["Pago"].ToString();
                    pFactura.Servicio = re["cService"].ToString();
                    list.Add(pFactura);
                }
                con.Close();
            }
            return list;
        }
        public static List<factura> searchFacturasVenta(string CasoNO, string CedulaPasaporte, string nombre, string apellido)
        {
            List<factura> list = new List<factura>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT facturasVenta.ID, facturasVenta.casoID AS NumeroCaso, services.cService, customers.name, customers.lastname, facturasVenta.TotalBalance, facturasVenta.Pago, facturasVenta.NuevoBalance FROM facturasVenta INNER JOIN customers ON customers.ID = facturasVenta.ClienteID INNER JOIN services ON services.ID = facturasVenta.servicioID " + 
                    " WHERE facturasVenta.casoID LIKE '{0}%' AND customers.name LIKE '{1}%' AND customers.lastname LIKE '{2}%' AND customers.idcard LIKE '{3}%'",
                    CasoNO, nombre, apellido, CedulaPasaporte), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    factura pFactura = new factura();
                    pFactura.ID_Factura = re["ID"].ToString();
                    pFactura.Apellido_Cliente = re["lastname"].ToString();
                    pFactura.Balance_Total = re["TotalBalance"].ToString();
                    pFactura.Caso_NO = re["NumeroCaso"].ToString();
                    pFactura.Fecha_Proximo_Pago = "No se ha registrado";
                    pFactura.Nombre_Cliente = re["name"].ToString();
                    pFactura.Nuevo_Balance = re["NuevoBalance"].ToString();
                    pFactura.Pago_Realizado = re["Pago"].ToString();
                    pFactura.Servicio = re["cService"].ToString();
                    list.Add(pFactura);
                }
                con.Close();
            }
            return list;
        }
    }
}

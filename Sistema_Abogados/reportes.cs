using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Sistema_Abogados
{
    public class reportes
    {
        // method for getting divorcios reports.
        public static DataTable reporteCasoDivorcio(string ID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format("SELECT divorcios.ID as NumeroCaso, divorcios.Pagos as TotalPagar, divorcios.DemandadoID as IdDemandado, divorcios.DemandanteID as IdDemanante, services.cService as Servicio, DEMANDANTE.name as NombreDemandante, DEMANDANTE.lastname as ApellidoDemandante, DEMANDANTE.Phone as TelefonoE, DEMANDANTE.Cellphone as CelularE, DEMANDANTE.idcard as CedulaPasaporteE, DEMANDADO.name as NombreO, DEMANDADO.lastname as ApellidoO, DEMANDADO.Phone as TelefonoO, DEMANDADO.Cellphone as CelularO, DEMANDADO.idcard as CedulaPasaporteO, divorciosFacturacion.TotalPago as BalanceTotalStatus FROM divorcios INNER JOIN services ON services.ID = divorcios.ServiceID INNER JOIN customers as DEMANDANTE ON divorcios.DemandanteID = DEMANDANTE.ID INNER JOIN customers as DEMANDADO on divorcios.DemandadoID = DEMANDADO.ID INNER JOIN divorciosFacturacion ON divorcios.ID = divorciosFacturacion.caseID where divorcios.ID = '{0}'", ID), con);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
        public static DataTable reporteFacturasDivorcio(string ID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format("SELECT divorcios.ID as NumeroCaso, services.cService as Servicio, DEMANDANTE.name as NombreDemandante, DEMANDANTE.lastname as ApellidoDemandante, DEMANDANTE.Cellphone as CellDemandante, DEMANDANTE.Phone as PhoDemandante, DEMANDADO.name as NombreDemandado, DEMANDADO.lastname as ApellidoDemandado, DEMANDADO.Cellphone as CellDemandado, DEMANDADO.Phone as PhoDemandado, divorciosFacturacion.TotalPago AS BalanceActual, divorciosFacturacion.ultimoPago as FechaUltimoPago, facturasDivorciosAccidente.ID as CodigoFactura, facturasDivorciosAccidente.FechaPago, facturasDivorciosAccidente.TotalBalance, facturasDivorciosAccidente.Pago, facturasDivorciosAccidente.NuevoBalance, facturasDivorciosAccidente.Detalles FROM divorcios INNER JOIN customers AS DEMANDADO ON DEMANDADO.ID = divorcios.DemandadoID INNER JOIN customers AS DEMANDANTE ON DEMANDANTE.ID = divorcios.DemandanteID INNER JOIN services ON services.ID = divorcios.ServiceID INNER JOIN facturasDivorciosAccidente ON facturasDivorciosAccidente.casoID = divorcios.ID INNER JOIN divorciosFacturacion ON divorciosFacturacion.caseID = divorcios.ID where divorcios.ID = '{0}'", ID), con);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
        public static DataTable reporteAbonoCasoDivorcio(string fechaDes, string fechaHast)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format("SELECT divorcios.ID as NumeroCaso, services.cService as Servicio, DEMANDANTE.name as NombreDemandante, DEMANDANTE.lastname as ApellidoDemandante, DEMANDANTE.Cellphone as CellDemandante, DEMANDANTE.Phone as PhoDemandante, DEMANDADO.name as NombreDemandado, DEMANDADO.lastname as ApellidoDemandado, DEMANDADO.Cellphone as CellDemandado, DEMANDADO.Phone as PhoDemandado, divorciosFacturacion.TotalPago AS BalanceActual, divorciosFacturacion.ultimoPago as FechaUltimoPago, facturasDivorciosAccidente.ID as CodigoFactura, facturasDivorciosAccidente.FechaPago, facturasDivorciosAccidente.TotalBalance, facturasDivorciosAccidente.Pago, facturasDivorciosAccidente.NuevoBalance, facturasDivorciosAccidente.Detalles FROM divorcios INNER JOIN customers AS DEMANDADO ON DEMANDADO.ID = divorcios.DemandadoID INNER JOIN customers AS DEMANDANTE ON DEMANDANTE.ID = divorcios.DemandanteID INNER JOIN services ON services.ID = divorcios.ServiceID INNER JOIN facturasDivorciosAccidente ON facturasDivorciosAccidente.casoID = divorcios.ID INNER JOIN divorciosFacturacion ON divorciosFacturacion.caseID = divorcios.ID where divorciosFacturacion.TotalPago > 0 and facturasDivorciosAccidente.FechaPago between '{0}' and '{1}'", fechaDes, fechaHast), con);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
        // ******* end ******* //

        // methos for getting ventas report
        public static DataTable reporteCasoVenta(string ID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format("Select Venta.ID as NumeroCaso, VENDEDOR.name as NombreVendedor, VENDEDOR.lastname as ApellidoVendedor, COMPRADOR.name as NombreComprador, COMPRADOR.lastname as ApellidoComprador, Venta.MontoVenta as TotalVenta, ventaFacturacion.TotalPago as BalanceActual, Venta.Descripcion as Detalles from Venta INNER join customers as VENDEDOR on VENDEDOR.ID = Venta.VendedorID inner join customers as COMPRADOR on COMPRADOR.ID = Venta.CompradorID inner join ventaFacturacion on ventaFacturacion.caseID = Venta.ID where Venta.ID = '{0}'", ID), con);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
        public static DataTable reporteFacturasVenta(string ID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format("Select Venta.ID as NumeroCaso, VENDEDOR.name as NombreVendedor, VENDEDOR.lastname as ApellidoVendedor, facturasVenta.ID as CodigoFactura, facturasVenta.FechaPago, facturasVenta.TotalBalance as BalanceTotal, facturasVenta.Pago, facturasVenta.NuevoBalance, facturasVenta.Detalles from Venta INNER join customers as VENDEDOR on VENDEDOR.ID = Venta.VendedorID inner join customers as COMPRADOR on COMPRADOR.ID = Venta.CompradorID inner join ventaFacturacion on ventaFacturacion.caseID = Venta.ID inner join facturasVenta on facturasVenta.casoID = Venta.ID where Venta.ID = '{0}'", ID), con);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
        public static DataTable reporteAbonoVenta(string fechaDes, string fechaHas)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format("Select Venta.ID as NumeroCaso, VENDEDOR.name as NombreVendedor, VENDEDOR.lastname as ApellidoVendedor, facturasVenta.ID as CodigoFactura, facturasVenta.FechaPago, facturasVenta.TotalBalance as BalanceTotal, facturasVenta.Pago, facturasVenta.NuevoBalance, facturasVenta.Detalles from Venta INNER join customers as VENDEDOR on VENDEDOR.ID = Venta.VendedorID inner join customers as COMPRADOR on COMPRADOR.ID = Venta.CompradorID inner join ventaFacturacion on ventaFacturacion.caseID = Venta.ID inner join facturasVenta on facturasVenta.casoID = Venta.ID where ventaFacturacion.TotalPago > 0 and facturasVenta.FechaPago between '{0}' and '{1}'", fechaDes, fechaHas), con);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
        // ******* end ******* //

        // methods for generating reportes for Alquiler
        public static DataTable reporteCasoAlquiler(string ID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format("Select Rent.ID as NumeroCaso, CLIENTE.name as NombreCliente, CLIENTE.lastname as ApellidoCliente, INQUILINO.name as NombreInquilino, INQUILINO.lastname as ApellidoInquilino, GARANTE.name as NombreGarante, GARANTE.lastname as ApellidoGarante, Rent.detalles, Rent.direccion, Rent.ContratoCant as TotalContrato, Rent.Mensualidad, rentFacturacion.ContratoCant as BalanceActualContr from Rent INNER join customers as CLIENTE on CLIENTE.ID = Rent.CLienteID inner join customers AS INQUILINO on INQUILINO.ID = Rent.InquilinoID inner join customers as GARANTE on GARANTE.ID = Rent.GaranteID INNER join rentFacturacion on rentFacturacion.caseID = Rent.ID where Rent.ID = '{0}'", ID), con);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
        public static DataTable reporteFacturasCasoAlquiler(string ID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format("Select Rent.ID as NumeroCaso, CLIENTE.name as NombreCliente, CLIENTE.lastname as ApellidoCliente, facturasAlquiler.ID as CodigoFactura, facturasAlquiler.Detalles, facturasAlquiler.TotalBalance as BalanceTotal, facturasAlquiler.Pago, facturasAlquiler.NuevoBalance, rentFacturacion.UltimoPago from Rent INNER join customers as CLIENTE on CLIENTE.ID = Rent.CLienteID INNER join rentFacturacion on rentFacturacion.caseID = Rent.ID inner join facturasAlquiler on facturasAlquiler.casoID = Rent.ID where Rent.ID = '{0}'", ID), con);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
        public static DataTable reporteAbonoContrAlquiler(string fechaDes, string fechaHas)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format("Select Rent.ID as NumeroCaso, CLIENTE.name as NombreCliente, CLIENTE.lastname as ApellidoCliente, facturasAlquiler.ID as CodigoFactura, facturasAlquiler.Detalles, facturasAlquiler.TotalBalance as BalanceTotal, facturasAlquiler.Pago, facturasAlquiler.NuevoBalance, rentFacturacion.UltimoPago from Rent INNER join customers as CLIENTE on CLIENTE.ID = Rent.CLienteID INNER join rentFacturacion on rentFacturacion.caseID = Rent.ID inner join facturasAlquiler on facturasAlquiler.casoID = Rent.ID where facturasAlquiler.Detalles = 'Pago mensualidad y Abono al contrato de alquiler' or facturasAlquiler.Detalles = 'Abono al contrato de alquiler' and rentFacturacion.ContratoCant > 0 and facturasAlquiler.FechaPago between '{0}' and '{1}'", fechaDes, fechaHas), con);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
        // ******* end ******* //
    }
}

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
        public static DataTable ReporteAbonoContrVenta(string fechaDesde, string fechaHasta)
        {
            DataTable dt = new DataTable();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format("Select Venta.ID as NumeroCaso, facturasVenta.ID as CodigoFactura, facturasVenta.Detalles, facturasVenta.TotalBalance as BalanceTotal, facturasVenta.Pago, facturasVenta.NuevoBalance, facturasVenta.FechaPago, VENDEDOR.ID as CodigoVendedor, VENDEDOR.name as NombreVendedor, VENDEDOR.lastname as ApellidoVendedor, VENDEDOR.Phone as TelefonoVendedor, VENDEDOR.Cellphone as CelularVendedor, VENDEDOR.idcard AS CedulaPasaporteVendedor, COMPRADOR.ID as CodigoComprador, COMPRADOR.name as NombreComprador, COMPRADOR.lastname as ApellidoComprador, COMPRADOR.Phone as TelefonoComprador, COMPRADOR.Cellphone as CelularComprador, COMPRADOR.idcard as CedulaPasaporteComprador From Venta INNER JOIN facturasVenta ON facturasVenta.casoID = Venta.ID " +
                    "INNER JOIN customers AS VENDEDOR ON VENDEDOR.ID = Venta.VendedorID INNER JOIN customers AS COMPRADOR on COMPRADOR.ID = Venta.CompradorID INNER JOIN ventaFacturacion On ventaFacturacion.caseID = Venta.ID WHERE ventaFacturacion.TotalPago > 0 and Detalles = 'Abono contrato de venta' and facturasVenta.FechaPago between '{0}' and '{1}'", fechaDesde, fechaHasta), con);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
        // method for generating the report
        public static DataTable ReporteAbonoContrAlquiler(string fechaDesde, string fechaHasta)
        {
            DataTable dt = new DataTable();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format("Select Rent.ID as CodigoCaso, CLIENTE.name as NombreCliente, CLIENTE.lastname as ApellidoCliente, CLIENTE.Phone as TelefonoCliente, CLIENTE.Cellphone as CelularCliente, CLIENTE.idcard as CedulaPasaporteCliente, INQUILINO.name as NombreInquilino, INQUILINO.lastname as ApellidoInquilino, INQUILINO.Phone as TelefonoInquilino, INQUILINO.Cellphone as CelularInquilino, INQUILINO.idcard as CedulaPasaporteInquilino, GARANTE.name AS NombreGarante, GARANTE.lastname AS ApellidoGarante, GARANTE.Phone as TelefonoGarante, GARANTE.Cellphone as CelularGarante, GARANTE.idcard as CedulaPasaporteGarante, facturasAlquiler.ID as CodigoFactura, facturasAlquiler.TotalBalance as BalanceTotal, facturasAlquiler.Pago, facturasAlquiler.NuevoBalance, facturasAlquiler.Detalles, rentFacturacion.UltimoPago as FechaPago From Rent" +
                    " INNER JOIN rentFacturacion on rentFacturacion.caseID = Rent.ID inner join customers as INQUILINO on INQUILINO.ID = Rent.InquilinoID inner join customers as CLIENTE on CLIENTE.ID = Rent.CLienteID inner join customers as GARANTE on GARANTE.ID = Rent.GaranteID inner join facturasAlquiler on facturasAlquiler.casoID = Rent.ID" +
                    " WHERE facturasAlquiler.Detalles = 'Pago mensualidad y Abono al contrato de alquiler' or facturasAlquiler.Detalles = 'Abono al contrato de alquiler' and rentFacturacion.ContratoCant > 0 and rentFacturacion.UltimoPago between '{0}' and '{1}'", fechaDesde, fechaHasta), con);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
    }
}

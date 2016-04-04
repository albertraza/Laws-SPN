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
        // method for preview the report information
        public static DataTable ReporteJustOneDivorcioAccidente(String codigoCaso)
        {
            DataTable dt = new DataTable();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format("SELECT divorcios.Pagos AS TotalPorServicio, divorciosFacturacion.TotalPago as BalanceActual, divorciosFacturacion.ultimoPago as FechaUltimoPago, DEMANDANTE.name AS NombreDemandante, DEMANDANTE.lastname as ApellidoDemandante, DEMANDANTE.Phone as TelefonoDemandante, DEMANDANTE.Cellphone as CellE, DEMANDANTE.idcard as CedulaPAsaporteE, DEMANDADO.name AS NombreDemandado, DEMANDADO.lastname AS ApellidoDemandado, DEMANDADO.Phone as TelefonoO, DEMANDADO.Cellphone as CellDemandado, DEMANDADO.idcard as CedulaPasaporteO " +
                    "FROM divorcios INNER JOIN divorciosFacturacion ON divorcios.ID = divorciosFacturacion.caseID INNER JOIN customers AS DEMANDANTE ON DEMANDANTE.ID = divorcios.DemandanteID INNER JOIN customers AS DEMANDADO ON DEMANDADO.ID = divorcios.DemandadoID WHERE divorciosFacturacion.TotalPago = 0 and divorcios.ID = '{0}'", codigoCaso), con);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
        // methods for preview the report infomarion
        public static DataTable ReporteAbonoDates(String FechaDesde, String FechaHasta)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format("SELECT divorcios.ID as NumeroCaso, services.cService as Servicio, DEMANDANTE.name as NombreDemandante, DEMANDANTE.lastname as ApellidoDemandante, DEMANDANTE.Cellphone as CellDemandante, DEMANDANTE.Phone as PhoDemandante, DEMANDANTE.idcard as CedulaPasaporte, DEMANDADO.name as NombreDemandado, DEMANDADO.lastname as ApellidoDemandado, DEMANDADO.Cellphone as CellDemandado, DEMANDADO.Phone as PhoDemandado, DEMANDADO.idcard as CedulaPasaporte, divorciosFacturacion.TotalPago AS BalanceActual, divorciosFacturacion.ultimoPago as FechaUltimoPago, " +
                    " facturasDivorciosAccidente.ID as CodigoFactura, facturasDivorciosAccidente.FechaPago, facturasDivorciosAccidente.TotalBalance, facturasDivorciosAccidente.Pago, facturasDivorciosAccidente.NuevoBalance, facturasDivorciosAccidente.Detalles FROM divorcios INNER JOIN customers AS DEMANDADO ON DEMANDADO.ID = divorcios.DemandadoID INNER JOIN customers AS DEMANDANTE ON DEMANDANTE.ID = divorcios.DemandanteID " +
                    " INNER JOIN services ON services.ID = divorcios.ServiceID INNER JOIN facturasDivorciosAccidente ON facturasDivorciosAccidente.casoID = divorcios.ID INNER JOIN divorciosFacturacion ON divorciosFacturacion.caseID = divorcios.ID Where facturasDivorciosAccidente.FechaPago between '{0}' and '{1}' And divorciosFacturacion.TotalPago > 0 AND Detalles = 'Abono a cuenta'", FechaDesde, FechaHasta), con);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
        // method for ventas abonos
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
    }
}

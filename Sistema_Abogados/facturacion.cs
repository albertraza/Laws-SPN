﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_Abogados
{
    public class facturacion
    {
        // start properties building.
        public string ID { get; set; }
        public string Servicio { get; set; }
        public string CasoNO { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Apellido_Cliente { get; set; }
        public string Cedula { get; set; }
        public string Abono { get; set; }
        public string Deposito { get; set; }
        public string Pago_Total { get; set; }
        // end of properties building
        
        // methods for registering facturaciones
        public static int registerRent(string clienteID, string serviceID, string casoID, string mensualidad, string deposito, string TotalContrato)
        {
            int r = -1;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("INSERT INTO rentFacturacion (clienteID, serviceID, caseID, Mensualidad, Deposito, ContratoCant) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", clienteID, serviceID, casoID, mensualidad, deposito, TotalContrato), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        public static int registerDivorciosAccidente(string clienteId, string serviceID, string casoID, string TotalPago, string Abono)
        {
            int r = -1;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("INSERT INTO divorciosFacturacion (clienteID, serviceID, caseID, TotalPago, Abono) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", clienteId, serviceID, casoID, TotalPago, Abono), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        public static int registerVentas(string clienteID, string serviceID, string casoID, string totalPago, string abono)
        {
            int r = -1;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("INSERT INTO ventaFacturacion (clienteID, serviceID, caseID, TotalPago, Abono) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", clienteID, serviceID, casoID, totalPago, abono), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        // methods for listing all.
        public static List<facturacion> listAllRent()
        {
            List<facturacion> list = new List<facturacion>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT rentFacturacion.ID, services.cService, Rent.ID AS CasoID, customers.name, customers.lastname, customers.ID, customers.idcard, rentFacturacion.Mensualidad, rentFacturacion.Deposito, rentFacturacion.contratoCant FROM rentFacturacion INNER JOIN customers ON customers.ID = rentFacturacion.clienteID INNER JOIN Rent ON Rent.ID = rentFacturacion.caseID INNER JOIN services ON services.ID = rentFacturacion.serviceID"), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    facturacion pFactura = new facturacion();

                    pFactura.ID = re["ID"].ToString();
                    pFactura.Abono = "No hay abono registrado";
                    pFactura.CasoNO = re["CasoID"].ToString();
                    pFactura.Apellido_Cliente = re["lastname"].ToString();
                    pFactura.Cedula = re["idcard"].ToString();
                    pFactura.Nombre_Cliente = re["name"].ToString();
                    pFactura.Pago_Total = Convert.ToDouble(re["Mensualidad"]).ToString("f2");
                    pFactura.Servicio = re["cService"].ToString();
                    pFactura.Deposito = Convert.ToDouble(re["ContratoCant"]).ToString("f2");

                    list.Add(pFactura);
                }
                con.Close();
            }
            return list;
        }
        public static List<facturacion> listAllDivorciosAccidentes()
        {
            List<facturacion> list = new List<facturacion>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand("SELECT divorciosFacturacion.ID, services.cService, divorcios.ID AS CasoID, customers.name, customers.lastname, customers.idcard, divorciosFacturacion.TotalPago, divorciosFacturacion.Abono FROM divorciosFacturacion INNER JOIN divorcios ON divorcios.ID = divorciosFacturacion.CaseID INNER JOIN customers ON customers.ID = divorciosFacturacion.clienteID INNER JOIN services ON services.ID = divorciosFacturacion.serviceID", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    facturacion pFactura = new facturacion();

                    pFactura.ID = re["ID"].ToString();
                    pFactura.Abono = Convert.ToDouble(re["Abono"]).ToString("f2");
                    pFactura.CasoNO = re["CasoID"].ToString();
                    pFactura.Apellido_Cliente = re["lastname"].ToString();
                    pFactura.Cedula = re["idcard"].ToString();
                    pFactura.Nombre_Cliente = re["name"].ToString();
                    pFactura.Pago_Total = Convert.ToDouble(re["TotalPago"]).ToString("f2");
                    pFactura.Servicio = re["cService"].ToString();
                    pFactura.Deposito = "No hay deposito registrado";

                    list.Add(pFactura);
                }
                con.Close();
            }
            return list;
        }
        public static List<facturacion> listAllVentas()
        {
            List<facturacion> list = new List<facturacion>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand("SELECT ventaFacturacion.ID, services.cService, Venta.ID AS CasoID, customers.name, customers.lastname, customers.idcard, ventaFacturacion.TotalPago, ventaFacturacion.Abono FROM ventaFacturacion INNER JOIN Venta ON Venta.ID = ventaFacturacion.caseID INNER JOIN customers ON customers.ID = ventaFacturacion.clienteID INNER JOIN services ON services.ID = ventaFacturacion.serviceID", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    facturacion pFactura = new facturacion();

                    pFactura.ID = re["ID"].ToString();
                    pFactura.Abono = Convert.ToDouble(re["Abono"]).ToString("f2");
                    pFactura.CasoNO = re["CasoID"].ToString();
                    pFactura.Apellido_Cliente = re["lastname"].ToString();
                    pFactura.Cedula = re["idcard"].ToString();
                    pFactura.Nombre_Cliente = re["name"].ToString();
                    pFactura.Pago_Total = Convert.ToDouble(re["TotalPago"]).ToString("f2");
                    pFactura.Servicio = re["cService"].ToString();
                    pFactura.Deposito = "No hay deposito registrado";

                    list.Add(pFactura);
                }
                con.Close();
            }
            return list;
        }
        // methods for searching all.
        public static List<facturacion> searchRent(string cedulaCli, string cedulaIn, string cedulaGa)
        {
            List<facturacion> list = new List<facturacion>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT rentFacturacion.ID, services.cService, Rent.ID AS CasoID, CLENTE.name, CLENTE.lastname, CLENTE.ID, CLENTE.idcard, rentFacturacion.Mensualidad, rentFacturacion.Deposito FROM Rent INNER JOIN customers AS CLENTE ON CLENTE.ID = Rent.CLienteID INNER JOIN rentFacturacion ON Rent.ID = rentFacturacion.caseID INNER JOIN services ON services.ID = rentFacturacion.serviceID INNER JOIN customers AS INQUILINO ON INQUILINO.ID = Rent.InquilinoID INNER JOIN customers AS GARANTE ON GARANTE.ID = Rent.GaranteID " +
                    " WHERE CLENTE.idcard LIKE '{0}%' AND INQUILINO.idcard LIKE '{1}%' AND GARANTE.idcard LIKE '{2}%'", cedulaCli, cedulaIn, cedulaGa), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    facturacion pFactura = new facturacion();

                    pFactura.ID = re["ID"].ToString();
                    pFactura.Abono = "No hay abono registrado";
                    pFactura.CasoNO = re["CasoID"].ToString();
                    pFactura.Apellido_Cliente = re["lastname"].ToString();
                    pFactura.Cedula = re["idcard"].ToString();
                    pFactura.Nombre_Cliente = re["name"].ToString();
                    pFactura.Pago_Total = Convert.ToDouble(re["Mensualidad"]).ToString("f2");
                    pFactura.Servicio = re["cService"].ToString();
                    pFactura.Deposito = Convert.ToDouble(re["Deposito"]).ToString("f2");

                    list.Add(pFactura);
                }
                con.Close();
            }
            return list;
        }
        public static List<facturacion> searchDivorciosAccidentes(string cedulaE, string cedulaO)
        {
            List<facturacion> list = new List<facturacion>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT divorciosFacturacion.ID, services.cService, divorcios.ID AS CasoID, DEMANDANTE.name, DEMANDANTE.lastname, DEMANDANTE.idcard, divorciosFacturacion.TotalPago, divorciosFacturacion.Abono FROM divorcios INNER JOIN divorciosFacturacion ON divorcios.ID = divorciosFacturacion.CaseID INNER JOIN customers AS DEMANDANTE ON DEMANDANTE.ID = divorcios.DemandanteID INNER JOIN services ON services.ID = divorciosFacturacion.serviceID INNER JOIN customers AS DEMANDADO ON divorcios.DemandadoID = DEMANDADO.ID " +
                    " WHERE DEMANDANTE.idcard LIKE '{0}%' AND DEMANDADO.idcard LIKE '{1}%'", cedulaE, cedulaO), con);
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    facturacion pFactura = new facturacion();

                    pFactura.ID = reader["ID"].ToString();
                    pFactura.Abono = Convert.ToDouble(reader["Abono"]).ToString("f2");
                    pFactura.CasoNO = reader["CasoID"].ToString();
                    pFactura.Apellido_Cliente = reader["lastname"].ToString();
                    pFactura.Cedula = reader["idcard"].ToString();
                    pFactura.Nombre_Cliente = reader["name"].ToString();
                    pFactura.Pago_Total = Convert.ToDouble(reader["TotalPago"]).ToString("f2");
                    pFactura.Servicio = reader["cService"].ToString();
                    pFactura.Deposito = "No hay deposito registrado";

                    list.Add(pFactura);
                }
                con.Close();
            }
            return list;
        }
        public static List<facturacion> searchVentas(string cedulaVe, string cedulaC)
        {
            List<facturacion> list = new List<facturacion>();
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT ventaFacturacion.ID, services.cService, Venta.ID AS CasoID, VENDEDOR.name, VENDEDOR.lastname, VENDEDOR.idcard, ventaFacturacion.TotalPago, ventaFacturacion.Abono FROM Venta INNER JOIN ventaFacturacion ON Venta.ID = ventaFacturacion.caseID INNER JOIN customers AS VENDEDOR ON VENDEDOR.ID = Venta.VendedorID INNER JOIN services ON services.ID = ventaFacturacion.serviceID INNER JOIN customers AS COMPRADOR ON COMPRADOR.ID = Venta.CompradorID " +
                    " WHERE VENDEDOR.idcard LIKE '{0}%' AND COMPRADOR.idcard LIKE '{1}%'", cedulaVe, cedulaC), con);
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    facturacion pFactura = new facturacion();

                    pFactura.ID = reader["ID"].ToString();
                    pFactura.Abono = Convert.ToDouble(reader["Abono"]).ToString("f2");
                    pFactura.CasoNO = reader["CasoID"].ToString();
                    pFactura.Apellido_Cliente = reader["lastname"].ToString();
                    pFactura.Cedula = reader["idcard"].ToString();
                    pFactura.Nombre_Cliente = reader["name"].ToString();
                    pFactura.Pago_Total = Convert.ToDouble(reader["TotalPago"]).ToString("f2");
                    pFactura.Servicio = reader["cService"].ToString();
                    pFactura.Deposito = "No hay deposito registrado";

                    list.Add(pFactura);
                }
                con.Close();
            }
            return list;
        }
        // methods for getting data from database.
        public static facturacionBaseObj getRentStatus(string ID)
        {
            facturacionBaseObj pFactura = new facturacionBaseObj();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT * FROM rentFacturacion WHERE ID = '{0}'", ID), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        pFactura.ID = re["ID"].ToString();
                        pFactura.Cliente_ID = re["clienteID"].ToString();
                        pFactura.Service_ID = re["serviceID"].ToString();
                        pFactura.Case_ID = re["caseID"].ToString();
                        pFactura.TotalPago_Mensualidad = Convert.ToDouble(re["Mensualidad"]).ToString("f2");
                        pFactura.Abono_Deposito = Convert.ToDouble(re["Deposito"]).ToString("f2");
                        pFactura.fechaUltimoPago = re["UltimoPago"].ToString();
                        pFactura.ContratoTotal = Convert.ToDouble(re["ContratoCant"]).ToString("f2");
                        pFactura.fechaProximoPago = re["ProximoPago"].ToString();
                    }
                }
                else
                {
                    pFactura = null;
                }
                con.Close();
            }
            return pFactura;
        }
        public static facturacionBaseObj getDivorciosAccidentesStatus(string ID)
        {
            facturacionBaseObj pFac = new facturacionBaseObj();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT * FROM divorciosFacturacion WHERE ID = '{0}'", ID), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        pFac.ID = re["ID"].ToString();
                        pFac.Cliente_ID = re["clienteID"].ToString();
                        pFac.Service_ID = re["serviceID"].ToString();
                        pFac.Case_ID = re["caseID"].ToString();
                        pFac.TotalPago_Mensualidad = Convert.ToDouble(re["TotalPago"]).ToString("f2");
                        pFac.Abono_Deposito = Convert.ToDouble(re["Abono"]).ToString("f2");
                        pFac.fechaUltimoPago = re["ultimoPago"].ToString();
                    }
                }
                else
                {
                    pFac = null;
                }
                con.Close();
            }
            return pFac;
        }
        public static facturacionBaseObj getVentasStatus(string ID)
        {
            facturacionBaseObj pfactura = new facturacionBaseObj();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT * FROM ventaFacturacion WHERE ID = '{0}'", ID), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        pfactura.ID = re["ID"].ToString();
                        pfactura.Cliente_ID = re["clienteID"].ToString();
                        pfactura.Service_ID = re["serviceID"].ToString();
                        pfactura.Case_ID = re["caseID"].ToString();
                        pfactura.TotalPago_Mensualidad = Convert.ToDouble(re["TotalPago"]).ToString("f2");
                        pfactura.Abono_Deposito = Convert.ToDouble(re["Abono"]).ToString("f2");
                        pfactura.fechaUltimoPago = re["ultimoPago"].ToString();
                    }
                }
                else
                {
                    pfactura = null;
                }
                con.Close();
            }
            return pfactura;
        }
        // methods for updating payments status
        public static int updateRentStatus(string ID, string Depositorestante, string fechaPago, string contratoCant, string fechaProximoPago)
        {
            int r = -1;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("UPDATE rentFacturacion SET Deposito = '{0}', UltimoPago = '{1}', contratoCant = '{2}', ProximoPago = '{3}' WHERE ID = '{4}'", Depositorestante, fechaPago, contratoCant, fechaProximoPago, ID), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        public static int updateDivorciosAccidenteStatus(string ID, string pagoRestante, string abonoRestante, string ultimoPago)
        {
            int r = -1;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("UPDATE divorciosFacturacion SET TotalPago = '{0}', Abono = '{1}', ultimoPago = '{2}' WHERE ID = '{3}'", pagoRestante, abonoRestante, ultimoPago, ID), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        public static int updateVentaStatus(string ID, string pagoRestante, string abonoRestante, string ultimoPago)
        {
            int r = -1;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("update ventaFacturacion set TotalPago = '{0}', Abono = '{1}', ultimoPago = '{2}' where ID = '{3}'", pagoRestante, abonoRestante, ultimoPago, ID), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
    }
}

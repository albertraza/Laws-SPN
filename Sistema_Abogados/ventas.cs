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
    }
}

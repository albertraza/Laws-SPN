using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Sistema_Abogados.Properties;

namespace Sistema_Abogados
{
    public class DBcomun
    {
        private static string getConnectionString()
        {
            return Sistema_Abogados.Properties.Settings.Default.AbogadosDBConnectionString;
        }
        public static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection(getConnectionString());
            con.Open();
            return con;
        }
    }
}

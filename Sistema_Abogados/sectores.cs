using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_Abogados
{
    public class sectores
    {
        // object properties declaration.
        public string ID { get; set; }
        public string Sector { get; set; }

        /// <summary>
        /// Contruct building.
        /// </summary>
        public sectores()
        {
        }
        public sectores(string pID, string pSector)
        {
            this.ID = pSector;
            this.Sector = pSector;
        }
        // end costruct building.
        // method for registering Cities.
        public static int registerCity(string City)
        {
            int r = -1;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("INSERT INTO cities values ('{0}')", City), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        // method for verifiing Cities input.
        public static bool cityVerification(string City)
        {
            bool r = false;
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT * FROM cities WHERE City = '{0}'", City), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    r = true;
                }
                else
                {
                    r = false;
                }
                con.Close();
            }
            return r;
        }
        // method for getting Cities ID.
        public static string getCityID(string City)
        {
            string r = null;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT ID FROM Cities"), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    re.Close();
                    r = comand.ExecuteScalar().ToString();
                }
                else
                {
                    r = null;
                    re.Close();
                }
                con.Close();
            }
            return r;
        }
    }
}

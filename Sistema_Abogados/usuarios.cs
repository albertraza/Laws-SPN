using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_Abogados
{
    public class usuarios
    {
        // create getter for saving users values
        public string id { get; set; }
        public string nombre { get; set; }

        // set up some constructs for making base objets
        public usuarios() { }

        public usuarios(string pid, string pname)
        {
            this.id = pid;
            this.nombre = pname;
        }
        /// <summary>
        /// end constructs estructure
        /// </summary>
        /// <param name="pU"></param>
        /// <returns></returns>
        public static bool checkUser(string name, string passwrd)
        {
            bool r = false;
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from users where name = '{0}' and passwrd = '{1}'", name, passwrd), con);
                SqlDataReader reader = comand.ExecuteReader();
                if (reader.HasRows)
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
    }
}

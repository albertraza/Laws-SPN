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
        /// 
        //method for login interface.

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

        // method for registering new users with picture included.
        public static int registerUser(string name, string password, string imageFilePath, string nivel)
        {
            int re = -1;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("insert into users (name, passwrd, nivel, picture) values ('{0}', '{1}', '{2}', '{3}')", name, password, nivel, imageFilePath), con);
                re = comand.ExecuteNonQuery();
                con.Close();
            }
            return re;
        }
    }
}

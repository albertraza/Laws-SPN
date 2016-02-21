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
        public string nivel { get; set; }
        public string image { get; set; }

        // set up some constructs for making base objets
        public usuarios() { }
        public usuarios(string pid, string pname, string pimage, string pnivel)
        {
            id = pid;
            nombre = pname;
            image = pimage;
            nivel = pnivel;
        }
        // end construct //
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
        public static int registerUser(string name, string password, string imageFilePath, string nivelID)
        {
            int re = -1;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("insert into users (name, passwrd, userLevelID, picture) values ('{0}', '{1}', '{2}', '{3}')", name, password, nivelID, imageFilePath), con);
                re = comand.ExecuteNonQuery();
                con.Close();
            }
            return re;
        }
        // method which loads all users.
        public static List<usuarios> listAllUsers()
        {
            List<usuarios> list = new List<usuarios>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand("SELECT users.ID, users.name, users.passwrd, users.picture, UserLevel.levels FROM users INNER JOIN UserLevel ON users.userLevelID = UserLevel.id", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    usuarios u = new usuarios();
                    u.id = re["ID"].ToString();
                    u.nombre = re["name"].ToString();
                    u.nivel = re["levels"].ToString();
                    u.image = re["picture"].ToString();

                    list.Add(u);
                }
                con.Close();
            }
            return list;
        }
        // search engine for all users.
        public static List<usuarios> SearchEngineUsers(string id, string name, string level, string passwrd)
        {
            List<usuarios> list = new List<usuarios>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from users where ID like '{0}%' and name like '{1}%' and passwrd like '{2}%' and nivel like '{3}%'",
                    id, name, passwrd, level), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    usuarios u = new usuarios();
                    u.id = re["ID"].ToString();
                    u.nombre = re["name"].ToString();
                    u.nivel = re["nivel"].ToString();
                    u.image = re["picture"].ToString();

                    list.Add(u);
                }
                con.Close();
            }
            return list;
        }
        // getting user object from database
        public static usuarios getUser(string id)
        {
            usuarios u = new usuarios();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT users.ID, users.name, users.passwrd, users.picture, UserLevel.levels FROM users INNER JOIN UserLevel ON users.userLevelID = UserLevel.id WHERE users.ID = '{0}'", id), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    u.id = re["ID"].ToString();
                    u.nombre = re["name"].ToString();
                    u.nivel = re["levels"].ToString();
                    u.image = re["picture"].ToString();
                }
                con.Close();
            }
            return u;
        }
        // getting users ID.
        public static string getUserID(string name)
        {
            string r = null;
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT * FROM users WHERE name = '{0}'", name), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        r = re["ID"].ToString();
                    }
                }
                else {
                    r = null;
                }
                con.Close();
            }
            return r;
        }
        public static string getUserLevelID(string UserLevel)
        {
            string r = null;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT id FROM userLevel WHERE levels = '{0}'", UserLevel), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    re.Close();
                    r = comand.ExecuteScalar().ToString();
                }
                else
                {
                    r = null;
                }
                con.Close();
            }
            return r;
        }
    }
}

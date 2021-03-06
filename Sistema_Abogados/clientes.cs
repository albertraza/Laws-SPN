﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_Abogados
{
    public class clientes
    {
        // creating clientes variables for storing data.
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Status { get; set; }
        public string Fecha_Registro { get; set; }
        public string Direccion { get; set; }
        public string Sector { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string E_Mail { get; set; }
        public string Ocupacion { get; set; }
        public string Image { get; set; }

        // creating constructs for building objects.
        public clientes() { }
        public clientes(string pid, string pnombre, string papellido, string pcedula, string pstatus, string pfecha, string pDireccion,
            string pSector, string pTelefono, string pCelular, string pEmail, string pOcupacion)
        {
            ID = pid;
            Nombre = pnombre;
            Apellido = papellido;
            Cedula = pcedula;
            Status = pstatus;
            Fecha_Registro = pfecha;
        }
        // end of building constructs ///
        // method for registering customers.
        public static int customerRegistration(clientes pClientes, string image, string pasaporte)
        {
            int r = -1;
            using(SqlConnection con  = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("INSERT INTO customers (name, lastname, idcard, StatusId, picture, registerdate, cAddress, CityID, Phone, Cellphone, email, ocupation, pasaporte) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')",
                    pClientes.Nombre, pClientes.Apellido, pClientes.Cedula, pClientes.Status, image, pClientes.Fecha_Registro, pClientes.Direccion, pClientes.Sector, pClientes.Telefono, pClientes.Celular, pClientes.E_Mail, pClientes.Ocupacion, pasaporte), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        // method for getting customers.
        public static string getID(string name, string idcard)
        {
            string r = null;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT * FROM customers WHERE name = '{0}' AND idcard = '{1}'", name, idcard), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        r = re["ID"].ToString();
                    }
                }
                else
                {
                    r = null;
                }
                con.Close();
            }
            return r;
        }
        // method for listing all customers.
        public static List<clientes> listAllCustomers()
        {
            List<clientes> list = new List<clientes>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand("SELECT * FROM customers INNER JOIN Cities ON customers.CityID = Cities.ID INNER JOIN CustomerStatus ON CustomerStatus.ID = customers.StatusId", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    clientes pClientes = new clientes();
                    pClientes.ID = re["ID"].ToString();
                    pClientes.Nombre = re["name"].ToString();
                    pClientes.Apellido = re["lastname"].ToString();
                    pClientes.Cedula = re["idcard"].ToString();
                    pClientes.Image = re.GetString(5);
                    pClientes.Status = re["Status"].ToString();
                    pClientes.Fecha_Registro = re["registerdate"].ToString();
                    pClientes.Direccion = re["cAddress"].ToString();
                    pClientes.E_Mail = re["email"].ToString();
                    pClientes.Ocupacion = re["ocupation"].ToString();
                    pClientes.Sector = re["City"].ToString();
                    pClientes.Telefono = re["Phone"].ToString();
                    pClientes.Celular = re["Cellphone"].ToString();

                    list.Add(pClientes);
                }
                con.Close();
            }
            return list;
        }
        // search engine for listing customers.
        public static List<clientes> searchCustomers(string ID, string name, string lastName, string cedula, string status, string registerDate)
        {
            List<clientes> list = new List<clientes>();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT * FROM customers INNER JOIN Cities ON customers.CityID = Cities.ID INNER JOIN CustomerStatus ON CustomerStatus.ID = customers.StatusId WHERE customers.ID LIKE '{0}%' AND name LIKE '{1}%' AND lastname LIKE '{2}%' AND idcard LIKE '{3}%' AND status LIKE '{4}%' AND registerdate LIKE '{5}%' ",
                    ID, name, lastName, cedula, status, registerDate), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    clientes pClientes = new clientes();
                    pClientes.ID = re["ID"].ToString();
                    pClientes.Nombre = re["name"].ToString();
                    pClientes.Apellido = re["lastname"].ToString();
                    pClientes.Cedula = re["idcard"].ToString();
                    pClientes.Image = re.GetString(5);
                    pClientes.Status = re["Status"].ToString();
                    pClientes.Fecha_Registro = re["registerdate"].ToString();
                    pClientes.Fecha_Registro = re["registerdate"].ToString();
                    pClientes.Direccion = re["cAddress"].ToString();
                    pClientes.E_Mail = re["email"].ToString();
                    pClientes.Ocupacion = re["ocupation"].ToString();
                    pClientes.Sector = re["City"].ToString();
                    pClientes.Telefono = re["Phone"].ToString();
                    pClientes.Celular = re["Cellphone"].ToString();

                    list.Add(pClientes);
                }
                con.Close();
            }
            return list;
        }
        // method for getting customers data.
        public static clientes getCustomerObject(string ID, string idCard)
        {
            clientes pClientes = new clientes();
            using(SqlConnection con  = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT * FROM customers INNER JOIN Cities ON customers.CityID = Cities.ID INNER JOIN CustomerStatus ON CustomerStatus.ID = customers.StatusId WHERE customers.ID = '{0}' OR customers.idcard = '{1}'", ID, idCard), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        pClientes.ID = re["ID"].ToString();
                        pClientes.Nombre = re["name"].ToString();
                        pClientes.Apellido = re["lastname"].ToString();
                        pClientes.Cedula = re["idcard"].ToString();
                        pClientes.Image = re.GetString(5);
                        pClientes.Status = re["Status"].ToString();
                        pClientes.Fecha_Registro = re["registerdate"].ToString();
                        pClientes.Fecha_Registro = re["registerdate"].ToString();
                        pClientes.Direccion = re["cAddress"].ToString();
                        pClientes.E_Mail = re["email"].ToString();
                        pClientes.Ocupacion = re["ocupation"].ToString();
                        pClientes.Sector = re["City"].ToString();
                        pClientes.Telefono = re["Phone"].ToString();
                        pClientes.Celular = re["Cellphone"].ToString();
                    }
                }
                else
                {
                    pClientes = null;
                }
                con.Close();
            }
            return pClientes;
        }
        // method for getting status ID.
        public static string getStatusID(String Status)
        {
            string r = null;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT ID FROM customerStatus where Status = '{0}'", Status), con);
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
        // method for validating customers.
        public static bool verify(string pCedula)
        {
            bool r;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("SELECT * FROM customers WHERE idcard = '{0}'", pCedula), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    r = false;
                }
                else
                {
                    r = true;
                }
                con.Close();
            }
            return r;
        }
        // method for verifying the default document.
        public static int verifyDocument(string ID, string cedula)
        {
            int r;
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand(string.Format("Select pasaporte from customers where ID = '{0}' or idcard = '{1}'", ID, cedula), con);
                r = Convert.ToInt32(comand.ExecuteScalar());
                con.Close();
            }
            return r;
        }
    }
}

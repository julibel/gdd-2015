using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PagoElectronico
{
    class Globals
    {
        private static int _userID = 0;
        private static string username;
        private static List<int> funcionalidades = new List<int>();

        private static string connectionString = ConfigurationManager.ConnectionStrings["GD1C2015"].ConnectionString;
        private static bool isLogged = false;

        public static int userID
        {
            get { return _userID; }
            set { _userID = value; }
        }
        public static string getConnectionString()
        {
            return connectionString;
        }

        public static string /*DateTime*/ getFechaSistema() //Dijimos de manejarla como string?
        {
            return ConfigurationManager.AppSettings["fechaSistema"];
            //return Convert.ToDateTime(ConfigurationManager.AppSettings["fechaSistema"]);
        }

        public static void setAdminLoggeado(bool status)
        {
            isLogged = status;
        }

        public static bool adminLoggeado()
        {
            return isLogged;
        }

        public static string getHashSha256(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }


        public static void setUser(int userID, string user, List<int> funcs)
        {
            _userID = userID;
            username = user;
            funcionalidades = funcs;
        }

        internal static bool tieneFuncionalidad(int idFun)
        {
            return funcionalidades.Contains(idFun);
        }
    }
}

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
        public static int userID = 0;
        public static string username;
        private static List<int> funcionalidades = new List<int>();

        private static string connectionString = ConfigurationManager.ConnectionStrings["GD1C2015"].ConnectionString;

        public static string getConnectionString()
        {
            return connectionString;
        }

        public static string getFechaSistema() 
        {
            return ConfigurationManager.AppSettings["fechaSistema"];
        }

        public static string getHashSHA256(string text)
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

        public static string getHashSHA1(string str)
        {
            SHA1 sha1 = SHA1Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha1.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }


        public static void setUser(int id, string name, List<int> funcs)
        {
            userID = id;
            username = name;
            funcionalidades = funcs;
        }

        public static bool tieneFuncionalidad(int idFun)
        {
            return funcionalidades.Contains(idFun);
        }

        public static void cerrarSesion()
        {
            userID = 0;
            username = "";
            funcionalidades = new List<int>();
        }
    }
}

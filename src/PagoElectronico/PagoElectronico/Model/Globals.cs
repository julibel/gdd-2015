using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace PagoElectronico
{
    class Globals
    {
        private static int _userID = 0;

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

        public static DateTime getFechaSistema()
        {
            return Convert.ToDateTime(ConfigurationManager.AppSettings["fechaSistema"]);
        }

        public static void setAdminLoggeado(bool status)
        {
            isLogged = status;
        }

        public static bool adminLoggeado()
        {
            return isLogged;
        }


    }
}

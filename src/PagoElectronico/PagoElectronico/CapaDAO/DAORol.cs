using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.CapaDAO
{
    class DAORol:SqlConnector
    {
        //GET
        public static DataTable getRoles()
        {
            return retrieveDataTable("getRoles");
        }

        //Existe ROL
        public static bool existeRol(string nombre)
        {
            var dt = retrieveDataTable("getRolNom", nombre);
            return dt.Rows.Count > 0;
        }


    }
}

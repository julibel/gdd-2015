using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PagoElectronico.CapaDAO
{
    class DAOListado:SqlConnector
    {
        public static DataTable ejecutarListado(string fInicio, string fFin, string listado)
        {
            return retrieveDataTable(listado, fInicio, fFin);
        }
    }
}

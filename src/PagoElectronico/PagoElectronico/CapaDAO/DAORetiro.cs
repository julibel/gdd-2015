using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PagoElectronico.CapaDAO
{
    class DAORetiro:DAOOperacion
    {
        public static DataTable getBancos()
        {
            return retrieveDataTable("GET_BANCOS");
        }
    }
}

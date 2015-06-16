using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PagoElectronico.CapaDAO
{
    class DAOConsultaSaldos : SqlConnector
    {
        public static DataTable getUltimosDepositos(string id)
        {
            return retrieveDataTable("GET_ULTIMOS_DEPOSITOS", Convert.ToInt32(id));
        }

        public static DataTable getUltimasTransferencias(string id)
        {
            return retrieveDataTable("GET_ULTIMAS_TRANSFERENCIAS", Convert.ToInt32(id));
        }

        public static DataTable getUltimosRetiros(string id)
        {
            return retrieveDataTable("GET_ULTIMOS_RETIROS", Convert.ToInt32(id));
        }

        public static DataTable getSaldo(string id)
        {
            return retrieveDataTable("GET_SALDO", Convert.ToInt32(id));
        }
    }
}

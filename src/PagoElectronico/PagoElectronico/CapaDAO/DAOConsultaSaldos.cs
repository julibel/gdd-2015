using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PagoElectronico.CapaDAO
{
    class DAOConsultaSaldos:DAOOperacion
    {
        public static DataTable getUltimosDepositos(long cuentaID)
        {
            return retrieveDataTable("ULTIMOS_DEPOSITOS", cuentaID);
        }

        public static DataTable getUltimasTransferencias(long cuentaID)
        {
            DataTable total = retrieveDataTable("ULTIMAS_TRANSFERENCIAS", cuentaID);

            for (int i = 9; i < total.Rows.Count; i++)
            {
                total.Rows[i].Delete();
            }

            return total;
        }

        public static DataTable getUltimosRetiros(long cuentaID)
        {
            return retrieveDataTable("ULTIMOS_RETIROS", cuentaID);
        }
    }
}

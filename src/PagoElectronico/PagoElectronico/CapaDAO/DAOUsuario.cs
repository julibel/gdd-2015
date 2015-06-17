using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Model;

namespace PagoElectronico.CapaDAO
{
    public class DAOUsuario: SqlConnector
    {
        public static void modificarContrasenia(int usu_id, string pass)
        {
            executeProcedure("MODIFICAR_CONTRASENIA", usu_id, pass);
        }

    }
}

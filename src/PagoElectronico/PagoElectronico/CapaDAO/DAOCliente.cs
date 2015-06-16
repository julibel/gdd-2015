using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Model;

namespace PagoElectronico.CapaDAO
{
    public class DAOCliente : SqlConnector
    {
        public static void AgregarCliente(Persona cliente,Usuario usuario)
        {
            executeProcedure("AGREGAR_CLIENTE", 
                cliente.Nombre, 
                cliente.Apellido, 
                cliente.Documento, 
                cliente.TipoDoc, 
                cliente.Calle,
                cliente.Piso,
                cliente.Departamento,
                cliente.Localidad,
                cliente.Pais_Actual,
                cliente.FechaDeNacimiento,
                cliente.Pais_Nacionalidad,
                cliente.Mail,
                usuario.NombreUsuario,
                usuario.Password,
                Globals.getFechaSistema(),
                usuario.Pregunta,
                usuario.Respuesta
                );
        }


        public static bool existeDni(string dni, int tipo)
        {
            var dt = retrieveDataTable("GET_CLIENTE_DNI", dni, tipo);
            return dt.Rows.Count > 0;
        }

        public static bool existeMail(string mail)
        {
            var dt = retrieveDataTable("GET_CLIENTE_MAIL", mail);
            return dt.Rows.Count > 0;
        }

    }
}

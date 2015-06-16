using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PagoElectronico.Model;

namespace PagoElectronico.CapaDAO
{
    public class DAOCliente : SqlConnector
    {
        public static int AgregarCliente(Persona cliente,Usuario usuario)
        {
            int id = executeProcedureWithReturnValue("AGREGAR_CLIENTE", 
                cliente.Nombre, 
                cliente.Apellido, 
                cliente.Documento, 
                cliente.TipoDoc, 
                cliente.Calle,
                cliente.Piso,
                cliente.Departamento,
                cliente.Localidad,
                cliente.Pais_Actual,
                cliente.FechaDeNacimiento.ToString("yyyy-MM-dd HH:mm:ss"),
                cliente.Pais_Nacionalidad,
                cliente.Mail,
                usuario.NombreUsuario,
                usuario.Password,
                Globals.getFechaSistema(),
                usuario.Pregunta,
                usuario.Respuesta
                );
            
            return id;
            
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
        
        public static DataTable getClientes(string nombre, string apellido, string email, int tipoDoc, string nroDoc)
        {
            //List<Persona> clientes = new List<Persona>();

            DataTable table = retrieveDataTable("GET_CLIENTES", nombre, apellido, email, tipoDoc, nroDoc);

            /*foreach (DataRow row in table.Rows)
            {
                Persona cliente = dataRowToCliente(row);
                clientes.Add(cliente);
            }*/
            return table;
        }

        public static Persona dataRowToCliente(DataRow row)
        {
            return new Persona(Convert.ToInt32(row["ID"]),
                                row["NOMBRE"] as string,
                                row["APELLIDO"] as string,
                                row["NUMERO_DOC"] as string,
                                Convert.ToInt32(row["TIPO"]),
                                row["CALLE"] as string,
                                Convert.ToInt32(row["PISO"]),
                                row["DEPTO"] as string,
                                row["LOCALIDAD"] as string,
                                row["PAIS"] as string,
                                Convert.ToDateTime(row["FECHA_NACIMIENTO"]),
                                row["NACIONALIDAD"] as string,
                                row["MAIL"] as string);
        }

    }
}

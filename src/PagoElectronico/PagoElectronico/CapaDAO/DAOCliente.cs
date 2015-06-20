using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PagoElectronico.Model;
using System.Windows.Forms;

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

        public static void ModificarCliente(Persona cliente, int id)
        {
            executeProcedure("MODIFICAR_CLIENTE",
                id,
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
                cliente.Activo
                );


        }
        
        public static bool existeDni(string dni, int tipo)
        {
            return checkIfExists("GET_CLIENTE_DNI", dni, tipo);
        }

        public static bool existeMail(string mail)
        {
            return  checkIfExists("GET_CLIENTE_MAIL", mail);
        }

        public static DataTable getCliente(int id)
        {
            return retrieveDataTable("GET_CLIENTE", id);
        }
        
        public static DataTable getClientes(string nombre, string apellido, string email, int tipoDoc, string nroDoc, int estado)
        {
            return retrieveDataTable("FIND_CLIENTES", nombre, apellido, email, tipoDoc, nroDoc, estado);
        }

        public static void bajarCliente(int id)
        {
            executeProcedure("BAJA_CLIENTE", id);
        }

         public static Persona dataRowToCliente(DataRow row)
        {
             int pais = Convert.ToInt32(row["PAIS"]);
             int nac = Convert.ToInt32(row["NACIONALIDAD"]);

             return new Persona(Convert.ToInt32(row["CLI_ID"]),
                                row["NOMBRE"] as string,
                                row["APELLIDO"] as string,
                                row["NUMERO_DOC"] as string,
                                Convert.ToInt32(row["TIPO_DOC"]),
                                row["CALLE"] as string,
                                Convert.ToInt32(row["PISO"]),
                                row["DEPTO"] as string,
                                row["LOCALIDAD"] as string,
                                getPais(pais),
                                pais,
                                Convert.ToDateTime(row["FECHA_NACIMIENTO"]),
                                getPais(nac),
                                nac,
                                row["MAIL"] as string,
                                Convert.ToInt32(row["ESTADO"]));
         }

         public static string getPais(int pais)
         {
             return (retrieveDataTable("GET_PAIS", pais)).Rows[0][0].ToString();
         }

         public static DataTable getTarjetasCliente(int id)
         {
             return retrieveDataTable("GET_TARJETAS_CLIENTE", id);
         }

         public static bool coincideDocumento(int tipo, string documento)
         {
             return checkIfExists("COINCIDE_DOCUMENTO", Globals.userID, tipo, documento);
         }
    }
}

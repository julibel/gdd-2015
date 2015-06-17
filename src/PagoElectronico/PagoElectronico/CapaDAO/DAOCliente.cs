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

        public static DataTable getCliente(int id)
        {
            return retrieveDataTable("GET_CLIENTE", id);
        }
        
        public static DataTable getClientes(string nombre, string apellido, string email, int tipoDoc, string nroDoc)
        {
            //List<Persona> clientes = new List<Persona>();

            DataTable table = retrieveDataTable("FIND_CLIENTES", nombre, apellido, email, tipoDoc, nroDoc);

            /*foreach (DataRow row in table.Rows)
            {
                Persona cliente = dataRowToCliente(row);
                clientes.Add(cliente);
            }*/
            return table;
        }

        public static void bajarCliente(int id)
        {
            executeProcedure("BAJA_CLIENTE", id);
        }

         public static Persona dataRowToCliente(DataRow row)
        {

            return new Persona(Convert.ToInt32(row["CLI_ID"]),
                                row["NOMBRE"] as string,
                                row["APELLIDO"] as string,
                               row["NUMERO_DOC"] as string,
                                Convert.ToInt32(row["TIPO_DOC"]),
                                row["CALLE"] as string,
                                Convert.ToInt32(row["PISO"]),
                                row["DEPTO"] as string,
                                row["LOCALIDAD"] as string,
                                "pais",
                                Convert.ToInt32(row["PAIS"]),
                               Convert.ToDateTime(row["FECHA_NACIMIENTO"]),
                               "pais",
                                Convert.ToInt32(row["NACIONALIDAD"]),
                               row["MAIL"] as string);
      }
        /*
        public static Persona dataRowToCliente(DataGridViewRow row)
        {
            return new Persona(Convert.ToInt32(row.Cells[1]),//id
                                Convert.ToString(row.Cells[4]),//nombre
                                Convert.ToString(row.Cells[5]),//apellido
                                Convert.ToString(row.Cells[3]),//numero doc
                                Convert.ToInt32(row.Cells[2]), //tipo_dni
                                Convert.ToString(row.Cells[7]),//calle
                                Convert.ToInt32(row.Cells[8]),//piso
                                Convert.ToString(row.Cells[9]),//departamento
                                Convert.ToString(row.Cells[10]),//localidad
                                "pais",
                                Convert.ToInt32(row.Cells[6]),//pais_actual
                               DateTime.Today,// Convert.ToDateTime(row.Cells[12]),//fecha_nac
                                "pais",
                                Convert.ToInt32(row.Cells[11]),//pais_nacionalidad
                                Convert.ToString(row.Cells[13])//mail
                                );

//    CLI_ID INT IDENTITY(1,1) PRIMARY KEY,
//    TIPO_DOC INT,
//    NUMERO_DOC VARCHAR(10),
//    NOMBRE VARCHAR(255),
//    APELLIDO VARCHAR(255),
//    PAIS INT,
//    CALLE VARCHAR(255),
//    PISO INT,
//    DEPTO VARCHAR(10),
//    LOCALIDAD VARCHAR(60),
//    NACIONALIDAD INT,
//    FECHA_NACIMIENTO DATETIME,
//    MAIL VARCHAR(255),
//    USUARIO INT	
//)
        }
        */

         public static DataTable getTarjetasCliente(int id)
         {
             return retrieveDataTable("GET_TARJETAS_CLIENTE", id);
         }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Model
{
    public class Persona
    {
        // ID
        // Nombre
        // Apellido
        // Calle
        // Piso
        // Depto
        // Localidad
        // Fecha de Nacimiento
        // Tipo Documento
        // Documento
        // Mail

//        CREATE TABLE PERSONAS(


//    NUMERO_DOC NUMERIC(10,0),
//    NOMBRE VARCHAR(255),
//    APELLIDO VARCHAR(255),
//    PAIS INT,
//    CALLE VARCHAR(255),
//    NUMERO_DOM NUMERIC(5,0),
//    PISO INT,
//    DEPTO VARCHAR(10), --SIGUIENDO EL ESQUEMA DE LA MAESTRA
//    LOCALIDAD INT,
//    NACIONALIDAD INT,
//    FECHA_NACIMIENTO DATE,
//    MAIL VARCHAR(255),
//    USUARIO INT	
//)



        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; } //ver tipo de datos
        public int TipoDoc { get; set; } 
        public string Calle { get; set; }
        public int Piso { get; set; }
        public string Departamento { get; set; }
        public string Localidad { get; set; } 
        public string Pais_Actual { get; set; }
        public int Paid_Actual_Id { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Pais_Nacionalidad { get; set; }
        public int Paid_Nacionalidad_Id { get; set; }
        public string Mail { get; set; }
        public int Activo { get; set; }


        public Persona(int id, string nombre,string apellido, string doc, int tipo, string calle, int piso, string departamento,
                       string loc,string pais_actual, int pais_actual_id, DateTime fecha_nac, string pais_nacionalidad, int pais_nacionalidad_id, string mail)
        {
            ID = id;
            Nombre = nombre;
            Apellido = apellido;
            Documento = doc;
            TipoDoc = tipo;
            Calle = calle;
            Piso = piso;
            Departamento = departamento;
            Localidad = loc;
            Pais_Actual = pais_actual;
            Paid_Actual_Id = pais_actual_id;
            FechaDeNacimiento = fecha_nac;
            Pais_Nacionalidad = pais_actual;
            Paid_Nacionalidad_Id = pais_nacionalidad_id;
            Mail = mail;
        }

        public Persona(int id, string nombre, string apellido, string doc, int tipo, string calle, int piso, string departamento,
               string loc, string pais_actual, int pais_actual_id, DateTime fecha_nac, string pais_nacionalidad, int pais_nacionalidad_id, string mail, int activo)
        {
            ID = id;
            Nombre = nombre;
            Apellido = apellido;
            Documento = doc;
            TipoDoc = tipo;
            Calle = calle;
            Piso = piso;
            Departamento = departamento;
            Localidad = loc;
            Pais_Actual = pais_actual;
            Paid_Actual_Id = pais_actual_id;
            FechaDeNacimiento = fecha_nac;
            Pais_Nacionalidad = pais_actual;
            Paid_Nacionalidad_Id = pais_nacionalidad_id;
            Mail = mail;
            Activo = activo;
        }

    }
}

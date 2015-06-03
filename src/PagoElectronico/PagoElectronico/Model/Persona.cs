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

        public long ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public int TipoDoc { get; set; } 
        public string Calle { get; set; }
        public int Piso { get; set; }
        public string Departamento { get; set; }
        public string Localidad { get; set; }
        public int ID_Pais_Actual { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int ID_Pais_Nacionalidad { get; set; }
        public string Mail { get; set; }
        public int Activo { get; set; }
        public string Descripcion { get; set; }


        public Persona(int id, string nombre,string apellido, string doc, int tipo, string calle, int piso, string departamento,
                       string loc,int id_pais_actual, DateTime fecha_nac, int id_pais_nacionalidad, string mail, int desc)
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
            ID_Pais_Actual = id_pais_actual;
            FechaDeNacimiento = fecha_nac;
            ID_Pais_Nacionalidad = id_pais_actual;
            Mail = mail;
            Activo = 1;
            Descripcion = desc;


        }


    }
}

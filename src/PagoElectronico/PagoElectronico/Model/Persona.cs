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
        public string Calle { get; set; }
        public int Piso { get; set; }
        public string Departamento { get; set; }
        public string Localidad { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int TipoDoc { get; set; } 
        public string Mail { get; set; }
        public int Activo { get; set; }
        public string Descripcion { get; set; }


    }
}

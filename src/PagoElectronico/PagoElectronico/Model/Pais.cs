using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Model
{
    public class Pais
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public string Pais()
        {
            return Nombre;
        }
    }
}

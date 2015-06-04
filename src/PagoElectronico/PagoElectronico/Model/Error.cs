using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Model
{
    public class Error
    {
        public string Descripcion { get; set; }

        public Error(string desc)
        {
            Descripcion = desc;
        }
    }
}

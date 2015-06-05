using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Excepciones
{
    class ValidarDatos : Exception
    {
        public string mensaje { get; set; }

        public ValidarDatos(string msgError)
        {
            mensaje = msgError;
        }
    }
}

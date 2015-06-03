using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Model
{
    public class Funcionalidad
    {
        private int _id;
        private string _nombre;

        public Funcionalidad(int id, string nombre)
        {
            _id = id;
            _nombre = nombre;
        }
    }
}

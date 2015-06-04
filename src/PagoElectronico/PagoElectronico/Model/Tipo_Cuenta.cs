using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Model
{
    public class Tipo_Cuenta
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Costo_Mantenimiento { get; set; }
        public int Costo_Transaccion { get; set; }


        public Tipo_Cuenta(int id, string nombre, int mantenimiento, int transaccion)
        {
            ID = id;
            Nombre = nombre;
            Costo_Mantenimiento = mantenimiento;
            Costo_Transaccion = transaccion;
        }
    }
}

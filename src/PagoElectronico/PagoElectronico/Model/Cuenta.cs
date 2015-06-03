using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Model
{
    public class Cuenta
    {
        public int ID { get; set; }
        public int ID_Usuario { get; set; }
        public int Moneda { get; set; }
        public DateTime Fecha_Alta { get; set; }
        public DateTime Fecha_expiracion { get; set; }
        public int Saldo { get; set; }
        public int Estado { get; set; }

        public Cuenta(int id, int id_usuario, DateTime fecha_alta, DateTime fecha_expiracion, int saldo)
        {
            ID = id;
            ID_Usuario = id_usuario;
            Moneda = 0; // ver si esta bien q sea 0
            Fecha_Alta = fecha_alta;
            Fecha_expiracion = fecha_expiracion;
            Saldo = saldo;
            Estado = 1;
        }

    }
}

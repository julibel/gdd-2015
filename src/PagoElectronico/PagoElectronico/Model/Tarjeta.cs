using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Model
{
    public class Tarjeta
    {
        public int ID { get; set; }
        public int ID_Persona { get; set; }
        private int _cod_seguridad;
        private int _encriptado;
        private int _limpio;
        public int Emisor { get; set; }
        public DateTime Fecha_Emision { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }


        public Tarjeta(int id, int id_persona, int cod_seguridad, int encriptado, int limpio, int emisor,
                       DateTime fecha_emision, DateTime fecha_vencimiento)
        {
            ID = id;
            ID_Persona = id_persona;
            _cod_seguridad = cod_seguridad;
            _encriptado = encriptado;
            _limpio = limpio;
            Emisor = emisor;
            Fecha_Emision = fecha_emision;
            Fecha_Vencimiento = fecha_vencimiento;
        }

    }
}

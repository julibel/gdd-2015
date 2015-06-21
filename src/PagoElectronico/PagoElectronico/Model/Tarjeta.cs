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
        public int cod_seguridad;
        public long numero;
        public string titular { get; set; }
        public string Emisor { get; set; }
        public string Fecha_Emision { get; set; }
        public string Fecha_Vencimiento { get; set; }


        public Tarjeta(int id, int id_persona, int cod_seg, long num, string emisor,
                       string fecha_emision, string fecha_vencimiento)
        {
            ID = id;
            ID_Persona = id_persona;
            cod_seguridad = cod_seg;
            numero = num;
            Emisor = emisor;
            Fecha_Emision = fecha_emision;
            Fecha_Vencimiento = fecha_vencimiento;
        }

        public Tarjeta(string titu, long num, int cod_seg, string emisor, string fecha_emision, string fecha_vencimiento)
        {
            titular = titu;
            numero = num;
            cod_seguridad = cod_seg;
            Emisor = emisor;
            Fecha_Emision = fecha_emision;
            Fecha_Vencimiento = fecha_vencimiento;
        }


        public Tarjeta(long num, int cod_seg, string emisor)
        {
            numero = num;
            cod_seguridad = cod_seg;
            Emisor = emisor;
          
        }


        public Tarjeta(int id, int id_persona, int cod_seg, string emisor, string fecha_emision, string fecha_vencimiento)
        {
            ID = id;
            ID_Persona = id_persona;
            cod_seguridad = cod_seg;
            Emisor = emisor;
            Fecha_Emision = fecha_emision;
            Fecha_Vencimiento = fecha_vencimiento;
        }
  
    }
}

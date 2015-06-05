using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Excepciones;
using PagoElectronico.Model;


namespace PagoElectronico.Model
{
    public class Campo: ICampo
    {
        public string Texto { get; set; }
        public string Nombre { get; set; }
        public bool Obligatorio { get; set; }
        public Control.TipoValidacion tipoVal { get; set; }

        public Campo(string nom, string text, bool oblig, Control.TipoValidacion val)
        {
            Nombre = nom;
            Texto = text;
            Obligatorio = oblig;
            tipoVal = val;
        }
        //Metodo que valida si el campo cumple con las restricciones impuestas.
        public void Validar()
        {
            var mensaje = "";
            bool validado = true;

            if (Obligatorio && Texto == "") { mensaje += "-El campo " + this.Nombre + " es obligatorio." + Environment.NewLine; validado = false; }
            try
            {
                Control.validarTipo(this);
            }
            catch (ValidarDatos ex)
            {
                mensaje += ex.mensaje;
                validado = false;
            }

            if (!validado)
            {
                throw new ValidarDatos(mensaje);
            }
        }
    }
}

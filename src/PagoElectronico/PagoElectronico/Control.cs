using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using PagoElectronico.Excepciones;
using PagoElectronico.Model;


namespace PagoElectronico
{
    public class Control
    {
        private static Regex patronAlfanumerico = new Regex("[a-zA-Z0-9]");
        private static Regex patronCodigo = new Regex(@"^\d+$");
        public enum TipoValidacion { Alfanumerico, Dinero, Codigo, Patente };
        //Metodo para Validar los distintos campos
        public static void validarCampos(List<ICampo> campos)
        {
            string mensajeError = "";
            foreach (var campo in campos)
            {
                try
                {
                    campo.Validar();
                }
                catch (ValidarDatos ex)
                {
                    mensajeError += ex.mensaje;
                }
            }
            if (mensajeError != "") { throw new ValidarDatos(mensajeError); }

        }
        //Metodo para distinguir los tipos de validaciones, si se agrega un nuevo tipo, se debe agregar en TipoValidacion, y 
        //la opción en este metodo con la condición y el mensaje correspondiente si falla esa condición.
        public static void validarTipo(Campo campo)
        {
            if (campo.Texto != "")
            {
                switch (campo.tipoVal)
                {
                    case TipoValidacion.Alfanumerico:
                        if (!stringValido(campo.Texto)) { throw new ValidarDatos("-El campo " + campo.Nombre + " debe ser alfanumérico." + Environment.NewLine); }
                        break;
                    case TipoValidacion.Dinero:
                        if (!stringEsDinero(campo.Texto)) { throw new ValidarDatos("-El campo " + campo.Nombre + " debe representar dinero.(sin letras, negativo ni ',')" + Environment.NewLine); }
                        break;
                    case TipoValidacion.Codigo:
                        if (!stringEsCodigo(campo.Texto)) { throw new ValidarDatos("-El campo " + campo.Nombre + " no es un código válido. Solo se permiten números." + Environment.NewLine); }
                        break;

                }

            }
        }
        public static Boolean stringValido(string unString)
        {
            return patronAlfanumerico.IsMatch(unString);
        }

        public static Boolean stringEsNumero(string unString)
        {
            double num;
            return double.TryParse(unString, out num);

        }
        public static Boolean stringEsDinero(string unString)
        {
            double num;
            return double.TryParse(unString, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out num);
        }
        public static Boolean stringEsCodigo(string unString)
        {
            return patronCodigo.IsMatch(unString);
        }
    }
}

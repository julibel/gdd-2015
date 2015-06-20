using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Model
{
    enum EstadoCuenta : int
    {
        Habilitada = 1,
        Deshabilitada = 2,
        PendienteDeActivacion = 3,
        Cerrada = 4
    }
}

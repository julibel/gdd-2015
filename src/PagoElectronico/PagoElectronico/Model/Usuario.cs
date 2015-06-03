using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Model
{
    public class Usuario
    {
        private int ID;
        private string _nombreUsuario;
        private int _estado;
        private int _intentos_fallidos;
        private int _pregunta;
        private List<Rol> _roles;

        public Usuario(string nombre, List<Rol> roles)
        {
            _nombreUsuario = nombre;
            _roles = roles;
        }

        public List<Rol> Roles()
        {
            return _roles;
        }

    }
}

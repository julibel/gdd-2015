using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Model
{
    public class Usuario
    {
        public int ID;
        public string NombreUsuario;
        public string Password;
        public byte Estado;
        public int Intentos_fallidos;
        public string Pregunta;
        public string Respuesta;
        public List<int> Roles_list;

        public Usuario(int id,string nombre,string password,string pregunta,string respuesta,List<int> roles)
        {
            ID = id;
            NombreUsuario = nombre;
            Password = password;
            Estado = 1;
            Intentos_fallidos = 0;
            Pregunta = pregunta;
            Respuesta = respuesta;
            Roles_list = roles;
        }

    }
}

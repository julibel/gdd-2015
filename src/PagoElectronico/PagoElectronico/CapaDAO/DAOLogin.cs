using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.CapaDAO
{
    class DAOLogin:SqlConnector
    {
        private static void loginIncorrecto(string user)
        {
            intentoLogin(user, 0);
        }

        private static void loginCorrecto(string user)
        {
            intentoLogin(user, 1);
        }

        private static void intentoLogin(string user, int estado)
        {
            executeProcedure("INTENTO_LOGIN", user, estado, Globals.getFechaSistema());
        }

        public static bool iniciarSesionConPassword(string user, int rol, string pass)
        {
            if (executeProcedureWithReturnValue("PASSWORD_CORRECTA", user, Globals.getHashSha256(pass)) != 0)
            {
                return iniciarSesion(user, rol);
            }
            loginIncorrecto(user);
            return false;
        }

        
        public static bool iniciarSesionConRespuesta(string user, int rol, string resp)
        {
            if (executeProcedureWithReturnValue("RESPUESTA_CORRECTA", user, Globals.getHashSha256(resp)) != 0)
            {
                executeProcedure("SET_PASSWORD", user, Globals.getHashSha256("default"));
                MessageBox.Show("Su nueva contraseña es 'default', cámbiela por seguridad", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return iniciarSesion(user, rol);
            }
            return false;
        }

        private static bool iniciarSesion(string user, int rol)
        {
            List<int> funcionalidades = getFuncionalidades(rol);
            int userID = getUserID(user);
            
            Globals.setUser(userID, user, funcionalidades);
            
            return true;
        }

        private static int getUserID(string user)
        {
            return executeProcedureWithReturnValue("GET_USUARIO_ID", user);
        }

        private static List<int> getFuncionalidades(int rolID)
        {
            DataTable funcs = retrieveDataTable("GET_FUNCIONALIDADES_ROL", rolID);
            List<int> funcionalidades = new List<int>();
            MessageBox.Show("Acá llegué: " + Convert.ToString(rolID));
            for (int i = 0; i < funcs.Rows.Count; i++)
            {
                funcionalidades.Add((int)funcs.Rows[i][0]);
                MessageBox.Show(Convert.ToString(funcs.Rows[i][0]));
            }
            return funcionalidades;
        }

        public static bool existeUsuario(string user)
        {
            return executeProcedureWithReturnValue("EXISTE_USUARIO", user) != 0;
        }

        public static string getPregunta(string user)
        {
            DataTable resultado = retrieveDataTable("GET_PREGUNTA", user);

            return Convert.ToString(resultado.Rows[0][0]);
        }

        public static DataTable getRolesUsuario(string user)
        {
            return retrieveDataTable("GET_ROLES_USUARIO", user);
        }
    }
}

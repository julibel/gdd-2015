using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace PagoElectronico.CapaDAO
{
    class DAORol:SqlConnector
    {
        //GET ROL
        public static DataTable getRol(string id)
        {     
            return retrieveDataTable("GET_ROL",Convert.ToInt32(id));
        }

        //GET ALL ROLES
        public static DataTable getRoles(int estado)
        {
            return retrieveDataTable("GET_ROLES",estado);
        }

        //ROL EXISTS
        public static bool existeRol(string nombre)
        {
            var dt = retrieveDataTable("GET_ROL_NOM", nombre);
            return dt.Rows.Count > 0;
        }

        //GET ALL FUNCIONALIDADES
        public static DataTable getFuncionalidades()
        {
            return retrieveDataTable("GET_FUNCIONALIDADES");
        }

        //GET FUNCIONALIDADES ROL

        public static DataTable getFuncionalidades(int rol)
        {
            return retrieveDataTable("GET_FUNCIONALIDADES_ROL", rol);
        }


        //FUNCIONES AUXILIARES
        private static DataTable crearData(DataGridViewRowCollection integers)
        {
            List<int> ints = new List<int>();

            for (int i = 0; i < integers.Count; i++)
            {
                ints.Add((int)integers[i].Cells["FUN_ID"].Value);
            }

            return Globals.intsToDataTable(ints);
        }


        //AGREGAR, MODIFICAR Y DAR DE BAJA
        public static void agregarRol(string nombre, DataGridViewRowCollection funcionalidades,int estado)
        {
            executeProcedure("AGREGAR_ROL",nombre,crearData(funcionalidades),estado);
        }

        public static void modificarRol(int id, string nombre, DataGridViewRowCollection funcionalidades,int estado)
        {
            executeProcedure("MODIFICAR_ROL", id, nombre, crearData(funcionalidades),estado);
        }

        public static void eliminarRol(int id)
        {
            executeProcedure("BAJA_ROL", id);
        }

        public static void activarRol(string nombre)
        {
            executeProcedure("ACTIVAR_ROL", nombre);
        }
    }
}

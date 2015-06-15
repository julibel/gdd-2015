using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
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
        public static DataTable getRoles()
        {
            return retrieveDataTable("GET_ROLES");
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


        //FUNCIONES AUXILIARES
        private static DataTable crearData(DataGridViewRowCollection integers)
        {
            List<int> ints = new List<int>();
            DataTable dataFuncs = new DataTable();

            dataFuncs.Columns.Add("ITEM");

            for (int i = 0; i < integers.Count; i++)
            {
                ints.Add((int)integers[i].Cells[0].Value);
            }

            foreach (int num in ints)
            {
                var row = dataFuncs.NewRow();

                row["ITEM"] = Convert.ToString(num);

                dataFuncs.Rows.Add(row);
            }

            return dataFuncs;
        }


        //AGREGAR, MODIFICAR Y DAR DE BAJA
        public static void agregarRol(string nombre, DataGridViewRowCollection funcionalidades)
        {
            executeProcedure("AGREGAR_ROL",nombre,crearData(funcionalidades));
        }


        public static void modificarRol(int id, string nombre, DataGridViewRowCollection funcionalidades)
        {
            executeProcedure("MODIFICAR_ROL", id, nombre, crearData(funcionalidades));
        }

        public static void eliminarRol(int id)
        {
            executeProcedure("BAJA_ROL", id);
        }

        internal static void activarRol(string nombre)
        {
            executeProcedure("ACTIVAR_ROL", nombre);
        }
    }
}

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

        public static DataTable getRol(string id)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand sc = new SqlCommand("SELECT ROL_ID, NOMBRE, FUNCIONALIDAD FROM BOBBY_TABLES.ROLES, BOBBY_TABLES.FUNCIONALIDADES_POR_ROL WHERE  ROL_ID = ROL AND ROL_ID = " + id);

            CapaDAO.SqlConnector.conexionSql(cn, sc);

            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            cn.Close();

            return dt;
        }

        public static DataTable dataRoles()
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand sc = new SqlCommand("SELECT ROL_ID as Indice, NOMBRE as Rol FROM BOBBY_TABLES.ROLES");

            CapaDAO.SqlConnector.conexionSql(cn, sc);

            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Indice", typeof(int));
            dt.Columns.Add("Rol", typeof(string));
            dt.Load(reader);

            cn.Close();

            return dt;
        }

        public static DataTable dataFuncionalidades()
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand sc = new SqlCommand("SELECT FUN_ID, NOMBRE FROM BOBBY_TABLES.FUNCIONALIDADES");

            CapaDAO.SqlConnector.conexionSql(cn, sc);

            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("FUN_ID", typeof(int));
            dt.Columns.Add("NOMBRE", typeof(string));
            dt.Load(reader);

            cn.Close();

            return dt;
        }

        public static void agregarRol(string nombre, DataGridViewRowCollection funcionalidades)
        {
            List<int> funcs = new List<int>();
            DataTable dataFuncs = new DataTable();

            dataFuncs.Columns.Add("ITEM");

            for (int i = 0; i < funcionalidades.Count; i++)
            {
                funcs.Add((int)funcionalidades[i].Cells[0].Value);
            }

            foreach (int num in funcs)
            {
                var row = dataFuncs.NewRow();

                row["ITEM"] = Convert.ToString(num);

                dataFuncs.Rows.Add(row);
            }       
            executeProcedure("AGREGAR_ROL",nombre,dataFuncs);
        }
    }
}

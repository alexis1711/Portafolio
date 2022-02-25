using System.Data.SqlClient;
using System.Data;
//Clases no utilizadas
/*
 * using System;
 * using System.Collections.Generic;
 * using System.Linq;
 * using System.Text;
 * using System.Threading.Tasks;
 * using System.Windows.Forms;
 */

namespace Sistema_de_Control_de_Empleados__SCE_
{
    class cConexion
    {
        public SqlConnection conexion = new SqlConnection("Data Source=ALEXANDER-PC;Initial Catalog=SCE_DB;Integrated Security=True");

        public SqlConnection ABRICONEXION()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection CERRARCONEXION()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            conexion.Close();
            return conexion;
        }
    }
}

using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
//Clases no utilizadas
/*
 * using System.Collections.Generic;
 * using System.Linq;
 * using System.Text;
 * using System.Threading.Tasks;
 * using System.Data.OleDb;
 */


namespace Sistema_de_Control_de_Empleados__SCE_
{
    class cArea:cConexion
    {
        public string Id_Area { get; set; }
        public string Area { get; set; }

        public void Insertar()
        {
            ABRICONEXION();
            SqlCommand insert = new SqlCommand("INSERT INTO Area VALUES(@area)", conexion);
            insert.Parameters.AddWithValue("@area", Area);
            try
            {
                insert.ExecuteNonQuery();
                MessageBox.Show("Registro Agregado...", "Sistema Control de Empleados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ya exite una Área con este nombre", "Sistema Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CERRARCONEXION();
        }

        public DataTable mostrar()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ABRICONEXION();
            comando.CommandText = "SELECT * FROM Area";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            CERRARCONEXION();
            return tabla;
        }

        public void editar(string id, string area)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = ABRICONEXION();
            comando.CommandText = "UPDATE Area SET area = @area WHERE id_area = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@area", area);
            try
            {
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                MessageBox.Show("Registro Modificado...", "Sistema Control de Empleados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ya exite una Área con este nombre", "Sistema Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CERRARCONEXION();
        }

        public void eliminar(string id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = ABRICONEXION();
            comando.CommandText = "DELETE FROM Area WHERE id_area = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CERRARCONEXION();
            MessageBox.Show("Registro Eliminado...", "Sistema Control de Empleados",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }
    }
}
    

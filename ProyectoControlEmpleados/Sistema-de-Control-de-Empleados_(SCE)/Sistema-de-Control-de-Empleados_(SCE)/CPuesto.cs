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
    class cPuesto : cConexion
    {
        public string Id_Puesto { get; set; }
        public string Puesto { get; set; }

        public void Insertar()
        {
            ABRICONEXION();
            SqlCommand insert = new SqlCommand("INSERT INTO Puesto VALUES(@puesto)", conexion);
            insert.Parameters.AddWithValue("@puesto", Puesto);
            try
            {
                insert.ExecuteNonQuery();
                MessageBox.Show("Registro Agregado...", "Sistema Control de Empleados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ya exite un Puesto con este nombre", "Sistema Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CERRARCONEXION();

        }
        public DataTable mostrar()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ABRICONEXION();
            comando.CommandText = "SELECT * FROM Puesto";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            CERRARCONEXION();
            return tabla;
        }

        public void editar(string id, string puesto)
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ABRICONEXION();
            comando.CommandText = "UPDATE Puesto SET puesto = @puesto WHERE id_puesto = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@puesto", puesto);
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
                MessageBox.Show("Ya exite un Puesto con este nombre", "Sistema Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CERRARCONEXION();
        }

        public void eliminar(string id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = ABRICONEXION();
            comando.CommandText = "DELETE FROM Puesto WHERE id_puesto = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            MessageBox.Show("Registro Eliminado...", "Sistema Control de Empleados",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            CERRARCONEXION();
        }
    }
}

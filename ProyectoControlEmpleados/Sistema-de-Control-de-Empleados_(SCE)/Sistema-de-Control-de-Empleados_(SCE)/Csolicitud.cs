using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
//Clases no utilizadas
/*
 * using System.Collections.Generic;
 * using System.Linq;
 * using System.Text;
 * using System.Threading.Tasks;
 */

namespace Sistema_de_Control_de_Empleados__SCE_
{
    class cSolicitud : cConexion
    {
        public string Id_empleado { get; set; }
        public string Motivo { get; set; }
        public DateTime Fecha_motivo { get; set; }
        public string Id_admin { get; set; }
        public string Accion { get; set; }
        public DateTime Fecha_accion { get; set; }

        public DataTable mostrar()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ABRICONEXION();
            comando.CommandText = "SELECT S.id_solicitud, (E.nombre + ' ' + E.apellido) AS Empl, S.motivo, CONVERT(Date, S.fecha_pedido) AS fecha_pedido, (A.nombre + ' ' + A.apellido) AS Admin, S.accion, CONVERT(Date, S.fecha_accion) AS fecha_accion " +
                                    "FROM Solicitudes S INNER JOIN Empleados E ON S.id_empleado = E.id_empleado " +
                                    "FULL JOIN Administradores A ON A.id_admin = S.id_admin " +
                                    "WHERE E.id_area = (SELECT id_area FROM Administradores WHERE id_admin = '" + cPerfil.id + "') " +
                                    "ORDER BY fecha_accion ASC";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            CERRARCONEXION();
            return tabla;
        }
        public DataTable mostrarem()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ABRICONEXION();
            comando.CommandText = "SELECT S.id_solicitud, S.motivo, CONVERT(Date, S.fecha_pedido) AS fecha_pedido, (A.nombre + ' ' + A.apellido) AS Nombre, S.accion, CONVERT(Date, S.fecha_accion) AS fecha_accion " +
                                    "FROM Solicitudes S FULL JOIN Administradores A ON A.id_admin = S.id_admin " +
                                    "WHERE id_empleado = '" + cPerfil.id + "' ORDER BY fecha_pedido DESC";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            CERRARCONEXION();
            return tabla;
        }

        public void Insertar()
        {
            ABRICONEXION();
            SqlCommand insert = new SqlCommand("INSERT INTO Solicitudes(id_empleado, motivo, fecha_pedido) VALUES (@id_em, @motivo, @fecha)", conexion);
            insert.Parameters.AddWithValue("@id_em", Id_empleado);
            insert.Parameters.AddWithValue("@motivo", Motivo);
            insert.Parameters.AddWithValue("@fecha", Fecha_motivo);
            try
            {
                insert.ExecuteNonQuery();
                MessageBox.Show("Solicitud Ingresada...", "Sistema Control de Empleados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
            CERRARCONEXION();
        }

        public void editar(string id_ad, string accion, DateTime fecha, int id)
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ABRICONEXION();
            comando.CommandText = "UPDATE Solicitudes set id_admin = @id_ad, accion = @accion, fecha_accion = @fecha WHERE id_solicitud = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@id_ad", id_ad);
            comando.Parameters.AddWithValue("@accion", accion);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CERRARCONEXION();
        }

        public void editarmasivo(string accion, DateTime fecha)
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ABRICONEXION();
            comando.CommandText = "UPDATE Solicitudes set accion = @accion, fecha_accion = @fecha WHERE CONVERT(Date, fecha_pedido) < DATEADD(day, -1, GETDATE()) AND (accion= '' OR accion IS NULL)";
            comando.Parameters.AddWithValue("@accion", accion);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CERRARCONEXION();
        }
    }
}

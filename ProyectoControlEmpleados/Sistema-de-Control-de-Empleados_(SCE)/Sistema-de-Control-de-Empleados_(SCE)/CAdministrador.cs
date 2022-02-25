using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Sistema_de_Control_de_Empleados__SCE_
{
    class cAdministrador:cConexion
    {
        public string Id_Admin { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public int id_area { get; set; }
        public int id_puesto { get; set; }
        public bool incapacidad { get; set; }
        public bool estado { get; set; }


        public void Insertar()
        {
            ABRICONEXION();
            SqlCommand insert = new SqlCommand("INSERT INTO Administradores(id_admin, nombre, apellido, usuario, contrasena, id_area, id_puesto, incapacidad, estado) " +
                "values(@id_admin, @nombre, @apellido,@usuario, @contrasena, @id_area, @id_puesto, @incapacidad, @estado)", conexion);
            insert.Parameters.AddWithValue("@id_admin", Id_Admin);
            insert.Parameters.AddWithValue("@nombre", Nombre);
            insert.Parameters.AddWithValue("@apellido", Apellido);
            insert.Parameters.AddWithValue("@usuario", Usuario);
            insert.Parameters.AddWithValue("@contrasena", Contrasena);
            insert.Parameters.AddWithValue("@id_area", id_area);
            insert.Parameters.AddWithValue("@id_puesto", id_puesto);
            insert.Parameters.AddWithValue("@incapacidad", incapacidad);
            insert.Parameters.AddWithValue("@estado", true);

            try
            {

                insert.ExecuteNonQuery();
                MessageBox.Show("Registro Agregado...", "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Ya exite un Usuario con este nombre", "Sistema Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            CERRARCONEXION();
        }

        public bool Discapacidad(RadioButton a)
        {
            bool inc = false;
            if (a.Checked == true)
            {
                inc = true;
            }
            return inc;
        }

        //Genera el codigo del administrador
        public string Codigo(string a1)
        {
            string codigo;
            DateTime año = DateTime.Now;
            SqlDataReader leer;
            int año2 = año.Year - 2000;
            int cant = 0;
            SqlCommand cuenta = new SqlCommand("SELECT COUNT (id_admin) AS total FROM Administradores WHERE id_admin like '%" + año2 + "%'", conexion);
            ABRICONEXION();
            leer = cuenta.ExecuteReader();
            if (leer.Read() == true)
            {
                cant = int.Parse(leer["total"].ToString()) + 1;
            }
            CERRARCONEXION();
            return codigo = a1 + año2 + cant.ToString("000");
        }

        public int Codarea(ComboBox a)
        {
            SqlDataReader leer;

            string area = a.SelectedItem.ToString();
            int codigo = 0;
            SqlCommand consulta = new SqlCommand("Select id_area From Area Where area='" + area + "'", conexion);
            ABRICONEXION();
            leer = consulta.ExecuteReader();
            if (leer.Read() == true)
            {
                codigo = int.Parse(leer["id_area"].ToString());
            }
            CERRARCONEXION();
            return codigo;
        }

        public int Codpuesto(ComboBox a)
        {
            SqlDataReader leer;
            string puesto = a.SelectedItem.ToString();
            int codigo = 0;
            SqlCommand consulta = new SqlCommand("Select id_puesto From Puesto Where puesto='" + puesto + "'", conexion);
            ABRICONEXION();
            leer = consulta.ExecuteReader();
            if (leer.Read() == true)
            {
                codigo = int.Parse(leer["id_puesto"].ToString());
            }
            CERRARCONEXION();
            return codigo;
        }

        public DataTable mostrar()
        {
            SqlCommand comando = new SqlCommand();
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            comando.Connection = ABRICONEXION();
            comando.CommandText = "SELECT Ad.id_admin, Ad.nombre, Ad.apellido, Ad.usuario, Ad.contrasena, A.area, P.puesto, Ad.incapacidad, Ad.estado " +
                                    "FROM Administradores Ad INNER JOIN Puesto P ON Ad.id_puesto = P.id_puesto " +
                                    "INNER JOIN Area A ON Ad.id_area = A.id_area";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            CERRARCONEXION();
            return tabla;
        }

        public void editar(string id, string nombre, string apellido, string usuario, string contra, int area, int puesto, bool incapacidad)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = ABRICONEXION();
            comando.CommandText = "UPDATE Administradores SET nombre = @nombre, apellido = @apellido, usuario = @usuario, contrasena = @contrasena, id_area = @id_area, id_puesto = @id_puesto, incapacidad = @incapacidad WHERE id_admin = @id_admin";

            comando.Parameters.AddWithValue("@id_admin", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contrasena", contra);
            comando.Parameters.AddWithValue("@id_area", area);
            comando.Parameters.AddWithValue("@id_puesto", puesto);
            comando.Parameters.AddWithValue("@incapacidad", incapacidad);
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

        public void desactivar(string id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = ABRICONEXION();
            comando.CommandText = "UPDATE Administradores SET estado = "+ false +" WHERE id_admin = @id_admin";

            comando.Parameters.AddWithValue("@id_admin", id);
            comando.Parameters.AddWithValue("@estado", false);

            try
            {
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                MessageBox.Show("Registro Desactivado...", "Sistema Control de Empleados",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("", "Sistema Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

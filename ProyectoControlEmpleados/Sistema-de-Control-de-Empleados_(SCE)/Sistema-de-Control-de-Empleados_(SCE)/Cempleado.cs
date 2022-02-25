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
 * using System.Data.OleDb;
 */

namespace Sistema_de_Control_de_Empleados__SCE_
{
    class cEmpleado : cConexion
    {
        //Atributos
        public string Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime Fechanac { get; set; }
        public string Genero { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public int Area { get; set; }
        public int Puesto { get; set; }
        public bool Incapacidad { get; set; }
        public bool Estado { get; set; }

        //Metodos
        //genera el ID del empleado
        public string Codigo(string a1)
        {
            string codigo;
            DateTime año = DateTime.Now;
            SqlDataReader leer;
            int año2 = año.Year - 2000;
            int cant = 0;
            SqlCommand cuenta = new SqlCommand("SELECT COUNT (id_empleado) AS total FROM Empleados WHERE id_empleado like '%" + año2 + "%'", conexion);
            ABRICONEXION();
            leer = cuenta.ExecuteReader();
            if (leer.Read() == true)
            {
                cant = int.Parse(leer["total"].ToString()) + 1;
            }
            CERRARCONEXION();
            return codigo = a1 + año2 + cant.ToString("000");
        }

        //Para encontrar el genero
        public string Asigenero(RadioButton a)
        {
            string genero;
            if (a.Checked == true)
            {
                genero = "Masculino";
            }
            else
            {
                genero = "Femenino";
            }
            return genero;
        }

        //Para asignar el id de puesto
        public int Codpuesto(ComboBox a)
        {
            SqlDataReader leer;
            string puesto = a.SelectedItem.ToString();
            int codigo = 0;
            SqlCommand consulta = new SqlCommand("SELECT id_puesto FROM Puesto WHERE puesto='" + puesto + "'", conexion);
            ABRICONEXION();
            leer = consulta.ExecuteReader();
            if (leer.Read() == true)
            {
                codigo = int.Parse(leer["id_puesto"].ToString());
            }
            CERRARCONEXION();
            return codigo;
        }

        //Para asignar el id de area
        public int Codarea(ComboBox a)
        {
            SqlDataReader leer;

            string area = a.SelectedItem.ToString();
            int codigo = 0;
            SqlCommand consulta = new SqlCommand("SELECT id_area FROM Area WHERE area='" + area + "'", conexion);
            ABRICONEXION();
            leer = consulta.ExecuteReader();
            if (leer.Read() == true)
            {
                codigo = int.Parse(leer["id_area"].ToString());
            }
            CERRARCONEXION();
            return codigo;
        }
        //Para asignar Incapacidad
        public bool Discapacidad(RadioButton a)
        {
            bool inc = false;
            if (a.Checked == true)
            {
                inc = true;
            }
            return inc;
        }

        //Para mostrar en el datagried
        public DataTable mostrar()
        {
            SqlCommand comando = new SqlCommand();
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            comando.Connection = ABRICONEXION();
            comando.CommandText = "SELECT E.id_empleado, E.nombre, E.apellido,E.fecha_nacimiento,E.genero, E.usuario,E.contrasena, A.area, P.puesto,E.incapacidad,E.estado " +
                                    "FROM Empleados E INNER JOIN Puesto P ON E.id_puesto = P.id_puesto " +
                                    "INNER JOIN Area A ON E.id_area = A.id_area";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            CERRARCONEXION();
            return tabla;
        }

        public void editar(string id, string nombre, string apellido, DateTime fecha, string genero, string usuario, string contrasena, int area, int puesto, bool incapacidad)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = ABRICONEXION();
            comando.CommandText = "UPDATE Empleados SET id_empleado = @id, nombre = @nombre, apellido = @apellido, fecha_nacimiento = @fecha, genero = @genero, usuario = @us, contrasena = @contra, id_area = @ida, id_puesto = @idp, Incapacidad = @inc WHERE id_empleado = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@us", usuario);
            comando.Parameters.AddWithValue("@contra", contrasena);
            comando.Parameters.AddWithValue("@ida", area);
            comando.Parameters.AddWithValue("@idp", puesto);
            comando.Parameters.AddWithValue("@inc", incapacidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CERRARCONEXION();
        }
    }
}

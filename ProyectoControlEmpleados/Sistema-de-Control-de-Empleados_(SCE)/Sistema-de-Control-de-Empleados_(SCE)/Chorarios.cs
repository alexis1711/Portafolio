using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
//Clases no utilizadas
/*
 * using System.Linq;
 * using System.Text;
 * using System.Threading.Tasks;
 */

namespace Sistema_de_Control_de_Empleados__SCE_
{
    class cHorarios : cConexion
    {
        public string ID_empleado { get; set; }
        public int ID_horario { get; set; }
        public string Dia { get; set; }
        public DateTime Hentrada { get; set; }
        public DateTime Hsalida { get; set; }
        public bool Especial { get; set; }
        public bool Estado { get; set; }
        public int Caja { get; set; }

        public void Insertar(Queue<cHorarios> horarios, cHorarios ho)
        {
            ABRICONEXION();
            SqlDataReader leer;
            SqlCommand insert = new SqlCommand(" insert into Horarios_Empleados(id_empleado, dia, hora_inicial, hora_final, especial, estado, caja) values(@id, @dia, @horai, @horaf, @especial, @estado, @caja)" , conexion);
            insert.Parameters.AddWithValue("@id", ID_empleado);
            insert.Parameters.AddWithValue("@dia", Dia);
            insert.Parameters.AddWithValue("@horai", Hentrada);
            insert.Parameters.AddWithValue("@horaf", Hsalida);
            insert.Parameters.AddWithValue("@especial", Especial);
            insert.Parameters.AddWithValue("@estado", true);
            insert.Parameters.AddWithValue("@caja", Caja);
            try
            {
                insert.ExecuteNonQuery();
                MessageBox.Show("Registro Agregado...", "Sistema Control de Empleados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                CERRARCONEXION();
                //Para meterlo en la cola
                ABRICONEXION();
                SqlCommand cuenta = new SqlCommand("SELECT TOP 1 id_horario FROM Horarios_Empleados ORDER BY id_horario DESC", conexion);
                leer = cuenta.ExecuteReader();
                if (leer.Read() == true)
                {
                    ho.ID_horario = int.Parse(leer["id_horario"].ToString());
                }
                CERRARCONEXION();
                horarios.Enqueue(ho);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                CERRARCONEXION();
            }
        }

        public void editar(string id_h, string dia, DateTime he, DateTime hs, bool especial, int caja)
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ABRICONEXION();
            comando.CommandText = "UPDATE Horarios_Empleados set  estado = @estado, dia = @dia, hora_inicial = @hi, hora_final = @hf, especial = @especial,  caja = @caja WHERE id_horario = @id_h";
            comando.Parameters.AddWithValue("@id_h", id_h);
            comando.Parameters.AddWithValue("@estado", true);
            comando.Parameters.AddWithValue("@dia", dia);
            comando.Parameters.AddWithValue("@hi", he);
            comando.Parameters.AddWithValue("@hf", hs);
            comando.Parameters.AddWithValue("@especial", especial);
            comando.Parameters.AddWithValue("@caja", caja);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            MessageBox.Show("Registro Modificado...", "Sistema Control de Empleados",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            CERRARCONEXION();
        }

        public bool validarguard(string dia, CheckBox espe, string id)
        {
            bool veri = false;
            try
            {
                ABRICONEXION();
                if (espe.Checked)
                {
                    SqlDataReader leer;
                    SqlCommand select = new SqlCommand("SELECT id_empleado FROM Horarios_Empleados where dia = '" + dia + "' AND especial = 1  AND id_empleado = '" + id + "'", conexion);
                    leer = select.ExecuteReader();
                    if(leer.Read() == true)
                    {
                        veri = true;
                        MessageBox.Show("Solo se puede guardar un horario habilitado por empleado", "Sistema Control de Empleados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                        veri = false;
                }
                else
                {
                    SqlDataReader leer2;
                    SqlCommand f = new SqlCommand("select id_empleado from Horarios_Empleados WHERE dia = '" + dia + "' AND especial = 0 AND id_empleado = '" + id + "'", conexion);
                    leer2 = f.ExecuteReader();
                    if(leer2.Read()==true)
                    {
                        veri = true;
                        MessageBox.Show("Solo se puede guardar un horario habilitado por empleado", "Sistema Control de Empleados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                        veri = false;
                    
                }
                CERRARCONEXION();
            }
            catch
            {
                MessageBox.Show("Solo se puede guardar un horario habilitado por empleado", "Sistema Control de Empleados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return veri;
        }

        public bool validarmodifi(string dia, CheckBox espe, string id, int id_ho)
        {
            bool veri = false;
            try
            {
                ABRICONEXION();
                if (espe.Checked)
                {
                    SqlDataReader leer;
                    SqlCommand select = new SqlCommand("SELECT id_horario FROM Horarios_Empleados WHERE dia = '" + dia + "' AND especial = 1  AND id_empleado = '" + id + "'", conexion);
                    leer = select.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        int horari = int.Parse(leer["id_horario"].ToString());
                        if (horari == id_ho)
                            veri = false;
                        else
                        {
                            veri = true;
                            MessageBox.Show("Solo se puede guardar un horario habilitado por empleado", "Sistema Control de Empleados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                        veri = false;
                }
                else
                {
                    SqlDataReader leer2;
                    SqlCommand cadena = new SqlCommand("SELECT id_horario FROM Horarios_Empleados WHERE dia = '" + dia + "' AND especial = 0 AND id_empleado = '" + id + "'", conexion);
                    leer2 = cadena.ExecuteReader();
                    if (leer2.Read() == true)
                    {
                        int horari = int.Parse(leer2["id_horario"].ToString());
                        if (horari == id_ho)
                            veri = false;
                        else
                        {
                            veri = true;
                            MessageBox.Show("Solo se puede guardar un horario habilitado por empleado", "Sistema Control de Empleados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                        veri = false;
                }
                CERRARCONEXION();
            }
            catch
            {
                MessageBox.Show("Solo se puede guardar un horario habilitado por empleado", "Sistema Control de Empleados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return veri;
        }

        public void mostrarh(DataGridView dgv)
        {
            SqlDataAdapter da;
            DataTable dt;
            try
            {
                ABRICONEXION();
                da = new SqlDataAdapter("SELECT Empleados.id_empleado, id_horario, (nombre + ' ' + apellido) AS Nombre, dia, hora_inicial, hora_final, especial, Horarios_Empleados.estado, caja FROM Horarios_Empleados INNER JOIN Empleados ON Horarios_Empleados.id_empleado = Empleados.id_empleado ", conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                CERRARCONEXION();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo cargar " + ex.ToString());
            }
        }
        public void mostrare(DataGridView dgv)
        {
            SqlDataAdapter da;
            DataTable dt;
            try
            {
                ABRICONEXION();
                da = new SqlDataAdapter("SELECT id_empleado, (nombre + ' ' + apellido) AS Nombre FROM Empleados ", conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                CERRARCONEXION();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo cargar " + ex.ToString());
            }
        }

        public void mostraractu(DataGridView dgv)
        {
            SqlDataAdapter da;
            DataTable dt;
            try
            {
                ABRICONEXION();
                string cadena = "SELECT (E.nombre + ' ' + E.apellido) AS Nombre, A.asistencia, A.hora, H.especial " +
                    "FROM Asistencia A " +
                    "INNER JOIN Horarios_Empleados H ON A.id_horario = H.id_horario " +
                    "INNER JOIN Empleados E ON E.id_empleado = H.id_empleado " +
                    "WHERE A.fecha = '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "' AND E.id_area = (SELECT id_area FROM Area WHERE area = '" + cPerfil.area + "') " +
                    "ORDER BY A.hora DESC";
                da = new SqlDataAdapter(cadena, conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                CERRARCONEXION();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar " + ex.ToString());
            }
        }

        public void mostrargene(DataGridView dgv)
        {
            SqlDataAdapter da;
            DataTable dt;
            try
            {
                ABRICONEXION();
                string cadena = "SELECT (E.nombre + ' ' + E.apellido) AS Nombre, A.asistencia, A.hora, H.especial, A.fecha " +
                    "FROM Asistencia A " +
                    "INNER JOIN Horarios_Empleados H ON A.id_horario = H.id_horario " +
                    "INNER JOIN Empleados E ON E.id_empleado = H.id_empleado " +
                    "WHERE E.id_area = (SELECT id_area FROM Area WHERE area = '" + cPerfil.area + "') " +
                    "ORDER BY A.fecha DESC";
                da = new SqlDataAdapter(cadena, conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                CERRARCONEXION();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar " + ex.ToString());
            }
        }

        public void eliminar()
        {
            try
            {
                ABRICONEXION();
                string cadena = "DELETE FROM Horarios_Empleados WHERE id_horario=" + ID_horario;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Registro Eliminado...", "Sistema Control de Empleados",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("El elemento no existe", "Sistema Control de Empleados",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                CERRARCONEXION();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar " + ex.ToString());
            }
        }

        public void desactivar(bool estado)
        {
            try
            {
                DataTable tabla = new DataTable();
                SqlCommand comando = new SqlCommand();
                comando.Connection = ABRICONEXION();
                comando.CommandText = "UPDATE Horarios_Empleados SET estado = @estado WHERE id_horario = @id_h";
                comando.Parameters.AddWithValue("@id_h", ID_horario);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                CERRARCONEXION();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la acción " + ex.ToString());
            }
        }

        //Para las Asistencias
        public void insertasis(int id, DateTime hora, string asistencia, DateTime fecha)
        {
            ABRICONEXION();
            SqlCommand insert = new SqlCommand("INSERT INTO Asistencia(id_horario, hora, asistencia, fecha) values(@id, @hora, @asistencia, @fecha)" , conexion);
            insert.Parameters.AddWithValue("@id", id);
            insert.Parameters.AddWithValue("@hora", hora);
            insert.Parameters.AddWithValue("@asistencia", asistencia);
            insert.Parameters.AddWithValue("@fecha", fecha);
            try
            {
                insert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
            CERRARCONEXION();
        }

        public bool veriasistencia(int id)
        {
            bool veri = false;
            try
            {
                SqlDataReader leer;
                DateTime inicio = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"));
                SqlCommand cuenta = new SqlCommand("SELECT hora_inicial FROM Horarios_Empleados WHERE id_horario = '" + id + "' AND estado = 1", conexion);
                ABRICONEXION();
                leer = cuenta.ExecuteReader();
                if (leer.Read() == true)
                {
                    if (DateTime.TryParse((leer["hora_inicial"].ToString()), out DateTime hora))
                    {
                        TimeSpan dif = new TimeSpan();
                        dif = inicio - hora;
                        double cant = dif.TotalMinutes;
                        if (cant >= -60 && cant <= 15)
                            veri = true;
                        else
                            veri = false;
                    }
                    else
                        veri = false;
                }
                else
                    veri = false;
                CERRARCONEXION();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al marcar, intente de nuevo " + ex);
            }
            return veri;
        }

        public bool veriretirada(int id)
        {
            bool veri = false;
            try
            {
                SqlDataReader leer;
                DateTime fin = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"));
                SqlCommand cuenta = new SqlCommand("SELECT hora_final FROM Horarios_Empleados WHERE id_horario = '" + id + "' AND estado = 1", conexion);
                ABRICONEXION();
                leer = cuenta.ExecuteReader();
                if (leer.Read() == true)
                {
                    if (DateTime.TryParse((leer["hora_final"].ToString()), out DateTime hora))
                    {
                        TimeSpan dif = new TimeSpan();
                        dif = fin - hora;
                        double cant = dif.TotalMinutes;
                        if (cant >= -30 && cant <= 50)
                            veri = true;
                        else
                            veri = false;
                    }
                    else
                        veri = false;
                }
                else
                    veri = false;
                CERRARCONEXION();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al marcar, intente de nuevo " + ex);
            }
            return veri;
        }

        public bool veriMarcado(int id_ho, string asitencia)
        {
            SqlDataReader leer;
            bool veri = false;
            try
            { 
                string cadena = "SELECT H.id_horario, A.asistencia, A.fecha " +
                    "FROM Asistencia A " +
                    "INNER JOIN Horarios_Empleados H ON A.id_horario = H.id_horario " +
                    "WHERE H.id_horario = " + id_ho + " AND A.fecha = '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "' AND A.asistencia = '" + asitencia + "' AND estado = 1";
                SqlCommand cuenta = new SqlCommand(cadena, conexion);
                ABRICONEXION();
                leer = cuenta.ExecuteReader();
                if (leer.Read() == true)
                {
                    veri = true;
                }
                else
                    veri = false;
                CERRARCONEXION();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al marcar, intente de nuevo" + ex);
            }
            return veri;
        }

        public void RecargarHorario(DataGridView dgv)
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ABRICONEXION();
            string fecha = DiaNombre(DateTime.Now);
            comando.CommandText = "SELECT id_horario, hora_inicial, hora_final, especial, caja FROM Horarios_Empleados WHERE id_empleado = '" + cPerfil.id + "' AND dia = '" + fecha + "' AND estado = 1";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            CERRARCONEXION();
            dgv.DataSource = tabla;
        }

        //Para saber en que dia de la semana estamos
        private string DiaNombre(DateTime fecha)
        {
            string nombre = "";
            switch (fecha.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    nombre = "Domingo";
                    break;
                case DayOfWeek.Monday:
                    nombre = "Lunes";
                    break;
                case DayOfWeek.Tuesday:
                    nombre = "Martes";
                    break;
                case DayOfWeek.Wednesday:
                    nombre = "Miercoles";
                    break;
                case DayOfWeek.Thursday:
                    nombre = "Jueves";
                    break;
                case DayOfWeek.Friday:
                    nombre = "Viernes";
                    break;
                case DayOfWeek.Saturday:
                    nombre = "Sabado";
                    break;
            }
            return nombre;
        }
    }
}



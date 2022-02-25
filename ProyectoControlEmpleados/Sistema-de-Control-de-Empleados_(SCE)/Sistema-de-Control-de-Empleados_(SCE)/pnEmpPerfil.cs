using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
//Clases no utilizadas
/*
 * using System.Collections.Generic;
 * using System.ComponentModel;
 * using System.Drawing;
 * using System.Linq;
 * using System.Text;
 * using System.Threading.Tasks;
 * using System.Data.Sql;
 * using System.Data.OleDb;
 * using System.Drawing.Printing;
 */

namespace Sistema_de_Control_de_Empleados__SCE_
{
    public partial class pnEmpPerfil : Form
    {
        cConexion co = new cConexion();
     
        private string contra;
        private int verificar = 0;
        public pnEmpPerfil()
        {
            InitializeComponent();
            Limpiar();
        }
        public void Limpiar()
        {
            foreach (Control con in Controls)
            {
                if (con is TextBox)
                {
                    ((TextBox)con).Clear();
                }
            }
            txtUsuario.Focus();
        }

        private void FormatoGridHorario()
        {
            //Renombro las columnas del dgv como quiera
            dgvHorario.Columns[0].Visible = false;
            dgvHorario.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHorario.Columns[1].HeaderText = "Día";
            dgvHorario.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHorario.Columns[2].HeaderText = "Hora de Entrada";
            dgvHorario.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHorario.Columns[3].HeaderText = "Hora de Salida";
            dgvHorario.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHorario.Columns[4].HeaderText = "Fecha Especial";
            dgvHorario.Columns[5].Visible = false;
            dgvHorario.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHorario.Columns[6].HeaderText = "Caja";
        }

        private void RecargarHorario()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = co.ABRICONEXION();
            comando.CommandText = "SELECT id_horario, dia, hora_inicial, hora_final, especial, estado, caja FROM Horarios_Empleados WHERE id_empleado = '" + cPerfil.id + "' AND estado = 1";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            co.CERRARCONEXION();
            dgvHorario.DataSource = tabla;
        }

        private void Recargar()
        {
            try
            {
                co.ABRICONEXION();
                string cadena;
                cadena = "SELECT E.id_empleado, E.nombre, E.apellido, E.usuario, E.contrasena, E.fecha_nacimiento, E.genero, A.area, P.puesto ";
                cadena += " FROM Empleados E INNER JOIN Puesto P ON E.id_puesto = P.id_puesto";
                cadena += " INNER JOIN Area A ON E.id_area = A.id_area";
                cadena += " WHERE E.id_empleado = @id";
                //
                SqlCommand carg = new SqlCommand(cadena, co.conexion);
                carg.Parameters.AddWithValue("@id", cPerfil.id);
                SqlDataReader ver = carg.ExecuteReader();
                if (ver.Read())
                {
                    txtNombre.Text = ver["nombre"].ToString();
                    txtApellido.Text = ver["apellido"].ToString();
                    txtUsuario.Text = ver["usuario"].ToString();
                    contra = ver["contrasena"].ToString();
                    txtContra.Text = contra;
                    txtVeriContra.Text = contra;
                    dtpFechaNac.Value = Convert.ToDateTime(ver["fecha_nacimiento"]);
                    if (ver["genero"].ToString() == "Femenino")
                    {
                        rbtnFemenino.Checked = true;
                        rbtnMasculino.Checked = false;
                    }
                    else if (ver["genero"].ToString() == "Masculino")
                    {
                        rbtnMasculino.Checked = true;
                        rbtnFemenino.Checked = false;
                    }
                    txtArea.Text = ver["area"].ToString();
                    txtPuesto.Text = ver["puesto"].ToString();
                }
                co.CERRARCONEXION();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificar == 0)
                {
                    if (txtUsuario.Text != "" && txtContra.Text != "" && txtVeriContra.Text != "")
                    {
                        if (txtContra.Text == txtVeriContra.Text)
                        {
                            co.ABRICONEXION();
                            //Verificamos en admin
                            string cadena = "SELECT id_admin FROM Administradores";
                            cadena += " WHERE usuario = @usuario";
                            SqlCommand ad = new SqlCommand(cadena, co.conexion);
                            ad.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                            SqlDataReader ver = ad.ExecuteReader();
                            if (!ver.Read())
                            {
                                ver.Close();
                                //Verificamos en empleados
                                cadena = "SELECT id_empleado FROM Empleados";
                                cadena += " WHERE usuario = @usuario";
                                //
                                SqlCommand emp = new SqlCommand(cadena, co.conexion);
                                emp.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                                SqlDataReader vera = emp.ExecuteReader();
                                if (!vera.Read())
                                {
                                    vera.Close();
                                    co.CERRARCONEXION();
                                    SqlCommand carg = new SqlCommand();
                                    carg.Connection = co.ABRICONEXION();
                                    carg.CommandText = "UPDATE Empleados SET usuario = @usuario, contrasena = @contra where id_empleado = @id";
                                    carg.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                                    carg.Parameters.AddWithValue("@contra", txtContra.Text);
                                    carg.Parameters.AddWithValue("@id", cPerfil.id);
                                    carg.ExecuteNonQuery();
                                    carg.Parameters.Clear();
                                    co.CERRARCONEXION();
                                    verificar++;
                                    MessageBox.Show("Se actualizarón los datos, por favor cierre la sesión y reingrese", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    vera.Close();
                                    MessageBox.Show("El usuario ya existe, ingrese otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                ver.Close();
                                MessageBox.Show("El usuario ya existe, ingrese otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            Limpiar();
                            Recargar();
                        }
                        else
                        {
                            MessageBox.Show("Debe verificar correctamente la Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe completar todos los campos (Usuario, Contraseñas)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                else
                {
                    MessageBox.Show("Ya ha cambiado sus datos, cierre sesión y reingrese", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron editar los datos: " + ex.Message);
            }
        }

        private void pnEmpPerfil_Load(object sender, EventArgs e)
        {
            Recargar();
            RecargarHorario();
            FormatoGridHorario();
        }
    }
}

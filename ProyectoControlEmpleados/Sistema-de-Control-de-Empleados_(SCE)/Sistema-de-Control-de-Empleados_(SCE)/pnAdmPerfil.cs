using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.OleDb;
using System.Drawing.Printing;

namespace Sistema_de_Control_de_Empleados__SCE_
{
    public partial class pnAdmPerfil : Form
    {
        cConexion co = new cConexion();
        private string contra;
        private int verificar = 0;
        public pnAdmPerfil()
        {
            InitializeComponent();
            Limpiar();
        }

        private void Recargar ()
        {
            try
            {
                co.ABRICONEXION();
                string cadena;
                cadena = "SELECT D.id_admin, D.nombre, D.apellido, D.usuario, D.contrasena, A.area, P.puesto";
                cadena += " FROM Administradores D INNER JOIN Puesto P ON D.id_puesto = P.id_puesto";
                cadena += " INNER JOIN Area A ON D.id_area = A.id_area";
                cadena += " WHERE D.id_admin = @id";
                //
                SqlCommand carg = new SqlCommand(cadena, co.conexion);
                carg.Parameters.AddWithValue("@id", cPerfil.id);
                SqlDataReader ver = carg.ExecuteReader();
                if (ver.Read())
                {
                    txtNombres.Text = ver["nombre"].ToString();
                    txtApellidos.Text = ver["apellido"].ToString();
                    txtUsuario.Text = ver["usuario"].ToString();
                    contra = ver["contrasena"].ToString();
                    txtContra.Text = contra;
                    txtVeriContra.Text = contra;
                    txtArea.Text = ver["area"].ToString();
                    txtPuesto.Text = ver["puesto"].ToString();
                }
                co.CERRARCONEXION();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Limpiar()
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if(verificar == 0)
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
                                    carg.CommandText = "UPDATE Administradores SET usuario = @usuario, contrasena = @contra where id_admin = @id";
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

        private void pnAdmPerfil_Load(object sender, EventArgs e)
        {
            Recargar();
        }
    }
}

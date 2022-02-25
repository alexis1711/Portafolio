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
    public partial class frmLogin : Form
    {
        int alto = 0, ancho = 0;
        cConexion co = new cConexion();
        public frmLogin()
        {
            InitializeComponent();
            ancho = this.Width;
            alto = this.Height;
            //Le ponemos el Logo al Form
            Icon Logo = new Icon("Imagenes/SCP_Logo.ico");
            this.Icon = Logo;
            pcbLogin.Image = new Bitmap("Imagenes/people.png");
            BarraTit();
            txtUsuario.Focus();
        }

        private void BarraTit()
        {
            pcbLogo.Image = new Bitmap("Imagenes/SCP_Logo.png");
            //Botón de cerrar
            btnExit.Location = new Point(ancho - 35, 0);
            btnExit.BackgroundImage = new Bitmap("Imagenes/close.png");
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.ForeColor = Color.DarkGray;
            //Botón de minimizar
            btnMin.Location = new Point(ancho - 70, 0);
            btnMin.BackgroundImage = new Bitmap("Imagenes/less.png");
            btnMin.BackgroundImageLayout = ImageLayout.Stretch;
            btnMin.ForeColor = Color.DarkGray;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            co.ABRICONEXION();
            string cadena;
            try
            {
                cadena = "SELECT E.id_empleado, E.nombre, E.apellido, A.area, P.puesto";
                cadena += " FROM Empleados E INNER JOIN Puesto P ON E.id_puesto = P.id_puesto";
                cadena += " INNER JOIN Area A ON E.id_area = A.id_area";
                cadena += " WHERE E.usuario = @usuario AND E.contrasena = @contra AND estado = 1";
                //
                SqlCommand adm = new SqlCommand(cadena, co.conexion);
                adm.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                adm.Parameters.AddWithValue("@contra", txtContra.Text);
                co.ABRICONEXION();
                SqlDataReader ver1 = adm.ExecuteReader();
                if (ver1.Read())
                {
                    frmEmpleadosPrincipal frmEmp = new frmEmpleadosPrincipal();
                    cPerfil.id = ver1["id_empleado"].ToString();
                    cPerfil.nombre = ver1["nombre"].ToString();
                    cPerfil.apellido = ver1["apellido"].ToString();
                    cPerfil.area = ver1["area"].ToString();
                    cPerfil.puesto = ver1["puesto"].ToString();
                    MessageBox.Show("Bienvenid@ " + ver1["nombre"].ToString() + " " + ver1["apellido"].ToString(), "Bienvenido", MessageBoxButtons.OK);
                    co.CERRARCONEXION();
                    this.Hide();
                    frmEmp.Show();
                }
                else
                {
                    ver1.Close();
                    cadena = "";
                    cadena = "SELECT D.id_admin, D.nombre, D.apellido, D.usuario, A.area, P.puesto";
                    cadena += " FROM Administradores D INNER JOIN Puesto P ON D.id_puesto = P.id_puesto";
                    cadena += " INNER JOIN Area A ON D.id_area = A.id_area";
                    cadena += " WHERE D.usuario = @usuario AND D.contrasena = @contra AND estado = 1";
                    //
                    SqlCommand emp = new SqlCommand(cadena, co.conexion);
                    emp.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    emp.Parameters.AddWithValue("@contra", txtContra.Text);
                    SqlDataReader ver2 = emp.ExecuteReader();
                    if (ver2.Read())
                    {
                        frmAdminsPrincipal frmAdm = new frmAdminsPrincipal();
                        cPerfil.id = ver2["id_admin"].ToString();
                        cPerfil.nombre = ver2["nombre"].ToString();
                        cPerfil.apellido = ver2["apellido"].ToString();
                        cPerfil.area = ver2["area"].ToString();
                        cPerfil.puesto = ver2["puesto"].ToString();
                        MessageBox.Show("Bienvenid@ " + ver2["nombre"].ToString() + " " + ver2["apellido"].ToString(), "Bienvenido", MessageBoxButtons.OK);
                        ver2.Close();
                        co.CERRARCONEXION();
                        this.Hide();
                        frmAdm.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo iniciar la sesión, usuario o contraseña incorrecta");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            co.CERRARCONEXION();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int posiX = 0, posiY = 0;
        private void BarraTitulo(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posiX = e.X;
                posiY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posiX);
                Top = Top + (e.Y - posiY);
            }
        }
    }
}

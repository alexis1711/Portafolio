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
    public partial class frmAdminsPrincipal : Form
    {
        
        pnAdmHorarios n = new pnAdmHorarios();
        int ancho = 0, alto = 0;
        public frmAdminsPrincipal()
        {
            InitializeComponent();
            ancho = this.Width;
            alto = this.Height;
            //Mostramos el Logo
            Icon Logo = new Icon("Imagenes/SCP_Logo.ico");
            this.Icon = Logo;
            pnMostrar.Location = new Point(175, 103);
            pnMostrar.Size = new Size(956, 528);
            BarraTit();
            BarraOpciones(btnAdmin);
            //Cargamos los Formularios
            Abrir<pnAdmAdministradores>();
            Abrir<pnAdmEmpleados>();
            Abrir<pnAdmHorarios>();
            Abrir<pnAdmAreaPuesto>();
            Abrir<pnAdmSolicitudes>();
            Abrir<pnAdmActualidad>();
            Abrir<pnAdmPerfil>();
        }

        private void BarraOpciones(Button btn)
        {
            foreach (Control boton in pnOpc.Controls)
            {
                if (boton == btnCerrarSesion)
                {

                }
                else if (boton == btn)
                {
                    boton.BackColor = Color.ForestGreen;
                    boton.ForeColor = Color.White;
                }
                else
                {
                    boton.BackColor = Color.DarkGray;
                    boton.ForeColor = Color.Black;
                }
            }
        }

        private void Abrir<F>() where F : Form, new()
        {
            Form form = pnMostrar.Controls.OfType<F>().FirstOrDefault();
            if (form != null)
            {
                //Si la instancia esta minimizada la dejamos en su estado normal
                if (form.WindowState == FormWindowState.Minimized)
                {
                    form.WindowState = FormWindowState.Normal;
                }
                //Si la instancia existe la  ponemos en primer plano
                form.BringToFront();
                return;
            }
            form = new F();
            form.TopLevel = false;
            pnMostrar.Controls.Add(form);
            pnMostrar.Tag = form;
            form.Show();
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

        private void btnadmin_Click(object sender, EventArgs e)
        {
            BarraOpciones(btnAdmin);
            Abrir<pnAdmAdministradores>();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            BarraOpciones(btnEmpleados);
            Abrir<pnAdmEmpleados>();

        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            BarraOpciones(btnHorarios);
            Abrir<pnAdmHorarios>();
            n.ActualizarGrid();
        }

        private void btnAreaPuesto_Click(object sender, EventArgs e)
        {
            BarraOpciones(btnAreaPuesto);
            Abrir<pnAdmAreaPuesto>();
        }

        private void btnActualidad_Click(object sender, EventArgs e)
        {
            BarraOpciones(btnActualidad);
            Abrir<pnAdmActualidad>();
        }

        private void frmAdminsPrincipal_Load(object sender, EventArgs e)
        {
            lblTitNombre.Text = cPerfil.nombre + " " + cPerfil.apellido;
            lblTitArea.Text = cPerfil.area;
            lblTitPuesto.Text = cPerfil.puesto;
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            BarraOpciones(btnPerfil);
            Abrir<pnAdmPerfil>();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            BarraOpciones(btnSolicitud);
            Abrir<pnAdmSolicitudes>();
        }

        private void btcerrars_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la sesión?", "Advertencía", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                frmLogin frmLogin = new frmLogin();
                cPerfil.id = "";
                cPerfil.nombre = "";
                cPerfil.apellido = "";
                cPerfil.area = "";
                cPerfil.puesto = "";
                this.Hide();
                frmLogin.Show();
            }
        }
    }
}

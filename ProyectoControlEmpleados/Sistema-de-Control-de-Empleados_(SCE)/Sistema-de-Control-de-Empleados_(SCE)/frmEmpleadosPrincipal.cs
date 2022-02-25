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
    public partial class frmEmpleadosPrincipal : Form
    {
        int ancho, alto;
        public frmEmpleadosPrincipal()
        {
            InitializeComponent();
            //Mostramos el Logo
            Icon Logo = new Icon("Imagenes/SCP_Logo.ico");
            this.Icon = Logo;
            ancho = this.Width;
            alto = this.Height;
            BarraTit();
            pnMostrar.Location = new Point(175, 103);
            pnMostrar.Size = new Size(865, 429);
            BarraOpciones(btnInicio);
            //Cargamos los Forms
            Abrir<pnEmpInicio>();
            Abrir<pnEmpPerfil>();
            Abrir<pnEmpSolicitud>();
        }
        //Esto muestra los diferentes Forms en el panel
        private void Abrir<F>() where F : Form, new()
        {
            Form form = pnMostrar.Controls.OfType<F>().FirstOrDefault();
            if(form != null)
            {
                //Si la instancia esta minimizada la dejamos en su estado normal
                if(form.WindowState == FormWindowState.Minimized)
                {
                    form.WindowState = FormWindowState.Normal;
                }
                //Si la instancia existe la  ponemos en primer plano
                form.BringToFront();
                return;
            }
            //Se abre el form
            form = new F();
            form.TopLevel = false;
            pnMostrar.Controls.Add(form);
            pnMostrar.Tag = form;
            form.Show();
        }
        private void BarraOpciones(Button btn)
        {
            foreach (Control boton in pnOpc.Controls)
            {
                if (boton is Button)
                {
                    if(boton == btnCerrarSesion)
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
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Advertencía", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            BarraOpciones(btnInicio);
            Abrir<pnEmpInicio>();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
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

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            BarraOpciones(btnPerfil);
            Abrir<pnEmpPerfil>();
        }

        private void frmEmpleadosPrincipal_Load(object sender, EventArgs e)
        {
            lblTitNombre.Text = cPerfil.nombre;
            lblTitArea.Text = cPerfil.area;
            lblTitPuesto.Text = cPerfil.puesto;
        }

        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            BarraOpciones(btnSolicitud);
            Abrir<pnEmpSolicitud>();
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Sistema_de_Control_de_Empleados__SCE_
{
    public partial class frmPantallaBienvenida : Form
    {
        int ancho = 0, alto = 0;
        cSolicitud so = new cSolicitud();
        public frmPantallaBienvenida()
        {
            InitializeComponent();
            //Le ponemos el Logo al Form
            Icon Logo = new Icon("Imagenes/SCP_Logo.ico");
            this.Icon = Logo;
            ancho = this.Width;
            alto = this.Height;
            pcbLogo.Image = new Bitmap("Imagenes/SCP_Logo.png");
            pcbLogo.Location = new Point(ancho - 106, 0);
            pcbUdb.Image = new Bitmap("Imagenes/UDB_Logo.png");
        }

        //Para poder mover la Barra de titulo
        int posiY = 0, posiX = 0;

        private void tmCarga_Tick(object sender, EventArgs e)
        {
            tmCarga.Stop();
            so.editarmasivo("Expirado", DateTime.Now);
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();
        }

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

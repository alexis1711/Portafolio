using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Prototipo_CS
{
    public partial class frm_Datos : Form
    {
        public frm_Datos()
        {
            InitializeComponent();
        }

        public frm_Datos(frm_General frm)
        {
            Form fd1 =  frm as Form;
            fd1.TopLevel = false;
            fd1.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fd1);
            this.PanelContenedor.Tag = fd1;
            fd1.Show();
        }

        //Abrir regiones en "+" para ver cada una

        #region Barra de titulo

        //Palabras reservadas de la libreria "using System.Runtime.InteropServices"
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Evento

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Opacidad
        int cont = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            if (this.Opacity < 1) this.Opacity += 0.05;
            cont += 1;

            if (cont == 100)
            {
                timer1.Stop();
              
                
            }
        }

        #endregion

        #region Controles de ventana

        private void icocerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void icominimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Abrir Forms

        private void Datos_Load(object sender, EventArgs e)
        {
            /*Opacidad*/
            this.Opacity = 0.0;
            timer1.Start();



            /*Para establecer coordenadas de los paneles que contienen
             el sub menu de guardar datos, reportes y registros*/

            btnguardardatos.Location = new Point(2, 68);
            HideSub();

            btnreporte.Location = new Point(2, 68);
            HideSub2();

            btnregistros.Location = new Point(2, 68);
            Hide3();
        }

        //frm_GuadarDatos

        private void btnguardardatos_Click(object sender, EventArgs e)
        {

            if (SubPanel.Visible == true)
            {
                SubPanel.Visible = false;
            }
            else
            {
                SubPanel.Visible = true;
            }
            btnguardardatos.Location = new Point(2, 68);
            SubPanel.Location = new Point(0, 127);

            if (SubPanel.Visible == false)
            {
                btnguardardatos.Location = new Point(2, 68);
            }

        }

        private void HideSub()
        {
            if (SubPanel.Visible == true)
            {
                SubPanel.Visible = false;
            }
        }

        //Para Abrir los diferentes forms de Guadar Datos

        public void General(object FormGuardar)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);

            Form fd1 = FormGuardar as Form;
            fd1.TopLevel = false;
            fd1.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fd1);
            this.PanelContenedor.Tag = fd1;
            fd1.Show();
        }

        private void btngeneral_Click(object sender, EventArgs e)
        {
            General(new frm_General());
            HideSub();
        }


        private void AbrirAccsTrans(object FormGuardar2)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);

            Form fd2 = FormGuardar2 as Form;
            fd2.TopLevel = false;
            fd2.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fd2);
            this.PanelContenedor.Tag = fd2;
            fd2.Show();
        }

        private void btnaccs_trans_Click(object sender, EventArgs e)
        {
            AbrirAccsTrans(new frm_AccsTrans());
            HideSub();
        }


        private void AbrirCirugiaMenor(object FormGuardar3)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);

            Form fd3 = FormGuardar3 as Form;
            fd3.TopLevel = false;
            fd3.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fd3);
            this.PanelContenedor.Tag = fd3;
            fd3.Show();
        }       
        
        private void btncirugia_menor_Click(object sender, EventArgs e)
        {
            AbrirCirugiaMenor(new frm_CirugiaMenor());
            HideSub();
        }

        private void AbrirActRegistros(object FormGuardar4)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);

            Form fd3 = FormGuardar4  as Form;
            fd3.TopLevel = false;
            fd3.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fd3);
            this.PanelContenedor.Tag = fd3;
            fd3.Show();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            AbrirActRegistros(new frm_ActRegistros());
            HideSub();
        }
     

        //frm_Reportes

        private void btnreporte_Click(object sender, EventArgs e)

        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
            btnreporte.Location = new Point(2, 68);
            panel1.Location = new Point(0, 127);

            if (panel1.Visible == false)
            {
                btnreporte.Location = new Point(2, 68);
            }

        }

        private void HideSub2()
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
        }

        //Para Abrir los diferentes forms de Reportes

        private void AbrirEmergencias(object FormAyuda)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);

            Form fa = FormAyuda as Form;
            fa.TopLevel = false;
            fa.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fa);
            this.PanelContenedor.Tag = fa;
            fa.Show();

        }

        private void btnemergencias_Click(object sender, EventArgs e)
        {
            AbrirEmergencias(new frm_emergencias());
            HideSub2();
        }

        private void AbrirAccidente(object FormAyuda)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);

            Form fa = FormAyuda as Form;
            fa.TopLevel = false;
            fa.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fa);
            this.PanelContenedor.Tag = fa;
            fa.Show();

        }

        private void btnaccidente_Click(object sender, EventArgs e)
        {
            AbrirAccidente(new frm_Accidentes());
            HideSub2();
        }
        

        private void AbrirCirugia(object FormAyuda)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);

            Form fa = FormAyuda as Form;
            fa.TopLevel = false;
            fa.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fa);
            this.PanelContenedor.Tag = fa;
            fa.Show();

        }

        private void btncirugia_Click(object sender, EventArgs e)
        {
            AbrirCirugia(new frm_Cirugia());
            HideSub2();
        }

        //frm_Reportes

        private void btnregistros_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
            btnregistros.Location = new Point(2, 68);
            panel2.Location = new Point(0, 127);

            if (panel2.Visible == false)
            {
                btnregistros.Location = new Point(2, 68);
            }

        }

        private void Hide3()
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }

        //Para Abrir los diferentes forms de Rgsitros

        private void AbrirEmpleados(object FormAyuda)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);

            Form fa = FormAyuda as Form;
            fa.TopLevel = false;
            fa.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fa);
            this.PanelContenedor.Tag = fa;
            fa.Show();

        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            AbrirEmpleados(new frm_Empleados());
            Hide3();
        }

        private void AbrirUnidades(object FormAyuda)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);

            Form fa = FormAyuda as Form;
            fa.TopLevel = false;
            fa.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fa);
            this.PanelContenedor.Tag = fa;
            fa.Show();

        }

        private void btnunidades_Click(object sender, EventArgs e)
        {
            AbrirUnidades(new frm_Unidades());
            Hide3();
        }
    

        // Abrir Form de Creditos

        private void AbrirCreditos(object FormCreditos)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);

            Form fc = FormCreditos as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fc);
            this.PanelContenedor.Tag = fc;
            fc.Show();
        }

        private void btncreditos_Click(object sender, EventArgs e)
        {
            AbrirCreditos(new frm_Creditos());
        }


        //Cerrar Sesión

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Buttons


        private void btnguardardatos_MouseEnter(object sender, EventArgs e)
        {
            btnguardardatos.BackColor = Color.DodgerBlue;
            
        }

        private void btnguardardatos_MouseLeave(object sender, EventArgs e)
        {
            btnguardardatos.BackColor = Color.MidnightBlue;
        }

        private void btncreditos_MouseEnter(object sender, EventArgs e)
        {
            btncreditos.BackColor = Color.DodgerBlue;
        }

        private void btncreditos_MouseLeave(object sender, EventArgs e)
        {
            btncreditos.BackColor = Color.MidnightBlue;
        }

        private void btncerrarsesion_MouseEnter(object sender, EventArgs e)
        {
            btncerrarsesion.BackColor = Color.DodgerBlue;
        }

        private void btncerrarsesion_MouseLeave(object sender, EventArgs e)
        {
            btncerrarsesion.BackColor = Color.MidnightBlue;
        }

        private void btnreporte_MouseEnter(object sender, EventArgs e)
        {
            btnreporte.BackColor = Color.DodgerBlue;
        }

        private void btnreporte_MouseLeave(object sender, EventArgs e)
        {
            btnreporte.BackColor = Color.MidnightBlue;
        }

        private void btnregistros_MouseEnter(object sender, EventArgs e)
        {
            btnregistros.BackColor = Color.DodgerBlue;
        }

        private void btnregistros_MouseLeave(object sender, EventArgs e)
        {
            btnregistros.BackColor = Color.MidnightBlue;
        }

        private void btngeneral_MouseEnter(object sender, EventArgs e)
        {
            btngeneral.BackColor = Color.DimGray;
        }

        private void btngeneral_MouseLeave(object sender, EventArgs e)
        {
            btngeneral.BackColor = Color.Black;
        }

        private void btnaccs_trans_MouseEnter(object sender, EventArgs e)
        {
            btnaccs_trans.BackColor = Color.DimGray;
        }

        private void btnaccs_trans_MouseLeave(object sender, EventArgs e)
        {
            btnaccs_trans.BackColor = Color.Black;
        }

        private void btncirugia_menor_MouseEnter(object sender, EventArgs e)
        {
            btncirugia_menor.BackColor = Color.DimGray;
        }

        private void btncirugia_menor_MouseLeave(object sender, EventArgs e)
        {
            btncirugia_menor.BackColor = Color.Black;
        }

        private void btnemergencias_MouseEnter(object sender, EventArgs e)
        {
            btnemergencias.BackColor = Color.DimGray;
        }

        private void btnemergencias_MouseLeave(object sender, EventArgs e)
        {
            btnemergencias.BackColor = Color.Black;
        }

        private void btnaccidente_MouseEnter(object sender, EventArgs e)
        {
            btnaccidente.BackColor = Color.DimGray;
        }

        private void btnaccidente_MouseLeave(object sender, EventArgs e)
        {
            btnaccidente.BackColor = Color.Black;
        }

        private void btncirugia_MouseEnter(object sender, EventArgs e)
        {
            btncirugia.BackColor = Color.DimGray;
        }

        private void btncirugia_MouseLeave(object sender, EventArgs e)
        {
            btncirugia.BackColor = Color.Black;
        }

        private void btnempleados_MouseEnter(object sender, EventArgs e)
        {
            btnempleados.BackColor = Color.DimGray;
        }

        private void btnempleados_MouseLeave(object sender, EventArgs e)
        {
            btnempleados.BackColor = Color.Black;
        }

        private void btnunidades_MouseEnter(object sender, EventArgs e)
        {
            btnunidades.BackColor = Color.DimGray;
        }

        private void btnunidades_MouseLeave(object sender, EventArgs e)
        {
            btnunidades.BackColor = Color.Black;
        }

        private void btnactualizar_MouseEnter(object sender, EventArgs e)
        {
            btnactualizar.BackColor = Color.DimGray;
        }

        private void btnactualizar_MouseLeave(object sender, EventArgs e)
        {
            btnactualizar.BackColor = Color.Black;
        }
    }

    #endregion


}

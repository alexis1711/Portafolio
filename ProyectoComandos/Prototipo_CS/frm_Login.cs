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

namespace Prototipo_CS
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            AcceptButton = btningresar;
        }

       
        //Abrir regiones en "+" para ver cada una

        #region Ver y ocultar Contraseña


        //Para la imagen ver y ocultar

        private void ver_Click(object sender, EventArgs e)
        {

            if (txtcontra.PasswordChar == '*')
            {
                txtcontra.PasswordChar = '\0';
            }
            else
            {
                txtcontra.PasswordChar = '*';
            }
        }

        #endregion

        #region Validar Campos
        private bool validarCampos()
        {
            
            bool validado = true;
            if (txtusuario.Text == "")
            {

                validado = false;

                errorProvider1.SetError(txtusuario, "Ingresar usuario");
            }

            if (txtcontra.Text == "")
            {

                validado = false;
                errorProvider1.SetError(txtcontra, "Ingresar contraseña");
            }

            

            return validado;
        }
      
        private void BorrarMesaje()
        {
            errorProvider1.SetError(txtusuario, "");
            errorProvider1.SetError(txtcontra, "");
        }

                               

        #endregion

        #region Eventos de los botones
        private void btningresar_Click(object sender, EventArgs e)
        {
            //Para Borrar ErrorProvider
            BorrarMesaje();
            //Si se cumple que todos los campos estan llenos
            if (validarCampos())
            {
                string texto = "Usuario: " + txtusuario.Text;
                frm_usuario abrir = new frm_usuario(texto);               
                abrir.Show();
                this.Hide();
               
            }

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        #endregion
    }
}

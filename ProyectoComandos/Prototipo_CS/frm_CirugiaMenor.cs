using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_CS
{
    public partial class frm_CirugiaMenor : Form
    {
        public frm_CirugiaMenor()
        {
            InitializeComponent();
        }

        private void txtNombre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNombre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtatendio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool validarCampos()
        {

            //variable que verificará si algo ha sido validado
            bool validado = true;


            if (rbtnM.Checked == false && rbtnF.Checked == false)
            {
                validado = false;
                errorProvider1.SetError(rbtnM, "Seleccione una opción");

                rbtnF.Checked = false;
                errorProvider1.SetError(rbtnF, "Seleccione una opción");
            }

            //Para que cuando el usuario seleccione una fecha en el futuro marque un error          

            DateTime fecha = dtppaciente.Value;
            int anios = System.DateTime.Now.Year - fecha.Year;
            if (anios < 0)
            {
                MessageBox.Show("La fecha ingresada es invalida");
                validado = false;
            }
            else if (anios == 0)
            {
                if (System.DateTime.Now.Subtract(fecha.AddYears(anios)).TotalDays > 0)
                {

                }
                else
                {
                    MessageBox.Show("La fecha ingresada es invalida");
                    validado = false;
                }
            }

            return validado;

        }

        //Para limpiar error
        private void BorrarMesaje()
        {
            errorProvider1.SetError(rbtnM, "");
            errorProvider1.SetError(rbtnF, "");           

        }

        //Limpiar Campos
        private void Limpiar()
        {           
            dtppaciente.CustomFormat = "";
            rbtnM.Checked = false;
            rbtnF.Checked = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //Para Borrar ErrorProvider
            BorrarMesaje();
            //Si se cumple que los campos estan llenos
            if (validarCampos())
            {
            }
        }

        // Limpiar datos

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            //Para borrar mensajes de ErrorProvider
            txtNombre1.Clear();
            txtNombre2.Clear();
            txtApellido1.Clear();
            txtApellido2.Clear();
            txtedad.Clear();
            txtdx.Clear();
            txtatendio.Clear();
            txtprocedimiento.Clear();
            rbtnF.Checked = false;
            rbtnM.Checked = false;

            BorrarMesaje();
            Limpiar();
        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {
            txtedad.MaxLength = 3;
            if (txtedad.Text.Length == 3)
            {
                MessageBox.Show("Limite de caracteres alcanzado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

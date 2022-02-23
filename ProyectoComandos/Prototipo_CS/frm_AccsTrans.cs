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
    public partial class frm_AccsTrans : Form
    {
        public frm_AccsTrans()
        {
            InitializeComponent();
        }

        #region Validar Campos

        //Edad
        private void txtEdadPaciente_KeyPress(object sender, KeyPressEventArgs e)
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

        //1re Nombre
        private void txtNombrePaciente1_KeyPress(object sender, KeyPressEventArgs e)
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

        //2do Nombre
        private void txtNombrePaciente2_KeyPress(object sender, KeyPressEventArgs e)
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

        //1re Apellido
        private void txtApellidoPaciente1_KeyPress(object sender, KeyPressEventArgs e)
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

        //2do Apellido
        private void txtApellidoPaciente2_KeyPress(object sender, KeyPressEventArgs e)
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

        //Jefe de brigada

        private void txtjefe_KeyPress(object sender, KeyPressEventArgs e)
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

        //Nombre Motorista
        private void txtmotorista_KeyPress(object sender, KeyPressEventArgs e)
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

        //Nombre Socorrista

        private void txtsocorrista_KeyPress(object sender, KeyPressEventArgs e)
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

        //Persona que reporto
        private void txtreporte_KeyPress(object sender, KeyPressEventArgs e)
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
            errorProvider1.SetError(cbxhos, "");

        }

        //Limpiar Campos
        private void Limpiar()
        {
            cbxhos.SelectedIndex = -1;
            dtppaciente.CustomFormat = "";
            rbtnM.Checked = false;
            rbtnF.Checked = false;
        }




        #endregion

        #region Limitar caracteres de txt

        private void txtEdadPaciente_TextChanged(object sender, EventArgs e)
        {
            txtEdadPaciente.MaxLength = 3;
            if (txtEdadPaciente.Text.Length == 3)
            {
                MessageBox.Show("Limite de caracteres alcanzado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion 

        private void btnguardar_Click(object sender, EventArgs e)
        {

            //Para Borrar ErrorProvider
            BorrarMesaje();
            //Si se cumple que los campos estan llenos
            if (validarCampos())
            {
            }
        }

        // Limpiar campos

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            //Para borrar mensajes de ErrorProvider
            txtNombrePaciente1.Clear();
            txtNombrePaciente2.Clear();
            txtApellidoPaciente1.Clear();
            txtApellidoPaciente2.Clear();
            txtEdadPaciente.Clear();
            rbtnF.Checked = false;
            rbtnM.Checked = false;
            cbxhos.SelectedIndex = -1;
            txtdiag.Clear();
            txtlugar.Clear();
            txtve.Clear();
            txtjefe.Clear();
            txtunidad.Clear();
            txtmotorista.Clear();
            txtsocorrista.Clear();
            txtreporte.Clear();
            txtobs.Clear();
            txtCorrelativo.Clear();

            BorrarMesaje();
            Limpiar();
        }

        private void frm_AccsTrans_Load(object sender, EventArgs e)
        {
            cbxhos.Items.Clear();
            cbxhos.Items.Add("Hospital de Diagnóstico");
            cbxhos.Items.Add("Hospital de la Mujer");
            cbxhos.Items.Add("Hospital Militar Central");
            cbxhos.Items.Add("Hospital Nacional de Niños Benjamin Bloom");
            cbxhos.Items.Add("Hospital Farela");
            cbxhos.Items.Add("Hospital de Diagnostico Col. Medica");
            cbxhos.Items.Add("Hospital Centro Ginecológico");
            cbxhos.Items.Add("Hospital Centro de Emergencias");
            cbxhos.Items.Add("Hospital Centro Pediátrico");
            cbxhos.Items.Add("Hospital Profamilia");
            cbxhos.Items.Add("Hospital Central");
            cbxhos.Items.Add("Hospital Medico Quirúrgico ISSS");
            cbxhos.Items.Add("Hospital Nacional Rosales");
            cbxhos.Items.Add("Hospital Bautista");
            cbxhos.Items.Add("ExHospital de Maternidad");
            cbxhos.Items.Add("Hospital 1ro de Mayo (ISSS)");
            cbxhos.Items.Add("Hospital Paravida");
            cbxhos.Items.Add("Hospital Milital Central");
            cbxhos.Items.Add("Unidad Médica San Jacinto ISSS");
            cbxhos.Items.Add("Hospital Milital Central");
        }

        
    }
}

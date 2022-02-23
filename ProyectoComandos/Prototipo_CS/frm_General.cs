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

namespace Prototipo_CS  //Si lees esto, animo guapo:v o guapa si eres Alexia:3
{
    public partial class frm_General : Form
    {

        //Abrir regiones en "+" para ver cada una 

        #region Initialize Component

        public frm_General()
        {
            InitializeComponent();

        }

        public frm_General(Paciente PacienteDGV)
        {
            InitializeComponent();

            txtCorrelativo.Text = PacienteDGV.CodigoPaciente;
            txtNombrePaciente1.Text = PacienteDGV.PrimerNombre;
            txtNombrePaciente2.Text = PacienteDGV.SegundoNombre;
            txtApellidoPaciente1.Text = PacienteDGV.PrimerApellido;
            txtApellidoPaciente2.Text = PacienteDGV.SegundoApellido;
            txtDirPaciente.Text = PacienteDGV.Direccion;
            //Genero
            txtEdadPaciente.Text = Convert.ToString(PacienteDGV.Edad);
            mtbTelefono.Text = PacienteDGV.Telefono;
            //NombreAcompañante
            txtparentesco.Text = PacienteDGV.Parentesco;
            txtdx.Text = PacienteDGV.Diagnostico;
        }

        #endregion

        #region Validar Campos


        //Nombre Paciente
        private void txtNombrePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condición para solo letras
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


        //Edad Paciente
        private void txtEdadPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
             //Condición para solo numeros          
            if(char.IsDigit(e.KeyChar)) 
            { 
                e.Handled = false; 
            } 
               
            else if(char.IsControl(e.KeyChar)) 
            { 
                e.Handled = false; 
            }                                    
            else 
            { 
               e.Handled = true; 
               MessageBox.Show("Solo se admiten datos numéricos","Error",MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            } 
        }

        //Nombre del contacto

        private void txtNombreContacto_KeyPress(object sender, KeyPressEventArgs e)
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

        //Relación del contacto
        private void txtRelacion_KeyPress(object sender, KeyPressEventArgs e)
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

        //1re Nombre de acompañante
        private void txtnombreA_KeyPress(object sender, KeyPressEventArgs e)
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

        //2do Nombre Acompañante
        private void txtnombreA2_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtapellidoA_KeyPress(object sender, KeyPressEventArgs e)
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

        //2do Apellido Acompañante
        private void txtApellidoA2_KeyPress(object sender, KeyPressEventArgs e)
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

        //Parentesco
        private void txtparentesco_KeyPress(object sender, KeyPressEventArgs e)
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

        //Reporte
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

        //Motorista
        private void txtApellidoContacto1_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtNombreContacto2_KeyPress(object sender, KeyPressEventArgs e)
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

        //Socorrista
        private void txtApellidoContacto2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtfc_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtfr_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtpa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtO_KeyPress(object sender, KeyPressEventArgs e)
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

        //Creamos un metodo que nos ayudara para las validaciones
        private bool validarCampos()
        {
            return ValidarTodo();
        }

       
        #endregion

        #region Métodos

        //Métodos para validar ErrorProvider

        private bool ValidarError()
        {
            bool validado = true;

            //Genero
            if (rbtnM.Checked == false && rbtnF.Checked == false && rbtngenegativo.Checked == false)
            { 
                validado = false;
                errorProvider1.SetError(rbtnM, "Seleccione una opción");
                errorProvider1.SetError(rbtnF, "Seleccione una opción");
                errorProvider1.SetError(rbtngenegativo, "Seleccione una opción");

            }

            //Categoria de Accidente
            if (rdbAccidente.Checked == false && rdbRescate.Checked == false
                && rdbIncendio.Checked == false && rdbFallecido.Checked == false && rdbLesion.Checked == false)
            {
                validado = false;
                errorProvider1.SetError(rdbFallecido, "Seleccione una opción");
                errorProvider1.SetError(rdbAccidente, "Seleccione una opción");
                errorProvider1.SetError(rdbIncendio, "Seleccione una opción");
                errorProvider1.SetError(rdbLesion, "Seleccione una opción");
                errorProvider1.SetError(rdbRescate, "Seleccione una opción");
                
            }

            //Tipo de Accidente
            if (cbxTipEm.SelectedIndex.Equals(-1))
            {
                validado = false;
                errorProvider1.SetError(cbxTipEm, "Selecciona un tipo");
            }

            //Hospital
            if (cbxhos.SelectedIndex.Equals(-1))
            {
                validado = false;
                errorProvider1.SetError(cbxhos, "Selecciona un hospital");
            }

            //Fecha
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

        private void Editar()
        {
            groupEmergencia.Enabled = false;
        }


        //Borra el ErrorProvider
        private void BorrarMensaje()
        {
            errorProvider1.SetError(rbtnM, "");
            errorProvider1.SetError(rbtnF, "");
            errorProvider1.SetError(cbxTipEm, "");
            errorProvider1.SetError(cbxhos, "");
            errorProvider1.SetError(rdbLesion, "");
            errorProvider1.SetError(rdbFallecido, "");
            errorProvider1.SetError(rdbAccidente, "");
            errorProvider1.SetError(rdbIncendio, "");
            errorProvider1.SetError(rdbRescate, "");         
            errorProvider1.SetError(rbtngenegativo, "");
        }

        private bool ValidarTodo()
        {
            bool validado;

            if (ValidarError())
                validado = true;
            else
                validado = false;

            return validado;
        }

        //Métodos Para Crear Clases
        private void Limpiar()
        {
            mtbHora.Clear();
            txtNombrePaciente1.Clear();
            txtNombrePaciente2.Clear();
            txtApellidoPaciente1.Clear();
            txtApellidoPaciente2.Clear();
            txtEdadPaciente.Clear();
            txtDirPaciente.Clear();
            txtPunRef.Clear();
            txtnombreA.Clear();
            txtnombreA2.Clear();
            txtapellidoA.Clear();
            txtApellidoA2.Clear();
            txtparentesco.Clear();
            mtbTelefono.Clear();
            txtfc.Clear();
            txtfr.Clear();
            txtpa.Clear();
            txtT.Clear();
            txtO.Clear();           
            mtbHoraLlegada.Clear();
            txtdx.Clear();
            txtObs.Clear();
            txtUnidad.Clear();
            txtJefeBrigada.Clear();
            txtMotorista.Clear();
            txtSocorrista.Clear();
            txtreporte.Clear();
            rdb911.Checked = false;
            rdbSem132.Checked = false;
            rdbParticular.Checked = false;
            rdbAccidente.Checked = false;
            rdbFallecido.Checked = false;
            rdbIncendio.Checked = false;
            rdbLesion.Checked = false;
            rdbRescate.Checked = false;
            cbxTipEm.SelectedIndex = -1;
            cbxhos.SelectedIndex = -1;
            dtppaciente.CustomFormat = "";
            rbtnM.Checked = false;
            rbtnF.Checked = false;
            txtCorrelativo.Clear();            
            rbtngenegativo.Checked = false;
        }

        private string GeneroPaciente()
        {
            string genero = "";

            if (rbtnM.Checked == true)
                genero = "Masculino";

            if (rbtnF.Checked == true)
                genero = "Femenino";

            return genero;
        }

        private string GenerarNombreAcompañante()
        {
            string NombreAcompañante = "";

            NombreAcompañante = txtnombreA.Text + " " + txtnombreA2.Text + " " + txtapellidoA.Text + " " + txtApellidoA2.Text;

            return NombreAcompañante;
        }

        private string GenerarTipoLlamada()
        {
            string TipoLlamada = "";

            if (rdb911.Checked == true)
                TipoLlamada = rdb911.Text;

            if (rdbSem132.Checked == true)
                TipoLlamada = rdbSem132.Text;

            if (rdbParticular.Checked == true)
                TipoLlamada = rdbParticular.Text;

            return TipoLlamada;
        }

        private int GenerarIndexIncidenteInt()
        {
            int Index;
            Index = cbxTipEm.SelectedIndex + 1;
            return Index;
        }

        private string GenerarIndexIncidenteString()
        {
            string Index;
            Index = Convert.ToString(GenerarIndexIncidenteInt());
            return Index;
        }

        private string GenerarCodigoIncidente()
        {
            string CodigoIncidente = "";
            int IndexIncidente = GenerarIndexIncidenteInt();

            if(rdbLesion.Checked == true)
                IndexIncidente += 0;
            
            if(rdbAccidente.Checked == true)
                IndexIncidente += 11;
            
            if(rdbRescate.Checked == true)
                IndexIncidente += 15;
            
            if(rdbIncendio.Checked == true)
                IndexIncidente += 23;
            
            if(rdbFallecido.Checked == true)
                IndexIncidente += 28;
            
            if (GenerarIndexIncidenteInt() <= 9)
                CodigoIncidente = "IN00" + GenerarIndexIncidenteString();
            else
                CodigoIncidente = "IN0" + GenerarIndexIncidenteString();

            return CodigoIncidente;
        }

        private string GenerarCodigoHospital()
        {
            string CodigoHospital = "";

            if (cbxhos.SelectedIndex < 9)
                CodigoHospital = "HOS0" + Convert.ToString(cbxhos.SelectedIndex + 1);
            else
                CodigoHospital = "HOS" + Convert.ToString(cbxhos.SelectedIndex + 1);

            return CodigoHospital;
        }

        private string GenerarDateTime()
        {
            string DateTime;

            DateTime = dtppaciente.Value.Month.ToString() + "/" + dtppaciente.Value.Day.ToString() + "/" + dtppaciente.Value.Year.ToString() + " " + mtbHora.Text;
            
            return DateTime;
        }

        private Paciente GenerarPaciente()
        {
            Paciente MiPaciente = new Paciente();

            MiPaciente.CodigoPaciente = txtCorrelativo.Text;
            MiPaciente.PrimerNombre = txtNombrePaciente1.Text;
            MiPaciente.SegundoNombre = txtNombrePaciente2.Text;
            MiPaciente.PrimerApellido = txtApellidoPaciente1.Text;
            MiPaciente.SegundoApellido = txtApellidoPaciente2.Text;
            MiPaciente.Direccion = txtDirPaciente.Text;
            MiPaciente.Genero = GeneroPaciente();
            MiPaciente.Edad = int.Parse(txtEdadPaciente.Text);
            MiPaciente.Telefono = mtbTelefono.Text;
            MiPaciente.NombreAcompañante = GenerarNombreAcompañante();
            MiPaciente.Parentesco = txtparentesco.Text;
            MiPaciente.CodigoHospital= GenerarCodigoHospital();
            MiPaciente.Diagnostico = txtdx.Text;

            return MiPaciente;
        }

    /*    private Emergencia GenerarEmergencia()
        {
            Emergencia MiEmergencia = new Emergencia();

            MiEmergencia.CodigoCategoria = GenerarCodigoIncidente();
            MiEmergencia.Fecha = Convert.ToString(dtppaciente.Value.Date) + " " +  mtbHora.Text;
            MiEmergencia.CodigoPaciente = txtCorrelativo.Text;
            MiEmergencia.CodigoEmergencia = txtCorrelativo.Text;
            MiEmergencia.TipoLlamada = GenerarTipoLlamada();
            MiEmergencia.FrecuenciaCardiaca = int.Parse(txtfc.Text);
            MiEmergencia.FrecuenciaRespiratoria = int.Parse(txtfr.Text);
            MiEmergencia.PresionArterial = int.Parse(txtpa.Text);
            MiEmergencia.Temperatura = Convert.ToDouble(txtT.Text);
            MiEmergencia.SaturacionOxigeno = Convert.ToDouble(txtO.Text);
            MiEmergencia.LugarIncidente = txtPunRef.Text;
            MiEmergencia.Empleado = txtreporte.Text;
            MiEmergencia.CodigoUnidad = txtUnidad.Text;
            MiEmergencia.Motorista = txtMotorista.Text;
            MiEmergencia.HoraLlegada = mtbHoraLlegada.Text;
            MiEmergencia.Observaciones = txtObs.Text;
               
            return MiEmergencia;
        }*/

        #endregion

        #region Eventos de los botones

        
        private void btnguardar1_Click(object sender, EventArgs e)
        {
            //Si se cumple que los campos estan llenos
            if (validarCampos()) 
            {
                /*Paciente MiPaciente = new Paciente();
                Emergencia MiEmergencia = new Emergencia();

                MiPaciente = GenerarPaciente();
                MiEmergencia = GenerarEmergencia();
                
                try
                {
                    string insertpacientes;
                    insertpacientes = "INSERT INTO Pacientes(CodigoPaciente, ";
                    insertpacientes += "PrimerNombrePaciente, SegundoNombrePaciente, PrimerApellidoPaciente, SegundoApellidoPaciente, ";
                    insertpacientes += "Direccion, Genero, Edad, Telefono, NombreAcompañante, Parentesco, CodHospital, Diagnosti)";
                    insertpacientes += "VALUES(@CodigoPaciente, @PrimerNombrePaciente, @SegundoNombrePaciente, @PrimerApellidoPaciente, @SegundoApellidoPaciente, ";
                    insertpacientes += "@Direccion, @Genero, @Edad, @Telefono, @NombreAcompañante, @Parentesco, @CodHospital, @Diagnostico) ";
                    insertpacientes += "INSERT INTO Emergencias(Fecha, CodigoPaciente, CodCategoria, CodEmergencia, TipoLlamada, FrecuenciaCardiaca, FrecuenciaRespiratoria, ";
                    insertpacientes += "PresionArterial, Temperatura, SaturacionOxige, LugarIncidente, Empleado, CodigoUnidad, Motorista, HoraLlegada, Observaciones) ";
                    insertpacientes += "VALUES(@Fecha, @CodigoPaciente2, @CodCategoria, @CodEmergencia, @TipoLlamada, @FrecuenciaCardiaca, @FrecuenciaRespiratoria, @PresionArterial, ";
                    insertpacientes += "@Temperatura, @SaturacionOxige, @LugarIncidente, @Empleado, @CodigoUnidad, @Motorista, @HoraLlegada, @Observaciones)";
                    insert1 = new SqlCommand(insertpacientes, conn);

                    //Insertar Tabla Pacientes
                    insert1.Parameters.Add(new SqlParameter("@CodigoPaciente", SqlDbType.VarChar));
                    insert1.Parameters["@CodigoPaciente"].Value = MiPaciente.CodigoPaciente;
                    insert1.Parameters.Add(new SqlParameter("@PrimerNombrePaciente", SqlDbType.VarChar));
                    insert1.Parameters["@PrimerNombrePaciente"].Value = MiPaciente.PrimerNombre;
                    insert1.Parameters.Add(new SqlParameter("@SegundoNombrePaciente", SqlDbType.VarChar));
                    insert1.Parameters["@SegundoNombrePaciente"].Value = MiPaciente.SegundoNombre;
                    insert1.Parameters.Add(new SqlParameter("@PrimerApellidoPaciente", SqlDbType.VarChar));
                    insert1.Parameters["@PrimerApellidoPaciente"].Value = MiPaciente.PrimerApellido;
                    insert1.Parameters.Add(new SqlParameter("@SegundoApellidoPaciente", SqlDbType.VarChar));
                    insert1.Parameters["@SegundoApellidoPaciente"].Value = MiPaciente.SegundoApellido;
                    insert1.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar));
                    insert1.Parameters["@Direccion"].Value = MiPaciente.Direccion;
                    insert1.Parameters.Add(new SqlParameter("@Genero", SqlDbType.VarChar));
                    insert1.Parameters["@Genero"].Value = MiPaciente.Genero;
                    insert1.Parameters.Add(new SqlParameter("@Edad", SqlDbType.Int));
                    insert1.Parameters["@Edad"].Value = MiPaciente.Edad;
                    insert1.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar));
                    insert1.Parameters["@Telefono"].Value = MiPaciente.Telefono;
                    insert1.Parameters.Add(new SqlParameter("@NombreAcompañante", SqlDbType.VarChar));
                    insert1.Parameters["@NombreAcompañante"].Value = MiPaciente.NombreAcompañante;
                    insert1.Parameters.Add(new SqlParameter("@Parentesco", SqlDbType.VarChar));
                    insert1.Parameters["@Parentesco"].Value = MiPaciente.Parentesco;
                    insert1.Parameters.Add(new SqlParameter("@CodHospital", SqlDbType.VarChar));
                    insert1.Parameters["@CodHospital"].Value = MiPaciente.CodigoHospital;
                    insert1.Parameters.Add(new SqlParameter("@Diagnostico", SqlDbType.VarChar));
                    insert1.Parameters["@Diagnostico"].Value = MiPaciente.Diagnostico;

                    //Insertar Tabla Emergencias
                    insert1.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.Date));
                    insert1.Parameters["@Fecha"].Value = MiEmergencia.Fecha;
                    insert1.Parameters.Add(new SqlParameter("@CodigoPaciente2", SqlDbType.VarChar));
                    insert1.Parameters["@CodigoPaciente2"].Value = MiEmergencia.CodigoPaciente;
                    insert1.Parameters.Add(new SqlParameter("@CodCategoria", SqlDbType.VarChar));
                    insert1.Parameters["@CodCategoria"].Value = MiEmergencia.CodigoCategoria;
                    insert1.Parameters.Add(new SqlParameter("@CodEmergencia", SqlDbType.VarChar));
                    insert1.Parameters["@CodEmergencia"].Value = MiEmergencia.CodigoEmergencia;
                    insert1.Parameters.Add(new SqlParameter("@TipoLlamada", SqlDbType.VarChar));
                    insert1.Parameters["@TipoLlamada"].Value = MiEmergencia.TipoLlamada;
                    insert1.Parameters.Add(new SqlParameter("@FrecuenciaCardiaca", SqlDbType.Int));
                    insert1.Parameters["@FrecuenciaCardiaca"].Value = MiEmergencia.FrecuenciaCardiaca;
                    insert1.Parameters.Add(new SqlParameter("@FrecuenciaRespiratoria", SqlDbType.Int));
                    insert1.Parameters["@FrecuenciaRespiratoria"].Value = MiEmergencia.FrecuenciaRespiratoria;
                    insert1.Parameters.Add(new SqlParameter("@PresionArterial", SqlDbType.Int));
                    insert1.Parameters["@PresionArterial"].Value = MiEmergencia.PresionArterial;
                    insert1.Parameters.Add(new SqlParameter("@Temperatura", SqlDbType.Float));
                    insert1.Parameters["@Temperatura"].Value = MiEmergencia.Temperatura;
                    insert1.Parameters.Add(new SqlParameter("@SaturacionOxige", SqlDbType.Float));
                    insert1.Parameters["@SaturacionOxige"].Value = MiEmergencia.SaturacionOxigeno;
                    insert1.Parameters.Add(new SqlParameter("@LugarIncidente", SqlDbType.VarChar));
                    insert1.Parameters["@LugarIncidente"].Value = MiEmergencia.LugarIncidente;
                    insert1.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.VarChar));
                    insert1.Parameters["@Empleado"].Value = MiEmergencia.Empleado;
                    insert1.Parameters.Add(new SqlParameter("@CodigoUnidad", SqlDbType.VarChar));
                    insert1.Parameters["@CodigoUnidad"].Value = MiEmergencia.CodigoUnidad;
                    insert1.Parameters.Add(new SqlParameter("@Motorista", SqlDbType.VarChar));
                    insert1.Parameters["@Motorista"].Value = MiEmergencia.Motorista;
                    insert1.Parameters.Add(new SqlParameter("@HoraLlegada", SqlDbType.Time));
                    insert1.Parameters["@HoraLlegada"].Value = MiEmergencia.HoraLlegada;
                    insert1.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar));
                    insert1.Parameters["@Observaciones"].Value = MiEmergencia.Observaciones;

                    insert1.ExecuteNonQuery();
                    Limpiar();
                    MessageBox.Show("Registro agregado");
                    conn.Close();*/
               
            }     
        }

        //Limpiar Campos
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            //Para borrar mensajes de ErrorProvider
            BorrarMensaje();
            Limpiar();
        }

        #endregion

        #region ComboBox

        private void InfPaciente_Load(object sender, EventArgs e)
        {
            //Agregamos Items al combo de Hospital

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
            cbxhos.Items.Add("Negativo");
        }

        private void rdbLesion_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLesion.Checked == true)
            {
                cbxTipEm.Items.Clear();
                cbxTipEm.Items.Add("Arma de Fuego");
                cbxTipEm.Items.Add("Arma Contundente");
                cbxTipEm.Items.Add("Accidente de Tránsito");
                cbxTipEm.Items.Add("Arma Blanca");
                cbxTipEm.Items.Add("Quemado por Polvora");
                cbxTipEm.Items.Add("Quemado por Otras Causas");
                cbxTipEm.Items.Add("Politraumatismo");
                cbxTipEm.Items.Add("Fracturas");
                cbxTipEm.Items.Add("Intoxicaciones");
                cbxTipEm.Items.Add("Picaduras");
                cbxTipEm.Items.Add("Mordedura");
                cbxTipEm.Items.Add("Otro");
            }
        }

        private void rdbAccidente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAccidente.Checked == true)
            {
                cbxTipEm.Items.Clear();
                cbxTipEm.Items.Add("Terrestre");
                cbxTipEm.Items.Add("Acuatico");
                cbxTipEm.Items.Add("Aéreos");
                cbxTipEm.Items.Add("Laborales");
                cbxTipEm.Items.Add("Otro");
            }
        }

        private void rdbRescate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRescate.Checked == true)
            {
                cbxTipEm.Items.Clear();
                cbxTipEm.Items.Add("Simples");
                cbxTipEm.Items.Add("Profundos");
                cbxTipEm.Items.Add("Aéreos");
                cbxTipEm.Items.Add("Urbanos");
                cbxTipEm.Items.Add("Montaña");
                cbxTipEm.Items.Add("Vehículo");
                cbxTipEm.Items.Add("Recuperación de Cadaveres");
                cbxTipEm.Items.Add("Otro");
            }
        }

        private void rdbIncendio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIncendio.Checked == true)
            {
                cbxTipEm.Items.Clear();
                cbxTipEm.Items.Add("Forestales");
                cbxTipEm.Items.Add("Estructural");
                cbxTipEm.Items.Add("Vehículo");
                cbxTipEm.Items.Add("Maleza Seca");
                cbxTipEm.Items.Add("Tambo de Gas");
                cbxTipEm.Items.Add("Otro");
            }
        }

        private void rdbFallecido_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFallecido.Checked == true)
            {
                cbxTipEm.Items.Clear();
                cbxTipEm.Items.Add("Asfixia por Inmersión");
                cbxTipEm.Items.Add("Accidente de Tránsito");
                cbxTipEm.Items.Add("Arma de Fuego");
                cbxTipEm.Items.Add("Arma Blanca");
                cbxTipEm.Items.Add("Otras Causas");
                cbxTipEm.Items.Add("Otro");
            }
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

        private void txtfc_TextChanged(object sender, EventArgs e)
        {
            txtfc.MaxLength = 3;
            if (txtfc.Text.Length == 3)
            {
                MessageBox.Show("Limite de caracteres alcanzado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtfr_TextChanged(object sender, EventArgs e)
        {
            txtfr.MaxLength = 3;
            if (txtfr.Text.Length == 3)
            {
                MessageBox.Show("Limite de caracteres alcanzado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtpa_TextChanged(object sender, EventArgs e)
        {
            txtpa.MaxLength = 3;
            if (txtpa.Text.Length == 3)
            {
                MessageBox.Show("Limite de caracteres alcanzado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtT_TextChanged(object sender, EventArgs e)
        {
            txtT.MaxLength = 3;
            if (txtT.Text.Length == 3)
            {
                MessageBox.Show("Limite de caracteres alcanzado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtO_TextChanged(object sender, EventArgs e)
        {
            txtO.MaxLength = 3;
            if (txtO.Text.Length == 3)
            {
                MessageBox.Show("Limite de caracteres alcanzado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        #endregion

        #region Otros
        private void ReporteNegativo()
        {
            txtNombrePaciente1.Text = "Negativo";
            txtNombrePaciente2.Text = "Negativo";
            txtApellidoPaciente1.Text = "Negativo";
            txtApellidoPaciente2.Text = "Negativo";
            txtEdadPaciente.Text = "00";
            txtDirPaciente.Text = "Negativo";
            txtPunRef.Text = "Negativo";
            txtnombreA.Text = "Negativo";
            txtnombreA2.Text = "Negativo";
            txtapellidoA.Text = "Negativo";
            txtApellidoA2.Text = "Negativo";
            txtparentesco.Text = "Negativo";
            mtbTelefono.Text = "00000000";           
            rbtngenegativo.Checked = true;
        }

        
        private void btnegativo_Click(object sender, EventArgs e)
        {
            ReporteNegativo();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        #endregion
    }
}

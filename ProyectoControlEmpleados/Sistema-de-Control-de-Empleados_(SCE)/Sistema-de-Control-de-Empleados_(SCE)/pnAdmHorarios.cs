using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
//Clases no utilizadas
/*
 * using System.ComponentModel;
 * using System.Drawing;
 * using System.Text;
 * using System.Threading.Tasks;
 * using System.Data.Sql;
 * using System.Data.OleDb;
 * using System.Drawing.Printing;
 * using System.Linq;
 */

namespace Sistema_de_Control_de_Empleados__SCE_
{
    public partial class pnAdmHorarios : Form
    {
        Queue<cHorarios> horarios = new Queue<cHorarios>();
        cHorarios ho = new cHorarios();
        cConexion c = new cConexion();
        DataTable dbdataset;

        public pnAdmHorarios()
        {
            InitializeComponent();
            ActualizarGrid();
            Limpiar();
        }

        public void ActualizarGrid()
        {
            ho.mostrare(dgvEmpleados);
            ho.mostrarh(dgvHorario);
        }

        private void Limpiar()
        {
            foreach (Control con in Controls)
            {
                if (con is ComboBox)
                {
                    if (((ComboBox)con).Items.Count != 0)
                        ((ComboBox)con).SelectedIndex = 0;
                }
                if (con is TextBox)
                {
                    ((TextBox)con).Clear();
                }
                if (con is CheckBox)
                {
                    ((CheckBox)con).Checked = false;
                }
                if (con is DateTimePicker)
                {
                    ((DateTimePicker)con).Value = DateTime.Now;
                }
            }
            dtpInicial.Format = DateTimePickerFormat.Custom;
            dtpFin.Format = DateTimePickerFormat.Custom;
            dtpInicial.CustomFormat = "HH:mm:ss";
            dtpFin.CustomFormat = "HH:mm:ss";
            dtpFin.Value.AddHours(1);
            nupCaja.Value = 0;
            btnEliminar.Text = "Eliminar ultimo dato en cola";
            txtNombre.Focus();
        }

        private void btnguardarho_Click(object sender, EventArgs e)
        {
            DateTime FechaFin = dtpInicial.Value.AddHours(1);
            try
            {
                if (!string.IsNullOrWhiteSpace(txtIdHorario.Text))
                {
                    MessageBox.Show("Tiene un Horario seleccionado, por favor limpie los datos para continuar", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtIdEmpleado.Text))
                {
                    MessageBox.Show("Seleccione un empleado, para asignarle el horario", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmbDia.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione el Día", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(dtpInicial.Text) || string.IsNullOrWhiteSpace(dtpFin.Text))
                {
                    MessageBox.Show("Hora Inicial/Final incorrecta", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (nupCaja.Value <= 0)
                {
                    MessageBox.Show("Seleccione una Caja", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dtpFin.Value < FechaFin)
                {
                    MessageBox.Show("El rango de Fechas no es correcto (Debe estar min. en un rango de 1 hora)", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(!ho.validarguard(cmbDia.Text, chbEspecial,txtIdEmpleado.Text))
                {
                    if (MessageBox.Show("¿Desea guardar el registro?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        ho.ID_empleado = txtIdEmpleado.Text;
                        ho.Dia = Convert.ToString(cmbDia.Text);
                        ho.Hentrada = DateTime.Parse(dtpInicial.Text);
                        ho.Hsalida = DateTime.Parse(dtpFin.Text);
                        ho.Caja = Convert.ToInt32(nupCaja.Value);
                        if (chbEspecial.Checked == true)
                            ho.Especial = true;
                        else
                            ho.Especial = false;
                        ho.Insertar(horarios, ho);
                        ho.mostrarh(dgvHorario);
                        ActualizarGrid();
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DateTime FechaFin = dtpInicial.Value.AddHours(1);
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdEmpleado.Text))
                {
                    MessageBox.Show("Seleccione un empleado, para asignarle el horario", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmbDia.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione el Día", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(dtpInicial.Text) || string.IsNullOrWhiteSpace(dtpFin.Text))
                {
                    MessageBox.Show("Hora Inicial/Final incorrecta", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (nupCaja.Value <= 0)
                {
                    MessageBox.Show("Seleccione una Caja", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dtpFin.Value < FechaFin)
                {
                    MessageBox.Show("El rango de Fechas no es correcto (Debe estar min. en un rango de 1 hora)", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!ho.validarmodifi(cmbDia.Text, chbEspecial, txtIdEmpleado.Text, Convert.ToInt32(txtIdHorario.Text)))
                {
                    if (MessageBox.Show("¿Desea modificar el registro?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        bool esp = chbEspecial.Checked;
                        ho.editar(txtIdHorario.Text, Convert.ToString(cmbDia.Text), dtpInicial.Value, dtpFin.Value, esp, Convert.ToInt32(nupCaja.Value));
                        Limpiar();
                        ActualizarGrid();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden editar los datos " + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (horarios.Count != 0 && btnEliminar.Text == "Eliminar ultimo dato en cola")
                {
                    if (MessageBox.Show("Solo se eliminara el ultimo dato de la cola ¿Desea eliminarlo?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        ho = horarios.Dequeue();
                        txtIdEmpleado.Text = ho.ID_empleado;
                        txtIdHorario.Text = ho.ID_horario.ToString();
                        cmbDia.Text = ho.Dia.ToString();
                        dtpInicial.Value = ho.Hentrada;
                        dtpFin.Value = ho.Hsalida;
                        nupCaja.Value = ho.Caja;
                        ho.eliminar();
                        Limpiar();
                        ActualizarGrid();
                    }
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtIdEmpleado.Text) && btnEliminar.Text == "Eliminar ultimo dato en cola")
                    {
                        MessageBox.Show("No existen horarios en la cola, asi que no ha seleccionado ningún registro", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (btnEliminar.Text == "Desactivar Registro")
                    {
                        if (MessageBox.Show("No ha seleccionado un dato de la cola, ¿Desea desactivar el registro seleccionado?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            ho.ID_horario = Convert.ToInt32(txtIdHorario.Text);
                            ho.desactivar(false);
                            MessageBox.Show("Registro Desactivado...", "Sistema Control de Empleados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            Limpiar();
                            ActualizarGrid();
                        }
                    }
                    else if (btnEliminar.Text == "Activar Registro")
                    {
                        if (MessageBox.Show("No ha seleccionado un dato de la cola, ¿Desea activar el registro seleccionado?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            ho.ID_horario = Convert.ToInt32(txtIdHorario.Text);
                            ho.desactivar(true);
                            MessageBox.Show("Registro Activado...", "Sistema Control de Empleados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            Limpiar();
                            ActualizarGrid();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarEmpl_TextChanged(object sender, EventArgs e)
        {
            cHorarios ca = new cHorarios();
            c.ABRICONEXION();
            SqlCommand cmdbase = new SqlCommand("SELECT id_empleado,nombre from empleados", c.conexion);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdbase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dgvEmpleados.DataSource = bsource;
                sda.Update(dbdataset);
                //
                DataView dv = new DataView(dbdataset);
                dv.RowFilter = string.Format("id_empleado like '%{0}%' or nombre like '%{0}%'", txtBuscarEmpl.Text);
                dgvEmpleados.DataSource = dv;
                c.CERRARCONEXION();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarHorario_TextChanged(object sender, EventArgs e)
        {
            c.ABRICONEXION();
            SqlCommand cmdbase = new SqlCommand("SELECT Empleados.id_empleado,id_horario,dia,hora_inicial,hora_final,Horarios_Empleados.estado,especial,caja,Nombre from Horarios_Empleados inner join Empleados on Horarios_Empleados.id_empleado = Empleados.id_empleado", c.conexion);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdbase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dgvHorario.DataSource = bsource;
                sda.Update(dbdataset);
                //
                DataView dv = new DataView(dbdataset);
                dv.RowFilter = string.Format("id_empleado like '%{0}%' or nombre like '%{0}%' or dia like '%{0}%'  ", txtBuscarHorario.Text);
                dgvHorario.DataSource = dv;
                c.CERRARCONEXION();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnAdmHorarios_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
            Limpiar();
            FormatoGridEmpleado();
            FormatoGridHorario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
            Limpiar();
        }

        private void FormatoGridHorario()
        {
            //Renombro las columnas del dgv como quiera
            dgvHorario.Columns[0].Visible = false;
            dgvHorario.Columns[1].Visible = false;
            dgvHorario.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHorario.Columns[2].HeaderText = "Nombre Empleado";
            dgvHorario.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHorario.Columns[3].HeaderText = "Día";
            dgvHorario.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHorario.Columns[4].HeaderText = "Hora de Entrada";
            dgvHorario.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHorario.Columns[5].HeaderText = "Hora de Salida";
            dgvHorario.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHorario.Columns[6].HeaderText = "Fecha Especial";
            dgvHorario.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHorario.Columns[7].HeaderText = "Estado";
            dgvHorario.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHorario.Columns[8].HeaderText = "Caja";
        }

        private void dgvHorario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdEmpleado.Text = dgvHorario.CurrentRow.Cells["id_empleado"].Value.ToString();
                txtIdHorario.Text = dgvHorario.CurrentRow.Cells["id_horario"].Value.ToString();
                txtNombre.Text = dgvHorario.CurrentRow.Cells["Nombre"].Value.ToString();
                cmbDia.Text = dgvHorario.CurrentRow.Cells["Dia"].Value.ToString();
                dtpInicial.Text = dgvHorario.CurrentRow.Cells["hora_inicial"].Value.ToString();
                dtpFin.Text = dgvHorario.CurrentRow.Cells["hora_final"].Value.ToString();
                bool esp = Convert.ToBoolean(dgvHorario.CurrentRow.Cells["especial"].Value);
                if (esp)
                    chbEspecial.Checked = true;
                else
                    chbEspecial.Checked = false;
                nupCaja.Value = Convert.ToInt32(dgvHorario.CurrentRow.Cells["caja"].Value);
                bool est = Convert.ToBoolean(dgvHorario.CurrentRow.Cells["estado"].Value);
                if (est)
                    btnEliminar.Text = "Desactivar Registro";
                else
                    btnEliminar.Text = "Activar Registro";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void FormatoGridEmpleado()
        {
            if (dgvHorario.DataSource != null)
            {
                //Renombro las columnas del dgv como quiera
                dgvEmpleados.Columns[0].Visible = false;
                dgvEmpleados.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvEmpleados.Columns[1].HeaderText = "Nombre Completo del Empleado";
            }
        }

      
        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdEmpleado.Text = dgvEmpleados.CurrentRow.Cells["id_empleado"].Value.ToString();
                txtNombre.Text = dgvEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
    }
}


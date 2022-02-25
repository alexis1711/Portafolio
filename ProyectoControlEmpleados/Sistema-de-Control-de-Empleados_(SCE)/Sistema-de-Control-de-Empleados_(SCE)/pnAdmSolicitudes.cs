using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
//Clases no utilizadas
/*
 * using System.ComponentModel;
 * using System.Drawing;
 * using System.Linq;
 * using System.Text;
 * using System.Threading.Tasks;
 * using System.Data.Sql;
 * using System.Data.OleDb;
 * using System.Drawing.Printing;
 */

namespace Sistema_de_Control_de_Empleados__SCE_
{
    public partial class pnAdmSolicitudes : Form
    {
        Queue<cSolicitud> solicitudesadm = new Queue<cSolicitud>();
        cSolicitud so = new cSolicitud();
        DataTable dbdataset;
        string accion = "";
        public pnAdmSolicitudes()
        {
            InitializeComponent();
            Limpiar();
        }

        private void pnAdmSolicitudes_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
            FormatoGrid();
            Limpiar();
            lblArea.Text = cPerfil.area;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
            Limpiar();
        }

        private void ActualizarGrid()
        {
            //Actualiza el Grid
            dgvSolicitudes.DataSource = so.mostrar();
        }

        private void FormatoGrid()
        {
            //Renombro las columnas del dgv como quiera
            dgvSolicitudes.Columns[0].Visible = false;
            dgvSolicitudes.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSolicitudes.Columns[1].HeaderText = "Empleado";
            dgvSolicitudes.Columns[2].Visible = false;
            dgvSolicitudes.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSolicitudes.Columns[3].HeaderText = "Fecha Solicitud";
            dgvSolicitudes.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSolicitudes.Columns[4].HeaderText = "Administrador - Resolución";
            dgvSolicitudes.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSolicitudes.Columns[5].HeaderText = "Resolución";
            dgvSolicitudes.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSolicitudes.Columns[6].HeaderText = "Fecha Resolución";           
        }

        private void Limpiar()
        {
            foreach (Control con in Controls)
            {
                if (con is TextBox)
                {
                    ((TextBox)con).Clear();
                }
            }
            dtpFecha.Value = DateTime.Now;
            txtEmpleado.Focus();
            txtEmpleado.ReadOnly = true;
            txtMotivo.ReadOnly = true;
            //Para saber si ya alguien acepto/rechazo la solicitud
            accion = "";
            btnAceptar.Enabled = true;
            btnRechazar.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdSolicitud.Text))
                {
                    MessageBox.Show("Haga doble click en la Solicitud que desea verificar", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("¿Desea aceptar la solicitud?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtIdSolicitud.Text);
                    so.editar(cPerfil.id, "Aceptado", DateTime.Now, id);
                    solicitudesadm.Enqueue(so);
                    MessageBox.Show("Solicitud Aceptada...", "Sistema Control de Empleados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ActualizarGrid();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron aceptar los datos: " + ex.Message);
            }
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdSolicitud.Text))
                {
                    MessageBox.Show("Haga doble click en la Solicitud que desea verificar", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("¿Desea rechazar la solicitud?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtIdSolicitud.Text);
                    so.editar(cPerfil.id, "Rechazado", DateTime.Now, id);
                    solicitudesadm.Enqueue(so);
                    MessageBox.Show("Solicitud Rechazada...", "Sistema Control de Empleados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ActualizarGrid();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron rechazar los datos: " + ex.Message);
            }
        }

        private void txtBuscarSolicitud_TextChanged(object sender, EventArgs e)
        {
            so.ABRICONEXION();
            string cadena = "SELECT S.id_solicitud, (E.nombre + ' ' + E.apellido) AS Empl, S.motivo, CONVERT(Date, S.fecha_pedido) AS fecha_pedido, (A.nombre + ' ' + A.apellido) AS Admin, S.accion, CONVERT(Date, S.fecha_accion) AS fecha_accion " +
                        "FROM Solicitudes S INNER JOIN Empleados E ON S.id_empleado = E.id_empleado " +
                        "FULL JOIN Administradores A ON A.id_admin = S.id_admin " +
                        "WHERE E.id_area = (SELECT id_area FROM Administradores WHERE id_admin = '" + cPerfil.id + "') " +
                        "ORDER BY fecha_accion ASC";
            SqlCommand cmdbase = new SqlCommand(cadena, so.conexion);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdbase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dgvSolicitudes.DataSource = bsource;
                sda.Update(dbdataset);
                //
                DataView dv = new DataView(dbdataset);
                dv.RowFilter = string.Format("Empl like '%{0}%' or  Admin like '%{0}%' or  accion like '%{0}%'", txtBuscarSolicitud.Text);
                dgvSolicitudes.DataSource = dv;
                so.CERRARCONEXION();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSolicitudes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdSolicitud.Text = dgvSolicitudes.CurrentRow.Cells["id_solicitud"].Value.ToString();
                txtEmpleado.Text = dgvSolicitudes.CurrentRow.Cells["Empl"].Value.ToString();
                txtMotivo.Text = dgvSolicitudes.CurrentRow.Cells["motivo"].Value.ToString();
                dtpFecha.Value = DateTime.Parse(dgvSolicitudes.CurrentRow.Cells["fecha_pedido"].Value.ToString());
                accion = dgvSolicitudes.CurrentRow.Cells["accion"].Value.ToString();
                if (accion == "")
                {
                    btnAceptar.Enabled = true;
                    btnRechazar.Enabled = true;
                }
                else
                {
                    btnAceptar.Enabled = false;
                    btnRechazar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

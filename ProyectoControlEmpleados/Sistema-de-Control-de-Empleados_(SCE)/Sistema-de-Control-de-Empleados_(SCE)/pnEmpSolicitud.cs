using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
//Clases no utilizadas
/*
 *using System.ComponentModel;
 *using System.Drawing;
 * using System.Linq;
 * using System.Text;
 * using System.Threading.Tasks;
 * using System.Data.Sql;
 * using System.Data.OleDb;
 * using System.Drawing.Printing;
 */

namespace Sistema_de_Control_de_Empleados__SCE_
{
    public partial class pnEmpSolicitud : Form
    {
        Queue<cSolicitud> soli = new Queue<cSolicitud>();
        cSolicitud so = new cSolicitud();
        DataTable dbdataset;
        DateTime FechaVali = DateTime.Now.AddDays(1);
        public pnEmpSolicitud()
        {
            InitializeComponent();
            ActualizarGrid();
            Limpiar();
        }

        private void ActualizarGrid()
        {
            //Actualiza el Grid
            dgvSolicitud.DataSource = so.mostrarem();
            ColumnsGrid();
        }

        private void ColumnsGrid()
        {
            dgvSolicitud.Columns[0].Visible = false;
            dgvSolicitud.Columns[1].Visible = false;
            dgvSolicitud.Columns[2].HeaderText = "Fecha Solicitud";
            dgvSolicitud.Columns[3].HeaderText = "Administrador - Resolución";
            dgvSolicitud.Columns[4].HeaderText = "Resolución";
            dgvSolicitud.Columns[5].HeaderText = "Fecha Resolución";

        }

        public void Limpiar()
        {
            txtMotivo.Clear();
            FechaVali = DateTime.Now.AddDays(1);
            dtpFecha.MinDate = FechaVali;
            dtpFecha.Value = FechaVali;
            txtMotivo.Focus();
            txtIdSolicitud.Text = "";
            lblAccion.Text = "";
            txtMotivo.ReadOnly = false;
            dtpFecha.Enabled = true;
            btnEnvSoli.Enabled = true;
        }

        private void btnEnvSoli_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtIdSolicitud.Text))
                {
                    MessageBox.Show("Tiene una Solicitud seleccionada, por favor limpie los datos para continuar", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtMotivo.Text))
                {
                    MessageBox.Show("Ingrese la solicitud", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (dtpFecha.Value >= FechaVali)
                    {
                        if (MessageBox.Show("¿Desea crear la solicitud?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            so.Id_empleado = cPerfil.id;
                            so.Motivo = txtMotivo.Text;
                            so.Fecha_motivo = dtpFecha.Value;
                            soli.Enqueue(so);
                            so.Insertar();
                            ActualizarGrid();
                            Limpiar();
                            txtMotivo.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La Fecha debe ser un día mayor a hoy", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron enviar los datos: " + ex.Message);
            }
        }

        private void txtBuscarSolicitud_TextChanged(object sender, EventArgs e)
        {
            so.ABRICONEXION();
            string cadena = "SELECT S.id_solicitud, S.motivo, CONVERT(Date, S.fecha_pedido) AS fecha_pedido, (A.nombre + ' ' + A.apellido) AS Nombre, S.accion, CONVERT(Date, S.fecha_accion) AS fecha_accion " +
                         "FROM Solicitudes S FULL JOIN Administradores A ON A.id_admin = S.id_admin " +
                         "WHERE id_empleado = '" + cPerfil.id + "' ORDER BY fecha_pedido DESC";
            SqlCommand cmdbase = new SqlCommand(cadena, so.conexion);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdbase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dgvSolicitud.DataSource = bsource;
                sda.Update(dbdataset);
                //
                DataView dv = new DataView(dbdataset);
                dv.RowFilter = string.Format("Nombre like '%{0}%' or accion like '%{0}%'", txtBuscarSolicitud.Text);
                dgvSolicitud.DataSource = dv;
                so.CERRARCONEXION();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnEmpSolicitud_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvSolicitud_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FechaVali = Convert.ToDateTime("1/1/2020");
                dtpFecha.MinDate = FechaVali;
                txtIdSolicitud.Text = dgvSolicitud.CurrentRow.Cells["id_solicitud"].Value.ToString();
                txtMotivo.Text = dgvSolicitud.CurrentRow.Cells["motivo"].Value.ToString();
                dtpFecha.Value = DateTime.Parse(dgvSolicitud.CurrentRow.Cells["fecha_pedido"].Value.ToString());
                string accion = dgvSolicitud.CurrentRow.Cells["accion"].Value.ToString();
                if (accion != "")
                    lblAccion.Text = "Solicitud: " + accion;
                else
                    lblAccion.Text = "";
                txtMotivo.ReadOnly = true;
                dtpFecha.Enabled = false;
                btnEnvSoli.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using System;
using System.Windows.Forms;
//Clases no utilizadas
/*
 * using System.Collections;
 * using System.Collections.Generic;
 * using System.ComponentModel;
 * using System.Data;
 * using System.Drawing;
 * using System.Linq;
 * using System.Text;
 * using System.Threading.Tasks;
 * using System.Data.SqlClient;
 * using System.Data.Sql;
 * using System.Data.OleDb;
 * using System.Drawing.Printing;
 */

namespace Sistema_de_Control_de_Empleados__SCE_
{
    public partial class pnEmpInicio : Form
    {
        public pnEmpInicio()
        {
            InitializeComponent();
            ho.RecargarHorario(dgvHorario);
        }

        cHorarios ho = new cHorarios();
        string dato1 = "Asistió";
        string dato2 = "Se Retiro";

        private void pnEmpInicio_Load(object sender, EventArgs e)
        {
            ho.RecargarHorario(dgvHorario);
            FormatoGridHorario();
            btnAsistencia.Enabled = false;
            btnRetirada.Enabled = false;
            lblMarcado1.Visible = false;
            lblMarcado2.Visible = false;
            txtIdHorario.Clear();
            tmTiempo.Enabled = true;
        }

        private void FormatoGridHorario()
        {
            //Renombro las columnas del dgv como quiera
            dgvHorario.Columns[0].Visible = false;
            dgvHorario.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHorario.Columns[1].HeaderText = "Hora de Entrada";
            dgvHorario.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHorario.Columns[2].HeaderText = "Hora de Salida";
            dgvHorario.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHorario.Columns[3].HeaderText = "Fecha Especial";
            dgvHorario.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHorario.Columns[4].HeaderText = "Caja";
        }

        private void tmTiempo_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdHorario.Text))
            {
                MessageBox.Show("Seleccione un horario", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!ho.veriMarcado(Convert.ToInt32(txtIdHorario.Text), dato1))
            {
                 if (ho.veriasistencia(Convert.ToInt32(txtIdHorario.Text)))
                {
                    ho.insertasis(Convert.ToInt32(txtIdHorario.Text), Convert.ToDateTime(lblHora.Text), dato1, Convert.ToDateTime(lblFecha.Text));
                    MessageBox.Show("Marcado completado, Gracias " + cPerfil.nombre + " " + cPerfil.apellido, "Sistema Control de Empleados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    btnAsistencia.Enabled = false;
                    btnRetirada.Enabled = false;
                    lblMarcado1.Visible = false;
                    lblMarcado2.Visible = false;
                    txtIdHorario.Clear();
                    ho.RecargarHorario(dgvHorario);
                }
                else
                {
                    MessageBox.Show("Hora Inadecuada...", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usted ya ha marcado este horario", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRetirada_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdHorario.Text))
            {
                MessageBox.Show("Seleccione un horario", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ho.veriMarcado(Convert.ToInt32(txtIdHorario.Text), dato2))
            {
                if (ho.veriretirada(Convert.ToInt32(txtIdHorario.Text)))
                {
                    ho.insertasis(Convert.ToInt32(txtIdHorario.Text), Convert.ToDateTime(lblHora.Text), dato2, Convert.ToDateTime(lblFecha.Text));
                    MessageBox.Show("Marcado completado, Hasta Pronto " + cPerfil.nombre + " " + cPerfil.apellido, "Sistema Control de Empleados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    btnAsistencia.Enabled = false;
                    btnRetirada.Enabled = false;
                    lblMarcado1.Visible = false;
                    lblMarcado2.Visible = false;
                    txtIdHorario.Clear();
                    ho.RecargarHorario(dgvHorario);
                }
                else
                {
                    MessageBox.Show("Hora Inadecuada...", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usted ya ha marcado este horario", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvHorario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdHorario.Text = dgvHorario.CurrentRow.Cells["id_horario"].Value.ToString();
                if (ho.veriMarcado(Convert.ToInt32(txtIdHorario.Text), dato1) && ho.veriMarcado(Convert.ToInt32(txtIdHorario.Text), dato2))
                {
                    btnAsistencia.Enabled = false;
                    btnRetirada.Enabled = false;
                    lblMarcado1.Visible = true;
                    lblMarcado2.Visible = true;
                }
                else if (!ho.veriMarcado(Convert.ToInt32(txtIdHorario.Text), dato1))
                {
                    btnAsistencia.Enabled = true;
                    btnRetirada.Enabled = false;
                    lblMarcado1.Visible = false;
                    lblMarcado2.Visible = false;
                }
                else if (!ho.veriMarcado(Convert.ToInt32(txtIdHorario.Text), dato2))
                {
                    btnAsistencia.Enabled = false;
                    btnRetirada.Enabled = true;
                    lblMarcado1.Visible = true;
                    lblMarcado2.Visible = false;
                }
                else
                {
                    btnAsistencia.Enabled = false;
                    btnRetirada.Enabled = false;
                    lblMarcado1.Visible = false;
                    lblMarcado2.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

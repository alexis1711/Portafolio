using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
//Clases no utilizadas
/*
 * using System.Collections.Generic;
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
    public partial class pnAdmActualidad : Form
    {
        cHorarios ho = new cHorarios();
        DataTable dbdataset;
        public pnAdmActualidad()
        {
            InitializeComponent();
        }

        private void pnAdmActualidad_Load(object sender, EventArgs e)
        {
            lblArea.Text = cPerfil.area;
            ho.mostraractu(dgvActualidad);
            ho.mostrargene(dgvGeneral);
            FormatoGridActualidad();
            FormatoGridGeneral();
        }

        private void FormatoGridActualidad()
        {
            //Renombro las columnas del dgv como quiera
            dgvActualidad.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvActualidad.Columns[0].HeaderText = "Nombre Empleado";
            dgvActualidad.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvActualidad.Columns[1].HeaderText = "Asistencia";
            dgvActualidad.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvActualidad.Columns[2].HeaderText = "Hora Marcada";
            dgvActualidad.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvActualidad.Columns[3].HeaderText = "Fecha Especial";
        }

        private void FormatoGridGeneral()
        {
            //Renombro las columnas del dgv como quiera
            dgvGeneral.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGeneral.Columns[0].HeaderText = "Nombre Empleado";
            dgvGeneral.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGeneral.Columns[1].HeaderText = "Asistencia";
            dgvGeneral.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGeneral.Columns[2].HeaderText = "Hora Marcada";
            dgvGeneral.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGeneral.Columns[3].HeaderText = "Fecha Especial";
            dgvGeneral.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGeneral.Columns[4].HeaderText = "Fecha";
        }

        private void txtBuscarHoy_TextChanged(object sender, EventArgs e)
        {
            ho.ABRICONEXION();
            string cadena = "SELECT (E.nombre + ' ' + E.apellido) AS Nombre, A.asistencia, A.hora, H.especial " +
                "FROM Asistencia A " +
                "INNER JOIN Horarios_Empleados H ON A.id_horario = H.id_horario " +
                "INNER JOIN Empleados E ON E.id_empleado = H.id_empleado " +
                "WHERE A.fecha = '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "' AND E.id_area = (SELECT id_area FROM Area WHERE area = '" + cPerfil.area + "') " +
                "ORDER BY A.hora DESC";
            SqlCommand cmdbase = new SqlCommand(cadena, ho.conexion);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdbase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dgvActualidad.DataSource = bsource;
                sda.Update(dbdataset);
                //
                DataView dv = new DataView(dbdataset);
                dv.RowFilter = string.Format("Nombre LIKE '%{0}%' OR Asistencia LIKE '%{0}%'", txtBuscarHoy.Text);
                dgvActualidad.DataSource = dv;
                ho.CERRARCONEXION();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarGen_TextChanged(object sender, EventArgs e)
        {
            ho.ABRICONEXION();
            string cadena = "SELECT (E.nombre + ' ' + E.apellido) AS Nombre, A.asistencia, A.hora, H.especial, A.fecha " +
                "FROM Asistencia A " +
                "INNER JOIN Horarios_Empleados H ON A.id_horario = H.id_horario " +
                "INNER JOIN Empleados E ON E.id_empleado = H.id_empleado " +
                "WHERE E.id_area = (SELECT id_area FROM Area WHERE area = '" + cPerfil.area + "') " +
                "ORDER BY A.fecha DESC";
            SqlCommand cmdbase = new SqlCommand(cadena, ho.conexion);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdbase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dgvGeneral.DataSource = bsource;
                sda.Update(dbdataset);
                //
                DataView dv = new DataView(dbdataset);
                dv.RowFilter = string.Format("Nombre LIKE '%{0}%' OR Asistencia LIKE '%{0}%'", txtBuscarGen.Text);
                dgvGeneral.DataSource = dv;
                ho.CERRARCONEXION();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

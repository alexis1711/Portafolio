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
    public partial class pnAdmAreaPuesto : Form
    {
        Queue<cArea> area = new Queue<cArea>();
        Queue<cPuesto> puesto = new Queue<cPuesto>();
        cArea ar = new cArea();
        cPuesto pu = new cPuesto();
        DataTable dbdataset;
        public pnAdmAreaPuesto()
        {
            InitializeComponent();
            ActualizarGrid();
            Limpiar();
        }

        private void ActualizarGrid()
        {
            dgvArea.DataSource = ar.mostrar();
            dgvPuesto.DataSource = pu.mostrar();
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
        }

        private void btnGuardarArea_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIdArea.Text))
            {
                MessageBox.Show("Tiene un Área seleccionada, por favor limpie los datos para continuar", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(string.IsNullOrWhiteSpace(txtArea.Text))
            {
                MessageBox.Show("Ingrese nombre del Área", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea guardar el registro?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        ar.Area = txtArea.Text;
                        area.Enqueue(ar);
                        ar.Insertar();
                        ActualizarGrid();
                        Limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudieron guardar los datos: " + ex.Message);
                    }
                }
            }
            txtArea.Focus();
        }
       
        private void btnModificarArea_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtIdArea.Text))
            {
                MessageBox.Show("Haga doble click en la Área que desea modificar", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtArea.Text))
            {
                MessageBox.Show("Ingrese nombre del Área", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea modificar el registro seleccionado?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        ar.editar(txtIdArea.Text, txtArea.Text);
                        ActualizarGrid();
                        Limpiar();
                        txtArea.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudierón editar los datos" + ex.Message);
                    }
                }
            }
        }

        private void btnGuardarPuesto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIdPuesto.Text))
            {
                MessageBox.Show("Tiene un Puesto seleccionado, por favor limpie los datos para continuar", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtPuesto.Text))
            {
                MessageBox.Show("Ingrese nombre del Puesto", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea guardar el registro?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        pu.Puesto = txtPuesto.Text;
                        puesto.Enqueue(pu);
                        pu.Insertar();
                        ActualizarGrid();
                        Limpiar();
                        txtPuesto.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudieron guardar los datos: " + ex.Message);
                    }
                }
            }
        }

        private void btnModificarPuesto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdPuesto.Text))
            {
                MessageBox.Show("Haga doble click en la fila que desea modificar", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtPuesto.Text))
            {
                MessageBox.Show("Ingrese nombre del Puesto", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea modificar el ultimo registro seleccionado?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        pu.editar(txtIdPuesto.Text, txtPuesto.Text);
                        ActualizarGrid();
                        Limpiar();
                        txtPuesto.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudieron editar los datos: " + ex.Message);
                    }
                }  
            }
        }

        private void txtBuscarArea_TextChanged(object sender, EventArgs e)
        {
            ar.ABRICONEXION();
            SqlCommand cmdbase = new SqlCommand("SELECT * FROM Area", ar.conexion);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdbase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dgvArea.DataSource = bsource;
                sda.Update(dbdataset);
                //
                DataView dv = new DataView(dbdataset);
                dv.RowFilter = string.Format("area LIKE '%{0}%'", txtBuscarArea.Text);
                dgvArea.DataSource = dv;
                ar.CERRARCONEXION();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarPuesto_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmdbase = new SqlCommand("SELECT * FROM Puesto", pu.conexion);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdbase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dgvPuesto.DataSource = bsource;
                sda.Update(dbdataset);

                DataView dv = new DataView(dbdataset);
                dv.RowFilter = string.Format("puesto LIKE '%{0}%'", txtBuscarPuesto.Text);
                dgvPuesto.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
       private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
            Limpiar();
        }

        private void pnAdmAreaPuesto_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
            FormatoGridArea();
            FormatoGridPuesto();
            Limpiar();
        }

        private void FormatoGridArea()
        {
            //Renombro las columnas del dgv
            dgvArea.Columns[0].Visible=false;
            dgvArea.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvArea.Columns[1].HeaderText = "Áreas";
        }

        private void FormatoGridPuesto()
        {
            //Renombro las columnas del dgv como quiera
            dgvPuesto.Columns[0].Visible = false;
            dgvPuesto.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPuesto.Columns[1].HeaderText = "Puestos";
        }

        private void dgvArea_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdArea.Text = dgvArea.CurrentRow.Cells["id_area"].Value.ToString();
                txtArea.Text = dgvArea.CurrentRow.Cells["area"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPuesto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdPuesto.Text = dgvPuesto.CurrentRow.Cells["id_puesto"].Value.ToString();
                txtPuesto.Text = dgvPuesto.CurrentRow.Cells["puesto"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEliminarArea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdArea.Text) || string.IsNullOrWhiteSpace(txtArea.Text))
            {
                MessageBox.Show("Haga doble click en la fila que desea modificar", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar el ultimo registro seleccionado?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        ar.eliminar(txtIdArea.Text);
                        ActualizarGrid();
                        Limpiar();
                    }
                    catch
                    {
                        MessageBox.Show("No se pudieron eliminar los datos", "Sistema Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }

        private void btnEliminarPuesto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdPuesto.Text) || string.IsNullOrWhiteSpace(txtPuesto.Text))
            {
                MessageBox.Show("Haga doble click en la fila que desea eliminar", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar el ultimo registro seleccionado?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        pu.eliminar(txtIdPuesto.Text);
                        ActualizarGrid();
                        Limpiar();
                    }
                    catch
                    {
                        MessageBox.Show("No se pudieron eliminar los datos", "Sistema Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void lblBuscarA_Click(object sender, EventArgs e)
        {

        }
    }
}

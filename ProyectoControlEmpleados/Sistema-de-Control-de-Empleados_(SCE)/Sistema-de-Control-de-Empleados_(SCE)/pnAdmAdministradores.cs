using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
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
    public partial class pnAdmAdministradores : Form
    {
        Queue<cAdministrador> admin = new Queue<cAdministrador>();
        cAdministrador ad = new cAdministrador();
        DataTable dbdataset;
        cConexion c = new cConexion();
        public pnAdmAdministradores()
        {
            InitializeComponent();
            ActualizarGrid();
            Limpiar();
        }
        private void ActualizarGrid()
        {
            dgvAdmin.DataSource = ad.mostrar();
            CargarArea();
            CargarPuesto();
        }

        private void Limpiar()
        {
            foreach (Control con in Controls)
            {
                if(con is ComboBox)
                {
                    if (((ComboBox)con).Items.Count != 0)
                        ((ComboBox)con).SelectedIndex = 0;
                }
                if (con is TextBox)
                {
                    ((TextBox)con).Clear();
                }
                if (con is RadioButton)
                {
                    ((RadioButton)con).Checked = false;
                }
            }
            btnDesactivar.Text = "Desactivar";
            txtNombre.Focus();
        }

        private void CargarArea()
        {
            cArea a = new cArea();
            try
            {
                cmbArea.Items.Clear();
                SqlCommand carg = new SqlCommand("SELECT area FROM Area", a.conexion);
                a.ABRICONEXION();
                SqlDataReader ver = carg.ExecuteReader();
                while (ver.Read() == true)
                {
                    cmbArea.Items.Add(ver[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarPuesto()
        {
            cPuesto p = new cPuesto();
            try
            {
                cmbPuesto.Items.Clear();
                SqlCommand carg = new SqlCommand("SELECT puesto FROM Puesto", p.conexion);
                p.ABRICONEXION();
                SqlDataReader ver = carg.ExecuteReader();
                while (ver.Read() == true)
                {
                    cmbPuesto.Items.Add(ver[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pnAdmAdministradores_Load(object sender, EventArgs e)
        {
            CargarArea();
            CargarPuesto();
            ActualizarGrid();
            Limpiar();
            FormatoGridAdmin();
        }

        private bool Validaciones_SoloLetra(TextBox txt)
        {
            bool veri = false;
            //Esta linea de codigo busca en el TextBox las letras que se encuentran en el
            if (Regex.IsMatch(txt.Text, "^[a-zA-Z ]*$")) //Expresión Regular
                veri = false;
            else
                veri = true;
            return veri;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtIdAdmin.Text))
                {
                    MessageBox.Show("Tiene un Administrador seleccionado, por favor limpie los datos para continuar", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Ingrese el nombre del administrador", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Validaciones_SoloLetra(txtNombre))
                {
                    MessageBox.Show("El nombre del empleado solo debe contener letras", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtApellidos.Text))
                {
                    MessageBox.Show("Ingrese el apellido del administrador", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Validaciones_SoloLetra(txtApellidos))
                {
                    MessageBox.Show("El nombre del empleado solo debe contener letras", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    MessageBox.Show("Ingrese el usuario del administrador", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtContra.Text))
                {
                    MessageBox.Show("Ingrese la contraseña del administrador", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtVeriContra.Text))
                {
                    MessageBox.Show("Ingrese la contraseña del administrador", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtVeriContra.Text != txtContra.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden!", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("¿Desea guardar el registro?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ad.Id_Admin = ad.Codigo(txtApellidos.Text);
                    ad.Nombre = txtNombre.Text;
                    ad.Apellido = txtApellidos.Text;
                    ad.id_area = ad.Codarea(cmbArea);
                    ad.id_puesto = ad.Codpuesto(cmbPuesto);
                    ad.Usuario = txtUsuario.Text;
                    ad.incapacidad = ad.Discapacidad(rdbtIncSi);
                    ad.Contrasena = txtContra.Text;
                    admin.Enqueue(ad);
                    ad.Insertar();
                    ActualizarGrid();
                    Limpiar();
                }
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

        private void FormatoGridAdmin()
        {
            //Renombro las columnas del dgv como quiera
            dgvAdmin.Columns[0].Visible = false;
            dgvAdmin.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdmin.Columns[1].HeaderText = "Nombre Administrador";
            dgvAdmin.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdmin.Columns[2].HeaderText = "Apellido Administrador";
            dgvAdmin.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdmin.Columns[3].HeaderText = "Usuario";
            dgvAdmin.Columns[4].Visible = false;
            dgvAdmin.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdmin.Columns[5].HeaderText = "Área";
            dgvAdmin.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdmin.Columns[6].HeaderText = "Puesto";
            dgvAdmin.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdmin.Columns[7].HeaderText = "Incapacidad";
            dgvAdmin.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdmin.Columns[8].HeaderText = "Estado";

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdAdmin.Text))
                {
                    MessageBox.Show("Haga doble click en la fila que desea modificar", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Ingrese el nombre del administrador", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Validaciones_SoloLetra(txtNombre))
                {
                    MessageBox.Show("El nombre del administrador solo debe contener letras", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtApellidos.Text))
                {
                    MessageBox.Show("Ingrese el apellido del administrador", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Validaciones_SoloLetra(txtApellidos))
                {
                    MessageBox.Show("El apellido del administrador solo debe contener letras", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    MessageBox.Show("Ingrese el usuario del administrador", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtContra.Text))
                {
                    MessageBox.Show("Ingrese la contraseña del administrador", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(txtInvContra.Text != txtContra.Text)
                {
                    //Entrara aqui si esas contras no son iguales
                    if (string.IsNullOrWhiteSpace(txtVeriContra.Text))
                    {
                        MessageBox.Show("Ingrese la contraseña del administrador", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtVeriContra.Text != txtContra.Text)
                    {
                        MessageBox.Show("Las contraseñas no coinciden!", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (MessageBox.Show("¿Desea modificar el registro?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        ad.editar(txtIdAdmin.Text, txtNombre.Text, txtApellidos.Text, txtUsuario.Text, txtContra.Text, Convert.ToInt32(ad.Codarea(cmbArea)), Convert.ToInt32(ad.Codpuesto(cmbPuesto)), ad.Discapacidad(rdbtIncSi));
                        ActualizarGrid();
                        Limpiar();
                        txtNombre.Focus();
                    }
                }
                else if (MessageBox.Show("¿Desea modificar el registro?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //Aqui entrara si no ha cambiado la contra
                    ad.editar(txtIdAdmin.Text, txtNombre.Text, txtApellidos.Text, txtUsuario.Text, txtContra.Text, Convert.ToInt32(ad.Codarea(cmbArea)), Convert.ToInt32(ad.Codpuesto(cmbPuesto)), ad.Discapacidad(rdbtIncSi));
                    ActualizarGrid();
                    Limpiar();
                    txtNombre.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron editar los datos" + ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ad.ABRICONEXION();
            string cadena = "SELECT Ad.id_admin, Ad.nombre, Ad.apellido, Ad.usuario, Ad.contrasena, A.area, P.puesto, Ad.incapacidad, Ad.estado " +
                                    "FROM Administradores Ad INNER JOIN Puesto P ON Ad.id_puesto = P.id_puesto " +
                                    "INNER JOIN Area A ON Ad.id_area = A.id_area";
            SqlCommand fr = new SqlCommand(cadena, ad.conexion);
            try
            {
                SqlDataAdapter sq = new SqlDataAdapter();
                sq.SelectCommand = fr;
                dbdataset = new DataTable();
                sq.Fill(dbdataset);
                BindingSource bs = new BindingSource();
                bs.DataSource = dbdataset;
                dgvAdmin.DataSource = bs;
                sq.Update(dbdataset);
                //
                DataView dt = new DataView(dbdataset);
                dt.RowFilter = string.Format("nombre like '%{0}%' OR apellido like '%{0}%' OR usuario  like '%{0}%' OR area  like '%{0}%' OR puesto  like '%{0}%'", txtBuscar.Text);
                dgvAdmin.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdAdmin.Text))
                {
                    MessageBox.Show("Haga doble click en la fila que desea Activar/Desactivar", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("¿Desea realizar la acción con el registro seleccionado?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = c.ABRICONEXION();
                    comando.CommandText = "UPDATE Administradores set estado = @est WHERE id_admin = @id";
                    comando.Parameters.AddWithValue("@id", txtIdAdmin.Text);
                    if (btnDesactivar.Text == "Desactivar")
                    {
                        comando.Parameters.AddWithValue("@est", false);
                        comando.ExecuteNonQuery();
                        comando.Parameters.Clear();
                        MessageBox.Show("Registro Desactivado...", "Sistema Control de Empleados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else if (btnDesactivar.Text == "Activar")
                    {
                        comando.Parameters.AddWithValue("@est", true);
                        comando.ExecuteNonQuery();
                        comando.Parameters.Clear();
                        MessageBox.Show("Registro Activado...", "Sistema Control de Empleados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    ActualizarGrid();
                    Limpiar();
                    txtNombre.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron editar los datos" + ex.Message);
            }
        }

        private void dgvAdmin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdAdmin.Text = dgvAdmin.CurrentRow.Cells["id_admin"].Value.ToString();
                txtNombre.Text = dgvAdmin.CurrentRow.Cells["nombre"].Value.ToString();
                txtApellidos.Text = dgvAdmin.CurrentRow.Cells["apellido"].Value.ToString();
                txtUsuario.Text = dgvAdmin.CurrentRow.Cells["usuario"].Value.ToString();
                txtContra.Text = dgvAdmin.CurrentRow.Cells["contrasena"].Value.ToString();
                txtInvContra.Text = dgvAdmin.CurrentRow.Cells["contrasena"].Value.ToString();
                cmbArea.Text = dgvAdmin.CurrentRow.Cells["area"].Value.ToString();
                cmbPuesto.Text = dgvAdmin.CurrentRow.Cells["puesto"].Value.ToString();
                bool inc = Convert.ToBoolean(dgvAdmin.CurrentRow.Cells["incapacidad"].Value);
                if (inc)
                {
                    rdbtIncSi.Checked = true;
                    rdbIncNo.Checked = false;
                }
                else
                {
                    rdbtIncSi.Checked = false;
                    rdbIncNo.Checked = true;
                }
                bool est = Convert.ToBoolean(dgvAdmin.CurrentRow.Cells["estado"].Value);
                if (est)
                    btnDesactivar.Text = "Desactivar";
                else
                    btnDesactivar.Text = "Activar";
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

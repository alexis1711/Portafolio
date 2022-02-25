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
    public partial class pnAdmEmpleados : Form
    {
        Queue<cEmpleado> empleado = new Queue<cEmpleado>();
        cConexion c = new cConexion();
        cEmpleado em = new cEmpleado();
        DataTable dbdataset;
        private SqlCommand insert1;
        public pnAdmEmpleados()
        {
            InitializeComponent();
            ActualizarGrid();
            Limpiar();
        }

        private void ActualizarGrid()
        {
            dgvEmpleados.DataSource = em.mostrar();
            CargarArea();
            CargarPuesto();
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
                if (con is RadioButton)
                {
                    ((RadioButton)con).Checked = false;
                }
            }
            //Sirve para limitar la fecha de nacimiento
            dtpFecha.Value = DateTime.Now.AddYears(-21);
            dtpFecha.MinDate = DateTime.Now.AddYears(-100);
            dtpFecha.MaxDate = DateTime.Now.AddYears(-18);
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
        private bool verificarcontra(TextBox a, TextBox b)
        {
            bool vali = false;
            string contra = a.Text;
            string veri = b.Text;
            if (veri == contra)
            {
                vali = true;
            }
            if (vali == false)
            {
                MessageBox.Show("Las Contraseñas no coinciden", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return vali;
        }

        private bool validar()
        {
            bool validado = true;
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del empleado", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validado = false;
            }
            else if (Validaciones_SoloLetra(txtNombre))
            {
                MessageBox.Show("El nombre del empleado solo debe contener letras", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validado = false;
            }
            else if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Ingrese el apellido del empleado", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validado = false;
            }
            else if (Validaciones_SoloLetra(txtApellido))
            {
                MessageBox.Show("El apellido del empleado solo debe contener letras", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validado = false;
            }
            else if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese el usuario del empleado", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validado = false;
            }
            else if (rdbFemenino.Checked == false && rdbMasculino.Checked == false)
            {
                MessageBox.Show("Seleccione el genero del empleado", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validado = false;
            }
            else if (rdbIncNo.Checked == false && rdbtIncSi.Checked == false)
            {
                MessageBox.Show("Seleccione si esta indiscapacitado el empleado", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validado = false;
            }
            else if (dtpFecha.Value < DateTime.Now.AddYears(-100) && dtpFecha.Value > DateTime.Now.AddYears(-18))
            {
                MessageBox.Show("Fecha de nacimiento invalida", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validado = false;
            }
            return validado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIdEmpleado.Text))
            {
                MessageBox.Show("Tiene un Empleado seleccionado, por favor limpie los datos para continuar", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtContra.Text) || string.IsNullOrWhiteSpace(txtVeriContra.Text))
            {
                MessageBox.Show("Ingrese la contraseña del empleado", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verificarcontra(txtContra, txtVeriContra) && validar())
            {
                if (MessageBox.Show("¿Desea guardar el registro?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    em.Id = em.Codigo(txtApellido.Text);
                    em.Nombres = txtNombre.Text;
                    em.Apellidos = txtApellido.Text;
                    em.Fechanac = dtpFecha.Value.Date;
                    em.Genero = em.Asigenero(rdbMasculino);
                    em.Usuario = txtUsuario.Text;
                    em.Contrasena = txtContra.Text;
                    em.Area = em.Codarea(cmbArea);
                    em.Puesto = em.Codpuesto(cmbPuesto);
                    em.Estado = true;
                    em.Incapacidad = em.Discapacidad(rdbtIncSi);
                    empleado.Enqueue(em);
                    try
                    {
                        c.ABRICONEXION();
                        string insertempleado;
                        insertempleado = "INSERT INTO Empleados(id_empleado,nombre,apellido,fecha_nacimiento,genero,usuario,contrasena,id_area,id_puesto,incapacidad,estado)";
                        insertempleado += "VALUES(@codigo,@nombre,@apellido,@fecha,@genero,@usuario,@contra,@area,@puesto,@inc,@est)";
                        insert1 = new SqlCommand(insertempleado, c.conexion);
                        insert1.Parameters.Add(new SqlParameter("@codigo", SqlDbType.VarChar));
                        insert1.Parameters["@codigo"].Value = em.Id;
                        insert1.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
                        insert1.Parameters["@nombre"].Value = em.Nombres;
                        insert1.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
                        insert1.Parameters["@apellido"].Value = em.Apellidos;
                        insert1.Parameters.Add(new SqlParameter("@fecha", SqlDbType.Date));
                        insert1.Parameters["@fecha"].Value = em.Fechanac;
                        insert1.Parameters.Add(new SqlParameter("@genero", SqlDbType.VarChar));
                        insert1.Parameters["@genero"].Value = em.Genero;
                        insert1.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar));
                        insert1.Parameters["@usuario"].Value = em.Usuario;
                        insert1.Parameters.Add(new SqlParameter("@contra", SqlDbType.VarChar));
                        insert1.Parameters["@contra"].Value = em.Contrasena;
                        insert1.Parameters.Add(new SqlParameter("@area", SqlDbType.Int));
                        insert1.Parameters["@area"].Value = em.Area;
                        insert1.Parameters.Add(new SqlParameter("@puesto", SqlDbType.Int));
                        insert1.Parameters["@puesto"].Value = em.Puesto;
                        insert1.Parameters.Add(new SqlParameter("@inc", SqlDbType.Bit));
                        insert1.Parameters["@inc"].Value = em.Incapacidad;
                        insert1.Parameters.Add(new SqlParameter("@est", SqlDbType.Bit));
                        insert1.Parameters["@est"].Value = em.Estado;
                        insert1.ExecuteNonQuery();
                        MessageBox.Show("Registro Agregado...", "Sistema Control de Empleados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        c.CERRARCONEXION();
                        ActualizarGrid();
                        Limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se produjo un error " + ex);
                    }
                }
            }
        }

        private void pnAdmEmpleados_Load(object sender, EventArgs e)
        {
           
            ActualizarGrid();
            FormatoGridEmpleado();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdEmpleado.Text))
            {
                MessageBox.Show("Haga doble click en la fila que desea modificar", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validar())
            {
                try
                {
                    if (txtInvContra.Text != txtContra.Text)
                    {
                        //Entrara aqui si esas contras no son iguales
                        if (string.IsNullOrWhiteSpace(txtVeriContra.Text))
                        {
                            MessageBox.Show("Ingrese la contraseña del empleado", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtVeriContra.Text != txtContra.Text)
                        {
                            MessageBox.Show("Las contraseñas no coinciden!", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if(MessageBox.Show("¿Desea modificar el registro seleccionado?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            em.editar(txtIdEmpleado.Text, txtNombre.Text, txtApellido.Text, dtpFecha.Value, em.Asigenero(rdbMasculino), txtUsuario.Text, txtContra.Text, em.Codarea(cmbArea), em.Codpuesto(cmbPuesto), em.Discapacidad(rdbtIncSi));
                            MessageBox.Show("Registro Modificado...", "Sistema Control de Empleados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ActualizarGrid();
                            Limpiar();
                        }
                    }
                    else if (MessageBox.Show("¿Desea modificar el registro seleccionado?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        em.editar(txtIdEmpleado.Text, txtNombre.Text, txtApellido.Text, dtpFecha.Value, em.Asigenero(rdbMasculino), txtUsuario.Text, txtContra.Text, em.Codarea(cmbArea), em.Codpuesto(cmbPuesto), em.Discapacidad(rdbtIncSi));
                        MessageBox.Show("Registro Modificado...", "Sistema Control de Empleados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ActualizarGrid();
                        Limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron editar los datos: " + ex.Message);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            em.ABRICONEXION();
            string cadena = "SELECT E.id_empleado, E.nombre, E.apellido,E.fecha_nacimiento,E.genero, E.usuario,E.contrasena, A.area, P.puesto, E.incapacidad, E.estado " +
                                    "FROM Empleados E INNER JOIN Puesto P ON E.id_puesto = P.id_puesto " +
                                    "INNER JOIN Area A ON E.id_area = A.id_area";
            SqlCommand fr = new SqlCommand(cadena, em.conexion);
            try
            {
                SqlDataAdapter sq = new SqlDataAdapter();
                sq.SelectCommand = fr;
                dbdataset = new DataTable();
                sq.Fill(dbdataset);
                BindingSource bs = new BindingSource();
                bs.DataSource = dbdataset;
                dgvEmpleados.DataSource = bs;
                sq.Update(dbdataset);
                //
                DataView dt = new DataView(dbdataset);
                dt.RowFilter = string.Format("nombre LIKE '%{0}%' OR apellido LIKE '%{0}%' OR usuario LIKE '%{0}%' OR area LIKE '%{0}%' OR puesto LIKE '%{0}%' OR genero LIKE '%{0}%'", txtBuscar.Text);
                dgvEmpleados.DataSource = dt;
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

        private void FormatoGridEmpleado()
        {
            //Renombro las columnas del dgv como quiera
            dgvEmpleados.Columns[0].Visible = false;
            dgvEmpleados.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmpleados.Columns[1].HeaderText = "Nombre Empleado";
            dgvEmpleados.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmpleados.Columns[2].HeaderText = "Apellido Empleado";
            dgvEmpleados.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmpleados.Columns[3].HeaderText = "Fecha de Nacimiento";
            dgvEmpleados.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmpleados.Columns[4].HeaderText = "Genero";
            dgvEmpleados.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmpleados.Columns[5].HeaderText = "Usuario";
            dgvEmpleados.Columns[6].Visible = false;
            dgvEmpleados.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmpleados.Columns[7].HeaderText = "Área";
            dgvEmpleados.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmpleados.Columns[8].HeaderText = "Puesto";
            dgvEmpleados.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmpleados.Columns[9].HeaderText = "Incapacidad";
            dgvEmpleados.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmpleados.Columns[10].HeaderText = "Estado";
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdEmpleado.Text = dgvEmpleados.CurrentRow.Cells["id_empleado"].Value.ToString();
                txtNombre.Text = dgvEmpleados.CurrentRow.Cells["nombre"].Value.ToString();
                txtApellido.Text = dgvEmpleados.CurrentRow.Cells["apellido"].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells["fecha_nacimiento"].Value.ToString());
                string genero = dgvEmpleados.CurrentRow.Cells["genero"].Value.ToString();
                if (genero == "Masculino")
                {
                    rdbMasculino.Checked = true;
                    rdbFemenino.Checked = false;
                }
                else if (genero == "Femenino")
                {
                    rdbMasculino.Checked = false;
                    rdbFemenino.Checked = true;
                }
                txtUsuario.Text = dgvEmpleados.CurrentRow.Cells["usuario"].Value.ToString();
                txtContra.Text = dgvEmpleados.CurrentRow.Cells["contrasena"].Value.ToString();
                txtInvContra.Text = dgvEmpleados.CurrentRow.Cells["contrasena"].Value.ToString();
                cmbArea.Text = dgvEmpleados.CurrentRow.Cells["area"].Value.ToString();
                cmbPuesto.Text = dgvEmpleados.CurrentRow.Cells["puesto"].Value.ToString();
                bool inc = Convert.ToBoolean(dgvEmpleados.CurrentRow.Cells["incapacidad"].Value);
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
                bool est = Convert.ToBoolean(dgvEmpleados.CurrentRow.Cells["estado"].Value);
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

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdEmpleado.Text))
                {
                    MessageBox.Show("Haga doble click en la fila que desea Activar/Desactivar", "Sistema de Control de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("¿Desea realizar la acción con el registro seleccionado?", "Sistema de Control de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        SqlCommand comando = new SqlCommand();
                        comando.Connection = c.ABRICONEXION();
                        comando.CommandText = "UPDATE Empleados set estado = @est WHERE id_empleado = @id";
                        comando.Parameters.AddWithValue("@id", txtIdEmpleado.Text);
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
                        c.CERRARCONEXION();
                        ActualizarGrid();
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la operación " + ex.Message);
            }
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsSeparator(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsSeparator(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
    }
}

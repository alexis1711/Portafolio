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
    public partial class frm_Empleados : Form
    {
        public frm_Empleados()
        {
            InitializeComponent();
            CargarEmpleados();
        }

        private void frm_Empleados_Load(object sender, EventArgs e)
        {
            cbxempleado.Items.Add("Jefe de Brigada");
            cbxempleado.Items.Add("Motorista");
            cbxempleado.Items.Add("Socorrista");
            cbxempleado.Items.Add("Voluntario");
            cbxempleado.Items.Add("Periodista");
            cbxempleado.Items.Add("Otro");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnom1.Clear();
            txtnom2.Clear();
            txtape1.Clear();
            txtape2.Clear();
            txtcod.Clear();
            cbxempleado.SelectedIndex = -1;
            CargarEmpleados();
        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e) => Validaciones.SoloLetras(e);

        private void txtnom2_KeyPress(object sender, KeyPressEventArgs e) => Validaciones.SoloLetras(e);

        private void txtape_KeyPress(object sender, KeyPressEventArgs e) => Validaciones.SoloLetras(e);

        private void txtape2_KeyPress(object sender, KeyPressEventArgs e) => Validaciones.SoloLetras(e);

        private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CargarEmpleados()
        {
            EntityFramework.ComandosSalvamentoEntities contexto = new EntityFramework.ComandosSalvamentoEntities();
            dgvempleados.DataSource = contexto.Empleados.ToList();
            dgvempleados.Columns.RemoveAt(9);
            dgvempleados.Columns.RemoveAt(9);
            dgvempleados.Columns.RemoveAt(9);
            dgvempleados.Columns.RemoveAt(9);
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {

        }
    }
}

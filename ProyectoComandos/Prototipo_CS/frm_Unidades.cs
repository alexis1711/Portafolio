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
    public partial class frm_Unidades : Form
    {
        public frm_Unidades()
        {
            InitializeComponent();
            txtcodhos.Enabled = false;
            txtcodigounidad.Enabled = false;
        }

        int id_estado;
        int uni_hos; //1 Para Unidad. 2 Para Hospital

        #region Hospital

        private void btnregistrarhos_Click(object sender, EventArgs e)
        {
            using (EntityFramework.ComandosSalvamentoEntities contexto = new EntityFramework.ComandosSalvamentoEntities())
            {
                EntityFramework.HospitalesSS c = new EntityFramework.HospitalesSS
                {
                    CodigoHospital = GenerarCodHos(),
                    NombreHospital = txtnombre.Text,
                    Estado = id_estado
                };
                contexto.HospitalesSS.Add(c);
                contexto.SaveChanges();
                ReestablecerHospital();
            }
        }

        private string GenerarCodHos()
        {
            string cod;
            EntityFramework.ComandosSalvamentoEntities contexto = new EntityFramework.ComandosSalvamentoEntities();

            if (contexto.HospitalesSS.Count() < 9)
                cod = "HOS0" + Convert.ToString(contexto.HospitalesSS.Count() + 1);
            else
                cod = "HOS" + Convert.ToString(contexto.HospitalesSS.Count() + 1);

            return cod;
        }

        private void CargarHospital()
        {
            EntityFramework.ComandosSalvamentoEntities contexto = new EntityFramework.ComandosSalvamentoEntities();
            /*string sqlsentence = "SELECT H.CodigoHospital, H.NombreHospital, E.Descripcion ";
            sqlsentence += "FROM HospitalesSS H JOIN Estado E ";
            sqlsentence += "ON H.Estado = E.Id";*/
            dgvunihos.DataSource = contexto.HospitalesSS.ToList();
            dgvunihos.Columns.RemoveAt(4);
            dgvunihos.Columns.RemoveAt(3);
        }

        private void LimpiarHospital()
        {
            txtcodhos.Clear();
            txtnombre.Clear();
            rdbactivohospitales.Checked = false;
            rdbinactivohospitales.Checked = false;
        }

        private void ReestablecerHospital()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            LimpiarUnidad();
            LimpiarHospital();
            txtcodhos.Text = GenerarCodHos();
            uni_hos = 2;

            CargarHospital();
        }

        private void rbtnhos_Click(object sender, EventArgs e)
        {
            ReestablecerHospital();
        }

        private void btnreestablecerhos_Click(object sender, EventArgs e)
        {
            ReestablecerHospital();
        }

        private void rdbactivohospitales_Click(object sender, EventArgs e) => id_estado = 1;

        private void rdbinactivohospitales_Click(object sender, EventArgs e) => id_estado = 2;

        #endregion

        #region Unidad

        private void btnregistrarunidad_Click(object sender, EventArgs e)
        {
            using (EntityFramework.ComandosSalvamentoEntities contexto = new EntityFramework.ComandosSalvamentoEntities())
            {
                EntityFramework.Unidades c = new EntityFramework.Unidades
                {
                    CodigoUnidad = GenerarCodUni(),
                    Placas = txtplacas.Text,
                    Descripcion = txtdescripcion.Text,
                    Estado = id_estado
                };
                contexto.Unidades.Add(c);
                contexto.SaveChanges();
                ReestablecerUnidad();
            }
        }

        private string GenerarCodUni()
        {
            string cod;
            EntityFramework.ComandosSalvamentoEntities contexto = new EntityFramework.ComandosSalvamentoEntities();

            if (contexto.Unidades.Count() < 9)
                cod = "UNI00" + Convert.ToString(contexto.Unidades.Count() + 1);
            else if (contexto.Unidades.Count() >= 9 && contexto.Unidades.Count() < 99)
                cod = "UNI0" + Convert.ToString(contexto.Unidades.Count() + 1);
            else
                cod = "UNI" + Convert.ToString(contexto.Unidades.Count() + 1);

            return cod;
        }

        private void CargarUnidad()
        {
            EntityFramework.ComandosSalvamentoEntities contexto = new EntityFramework.ComandosSalvamentoEntities();
            dgvunihos.DataSource = contexto.Unidades.ToList();
            dgvunihos.Columns.RemoveAt(5);
            dgvunihos.Columns.RemoveAt(4);
        }

        private void LimpiarUnidad()
        {
            txtcodigounidad.Clear();
            txtplacas.Clear();
            txtdescripcion.Clear();
            rdbactivounidades.Checked = false;
            rdbinactivounidades.Checked = false;
        }

        private void ReestablecerUnidad()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            LimpiarUnidad();
            LimpiarHospital();
            txtcodigounidad.Text = GenerarCodUni();
            uni_hos = 1;

            CargarUnidad();
        }

        private void rbtnunidad_Click(object sender, EventArgs e)
        {
            ReestablecerUnidad();
        }

        private void btnreestableceruni_Click(object sender, EventArgs e)
        {
            ReestablecerUnidad();
        }

        private void rdbactivounidades_Click(object sender, EventArgs e) => id_estado = 1;

        private void rdbinactivounidades_Click(object sender, EventArgs e) => id_estado = 2;

        #endregion
    }
}

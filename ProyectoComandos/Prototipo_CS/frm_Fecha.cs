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
    public partial class frm_Fecha : Form
    {
        public frm_Fecha()
        {
            InitializeComponent();
        }

        private void rbtnlesion_CheckedChanged(object sender, EventArgs e)
        {
            cbxlesion.Enabled = true;
            cbxaccidente.SelectedIndex = -1;
            cbxrescate.SelectedIndex = -1;
            cbxincendio.SelectedIndex = -1;
            cbxfallecimiento.SelectedIndex = -1;

            if (rbtnaccidente.Checked == true||rbtnfallecidos.Checked == true||rbtnincendio.Checked == true||rbtnrescate.Checked == true)
            {
                cbxlesion.Enabled = false;
         
              
            }
        }

        private void rbtnaccidente_CheckedChanged(object sender, EventArgs e)
        {
            cbxaccidente.Enabled = true;
            cbxlesion.SelectedIndex = -1;
            cbxrescate.SelectedIndex = -1;
            cbxincendio.SelectedIndex = -1;
            cbxfallecimiento.SelectedIndex = -1;

            if (rbtnlesion.Checked == true || rbtnfallecidos.Checked == true || rbtnincendio.Checked == true || rbtnrescate.Checked == true)
            {
                cbxaccidente.Enabled = false;

                
            }
        }

        private void rbtnrescate_CheckedChanged(object sender, EventArgs e)
        {
            cbxrescate.Enabled = true;
            cbxlesion.SelectedIndex = -1;
            cbxaccidente.SelectedIndex = -1;
            cbxincendio.SelectedIndex = -1;
            cbxfallecimiento.SelectedIndex = -1;

            if (rbtnaccidente.Checked == true || rbtnfallecidos.Checked == true || rbtnincendio.Checked == true || rbtnlesion.Checked == true)
            {
                cbxrescate.Enabled = false;
               
            }
        }

        private void rbtnincendio_CheckedChanged(object sender, EventArgs e)
        {
            cbxincendio.Enabled = true;
            cbxlesion.SelectedIndex = -1;
            cbxaccidente.SelectedIndex = -1;
            cbxrescate.SelectedIndex = -1;
            cbxfallecimiento.SelectedIndex = -1;

            if (rbtnaccidente.Checked == true || rbtnfallecidos.Checked == true || rbtnlesion.Checked == true || rbtnrescate.Checked == true)
            {
                cbxincendio.Enabled = false;
                
            }
        }

        private void rbtnfallecidos_CheckedChanged(object sender, EventArgs e)
        {
            cbxfallecimiento.Enabled = true;
            cbxlesion.SelectedIndex = -1;
            cbxaccidente.SelectedIndex = -1;
            cbxrescate.SelectedIndex = -1;
            cbxincendio.SelectedIndex = -1;

            if (rbtnaccidente.Checked == true || rbtnlesion.Checked == true || rbtnincendio.Checked == true || rbtnrescate.Checked == true)
            {
                cbxfallecimiento.Enabled = false;
                
            }
        }

        private void fecha_Load(object sender, EventArgs e)
        {
            //Para cbxlesion
            cbxlesion.Items.Clear();
            cbxlesion.Items.Add("Arma de Fuego");
            cbxlesion.Items.Add("Arma Contundente");
            cbxlesion.Items.Add("Accidente de Tránsito");
            cbxlesion.Items.Add("Arma Blanca");
            cbxlesion.Items.Add("Quemado por Polvora");
            cbxlesion.Items.Add("Quemado por Otras Causas");
            cbxlesion.Items.Add("Politraumatismo");
            cbxlesion.Items.Add("Fracturas");
            cbxlesion.Items.Add("Intoxicaciones");
            cbxlesion.Items.Add("Picaduras");
            cbxlesion.Items.Add("Mordedura");

            //Para cbxaccidente
            cbxaccidente.Items.Clear();
            cbxaccidente.Items.Add("Terrestre");
            cbxaccidente.Items.Add("Acuatico");
            cbxaccidente.Items.Add("Aéreos");
            cbxaccidente.Items.Add("Laborales");

            //Para cbxrescate
            cbxrescate.Items.Clear();
            cbxrescate.Items.Add("Simples");
            cbxrescate.Items.Add("Profundos");
            cbxrescate.Items.Add("Aéreos");
            cbxrescate.Items.Add("Urbanos");
            cbxrescate.Items.Add("Montaña");
            cbxrescate.Items.Add("Vehículo");
            cbxrescate.Items.Add("Recuperación de Cadaveres");
            cbxrescate.Items.Add("Otros");

            //Para cbxincendio
            cbxincendio.Items.Clear();
            cbxincendio.Items.Add("Forestales");
            cbxincendio.Items.Add("Estructural");
            cbxincendio.Items.Add("Vehículo");
            cbxincendio.Items.Add("Maleza Seca");
            cbxincendio.Items.Add("Tambo de Gas");


            //Para cbxfallecimiento
            cbxfallecimiento.Items.Clear();
            cbxfallecimiento.Items.Add("Asfixia por Inmersión");
            cbxfallecimiento.Items.Add("Accidente de Tránsito");
            cbxfallecimiento.Items.Add("Arma de Fuego");
            cbxfallecimiento.Items.Add("Arma Blanca");
            cbxfallecimiento.Items.Add("Otras Causas");

        }

        private void txtlimpiar_Click(object sender, EventArgs e)
        {
            cbxlesion.SelectedIndex = -1;
            cbxrescate.SelectedIndex = -1;
            cbxincendio.SelectedIndex = -1;
            cbxfallecimiento.SelectedIndex = -1;
            cbxaccidente.SelectedIndex = -1;
            rbtnlesion.Checked = false;
            rbtnrescate.Checked = false;
            rbtnincendio.Checked = false;
            rbtnfallecidos.Checked = false;
            rbtnaccidente.Checked = false;
            cbxlesion.Enabled = false;
            cbxaccidente.Enabled = false;
            cbxrescate.Enabled = false;
            cbxincendio.Enabled = false;
            cbxfallecimiento.Enabled = false;
        }
    }



}

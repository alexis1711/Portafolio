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
    public partial class frm_Accidentes : Form
    {
        public frm_Accidentes()
        {
            InitializeComponent();
        }

        private void frm_Accidentes_Load(object sender, EventArgs e)
        {
            //Para cbxaccidente
            cbxaccidente.Items.Clear();
            cbxaccidente.Items.Add("Terrestre");
            cbxaccidente.Items.Add("Acuatico");
            cbxaccidente.Items.Add("Aéreos");
            cbxaccidente.Items.Add("Laborales");
        }

       
    }
}

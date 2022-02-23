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
    public partial class frm_emergencias : Form
    {
        public frm_emergencias()
        {
            InitializeComponent();
        }


        private void AbrirFecha(object FormFecha)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            {
                Form fa = FormFecha as Form;
                fa.TopLevel = false;
                fa.Dock = DockStyle.Fill;
                this.PanelContenedor.Controls.Add(fa);
                this.PanelContenedor.Tag = fa;
                fa.Show();

            }  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFecha(new frm_Fecha());
        }

        private void AbrirGenero(object FormFecha)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            {
                Form fa = FormFecha as Form;
                fa.TopLevel = false;
                fa.Dock = DockStyle.Fill;
                this.PanelContenedor.Controls.Add(fa);
                this.PanelContenedor.Tag = fa;
                fa.Show();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirGenero(new frm_Genero());
        }

        private void AbrirTipos(object FormTipo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            {
                Form fa = FormTipo as Form;
                fa.TopLevel = false;
                fa.Dock = DockStyle.Fill;
                this.PanelContenedor.Controls.Add(fa);
                this.PanelContenedor.Tag = fa;
                fa.Show();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirTipos(new frm_TipoAcc());
        }
    }
}

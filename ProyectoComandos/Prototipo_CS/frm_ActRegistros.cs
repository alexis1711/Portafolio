using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prototipo_CS
{
    public partial class frm_ActRegistros : Form
    {
        Paciente PacienteDGV = new Paciente();


        public frm_ActRegistros()
        {
            InitializeComponent();

        }

        #region Abrir Form General

        private void btnactualizar_Click(object sender, EventArgs e)
        {

            frm_General abrir = new frm_General(PacienteDGV);
            abrir.Show();
            /*
            frm_General frm1 = new frm_General(PacienteDGV);
            frm_Datos frm = new frm_Datos(frm1);
            frm.Show();*/
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
           /* SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Pacientes", sCn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvactulizar.DataSource = dtbl;
            conn.Close();*/

        }

    
        private void dgvactulizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow seleccion = dgvactulizar.Rows[index];
            txtcorrelativo.Text = seleccion.Cells[0].Value.ToString();

            PacienteDGV.CodigoPaciente = seleccion.Cells[0].Value.ToString();
            PacienteDGV.PrimerNombre = seleccion.Cells[1].Value.ToString();
            PacienteDGV.SegundoNombre = seleccion.Cells[2].Value.ToString();
            PacienteDGV.PrimerApellido = seleccion.Cells[3].Value.ToString();
            PacienteDGV.SegundoApellido = seleccion.Cells[4].Value.ToString();
            PacienteDGV.Direccion = seleccion.Cells[5].Value.ToString();
            PacienteDGV.Genero = seleccion.Cells[6].Value.ToString();
            PacienteDGV.Edad = int.Parse(seleccion.Cells[7].Value.ToString());
            PacienteDGV.Telefono = seleccion.Cells[8].Value.ToString();
            PacienteDGV.NombreAcompañante = seleccion.Cells[9].Value.ToString();
            PacienteDGV.Parentesco = seleccion.Cells[10].Value.ToString();
            PacienteDGV.LugarIncidente = seleccion.Cells[11].Value.ToString();
            PacienteDGV.Diagnostico = seleccion.Cells[12].Value.ToString();


            frm_General frm = new frm_General(PacienteDGV);

//<<<<<<< HEAD

//=======
            
         /*  conn.Open();
            SqlCommand command = new SqlCommand("Select * from Emergencias where CodigoPaciente = '" + PacienteDGV.CodigoPaciente + "'", conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                EmergenciaDGV.Fecha = reader["Fecha"].ToString().Trim();
                EmergenciaDGV.CodigoPaciente = reader["CodigoPaciente"].ToString().Trim();
                EmergenciaDGV.CodigoCategoria = reader["CodCategoria"].ToString().Trim();
                EmergenciaDGV.CodigoEmergencia = reader["CodEmergencia"].ToString().Trim();
                EmergenciaDGV.TipoLlamada = reader["TipoLlamada"].ToString().Trim();
                EmergenciaDGV.FrecuenciaCardiaca = int.Parse(reader["FrecuenciaCardiaca"].ToString());
                EmergenciaDGV.FrecuenciaRespiratoria = int.Parse(reader["FrecuenciaRespiratoria"].ToString());
                EmergenciaDGV.PresionArterial = int.Parse(reader["PresionArterial"].ToString().Trim());
                EmergenciaDGV.Temperatura = int.Parse(reader["Temperatura"].ToString().Trim());
                EmergenciaDGV.SaturacionOxigeno = int.Parse(reader["SaturacionOxige"].ToString().Trim());
               
                EmergenciaDGV.Empleado = reader["Empleado"].ToString().Trim();
                EmergenciaDGV.CodigoUnidad = reader["CodigoUnidad"].ToString().Trim();
                
                EmergenciaDGV.HoraLlegada = reader["HoraLlegada"].ToString().Trim();
                EmergenciaDGV.Observaciones = reader["Observaciones"].ToString().Trim();
            }
            
            conn.Close();
           */

        }

       
    }
}

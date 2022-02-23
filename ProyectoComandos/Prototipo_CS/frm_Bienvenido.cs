﻿using System;
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
    public partial class frm_Bienvenido : Form
    {
        public frm_Bienvenido()
        {
            InitializeComponent();
        }

        //Abrir regiones en "+" para ver cada una

        #region Timers Fade In , Fade Out
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;                 
            progressBar1.Value += 1;
                        
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
                  
         }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                frm_Datos abrir = new frm_Datos();
                abrir.Show();
                this.Close();                
            }
        }

        #endregion 

        private void Bienvenido_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
        }
}

}
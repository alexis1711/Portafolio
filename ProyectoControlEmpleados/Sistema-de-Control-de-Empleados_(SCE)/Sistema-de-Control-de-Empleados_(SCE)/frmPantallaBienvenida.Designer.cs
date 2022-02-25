namespace Sistema_de_Control_de_Empleados__SCE_
{
    partial class frmPantallaBienvenida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantallaBienvenida));
            this.pnTop = new System.Windows.Forms.Panel();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.pntitulo = new System.Windows.Forms.Panel();
            this.lblUdb1 = new System.Windows.Forms.Label();
            this.lblUdb2 = new System.Windows.Forms.Label();
            this.pcbUdb = new System.Windows.Forms.PictureBox();
            this.lblEdgard = new System.Windows.Forms.Label();
            this.lblByron = new System.Windows.Forms.Label();
            this.lblAlexis = new System.Windows.Forms.Label();
            this.lblRoberto = new System.Windows.Forms.Label();
            this.lblGissela = new System.Windows.Forms.Label();
            this.tmCarga = new System.Windows.Forms.Timer(this.components);
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.pntitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUdb)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.ForestGreen;
            this.pnTop.Controls.Add(this.lblTitulo2);
            this.pnTop.Controls.Add(this.pcbLogo);
            this.pnTop.Controls.Add(this.lblTitulo1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.ForeColor = System.Drawing.Color.Black;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(454, 86);
            this.pnTop.TabIndex = 2;
            this.pnTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.White;
            this.lblTitulo2.Location = new System.Drawing.Point(12, 41);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(285, 32);
            this.lblTitulo2.TabIndex = 100004;
            this.lblTitulo2.Text = "de Empleados (SCP)";
            this.lblTitulo2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // pcbLogo
            // 
            this.pcbLogo.Location = new System.Drawing.Point(347, 0);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(86, 86);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 100002;
            this.pcbLogo.TabStop = false;
            this.pcbLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.ForeColor = System.Drawing.Color.White;
            this.lblTitulo1.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(285, 32);
            this.lblTitulo1.TabIndex = 100001;
            this.lblTitulo1.Text = "Sistema de Control";
            this.lblTitulo1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // pntitulo
            // 
            this.pntitulo.BackColor = System.Drawing.Color.DarkGray;
            this.pntitulo.Controls.Add(this.lblUdb1);
            this.pntitulo.Controls.Add(this.lblUdb2);
            this.pntitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pntitulo.Location = new System.Drawing.Point(0, 86);
            this.pntitulo.Name = "pntitulo";
            this.pntitulo.Size = new System.Drawing.Size(454, 51);
            this.pntitulo.TabIndex = 100008;
            this.pntitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // lblUdb1
            // 
            this.lblUdb1.AutoSize = true;
            this.lblUdb1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUdb1.Location = new System.Drawing.Point(136, 7);
            this.lblUdb1.Name = "lblUdb1";
            this.lblUdb1.Size = new System.Drawing.Size(176, 18);
            this.lblUdb1.TabIndex = 100004;
            this.lblUdb1.Text = "Universidad Don Bosco";
            this.lblUdb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUdb1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // lblUdb2
            // 
            this.lblUdb2.AutoSize = true;
            this.lblUdb2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUdb2.Location = new System.Drawing.Point(67, 26);
            this.lblUdb2.Name = "lblUdb2";
            this.lblUdb2.Size = new System.Drawing.Size(328, 18);
            this.lblUdb2.TabIndex = 100005;
            this.lblUdb2.Text = "Ingeniería en Ciencias de la Computación";
            this.lblUdb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUdb2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // pcbUdb
            // 
            this.pcbUdb.BackColor = System.Drawing.Color.DarkGray;
            this.pcbUdb.Location = new System.Drawing.Point(31, 156);
            this.pcbUdb.Name = "pcbUdb";
            this.pcbUdb.Size = new System.Drawing.Size(125, 125);
            this.pcbUdb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUdb.TabIndex = 100009;
            this.pcbUdb.TabStop = false;
            this.pcbUdb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // lblEdgard
            // 
            this.lblEdgard.AutoSize = true;
            this.lblEdgard.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdgard.Location = new System.Drawing.Point(188, 179);
            this.lblEdgard.Name = "lblEdgard";
            this.lblEdgard.Size = new System.Drawing.Size(245, 15);
            this.lblEdgard.TabIndex = 100014;
            this.lblEdgard.Text = "Barrera Flamenco, Edgard Alexander";
            this.lblEdgard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // lblByron
            // 
            this.lblByron.AutoSize = true;
            this.lblByron.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblByron.Location = new System.Drawing.Point(188, 151);
            this.lblByron.Name = "lblByron";
            this.lblByron.Size = new System.Drawing.Size(210, 15);
            this.lblByron.TabIndex = 100013;
            this.lblByron.Text = "Aguillón Amaya, Byron Enrique";
            this.lblByron.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // lblAlexis
            // 
            this.lblAlexis.AutoSize = true;
            this.lblAlexis.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlexis.Location = new System.Drawing.Point(188, 210);
            this.lblAlexis.Name = "lblAlexis";
            this.lblAlexis.Size = new System.Drawing.Size(224, 15);
            this.lblAlexis.TabIndex = 100015;
            this.lblAlexis.Text = "Cornejo Hernández, Alexis Josué";
            this.lblAlexis.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // lblRoberto
            // 
            this.lblRoberto.AutoSize = true;
            this.lblRoberto.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoberto.Location = new System.Drawing.Point(188, 238);
            this.lblRoberto.Name = "lblRoberto";
            this.lblRoberto.Size = new System.Drawing.Size(189, 15);
            this.lblRoberto.TabIndex = 100016;
            this.lblRoberto.Text = "Portal Gómez, Roberto José";
            this.lblRoberto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // lblGissela
            // 
            this.lblGissela.AutoSize = true;
            this.lblGissela.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGissela.Location = new System.Drawing.Point(188, 268);
            this.lblGissela.Name = "lblGissela";
            this.lblGissela.Size = new System.Drawing.Size(224, 15);
            this.lblGissela.TabIndex = 100012;
            this.lblGissela.Text = "Serrano López, Gissela Verenice";
            this.lblGissela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // tmCarga
            // 
            this.tmCarga.Enabled = true;
            this.tmCarga.Interval = 3000;
            this.tmCarga.Tick += new System.EventHandler(this.tmCarga_Tick);
            // 
            // frmPantallaBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(454, 299);
            this.ControlBox = false;
            this.Controls.Add(this.lblRoberto);
            this.Controls.Add(this.lblAlexis);
            this.Controls.Add(this.lblEdgard);
            this.Controls.Add(this.lblByron);
            this.Controls.Add(this.lblGissela);
            this.Controls.Add(this.pcbUdb);
            this.Controls.Add(this.pntitulo);
            this.Controls.Add(this.pnTop);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPantallaBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPantallaBienvenida";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.pntitulo.ResumeLayout(false);
            this.pntitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUdb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Panel pntitulo;
        private System.Windows.Forms.Label lblUdb1;
        private System.Windows.Forms.Label lblUdb2;
        private System.Windows.Forms.PictureBox pcbUdb;
        private System.Windows.Forms.Label lblEdgard;
        private System.Windows.Forms.Label lblByron;
        private System.Windows.Forms.Label lblAlexis;
        private System.Windows.Forms.Label lblRoberto;
        private System.Windows.Forms.Label lblGissela;
        private System.Windows.Forms.Timer tmCarga;
    }
}
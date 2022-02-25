namespace Sistema_de_Control_de_Empleados__SCE_
{
    partial class frmAdminsPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminsPrincipal));
            this.pnTitulo = new System.Windows.Forms.Panel();
            this.lblTitPuesto = new System.Windows.Forms.Label();
            this.lblTitArea = new System.Windows.Forms.Label();
            this.lblTitNombre = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnOpc = new System.Windows.Forms.Panel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnActualidad = new System.Windows.Forms.Button();
            this.btnSolicitud = new System.Windows.Forms.Button();
            this.btnAreaPuesto = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pnMostrar = new System.Windows.Forms.Panel();
            this.pnTitulo.SuspendLayout();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.pnOpc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitulo
            // 
            this.pnTitulo.BackColor = System.Drawing.Color.DarkGray;
            this.pnTitulo.Controls.Add(this.lblTitPuesto);
            this.pnTitulo.Controls.Add(this.lblTitArea);
            this.pnTitulo.Controls.Add(this.lblTitNombre);
            this.pnTitulo.Controls.Add(this.lblP);
            this.pnTitulo.Controls.Add(this.lblA);
            this.pnTitulo.Controls.Add(this.lblBienvenido);
            this.pnTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitulo.Location = new System.Drawing.Point(0, 35);
            this.pnTitulo.Name = "pnTitulo";
            this.pnTitulo.Size = new System.Drawing.Size(1143, 62);
            this.pnTitulo.TabIndex = 9;
            this.pnTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // lblTitPuesto
            // 
            this.lblTitPuesto.AutoSize = true;
            this.lblTitPuesto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitPuesto.ForeColor = System.Drawing.Color.Black;
            this.lblTitPuesto.Location = new System.Drawing.Point(489, 32);
            this.lblTitPuesto.Name = "lblTitPuesto";
            this.lblTitPuesto.Size = new System.Drawing.Size(63, 19);
            this.lblTitPuesto.TabIndex = 100008;
            this.lblTitPuesto.Text = "Puesto";
            this.lblTitPuesto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // lblTitArea
            // 
            this.lblTitArea.AutoSize = true;
            this.lblTitArea.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitArea.ForeColor = System.Drawing.Color.Black;
            this.lblTitArea.Location = new System.Drawing.Point(86, 32);
            this.lblTitArea.Name = "lblTitArea";
            this.lblTitArea.Size = new System.Drawing.Size(45, 19);
            this.lblTitArea.TabIndex = 100007;
            this.lblTitArea.Text = "Area";
            this.lblTitArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // lblTitNombre
            // 
            this.lblTitNombre.AutoSize = true;
            this.lblTitNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitNombre.ForeColor = System.Drawing.Color.Black;
            this.lblTitNombre.Location = new System.Drawing.Point(132, 5);
            this.lblTitNombre.Name = "lblTitNombre";
            this.lblTitNombre.Size = new System.Drawing.Size(144, 19);
            this.lblTitNombre.TabIndex = 100006;
            this.lblTitNombre.Text = "Nombre Completo";
            this.lblTitNombre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.ForeColor = System.Drawing.Color.Black;
            this.lblP.Location = new System.Drawing.Point(412, 30);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(80, 22);
            this.lblP.TabIndex = 100003;
            this.lblP.Text = "Puesto:";
            this.lblP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.Black;
            this.lblA.Location = new System.Drawing.Point(29, 30);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(60, 22);
            this.lblA.TabIndex = 100002;
            this.lblA.Text = "Área:";
            this.lblA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.Black;
            this.lblBienvenido.Location = new System.Drawing.Point(12, 3);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(130, 22);
            this.lblBienvenido.TabIndex = 100001;
            this.lblBienvenido.Text = "Bienvenido: ";
            this.lblBienvenido.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.ForestGreen;
            this.pnTop.Controls.Add(this.pcbLogo);
            this.pnTop.Controls.Add(this.lblTitulo);
            this.pnTop.Controls.Add(this.btnMin);
            this.pnTop.Controls.Add(this.btnExit);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.ForeColor = System.Drawing.Color.Black;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1143, 35);
            this.pnTop.TabIndex = 8;
            this.pnTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // pcbLogo
            // 
            this.pcbLogo.Location = new System.Drawing.Point(3, 0);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(35, 35);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 100002;
            this.pcbLogo.TabStop = false;
            this.pcbLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(44, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(380, 22);
            this.lblTitulo.TabIndex = 100001;
            this.lblTitulo.Text = "Sistema de Control de Empleados (SCP)";
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMin.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnMin.Location = new System.Drawing.Point(1073, 1);
            this.btnMin.Margin = new System.Windows.Forms.Padding(0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(35, 35);
            this.btnMin.TabIndex = 100000;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnExit.Location = new System.Drawing.Point(1108, 1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 100000;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnOpc
            // 
            this.pnOpc.BackColor = System.Drawing.Color.DarkGray;
            this.pnOpc.Controls.Add(this.btnPerfil);
            this.pnOpc.Controls.Add(this.btnActualidad);
            this.pnOpc.Controls.Add(this.btnSolicitud);
            this.pnOpc.Controls.Add(this.btnAreaPuesto);
            this.pnOpc.Controls.Add(this.btnCerrarSesion);
            this.pnOpc.Controls.Add(this.btnHorarios);
            this.pnOpc.Controls.Add(this.btnEmpleados);
            this.pnOpc.Controls.Add(this.btnAdmin);
            this.pnOpc.Location = new System.Drawing.Point(16, 103);
            this.pnOpc.Name = "pnOpc";
            this.pnOpc.Size = new System.Drawing.Size(153, 528);
            this.pnOpc.TabIndex = 10;
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPerfil.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Location = new System.Drawing.Point(0, 306);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(153, 51);
            this.btnPerfil.TabIndex = 8;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnActualidad
            // 
            this.btnActualidad.BackColor = System.Drawing.Color.ForestGreen;
            this.btnActualidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActualidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualidad.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualidad.ForeColor = System.Drawing.Color.White;
            this.btnActualidad.Location = new System.Drawing.Point(0, 255);
            this.btnActualidad.Name = "btnActualidad";
            this.btnActualidad.Size = new System.Drawing.Size(153, 51);
            this.btnActualidad.TabIndex = 7;
            this.btnActualidad.Text = "Bitacora";
            this.btnActualidad.UseVisualStyleBackColor = false;
            this.btnActualidad.Click += new System.EventHandler(this.btnActualidad_Click);
            // 
            // btnSolicitud
            // 
            this.btnSolicitud.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSolicitud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolicitud.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSolicitud.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitud.ForeColor = System.Drawing.Color.White;
            this.btnSolicitud.Location = new System.Drawing.Point(0, 204);
            this.btnSolicitud.Name = "btnSolicitud";
            this.btnSolicitud.Size = new System.Drawing.Size(153, 51);
            this.btnSolicitud.TabIndex = 6;
            this.btnSolicitud.Text = "Solicitud";
            this.btnSolicitud.UseVisualStyleBackColor = false;
            this.btnSolicitud.Click += new System.EventHandler(this.btnSolicitud_Click);
            // 
            // btnAreaPuesto
            // 
            this.btnAreaPuesto.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAreaPuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAreaPuesto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAreaPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAreaPuesto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaPuesto.ForeColor = System.Drawing.Color.White;
            this.btnAreaPuesto.Location = new System.Drawing.Point(0, 153);
            this.btnAreaPuesto.Name = "btnAreaPuesto";
            this.btnAreaPuesto.Size = new System.Drawing.Size(153, 51);
            this.btnAreaPuesto.TabIndex = 4;
            this.btnAreaPuesto.Text = "Áreas / Puestos";
            this.btnAreaPuesto.UseVisualStyleBackColor = false;
            this.btnAreaPuesto.Click += new System.EventHandler(this.btnAreaPuesto_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 477);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(153, 51);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btcerrars_Click);
            // 
            // btnHorarios
            // 
            this.btnHorarios.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHorarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHorarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHorarios.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorarios.ForeColor = System.Drawing.Color.White;
            this.btnHorarios.Location = new System.Drawing.Point(0, 102);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(153, 51);
            this.btnHorarios.TabIndex = 3;
            this.btnHorarios.Text = "Horarios";
            this.btnHorarios.UseVisualStyleBackColor = false;
            this.btnHorarios.Click += new System.EventHandler(this.btnHorarios_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmpleados.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 51);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(153, 51);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdmin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(0, 0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(153, 51);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // pnMostrar
            // 
            this.pnMostrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMostrar.Location = new System.Drawing.Point(175, 103);
            this.pnMostrar.Name = "pnMostrar";
            this.pnMostrar.Size = new System.Drawing.Size(956, 528);
            this.pnMostrar.TabIndex = 11;
            // 
            // frmAdminsPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1143, 643);
            this.Controls.Add(this.pnMostrar);
            this.Controls.Add(this.pnOpc);
            this.Controls.Add(this.pnTitulo);
            this.Controls.Add(this.pnTop);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminsPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminsPrincipal";
            this.Load += new System.EventHandler(this.frmAdminsPrincipal_Load);
            this.pnTitulo.ResumeLayout(false);
            this.pnTitulo.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.pnOpc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitulo;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitPuesto;
        private System.Windows.Forms.Label lblTitArea;
        private System.Windows.Forms.Label lblTitNombre;
        private System.Windows.Forms.Panel pnOpc;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnActualidad;
        private System.Windows.Forms.Button btnSolicitud;
        private System.Windows.Forms.Button btnAreaPuesto;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel pnMostrar;
    }
}
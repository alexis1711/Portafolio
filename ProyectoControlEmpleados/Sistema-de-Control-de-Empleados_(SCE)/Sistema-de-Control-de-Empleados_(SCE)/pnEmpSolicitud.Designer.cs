namespace Sistema_de_Control_de_Empleados__SCE_
{
    partial class pnEmpSolicitud
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnEmpSolicitud));
            this.lblSoliTot = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnEnvSoli = new System.Windows.Forms.Button();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblSoli = new System.Windows.Forms.Label();
            this.txtIdSolicitud = new System.Windows.Forms.TextBox();
            this.lblAccion = new System.Windows.Forms.Label();
            this.lblBuscarA = new System.Windows.Forms.Label();
            this.txtBuscarSolicitud = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvSolicitud = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoliTot
            // 
            this.lblSoliTot.AutoSize = true;
            this.lblSoliTot.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoliTot.Location = new System.Drawing.Point(536, 43);
            this.lblSoliTot.Name = "lblSoliTot";
            this.lblSoliTot.Size = new System.Drawing.Size(198, 19);
            this.lblSoliTot.TabIndex = 100035;
            this.lblSoliTot.Text = "Todas las solicitudes";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpFecha.Location = new System.Drawing.Point(127, 316);
            this.dtpFecha.MinDate = new System.DateTime(1755, 7, 17, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(249, 20);
            this.dtpFecha.TabIndex = 100033;
            this.dtpFecha.Value = new System.DateTime(2020, 12, 25, 23, 59, 59, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(27, 292);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(198, 19);
            this.lblFecha.TabIndex = 100032;
            this.lblFecha.Text = "Fecha a pedir permiso";
            // 
            // btnEnvSoli
            // 
            this.btnEnvSoli.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEnvSoli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnvSoli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnvSoli.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvSoli.ForeColor = System.Drawing.Color.White;
            this.btnEnvSoli.Location = new System.Drawing.Point(31, 376);
            this.btnEnvSoli.Name = "btnEnvSoli";
            this.btnEnvSoli.Size = new System.Drawing.Size(172, 33);
            this.btnEnvSoli.TabIndex = 100031;
            this.btnEnvSoli.Text = "Enviar Solicitud";
            this.btnEnvSoli.UseVisualStyleBackColor = false;
            this.btnEnvSoli.Click += new System.EventHandler(this.btnEnvSoli_Click);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(27, 49);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(108, 19);
            this.lblMotivo.TabIndex = 100030;
            this.lblMotivo.Text = "Descripción";
            // 
            // txtMotivo
            // 
            this.txtMotivo.BackColor = System.Drawing.Color.White;
            this.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotivo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.ForeColor = System.Drawing.Color.Black;
            this.txtMotivo.Location = new System.Drawing.Point(31, 78);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(345, 207);
            this.txtMotivo.TabIndex = 100029;
            // 
            // lblSoli
            // 
            this.lblSoli.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lblSoli.AutoSize = true;
            this.lblSoli.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoli.ForeColor = System.Drawing.Color.Black;
            this.lblSoli.Location = new System.Drawing.Point(327, 9);
            this.lblSoli.Name = "lblSoli";
            this.lblSoli.Size = new System.Drawing.Size(240, 22);
            this.lblSoli.TabIndex = 100028;
            this.lblSoli.Text = "Solicitudes de permisos";
            // 
            // txtIdSolicitud
            // 
            this.txtIdSolicitud.BackColor = System.Drawing.Color.White;
            this.txtIdSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdSolicitud.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSolicitud.ForeColor = System.Drawing.Color.Black;
            this.txtIdSolicitud.Location = new System.Drawing.Point(182, 47);
            this.txtIdSolicitud.Name = "txtIdSolicitud";
            this.txtIdSolicitud.ReadOnly = true;
            this.txtIdSolicitud.Size = new System.Drawing.Size(43, 25);
            this.txtIdSolicitud.TabIndex = 100080;
            this.txtIdSolicitud.Text = "1";
            this.txtIdSolicitud.Visible = false;
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion.Location = new System.Drawing.Point(27, 345);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(288, 19);
            this.lblAccion.TabIndex = 100081;
            this.lblAccion.Text = "Solicitud: Aceptado / Rechazado";
            // 
            // lblBuscarA
            // 
            this.lblBuscarA.AutoSize = true;
            this.lblBuscarA.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarA.Location = new System.Drawing.Point(436, 78);
            this.lblBuscarA.Name = "lblBuscarA";
            this.lblBuscarA.Size = new System.Drawing.Size(63, 19);
            this.lblBuscarA.TabIndex = 100083;
            this.lblBuscarA.Text = "Buscar";
            // 
            // txtBuscarSolicitud
            // 
            this.txtBuscarSolicitud.BackColor = System.Drawing.Color.White;
            this.txtBuscarSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarSolicitud.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarSolicitud.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarSolicitud.Location = new System.Drawing.Point(525, 77);
            this.txtBuscarSolicitud.Name = "txtBuscarSolicitud";
            this.txtBuscarSolicitud.Size = new System.Drawing.Size(315, 25);
            this.txtBuscarSolicitud.TabIndex = 100082;
            this.txtBuscarSolicitud.TextChanged += new System.EventHandler(this.txtBuscarSolicitud_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(226, 376);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(126, 33);
            this.btnLimpiar.TabIndex = 100084;
            this.btnLimpiar.Text = "Limpiar Todo";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvSolicitud
            // 
            this.dgvSolicitud.AllowUserToAddRows = false;
            this.dgvSolicitud.AllowUserToDeleteRows = false;
            this.dgvSolicitud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSolicitud.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitud.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitud.EnableHeadersVisualStyles = false;
            this.dgvSolicitud.Location = new System.Drawing.Point(393, 108);
            this.dgvSolicitud.MultiSelect = false;
            this.dgvSolicitud.Name = "dgvSolicitud";
            this.dgvSolicitud.ReadOnly = true;
            this.dgvSolicitud.Size = new System.Drawing.Size(460, 309);
            this.dgvSolicitud.TabIndex = 100086;
            this.dgvSolicitud.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitud_CellDoubleClick);
            // 
            // pnEmpSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(865, 429);
            this.Controls.Add(this.dgvSolicitud);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblBuscarA);
            this.Controls.Add(this.txtBuscarSolicitud);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.txtIdSolicitud);
            this.Controls.Add(this.lblSoliTot);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnEnvSoli);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.lblSoli);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pnEmpSolicitud";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pnEmpSolicitud";
            this.Load += new System.EventHandler(this.pnEmpSolicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoliTot;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnEnvSoli;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblSoli;
        private System.Windows.Forms.TextBox txtIdSolicitud;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Label lblBuscarA;
        private System.Windows.Forms.TextBox txtBuscarSolicitud;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvSolicitud;
    }
}
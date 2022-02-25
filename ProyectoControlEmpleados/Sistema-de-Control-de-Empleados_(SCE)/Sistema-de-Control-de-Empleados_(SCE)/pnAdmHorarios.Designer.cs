namespace Sistema_de_Control_de_Empleados__SCE_
{
    partial class pnAdmHorarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnAdmHorarios));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nupCaja = new System.Windows.Forms.NumericUpDown();
            this.lblCaja = new System.Windows.Forms.Label();
            this.lblempleadosmuestra = new System.Windows.Forms.Label();
            this.txtBuscarEmpl = new System.Windows.Forms.TextBox();
            this.lblhorariomuestra = new System.Windows.Forms.Label();
            this.txtBuscarHorario = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.chbEspecial = new System.Windows.Forms.CheckBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.lblFin = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.lblInicial = new System.Windows.Forms.Label();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.txtIdHorario = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblBuscarH = new System.Windows.Forms.Label();
            this.lblBuscarE = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.dgvHorario = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AcceptsReturn = true;
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(189, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(266, 25);
            this.txtNombre.TabIndex = 100065;
            // 
            // nupCaja
            // 
            this.nupCaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupCaja.Location = new System.Drawing.Point(114, 151);
            this.nupCaja.Name = "nupCaja";
            this.nupCaja.Size = new System.Drawing.Size(120, 20);
            this.nupCaja.TabIndex = 100063;
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja.Location = new System.Drawing.Point(54, 148);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(54, 19);
            this.lblCaja.TabIndex = 100062;
            this.lblCaja.Text = "Caja:";
            this.lblCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblempleadosmuestra
            // 
            this.lblempleadosmuestra.AutoSize = true;
            this.lblempleadosmuestra.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempleadosmuestra.Location = new System.Drawing.Point(165, 192);
            this.lblempleadosmuestra.Name = "lblempleadosmuestra";
            this.lblempleadosmuestra.Size = new System.Drawing.Size(90, 19);
            this.lblempleadosmuestra.TabIndex = 100060;
            this.lblempleadosmuestra.Text = "Empleados";
            // 
            // txtBuscarEmpl
            // 
            this.txtBuscarEmpl.BackColor = System.Drawing.Color.White;
            this.txtBuscarEmpl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarEmpl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarEmpl.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarEmpl.Location = new System.Drawing.Point(126, 220);
            this.txtBuscarEmpl.Name = "txtBuscarEmpl";
            this.txtBuscarEmpl.Size = new System.Drawing.Size(299, 25);
            this.txtBuscarEmpl.TabIndex = 100059;
            this.txtBuscarEmpl.TextChanged += new System.EventHandler(this.txtBuscarEmpl_TextChanged);
            // 
            // lblhorariomuestra
            // 
            this.lblhorariomuestra.AutoSize = true;
            this.lblhorariomuestra.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhorariomuestra.Location = new System.Drawing.Point(681, 195);
            this.lblhorariomuestra.Name = "lblhorariomuestra";
            this.lblhorariomuestra.Size = new System.Drawing.Size(81, 19);
            this.lblhorariomuestra.TabIndex = 100056;
            this.lblhorariomuestra.Text = "Horarios";
            // 
            // txtBuscarHorario
            // 
            this.txtBuscarHorario.BackColor = System.Drawing.Color.White;
            this.txtBuscarHorario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarHorario.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarHorario.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarHorario.Location = new System.Drawing.Point(599, 220);
            this.txtBuscarHorario.Name = "txtBuscarHorario";
            this.txtBuscarHorario.Size = new System.Drawing.Size(329, 25);
            this.txtBuscarHorario.TabIndex = 100055;
            this.txtBuscarHorario.TextChanged += new System.EventHandler(this.txtBuscarHorario_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(822, 128);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 69);
            this.btnEliminar.TabIndex = 100054;
            this.btnEliminar.Text = "Eliminar ultimo dato en cola";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(718, 141);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 33);
            this.btnModificar.TabIndex = 100053;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // chbEspecial
            // 
            this.chbEspecial.AutoSize = true;
            this.chbEspecial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbEspecial.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEspecial.Location = new System.Drawing.Point(265, 148);
            this.chbEspecial.Name = "chbEspecial";
            this.chbEspecial.Size = new System.Drawing.Size(139, 22);
            this.chbEspecial.TabIndex = 100052;
            this.chbEspecial.Text = "Fecha especial";
            this.chbEspecial.UseVisualStyleBackColor = true;
            // 
            // dtpFin
            // 
            this.dtpFin.CalendarFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFin.CustomFormat = "hh:mm tt";
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFin.Location = new System.Drawing.Point(637, 106);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.ShowUpDown = true;
            this.dtpFin.Size = new System.Drawing.Size(100, 20);
            this.dtpFin.TabIndex = 100051;
            this.dtpFin.Value = new System.DateTime(2020, 3, 18, 0, 0, 0, 0);
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.Location = new System.Drawing.Point(496, 106);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(135, 19);
            this.lblFin.TabIndex = 100050;
            this.lblFin.Text = "Hora de Salida";
            this.lblFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpInicial
            // 
            this.dtpInicial.CalendarFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpInicial.CustomFormat = "hh:mm tt";
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicial.Location = new System.Drawing.Point(304, 107);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.ShowUpDown = true;
            this.dtpInicial.Size = new System.Drawing.Size(100, 20);
            this.dtpInicial.TabIndex = 100043;
            this.dtpInicial.Value = new System.DateTime(2020, 3, 18, 0, 0, 0, 0);
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicial.Location = new System.Drawing.Point(154, 107);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(144, 19);
            this.lblInicial.TabIndex = 100049;
            this.lblInicial.Text = "Hora de Entrada";
            this.lblInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDia
            // 
            this.cmbDia.BackColor = System.Drawing.Color.White;
            this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDia.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.cmbDia.Location = new System.Drawing.Point(637, 64);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(175, 26);
            this.cmbDia.TabIndex = 100042;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(595, 67);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(36, 19);
            this.lblDia.TabIndex = 100048;
            this.lblDia.Text = "Día";
            this.lblDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(39, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(144, 19);
            this.lblNombre.TabIndex = 100047;
            this.lblNombre.Text = "Nombre Completo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(627, 141);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 33);
            this.btnGuardar.TabIndex = 100044;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnguardarho_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.Black;
            this.lblHorario.Location = new System.Drawing.Point(340, 19);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(260, 22);
            this.lblHorario.TabIndex = 100045;
            this.lblHorario.Text = "Horarios de los empleados";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.BackColor = System.Drawing.Color.White;
            this.txtIdEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdEmpleado.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpleado.ForeColor = System.Drawing.Color.Black;
            this.txtIdEmpleado.Location = new System.Drawing.Point(78, 38);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.ReadOnly = true;
            this.txtIdEmpleado.Size = new System.Drawing.Size(43, 25);
            this.txtIdEmpleado.TabIndex = 100074;
            this.txtIdEmpleado.Text = "1";
            this.txtIdEmpleado.Visible = false;
            // 
            // txtIdHorario
            // 
            this.txtIdHorario.BackColor = System.Drawing.Color.White;
            this.txtIdHorario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdHorario.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdHorario.ForeColor = System.Drawing.Color.Black;
            this.txtIdHorario.Location = new System.Drawing.Point(875, 38);
            this.txtIdHorario.Name = "txtIdHorario";
            this.txtIdHorario.ReadOnly = true;
            this.txtIdHorario.Size = new System.Drawing.Size(43, 25);
            this.txtIdHorario.TabIndex = 100075;
            this.txtIdHorario.Text = "1";
            this.txtIdHorario.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(536, 136);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 52);
            this.btnLimpiar.TabIndex = 100077;
            this.btnLimpiar.Text = "Limpiar Todo";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblBuscarH
            // 
            this.lblBuscarH.AutoSize = true;
            this.lblBuscarH.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarH.Location = new System.Drawing.Point(524, 221);
            this.lblBuscarH.Name = "lblBuscarH";
            this.lblBuscarH.Size = new System.Drawing.Size(63, 19);
            this.lblBuscarH.TabIndex = 100081;
            this.lblBuscarH.Text = "Buscar";
            // 
            // lblBuscarE
            // 
            this.lblBuscarE.AutoSize = true;
            this.lblBuscarE.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarE.Location = new System.Drawing.Point(39, 221);
            this.lblBuscarE.Name = "lblBuscarE";
            this.lblBuscarE.Size = new System.Drawing.Size(63, 19);
            this.lblBuscarE.TabIndex = 100082;
            this.lblBuscarE.Text = "Buscar";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.EnableHeadersVisualStyles = false;
            this.dgvEmpleados.Location = new System.Drawing.Point(25, 265);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersWidth = 82;
            this.dgvEmpleados.Size = new System.Drawing.Size(448, 237);
            this.dgvEmpleados.TabIndex = 100085;
            this.dgvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellDoubleClick);
            // 
            // dgvHorario
            // 
            this.dgvHorario.AllowUserToAddRows = false;
            this.dgvHorario.AllowUserToDeleteRows = false;
            this.dgvHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorario.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorario.EnableHeadersVisualStyles = false;
            this.dgvHorario.Location = new System.Drawing.Point(496, 265);
            this.dgvHorario.MultiSelect = false;
            this.dgvHorario.Name = "dgvHorario";
            this.dgvHorario.ReadOnly = true;
            this.dgvHorario.RowHeadersWidth = 82;
            this.dgvHorario.Size = new System.Drawing.Size(448, 237);
            this.dgvHorario.TabIndex = 100086;
            this.dgvHorario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorario_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(416, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 100087;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnAdmHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(956, 528);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvHorario);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.lblBuscarE);
            this.Controls.Add(this.lblBuscarH);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtIdHorario);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.nupCaja);
            this.Controls.Add(this.lblCaja);
            this.Controls.Add(this.lblempleadosmuestra);
            this.Controls.Add(this.txtBuscarEmpl);
            this.Controls.Add(this.lblhorariomuestra);
            this.Controls.Add(this.txtBuscarHorario);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.chbEspecial);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.dtpInicial);
            this.Controls.Add(this.lblInicial);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblHorario);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pnAdmHorarios";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pnAdmHorarios";
            this.Load += new System.EventHandler(this.pnAdmHorarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown nupCaja;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.Label lblempleadosmuestra;
        private System.Windows.Forms.TextBox txtBuscarEmpl;
        private System.Windows.Forms.Label lblhorariomuestra;
        private System.Windows.Forms.TextBox txtBuscarHorario;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.CheckBox chbEspecial;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.TextBox txtIdHorario;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblBuscarH;
        private System.Windows.Forms.Label lblBuscarE;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridView dgvHorario;
        private System.Windows.Forms.Button button1;
    }
}
namespace Prototipo_CS
{
    partial class frm_Unidades
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnreestablecerhos = new System.Windows.Forms.Button();
            this.btnmodificarhos = new System.Windows.Forms.Button();
            this.rdbinactivohospitales = new System.Windows.Forms.RadioButton();
            this.rdbactivohospitales = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnregistrarhos = new System.Windows.Forms.Button();
            this.txtcodhos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnreestableceruni = new System.Windows.Forms.Button();
            this.btnmodificaruni = new System.Windows.Forms.Button();
            this.rdbinactivounidades = new System.Windows.Forms.RadioButton();
            this.btnregistrarunidad = new System.Windows.Forms.Button();
            this.txtcodigounidad = new System.Windows.Forms.TextBox();
            this.rdbactivounidades = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbApellido1 = new System.Windows.Forms.Label();
            this.txtplacas = new System.Windows.Forms.TextBox();
            this.lbNombre1 = new System.Windows.Forms.Label();
            this.rbtnunidad = new System.Windows.Forms.RadioButton();
            this.rbtnhos = new System.Windows.Forms.RadioButton();
            this.dgvunihos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvunihos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnreestablecerhos);
            this.groupBox2.Controls.Add(this.btnmodificarhos);
            this.groupBox2.Controls.Add(this.rdbinactivohospitales);
            this.groupBox2.Controls.Add(this.rdbactivohospitales);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnregistrarhos);
            this.groupBox2.Controls.Add(this.txtcodhos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtnombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 184);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hospitales";
            // 
            // btnreestablecerhos
            // 
            this.btnreestablecerhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreestablecerhos.Location = new System.Drawing.Point(130, 136);
            this.btnreestablecerhos.Name = "btnreestablecerhos";
            this.btnreestablecerhos.Size = new System.Drawing.Size(110, 27);
            this.btnreestablecerhos.TabIndex = 68;
            this.btnreestablecerhos.Text = "Reestablecer";
            this.btnreestablecerhos.UseVisualStyleBackColor = true;
            this.btnreestablecerhos.Click += new System.EventHandler(this.btnreestablecerhos_Click);
            // 
            // btnmodificarhos
            // 
            this.btnmodificarhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificarhos.Location = new System.Drawing.Point(196, 103);
            this.btnmodificarhos.Name = "btnmodificarhos";
            this.btnmodificarhos.Size = new System.Drawing.Size(79, 27);
            this.btnmodificarhos.TabIndex = 67;
            this.btnmodificarhos.Text = "Modificar";
            this.btnmodificarhos.UseVisualStyleBackColor = true;
            // 
            // rdbinactivohospitales
            // 
            this.rdbinactivohospitales.AutoSize = true;
            this.rdbinactivohospitales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbinactivohospitales.Location = new System.Drawing.Point(11, 136);
            this.rdbinactivohospitales.Name = "rdbinactivohospitales";
            this.rdbinactivohospitales.Size = new System.Drawing.Size(72, 20);
            this.rdbinactivohospitales.TabIndex = 66;
            this.rdbinactivohospitales.TabStop = true;
            this.rdbinactivohospitales.Text = "Inactivo";
            this.rdbinactivohospitales.UseVisualStyleBackColor = true;
            this.rdbinactivohospitales.Click += new System.EventHandler(this.rdbinactivohospitales_Click);
            // 
            // rdbactivohospitales
            // 
            this.rdbactivohospitales.AutoSize = true;
            this.rdbactivohospitales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbactivohospitales.Location = new System.Drawing.Point(11, 110);
            this.rdbactivohospitales.Name = "rdbactivohospitales";
            this.rdbactivohospitales.Size = new System.Drawing.Size(63, 20);
            this.rdbactivohospitales.TabIndex = 65;
            this.rdbactivohospitales.TabStop = true;
            this.rdbactivohospitales.Text = "Activo";
            this.rdbactivohospitales.UseVisualStyleBackColor = true;
            this.rdbactivohospitales.Click += new System.EventHandler(this.rdbactivohospitales_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 64;
            this.label5.Text = "Estado:\n";
            // 
            // btnregistrarhos
            // 
            this.btnregistrarhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrarhos.Location = new System.Drawing.Point(107, 103);
            this.btnregistrarhos.Name = "btnregistrarhos";
            this.btnregistrarhos.Size = new System.Drawing.Size(83, 27);
            this.btnregistrarhos.TabIndex = 57;
            this.btnregistrarhos.Text = "Registrar";
            this.btnregistrarhos.UseVisualStyleBackColor = true;
            this.btnregistrarhos.Click += new System.EventHandler(this.btnregistrarhos_Click);
            // 
            // txtcodhos
            // 
            this.txtcodhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodhos.Location = new System.Drawing.Point(65, 17);
            this.txtcodhos.Name = "txtcodhos";
            this.txtcodhos.Size = new System.Drawing.Size(106, 22);
            this.txtcodhos.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Codigo:\n";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(66, 56);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(236, 22);
            this.txtnombre.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnreestableceruni);
            this.groupBox1.Controls.Add(this.btnmodificaruni);
            this.groupBox1.Controls.Add(this.rdbinactivounidades);
            this.groupBox1.Controls.Add(this.btnregistrarunidad);
            this.groupBox1.Controls.Add(this.txtcodigounidad);
            this.groupBox1.Controls.Add(this.rdbactivounidades);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbApellido1);
            this.groupBox1.Controls.Add(this.txtplacas);
            this.groupBox1.Controls.Add(this.lbNombre1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 215);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unidades";
            // 
            // btnreestableceruni
            // 
            this.btnreestableceruni.Location = new System.Drawing.Point(134, 169);
            this.btnreestableceruni.Name = "btnreestableceruni";
            this.btnreestableceruni.Size = new System.Drawing.Size(106, 28);
            this.btnreestableceruni.TabIndex = 65;
            this.btnreestableceruni.Text = "Reestablecer";
            this.btnreestableceruni.UseVisualStyleBackColor = true;
            this.btnreestableceruni.Click += new System.EventHandler(this.btnreestableceruni_Click);
            // 
            // btnmodificaruni
            // 
            this.btnmodificaruni.Location = new System.Drawing.Point(190, 138);
            this.btnmodificaruni.Name = "btnmodificaruni";
            this.btnmodificaruni.Size = new System.Drawing.Size(87, 25);
            this.btnmodificaruni.TabIndex = 64;
            this.btnmodificaruni.Text = "Modificar";
            this.btnmodificaruni.UseVisualStyleBackColor = true;
            // 
            // rdbinactivounidades
            // 
            this.rdbinactivounidades.AutoSize = true;
            this.rdbinactivounidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbinactivounidades.Location = new System.Drawing.Point(9, 186);
            this.rdbinactivounidades.Name = "rdbinactivounidades";
            this.rdbinactivounidades.Size = new System.Drawing.Size(72, 20);
            this.rdbinactivounidades.TabIndex = 63;
            this.rdbinactivounidades.TabStop = true;
            this.rdbinactivounidades.Text = "Inactivo";
            this.rdbinactivounidades.UseVisualStyleBackColor = true;
            this.rdbinactivounidades.Click += new System.EventHandler(this.rdbinactivounidades_Click);
            // 
            // btnregistrarunidad
            // 
            this.btnregistrarunidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrarunidad.Location = new System.Drawing.Point(101, 138);
            this.btnregistrarunidad.Name = "btnregistrarunidad";
            this.btnregistrarunidad.Size = new System.Drawing.Size(83, 27);
            this.btnregistrarunidad.TabIndex = 60;
            this.btnregistrarunidad.Text = "Registrar";
            this.btnregistrarunidad.UseVisualStyleBackColor = true;
            this.btnregistrarunidad.Click += new System.EventHandler(this.btnregistrarunidad_Click);
            // 
            // txtcodigounidad
            // 
            this.txtcodigounidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigounidad.Location = new System.Drawing.Point(59, 20);
            this.txtcodigounidad.Name = "txtcodigounidad";
            this.txtcodigounidad.Size = new System.Drawing.Size(65, 22);
            this.txtcodigounidad.TabIndex = 59;
            // 
            // rdbactivounidades
            // 
            this.rdbactivounidades.AutoSize = true;
            this.rdbactivounidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbactivounidades.Location = new System.Drawing.Point(9, 160);
            this.rdbactivounidades.Name = "rdbactivounidades";
            this.rdbactivounidades.Size = new System.Drawing.Size(63, 20);
            this.rdbactivounidades.TabIndex = 62;
            this.rdbactivounidades.TabStop = true;
            this.rdbactivounidades.Text = "Activo";
            this.rdbactivounidades.UseVisualStyleBackColor = true;
            this.rdbactivounidades.Click += new System.EventHandler(this.rdbactivounidades_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Codigo:\n";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(6, 67);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(296, 63);
            this.txtdescripcion.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Estado:\n";
            // 
            // lbApellido1
            // 
            this.lbApellido1.AutoSize = true;
            this.lbApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido1.Location = new System.Drawing.Point(3, 48);
            this.lbApellido1.Name = "lbApellido1";
            this.lbApellido1.Size = new System.Drawing.Size(83, 16);
            this.lbApellido1.TabIndex = 56;
            this.lbApellido1.Text = "Descripción:";
            // 
            // txtplacas
            // 
            this.txtplacas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplacas.Location = new System.Drawing.Point(190, 20);
            this.txtplacas.Name = "txtplacas";
            this.txtplacas.Size = new System.Drawing.Size(112, 22);
            this.txtplacas.TabIndex = 55;
            // 
            // lbNombre1
            // 
            this.lbNombre1.AutoSize = true;
            this.lbNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre1.Location = new System.Drawing.Point(131, 23);
            this.lbNombre1.Name = "lbNombre1";
            this.lbNombre1.Size = new System.Drawing.Size(53, 16);
            this.lbNombre1.TabIndex = 54;
            this.lbNombre1.Text = "Placas:";
            // 
            // rbtnunidad
            // 
            this.rbtnunidad.AutoSize = true;
            this.rbtnunidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnunidad.Location = new System.Drawing.Point(111, 12);
            this.rbtnunidad.Name = "rbtnunidad";
            this.rbtnunidad.Size = new System.Drawing.Size(95, 24);
            this.rbtnunidad.TabIndex = 56;
            this.rbtnunidad.TabStop = true;
            this.rbtnunidad.Text = "Unidades";
            this.rbtnunidad.UseVisualStyleBackColor = true;
            this.rbtnunidad.Click += new System.EventHandler(this.rbtnunidad_Click);
            // 
            // rbtnhos
            // 
            this.rbtnhos.AutoSize = true;
            this.rbtnhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnhos.Location = new System.Drawing.Point(112, 287);
            this.rbtnhos.Name = "rbtnhos";
            this.rbtnhos.Size = new System.Drawing.Size(102, 24);
            this.rbtnhos.TabIndex = 57;
            this.rbtnhos.TabStop = true;
            this.rbtnhos.Text = "Hospitales\r\n";
            this.rbtnhos.UseVisualStyleBackColor = true;
            this.rbtnhos.Click += new System.EventHandler(this.rbtnhos_Click);
            // 
            // dgvunihos
            // 
            this.dgvunihos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvunihos.Location = new System.Drawing.Point(339, 24);
            this.dgvunihos.Name = "dgvunihos";
            this.dgvunihos.Size = new System.Drawing.Size(634, 525);
            this.dgvunihos.TabIndex = 58;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.rbtnhos);
            this.groupBox3.Controls.Add(this.rbtnunidad);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 525);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            // 
            // frm_Unidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 572);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvunihos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Unidades";
            this.Text = "frm_Unidades";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvunihos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnregistrarunidad;
        private System.Windows.Forms.TextBox txtcodigounidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label lbApellido1;
        private System.Windows.Forms.TextBox txtplacas;
        private System.Windows.Forms.Label lbNombre1;
        private System.Windows.Forms.RadioButton rbtnunidad;
        private System.Windows.Forms.RadioButton rbtnhos;
        private System.Windows.Forms.Button btnregistrarhos;
        private System.Windows.Forms.TextBox txtcodhos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbinactivohospitales;
        private System.Windows.Forms.RadioButton rdbactivohospitales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbinactivounidades;
        private System.Windows.Forms.RadioButton rdbactivounidades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvunihos;
        private System.Windows.Forms.Button btnreestablecerhos;
        private System.Windows.Forms.Button btnmodificarhos;
        private System.Windows.Forms.Button btnreestableceruni;
        private System.Windows.Forms.Button btnmodificaruni;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
namespace Prototipo_CS
{
    partial class frm_Empleados
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
            this.txtape2 = new System.Windows.Forms.TextBox();
            this.lbApellido2 = new System.Windows.Forms.Label();
            this.txtape1 = new System.Windows.Forms.TextBox();
            this.lbApellido1 = new System.Windows.Forms.Label();
            this.txtnom2 = new System.Windows.Forms.TextBox();
            this.lbNombre2 = new System.Windows.Forms.Label();
            this.txtnom1 = new System.Windows.Forms.TextBox();
            this.lbNombre1 = new System.Windows.Forms.Label();
            this.dtppaciente = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.cbxempleado = new System.Windows.Forms.ComboBox();
            this.btnreestablecer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbactivoempleados = new System.Windows.Forms.RadioButton();
            this.rdbinactivoempleados = new System.Windows.Forms.RadioButton();
            this.gpbempleado = new System.Windows.Forms.GroupBox();
            this.dgvempleados = new System.Windows.Forms.DataGridView();
            this.gpbempleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtape2
            // 
            this.txtape2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtape2.Location = new System.Drawing.Point(814, 45);
            this.txtape2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtape2.Name = "txtape2";
            this.txtape2.Size = new System.Drawing.Size(140, 21);
            this.txtape2.TabIndex = 36;
            this.txtape2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtape2_KeyPress);
            // 
            // lbApellido2
            // 
            this.lbApellido2.AutoSize = true;
            this.lbApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido2.Location = new System.Drawing.Point(731, 47);
            this.lbApellido2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbApellido2.Name = "lbApellido2";
            this.lbApellido2.Size = new System.Drawing.Size(75, 16);
            this.lbApellido2.TabIndex = 35;
            this.lbApellido2.Text = "2° Apellido:";
            // 
            // txtape1
            // 
            this.txtape1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtape1.Location = new System.Drawing.Point(564, 45);
            this.txtape1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtape1.Name = "txtape1";
            this.txtape1.Size = new System.Drawing.Size(140, 21);
            this.txtape1.TabIndex = 34;
            this.txtape1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtape_KeyPress);
            // 
            // lbApellido1
            // 
            this.lbApellido1.AutoSize = true;
            this.lbApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido1.Location = new System.Drawing.Point(481, 47);
            this.lbApellido1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbApellido1.Name = "lbApellido1";
            this.lbApellido1.Size = new System.Drawing.Size(75, 16);
            this.lbApellido1.TabIndex = 32;
            this.lbApellido1.Text = "1° Apellido:";
            // 
            // txtnom2
            // 
            this.txtnom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom2.Location = new System.Drawing.Point(333, 45);
            this.txtnom2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnom2.Name = "txtnom2";
            this.txtnom2.Size = new System.Drawing.Size(130, 21);
            this.txtnom2.TabIndex = 30;
            this.txtnom2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnom2_KeyPress);
            // 
            // lbNombre2
            // 
            this.lbNombre2.AutoSize = true;
            this.lbNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre2.Location = new System.Drawing.Point(251, 47);
            this.lbNombre2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre2.Name = "lbNombre2";
            this.lbNombre2.Size = new System.Drawing.Size(74, 16);
            this.lbNombre2.TabIndex = 29;
            this.lbNombre2.Text = "2° Nombre:";
            // 
            // txtnom1
            // 
            this.txtnom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom1.Location = new System.Drawing.Point(89, 45);
            this.txtnom1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnom1.Name = "txtnom1";
            this.txtnom1.Size = new System.Drawing.Size(140, 21);
            this.txtnom1.TabIndex = 28;
            this.txtnom1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnom_KeyPress);
            // 
            // lbNombre1
            // 
            this.lbNombre1.AutoSize = true;
            this.lbNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre1.Location = new System.Drawing.Point(7, 47);
            this.lbNombre1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre1.Name = "lbNombre1";
            this.lbNombre1.Size = new System.Drawing.Size(74, 16);
            this.lbNombre1.TabIndex = 27;
            this.lbNombre1.Text = "1° Nombre:";
            // 
            // dtppaciente
            // 
            this.dtppaciente.Location = new System.Drawing.Point(151, 78);
            this.dtppaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtppaciente.Name = "dtppaciente";
            this.dtppaciente.ShowUpDown = true;
            this.dtppaciente.Size = new System.Drawing.Size(247, 22);
            this.dtppaciente.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // txtcod
            // 
            this.txtcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.Location = new System.Drawing.Point(89, 15);
            this.txtcod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(59, 21);
            this.txtcod.TabIndex = 38;
            this.txtcod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcod_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Codigo:\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tipo de empleado:\n";
            // 
            // btnregistrar
            // 
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Location = new System.Drawing.Point(724, 87);
            this.btnregistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(111, 33);
            this.btnregistrar.TabIndex = 53;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // cbxempleado
            // 
            this.cbxempleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxempleado.FormattingEnabled = true;
            this.cbxempleado.Location = new System.Drawing.Point(151, 108);
            this.cbxempleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxempleado.Name = "cbxempleado";
            this.cbxempleado.Size = new System.Drawing.Size(247, 24);
            this.cbxempleado.TabIndex = 54;
            // 
            // btnreestablecer
            // 
            this.btnreestablecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreestablecer.Location = new System.Drawing.Point(843, 87);
            this.btnreestablecer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnreestablecer.Name = "btnreestablecer";
            this.btnreestablecer.Size = new System.Drawing.Size(111, 33);
            this.btnreestablecer.TabIndex = 55;
            this.btnreestablecer.Text = "Reestablecer";
            this.btnreestablecer.UseVisualStyleBackColor = true;
            this.btnreestablecer.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Estado:\n";
            // 
            // rdbactivoempleados
            // 
            this.rdbactivoempleados.AutoSize = true;
            this.rdbactivoempleados.Location = new System.Drawing.Point(484, 93);
            this.rdbactivoempleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbactivoempleados.Name = "rdbactivoempleados";
            this.rdbactivoempleados.Size = new System.Drawing.Size(63, 20);
            this.rdbactivoempleados.TabIndex = 57;
            this.rdbactivoempleados.TabStop = true;
            this.rdbactivoempleados.Text = "Activo";
            this.rdbactivoempleados.UseVisualStyleBackColor = true;
            // 
            // rdbinactivoempleados
            // 
            this.rdbinactivoempleados.AutoSize = true;
            this.rdbinactivoempleados.Location = new System.Drawing.Point(555, 93);
            this.rdbinactivoempleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbinactivoempleados.Name = "rdbinactivoempleados";
            this.rdbinactivoempleados.Size = new System.Drawing.Size(72, 20);
            this.rdbinactivoempleados.TabIndex = 58;
            this.rdbinactivoempleados.TabStop = true;
            this.rdbinactivoempleados.Text = "Inactivo";
            this.rdbinactivoempleados.UseVisualStyleBackColor = true;
            // 
            // gpbempleado
            // 
            this.gpbempleado.Controls.Add(this.btnregistrar);
            this.gpbempleado.Controls.Add(this.rdbinactivoempleados);
            this.gpbempleado.Controls.Add(this.label3);
            this.gpbempleado.Controls.Add(this.rdbactivoempleados);
            this.gpbempleado.Controls.Add(this.dtppaciente);
            this.gpbempleado.Controls.Add(this.label4);
            this.gpbempleado.Controls.Add(this.lbNombre1);
            this.gpbempleado.Controls.Add(this.btnreestablecer);
            this.gpbempleado.Controls.Add(this.txtnom1);
            this.gpbempleado.Controls.Add(this.cbxempleado);
            this.gpbempleado.Controls.Add(this.lbNombre2);
            this.gpbempleado.Controls.Add(this.txtnom2);
            this.gpbempleado.Controls.Add(this.label2);
            this.gpbempleado.Controls.Add(this.lbApellido1);
            this.gpbempleado.Controls.Add(this.txtcod);
            this.gpbempleado.Controls.Add(this.txtape1);
            this.gpbempleado.Controls.Add(this.label1);
            this.gpbempleado.Controls.Add(this.lbApellido2);
            this.gpbempleado.Controls.Add(this.txtape2);
            this.gpbempleado.Location = new System.Drawing.Point(12, 12);
            this.gpbempleado.Name = "gpbempleado";
            this.gpbempleado.Size = new System.Drawing.Size(961, 144);
            this.gpbempleado.TabIndex = 59;
            this.gpbempleado.TabStop = false;
            this.gpbempleado.Text = "Empleado";
            // 
            // dgvempleados
            // 
            this.dgvempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleados.Location = new System.Drawing.Point(12, 162);
            this.dgvempleados.Name = "dgvempleados";
            this.dgvempleados.Size = new System.Drawing.Size(961, 514);
            this.dgvempleados.TabIndex = 60;
            // 
            // frm_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 688);
            this.Controls.Add(this.dgvempleados);
            this.Controls.Add(this.gpbempleado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Empleados";
            this.Text = "frm_Empleados";
            this.Load += new System.EventHandler(this.frm_Empleados_Load);
            this.gpbempleado.ResumeLayout(false);
            this.gpbempleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtape2;
        private System.Windows.Forms.Label lbApellido2;
        private System.Windows.Forms.TextBox txtape1;
        private System.Windows.Forms.Label lbApellido1;
        private System.Windows.Forms.TextBox txtnom2;
        private System.Windows.Forms.Label lbNombre2;
        private System.Windows.Forms.TextBox txtnom1;
        private System.Windows.Forms.Label lbNombre1;
        private System.Windows.Forms.DateTimePicker dtppaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.ComboBox cbxempleado;
        private System.Windows.Forms.Button btnreestablecer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbactivoempleados;
        private System.Windows.Forms.RadioButton rdbinactivoempleados;
        private System.Windows.Forms.GroupBox gpbempleado;
        private System.Windows.Forms.DataGridView dgvempleados;
    }
}
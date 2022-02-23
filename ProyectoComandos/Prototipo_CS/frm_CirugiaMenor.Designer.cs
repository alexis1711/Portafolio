namespace Prototipo_CS
{
    partial class frm_CirugiaMenor
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
            this.dtppaciente = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnM = new System.Windows.Forms.RadioButton();
            this.rbtnF = new System.Windows.Forms.RadioButton();
            this.lbGenero = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbApellido2 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.lbApellido1 = new System.Windows.Forms.Label();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.lbNombre2 = new System.Windows.Forms.Label();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.lbNombre1 = new System.Windows.Forms.Label();
            this.txtdx = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtprocedimiento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtatendio = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtppaciente
            // 
            this.dtppaciente.Location = new System.Drawing.Point(87, 36);
            this.dtppaciente.Name = "dtppaciente";
            this.dtppaciente.ShowUpDown = true;
            this.dtppaciente.Size = new System.Drawing.Size(225, 20);
            this.dtppaciente.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Fecha ";
            // 
            // rbtnM
            // 
            this.rbtnM.AutoSize = true;
            this.rbtnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnM.Location = new System.Drawing.Point(239, 179);
            this.rbtnM.Name = "rbtnM";
            this.rbtnM.Size = new System.Drawing.Size(37, 20);
            this.rbtnM.TabIndex = 41;
            this.rbtnM.TabStop = true;
            this.rbtnM.Text = "M";
            this.rbtnM.UseVisualStyleBackColor = true;
            // 
            // rbtnF
            // 
            this.rbtnF.AutoSize = true;
            this.rbtnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnF.Location = new System.Drawing.Point(298, 179);
            this.rbtnF.Name = "rbtnF";
            this.rbtnF.Size = new System.Drawing.Size(34, 20);
            this.rbtnF.TabIndex = 40;
            this.rbtnF.TabStop = true;
            this.rbtnF.Text = "F";
            this.rbtnF.UseVisualStyleBackColor = true;
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenero.Location = new System.Drawing.Point(259, 160);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(53, 16);
            this.lbGenero.TabIndex = 39;
            this.lbGenero.Text = "Género";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(100, 178);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(73, 20);
            this.txtedad.TabIndex = 38;
            this.txtedad.TextChanged += new System.EventHandler(this.txtedad_TextChanged);
            this.txtedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedad_KeyPress);
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad.Location = new System.Drawing.Point(22, 183);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(44, 16);
            this.lbEdad.TabIndex = 36;
            this.lbEdad.Text = "Edad:";
            // 
            // lbApellido2
            // 
            this.lbApellido2.AutoSize = true;
            this.lbApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido2.Location = new System.Drawing.Point(236, 125);
            this.lbApellido2.Name = "lbApellido2";
            this.lbApellido2.Size = new System.Drawing.Size(75, 16);
            this.lbApellido2.TabIndex = 37;
            this.lbApellido2.Text = "2° Apellido:";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(100, 125);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(106, 20);
            this.txtApellido1.TabIndex = 35;
            this.txtApellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido1_KeyPress);
            // 
            // lbApellido1
            // 
            this.lbApellido1.AutoSize = true;
            this.lbApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido1.Location = new System.Drawing.Point(25, 125);
            this.lbApellido1.Name = "lbApellido1";
            this.lbApellido1.Size = new System.Drawing.Size(75, 16);
            this.lbApellido1.TabIndex = 34;
            this.lbApellido1.Text = "1° Apellido:";
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(312, 87);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(106, 20);
            this.txtNombre2.TabIndex = 33;
            this.txtNombre2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre2_KeyPress);
            // 
            // lbNombre2
            // 
            this.lbNombre2.AutoSize = true;
            this.lbNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre2.Location = new System.Drawing.Point(236, 87);
            this.lbNombre2.Name = "lbNombre2";
            this.lbNombre2.Size = new System.Drawing.Size(74, 16);
            this.lbNombre2.TabIndex = 32;
            this.lbNombre2.Text = "2° Nombre:";
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(100, 87);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(106, 20);
            this.txtNombre1.TabIndex = 31;
            this.txtNombre1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre1_KeyPress);
            // 
            // lbNombre1
            // 
            this.lbNombre1.AutoSize = true;
            this.lbNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre1.Location = new System.Drawing.Point(24, 87);
            this.lbNombre1.Name = "lbNombre1";
            this.lbNombre1.Size = new System.Drawing.Size(74, 16);
            this.lbNombre1.TabIndex = 30;
            this.lbNombre1.Text = "1° Nombre:";
            // 
            // txtdx
            // 
            this.txtdx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdx.Location = new System.Drawing.Point(466, 84);
            this.txtdx.Name = "txtdx";
            this.txtdx.Size = new System.Drawing.Size(209, 22);
            this.txtdx.TabIndex = 55;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(467, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 16);
            this.label20.TabIndex = 54;
            this.label20.Text = "Dx";
            // 
            // txtprocedimiento
            // 
            this.txtprocedimiento.Location = new System.Drawing.Point(25, 253);
            this.txtprocedimiento.Multiline = true;
            this.txtprocedimiento.Name = "txtprocedimiento";
            this.txtprocedimiento.Size = new System.Drawing.Size(365, 76);
            this.txtprocedimiento.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Procedimientos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Atendió:";
            // 
            // txtatendio
            // 
            this.txtatendio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtatendio.Location = new System.Drawing.Point(466, 154);
            this.txtatendio.Name = "txtatendio";
            this.txtatendio.Size = new System.Drawing.Size(209, 22);
            this.txtatendio.TabIndex = 59;
            this.txtatendio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtatendio_KeyPress);
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(312, 124);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(106, 20);
            this.txtApellido2.TabIndex = 60;
            this.txtApellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido2_KeyPress);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(56, 335);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(55, 27);
            this.btnguardar.TabIndex = 62;
            this.btnguardar.Text = "Guardar ";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(170, 339);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(95, 23);
            this.btnlimpiar.TabIndex = 61;
            this.btnlimpiar.Text = "Limpiar Campos";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_CirugiaMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 688);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtatendio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprocedimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdx);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.rbtnM);
            this.Controls.Add(this.rbtnF);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbApellido2);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.lbApellido1);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.lbNombre2);
            this.Controls.Add(this.txtNombre1);
            this.Controls.Add(this.lbNombre1);
            this.Controls.Add(this.dtppaciente);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CirugiaMenor";
            this.Text = "Cirugia_Menor";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtppaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnM;
        private System.Windows.Forms.RadioButton rbtnF;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Label lbApellido1;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.Label lbNombre2;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.Label lbNombre1;
        private System.Windows.Forms.TextBox txtdx;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtprocedimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtatendio;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
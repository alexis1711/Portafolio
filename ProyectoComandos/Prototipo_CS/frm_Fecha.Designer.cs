namespace Prototipo_CS
{
    partial class frm_Fecha
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnlesion = new System.Windows.Forms.RadioButton();
            this.rbtnaccidente = new System.Windows.Forms.RadioButton();
            this.rbtnrescate = new System.Windows.Forms.RadioButton();
            this.rbtnincendio = new System.Windows.Forms.RadioButton();
            this.rbtnfallecidos = new System.Windows.Forms.RadioButton();
            this.cbxlesion = new System.Windows.Forms.ComboBox();
            this.cbxaccidente = new System.Windows.Forms.ComboBox();
            this.cbxrescate = new System.Windows.Forms.ComboBox();
            this.cbxincendio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxfallecimiento = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.txtlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha 1 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de accidente";
            // 
            // rbtnlesion
            // 
            this.rbtnlesion.AutoSize = true;
            this.rbtnlesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnlesion.Location = new System.Drawing.Point(21, 181);
            this.rbtnlesion.Name = "rbtnlesion";
            this.rbtnlesion.Size = new System.Drawing.Size(75, 19);
            this.rbtnlesion.TabIndex = 5;
            this.rbtnlesion.TabStop = true;
            this.rbtnlesion.Text = "Lesiones";
            this.rbtnlesion.UseVisualStyleBackColor = true;
            this.rbtnlesion.CheckedChanged += new System.EventHandler(this.rbtnlesion_CheckedChanged);
            // 
            // rbtnaccidente
            // 
            this.rbtnaccidente.AutoSize = true;
            this.rbtnaccidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnaccidente.Location = new System.Drawing.Point(121, 181);
            this.rbtnaccidente.Name = "rbtnaccidente";
            this.rbtnaccidente.Size = new System.Drawing.Size(78, 19);
            this.rbtnaccidente.TabIndex = 6;
            this.rbtnaccidente.TabStop = true;
            this.rbtnaccidente.Text = "Accidente";
            this.rbtnaccidente.UseVisualStyleBackColor = true;
            this.rbtnaccidente.CheckedChanged += new System.EventHandler(this.rbtnaccidente_CheckedChanged);
            // 
            // rbtnrescate
            // 
            this.rbtnrescate.AutoSize = true;
            this.rbtnrescate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnrescate.Location = new System.Drawing.Point(21, 221);
            this.rbtnrescate.Name = "rbtnrescate";
            this.rbtnrescate.Size = new System.Drawing.Size(70, 19);
            this.rbtnrescate.TabIndex = 7;
            this.rbtnrescate.TabStop = true;
            this.rbtnrescate.Text = "Rescate";
            this.rbtnrescate.UseVisualStyleBackColor = true;
            this.rbtnrescate.CheckedChanged += new System.EventHandler(this.rbtnrescate_CheckedChanged);
            // 
            // rbtnincendio
            // 
            this.rbtnincendio.AutoSize = true;
            this.rbtnincendio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnincendio.Location = new System.Drawing.Point(121, 221);
            this.rbtnincendio.Name = "rbtnincendio";
            this.rbtnincendio.Size = new System.Drawing.Size(72, 19);
            this.rbtnincendio.TabIndex = 8;
            this.rbtnincendio.TabStop = true;
            this.rbtnincendio.Text = "Incendio";
            this.rbtnincendio.UseVisualStyleBackColor = true;
            this.rbtnincendio.CheckedChanged += new System.EventHandler(this.rbtnincendio_CheckedChanged);
            // 
            // rbtnfallecidos
            // 
            this.rbtnfallecidos.AutoSize = true;
            this.rbtnfallecidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnfallecidos.Location = new System.Drawing.Point(21, 263);
            this.rbtnfallecidos.Name = "rbtnfallecidos";
            this.rbtnfallecidos.Size = new System.Drawing.Size(81, 19);
            this.rbtnfallecidos.TabIndex = 9;
            this.rbtnfallecidos.TabStop = true;
            this.rbtnfallecidos.Text = "Fallecidos";
            this.rbtnfallecidos.UseVisualStyleBackColor = true;
            this.rbtnfallecidos.CheckedChanged += new System.EventHandler(this.rbtnfallecidos_CheckedChanged);
            // 
            // cbxlesion
            // 
            this.cbxlesion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxlesion.Enabled = false;
            this.cbxlesion.FormattingEnabled = true;
            this.cbxlesion.Location = new System.Drawing.Point(337, 67);
            this.cbxlesion.Name = "cbxlesion";
            this.cbxlesion.Size = new System.Drawing.Size(151, 21);
            this.cbxlesion.TabIndex = 10;
            // 
            // cbxaccidente
            // 
            this.cbxaccidente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxaccidente.Enabled = false;
            this.cbxaccidente.FormattingEnabled = true;
            this.cbxaccidente.Location = new System.Drawing.Point(527, 67);
            this.cbxaccidente.Name = "cbxaccidente";
            this.cbxaccidente.Size = new System.Drawing.Size(151, 21);
            this.cbxaccidente.TabIndex = 11;
            // 
            // cbxrescate
            // 
            this.cbxrescate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxrescate.Enabled = false;
            this.cbxrescate.FormattingEnabled = true;
            this.cbxrescate.Location = new System.Drawing.Point(337, 136);
            this.cbxrescate.Name = "cbxrescate";
            this.cbxrescate.Size = new System.Drawing.Size(151, 21);
            this.cbxrescate.TabIndex = 12;
            // 
            // cbxincendio
            // 
            this.cbxincendio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxincendio.Enabled = false;
            this.cbxincendio.FormattingEnabled = true;
            this.cbxincendio.Location = new System.Drawing.Point(527, 136);
            this.cbxincendio.Name = "cbxincendio";
            this.cbxincendio.Size = new System.Drawing.Size(151, 21);
            this.cbxincendio.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tipo de Lesión";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(546, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tipo de Accidente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tipo de Rescate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(546, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tipo de Incendio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(340, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tipo de Fallecimiento";
            // 
            // cbxfallecimiento
            // 
            this.cbxfallecimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxfallecimiento.Enabled = false;
            this.cbxfallecimiento.FormattingEnabled = true;
            this.cbxfallecimiento.Location = new System.Drawing.Point(337, 204);
            this.cbxfallecimiento.Name = "cbxfallecimiento";
            this.cbxfallecimiento.Size = new System.Drawing.Size(151, 21);
            this.cbxfallecimiento.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(107, 91);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 45;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtlimpiar
            // 
            this.txtlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlimpiar.Location = new System.Drawing.Point(110, 312);
            this.txtlimpiar.Name = "txtlimpiar";
            this.txtlimpiar.Size = new System.Drawing.Size(83, 27);
            this.txtlimpiar.TabIndex = 56;
            this.txtlimpiar.Text = "Limpiar";
            this.txtlimpiar.UseVisualStyleBackColor = true;
            this.txtlimpiar.Click += new System.EventHandler(this.txtlimpiar_Click);
            // 
            // frm_Fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtlimpiar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxfallecimiento);
            this.Controls.Add(this.cbxincendio);
            this.Controls.Add(this.cbxrescate);
            this.Controls.Add(this.cbxaccidente);
            this.Controls.Add(this.cbxlesion);
            this.Controls.Add(this.rbtnfallecidos);
            this.Controls.Add(this.rbtnincendio);
            this.Controls.Add(this.rbtnrescate);
            this.Controls.Add(this.rbtnaccidente);
            this.Controls.Add(this.rbtnlesion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Fecha";
            this.Text = "fecha";
            this.Load += new System.EventHandler(this.fecha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnlesion;
        private System.Windows.Forms.RadioButton rbtnaccidente;
        private System.Windows.Forms.RadioButton rbtnrescate;
        private System.Windows.Forms.RadioButton rbtnincendio;
        private System.Windows.Forms.RadioButton rbtnfallecidos;
        private System.Windows.Forms.ComboBox cbxlesion;
        private System.Windows.Forms.ComboBox cbxaccidente;
        private System.Windows.Forms.ComboBox cbxrescate;
        private System.Windows.Forms.ComboBox cbxincendio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxfallecimiento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtlimpiar;
    }
}
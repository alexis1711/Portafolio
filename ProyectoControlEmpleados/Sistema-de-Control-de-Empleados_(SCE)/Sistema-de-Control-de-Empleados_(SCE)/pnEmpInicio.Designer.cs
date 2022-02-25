namespace Sistema_de_Control_de_Empleados__SCE_
{
    partial class pnEmpInicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnEmpInicio));
            this.lblHorario = new System.Windows.Forms.Label();
            this.dgvHorario = new System.Windows.Forms.DataGridView();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.txtIdHorario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRetirada = new System.Windows.Forms.Button();
            this.lblMarcado1 = new System.Windows.Forms.Label();
            this.lblMarcado2 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tmTiempo = new System.Windows.Forms.Timer(this.components);
            this.lblHor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.Black;
            this.lblHorario.Location = new System.Drawing.Point(297, 16);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(260, 22);
            this.lblHorario.TabIndex = 100005;
            this.lblHorario.Text = "Horario de Trabajo de Hoy";
            // 
            // dgvHorario
            // 
            this.dgvHorario.AllowUserToAddRows = false;
            this.dgvHorario.AllowUserToDeleteRows = false;
            this.dgvHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorario.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorario.EnableHeadersVisualStyles = false;
            this.dgvHorario.Location = new System.Drawing.Point(12, 48);
            this.dgvHorario.MultiSelect = false;
            this.dgvHorario.Name = "dgvHorario";
            this.dgvHorario.ReadOnly = true;
            this.dgvHorario.Size = new System.Drawing.Size(841, 183);
            this.dgvHorario.TabIndex = 100085;
            this.dgvHorario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorario_CellDoubleClick);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAsistencia.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnAsistencia.Location = new System.Drawing.Point(485, 293);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(123, 60);
            this.btnAsistencia.TabIndex = 100086;
            this.btnAsistencia.Text = "Marcar Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = false;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // txtIdHorario
            // 
            this.txtIdHorario.BackColor = System.Drawing.Color.White;
            this.txtIdHorario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdHorario.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdHorario.ForeColor = System.Drawing.Color.Black;
            this.txtIdHorario.Location = new System.Drawing.Point(120, 237);
            this.txtIdHorario.Name = "txtIdHorario";
            this.txtIdHorario.ReadOnly = true;
            this.txtIdHorario.Size = new System.Drawing.Size(43, 25);
            this.txtIdHorario.TabIndex = 100088;
            this.txtIdHorario.Text = "1";
            this.txtIdHorario.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(564, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 100092;
            this.label2.Text = "Asistencia";
            // 
            // btnRetirada
            // 
            this.btnRetirada.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRetirada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetirada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetirada.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirada.ForeColor = System.Drawing.Color.White;
            this.btnRetirada.Location = new System.Drawing.Point(623, 293);
            this.btnRetirada.Name = "btnRetirada";
            this.btnRetirada.Size = new System.Drawing.Size(123, 60);
            this.btnRetirada.TabIndex = 100093;
            this.btnRetirada.Text = "Marcar Retirada";
            this.btnRetirada.UseVisualStyleBackColor = false;
            this.btnRetirada.Click += new System.EventHandler(this.btnRetirada_Click);
            // 
            // lblMarcado1
            // 
            this.lblMarcado1.AutoSize = true;
            this.lblMarcado1.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMarcado1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcado1.Location = new System.Drawing.Point(501, 356);
            this.lblMarcado1.Name = "lblMarcado1";
            this.lblMarcado1.Size = new System.Drawing.Size(91, 19);
            this.lblMarcado1.TabIndex = 100094;
            this.lblMarcado1.Text = "Marcado ✓";
            this.lblMarcado1.Visible = false;
            // 
            // lblMarcado2
            // 
            this.lblMarcado2.AutoSize = true;
            this.lblMarcado2.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMarcado2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcado2.Location = new System.Drawing.Point(641, 356);
            this.lblMarcado2.Name = "lblMarcado2";
            this.lblMarcado2.Size = new System.Drawing.Size(91, 19);
            this.lblMarcado2.TabIndex = 100095;
            this.lblMarcado2.Text = "Marcado ✓";
            this.lblMarcado2.Visible = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHora.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(182, 293);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(81, 19);
            this.lblHora.TabIndex = 100089;
            this.lblHora.Text = "00:00:00";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Gainsboro;
            this.lblFecha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(182, 346);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(81, 19);
            this.lblFecha.TabIndex = 100091;
            this.lblFecha.Text = "00/00/00";
            // 
            // tmTiempo
            // 
            this.tmTiempo.Tick += new System.EventHandler(this.tmTiempo_Tick);
            // 
            // lblHor
            // 
            this.lblHor.AutoSize = true;
            this.lblHor.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHor.Location = new System.Drawing.Point(55, 293);
            this.lblHor.Name = "lblHor";
            this.lblHor.Size = new System.Drawing.Size(108, 19);
            this.lblHor.TabIndex = 100087;
            this.lblHor.Text = "Hora Actual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 100090;
            this.label1.Text = "Fecha Actual";
            // 
            // pnEmpInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(865, 429);
            this.Controls.Add(this.lblMarcado2);
            this.Controls.Add(this.lblMarcado1);
            this.Controls.Add(this.btnRetirada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.txtIdHorario);
            this.Controls.Add(this.lblHor);
            this.Controls.Add(this.btnAsistencia);
            this.Controls.Add(this.dgvHorario);
            this.Controls.Add(this.lblHorario);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pnEmpInicio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pnInicio";
            this.Load += new System.EventHandler(this.pnEmpInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.DataGridView dgvHorario;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.TextBox txtIdHorario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRetirada;
        private System.Windows.Forms.Label lblMarcado1;
        private System.Windows.Forms.Label lblMarcado2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer tmTiempo;
        private System.Windows.Forms.Label lblHor;
        private System.Windows.Forms.Label label1;
    }
}
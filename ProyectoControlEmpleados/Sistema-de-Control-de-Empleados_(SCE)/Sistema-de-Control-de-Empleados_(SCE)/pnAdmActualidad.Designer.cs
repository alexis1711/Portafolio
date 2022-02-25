namespace Sistema_de_Control_de_Empleados__SCE_
{
    partial class pnAdmActualidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnAdmActualidad));
            this.lblBitacoraActual = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.dgvActualidad = new System.Windows.Forms.DataGridView();
            this.lblBuscarHoy = new System.Windows.Forms.Label();
            this.txtBuscarHoy = new System.Windows.Forms.TextBox();
            this.lblBuscarGen = new System.Windows.Forms.Label();
            this.txtBuscarGen = new System.Windows.Forms.TextBox();
            this.dgvGeneral = new System.Windows.Forms.DataGridView();
            this.lblBitacoraGeneral = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBitacoraActual
            // 
            this.lblBitacoraActual.AutoSize = true;
            this.lblBitacoraActual.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitacoraActual.ForeColor = System.Drawing.Color.Black;
            this.lblBitacoraActual.Location = new System.Drawing.Point(126, 52);
            this.lblBitacoraActual.Name = "lblBitacoraActual";
            this.lblBitacoraActual.Size = new System.Drawing.Size(160, 22);
            this.lblBitacoraActual.TabIndex = 100038;
            this.lblBitacoraActual.Text = "Bitácora Actual";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.Black;
            this.lblArea.Location = new System.Drawing.Point(97, 9);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(20, 22);
            this.lblArea.TabIndex = 100040;
            this.lblArea.Text = "-";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvActualidad
            // 
            this.dgvActualidad.AllowUserToAddRows = false;
            this.dgvActualidad.AllowUserToDeleteRows = false;
            this.dgvActualidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActualidad.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActualidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActualidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualidad.EnableHeadersVisualStyles = false;
            this.dgvActualidad.Location = new System.Drawing.Point(30, 138);
            this.dgvActualidad.MultiSelect = false;
            this.dgvActualidad.Name = "dgvActualidad";
            this.dgvActualidad.ReadOnly = true;
            this.dgvActualidad.Size = new System.Drawing.Size(425, 378);
            this.dgvActualidad.TabIndex = 100086;
            // 
            // lblBuscarHoy
            // 
            this.lblBuscarHoy.AutoSize = true;
            this.lblBuscarHoy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarHoy.Location = new System.Drawing.Point(31, 90);
            this.lblBuscarHoy.Name = "lblBuscarHoy";
            this.lblBuscarHoy.Size = new System.Drawing.Size(63, 19);
            this.lblBuscarHoy.TabIndex = 100088;
            this.lblBuscarHoy.Text = "Buscar";
            // 
            // txtBuscarHoy
            // 
            this.txtBuscarHoy.BackColor = System.Drawing.Color.White;
            this.txtBuscarHoy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarHoy.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarHoy.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarHoy.Location = new System.Drawing.Point(113, 89);
            this.txtBuscarHoy.Name = "txtBuscarHoy";
            this.txtBuscarHoy.Size = new System.Drawing.Size(333, 25);
            this.txtBuscarHoy.TabIndex = 100087;
            this.txtBuscarHoy.TextChanged += new System.EventHandler(this.txtBuscarHoy_TextChanged);
            // 
            // lblBuscarGen
            // 
            this.lblBuscarGen.AutoSize = true;
            this.lblBuscarGen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarGen.Location = new System.Drawing.Point(505, 90);
            this.lblBuscarGen.Name = "lblBuscarGen";
            this.lblBuscarGen.Size = new System.Drawing.Size(63, 19);
            this.lblBuscarGen.TabIndex = 100092;
            this.lblBuscarGen.Text = "Buscar";
            // 
            // txtBuscarGen
            // 
            this.txtBuscarGen.BackColor = System.Drawing.Color.White;
            this.txtBuscarGen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarGen.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarGen.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarGen.Location = new System.Drawing.Point(587, 89);
            this.txtBuscarGen.Name = "txtBuscarGen";
            this.txtBuscarGen.Size = new System.Drawing.Size(333, 25);
            this.txtBuscarGen.TabIndex = 100091;
            this.txtBuscarGen.TextChanged += new System.EventHandler(this.txtBuscarGen_TextChanged);
            // 
            // dgvGeneral
            // 
            this.dgvGeneral.AllowUserToAddRows = false;
            this.dgvGeneral.AllowUserToDeleteRows = false;
            this.dgvGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGeneral.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGeneral.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneral.EnableHeadersVisualStyles = false;
            this.dgvGeneral.Location = new System.Drawing.Point(504, 138);
            this.dgvGeneral.MultiSelect = false;
            this.dgvGeneral.Name = "dgvGeneral";
            this.dgvGeneral.ReadOnly = true;
            this.dgvGeneral.Size = new System.Drawing.Size(425, 378);
            this.dgvGeneral.TabIndex = 100090;
            // 
            // lblBitacoraGeneral
            // 
            this.lblBitacoraGeneral.AutoSize = true;
            this.lblBitacoraGeneral.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitacoraGeneral.ForeColor = System.Drawing.Color.Black;
            this.lblBitacoraGeneral.Location = new System.Drawing.Point(604, 52);
            this.lblBitacoraGeneral.Name = "lblBitacoraGeneral";
            this.lblBitacoraGeneral.Size = new System.Drawing.Size(170, 22);
            this.lblBitacoraGeneral.TabIndex = 100089;
            this.lblBitacoraGeneral.Text = "Bitácora General";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(31, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 22);
            this.lblNombre.TabIndex = 100040;
            this.lblNombre.Text = "Area:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnAdmActualidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(956, 528);
            this.ControlBox = false;
            this.Controls.Add(this.lblBuscarGen);
            this.Controls.Add(this.txtBuscarGen);
            this.Controls.Add(this.dgvGeneral);
            this.Controls.Add(this.lblBitacoraGeneral);
            this.Controls.Add(this.lblBuscarHoy);
            this.Controls.Add(this.txtBuscarHoy);
            this.Controls.Add(this.dgvActualidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblBitacoraActual);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pnAdmActualidad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pnAdmActualidad";
            this.Load += new System.EventHandler(this.pnAdmActualidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBitacoraActual;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.DataGridView dgvActualidad;
        private System.Windows.Forms.Label lblBuscarHoy;
        private System.Windows.Forms.TextBox txtBuscarHoy;
        private System.Windows.Forms.Label lblBuscarGen;
        private System.Windows.Forms.TextBox txtBuscarGen;
        private System.Windows.Forms.DataGridView dgvGeneral;
        private System.Windows.Forms.Label lblBitacoraGeneral;
        private System.Windows.Forms.Label lblNombre;
    }
}
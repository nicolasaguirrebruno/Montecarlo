namespace CorrectivoOPreventivo.Controles
{
    partial class ControlMantenimientoPreventivo
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPreventivo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias_mantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia_mantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.se_mantuvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimo_dia_mantenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_mantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreventivo)).BeginInit();
            this.SuspendLayout();
            // 
            // acumPreventivo
            // 
            this.dgvPreventivo.AllowUserToAddRows = false;
            this.dgvPreventivo.AllowUserToDeleteRows = false;
            this.dgvPreventivo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPreventivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreventivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Dias_mantenimiento,
            this.Dia_mantenimiento,
            this.dataGridViewTextBoxColumn5,
            this.se_mantuvo,
            this.dataGridViewTextBoxColumn6,
            this.ultimo_dia_mantenido,
            this.dataGridViewTextBoxColumn7,
            this.costo_mantenimiento,
            this.dataGridViewTextBoxColumn8});
            this.dgvPreventivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPreventivo.Location = new System.Drawing.Point(0, 0);
            this.dgvPreventivo.Name = "acumPreventivo";
            this.dgvPreventivo.ReadOnly = true;
            this.dgvPreventivo.RowHeadersWidth = 51;
            this.dgvPreventivo.RowTemplate.Height = 29;
            this.dgvPreventivo.Size = new System.Drawing.Size(1342, 341);
            this.dgvPreventivo.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Día";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "RND Avería";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Días para el Reparo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Día a Reparar";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Dias_mantenimiento
            // 
            this.Dias_mantenimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dias_mantenimiento.HeaderText = "Días para el Mantenimiento";
            this.Dias_mantenimiento.MinimumWidth = 6;
            this.Dias_mantenimiento.Name = "Dias_mantenimiento";
            this.Dias_mantenimiento.ReadOnly = true;
            // 
            // Dia_mantenimiento
            // 
            this.Dia_mantenimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dia_mantenimiento.HeaderText = "Día de Mantenimiento";
            this.Dia_mantenimiento.MinimumWidth = 6;
            this.Dia_mantenimiento.Name = "Dia_mantenimiento";
            this.Dia_mantenimiento.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Se reparó";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // se_mantuvo
            // 
            this.se_mantuvo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.se_mantuvo.HeaderText = "Se mantuvo";
            this.se_mantuvo.MinimumWidth = 6;
            this.se_mantuvo.Name = "se_mantuvo";
            this.se_mantuvo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Ultimo Día Arreglado";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // ultimo_dia_mantenido
            // 
            this.ultimo_dia_mantenido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ultimo_dia_mantenido.HeaderText = "Ultimo Día Mantenido";
            this.ultimo_dia_mantenido.MinimumWidth = 6;
            this.ultimo_dia_mantenido.Name = "ultimo_dia_mantenido";
            this.ultimo_dia_mantenido.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "Costo de reparación";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // costo_mantenimiento
            // 
            this.costo_mantenimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costo_mantenimiento.HeaderText = "Costo de Mantenimiento";
            this.costo_mantenimiento.MinimumWidth = 6;
            this.costo_mantenimiento.Name = "costo_mantenimiento";
            this.costo_mantenimiento.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.HeaderText = "Acumulación Costo";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // ControlMantenimientoPreventivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPreventivo);
            this.Name = "ControlMantenimientoPreventivo";
            this.Size = new System.Drawing.Size(1342, 341);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreventivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvPreventivo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Dias_mantenimiento;
        private DataGridViewTextBoxColumn Dia_mantenimiento;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn se_mantuvo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn ultimo_dia_mantenido;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn costo_mantenimiento;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}

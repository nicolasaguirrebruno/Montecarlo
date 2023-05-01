namespace CorrectivoOPreventivo
{
    partial class Montecarlo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 



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
        /// 
        private void InitializeComponent()
        {
            this.dgvCorrectivo = new System.Windows.Forms.DataGridView();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_averia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_para_reparo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_reparar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.se_reparo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ultimo_dia_arreglado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_reparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acumulacion_costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrectivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreventivo)).BeginInit();
            this.SuspendLayout();
            // 
            // acumCorrectivo
            // 
            this.dgvCorrectivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorrectivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dia,
            this.rnd_averia,
            this.dia_para_reparo,
            this.dia_reparar,
            this.se_reparo,
            this.Ultimo_dia_arreglado,
            this.costo_reparacion,
            this.acumulacion_costo});
            this.dgvCorrectivo.Location = new System.Drawing.Point(47, 117);
            this.dgvCorrectivo.MinimumSize = new System.Drawing.Size(1053, 341);
            this.dgvCorrectivo.Name = "acumCorrectivo";
            this.dgvCorrectivo.RowHeadersWidth = 51;
            this.dgvCorrectivo.RowTemplate.Height = 29;
            this.dgvCorrectivo.Size = new System.Drawing.Size(1053, 341);
            this.dgvCorrectivo.TabIndex = 0;
            // 
            // dia
            // 
            this.dia.HeaderText = "Dia";
            this.dia.MinimumWidth = 6;
            this.dia.Name = "dia";
            this.dia.ReadOnly = true;
            this.dia.Width = 125;
            // 
            // rnd_averia
            // 
            this.rnd_averia.HeaderText = "RND Averia";
            this.rnd_averia.MinimumWidth = 6;
            this.rnd_averia.Name = "rnd_averia";
            this.rnd_averia.ReadOnly = true;
            this.rnd_averia.Width = 125;
            // 
            // dia_para_reparo
            // 
            this.dia_para_reparo.HeaderText = "Dias Para El Reparo";
            this.dia_para_reparo.MinimumWidth = 6;
            this.dia_para_reparo.Name = "dia_para_reparo";
            this.dia_para_reparo.ReadOnly = true;
            this.dia_para_reparo.Width = 125;
            // 
            // dia_reparar
            // 
            this.dia_reparar.HeaderText = "Dia A Reparar";
            this.dia_reparar.MinimumWidth = 6;
            this.dia_reparar.Name = "dia_reparar";
            this.dia_reparar.ReadOnly = true;
            this.dia_reparar.Width = 125;
            // 
            // se_reparo
            // 
            this.se_reparo.HeaderText = "Se reparo";
            this.se_reparo.MinimumWidth = 6;
            this.se_reparo.Name = "se_reparo";
            this.se_reparo.ReadOnly = true;
            this.se_reparo.Width = 125;
            // 
            // Ultimo_dia_arreglado
            // 
            this.Ultimo_dia_arreglado.HeaderText = "Ultimo Dia Arreglado";
            this.Ultimo_dia_arreglado.MinimumWidth = 6;
            this.Ultimo_dia_arreglado.Name = "Ultimo_dia_arreglado";
            this.Ultimo_dia_arreglado.ReadOnly = true;
            this.Ultimo_dia_arreglado.Width = 125;
            // 
            // costo_reparacion
            // 
            this.costo_reparacion.HeaderText = "Costo de reparacion";
            this.costo_reparacion.MinimumWidth = 6;
            this.costo_reparacion.Name = "costo_reparacion";
            this.costo_reparacion.Width = 125;
            // 
            // acumulacion_costo
            // 
            this.acumulacion_costo.HeaderText = "Acumulacion Costo";
            this.acumulacion_costo.MinimumWidth = 6;
            this.acumulacion_costo.Name = "acumulacion_costo";
            this.acumulacion_costo.ReadOnly = true;
            this.acumulacion_costo.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mantenimiento Correctivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(47, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mantenimiento Preventivo";
            // 
            // acumPreventivo
            // 
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
            this.dgvPreventivo.Location = new System.Drawing.Point(47, 561);
            this.dgvPreventivo.Name = "acumPreventivo";
            this.dgvPreventivo.RowHeadersWidth = 51;
            this.dgvPreventivo.RowTemplate.Height = 29;
            this.dgvPreventivo.Size = new System.Drawing.Size(1677, 341);
            this.dgvPreventivo.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Dia";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "RND Averia";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Dias Para El Reparo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Dia A Reparar";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Dias_mantenimiento
            // 
            this.Dias_mantenimiento.HeaderText = "Dias Para El Mantenimiento";
            this.Dias_mantenimiento.MinimumWidth = 6;
            this.Dias_mantenimiento.Name = "Dias_mantenimiento";
            this.Dias_mantenimiento.ReadOnly = true;
            this.Dias_mantenimiento.Width = 125;
            // 
            // Dia_mantenimiento
            // 
            this.Dia_mantenimiento.HeaderText = "Dia De Mantenimiento";
            this.Dia_mantenimiento.MinimumWidth = 6;
            this.Dia_mantenimiento.Name = "Dia_mantenimiento";
            this.Dia_mantenimiento.ReadOnly = true;
            this.Dia_mantenimiento.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Se reparo";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // se_mantuvo
            // 
            this.se_mantuvo.HeaderText = "Se mantuvo";
            this.se_mantuvo.MinimumWidth = 6;
            this.se_mantuvo.Name = "se_mantuvo";
            this.se_mantuvo.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Ultimo Dia Arreglado";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // ultimo_dia_mantenido
            // 
            this.ultimo_dia_mantenido.HeaderText = "Ultimo Dia Mantenido";
            this.ultimo_dia_mantenido.MinimumWidth = 6;
            this.ultimo_dia_mantenido.Name = "ultimo_dia_mantenido";
            this.ultimo_dia_mantenido.ReadOnly = true;
            this.ultimo_dia_mantenido.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Costo de reparacion";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // costo_mantenimiento
            // 
            this.costo_mantenimiento.HeaderText = "Costo De Mantenimiento";
            this.costo_mantenimiento.MinimumWidth = 6;
            this.costo_mantenimiento.Name = "costo_mantenimiento";
            this.costo_mantenimiento.ReadOnly = true;
            this.costo_mantenimiento.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Acumulacion Costo";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // Montecarlo
            // 
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPreventivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCorrectivo);
            this.Name = "Montecarlo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrectivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreventivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private DataGridView dgvCorrectivo;
        private Label label1;
        private DataGridViewTextBoxColumn dia;
        private DataGridViewTextBoxColumn rnd_averia;
        private DataGridViewTextBoxColumn dia_para_reparo;
        private DataGridViewTextBoxColumn dia_reparar;
        private DataGridViewTextBoxColumn se_reparo;
        private DataGridViewTextBoxColumn Ultimo_dia_arreglado;
        private DataGridViewTextBoxColumn costo_reparacion;
        private DataGridViewTextBoxColumn acumulacion_costo;
        private Label label2;
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
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
            dgvCorrectivo = new DataGridView();
            dia = new DataGridViewTextBoxColumn();
            rnd_averia = new DataGridViewTextBoxColumn();
            dia_para_reparo = new DataGridViewTextBoxColumn();
            dia_reparar = new DataGridViewTextBoxColumn();
            se_reparo = new DataGridViewTextBoxColumn();
            Ultimo_dia_arreglado = new DataGridViewTextBoxColumn();
            costo_reparacion = new DataGridViewTextBoxColumn();
            acumulacion_costo = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            dgvPreventivo = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Dias_mantenimiento = new DataGridViewTextBoxColumn();
            Dia_mantenimiento = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            se_mantuvo = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            ultimo_dia_mantenido = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            costo_mantenimiento = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCorrectivo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPreventivo).BeginInit();
            SuspendLayout();
            // 
            // dgvCorrectivo
            // 
            dgvCorrectivo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCorrectivo.Columns.AddRange(new DataGridViewColumn[] { dia, rnd_averia, dia_para_reparo, dia_reparar, se_reparo, Ultimo_dia_arreglado, costo_reparacion, acumulacion_costo });
            dgvCorrectivo.Location = new Point(47, 117);
            dgvCorrectivo.Name = "dgvCorrectivo";
            dgvCorrectivo.RowHeadersWidth = 51;
            dgvCorrectivo.RowTemplate.Height = 29;
            dgvCorrectivo.Size = new Size(1053, 341);
            dgvCorrectivo.TabIndex = 0;
            dgvCorrectivo.CellContentClick += dgvCorrectivo_CellContentClick;
            // 
            // dia
            // 
            dia.HeaderText = "Dia";
            dia.MinimumWidth = 6;
            dia.Name = "dia";
            dia.ReadOnly = true;
            dia.Width = 125;
            // 
            // rnd_averia
            // 
            rnd_averia.HeaderText = "RND Averia";
            rnd_averia.MinimumWidth = 6;
            rnd_averia.Name = "rnd_averia";
            rnd_averia.ReadOnly = true;
            rnd_averia.Width = 125;
            // 
            // dia_para_reparo
            // 
            dia_para_reparo.HeaderText = "Dias Para El Reparo";
            dia_para_reparo.MinimumWidth = 6;
            dia_para_reparo.Name = "dia_para_reparo";
            dia_para_reparo.ReadOnly = true;
            dia_para_reparo.Width = 125;
            // 
            // dia_reparar
            // 
            dia_reparar.HeaderText = "Dia A Reparar";
            dia_reparar.MinimumWidth = 6;
            dia_reparar.Name = "dia_reparar";
            dia_reparar.ReadOnly = true;
            dia_reparar.Width = 125;
            // 
            // se_reparo
            // 
            se_reparo.HeaderText = "Se reparo";
            se_reparo.MinimumWidth = 6;
            se_reparo.Name = "se_reparo";
            se_reparo.ReadOnly = true;
            se_reparo.Width = 125;
            // 
            // Ultimo_dia_arreglado
            // 
            Ultimo_dia_arreglado.HeaderText = "Ultimo Dia Arreglado";
            Ultimo_dia_arreglado.MinimumWidth = 6;
            Ultimo_dia_arreglado.Name = "Ultimo_dia_arreglado";
            Ultimo_dia_arreglado.ReadOnly = true;
            Ultimo_dia_arreglado.Width = 125;
            // 
            // costo_reparacion
            // 
            costo_reparacion.HeaderText = "Costo de reparacion";
            costo_reparacion.MinimumWidth = 6;
            costo_reparacion.Name = "costo_reparacion";
            costo_reparacion.Width = 125;
            // 
            // acumulacion_costo
            // 
            acumulacion_costo.HeaderText = "Acumulacion Costo";
            acumulacion_costo.MinimumWidth = 6;
            acumulacion_costo.Name = "acumulacion_costo";
            acumulacion_costo.ReadOnly = true;
            acumulacion_costo.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(47, 43);
            label1.Name = "label1";
            label1.Size = new Size(436, 40);
            label1.TabIndex = 1;
            label1.Text = "Mantenimiento Correctivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(47, 488);
            label2.Name = "label2";
            label2.Size = new Size(438, 40);
            label2.TabIndex = 3;
            label2.Text = "Mantenimiento Preventivo";
            // 
            // dgvPreventivo
            // 
            dgvPreventivo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPreventivo.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Dias_mantenimiento, Dia_mantenimiento, dataGridViewTextBoxColumn5, se_mantuvo, dataGridViewTextBoxColumn6, ultimo_dia_mantenido, dataGridViewTextBoxColumn7, costo_mantenimiento, dataGridViewTextBoxColumn8 });
            dgvPreventivo.Location = new Point(47, 561);
            dgvPreventivo.Name = "dgvPreventivo";
            dgvPreventivo.RowHeadersWidth = 51;
            dgvPreventivo.RowTemplate.Height = 29;
            dgvPreventivo.Size = new Size(1677, 341);
            dgvPreventivo.TabIndex = 2;
            dgvPreventivo.CellContentClick += dgvPreventivo_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Dia";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "RND Averia";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Dias Para El Reparo";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Dia A Reparar";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Dias_mantenimiento
            // 
            Dias_mantenimiento.HeaderText = "Dias Para El Mantenimiento";
            Dias_mantenimiento.MinimumWidth = 6;
            Dias_mantenimiento.Name = "Dias_mantenimiento";
            Dias_mantenimiento.ReadOnly = true;
            Dias_mantenimiento.Width = 125;
            // 
            // Dia_mantenimiento
            // 
            Dia_mantenimiento.HeaderText = "Dia De Mantenimiento";
            Dia_mantenimiento.MinimumWidth = 6;
            Dia_mantenimiento.Name = "Dia_mantenimiento";
            Dia_mantenimiento.ReadOnly = true;
            Dia_mantenimiento.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Se reparo";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // se_mantuvo
            // 
            se_mantuvo.HeaderText = "Se mantuvo";
            se_mantuvo.MinimumWidth = 6;
            se_mantuvo.Name = "se_mantuvo";
            se_mantuvo.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Ultimo Dia Arreglado";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // ultimo_dia_mantenido
            // 
            ultimo_dia_mantenido.HeaderText = "Ultimo Dia Mantenido";
            ultimo_dia_mantenido.MinimumWidth = 6;
            ultimo_dia_mantenido.Name = "ultimo_dia_mantenido";
            ultimo_dia_mantenido.ReadOnly = true;
            ultimo_dia_mantenido.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Costo de reparacion";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // costo_mantenimiento
            // 
            costo_mantenimiento.HeaderText = "Costo De Mantenimiento";
            costo_mantenimiento.MinimumWidth = 6;
            costo_mantenimiento.Name = "costo_mantenimiento";
            costo_mantenimiento.ReadOnly = true;
            costo_mantenimiento.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Acumulacion Costo";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // Montecarlo
            // 
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1799, 926);
            Controls.Add(label2);
            Controls.Add(dgvPreventivo);
            Controls.Add(label1);
            Controls.Add(dgvCorrectivo);
            Name = "Montecarlo";
            ((System.ComponentModel.ISupportInitialize)dgvCorrectivo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPreventivo).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
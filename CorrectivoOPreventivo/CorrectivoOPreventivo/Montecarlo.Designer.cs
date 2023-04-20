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
            ((System.ComponentModel.ISupportInitialize)dgvCorrectivo).BeginInit();
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
            dgvCorrectivo.Size = new Size(1053, 745);
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
            // Montecarlo
            // 
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1293, 926);
            Controls.Add(label1);
            Controls.Add(dgvCorrectivo);
            Name = "Montecarlo";
            ((System.ComponentModel.ISupportInitialize)dgvCorrectivo).EndInit();
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
    }
}
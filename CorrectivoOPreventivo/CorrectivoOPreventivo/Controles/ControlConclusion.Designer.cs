namespace CorrectivoOPreventivo.Controles
{
    partial class ControlConclusion
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
            this.lblCostoAcumCorrectivo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCostoAcumPreventivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCostoAcumCorrectivo
            // 
            this.lblCostoAcumCorrectivo.AutoSize = true;
            this.lblCostoAcumCorrectivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostoAcumCorrectivo.Location = new System.Drawing.Point(469, 44);
            this.lblCostoAcumCorrectivo.Name = "lblCostoAcumCorrectivo";
            this.lblCostoAcumCorrectivo.Size = new System.Drawing.Size(14, 15);
            this.lblCostoAcumCorrectivo.TabIndex = 0;
            this.lblCostoAcumCorrectivo.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "El costo promedio por día para el Mantenimiento Correctivo fue de:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "El costo promedio por día para el Mantenimiento Preventivo fue de:";
            // 
            // lblCostoAcumPreventivo
            // 
            this.lblCostoAcumPreventivo.AutoSize = true;
            this.lblCostoAcumPreventivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostoAcumPreventivo.Location = new System.Drawing.Point(469, 78);
            this.lblCostoAcumPreventivo.Name = "lblCostoAcumPreventivo";
            this.lblCostoAcumPreventivo.Size = new System.Drawing.Size(14, 15);
            this.lblCostoAcumPreventivo.TabIndex = 0;
            this.lblCostoAcumPreventivo.Text = "0";
            // 
            // ControlConclusion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCostoAcumPreventivo);
            this.Controls.Add(this.lblCostoAcumCorrectivo);
            this.Name = "ControlConclusion";
            this.Size = new System.Drawing.Size(1053, 341);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label lblCostoAcumCorrectivo;
        private Label label1;
        private Label label2;
        public Label lblCostoAcumPreventivo;
    }
}

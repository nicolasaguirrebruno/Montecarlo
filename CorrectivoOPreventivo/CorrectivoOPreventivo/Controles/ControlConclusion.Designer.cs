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
            this.label3 = new System.Windows.Forms.Label();
            this.lblEstrategia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCostoAcumPreventivo = new System.Windows.Forms.Label();
            this.lblCostoAcumCorrectivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(72, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo por día";
            // 
            // lblEstrategia
            // 
            this.lblEstrategia.AutoSize = true;
            this.lblEstrategia.BackColor = System.Drawing.Color.Coral;
            this.lblEstrategia.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblEstrategia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEstrategia.Location = new System.Drawing.Point(72, 152);
            this.lblEstrategia.Name = "lblEstrategia";
            this.lblEstrategia.Size = new System.Drawing.Size(104, 20);
            this.lblEstrategia.TabIndex = 9;
            this.lblEstrategia.Text = "Es conveniente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(72, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "El costo promedio por día para el Mantenimiento Preventivo fue de:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(72, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "El costo promedio por día para el Mantenimiento Correctivo fue de:";
            // 
            // lblCostoAcumPreventivo
            // 
            this.lblCostoAcumPreventivo.AutoSize = true;
            this.lblCostoAcumPreventivo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostoAcumPreventivo.Location = new System.Drawing.Point(562, 118);
            this.lblCostoAcumPreventivo.Name = "lblCostoAcumPreventivo";
            this.lblCostoAcumPreventivo.Size = new System.Drawing.Size(16, 20);
            this.lblCostoAcumPreventivo.TabIndex = 7;
            this.lblCostoAcumPreventivo.Text = "0";
            // 
            // lblCostoAcumCorrectivo
            // 
            this.lblCostoAcumCorrectivo.AutoSize = true;
            this.lblCostoAcumCorrectivo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostoAcumCorrectivo.Location = new System.Drawing.Point(562, 84);
            this.lblCostoAcumCorrectivo.Name = "lblCostoAcumCorrectivo";
            this.lblCostoAcumCorrectivo.Size = new System.Drawing.Size(16, 20);
            this.lblCostoAcumCorrectivo.TabIndex = 8;
            this.lblCostoAcumCorrectivo.Text = "0";
            // 
            // ControlConclusion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEstrategia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCostoAcumPreventivo);
            this.Controls.Add(this.lblCostoAcumCorrectivo);
            this.Controls.Add(this.label3);
            this.Name = "ControlConclusion";
            this.Size = new System.Drawing.Size(1053, 341);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label lblEstrategia;
        private Label label2;
        private Label label1;
        public Label lblCostoAcumPreventivo;
        public Label lblCostoAcumCorrectivo;
    }
}

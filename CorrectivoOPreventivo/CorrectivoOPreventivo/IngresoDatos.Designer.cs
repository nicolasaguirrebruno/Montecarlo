namespace CorrectivoOPreventivo
{
    partial class IngresoDatos
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputCantDias = new System.Windows.Forms.TextBox();
            this.inputDesde = new System.Windows.Forms.TextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.inputHasta = new System.Windows.Forms.TextBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnInitializeSimulation = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrorSimulacion = new System.Windows.Forms.Label();
            this.lblErrorHasta = new System.Windows.Forms.Label();
            this.lblErrorDesde = new System.Windows.Forms.Label();
            this.lblErrorCantDias = new System.Windows.Forms.Label();
            this.pnContenido = new System.Windows.Forms.Panel();
            this.pnSimulacion = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConclusion = new System.Windows.Forms.Button();
            this.btnPreventivo = new System.Windows.Forms.Button();
            this.btnCorrectivo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnContenido.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de días a simular";
            // 
            // inputCantDias
            // 
            this.inputCantDias.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputCantDias.Location = new System.Drawing.Point(190, 65);
            this.inputCantDias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputCantDias.Name = "inputCantDias";
            this.inputCantDias.Size = new System.Drawing.Size(124, 26);
            this.inputCantDias.TabIndex = 1;
            this.inputCantDias.TextChanged += new System.EventHandler(this.inputCantDias_TextChanged);
            this.inputCantDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputCantDias_KeyPress);
            // 
            // inputDesde
            // 
            this.inputDesde.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputDesde.Location = new System.Drawing.Point(541, 34);
            this.inputDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputDesde.Name = "inputDesde";
            this.inputDesde.Size = new System.Drawing.Size(130, 26);
            this.inputDesde.TabIndex = 3;
            this.inputDesde.TextChanged += new System.EventHandler(this.inputDesde_TextChanged);
            this.inputDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputDesde_KeyPress);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Enabled = false;
            this.lblDesde.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesde.Location = new System.Drawing.Point(439, 36);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(96, 20);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Mostrar desde";
            // 
            // inputHasta
            // 
            this.inputHasta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputHasta.Location = new System.Drawing.Point(541, 86);
            this.inputHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputHasta.Name = "inputHasta";
            this.inputHasta.Size = new System.Drawing.Size(130, 26);
            this.inputHasta.TabIndex = 5;
            this.inputHasta.TextChanged += new System.EventHandler(this.inputHasta_TextChanged);
            this.inputHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputHasta_KeyPress);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Enabled = false;
            this.lblHasta.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHasta.Location = new System.Drawing.Point(439, 88);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(88, 20);
            this.lblHasta.TabIndex = 4;
            this.lblHasta.Text = "Mostrar hasta";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(17, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(359, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "¿Correctivo o Preventivo?";
            // 
            // btnInitializeSimulation
            // 
            this.btnInitializeSimulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInitializeSimulation.BackColor = System.Drawing.Color.Coral;
            this.btnInitializeSimulation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInitializeSimulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitializeSimulation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInitializeSimulation.ForeColor = System.Drawing.Color.Transparent;
            this.btnInitializeSimulation.Location = new System.Drawing.Point(962, 10);
            this.btnInitializeSimulation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInitializeSimulation.Name = "btnInitializeSimulation";
            this.btnInitializeSimulation.Size = new System.Drawing.Size(264, 95);
            this.btnInitializeSimulation.TabIndex = 10;
            this.btnInitializeSimulation.Text = "Iniciar Simulación";
            this.btnInitializeSimulation.UseVisualStyleBackColor = false;
            this.btnInitializeSimulation.Click += new System.EventHandler(this.btnInitializeSimulation_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblErrorSimulacion);
            this.panel1.Controls.Add(this.lblErrorHasta);
            this.panel1.Controls.Add(this.lblErrorDesde);
            this.panel1.Controls.Add(this.lblErrorCantDias);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnInitializeSimulation);
            this.panel1.Controls.Add(this.inputCantDias);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inputHasta);
            this.panel1.Controls.Add(this.lblDesde);
            this.panel1.Controls.Add(this.lblHasta);
            this.panel1.Controls.Add(this.inputDesde);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 135);
            this.panel1.TabIndex = 12;
            // 
            // lblErrorSimulacion
            // 
            this.lblErrorSimulacion.AutoSize = true;
            this.lblErrorSimulacion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSimulacion.Location = new System.Drawing.Point(1040, 107);
            this.lblErrorSimulacion.Name = "lblErrorSimulacion";
            this.lblErrorSimulacion.Size = new System.Drawing.Size(96, 15);
            this.lblErrorSimulacion.TabIndex = 14;
            this.lblErrorSimulacion.Text = "Verificar Campos";
            // 
            // lblErrorHasta
            // 
            this.lblErrorHasta.AutoSize = true;
            this.lblErrorHasta.ForeColor = System.Drawing.Color.Red;
            this.lblErrorHasta.Location = new System.Drawing.Point(502, 114);
            this.lblErrorHasta.Name = "lblErrorHasta";
            this.lblErrorHasta.Size = new System.Drawing.Size(169, 15);
            this.lblErrorHasta.TabIndex = 13;
            this.lblErrorHasta.Text = "Este valor no puede estar vacío";
            // 
            // lblErrorDesde
            // 
            this.lblErrorDesde.AutoSize = true;
            this.lblErrorDesde.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDesde.Location = new System.Drawing.Point(502, 62);
            this.lblErrorDesde.Name = "lblErrorDesde";
            this.lblErrorDesde.Size = new System.Drawing.Size(169, 15);
            this.lblErrorDesde.TabIndex = 12;
            this.lblErrorDesde.Text = "Este valor no puede estar vacío";
            // 
            // lblErrorCantDias
            // 
            this.lblErrorCantDias.AutoSize = true;
            this.lblErrorCantDias.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCantDias.Location = new System.Drawing.Point(145, 95);
            this.lblErrorCantDias.Name = "lblErrorCantDias";
            this.lblErrorCantDias.Size = new System.Drawing.Size(169, 15);
            this.lblErrorCantDias.TabIndex = 11;
            this.lblErrorCantDias.Text = "Este valor no puede estar vacío";
            // 
            // pnContenido
            // 
            this.pnContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.pnContenido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnContenido.Controls.Add(this.pnSimulacion);
            this.pnContenido.Controls.Add(this.panel3);
            this.pnContenido.Location = new System.Drawing.Point(12, 151);
            this.pnContenido.Name = "pnContenido";
            this.pnContenido.Size = new System.Drawing.Size(1346, 500);
            this.pnContenido.TabIndex = 13;
            // 
            // pnSimulacion
            // 
            this.pnSimulacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSimulacion.Location = new System.Drawing.Point(0, 100);
            this.pnSimulacion.Name = "pnSimulacion";
            this.pnSimulacion.Size = new System.Drawing.Size(1342, 396);
            this.pnSimulacion.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnConclusion);
            this.panel3.Controls.Add(this.btnPreventivo);
            this.panel3.Controls.Add(this.btnCorrectivo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1342, 100);
            this.panel3.TabIndex = 12;
            // 
            // btnConclusion
            // 
            this.btnConclusion.BackColor = System.Drawing.Color.Coral;
            this.btnConclusion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConclusion.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConclusion.Enabled = false;
            this.btnConclusion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnConclusion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConclusion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConclusion.ForeColor = System.Drawing.Color.Transparent;
            this.btnConclusion.Location = new System.Drawing.Point(898, 0);
            this.btnConclusion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConclusion.Name = "btnConclusion";
            this.btnConclusion.Size = new System.Drawing.Size(448, 100);
            this.btnConclusion.TabIndex = 13;
            this.btnConclusion.Text = "Conclusión";
            this.btnConclusion.UseVisualStyleBackColor = false;
            this.btnConclusion.Click += new System.EventHandler(this.btnConclusion_Click);
            // 
            // btnPreventivo
            // 
            this.btnPreventivo.BackColor = System.Drawing.Color.Coral;
            this.btnPreventivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreventivo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPreventivo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPreventivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreventivo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPreventivo.ForeColor = System.Drawing.Color.Transparent;
            this.btnPreventivo.Location = new System.Drawing.Point(449, 0);
            this.btnPreventivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreventivo.Name = "btnPreventivo";
            this.btnPreventivo.Size = new System.Drawing.Size(449, 100);
            this.btnPreventivo.TabIndex = 12;
            this.btnPreventivo.Text = "Mantenimiento Preventivo";
            this.btnPreventivo.UseVisualStyleBackColor = false;
            this.btnPreventivo.Click += new System.EventHandler(this.btnPreventivo_Click);
            // 
            // btnCorrectivo
            // 
            this.btnCorrectivo.BackColor = System.Drawing.Color.Coral;
            this.btnCorrectivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorrectivo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCorrectivo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCorrectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrectivo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCorrectivo.ForeColor = System.Drawing.Color.Transparent;
            this.btnCorrectivo.Location = new System.Drawing.Point(0, 0);
            this.btnCorrectivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCorrectivo.Name = "btnCorrectivo";
            this.btnCorrectivo.Size = new System.Drawing.Size(449, 100);
            this.btnCorrectivo.TabIndex = 11;
            this.btnCorrectivo.Text = "Mantenimiento Correctivo";
            this.btnCorrectivo.UseVisualStyleBackColor = false;
            this.btnCorrectivo.Click += new System.EventHandler(this.btnCorrectivo_Click);
            // 
            // IngresoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1370, 661);
            this.Controls.Add(this.pnContenido);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1364, 600);
            this.Name = "IngresoDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresoDatos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IngresoDatos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnContenido.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox inputCantDias;
        private TextBox inputDesde;
        private Label lblDesde;
        private TextBox inputHasta;
        private Label lblHasta;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ImageList imageList1;
        private Label label5;
        private Button btnInitializeSimulation;
        private Panel panel1;
        private Panel pnContenido;
        private Panel panel3;
        private Button btnPreventivo;
        private Button btnCorrectivo;
        private Panel pnSimulacion;
        private Button btnConclusion;
        private Label lblErrorHasta;
        private Label lblErrorDesde;
        private Label lblErrorCantDias;
        private Label lblErrorSimulacion;
    }
}
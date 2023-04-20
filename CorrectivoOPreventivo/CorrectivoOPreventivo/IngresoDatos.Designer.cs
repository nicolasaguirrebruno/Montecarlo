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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresoDatos));
            label1 = new Label();
            inputCantDias = new TextBox();
            inputDesde = new TextBox();
            lblDesde = new Label();
            inputHasta = new TextBox();
            lblHasta = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            btnInitializeSimulation = new Button();
            chkMostrar = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(160, 151);
            label1.Name = "label1";
            label1.Size = new Size(275, 24);
            label1.TabIndex = 0;
            label1.Text = "Ingrese la cantidad de dias a simular";
            // 
            // inputCantDias
            // 
            inputCantDias.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inputCantDias.Location = new Point(460, 145);
            inputCantDias.Name = "inputCantDias";
            inputCantDias.Size = new Size(303, 30);
            inputCantDias.TabIndex = 1;
            // 
            // inputDesde
            // 
            inputDesde.Enabled = false;
            inputDesde.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inputDesde.Location = new Point(460, 368);
            inputDesde.Name = "inputDesde";
            inputDesde.Size = new Size(303, 30);
            inputDesde.TabIndex = 3;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Enabled = false;
            lblDesde.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesde.Location = new Point(163, 371);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(158, 24);
            lblDesde.TabIndex = 2;
            lblDesde.Text = "Cantidad dias desde";
            // 
            // inputHasta
            // 
            inputHasta.Enabled = false;
            inputHasta.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inputHasta.Location = new Point(463, 437);
            inputHasta.Name = "inputHasta";
            inputHasta.Size = new Size(303, 30);
            inputHasta.TabIndex = 5;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Enabled = false;
            lblHasta.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHasta.Location = new Point(163, 437);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(154, 24);
            lblHasta.TabIndex = 4;
            lblHasta.Text = "Cantidad dias hasta";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(73, 297);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(809, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Coral;
            label5.Location = new Point(286, 29);
            label5.Name = "label5";
            label5.Size = new Size(444, 40);
            label5.TabIndex = 8;
            label5.Text = "¿Correctivo o Preventivo?";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(73, 499);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(809, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(348, 239);
            label4.Name = "label4";
            label4.Size = new Size(287, 33);
            label4.TabIndex = 6;
            label4.Text = "Mostrar por pantalla";
            // 
            // btnInitializeSimulation
            // 
            btnInitializeSimulation.BackColor = Color.Coral;
            btnInitializeSimulation.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInitializeSimulation.ForeColor = Color.Transparent;
            btnInitializeSimulation.Location = new Point(73, 600);
            btnInitializeSimulation.Name = "btnInitializeSimulation";
            btnInitializeSimulation.Size = new Size(809, 65);
            btnInitializeSimulation.TabIndex = 10;
            btnInitializeSimulation.Text = "Iniciar Simulacion";
            btnInitializeSimulation.UseVisualStyleBackColor = false;
            btnInitializeSimulation.Click += btnInitializeSimulation_Click;
            // 
            // chkMostrar
            // 
            chkMostrar.AutoSize = true;
            chkMostrar.Location = new Point(315, 248);
            chkMostrar.Name = "chkMostrar";
            chkMostrar.Size = new Size(18, 17);
            chkMostrar.TabIndex = 11;
            chkMostrar.UseVisualStyleBackColor = true;
            chkMostrar.CheckedChanged += chkMostrar_CheckedChanged;
            // 
            // IngresoDatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(991, 700);
            Controls.Add(chkMostrar);
            Controls.Add(btnInitializeSimulation);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(inputHasta);
            Controls.Add(lblHasta);
            Controls.Add(inputDesde);
            Controls.Add(lblDesde);
            Controls.Add(inputCantDias);
            Controls.Add(label1);
            Name = "IngresoDatos";
            Text = "IngresoDatos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private PictureBox pictureBox1;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label4;
        private Button btnInitializeSimulation;
        private CheckBox chkMostrar;
    }
}
namespace sim_tp3
{
    partial class FormPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.groupBoxDistribucion = new System.Windows.Forms.GroupBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.radioButtonPoisson = new System.Windows.Forms.RadioButton();
            this.labelN = new System.Windows.Forms.Label();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonExponencial = new System.Windows.Forms.RadioButton();
            this.radioButtonUniformeAB = new System.Windows.Forms.RadioButton();
            this.panelUniforme = new System.Windows.Forms.Panel();
            this.labelUniformeAB = new System.Windows.Forms.Label();
            this.buttonGenerarUniforme = new System.Windows.Forms.Button();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.panelNormal = new System.Windows.Forms.Panel();
            this.textBoxDesviacionNormal = new System.Windows.Forms.TextBox();
            this.labelDesviacionNormal = new System.Windows.Forms.Label();
            this.labelNormal = new System.Windows.Forms.Label();
            this.buttonGenerarNormal = new System.Windows.Forms.Button();
            this.textBoxMediaNormal = new System.Windows.Forms.TextBox();
            this.labelMediaNormal = new System.Windows.Forms.Label();
            this.panelExponencial = new System.Windows.Forms.Panel();
            this.buttonGenerarExponencial = new System.Windows.Forms.Button();
            this.textBoxValorExponencial = new System.Windows.Forms.TextBox();
            this.labelValorExponencial = new System.Windows.Forms.Label();
            this.groupBoxExponencial = new System.Windows.Forms.GroupBox();
            this.radioButtonMedia = new System.Windows.Forms.RadioButton();
            this.radioButtonLambda = new System.Windows.Forms.RadioButton();
            this.labelExponencial = new System.Windows.Forms.Label();
            this.panelPoisson = new System.Windows.Forms.Panel();
            this.labelPoisson = new System.Windows.Forms.Label();
            this.buttonGenerarPoisson = new System.Windows.Forms.Button();
            this.textBoxMediaPoisson = new System.Windows.Forms.TextBox();
            this.labelMediaPoisson = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonChi2 = new System.Windows.Forms.Button();
            this.dataGridViewMostrar = new System.Windows.Forms.DataGridView();
            this.groupBoxDistribucion.SuspendLayout();
            this.panelUniforme.SuspendLayout();
            this.panelNormal.SuspendLayout();
            this.panelExponencial.SuspendLayout();
            this.groupBoxExponencial.SuspendLayout();
            this.panelPoisson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDistribucion
            // 
            this.groupBoxDistribucion.Controls.Add(this.textBoxN);
            this.groupBoxDistribucion.Controls.Add(this.radioButtonPoisson);
            this.groupBoxDistribucion.Controls.Add(this.labelN);
            this.groupBoxDistribucion.Controls.Add(this.radioButtonNormal);
            this.groupBoxDistribucion.Controls.Add(this.radioButtonExponencial);
            this.groupBoxDistribucion.Controls.Add(this.radioButtonUniformeAB);
            this.groupBoxDistribucion.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDistribucion.Name = "groupBoxDistribucion";
            this.groupBoxDistribucion.Size = new System.Drawing.Size(198, 152);
            this.groupBoxDistribucion.TabIndex = 0;
            this.groupBoxDistribucion.TabStop = false;
            this.groupBoxDistribucion.Text = "Distribución a Elegir";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(29, 115);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 6;
            // 
            // radioButtonPoisson
            // 
            this.radioButtonPoisson.AutoSize = true;
            this.radioButtonPoisson.Location = new System.Drawing.Point(6, 88);
            this.radioButtonPoisson.Name = "radioButtonPoisson";
            this.radioButtonPoisson.Size = new System.Drawing.Size(62, 17);
            this.radioButtonPoisson.TabIndex = 3;
            this.radioButtonPoisson.Text = "Poisson";
            this.radioButtonPoisson.UseVisualStyleBackColor = true;
            this.radioButtonPoisson.CheckedChanged += new System.EventHandler(this.RadioButtonPoisson_CheckedChanged);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(5, 118);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(18, 13);
            this.labelN.TabIndex = 5;
            this.labelN.Text = "N:";
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(6, 65);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(110, 17);
            this.radioButtonNormal.TabIndex = 2;
            this.radioButtonNormal.Text = "Normal Box Muller";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            this.radioButtonNormal.CheckedChanged += new System.EventHandler(this.RadioButtonNormal_CheckedChanged);
            // 
            // radioButtonExponencial
            // 
            this.radioButtonExponencial.AutoSize = true;
            this.radioButtonExponencial.Location = new System.Drawing.Point(6, 42);
            this.radioButtonExponencial.Name = "radioButtonExponencial";
            this.radioButtonExponencial.Size = new System.Drawing.Size(129, 17);
            this.radioButtonExponencial.TabIndex = 1;
            this.radioButtonExponencial.Text = "Exponencial Negativa";
            this.radioButtonExponencial.UseVisualStyleBackColor = true;
            this.radioButtonExponencial.CheckedChanged += new System.EventHandler(this.RadioButtonExponencial_CheckedChanged);
            // 
            // radioButtonUniformeAB
            // 
            this.radioButtonUniformeAB.AutoSize = true;
            this.radioButtonUniformeAB.Checked = true;
            this.radioButtonUniformeAB.Location = new System.Drawing.Point(6, 19);
            this.radioButtonUniformeAB.Name = "radioButtonUniformeAB";
            this.radioButtonUniformeAB.Size = new System.Drawing.Size(90, 17);
            this.radioButtonUniformeAB.TabIndex = 0;
            this.radioButtonUniformeAB.TabStop = true;
            this.radioButtonUniformeAB.Text = "Uniforme (AB)";
            this.radioButtonUniformeAB.UseVisualStyleBackColor = true;
            this.radioButtonUniformeAB.CheckedChanged += new System.EventHandler(this.RadioButtonUniformeAB_CheckedChanged);
            // 
            // panelUniforme
            // 
            this.panelUniforme.Controls.Add(this.labelUniformeAB);
            this.panelUniforme.Controls.Add(this.buttonGenerarUniforme);
            this.panelUniforme.Controls.Add(this.textBoxB);
            this.panelUniforme.Controls.Add(this.textBoxA);
            this.panelUniforme.Controls.Add(this.labelB);
            this.panelUniforme.Controls.Add(this.labelA);
            this.panelUniforme.Location = new System.Drawing.Point(12, 170);
            this.panelUniforme.Name = "panelUniforme";
            this.panelUniforme.Size = new System.Drawing.Size(198, 268);
            this.panelUniforme.TabIndex = 1;
            // 
            // labelUniformeAB
            // 
            this.labelUniformeAB.AutoSize = true;
            this.labelUniformeAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUniformeAB.Location = new System.Drawing.Point(9, 11);
            this.labelUniformeAB.Name = "labelUniformeAB";
            this.labelUniformeAB.Size = new System.Drawing.Size(148, 13);
            this.labelUniformeAB.TabIndex = 5;
            this.labelUniformeAB.Text = "Distribución Uniforme AB";
            // 
            // buttonGenerarUniforme
            // 
            this.buttonGenerarUniforme.Location = new System.Drawing.Point(12, 87);
            this.buttonGenerarUniforme.Name = "buttonGenerarUniforme";
            this.buttonGenerarUniforme.Size = new System.Drawing.Size(120, 23);
            this.buttonGenerarUniforme.TabIndex = 4;
            this.buttonGenerarUniforme.Text = "Generar";
            this.buttonGenerarUniforme.UseVisualStyleBackColor = true;
            this.buttonGenerarUniforme.Click += new System.EventHandler(this.ButtonGenerarUniforme_Click);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(32, 61);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 3;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(32, 35);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 2;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(9, 64);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(17, 13);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "B:";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(9, 38);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(17, 13);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "A:";
            // 
            // panelNormal
            // 
            this.panelNormal.Controls.Add(this.textBoxDesviacionNormal);
            this.panelNormal.Controls.Add(this.labelDesviacionNormal);
            this.panelNormal.Controls.Add(this.labelNormal);
            this.panelNormal.Controls.Add(this.buttonGenerarNormal);
            this.panelNormal.Controls.Add(this.textBoxMediaNormal);
            this.panelNormal.Controls.Add(this.labelMediaNormal);
            this.panelNormal.Location = new System.Drawing.Point(12, 170);
            this.panelNormal.Name = "panelNormal";
            this.panelNormal.Size = new System.Drawing.Size(198, 268);
            this.panelNormal.TabIndex = 2;
            // 
            // textBoxDesviacionNormal
            // 
            this.textBoxDesviacionNormal.Location = new System.Drawing.Point(79, 61);
            this.textBoxDesviacionNormal.Name = "textBoxDesviacionNormal";
            this.textBoxDesviacionNormal.Size = new System.Drawing.Size(100, 20);
            this.textBoxDesviacionNormal.TabIndex = 12;
            // 
            // labelDesviacionNormal
            // 
            this.labelDesviacionNormal.AutoSize = true;
            this.labelDesviacionNormal.Location = new System.Drawing.Point(10, 64);
            this.labelDesviacionNormal.Name = "labelDesviacionNormal";
            this.labelDesviacionNormal.Size = new System.Drawing.Size(63, 13);
            this.labelDesviacionNormal.TabIndex = 11;
            this.labelDesviacionNormal.Text = "Desviación:";
            // 
            // labelNormal
            // 
            this.labelNormal.AutoSize = true;
            this.labelNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNormal.Location = new System.Drawing.Point(12, 11);
            this.labelNormal.Name = "labelNormal";
            this.labelNormal.Size = new System.Drawing.Size(117, 13);
            this.labelNormal.TabIndex = 10;
            this.labelNormal.Text = "Distribución Normal";
            // 
            // buttonGenerarNormal
            // 
            this.buttonGenerarNormal.Location = new System.Drawing.Point(13, 87);
            this.buttonGenerarNormal.Name = "buttonGenerarNormal";
            this.buttonGenerarNormal.Size = new System.Drawing.Size(120, 23);
            this.buttonGenerarNormal.TabIndex = 9;
            this.buttonGenerarNormal.Text = "Generar";
            this.buttonGenerarNormal.UseVisualStyleBackColor = true;
            this.buttonGenerarNormal.Click += new System.EventHandler(this.ButtonGenerarNormal_Click);
            // 
            // textBoxMediaNormal
            // 
            this.textBoxMediaNormal.Location = new System.Drawing.Point(79, 35);
            this.textBoxMediaNormal.Name = "textBoxMediaNormal";
            this.textBoxMediaNormal.Size = new System.Drawing.Size(100, 20);
            this.textBoxMediaNormal.TabIndex = 8;
            // 
            // labelMediaNormal
            // 
            this.labelMediaNormal.AutoSize = true;
            this.labelMediaNormal.Location = new System.Drawing.Point(34, 38);
            this.labelMediaNormal.Name = "labelMediaNormal";
            this.labelMediaNormal.Size = new System.Drawing.Size(39, 13);
            this.labelMediaNormal.TabIndex = 7;
            this.labelMediaNormal.Text = "Media:";
            // 
            // panelExponencial
            // 
            this.panelExponencial.Controls.Add(this.buttonGenerarExponencial);
            this.panelExponencial.Controls.Add(this.textBoxValorExponencial);
            this.panelExponencial.Controls.Add(this.labelValorExponencial);
            this.panelExponencial.Controls.Add(this.groupBoxExponencial);
            this.panelExponencial.Controls.Add(this.labelExponencial);
            this.panelExponencial.Location = new System.Drawing.Point(12, 170);
            this.panelExponencial.Name = "panelExponencial";
            this.panelExponencial.Size = new System.Drawing.Size(198, 268);
            this.panelExponencial.TabIndex = 3;
            // 
            // buttonGenerarExponencial
            // 
            this.buttonGenerarExponencial.Location = new System.Drawing.Point(16, 165);
            this.buttonGenerarExponencial.Name = "buttonGenerarExponencial";
            this.buttonGenerarExponencial.Size = new System.Drawing.Size(120, 23);
            this.buttonGenerarExponencial.TabIndex = 13;
            this.buttonGenerarExponencial.Text = "Generar";
            this.buttonGenerarExponencial.UseVisualStyleBackColor = true;
            this.buttonGenerarExponencial.Click += new System.EventHandler(this.ButtonGenerarExponencial_Click);
            // 
            // textBoxValorExponencial
            // 
            this.textBoxValorExponencial.Location = new System.Drawing.Point(67, 139);
            this.textBoxValorExponencial.Name = "textBoxValorExponencial";
            this.textBoxValorExponencial.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorExponencial.TabIndex = 11;
            // 
            // labelValorExponencial
            // 
            this.labelValorExponencial.AutoSize = true;
            this.labelValorExponencial.Location = new System.Drawing.Point(27, 142);
            this.labelValorExponencial.Name = "labelValorExponencial";
            this.labelValorExponencial.Size = new System.Drawing.Size(34, 13);
            this.labelValorExponencial.TabIndex = 10;
            this.labelValorExponencial.Text = "Valor:";
            // 
            // groupBoxExponencial
            // 
            this.groupBoxExponencial.Controls.Add(this.radioButtonMedia);
            this.groupBoxExponencial.Controls.Add(this.radioButtonLambda);
            this.groupBoxExponencial.Location = new System.Drawing.Point(14, 47);
            this.groupBoxExponencial.Name = "groupBoxExponencial";
            this.groupBoxExponencial.Size = new System.Drawing.Size(166, 85);
            this.groupBoxExponencial.TabIndex = 8;
            this.groupBoxExponencial.TabStop = false;
            this.groupBoxExponencial.Text = "Ingresar Media/Lambda";
            // 
            // radioButtonMedia
            // 
            this.radioButtonMedia.AutoSize = true;
            this.radioButtonMedia.Checked = true;
            this.radioButtonMedia.Location = new System.Drawing.Point(9, 50);
            this.radioButtonMedia.Name = "radioButtonMedia";
            this.radioButtonMedia.Size = new System.Drawing.Size(54, 17);
            this.radioButtonMedia.TabIndex = 1;
            this.radioButtonMedia.TabStop = true;
            this.radioButtonMedia.Text = "Media";
            this.radioButtonMedia.UseVisualStyleBackColor = true;
            // 
            // radioButtonLambda
            // 
            this.radioButtonLambda.AutoSize = true;
            this.radioButtonLambda.Location = new System.Drawing.Point(9, 27);
            this.radioButtonLambda.Name = "radioButtonLambda";
            this.radioButtonLambda.Size = new System.Drawing.Size(63, 17);
            this.radioButtonLambda.TabIndex = 0;
            this.radioButtonLambda.Text = "Lambda";
            this.radioButtonLambda.UseVisualStyleBackColor = true;
            // 
            // labelExponencial
            // 
            this.labelExponencial.AutoSize = true;
            this.labelExponencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExponencial.Location = new System.Drawing.Point(13, 11);
            this.labelExponencial.Name = "labelExponencial";
            this.labelExponencial.Size = new System.Drawing.Size(154, 26);
            this.labelExponencial.TabIndex = 7;
            this.labelExponencial.Text = "Distribución Exponenecial\r\nNegativa";
            // 
            // panelPoisson
            // 
            this.panelPoisson.Controls.Add(this.labelPoisson);
            this.panelPoisson.Controls.Add(this.buttonGenerarPoisson);
            this.panelPoisson.Controls.Add(this.textBoxMediaPoisson);
            this.panelPoisson.Controls.Add(this.labelMediaPoisson);
            this.panelPoisson.Location = new System.Drawing.Point(12, 170);
            this.panelPoisson.Name = "panelPoisson";
            this.panelPoisson.Size = new System.Drawing.Size(198, 268);
            this.panelPoisson.TabIndex = 4;
            // 
            // labelPoisson
            // 
            this.labelPoisson.AutoSize = true;
            this.labelPoisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoisson.Location = new System.Drawing.Point(9, 11);
            this.labelPoisson.Name = "labelPoisson";
            this.labelPoisson.Size = new System.Drawing.Size(122, 13);
            this.labelPoisson.TabIndex = 6;
            this.labelPoisson.Text = "Distribución Poisson";
            // 
            // buttonGenerarPoisson
            // 
            this.buttonGenerarPoisson.Location = new System.Drawing.Point(12, 87);
            this.buttonGenerarPoisson.Name = "buttonGenerarPoisson";
            this.buttonGenerarPoisson.Size = new System.Drawing.Size(120, 23);
            this.buttonGenerarPoisson.TabIndex = 5;
            this.buttonGenerarPoisson.Text = "Generar";
            this.buttonGenerarPoisson.UseVisualStyleBackColor = true;
            this.buttonGenerarPoisson.Click += new System.EventHandler(this.ButtonGenerarPoisson_Click);
            // 
            // textBoxMediaPoisson
            // 
            this.textBoxMediaPoisson.Location = new System.Drawing.Point(54, 35);
            this.textBoxMediaPoisson.Name = "textBoxMediaPoisson";
            this.textBoxMediaPoisson.Size = new System.Drawing.Size(100, 20);
            this.textBoxMediaPoisson.TabIndex = 1;
            // 
            // labelMediaPoisson
            // 
            this.labelMediaPoisson.AutoSize = true;
            this.labelMediaPoisson.Location = new System.Drawing.Point(9, 38);
            this.labelMediaPoisson.Name = "labelMediaPoisson";
            this.labelMediaPoisson.Size = new System.Drawing.Size(39, 13);
            this.labelMediaPoisson.TabIndex = 0;
            this.labelMediaPoisson.Text = "Media:";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalir.Location = new System.Drawing.Point(417, 445);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // buttonChi2
            // 
            this.buttonChi2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChi2.Location = new System.Drawing.Point(267, 444);
            this.buttonChi2.Name = "buttonChi2";
            this.buttonChi2.Size = new System.Drawing.Size(144, 23);
            this.buttonChi2.TabIndex = 5;
            this.buttonChi2.Text = "Análisis de Chi Cuadrado";
            this.buttonChi2.UseVisualStyleBackColor = true;
            this.buttonChi2.Click += new System.EventHandler(this.ButtonChi2_Click);
            // 
            // dataGridViewMostrar
            // 
            this.dataGridViewMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostrar.Location = new System.Drawing.Point(216, 12);
            this.dataGridViewMostrar.Name = "dataGridViewMostrar";
            this.dataGridViewMostrar.Size = new System.Drawing.Size(276, 426);
            this.dataGridViewMostrar.TabIndex = 6;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 480);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewMostrar);
            this.Controls.Add(this.buttonChi2);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.panelPoisson);
            this.Controls.Add(this.panelExponencial);
            this.Controls.Add(this.panelNormal);
            this.Controls.Add(this.panelUniforme);
            this.Controls.Add(this.groupBoxDistribucion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 519);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 519);
            this.Name = "FormPrincipal";
            this.Text = "Trabajo Práctico 3";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBoxDistribucion.ResumeLayout(false);
            this.groupBoxDistribucion.PerformLayout();
            this.panelUniforme.ResumeLayout(false);
            this.panelUniforme.PerformLayout();
            this.panelNormal.ResumeLayout(false);
            this.panelNormal.PerformLayout();
            this.panelExponencial.ResumeLayout(false);
            this.panelExponencial.PerformLayout();
            this.groupBoxExponencial.ResumeLayout(false);
            this.groupBoxExponencial.PerformLayout();
            this.panelPoisson.ResumeLayout(false);
            this.panelPoisson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDistribucion;
        private System.Windows.Forms.RadioButton radioButtonPoisson;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonExponencial;
        private System.Windows.Forms.RadioButton radioButtonUniformeAB;
        private System.Windows.Forms.Panel panelUniforme;
        private System.Windows.Forms.Panel panelNormal;
        private System.Windows.Forms.Panel panelExponencial;
        private System.Windows.Forms.Panel panelPoisson;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Button buttonGenerarUniforme;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Button buttonChi2;
        private System.Windows.Forms.DataGridView dataGridViewMostrar;
        private System.Windows.Forms.Label labelUniformeAB;
        private System.Windows.Forms.Label labelPoisson;
        private System.Windows.Forms.Button buttonGenerarPoisson;
        private System.Windows.Forms.TextBox textBoxMediaPoisson;
        private System.Windows.Forms.Label labelMediaPoisson;
        private System.Windows.Forms.TextBox textBoxDesviacionNormal;
        private System.Windows.Forms.Label labelDesviacionNormal;
        private System.Windows.Forms.Label labelNormal;
        private System.Windows.Forms.Button buttonGenerarNormal;
        private System.Windows.Forms.TextBox textBoxMediaNormal;
        private System.Windows.Forms.Label labelMediaNormal;
        private System.Windows.Forms.Button buttonGenerarExponencial;
        private System.Windows.Forms.TextBox textBoxValorExponencial;
        private System.Windows.Forms.Label labelValorExponencial;
        private System.Windows.Forms.GroupBox groupBoxExponencial;
        private System.Windows.Forms.RadioButton radioButtonMedia;
        private System.Windows.Forms.RadioButton radioButtonLambda;
        private System.Windows.Forms.Label labelExponencial;
    }
}


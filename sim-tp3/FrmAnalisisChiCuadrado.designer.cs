namespace sim_tp3
{
    partial class FrmAnalisisChiCuadrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnalisisChiCuadrado));
            this.dgvMuestra = new System.Windows.Forms.DataGridView();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.dgvFrecuencia = new System.Windows.Forms.DataGridView();
            this.btnTestChiCuadrado = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.grpIntervalos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadIntervalos = new System.Windows.Forms.TextBox();
            this.rdbAutomatico = new System.Windows.Forms.RadioButton();
            this.rdbManual = new System.Windows.Forms.RadioButton();
            this.grpGeneradorMuestra = new System.Windows.Forms.GroupBox();
            this.btnEliminarMuestra = new System.Windows.Forms.Button();
            this.btnGenerarNumerosAleatorios = new System.Windows.Forms.Button();
            this.txtDecimales = new System.Windows.Forms.TextBox();
            this.txtTamañoMuestraAGenerar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMostrarGrafico = new System.Windows.Forms.Button();
            this.grpAgregarValor = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBoxMediaVarianza = new System.Windows.Forms.GroupBox();
            this.lblVarianzaEsperada = new System.Windows.Forms.Label();
            this.lblVarianzaObservada = new System.Windows.Forms.Label();
            this.lblMediaEsperada = new System.Windows.Forms.Label();
            this.lblMediaObservada = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.lblChiCuadrado = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTamañoMuestra = new System.Windows.Forms.Label();
            this.lblCantidadIntervalos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAjustarIntervalos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencia)).BeginInit();
            this.grpIntervalos.SuspendLayout();
            this.grpGeneradorMuestra.SuspendLayout();
            this.grpAgregarValor.SuspendLayout();
            this.groupBoxMediaVarianza.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMuestra
            // 
            this.dgvMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestra.Location = new System.Drawing.Point(232, 12);
            this.dgvMuestra.Name = "dgvMuestra";
            this.dgvMuestra.Size = new System.Drawing.Size(162, 399);
            this.dgvMuestra.TabIndex = 7;
            this.dgvMuestra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(6, 19);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(202, 20);
            this.txtLista.TabIndex = 0;
            this.txtLista.TextChanged += new System.EventHandler(this.txtLista_TextChanged);
            this.txtLista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLista_KeyDown);
            this.txtLista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLista_KeyPress);
            // 
            // dgvFrecuencia
            // 
            this.dgvFrecuencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrecuencia.Location = new System.Drawing.Point(400, 12);
            this.dgvFrecuencia.Name = "dgvFrecuencia";
            this.dgvFrecuencia.Size = new System.Drawing.Size(388, 325);
            this.dgvFrecuencia.TabIndex = 8;
            this.dgvFrecuencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnTestChiCuadrado
            // 
            this.btnTestChiCuadrado.Location = new System.Drawing.Point(12, 284);
            this.btnTestChiCuadrado.Name = "btnTestChiCuadrado";
            this.btnTestChiCuadrado.Size = new System.Drawing.Size(214, 23);
            this.btnTestChiCuadrado.TabIndex = 3;
            this.btnTestChiCuadrado.Text = "Analizar Muestra";
            this.btnTestChiCuadrado.UseVisualStyleBackColor = true;
            this.btnTestChiCuadrado.Click += new System.EventHandler(this.btnTestChi_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(599, 347);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Estadístico de Prueba:";
            this.label17.DoubleClick += new System.EventHandler(this.lblChiCuadrado_DoubleClick);
            // 
            // grpIntervalos
            // 
            this.grpIntervalos.Controls.Add(this.label2);
            this.grpIntervalos.Controls.Add(this.txtCantidadIntervalos);
            this.grpIntervalos.Controls.Add(this.rdbAutomatico);
            this.grpIntervalos.Controls.Add(this.rdbManual);
            this.grpIntervalos.Location = new System.Drawing.Point(12, 3);
            this.grpIntervalos.Name = "grpIntervalos";
            this.grpIntervalos.Size = new System.Drawing.Size(214, 103);
            this.grpIntervalos.TabIndex = 0;
            this.grpIntervalos.TabStop = false;
            this.grpIntervalos.Text = "Cantidad de Intervalos";
            this.grpIntervalos.Enter += new System.EventHandler(this.grpIntervalos_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad a Utilizar";
            // 
            // txtCantidadIntervalos
            // 
            this.txtCantidadIntervalos.Enabled = false;
            this.txtCantidadIntervalos.Location = new System.Drawing.Point(108, 69);
            this.txtCantidadIntervalos.Name = "txtCantidadIntervalos";
            this.txtCantidadIntervalos.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadIntervalos.TabIndex = 2;
            this.txtCantidadIntervalos.TextChanged += new System.EventHandler(this.txtCantidadIntervalos_TextChanged);
            this.txtCantidadIntervalos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadIntervalos_KeyPress);
            // 
            // rdbAutomatico
            // 
            this.rdbAutomatico.AutoSize = true;
            this.rdbAutomatico.Checked = true;
            this.rdbAutomatico.Location = new System.Drawing.Point(24, 26);
            this.rdbAutomatico.Name = "rdbAutomatico";
            this.rdbAutomatico.Size = new System.Drawing.Size(140, 17);
            this.rdbAutomatico.TabIndex = 0;
            this.rdbAutomatico.TabStop = true;
            this.rdbAutomatico.Text = "Definir Automáticamente";
            this.rdbAutomatico.UseVisualStyleBackColor = true;
            this.rdbAutomatico.CheckedChanged += new System.EventHandler(this.rdbAutomatico_CheckedChanged);
            // 
            // rdbManual
            // 
            this.rdbManual.AutoSize = true;
            this.rdbManual.Location = new System.Drawing.Point(24, 49);
            this.rdbManual.Name = "rdbManual";
            this.rdbManual.Size = new System.Drawing.Size(122, 17);
            this.rdbManual.TabIndex = 1;
            this.rdbManual.Text = "Definir Manualmente";
            this.rdbManual.UseVisualStyleBackColor = true;
            this.rdbManual.CheckedChanged += new System.EventHandler(this.rdbManual_CheckedChanged);
            // 
            // grpGeneradorMuestra
            // 
            this.grpGeneradorMuestra.Controls.Add(this.btnEliminarMuestra);
            this.grpGeneradorMuestra.Controls.Add(this.btnGenerarNumerosAleatorios);
            this.grpGeneradorMuestra.Controls.Add(this.txtDecimales);
            this.grpGeneradorMuestra.Controls.Add(this.txtTamañoMuestraAGenerar);
            this.grpGeneradorMuestra.Controls.Add(this.label1);
            this.grpGeneradorMuestra.Controls.Add(this.label3);
            this.grpGeneradorMuestra.Location = new System.Drawing.Point(12, 112);
            this.grpGeneradorMuestra.Name = "grpGeneradorMuestra";
            this.grpGeneradorMuestra.Size = new System.Drawing.Size(214, 112);
            this.grpGeneradorMuestra.TabIndex = 1;
            this.grpGeneradorMuestra.TabStop = false;
            this.grpGeneradorMuestra.Text = "Generar Muestra de Números Aleatorios";
            // 
            // btnEliminarMuestra
            // 
            this.btnEliminarMuestra.Location = new System.Drawing.Point(6, 81);
            this.btnEliminarMuestra.Name = "btnEliminarMuestra";
            this.btnEliminarMuestra.Size = new System.Drawing.Size(96, 23);
            this.btnEliminarMuestra.TabIndex = 3;
            this.btnEliminarMuestra.Text = "Eliminar Muestra";
            this.btnEliminarMuestra.UseVisualStyleBackColor = true;
            this.btnEliminarMuestra.Click += new System.EventHandler(this.btnEliminarMuestra_Click);
            // 
            // btnGenerarNumerosAleatorios
            // 
            this.btnGenerarNumerosAleatorios.Location = new System.Drawing.Point(108, 81);
            this.btnGenerarNumerosAleatorios.Name = "btnGenerarNumerosAleatorios";
            this.btnGenerarNumerosAleatorios.Size = new System.Drawing.Size(100, 23);
            this.btnGenerarNumerosAleatorios.TabIndex = 2;
            this.btnGenerarNumerosAleatorios.Text = "Generar Muestra";
            this.btnGenerarNumerosAleatorios.UseVisualStyleBackColor = true;
            this.btnGenerarNumerosAleatorios.Click += new System.EventHandler(this.btnGenerarNumerosAleatorios_Click);
            // 
            // txtDecimales
            // 
            this.txtDecimales.Location = new System.Drawing.Point(108, 55);
            this.txtDecimales.Name = "txtDecimales";
            this.txtDecimales.Size = new System.Drawing.Size(100, 20);
            this.txtDecimales.TabIndex = 1;
            this.txtDecimales.Text = "4";
            this.txtDecimales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // txtTamañoMuestraAGenerar
            // 
            this.txtTamañoMuestraAGenerar.Location = new System.Drawing.Point(108, 29);
            this.txtTamañoMuestraAGenerar.Name = "txtTamañoMuestraAGenerar";
            this.txtTamañoMuestraAGenerar.Size = new System.Drawing.Size(100, 20);
            this.txtTamañoMuestraAGenerar.TabIndex = 0;
            this.txtTamañoMuestraAGenerar.Text = "30";
            this.txtTamañoMuestraAGenerar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maximo Decimales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad a Generar";
            // 
            // btnMostrarGrafico
            // 
            this.btnMostrarGrafico.Enabled = false;
            this.btnMostrarGrafico.Location = new System.Drawing.Point(602, 388);
            this.btnMostrarGrafico.Name = "btnMostrarGrafico";
            this.btnMostrarGrafico.Size = new System.Drawing.Size(90, 23);
            this.btnMostrarGrafico.TabIndex = 4;
            this.btnMostrarGrafico.Text = "Mostrar Gráfico";
            this.btnMostrarGrafico.UseVisualStyleBackColor = true;
            this.btnMostrarGrafico.Click += new System.EventHandler(this.button2_Click);
            // 
            // grpAgregarValor
            // 
            this.grpAgregarValor.Controls.Add(this.txtLista);
            this.grpAgregarValor.Location = new System.Drawing.Point(12, 230);
            this.grpAgregarValor.Name = "grpAgregarValor";
            this.grpAgregarValor.Size = new System.Drawing.Size(214, 48);
            this.grpAgregarValor.TabIndex = 2;
            this.grpAgregarValor.TabStop = false;
            this.grpAgregarValor.Text = "Agregar Valor Específico a la Muestra";
            this.grpAgregarValor.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(438, 347);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Tamaño Muestra:";
            // 
            // groupBoxMediaVarianza
            // 
            this.groupBoxMediaVarianza.Controls.Add(this.lblVarianzaEsperada);
            this.groupBoxMediaVarianza.Controls.Add(this.lblVarianzaObservada);
            this.groupBoxMediaVarianza.Controls.Add(this.lblMediaEsperada);
            this.groupBoxMediaVarianza.Controls.Add(this.lblMediaObservada);
            this.groupBoxMediaVarianza.Controls.Add(this.label23);
            this.groupBoxMediaVarianza.Controls.Add(this.label22);
            this.groupBoxMediaVarianza.Controls.Add(this.label20);
            this.groupBoxMediaVarianza.Controls.Add(this.label21);
            this.groupBoxMediaVarianza.Location = new System.Drawing.Point(13, 314);
            this.groupBoxMediaVarianza.Name = "groupBoxMediaVarianza";
            this.groupBoxMediaVarianza.Size = new System.Drawing.Size(213, 97);
            this.groupBoxMediaVarianza.TabIndex = 11;
            this.groupBoxMediaVarianza.TabStop = false;
            this.groupBoxMediaVarianza.Text = "Media y Varianza";
            // 
            // lblVarianzaEsperada
            // 
            this.lblVarianzaEsperada.AutoSize = true;
            this.lblVarianzaEsperada.Location = new System.Drawing.Point(122, 79);
            this.lblVarianzaEsperada.Name = "lblVarianzaEsperada";
            this.lblVarianzaEsperada.Size = new System.Drawing.Size(10, 13);
            this.lblVarianzaEsperada.TabIndex = 4;
            this.lblVarianzaEsperada.Text = "-";
            // 
            // lblVarianzaObservada
            // 
            this.lblVarianzaObservada.AutoSize = true;
            this.lblVarianzaObservada.Location = new System.Drawing.Point(122, 60);
            this.lblVarianzaObservada.Name = "lblVarianzaObservada";
            this.lblVarianzaObservada.Size = new System.Drawing.Size(10, 13);
            this.lblVarianzaObservada.TabIndex = 4;
            this.lblVarianzaObservada.Text = "-";
            // 
            // lblMediaEsperada
            // 
            this.lblMediaEsperada.AutoSize = true;
            this.lblMediaEsperada.Location = new System.Drawing.Point(122, 41);
            this.lblMediaEsperada.Name = "lblMediaEsperada";
            this.lblMediaEsperada.Size = new System.Drawing.Size(10, 13);
            this.lblMediaEsperada.TabIndex = 4;
            this.lblMediaEsperada.Text = "-";
            // 
            // lblMediaObservada
            // 
            this.lblMediaObservada.AutoSize = true;
            this.lblMediaObservada.Location = new System.Drawing.Point(122, 22);
            this.lblMediaObservada.Name = "lblMediaObservada";
            this.lblMediaObservada.Size = new System.Drawing.Size(10, 13);
            this.lblMediaObservada.TabIndex = 4;
            this.lblMediaObservada.Text = "-";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(17, 79);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(99, 13);
            this.label23.TabIndex = 3;
            this.label23.Text = "Varianza Esperada:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 60);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(106, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Varianza Observada:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(29, 41);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Media Esperada:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(22, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Media Observada:";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(698, 388);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(90, 23);
            this.buttonVolver.TabIndex = 6;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Enabled = false;
            this.btnExportarExcel.Location = new System.Drawing.Point(501, 388);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(95, 23);
            this.btnExportarExcel.TabIndex = 5;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.buttonExportarExcel_Click);
            // 
            // lblChiCuadrado
            // 
            this.lblChiCuadrado.AutoSize = true;
            this.lblChiCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiCuadrado.Location = new System.Drawing.Point(742, 347);
            this.lblChiCuadrado.Name = "lblChiCuadrado";
            this.lblChiCuadrado.Size = new System.Drawing.Size(11, 13);
            this.lblChiCuadrado.TabIndex = 14;
            this.lblChiCuadrado.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(578, 366);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(198, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "Con este valor se puede entrar a la tabla";
            this.label19.Visible = false;
            // 
            // lblTamañoMuestra
            // 
            this.lblTamañoMuestra.AutoSize = true;
            this.lblTamañoMuestra.Location = new System.Drawing.Point(535, 347);
            this.lblTamañoMuestra.Name = "lblTamañoMuestra";
            this.lblTamañoMuestra.Size = new System.Drawing.Size(10, 13);
            this.lblTamañoMuestra.TabIndex = 4;
            this.lblTamañoMuestra.Text = "-";
            // 
            // lblCantidadIntervalos
            // 
            this.lblCantidadIntervalos.AutoSize = true;
            this.lblCantidadIntervalos.Location = new System.Drawing.Point(535, 366);
            this.lblCantidadIntervalos.Name = "lblCantidadIntervalos";
            this.lblCantidadIntervalos.Size = new System.Drawing.Size(10, 13);
            this.lblCantidadIntervalos.TabIndex = 4;
            this.lblCantidadIntervalos.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad De Intervalos:";
            // 
            // btnAjustarIntervalos
            // 
            this.btnAjustarIntervalos.Enabled = false;
            this.btnAjustarIntervalos.Location = new System.Drawing.Point(400, 388);
            this.btnAjustarIntervalos.Name = "btnAjustarIntervalos";
            this.btnAjustarIntervalos.Size = new System.Drawing.Size(95, 23);
            this.btnAjustarIntervalos.TabIndex = 5;
            this.btnAjustarIntervalos.Text = "Ajustar intervalos";
            this.btnAjustarIntervalos.UseVisualStyleBackColor = true;
            this.btnAjustarIntervalos.Click += new System.EventHandler(this.buttonAjustarIntevalos_Click);
            // 
            // FrmAnalisisChiCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.ControlBox = false;
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblCantidadIntervalos);
            this.Controls.Add(this.lblChiCuadrado);
            this.Controls.Add(this.lblTamañoMuestra);
            this.Controls.Add(this.btnAjustarIntervalos);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.groupBoxMediaVarianza);
            this.Controls.Add(this.grpAgregarValor);
            this.Controls.Add(this.btnMostrarGrafico);
            this.Controls.Add(this.grpGeneradorMuestra);
            this.Controls.Add(this.grpIntervalos);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnTestChiCuadrado);
            this.Controls.Add(this.dgvFrecuencia);
            this.Controls.Add(this.dgvMuestra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 462);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 462);
            this.Name = "FrmAnalisisChiCuadrado";
            this.Text = "Analizador de Muestras";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencia)).EndInit();
            this.grpIntervalos.ResumeLayout(false);
            this.grpIntervalos.PerformLayout();
            this.grpGeneradorMuestra.ResumeLayout(false);
            this.grpGeneradorMuestra.PerformLayout();
            this.grpAgregarValor.ResumeLayout(false);
            this.grpAgregarValor.PerformLayout();
            this.groupBoxMediaVarianza.ResumeLayout(false);
            this.groupBoxMediaVarianza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMuestra;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.DataGridView dgvFrecuencia;
        private System.Windows.Forms.Button btnTestChiCuadrado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox grpIntervalos;
        private System.Windows.Forms.TextBox txtCantidadIntervalos;
        private System.Windows.Forms.RadioButton rdbAutomatico;
        private System.Windows.Forms.RadioButton rdbManual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpGeneradorMuestra;
        private System.Windows.Forms.Button btnGenerarNumerosAleatorios;
        private System.Windows.Forms.TextBox txtTamañoMuestraAGenerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMostrarGrafico;
        private System.Windows.Forms.GroupBox grpAgregarValor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnEliminarMuestra;
        private System.Windows.Forms.TextBox txtDecimales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMediaVarianza;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Label lblChiCuadrado;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblMediaObservada;
        private System.Windows.Forms.Label lblVarianzaEsperada;
        private System.Windows.Forms.Label lblVarianzaObservada;
        private System.Windows.Forms.Label lblMediaEsperada;
        private System.Windows.Forms.Label lblTamañoMuestra;
        private System.Windows.Forms.Label lblCantidadIntervalos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAjustarIntervalos;
    }
}


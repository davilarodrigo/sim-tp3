using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace sim_tp3
{
    public partial class FrmAnalisisChiCuadrado : Form
    {
        #region declaracion variables

        bool muestraAnalizada=false;

        List<int> frecuenciasObservada;
        List<double> limitesInferioresDeIntervalos;
        List<double> limitesSuperioresDeIntervalos;
        int frecuenciaEsperada;
        string modoFuncionamiento = "uniforme01";

        bool cantidadIntervalosManual;

        AnalizadorDeMuestra analizadorDeMuestra;

        List<double> muestra = new List<double>();

        #endregion

        void generarMuestraAleatoria() {
            Random random = new Random();
            if (txtTamañoMuestraAGenerar.Text=="")
            {
                MessageBox.Show("Ingrese la cantidad de valores a generar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtDecimales.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad maxima de decimales que los numeros generados podran tener", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int n = Convert.ToInt32(txtTamañoMuestraAGenerar.Text); // tamaño muestra
            int d = Convert.ToInt32(txtDecimales.Text); // max numero de decimales

            if (d==0)
            {
                MessageBox.Show("Ingrese una cantidad valida de decimales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (d >= 16)
            {
                MessageBox.Show("El numero de decimales debe ser igual o menor a 15", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (n == 0)
            {
                MessageBox.Show("Ingrese una cantidad de numeros a generar valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            limpiarMuestra();

            for (int i = 0; i < n; i++) muestra.Add(Math.Round(random.NextDouble(), d));

            cargarGridMuestra();
        }

        void cargarGridMuestra()
        {
            this.dgvMuestra.Rows.Clear();
            for (int i = 0; i < muestra.Count; i++)
            {
                dgvMuestra.Rows.Add(i+1, muestra[i]);
            }

        }

        void limpiarMuestra()
        {
            dgvMuestra.Rows.Clear();
            dgvFrecuencia.Rows.Clear();


            lblTamanoMuestra.Text = "Tamaño Muestra:";
            lblChiCuadrado.Text = "Estadístico de Prueba:";
            labelMediaObservada.Text = "-";
            labelVarianzaObservada.Text = "-";
            lblMediaEsperada.Text = "Media Esperada:    -";
            lblVarianzaEsperada.Text = "Varianza Esperada:    -";
            labelChiCuadrado.Text = "-";
            labelTamanoMuestra.Text = "-";


            muestraAnalizada = false;

            muestra = null; 
            muestra = new List<double>();
        }

        public FrmAnalisisChiCuadrado(List<double> muestra)
        {
            InitializeComponent();
            this.muestra = muestra;
            
            grpGeneradorMuestra.Enabled = false;
            grpAgregarValor.Enabled = false;

            this.configurarDataGridViews();
            this.cargarGridMuestra();
        }

        public FrmAnalisisChiCuadrado(List<double> muestra, string distribucion)
        {
            InitializeComponent();
            this.muestra = muestra;

            grpGeneradorMuestra.Enabled = false;
            grpAgregarValor.Enabled = false;

            this.configurarDataGridViews();
            this.cargarGridMuestra();
        }

        private void configurarDistribucion(string distribucion)
        {
            if (distribucion == "uniformeAB")
            {
                this.modoFuncionamiento = "uniformeAB";
            } else if (distribucion == "exponencial") {
                this.modoFuncionamiento = "exponencial";
            } else if (distribucion == "normal") {
                this.modoFuncionamiento = "normal";
            } else{
                this.modoFuncionamiento = "poisson";
            }
        }

        public FrmAnalisisChiCuadrado()
        {
            InitializeComponent();
        }

        void configurarGroupBoxIntervalos()
        {
            cantidadIntervalosManual = rdbManual.Checked;
            txtCantidadIntervalos.Enabled = cantidadIntervalosManual;            
        }
               
        void agregarValorAMuestra()
        {
            string texto=txtLista.Text.ToString();
            double numero = Convert.ToInt32(texto);

            for (int i = 0; i < texto.Length; i++) numero /= 10;

            txtLista.Clear();
            muestra.Add(numero);
            dgvMuestra.Rows.Add(dgvMuestra.Rows.Count, numero);
        }

        void configurarDataGridViews() {
            dgvFrecuencia.ColumnCount = 5;
            dgvFrecuencia.Columns[0].HeaderText = "Inicio del Intervalo";
            dgvFrecuencia.Columns[1].HeaderText = "Fin del Intervalo";
            dgvFrecuencia.Columns[2].HeaderText = "Frecuencia Observada";
            dgvFrecuencia.Columns[3].HeaderText = "Frecuencia Esperada";
            dgvFrecuencia.Columns[4].HeaderText = "Estadístico de Prueba (parcial)";

            dgvFrecuencia.Columns[0].Width = 60;
            dgvFrecuencia.Columns[1].Width = 60;
            dgvFrecuencia.Columns[2].Width = 65;
            dgvFrecuencia.Columns[3].Width = 65;
            dgvFrecuencia.Columns[4].Width = 70;

            dgvMuestra.ColumnCount = 2;
            dgvMuestra.Columns[1].HeaderText = "Muestra";
            dgvMuestra.Columns[1].Width = 65;
            dgvMuestra.Columns[0].HeaderText = "Iterac.";
            dgvMuestra.Columns[0].Width = 50;
        }

     
        private void btnTestChi_Click(object sender, EventArgs e)
        {
            if (muestra.Count == 0)
            {
                MessageBox.Show("Se debe generar una muestra antes de analizarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLista.Focus();
                return;
            }

            dgvFrecuencia.Rows.Clear();

            this.buttonExportarExcel.Enabled = true;
            this.btnMostrarGrafico.Enabled = true;

            analizadorDeMuestra = new AnalizadorDeMuestra(muestra);

            if (cantidadIntervalosManual)
            {
                if (txtCantidadIntervalos.Text=="")
                {
                    MessageBox.Show("Ingrese Una Cantidad de intervalos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int cantidadIntervalos = Convert.ToInt32( txtCantidadIntervalos.Text);

                frecuenciasObservada = analizadorDeMuestra.FrecuenciasObservadasUniforme01(cantidadIntervalos);
            }
            else
            {
                frecuenciasObservada = analizadorDeMuestra.FrecuenciasObservadasUniforme01();
            }

            limitesSuperioresDeIntervalos = analizadorDeMuestra.LimitesSuperioresDeIntervalos;
            limitesInferioresDeIntervalos = analizadorDeMuestra.LimitesInferioresDeIntervalos;

            frecuenciaEsperada = analizadorDeMuestra.FrecuenciaEsperadaUniforme01();

            //lblTamanoMuestra.Text = "Tamaño Muestra = " + muestra.Count.ToString();
            labelTamanoMuestra.Text = muestra.Count.ToString();
            //lblChiCuadrado.Text = "Chi Cuadrado = "+ analizadorDeMuestra.calcularChiCuadrado().ToString();
            labelChiCuadrado.Text = analizadorDeMuestra.calcularChiCuadrado().ToString();
            List<double> estadisticosPrueba = analizadorDeMuestra.obtenerEstadisticoPrueba();

            for (int i = 0; i < frecuenciasObservada.Count; i++)
            {
                dgvFrecuencia.Rows.Add(limitesInferioresDeIntervalos[i], limitesSuperioresDeIntervalos[i],frecuenciasObservada[i],frecuenciaEsperada, estadisticosPrueba[i]);
            }

            muestraAnalizada = true;

            this.labelEntrarTabla.Visible = true;

            this.lblMediaEsperada.Text = "Media Esperada:    0.5";
            this.lblVarianzaEsperada.Text = "Varianza Esperada:    0.0833";
            double media;
            double sumatoria = 0;
            for (int i = 0; i < muestra.Count(); i++)
            {
                sumatoria += muestra[i];
            }
            media = Math.Truncate(sumatoria / Convert.ToDouble(muestra.Count())*10000)/10000;
            //this.lblMediaObservada.Text += " " + media.ToString();
            this.labelMediaObservada.Text = media.ToString();

            double sumatoria2 = 0;
            for (int i = 0; i < muestra.Count(); i++)
            {
                sumatoria2 += (Math.Pow(muestra[i] - (double)media, 2));
            }
            double varianza = Math.Truncate(sumatoria2 / Convert.ToDouble(muestra.Count()-1) * 10000) / 10000;
            //this.lblVarianzaObservada.Text += " " + varianza.ToString();
            this.labelVarianzaObservada.Text = varianza.ToString();
        }

        //private List<int> FrecuenciasObservadas01()
        //{

        //}

        private void button2_Click(object sender, EventArgs e)
        {
            if (!muestraAnalizada)
            {
                MessageBox.Show("Debe Generar y Analizar la muestra antes de generar el grafico", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmGrafico grafico = new FrmGrafico(frecuenciasObservada, frecuenciaEsperada);
            //grafico.recibirParametro();
            grafico.ShowDialog();
        }

        #region otros

        private void Form1_Load(object sender, EventArgs e)
        {
            configurarDataGridViews();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            agregarValorAMuestra();
        }

        private void txtLista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;              
        }

        private void txtLista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtLista.Text!="")
                {
                agregarValorAMuestra();
                }
            }
        }

        private void txtLista_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rdbAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            configurarGroupBoxIntervalos();
        }

        private void rdbManual_CheckedChanged(object sender, EventArgs e)
        {
            configurarGroupBoxIntervalos();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtCantidadIntervalos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminarMuestra_Click(object sender, EventArgs e)
        {
            limpiarMuestra();
            btnTestChiCuadrado.Enabled = false;
            buttonExportarExcel.Enabled = false;
            btnMostrarGrafico.Enabled = false;
            this.labelEntrarTabla.Visible = false;
        }

        private void btnGenerarNumerosAleatorios_Click(object sender, EventArgs e)
        {
            generarMuestraAleatoria();
            btnTestChiCuadrado.Enabled = true;
        }

        private void grpIntervalos_Enter(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblChiCuadrado_DoubleClick(object sender, EventArgs e)
        {
            btnTestChiCuadrado.Enabled = true;
            //limpiarMuestra();
            //btnTestChiCuadrado.Enabled = false;
        }

        private void buttonExportarExcel_Click(object sender, EventArgs e)
        {
            //FrmGrafico grafico = new FrmGrafico(frecuenciasObservada, frecuenciaEsperada);
            //Chart chart1 = grafico.devolverGrafico();
            //grafico.Dispose();
            //chart1.SaveImage(".\\hola.png", ChartImageFormat.Png);

            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Hoja1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Lista Aleatoria";
            // storing header part in Excel  
            for (int i = 1; i < this.dgvMuestra.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = this.dgvMuestra.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < this.dgvMuestra.Rows.Count - 1; i++)
            {
                for (int j = 0; j < this.dgvMuestra.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = this.dgvMuestra.Rows[i].Cells[j].Value.ToString();
                }
            }

            worksheet.Cells[1, 5] = "Observada";
            worksheet.Cells[1, 6] = "Esperada";
            worksheet.Cells[2, 4] = "Media";
            worksheet.Cells[3, 4] = "Varianza";
            worksheet.Cells[2, 5] = this.labelMediaObservada.Text;
            worksheet.Cells[2, 6] = this.labelVarianzaObservada.Text;
            worksheet.Cells[3, 5] = "0.5";
            worksheet.Cells[3, 6] = "0.0833";
            worksheet.Cells[2, 9] = "Estadístico de Prueba";
            worksheet.Cells[2, 10] = this.labelChiCuadrado.Text;

            //worksheet.Columns.Width = 100;

            for (int i = 1; i < this.dgvFrecuencia.Columns.Count + 1; i++)
            {
                worksheet.Cells[5, i+3] = this.dgvFrecuencia.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < this.dgvFrecuencia.Rows.Count - 1; i++)
            {
                for (int j = 0; j < this.dgvFrecuencia.Columns.Count; j++)
                {
                    worksheet.Cells[i + 6, j + 4] = this.dgvFrecuencia.Rows[i].Cells[j].Value.ToString();
                }
            }

            Microsoft.Office.Interop.Excel.Range chartRange;

            Microsoft.Office.Interop.Excel.ChartObjects xlCharts = (Microsoft.Office.Interop.Excel.ChartObjects)worksheet.ChartObjects(Type.Missing);
            Microsoft.Office.Interop.Excel.ChartObject myChart = (Microsoft.Office.Interop.Excel.ChartObject)xlCharts.Add(500,100,500,300);
            Microsoft.Office.Interop.Excel.Chart chartPage = myChart.Chart;

            int cantIntervalos = dgvFrecuencia.Rows.Count;
            chartRange = worksheet.get_Range("F5", "G" + (cantIntervalos+5).ToString());
            chartPage.SetSourceData(chartRange, System.Reflection.Missing.Value);
            chartPage.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered;
            //myChart.TopLeftCell = worksheet.Cells[3, 10];

            //worksheet.Shapes.AddPicture(".\\hola.jpg", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 50, 50, 300, 45);
            // save the application
            //workbook.SaveAs(".\\output"+documentoExcel.ToString()+".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //documentoExcel += 1;
            // Exit from the application  
            //app.Quit();
        }
    }
}
#endregion
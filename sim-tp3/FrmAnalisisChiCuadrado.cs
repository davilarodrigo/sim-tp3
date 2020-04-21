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

        List<int> frecuenciasObservadas;
        List<int> frecuenciasEsperadas;
        List<double> limitesInferioresDeIntervalos;
        List<double> limitesSuperioresDeIntervalos;

        bool cantidadIntervalosManual;

        AnalizadorDeMuestra analizadorDeMuestra;

        List<double> muestra = new List<double>();

        #endregion

        #region constructores 

        public FrmAnalisisChiCuadrado(List<double> muestra, double varianzaEsperada )
        {
            this.muestra = muestra;
            construirFormulario();
            label23.Text = varianzaEsperada.ToString();            
        }
        
        public FrmAnalisisChiCuadrado(List<double> muestra)
        {
            this.muestra = muestra;
            construirFormulario();
        }

        public FrmAnalisisChiCuadrado()
        {
            construirFormulario();
        }

        private void construirFormulario()
        {
            InitializeComponent();

            grpGeneradorMuestra.Enabled = false;
            grpAgregarValor.Enabled = false;

            configurarDataGridViews();
            cargarGridMuestra();
        }

        #endregion

        #region funciones principales

        private void analizarMuestra()
        {
            if (muestra.Count == 0)
            {
                MessageBox.Show("Se debe generar una muestra antes de analizarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLista.Focus();
                return;
            }

            dgvFrecuencia.Rows.Clear();

            int cantidadIntervalos; //por defecto es cero, para el modo automatico
                       
            if (cantidadIntervalosManual)
            {
                if (txtCantidadIntervalos.Text == "")
                {
                    MessageBox.Show("Ingrese Una Cantidad de intervalos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cantidadIntervalos = Convert.ToInt32(txtCantidadIntervalos.Text);
            }
            else cantidadIntervalos = (int)Math.Floor(Math.Sqrt(muestra.Count)); //q los intervalos sean raiz del tamaño de muestra
            
            btnExportarExcel.Enabled = true;
            btnMostrarGrafico.Enabled = true;
            lblCantidadIntervalos.Text = cantidadIntervalos.ToString();

            //a partir de este punto ya esta todo validado, y se comienza a analizar la muestra
            analizadorDeMuestra = new AnalizadorDeMuestra(muestra,
                                                          cantidadIntervalos,
                                                          AnalizadorDeMuestra.TiposDistribucion.Uniforme);

            frecuenciasObservadas = analizadorDeMuestra.ObtenerFrecuenciasObservadas;            
            frecuenciasEsperadas = analizadorDeMuestra.ObtenerFrecuenciasEsperadas;

            limitesSuperioresDeIntervalos = analizadorDeMuestra.ObtenerLimitesSuperioresDeIntervalos;
            limitesInferioresDeIntervalos = analizadorDeMuestra.ObtenerLimitesInferioresDeIntervalos;

            lblTamañoMuestra.Text = muestra.Count.ToString();
            lblChiCuadrado.Text = analizadorDeMuestra.ObtenerChiCuadrado().ToString();

            List<double> estadisticosPrueba = analizadorDeMuestra.obtenerEstadisticoPrueba();

            for (int i = 0; i < cantidadIntervalos; i++)
            {
                //linea con mas problemas q flancito
                dgvFrecuencia.Rows.Add(limitesInferioresDeIntervalos[i], limitesSuperioresDeIntervalos[i], frecuenciasObservadas[i], frecuenciasEsperadas[i], estadisticosPrueba[i]);
            }

            muestraAnalizada = true;

            this.label19.Visible = true;


            double media;
            double sumatoria = 0;
            for (int i = 0; i < muestra.Count(); i++)
            {
                sumatoria += muestra[i];
            }
            media = Math.Truncate(sumatoria / Convert.ToDouble(muestra.Count()) * 10000) / 10000;
            //this.lblMediaObservada.Text += " " + media.ToString();
            lblMediaObservada.Text = media.ToString();

            double sumatoria2 = 0;
            for (int i = 0; i < muestra.Count(); i++)
            {
                sumatoria2 += (Math.Pow(muestra[i] - (double)media, 2));
            }
            double varianza = Math.Truncate(sumatoria2 / Convert.ToDouble(muestra.Count() - 1) * 10000) / 10000;
            //this.lblVarianzaObservada.Text += " " + varianza.ToString();
            lblVarianzaObservada.Text = varianza.ToString();
        }
      
        private void mostrarGrafico()
        {
            if (!muestraAnalizada)
            {
                MessageBox.Show("Debe Generar y Analizar la muestra antes de generar el grafico", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmGrafico grafico = new FrmGrafico(frecuenciasObservadas, frecuenciasEsperadas);
            //grafico.recibirParametro();
            grafico.ShowDialog();
        }

        private void generarMuestraAleatoria()
        {
            Random random = new Random();
            if (txtTamañoMuestraAGenerar.Text == "")
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

            if (d == 0)
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
        #endregion 

        #region funciones secundarias
        void agregarValorAMuestra()
        {
            string texto = txtLista.Text.ToString();
            double numero = Convert.ToInt32(texto);

            for (int i = 0; i < texto.Length; i++) numero /= 10;

            txtLista.Clear();
            muestra.Add(numero);
            dgvMuestra.Rows.Add(dgvMuestra.Rows.Count, numero);
        }


        void limpiarMuestra()
        {
            dgvMuestra.Rows.Clear();
            dgvFrecuencia.Rows.Clear();


            label18.Text = "Tamaño Muestra:";
            label17.Text = "Estadístico de Prueba:";
            lblMediaObservada.Text = "-";
            //labelVarianzaObservada.Text = "-";
            label20.Text = "Media Esperada:    -";
            label23.Text = "Varianza Esperada:    -";
            lblChiCuadrado.Text = "-";
            //labelTamanoMuestra.Text = "-";


            muestraAnalizada = false;

            muestra = null;
            muestra = new List<double>();
        }
        void configurarGroupBoxIntervalos()
        {
            cantidadIntervalosManual = rdbManual.Checked;
            txtCantidadIntervalos.Enabled = cantidadIntervalosManual;
        }
        void configurarDataGridViews()
        {
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
        void cargarGridMuestra()
        {
            this.dgvMuestra.Rows.Clear();
            for (int i = 0; i < muestra.Count; i++)
            {
                dgvMuestra.Rows.Add(i + 1, muestra[i]);
            }

        }

        #endregion

        #region propiedades y otros

        private void button2_Click(object sender, EventArgs e)
        {
            mostrarGrafico();
        }


        private void btnTestChi_Click(object sender, EventArgs e)
        {
            analizarMuestra();
        }


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
            btnExportarExcel.Enabled = false;
            btnMostrarGrafico.Enabled = false;
            this.label19.Visible = false;
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
            worksheet.Cells[2, 5] = lblMediaObservada.Text;
            worksheet.Cells[2, 6] = lblVarianzaObservada.Text;
            worksheet.Cells[3, 5] = "0.5";
            worksheet.Cells[3, 6] = "0.0833";
            worksheet.Cells[2, 9] = "Estadístico de Prueba";
            worksheet.Cells[2, 10] = lblChiCuadrado.Text;

            //worksheet.Columns.Width = 100;

            for (int i = 1; i < dgvFrecuencia.Columns.Count + 1; i++)
            {
                worksheet.Cells[5, i+3] = dgvFrecuencia.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvFrecuencia.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvFrecuencia.Columns.Count; j++)
                {
                    worksheet.Cells[i + 6, j + 4] = dgvFrecuencia.Rows[i].Cells[j].Value.ToString();
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

        private void txtCantidadIntervalos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
#endregion
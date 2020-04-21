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
    public partial class FrmGrafico : Form
    {
        List<int> frecuenciasObservadas;
        List<int> frecuenciasEsperadas;

        public FrmGrafico(List<int> frecuenciasObservadas, List<int> frecuenciasEsperadas)
        {
            this.frecuenciasObservadas = frecuenciasObservadas;
            this.frecuenciasEsperadas = frecuenciasEsperadas;
            InitializeComponent();
        }

        public System.Windows.Forms.DataVisualization.Charting.Chart devolverGrafico()
        {
            return chart1;
        }
    

        private void Grafico_Load(object sender, EventArgs e)
        {
            var chart = chart1.ChartAreas[0];
            
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisX.Minimum = 0;
            chart.AxisY.Minimum = 0;

            chart.AxisX.Interval = 1;
            //chart.AxisY.Interval = 1;

            chart1.Series.Add("Observada");
            chart1.Series["Observada"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["Observada"].Color = Color.CornflowerBlue;

            chart1.Series.Add("Esperada");
            chart1.Series["Esperada"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["Esperada"].Color = Color.Orange;

            for (int i = 0; i < frecuenciasObservadas.Count; i++)
            {
                chart1.Series["Observada"].Points.AddXY(i+1,frecuenciasObservadas[i]);
                chart1.Series["Esperada"].Points.AddXY(i+1, frecuenciasEsperadas[i]);
            }
        }
    }
}

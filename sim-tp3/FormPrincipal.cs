using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sim_tp3
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private List<double> listaChi = new List<double>();

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.SetearFormulario();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            // CerrarExcels();
            this.Dispose();
        }

        private void ButtonGenerarUniforme_Click(object sender, EventArgs e)
        {
            this.dataGridViewMostrar.Rows.Clear();
            this.listaChi = new List<double>();
            int cantidadVueltas = Int32.Parse(this.textBoxN.Text);
            int a = Int32.Parse(this.textBoxA.Text);
            int b = Int32.Parse(this.textBoxB.Text);

            for (int i = 0; i < cantidadVueltas; i++)
            {
                int numero = GeneradorDistribuciones.UniformeAB(a, b);
                this.dataGridViewMostrar.Rows.Add(i+1, numero);
                this.listaChi.Add(numero);
            }

            if (this.dataGridViewMostrar.Rows.Count > 0)
            {
                this.buttonChi2.Enabled = true;
            }
        }

        private void ButtonGenerarPoisson_Click(object sender, EventArgs e)
        {
            this.dataGridViewMostrar.Rows.Clear();
            this.listaChi = new List<double>();
            int cantidadVueltas = Int32.Parse(this.textBoxN.Text);
            int media = Int32.Parse(this.textBoxMediaPoisson.Text);

            for (int i = 0; i < cantidadVueltas; i++)
            {
                int numero = GeneradorDistribuciones.Poisson(media);
                this.dataGridViewMostrar.Rows.Add(i+1, numero);
                this.listaChi.Add(numero);
            }

            if (this.dataGridViewMostrar.Rows.Count > 0)
            {
                this.buttonChi2.Enabled = true;
            }
        }

        private void ButtonGenerarNormal_Click(object sender, EventArgs e)
        {
            this.dataGridViewMostrar.Rows.Clear();
            this.listaChi = new List<double>();
            int cantidadVueltas;
            int nIngresado = Int32.Parse(this.textBoxN.Text);

            if (nIngresado % 2 == 0)
            {
                cantidadVueltas = nIngresado / 2;
            }
            else
            {
                cantidadVueltas = (nIngresado / 2) + 1;
            }
            int media = Int32.Parse(this.textBoxMediaNormal.Text);
            int desviacion = Int32.Parse(this.textBoxDesviacionNormal.Text);
            int index = 1;

            for (int i = 0; i < cantidadVueltas; i++)
            {
                List<double> lista = GeneradorDistribuciones.NormalBoxMuller(media, desviacion);
                this.dataGridViewMostrar.Rows.Add(index, lista[0]);
                this.dataGridViewMostrar.Rows.Add(index + 1, lista[1]);
                this.listaChi.Add(lista[0]);
                this.listaChi.Add(lista[1]);
                index += 2;
            }

            if(nIngresado % 2 != 0)
            {
                this.dataGridViewMostrar.Rows.RemoveAt(this.dataGridViewMostrar.Rows.Count - 2);
            }

            if (this.dataGridViewMostrar.Rows.Count > 0)
            {
                this.buttonChi2.Enabled = true;
            }
        }

        private void ButtonGenerarExponencial_Click(object sender, EventArgs e)
        {
            this.dataGridViewMostrar.Rows.Clear();
            this.listaChi = new List<double>();
            int cantidadVueltas = Int32.Parse(this.textBoxN.Text);
            double lambda;
            
            if(this.radioButtonMedia.Checked == true)
            {
                lambda = 1 / (Convert.ToDouble(this.textBoxValorExponencial.Text));
            }
            else
            {
                lambda = Convert.ToDouble(this.textBoxValorExponencial.Text);
            }

            for (int i = 0; i < cantidadVueltas; i++)
            {
                double numero = GeneradorDistribuciones.ExponencialNegativa(lambda);
                this.dataGridViewMostrar.Rows.Add(i + 1, numero);
                this.listaChi.Add(numero);
            }

            if (this.dataGridViewMostrar.Rows.Count > 0)
            {
                this.buttonChi2.Enabled = true;
            }
        }

        private void SetearFormulario()
        {
            this.dataGridViewMostrar.ColumnCount = 2;
            this.dataGridViewMostrar.Columns[0].HeaderText = "Iteración";
            this.dataGridViewMostrar.Columns[1].HeaderText = "Número";

            this.radioButtonUniformeAB.Checked = true;
            this.radioButtonExponencial.Checked = false;
            this.radioButtonNormal.Checked = false;
            this.radioButtonPoisson.Checked = false;

            this.radioButtonMedia.Checked = true;
            this.radioButtonLambda.Checked = false;

            this.panelUniforme.BringToFront();
            this.panelNormal.Enabled = false;
            this.panelExponencial.Enabled = false;
            this.panelPoisson.Enabled = false;

            this.buttonChi2.Enabled = false;
        }

        private void RadioButtonUniformeAB_CheckedChanged(object sender, EventArgs e)
        {
            this.panelUniforme.BringToFront();
            this.panelUniforme.Enabled = true;
            this.panelNormal.Enabled = false;
            this.panelExponencial.Enabled = false;
            this.panelPoisson.Enabled = false;

            this.buttonChi2.Enabled = false;
        }

        private void RadioButtonExponencial_CheckedChanged(object sender, EventArgs e)
        {
            this.panelExponencial.BringToFront();
            this.panelExponencial.Enabled = true;
            this.panelUniforme.Enabled = false;
            this.panelNormal.Enabled = false;
            this.panelPoisson.Enabled = false;

            this.buttonChi2.Enabled = false;
        }

        private void RadioButtonNormal_CheckedChanged(object sender, EventArgs e)
        {
            this.panelNormal.BringToFront();
            this.panelNormal.Enabled = true;
            this.panelUniforme.Enabled = false;
            this.panelExponencial.Enabled = false;
            this.panelPoisson.Enabled = false;

            this.buttonChi2.Enabled = false;
        }

        private void RadioButtonPoisson_CheckedChanged(object sender, EventArgs e)
        {
            this.panelPoisson.BringToFront();
            this.panelPoisson.Enabled = true;
            this.panelUniforme.Enabled = false;
            this.panelNormal.Enabled = false;
            this.panelExponencial.Enabled = false;

            this.buttonChi2.Enabled = false;
        }

        private void ButtonChi2_Click(object sender, EventArgs e)
        {
            FrmAnalisisChiCuadrado form = new FrmAnalisisChiCuadrado(listaChi);
            form.ShowDialog();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    dataGridView1.ColumnCount = 1;
        //    GeneradorAleatorio.SetearGeneradorLineal();
        //    List<double> listilla = new List<double>();
        //    for (int i = 0; i < 20; i++)
        //    {
        //        listilla.Add(GeneradorDistribuciones.ExponencialNegativaMedia(52));
        //        dataGridView1.Rows.Add(listilla[i]);
        //    }
        //}
    }
}

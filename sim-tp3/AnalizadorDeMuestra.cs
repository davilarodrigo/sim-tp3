using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sim_tp3
{
    public class AnalizadorDeMuestra
    {
        public enum TiposDistribucion { ExponencialNegativa, Uniforme, Normal, Poisson};
        
        List<double> muestra;
        List<double> limitesInferioresDeIntervalos;
        List<double> limitesSuperioresDeIntervalos;

        List<double> frecuenciasEsperadas;
        List<int>    frecuenciasObservadas;

        public List<double> ObtenerMuestra { get => muestra; }
        public List<double> ObtenerLimitesInferioresDeIntervalos { get => limitesInferioresDeIntervalos; }
        public List<double> ObtenerLimitesSuperioresDeIntervalos { get => limitesSuperioresDeIntervalos; }
        public List<double> ObtenerFrecuenciasEsperadas { get => frecuenciasEsperadas; }
        public List<int>    ObtenerFrecuenciasObservadas { get => frecuenciasObservadas; }
                
        private int tamañoMuestra; //tamaño de la muestra
        private int cantidadDeIntervalos; //cantidad de intervalos
        private double media;
        private double varianza;

        public AnalizadorDeMuestra(List<double> muestra, int cantidadDeIntervalos, TiposDistribucion tipoDeDistribucion,double varianza, double media)
        {
            this.varianza = varianza;
            this.media = media;
            this.muestra = muestra;
            this.cantidadDeIntervalos = cantidadDeIntervalos;
            this.tamañoMuestra = muestra.Count;

            AnalizarDistribucionDeFrecuencia();
            CalcularFrecuenciasEsperadas(tipoDeDistribucion);
        }

        public double ObtenerChiCuadrado()
        {
            int frecuenciaEsperada = 5;//esto despues hay q arreglarlo

            double sumatoria = 0;

            for (int i = 0; i < cantidadDeIntervalos; i++)
            {
                sumatoria += (Math.Pow(frecuenciasObservadas[i] - (double)frecuenciaEsperada, 2));
            }
            sumatoria /= (double)frecuenciaEsperada;

            return Math.Truncate(sumatoria* 100000)/100000;
        }

        private double CalcularProbabilidadEsperadaExpoNegativa(double limSup, double limInf)
        {
            double lambda = (double)1 / media;

            double acumuladaInf = 1 - Math.Pow(Math.E, ((-lambda) * limInf));
            double acumuladaSup = 1 - Math.Pow(Math.E, ((-lambda) * limSup));

            return acumuladaSup - acumuladaInf;

        }

        void CalcularFrecuenciasEsperadas(TiposDistribucion tipoDeDistribucion)
        {
            frecuenciasEsperadas = new List<double>();
            

            switch (tipoDeDistribucion)
            {
                case TiposDistribucion.ExponencialNegativa:
                    for (int i = 0; i < this.cantidadDeIntervalos; i++)
                    {

                        double probEsperada = CalcularProbabilidadEsperadaExpoNegativa(limitesSuperioresDeIntervalos[i],limitesInferioresDeIntervalos[i]);

                        this.frecuenciasEsperadas.Add(probEsperada*tamañoMuestra);
                                               
                    }



                    //[ F(x2) - F(x1) ] * tamaño muestra


                    break;

                case TiposDistribucion.Uniforme:

                    int frecuenciaEsperada = tamañoMuestra / cantidadDeIntervalos;

                    for (int i = 0; i < cantidadDeIntervalos; i++)
                    {
                        frecuenciasEsperadas.Add(frecuenciaEsperada);
                    }

                    break;

                case TiposDistribucion.Normal:
                    break;
                case TiposDistribucion.Poisson:
                    break;
                default:
                    break;
            }
                       

        }

        void DefinirLimitesDeLosIntervalos(int cantidadDeIntervalos)
        {
            //se obtienen los limites superior e inferior de la muestra en si
            double limiteInferior = muestra.Min();
            double limiteSuperior = muestra.Max();

            double extensionDeLaMuestra = limiteSuperior - limiteInferior;
            double tamañoIntervalo = extensionDeLaMuestra / cantidadDeIntervalos;            

            for (int i = 0; i < cantidadDeIntervalos; i++)
            {
                limitesInferioresDeIntervalos.Add(limiteInferior + tamañoIntervalo * i);
                limitesSuperioresDeIntervalos.Add(limiteInferior + tamañoIntervalo * (i+1));
            }
        }

        void AnalizarDistribucionDeFrecuencia()
        {        
            frecuenciasObservadas = new List<int>();
            limitesSuperioresDeIntervalos = new List<double>();
            limitesInferioresDeIntervalos = new List<double>();
                
            DefinirLimitesDeLosIntervalos(cantidadDeIntervalos);

            for (int i = 0; i < cantidadDeIntervalos; i++)
            {//este for se puede hacer en un solo reglon?¿¿
                frecuenciasObservadas.Add(0);
            }
                        
            for (int i = 0; i < tamañoMuestra; i++)
            {
                for (int j = 0; j < cantidadDeIntervalos; j++)
                {
                    if (muestra[i] <= limitesSuperioresDeIntervalos[j])
                    {
                        frecuenciasObservadas[j]++;
                        break;
                    }
                }
            }
        }

        public List<double> obtenerEstadisticoPrueba()
        {
            int frecuenciaEsperada = 5; //hay q cambviarlo

            List<double> estadisticosPrueba = new List<double>();
            double sumatoria = 0;

            for (int i = 0; i < cantidadDeIntervalos; i++)
            {
                sumatoria = (Math.Pow(frecuenciasObservadas[i] - (double)frecuenciaEsperada, 2));
                sumatoria /= (double)frecuenciaEsperada;
                estadisticosPrueba.Add(Math.Truncate(sumatoria * 100000) / 100000);
            }

            return estadisticosPrueba;
        }


    }
}

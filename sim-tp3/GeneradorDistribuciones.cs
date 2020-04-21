using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim_tp3
{
    static class GeneradorDistribuciones
    {
        public static int UniformeAB(int a, int b)
        {
            double uniformeAB = a + ((b - a) * GeneradorAleatorio.ObtenerSiguienteAleatorio());
            return Convert.ToInt32(uniformeAB);
        }

        //public static double ExponencialNegativaMedia(double media)
        //{
        //    double exponencial = (-media * (Math.Log(1 - GeneradorAleatorio.ObtenerSiguienteAleatorio())));
        //    return (Math.Truncate(exponencial * 10000)) / 10000;
        //}

        public static double ExponencialNegativa(double lambda)
        {
            double exponencial = (-(1/lambda) * (Math.Log(1 - GeneradorAleatorio.ObtenerSiguienteAleatorio())));
            return (Math.Truncate(exponencial * 10000)) / 10000;
        }

        public static List<double> NormalBoxMuller(int media, double desviacion)
        {
            List<double> lista = new List<double>();
            double n1, n2;
            double random1 = GeneradorAleatorio.ObtenerSiguienteAleatorio();
            double random2 = GeneradorAleatorio.ObtenerSiguienteAleatorio();

            n1 = Math.Sqrt(-2 * Math.Log(random1)) * Math.Cos(2 * Math.PI * random2) * desviacion + media;
            n2 = Math.Sqrt(-2 * Math.Log(random1)) * Math.Sin(2 * Math.PI * random2) * desviacion + media;

            lista.Add(Math.Truncate(n1 * 10000) / 10000);
            lista.Add(Math.Truncate(n2 * 10000) / 10000);
            return lista;
        }

        public static int Poisson(int media)
        {
            double p = GeneradorAleatorio.ObtenerSiguienteAleatorio();
            int x = 0;
            double a = Math.Exp(-media);

            while (p >= a)
            {
                p *= GeneradorAleatorio.ObtenerSiguienteAleatorio(); ;
                x += 1;
            }
            return x;
        }

    }
}

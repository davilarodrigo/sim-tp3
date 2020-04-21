using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim_tp3
{
    static class GeneradorAleatorio
    {
        private static int raiz, c, a, m;
        private static bool esModoMultiplicativo;
        public static bool estaSeteado = false;

        public static void SetearGeneradorLineal()
        {
            List<int> numerosRaiz = new List<int>() { 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 29, 31, 33, 35, 37 };
            List<int> numerosC = new List<int>() { 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73 };
            List<int> numerosG = new List<int>() { 17, 18, 19, 20, 21, 22, 23, 24 };
            List<int> numerosK = new List<int>() { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };

            int valorRaiz, valorC, valorG, valorK;

            Random random = new Random();
            int index = random.Next(1, numerosRaiz.Count);
            valorRaiz = numerosRaiz[index - 1];

            index = random.Next(1, numerosC.Count);
            valorC = numerosC[index - 1];

            index = random.Next(1, numerosG.Count);
            valorG = numerosG[index - 1];

            index = random.Next(1, numerosK.Count);
            valorK = numerosK[index - 1];

            RecibirValoresLineal(valorRaiz, valorC, valorK, valorG);
        }

        public static void RecibirValoresLineal(int raizRecibida, int cRecibido, int k, int g)
        {
            esModoMultiplicativo = false;
            raiz = raizRecibida;
            c = cRecibido;
            a = 1 + (4 * k);

            m = 1;
            for (int i = 0; i < g; i++)
            {
                m *= 2;
            }

            // Ponemos la flag en true para indicar que esta seteado
            estaSeteado = true;
        }
            
        public static int ObtenerSiguienteRaiz()
        {
            if (!estaSeteado)
            {
                SetearGeneradorLineal();
            }
            
            int x = raiz;

            if (esModoMultiplicativo)
            {
                x = ((a) * x) % (m);
            }
            else
            {
                x = ((a) * x + c) % (m);
            }

            raiz = x;
            return x;
        }

        public static double ObtenerSiguienteAleatorio()
        {
            if (!estaSeteado)
            {
                SetearGeneradorLineal();
            }

            int siguienteRaiz = ObtenerSiguienteRaiz();
            double valorTruncado = (Math.Truncate(Convert.ToDouble(siguienteRaiz) / (m - 1) * 10000)) / 10000;
            return valorTruncado;
        }

    }
    
}

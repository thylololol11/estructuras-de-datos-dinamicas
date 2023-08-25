using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    public class ExamenEstructuraDatos
    {
        public static void ImprimirElementosLista(List<string> lista, int indice)
        {
            if (indice == lista.Count)
            {
                return;
            }
            Console.WriteLine(lista[indice]);
            ImprimirElementosLista(lista, ++indice);
        }
        public static void ImprimirElementosLista(List<int> lista, int indice)
        {
            if (indice == lista.Count)
            {
                return;
            }
            Console.WriteLine(lista[indice]);
            ImprimirElementosLista(lista, ++indice);
        }
        private static List<int> _RecorrerMatriz(int[][] matriz, List<int> solucion, int fila, int columna)
        {
            if (columna == matriz[fila].Length)
            {
                columna = 0;
                fila++;
            }

            if (fila == matriz.Length)
            {
                return solucion;
            }
            int numero = matriz[fila][columna];
            solucion.Add(numero);
            return _RecorrerMatriz(matriz, solucion, fila, ++columna);
        }
        public static void RecorrerMatriz(int[][] matriz)
        {
            List<int> ret = new();
            _RecorrerMatriz(matriz, ret, 0, 0);
            ImprimirElementosLista(ret, 0);
        }

        public static void GenerarCombinacionBinarios(int n)
        {
            List<string> combinaciones = new();
            GenerarCombinaciones(new int[n], combinaciones, 0);
            ImprimirElementosLista(combinaciones, 0);
        }

        static void GenerarCombinaciones(int[] CombinacionBinario, List<string> combinaciones, int index)
        {
            if (index == CombinacionBinario.Length)
            {
                IngresarBinarioBalanceado(CombinacionBinario, 0, "", 0, combinaciones);
                return;
            }

            CombinacionBinario[index] = 0;
            GenerarCombinaciones(CombinacionBinario, combinaciones, index + 1);

            CombinacionBinario[index] = 1;
            GenerarCombinaciones(CombinacionBinario, combinaciones, index + 1);
        }

        static void IngresarBinarioBalanceado(int[] combinacion, int posicion, string binario, int contador, List<string> combinaciones)
        {

            if (posicion == combinacion.Length)
            {
                if (contador == 0)
                {
                    combinaciones.Add(binario);

                }
                return;
            }

            binario += combinacion[posicion];

            if (combinacion.Length % 2 == 0)
            {
                if (posicion + 1 <= combinacion.Length / 2) contador += combinacion[posicion];
                else contador -= combinacion[posicion];
            }
            else
            {
                if (posicion + 1 < combinacion.Length / 2 + 1) contador += combinacion[posicion];
                else if (posicion + 1 > combinacion.Length / 2 + 1) contador -= combinacion[posicion];
            }
            IngresarBinarioBalanceado(combinacion, ++posicion, binario, contador, combinaciones);
        }

    }
}

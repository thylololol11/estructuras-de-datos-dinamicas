using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalleresEstructurasDatos
{
    public class FuncionesTaller
    {
        public static int DigitosMultiplos2y4(int numero)
        {
            if (numero < 10)
            {
                if (numero % 2 == 0 && numero % 4 == 0 && numero != 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            int digito = numero % 10;
            if (digito % 2 == 0 && digito % 4 == 0 && digito != 0)
            {
                return 1 + DigitosMultiplos2y4(numero / 10);
            }
            return 0 + DigitosMultiplos2y4(numero / 10);
        }
        public static string MitadStringInvertido(string texto)
        {
            int longitud = texto.Length;
            string mitadInferior = texto.Substring(0, longitud / 2);
            string mitadSuperior = texto.Substring(longitud / 2);
            string mitadInvertida = "";
            for (int i = mitadSuperior.Length - 1; i >= 0; i--)
            {
                mitadInvertida += mitadSuperior.ElementAt(i);
            }
            return mitadInferior + mitadInvertida;
        }


        public static int SumaImparesMatriz(int[][] matriz, int fila = 0, int columna = 0)
        {

            if (columna == matriz.Length)
            {
                columna = 0;
                fila++;
            }
            if (fila == matriz.Length)
            {
                return 0;
            }
            int numero = matriz[fila][columna];
            if (numero % 2 != 0)
            {
                return numero + SumaImparesMatriz(matriz, fila, ++columna);
            }
            return 0 + SumaImparesMatriz(matriz, fila, ++columna);

        }

        private static string _NumerosDeString(string str)
        {
            if (str.Length == 0) return "";
            char caracter = str.ElementAt(0);
            if (Char.IsNumber(caracter))
            {
                return caracter.ToString() + _NumerosDeString(str.Substring(1));
            }
            return _NumerosDeString(str.Substring(1));
        }
        public static int NumerosDeString(string str)
        {
            return Int32.Parse(_NumerosDeString(str));
        }

    }
}
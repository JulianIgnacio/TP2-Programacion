using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main()
        {
            int[,] matriz1 = new int[3, 3];
            int[,] matriz2 = new int[3, 3];
            int[,] matrizResultado = new int[3, 3];
            matriz1[0, 0] = 1;
            matriz1[0, 1] = 4;
            matriz1[0, 2] = 7;
            matriz1[1, 0] = 2;
            matriz1[1, 1] = 5;
            matriz1[1, 2] = 8;
            matriz1[2, 0] = 3;
            matriz1[2, 1] = 6;
            matriz1[2, 2] = 9;
            matriz2[0, 0] = 3;
            matriz2[0, 1] = 6;
            matriz2[0, 2] = 9;
            matriz2[1, 0] = 1;
            matriz2[1, 1] = 4;
            matriz2[1, 2] = 7;
            matriz2[2, 0] = 2;
            matriz2[2, 1] = 5;
            matriz2[2, 2] = 8;
            Calcular(matriz1, matriz2, matrizResultado);
            Mostrar(matrizResultado);
            Console.ReadKey();
        }
        static void Mostrar(int[,] matriz)
        {
            Console.Write("\n");
            Console.WriteLine("La matriz resultante del producto es:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("\t" + matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Calcular(int[,] producto1, int[,] producto2, int[,] resultado)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultado[i, j] = producto1[i, j] * producto2[i, j];
                }
            }
        }
    }
}

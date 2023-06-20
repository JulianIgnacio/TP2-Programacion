using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main()
        {
            int[,] matriz1 = new int[3, 3];
            int[,] matriz2 = new int[3, 3];
            int[,] matrizResultado = new int[3, 3];
            matriz1[0, 0] = 14;
            matriz1[0, 1] = 42;
            matriz1[0, 2] = 32;
            matriz1[1, 0] = 22;
            matriz1[1, 1] = 35;
            matriz1[1, 2] = 48;
            matriz1[2, 0] = 39;
            matriz1[2, 1] = 60;
            matriz1[2, 2] = 97;
            matriz2[0, 0] = 32;
            matriz2[0, 1] = 65;
            matriz2[0, 2] = 19;
            matriz2[1, 0] = 12;
            matriz2[1, 1] = 48;
            matriz2[1, 2] = 72;
            matriz2[2, 0] = 23;
            matriz2[2, 1] = 56;
            matriz2[2, 2] = 80;
            Calcular(matriz1, matriz2, matrizResultado);
            Mostrar(matrizResultado);
            Console.ReadKey();
        }
        static void Mostrar(int[,] matriz)
        {
            Console.Write("\n");
            Console.WriteLine("Los datos cargados en la matriz son:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("\t" + matriz[i,j]+ "\t");
                }
                Console.WriteLine();
            }
        }
        static void Calcular(int[,] suma1, int[,] suma2, int[,] resultado)
        {
            for (int i = 0;i < 3; i++)
            {
                for(int j=0; j < 3; j++)
                {
                    resultado[i, j] = suma1[i,j] + suma2[i,j];
                }
            }
        }
    }
}

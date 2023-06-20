using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main()
        {
            int[] notas = new int[6];
            notas[0] = 10;
            notas[1] = 6;
            notas[2] = 8;
            notas[3] = 9;
            notas[4] = 7;
            notas[5] = 10;
            Calcular(notas);
            Console.WriteLine("el promedio es:{0}",Calcular(notas));
            Console.ReadKey();
        }
        static int Calcular(int[] calculoNota)
        {
            int resultado = 0;
            for (int i = 0; i < calculoNota.Length; i++)
            {
                resultado+= calculoNota[i];
            }
            resultado /= 6;
            return resultado;
        }
    }
}

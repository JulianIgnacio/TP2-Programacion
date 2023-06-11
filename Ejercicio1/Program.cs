using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1TP2
{
    internal class Program
    {
        static void Main()
        {
            int[] semana1 = new int[7];
            int[] semana2 = new int[7];
            int[] semana3 = new int[7];
            int[] semana4 = new int[7];
            int[] suma = new int[7];
            int sumatotal = 0;
            Console.WriteLine("Ingrese los valores de la primera semana:");
            Cargar(semana1);
            Console.WriteLine("Los valores de la primera semana son:");
            Mostrar(semana1);
            Console.WriteLine("Ingrese los valores de la segunda semana:");
            Cargar(semana2);
            Console.WriteLine("Los valores de la segunda semana son:");
            Mostrar(semana2);
            Console.WriteLine("Ingrese los valores de la tercera semana:");
            Cargar(semana3);
            Console.WriteLine("Los valores de la tercera semana son:");
            Mostrar(semana3);
            Console.WriteLine("Ingrese los valores de la cuarta semana:");
            Cargar(semana4);
            Console.WriteLine("Los valores de la cuarta semana son:");
            Mostrar(semana4);
            SumaSemanal(suma, semana1);
            SumaSemanal(suma, semana2);
            SumaSemanal(suma, semana3);
            SumaSemanal(suma, semana4);
            Console.WriteLine("los valores de la suma de toda la semana son:");
            Mostrar(suma);
            Array.Sort(suma);
            Console.WriteLine("Los valores ordenados de menor a mayor son:");
            Mostrar(suma);
            Console.WriteLine("El valor menor es:{0}", suma[0]);
            Console.WriteLine("El valor mayor es:{0}", suma[6]);
            double promedio = suma.Average();
            Console.WriteLine("su promedio es:{0}", promedio);
            SumaFinal(suma, sumatotal);
            Console.ReadKey();
        }
        static void Cargar(int[] vector)
        {

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Mostrar(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
        }
        static void SumaSemanal(int[] sumatoriaSemanal, int[] vectorAsumar)
        {
            for (int i = 0; i < 7; i++)
            {
                sumatoriaSemanal[i] += vectorAsumar[i];
            }
        }
        static void SumaFinal(int[] sumaMensual, int acumulador)
        {
            for (int i = 0; i < sumaMensual.Length; i++)
            {
                acumulador += sumaMensual[i];
            }
            Console.WriteLine("La suma de todos sus elementos es:{0}", acumulador);
        }
    }
}

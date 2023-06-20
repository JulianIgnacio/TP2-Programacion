using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main()
        {
            int[] Notas = new int[6];
            Cargar(Notas);
            Calcular(Notas);
            Console.ReadKey();
        }
        static void Cargar(int[] cargarnotas)
        {
            Console.WriteLine("Ingrese las notas de el alumno");
            for (int i = 0;i<cargarnotas.Length;i++)
            {
                cargarnotas[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Calcular(int[] calculoNota)
        {
            int resultado = 0;

            for (int i = 0; i < calculoNota.Length; i++)
            {
                resultado += calculoNota[i];
            }
            resultado /= 6;
            Console.WriteLine("El promedio es:{0}", resultado);
            if (resultado>=7)
            {
                Console.WriteLine("El alumno promociono");
            }else if(resultado == 6)
            {
                Console.WriteLine("El alumno esta regular");
            }
            else
            {
                Console.WriteLine("El alumno desaprobo");
            }
        }
    }
}

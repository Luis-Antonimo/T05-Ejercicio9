using System;

namespace T05Ejercicio9
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[5];
            for (int i=0; i<array.Length; i++)
            {
                Console.WriteLine("Escriba el valor del array con posición " + i);
                int valor = Convert.ToInt32(Console.ReadLine());
                array[i] = valor;
            }
            Console.WriteLine("\nMostrando contenido del array: ");
            foreach (int x in array)
            {
                Console.WriteLine(x);
            }

        }
    }
}
using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, promedio = 0, suma = 0;
            int[] numeros = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("dame un numero");
                n = int.Parse(Console.ReadLine());
                numeros[i] = n;
            }
            for (int i = 0; i < 8; i++)
            {
                suma+=numeros[i];
            }
            promedio = suma/8;
            Console.WriteLine("El promedio es: " + promedio);
            for (int i = 0; i < 8; i++)
            {
                if (numeros[i] > promedio)
                    Console.WriteLine(numeros[i] + " es mayor al promedio");
            }
        }
    }
}

// Hacer un programa que solicite 100 números enteros y los guarde en un
// vector. Luego recorrer ese vector para calcular el promedio. Mostrar por
// pantalla los valores del vector que son mayores al promedio calculado.
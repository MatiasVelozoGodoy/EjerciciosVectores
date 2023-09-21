using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, max, posicion = 1;
            int[] numeros = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("dame un numero");
                n = int.Parse(Console.ReadLine());
                numeros[i] = n;
            }
            max = numeros[0];
            for (int i = 0; i < 5; i++)
            {
                if(numeros[i] > max){
                    max = numeros[i];
                    posicion = i+1;
                }
            }
            Console.WriteLine("El numero mas grande del vector es: " + max + " y esta en la posicion: " + posicion);
        }
    }
}

// Hacer un programa que solicite 50 números enteros y los guarde en un vector.
// Luego recorrer todos los elementos del vector y determinar cuál es el valor
// máximo y su posición dentro del vector.
using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, suma=0;
            int[] numeros = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Dame un numero");
                n = int.Parse(Console.ReadLine());
                numeros[i] = n;
                
            }
            for (int x = 0; x < 5; x++)
            {
                suma += numeros[x];
            }
            Console.WriteLine("La suma total de todos los numeros del vector es de: " + suma);
        }
    }
}

// Hacer un programa que solicite 50 números enteros y los guarde en un vector.
// Luego recorrer el vector y determinar e informar cuál es la suma de los valores
// del mismo.
// Nota: usar dos ciclos: uno para guardar los números en el vector y otro para
// recorrerlo y leerlo.
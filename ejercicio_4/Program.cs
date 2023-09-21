using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, bandera;
            int[] numeros = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("dame un numero");
                n = int.Parse(Console.ReadLine());
                numeros[i] = n;
            }
            bandera = 0;
            for (int i = 0; i < 7; i++)
            {
                if(numeros[i] < numeros[i+1])
                    bandera++;
            }
            
            if(bandera == 7)
                Console.WriteLine("El vector esta ordenado");
            else
                Console.WriteLine("El vector no esta ordenado");
        }
    }
}

// Dada una lista de 10 números enteros, cargarlos en un vector. Luego,
// determinar e informar si el vector está ordenado en forma creciente. Por
// ejemplo el vector con los valores 1, 3, 5, 7 y 9 está ordenado; el vector 1, 5, 3, 7
// y 9 no lo está.
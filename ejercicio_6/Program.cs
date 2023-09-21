using System;

namespace ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, bandera = 0, repetido = 0;
            bool rep = false;
            int[] numeros = new int[8];
            
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("dame un numero");
                n = int.Parse(Console.ReadLine());
                numeros[i] = n;
            }
            
            for (int x = 0; x < 8; x++)
            {   
                bandera = 0;
                repetido = numeros[x];
                for (int y = 0; y < 8; y++)
                {
                    if(numeros[x] == numeros[y])
                        bandera++;
                }
                if(bandera >= 2)
                    rep = true;
            }
            if(rep)
                Console.WriteLine("Hay repetidos");
            else
                Console.WriteLine("No hay repetidos");
        }
    }
}

// Dada una lista de 10 números, cargarlos en un vector. Luego detectar si en el
// vector hay algún elemento repetido. De haberlo, indicarlo con un cartel
// aclaratorio “Hay repetidos”, de lo contrario indicar “No hay repetidos”.
// Pista: usar ciclos combinados.
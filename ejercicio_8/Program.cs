using System;

namespace ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,  aux = 0;
            int[] numeros = new int[6]; 
            int[] numeroAux = new int[6]; 

            for (int i = 0; i < 6; i++)
            {
                numeroAux[i] = i+1;
                Console.WriteLine("dame un numero");
                n = int.Parse(Console.ReadLine());
                numeros[i] = n;
            }
            for (int x = 0; x < 6; x++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if(numeros[i] < numeros[i+1]){
                        aux = numeros[i+1];
                        numeros[i+1] = numeros[i];
                        numeros[i] = aux;
                        aux = numeroAux[i+1];
                        numeroAux[i+1] = numeroAux[i];
                        numeroAux[i] = aux;
                    }
                }
            }
            for (int x = 0; x < 6; x++)
            {
                
            Console.WriteLine("el numero es: " + numeros[x] + " y esta en la posicion " + numeroAux[x]);
            }
        }
    }
}

// Se ingresa una lista de 20 números en un vector. Se pide ordenar dichos
// números en forma decreciente (de mayor a menor). Mostrar el listado
// ordenado informando también la posición original de cada número en el
// vector.
// Pista: usar ciclos combinados.
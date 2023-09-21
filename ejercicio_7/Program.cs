using System;

namespace ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nArticulo, cantidadVendida, maxVendido, conMax=1;
            int[] numero = new int[6];
            for (int i = 0; i < 6; i++)
            {
                numero[i] = 0;
            }

            Console.WriteLine("Dame el numero del articulo");
            nArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime la cantidad vendida");
            cantidadVendida = int.Parse(Console.ReadLine());
            Console.WriteLine("Vendido");
            while (nArticulo != 0)
            {
                numero[nArticulo-1]+= cantidadVendida;
                Console.WriteLine("Dame el numero del articulo");
                nArticulo = int.Parse(Console.ReadLine());
                if (nArticulo == 0)
                    break;
                Console.WriteLine("Dime la cantidad vendida");
                cantidadVendida = int.Parse(Console.ReadLine());
                Console.WriteLine("Vendido");
            }
            Console.WriteLine("El articulo numero 6 vendio: " + numero[5]);
            maxVendido = numero[0];
            for (int i = 0; i < 6; i++)
            {
                if(numero[i] > maxVendido){
                    maxVendido = numero[i];
                    conMax = i+1;
                }
            }
            
            Console.WriteLine("El articulo mas vendido es el: " + conMax + " con " +  maxVendido);
            for (int x = 0; x < 6; x++)
            {
            if(numero[x] == 0)
                Console.WriteLine("El articulo que no presento ventas es el:" + (x+1));
                
            }
        }
    }
}

// Una empresa comercializa 15 tipos de artículos y por cada venta realizada
// genera un registro con los siguientes datos:
// • Número de artículo (1 a 15).
// • Cantidad vendida.
// Puede haber varios registros para el mismo artículo y el último se indica
// número de artículo igual a cero.
// Se pide determinar e informar:
// a. El número de artículo que más se vendió en total.
// b. Los números de artículos que no registraron ventas.
// c. La cantidad de unidades vendidas para el artículo número 10.
// Nota: tener en cuenta el concepto de “registro” y el planteo de estructura
// principal separado de consignas (ver videos de ciclos combinados y ejercicios
// resueltos de ciclos combinados).
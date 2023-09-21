using System;

namespace ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            char a = 'a', b = 'o';
            // int i = 0;
            Console.WriteLine("dame una letra");
            frase = Console.ReadLine();
            frase = frase.Replace(a,b);
            Console.WriteLine(frase);
            // letra = char.Parse(Console.ReadLine());
            
            // while (letra != '.')
            // {
            //     letras[i] = letra;
            //     Console.WriteLine("dame una letra");
            //     letra = char.Parse(Console.ReadLine());
            //     i++;
            // }
            // for (int x = 0; x < 15; x++)
            // {
            //     if(letras[x] == a)
            //         letras[x] = b;
            // }
            // i = 0;
            // while (letras[i] != '\0')
            // {
            //     Console.Write(letras[i]);
            //     i++;                
            // }
        }
    }
}

// Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
// El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. 
// Mostrar el resultado en pantalla. Ejemplo:
// CADENA FUENTE: “La mar estaba serena"
// CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
// CADENA RESULTADO: “Li mir estibi sereni"
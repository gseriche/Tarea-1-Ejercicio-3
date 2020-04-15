using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tarea 1 - Ejercicio 3
// Diseñar un algoritmo y construir un programa que lea dos números
// y nos diga cual de ellos es mayor o bien si son iguales (recuerda usar la estructura condicional SI).

// Algoritmo
// 1 - Crear variable para almacenar primer numero que se solicitara al usuario
// 2 - Solicitar al usuario ingreso del primer numero
// 3 - Almacenar el primer numero en la primera variable
// 4 al 6 - Repetir paso 1 al 3 para el segundo numero
// 7 - Verificar si el primer numero es mayor al segundo, si es mayor, imprimir el resultado
// 8 - Verificar si el primer numero es menor al segundo, si es menor, imprimir el resultado
// 9 - Si el primer numero no es mayor ni menor que el segundo, imprimir que son iguales

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Solicita al usuario ingresar un primer numero
            string advertencia = "";

            float numero1;
            do
            {
                Console.WriteLine(advertencia);
                Console.WriteLine("Ingresa el primer numero");
                advertencia = "Por favor intenta denuevo, esta vez ingresando un numero";
            } while (!float.TryParse(Console.ReadLine(), out numero1));

            // Solicita al usuario ingresar un segundo numero
            advertencia = "";

            float numero2;
            do
            {
                Console.WriteLine(advertencia);
                Console.WriteLine("Ingresa el segundo numero");
                advertencia = "Por favor intenta denuevo, esta vez ingresando un numero";
            } while (!float.TryParse(Console.ReadLine(), out numero2));

            // Verifica e imprime cual es la relacion de estos numeros entre si en valor numerico
            if (numero1 > numero2)
            {
                Console.WriteLine("El primer numero es mayor que el segundo numero");
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine("El primer numero es menor que el segundo numero");
            }
            else
            {
                Console.WriteLine("El primer numero y el segundo numero son iguales");
            }
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para salir del programa");
            Console.ReadLine();

        }
    }
}

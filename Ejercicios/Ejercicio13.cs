
using System.ComponentModel;

public class Ejercicio13
{
    public static void Run()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- MENÚ DE EJERCICIOS ---");
            Console.WriteLine("1. Calcula factorial (bucle)");
            Console.WriteLine("2. Calcula factorial (recursivo)");
            Console.WriteLine("3. Comprobar palíndromo");
            Console.WriteLine("4. Invertir texto");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Elige una opción");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Introduce un número:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Factorial (bucle): " + Ejercicio11.Factorial(num1)); );
                    break;

                case 2:
                    Console.Write("Introduce un número:");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Factorial (recursivo): " + Ejercicio12.Factorial(num2));
                    break;

                case 3:
                    Console.Write("Introduce una frase: ");
                    string frase = Console.ReadLine();
                    string limpio = frase.ToLower().Replace(" ", "");
                    char[] chars = limpio.ToCharArray();
                    Array.Reverse(chars);
                    string invertido = new string(chars);
                    Console.WriteLine(limpio == invertido ? "Es palíndromo" : "No es palídromo");
                    break;

                case 4:
                    Console.Write("Introduce un texto: ");
                    string texto = Console.ReadLine();
                    char[] arr = texto.ToCharArray();
                    Array.Reverse(arr);
                    Console.WriteLine("Texto invertido: " + new string(arr));
                    break;

                case 0:
                    Console.WriteLine("!Hasta luego¡");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;

            }

        } while (opcion != 0);
    }
}

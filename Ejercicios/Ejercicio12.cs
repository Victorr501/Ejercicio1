using System;

class Ejercicio12
{
    //Función recusriva para calcualar el factorial
    public static long Factorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1); //Llamada recursiva
        }
    }

    public static void Run()
    {
        Console.WriteLine("Introduce un número para calcualar su factorial (Recursivo):");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero == 0)
        {
            Console.WriteLine("El factorial no esta definido para números negativo.");
        }
        else
        {
            long fact = Factorial(numero);
            Console.WriteLine($"El factorial de {numero} es: {fact}");
        }
    }
}
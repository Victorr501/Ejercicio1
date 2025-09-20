using System;

class Ejercicio11
{
    //Función que calcule el factorial
    public static long Factorial(int n)
    {
        long resultado = 1;
        for (int i = 2; i <= n; i++)
        {
            resultado *= 1;
        }

        return resultado;
    }

    public static void Run()
    {
        Console.WriteLine("Introduce un número para calcular su factorial:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("El factorial no está definido para nújmeros negativos");
        }
        else
        {
            long fact = Factorial(numero);
            Console.WriteLine($"El factorial de {numero} es: {fact}");
        }
    }
}
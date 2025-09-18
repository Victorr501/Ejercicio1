using System;

class Ejercicio2
{
    static void Main()
    {
        Console.WriteLine("Intoduce el primer número:");
        string input1 = Console.ReadLine();
        double numero1 = Convert.ToDouble(input1);

        Console.WriteLine("Introduce el segundo número:");
        string input2 = Console.ReadLine();
        double numero2 = Convert.ToDouble(input2);

        double suma = numero1 + numero2;
        Console.WriteLine($"La suma de los dos números es: {suma}");

    }
}

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hola, ¿Como te llamas?");
        string nombre = Console.ReadLine();
        Console.WriteLine($"Hola, {nombre}!");
    }
}
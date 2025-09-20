using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ejercicio01
{
    public static void Run()
    {
        Console.WriteLine("Hola, ¿Como te llamas?");
        string nombre = Console.ReadLine();
        Console.WriteLine($"Hola, {nombre}!");
    }
}

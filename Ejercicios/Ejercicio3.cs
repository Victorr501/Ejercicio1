using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Ejercicio3
{

    public static void Run()
    {
        Console.WriteLine("Introduce un número:");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero % 2 == 0)
        {
            Console.WriteLine($"El número {numero} es PAR");
        } else
        {
            Console.WriteLine($"El número {numero} es IMPAR");
        }
    }
}


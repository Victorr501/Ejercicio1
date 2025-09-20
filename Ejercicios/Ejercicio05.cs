class Ejercicio05
{
    public static void Run()
    {
        Console.WriteLine("Introduce un número:");
        int limite  = Convert.ToInt32(Console.ReadLine());

        int suma = 0;

        for (int i = 1; i <= limite; i++)
        {
            suma += i;
        }

        Console.WriteLine($"La suma de los número desde 1 hasta {limite} es: {suma}");
    }
}
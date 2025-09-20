
class Ejercicio04
{
    public static void Run()
    {
        Console.WriteLine("Introduce un número:");
        int limite = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Contando desde 1 hasta {limite}:");

        for (int i = 1; i <= limite; i++)
        {
            Console.WriteLine(i);
        }
    }
}

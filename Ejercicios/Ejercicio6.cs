class ejercicio6
{
    //Leer varios números y calcular su prodedio
    public static void Run()
    {
        Console.WriteLine("¿Cuántos números quires introducir?");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        int[] numeros = new int[cantidad];
        int suma = 0;

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"Introduce el número {i + 1}:");

            numeros[i] = Convert.ToInt32(Console.ReadLine());
            suma += numeros[i];

        }

        double promedio = (double)suma / cantidad;

        Console.WriteLine($"El promedio de los  números introducidos es: {promedio}");

    }
}
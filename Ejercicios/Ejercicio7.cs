class Ejercicio7
{
    public static  void Run()
    {
        Console.WriteLine("¿Cuantos números quieres introducir?");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        int[] numeros = new int[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"Introduce el número {i + 1}:");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        int mayor = numeros[0];
        int menor = numeros[0];

        for (int i = 1; i < cantidad; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
            }

            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }

        Console.WriteLine($"El número mayor es: {mayor}");
        Console.WriteLine($"El número menor es: {menor}");

    }
}

class Ejercicio09
{
    public static void Run()
    {
        Console.WriteLine("Escribe una palabara o frase:");
        string texto = Console.ReadLine();

        char[] caracteres = texto.ToCharArray();
        Array.Reverse(caracteres);

        string invertido = new string(caracteres);

        Console.WriteLine($"El texto invertido es: {invertido}");

    }
}
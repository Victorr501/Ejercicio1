
class Ejercicio8
{
    public static void Run() 
    {
        Console.WriteLine("Escribe una palabra o frase:");
        string texto = Console.ReadLine();

        int contadorVocales = 0;

        foreach (char c in texto.ToLower())
        {
            if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                contadorVocales++;
            }
        }

        Console.WriteLine($"El texto tiene {contadorVocales} vocales.");
    }
}

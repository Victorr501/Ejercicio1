
class Ejercicio10
{
    public static void Run()
    {
        Console.WriteLine("Escribe una palabra o frase:");
        string texto = Console.ReadLine();

        //Convertir todo a minusculas y elimianr espacios
        string textoLimpio = texto.ToLower().Replace(" ", "");

        //Invertir el string
        char[] caracteres = textoLimpio.ToCharArray();
        Array.Reverse(caracteres);
        string invertido = new string(caracteres);

        //Comparar
        if (textoLimpio == invertido)
        {
            Console.WriteLine("Es un palíndromo");
        }
        else
        {
            Console.WriteLine("No es un palíndromo");
        }
    }
}
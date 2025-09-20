
class Ejercicio14
{
    public static void Run()
    {
        List<string> notas = new List<string>();
        int opcion;

        do
        {
            Console.WriteLine("\n ---GESTOR DE NOTAS ---");
            Console.WriteLine("1. Añadir notas");
            Console.WriteLine("2. Listar notas");
            Console.WriteLine("3. Borrar nota");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Escribe tu nota:");
                    string nuevaNota = Console.ReadLine();
                    notas.Add(nuevaNota);
                    Console.WriteLine("Notas añadida.");
                    break;
                case 2:
                    Console.WriteLine("\n Tu notas:");
                    if (notas.Count == 0)
                    {
                        Console.WriteLine("(No hay notas)");
                    }
                    else
                    {
                        for (int i = 0; i < notas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {notas[i]}");
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("\n Introduce el número de la nota  a borrar: ");
                    for (int i = 0; i < notas.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {notas[i]}");
                    }
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num > 0 && num <= notas.Count)
                    {
                        notas.RemoveAt(num - 1);
                        Console.WriteLine("Nota borrada.");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }

                    break;

                case 0:
                    Console.WriteLine("!Hasta luego¡");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }
}
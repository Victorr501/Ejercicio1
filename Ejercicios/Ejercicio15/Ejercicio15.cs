class Ejercicio15
{
    public static void Run()
    {
        List<Tarea> tareas = new List<Tarea>();
        int opcion;

        do
        {
            Console.WriteLine("\n ---GESTOR DE TAREAS ---");
            Console.WriteLine("1. Añadir tarea");
            Console.WriteLine("2. Listar tareas");
            Console.WriteLine("3. Marcar tarea como completada");
            Console.WriteLine("4. Borrar tarea");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Título de la tarea:");
                    string titulo = Console.ReadLine();

                    Console.Write("Fecha límete (dd/mm/aaaa): ");
                    DateTime fecha = DateTime.Parse(Console.ReadLine());

                    tareas.Add(new Tarea(titulo, fecha));
                    Console.WriteLine("Tarea añadida.");
                    break;

                case 2:
                    Console.WriteLine("\n Lista de tareas:");
                    if (tareas.Count == 0)
                        Console.WriteLine("(No hay tareas)");
                    else
                    {
                        for (int i = 0; i < tareas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tareas[i]}");
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("Número de la tarea a marcar como completada:");
                    int numComp = Convert.ToInt32(Console.ReadLine());
                    if (numComp > 0 && numComp <= tareas.Count)
                    {
                        tareas[numComp - 1].Completada = true;
                        Console.WriteLine("Tarea completada.");
                    }
                    else
                        Console.WriteLine("Número inválido.");
                    break;

                case 4:
                    Console.WriteLine("Número de la tarea a borrar:");
                    int numBorrar = Convert.ToInt32(Console.ReadLine());
                    if (numBorrar > 0 && numBorrar <= tareas.Count)
                    {
                        tareas.RemoveAt(numBorrar - 1);
                        Console.WriteLine("Tarea borrada.");
                    }
                    else
                        Console.WriteLine("Número inválido.");
                    break;

                case 0:
                    Console.WriteLine("¡Hasta luego!");
                    break;

                default:
                    Console.WriteLine("Opción no valida.");
                    break;


            }

        } while (opcion != 0);

    }
}

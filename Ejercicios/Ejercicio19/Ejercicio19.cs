class Ejericio10
{
    public static void Run()
    {
        List<TareaPrioridad> tareas = TareaJSON.CargarTareas();
        int opcion;

        do
        {
            Console.WriteLine("\n ---Gestor de Tareas con buscador (JSON)---");
            Console.WriteLine("1. Añadir tarea");
            Console.WriteLine("2. Listar tareas");
            Console.WriteLine("3. Marcar tarea como completada");
            Console.WriteLine("4. Borrar tarea");
            Console.WriteLine("5. Buscar tareas por palabra clave");
            Console.WriteLine("6. Buscar tareas por rango de fechas");
            Console.WriteLine("0. Salir (guardado)");
            Console.Write("Elige una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Titulo de la tarea:");
                    string titulo = Console.ReadLine();

                    Console.Write("Fecha límite (dd/mm/aaaa): ");
                    DateTime fecha = DateTime.Parse(Console.ReadLine());

                    Console.Write("Prioridad (1 = Alta, 2 = Media, 3 = Baja):");
                    int p = Convert.ToInt32(Console.ReadLine());
                    NivelPrioridad prioridad = (NivelPrioridad)(p - 1);

                    tareas.Add(new TareaPrioridad(titulo, fecha, prioridad));
                    Console.WriteLine("Tarea añadida.");
                    break;

                case 2:
                    Console.WriteLine("\n Lista de tareas:");
                    if (tareas.Count == 0)
                        Console.WriteLine("(No hay tareas)");
                    else
                    {
                        foreach (var tarea in tareas
                            .OrderBy(t => t.Prioridad)
                            .ThenBy(t => t.FechaLimite))
                            Console.WriteLine(tarea);
                    }
                    break;

                case 3:
                    Console.WriteLine("Número de la terea a marcar como completada:");
                    for (int i = 0; i < tareas.Count; i++)
                        Console.WriteLine($"{i + 1}. {tareas[i]}");

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
                    for (int i = 0; i < tareas.Count; i++)
                        Console.WriteLine($"{i + 1}. {tareas[i]}");

                    int numBorrar = Convert.ToInt32(Console.ReadLine());
                    if (numBorrar > 0 && numBorrar <= tareas.Count)
                    {
                        tareas.RemoveAt(numBorrar - 1);
                        Console.WriteLine("Tarea borrada.");

                    }
                    else
                        Console.WriteLine("Numéro inválido.");
                    break;

                case 5:
                    Console.Write("Introduce la palabra clave:");
                    string clave = Console.ReadLine().ToLower();

                    var resultadosClave = tareas
                        .Where(t => t.Titulo.ToLower().Contains(clave))
                        .ToList();

                    Console.WriteLine("\n Resultados de búsqueda:");
                    if (resultadosClave.Count == 0)
                        Console.WriteLine("No se encontraron tares con esa palabra clave.");
                    else
                        resultadosClave.ForEach(t => Console.WriteLine(t));
                    break;

                case 6:
                    Console.WriteLine("Fecha inicio (dd/mm/aaaa):");
                    DateTime inicio = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Fecha fin (dd/mm/aaaa):");
                    DateTime fin = DateTime.Parse(Console.ReadLine());

                    var resultadosFecha = tareas
                        .Where(t => t.FechaLimite >= inicio && t.FechaLimite <= fin)
                        .ToList();

                    Console.WriteLine("\n Resultados de busqueda por fechas:");
                    if (resultadosFecha.Count == 0)
                        Console.WriteLine("No se encontraron tares en ese rango:");
                    else
                        resultadosFecha.ForEach(t => Console.WriteLine(t));
                    break;

                case 0:
                    TareaJSON.GardarTarea(tareas);
                    Console.WriteLine("Tareas guardadas. Hata luego!");
                    break;

                default:
                    Console.WriteLine("Opción invalida");
                    break;


            }
        } while (opcion != 0);
    }
}
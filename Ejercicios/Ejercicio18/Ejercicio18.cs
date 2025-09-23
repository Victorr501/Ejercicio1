class Ejercicio18

{
    public static void Run()
    {
        List<TareaPrioridad> tareas = TareaJSON.CargarTareas();
        int opcion;

        do
        {
            Console.WriteLine("\n ---GESTOR DE TAREAS (JSON)---");
            Console.WriteLine("1. Añadir tarea");
            Console.WriteLine("2. Listar tareas");
            Console.WriteLine("3. Marcar tarea como completada");
            Console.WriteLine("4. Borrar tarea");
            Console.WriteLine("0. Salir (guardado)");
            Console.Write("Elige una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Título de la tarea:");
                    string titulo = Console.ReadLine();

                    Console.Write("Fecha límete (dd/mm/aaaa): ");
                    DateTime fecha = DateTime.Parse(Console.ReadLine());

                    Console.Write("Prioridad (1 = Alta , 2 = Media, 3 = Baja):");
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
                        var ordenadas = tareas
                            .OrderBy(t => t.Prioridad)
                            .ThenBy(t => t.FechaLimite);

                        int i = 1;
                        foreach (var tarea in ordenadas)
                        {
                            Console.WriteLine($"{i}. {tarea}");
                            i++;
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("Número de la tarea a marcar como completada:");
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
                    TareaJSON.GuardarTareas(tareas);
                    Console.WriteLine("¡Hasta luego!");
                    break;

                default:
                    Console.WriteLine("Opción no valida.");
                    break;


            }

        } while (opcion != 0);

    }
}
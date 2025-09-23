using System.Text.Json;


class TareaJSON
{
    static string archivo = "tareas.json";

    public static void GardarTarea(List<TareaPrioridad> tareas)
    {
        string json = JsonSerializer.Serialize(tareas, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(archivo, json);
    }

    public static List<TareaPrioridad> CargarTareas()
    {
        if (File.Exists(archivo))
        {
            string json = File.ReadAllText(archivo);
            return JsonSerializer.Deserialize<List<TareaPrioridad>>(json);
        }

        return new List<TareaPrioridad>();
    }
}
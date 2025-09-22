using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class TareaDAO
{
    static string archivo = "tareas.txt";

    public static void GuardarTareas(List<TareaPrioridad> tareas)
    {
        using (StreamWriter sw = new StreamWriter(archivo))
        {
            foreach (var tarea in tareas)
            {
                sw.WriteLine(tarea.ToFileString());
            }
        }
    }


    public static List<TareaPrioridad> CargarTareas()
    {
        List<TareaPrioridad> lista = new List<TareaPrioridad>();
        if (File.Exists(archivo))
        {
            string[] lineas = File.ReadAllLines(archivo);
            foreach (var linea in lineas)
            {
                lista.Add(TareaPrioridad.FromFileFormat(linea));
            }
        }
        return lista;
    }
}
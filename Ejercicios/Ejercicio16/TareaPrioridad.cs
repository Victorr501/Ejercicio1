enum NivelPrioridad { Alta, Media, Baja }

class TareaPrioridad
{
    public string Titulo { get; set; }
    public DateTime FechaLimite { get; set; }
    public bool Completada { get; set; }
    public NivelPrioridad Prioridad { get; set; }

    public TareaPrioridad(string titulo, DateTime fecha, NivelPrioridad prioridad)
    {
        Titulo = titulo;
        FechaLimite = fecha;
        Completada = false;
        Prioridad = prioridad;
    }

    public override string ToString()
    {
        string estado = Completada ? "Completada" : "Pendiente";
        return $"{Titulo} (Límete: {FechaLimite.ToShortDateString()}, Prioridad: {Prioridad}) - {estado}";
    }


    //Para guardar en archivo
    public string ToFileString()
    {
        return $"{Titulo}|{FechaLimite}|{Completada}|{Prioridad}";
    }

    //PAra cargar desde archivo
    public static TareaPrioridad FromFileFormat(string line)
    {
        var partes = line.Split('|');
        string titulo = partes[0];
        DateTime fecha = DateTime.Parse(partes[1]);
        bool completada = bool.Parse(partes[2]);
        NivelPrioridad prioridad = (NivelPrioridad)Enum.Parse(typeof(NivelPrioridad), partes[3]);

        TareaPrioridad tarea = new TareaPrioridad(titulo, fecha, prioridad);
        tarea.Completada = completada;
        return tarea;
    }
}




class Tarea
{
    public string Titulo { get; set; }
    public DateTime FechaLimite { get; set; }
    public bool Completada { get; set; }

    public Tarea(string titulo, DateTime fecha)
    {
        Titulo = titulo;
        FechaLimite = fecha;
        Completada = false;
    }

    public override string ToString()
    {
        string estado = Completada ? "Completada" : "Pendiente";
        return $"{Titulo} (Límete: {FechaLimite.ToShortDateString()}) - {estado}";
    }

}




class TareaTiempo
{
    public string Titulo { get; set; }
    public DateTime FechaLimite { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Completada { get; set; }
    public NivelPrioridad Prioridad { get; set; }   

    public TareaTiempo(string titulo, DateTime fecha, NivelPrioridad prioridad)
    {
        Titulo = titulo;
        FechaLimite = fecha;
        FechaCreacion = DateTime.Now;
        Completada = false;
        Prioridad = prioridad;
    }

    public override string ToString()
    {
        string estado = Completada ? "Completada" : "Pendiente";
        string diasRestantes;

        int diferencia = (FechaLimite - DateTime.Now).Days;

        if (diferencia > 0)
            diasRestantes = $"{diferencia} días restantes";
        else if (diferencia == 0)
            diasRestantes = "Último día";
        else
            diasRestantes = $"Vencida hace {-diferencia} dias";

        return $"{Titulo} (Creada: {FechaCreacion.ToShortDateString()}, Limite: {FechaLimite.ToShortDateString()}, Prioridad: {Prioridad}) - {estado} - {diasRestantes}";

    }
}
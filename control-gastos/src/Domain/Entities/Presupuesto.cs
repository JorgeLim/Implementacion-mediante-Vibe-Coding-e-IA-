namespace Domain.Entities;

public class Presupuesto
{
    public int IdPresupuesto { get; set; }
    public int IdArea { get; set; }
    public int IdCentroCosto { get; set; }
    public string Periodo { get; set; } = string.Empty;
    public decimal MontoTotal { get; set; }
    public decimal MontoUtilizado { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public bool Activo { get; set; } = true;
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaActualizacion { get; set; }
}

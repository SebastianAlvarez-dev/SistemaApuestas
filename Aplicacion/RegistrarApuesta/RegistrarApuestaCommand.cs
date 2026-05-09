namespace Aplicacion.RegistrarApuesta;

public class RegistrarApuestaCommand
{
    public Guid UsuarioId { get; set; }

    public Guid PartidoId { get; set; }

    public string Prediccion { get; set; } = string.Empty;

    public decimal Monto { get; set; }

    public decimal Cuota { get; set; }
}
using Dominio.Partidos;
namespace Aplicacion.RegistrarApuesta;

public class RegistrarApuestaCommand
{
    public Guid UsuarioId { get; set; }

    public Guid PartidoId { get; set; }

    public ResultadoPartido Prediccion { get; set; }

    public decimal Monto { get; set; }

    public decimal Cuota { get; set; }
}
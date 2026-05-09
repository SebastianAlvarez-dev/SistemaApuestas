using Dominio.Abstracciones;

namespace Dominio.Apuestas;

public class ApuestaRegistradaEvento : IEventoDominio
{
    public Guid ApuestaId { get; }

    public DateTime OcurrioEn { get; }

    public ApuestaRegistradaEvento(Guid apuestaId)
    {
        ApuestaId = apuestaId;
        OcurrioEn = DateTime.Now;
    }
}
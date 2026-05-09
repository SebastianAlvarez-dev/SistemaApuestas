using Dominio.Abstracciones;

namespace Dominio.Partidos;

public class Partido : Entidad
{
    public string EquipoLocal { get; private set; }
    public string EquipoVisitante { get; private set; }

    public bool Finalizado { get; private set; }

    public ResultadoPartido? Resultado { get; private set; }

    public Partido(
        Guid id,
        string equipoLocal,
        string equipoVisitante)
    {
        Id = id;
        EquipoLocal = equipoLocal;
        EquipoVisitante = equipoVisitante;
    }

    public void Finalizar(ResultadoPartido resultado)
    {
    Finalizado = true;
    Resultado = resultado;
    }
}
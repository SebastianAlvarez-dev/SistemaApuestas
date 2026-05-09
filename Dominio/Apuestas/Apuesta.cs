using Dominio.Abstracciones;
using Dominio.Partidos;
using Dominio.Usuarios;

namespace Dominio.Apuestas;

public class Apuesta : Entidad
{
    public Usuario Usuario { get; private set; }

    public Partido Partido { get; private set; }

    public ResultadoPartido Prediccion { get; private set; }

    public decimal Monto { get; private set; }

    public decimal Cuota { get; private set; }

    public bool Ganada { get; private set; }

    public Apuesta(
        Guid id,
        Usuario usuario,
        Partido partido,
        ResultadoPartido prediccion,
        decimal monto,
        decimal cuota)
    {
        Id = id;
        Usuario = usuario;
        Partido = partido;
        Prediccion = prediccion;
        Monto = monto;
        Cuota = cuota;
    }

    public decimal CalcularGanancia()
    {
        return Monto * Cuota;
    }

    public void MarcarGanada()
    {
        Ganada = true;
    }
}
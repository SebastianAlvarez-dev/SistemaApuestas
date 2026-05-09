using Dominio.Apuestas;

namespace Aplicacion.ResolverApuesta;

public class ResolverApuestaHandler
{
    public string Handle(Apuesta apuesta)
    {
        if (apuesta.Partido.Resultado == apuesta.Prediccion)
        {
            var ganancia = apuesta.CalcularGanancia();

            apuesta.Usuario.AgregarSaldo(ganancia);

            apuesta.MarcarGanada();

            return $"Apuesta ganada: ${ganancia}";
        }

        return "Apuesta perdida";
    }
}
// Caso de uso encargado de resolver apuestas en el sistema
using Dominio.Apuestas;

namespace Aplicacion.ResolverApuesta;

public class ResolverApuestaHandler
{
    // Verifica el resultado del partido y calcula ganancias
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
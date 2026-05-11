using Dominio.Apuestas;
using Dominio.Partidos;
using Dominio.Usuarios;
// Caso de uso encargado de registrar apuestas en el sistema
namespace Aplicacion.RegistrarApuesta;

public class RegistrarApuestaHandler
{
    // Ejecuta el flujo de registro de una apuesta
    public Apuesta Handle(
        RegistrarApuestaCommand command,
        Usuario usuario,
        Partido partido)
    {
        ApuestaServicio.Validar(
            usuario,
            partido,
            command.Monto);

        usuario.DescontarSaldo(command.Monto);

        var apuesta = new Apuesta(
            Guid.NewGuid(),
            usuario,
            partido,
            command.Prediccion,
            command.Monto,
            command.Cuota);

        return apuesta;
    }
}
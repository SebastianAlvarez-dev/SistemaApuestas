using Dominio.Partidos;
using Dominio.Usuarios;

namespace Dominio.Apuestas;

public static class ApuestaServicio
{
    public static void Validar(
        Usuario usuario,
        Partido partido,
        decimal monto)
    {
        if (partido.Finalizado)
        {
            throw new Exception(
                "No se puede apostar en un partido finalizado");
        }

        if (monto <= 0)
        {
            throw new Exception(
                "El monto debe ser mayor que cero");
        }

        if (usuario.Saldo < monto)
        {
            throw new Exception("Saldo insuficiente");
        }
    }
}
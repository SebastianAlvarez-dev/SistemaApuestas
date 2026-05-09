using Dominio.Abstracciones;

namespace Dominio.Usuarios;

public class Usuario : Entidad
{
    public string Nombre { get; private set; }
    public decimal Saldo { get; private set; }

    public Usuario(Guid id, string nombre, decimal saldo)
    {
        Id = id;
        Nombre = nombre;
        Saldo = saldo;
    }

    public void DescontarSaldo(decimal monto)
    {
        if (monto > Saldo)
        {
            throw new Exception("Saldo insuficiente");
        }

        Saldo -= monto;
    }

    public void AgregarSaldo(decimal monto)
    {
        Saldo += monto;
    }
}
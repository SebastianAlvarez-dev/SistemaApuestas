namespace Dominio.Abstracciones;
// Contrato base para eventos del dominio
public interface IEventoDominio
{
    DateTime OcurrioEn { get; }
}
using Aplicacion.RegistrarApuesta;
using Aplicacion.ResolverApuesta;
using Dominio.Partidos;
using Dominio.Usuarios;
// Creación de usuario y partido de prueba
var usuario = new Usuario(
    Guid.NewGuid(),
    "Sebastian",
    100);

var partido = new Partido(
    Guid.NewGuid(),
    "Barcelona",
    "Real Madrid");
// Datos necesarios para registrar una apuesta
var command = new RegistrarApuestaCommand
{
    UsuarioId = usuario.Id,
    PartidoId = partido.Id,
    Prediccion = ResultadoPartido.Local,
    Monto = 20,
    Cuota = 2.5m
};

var registrarHandler = new RegistrarApuestaHandler();

var apuesta = registrarHandler.Handle(
    command,
    usuario,
    partido);

// Simulación del resultado final del partido
Console.WriteLine("Apuesta registrada");

Console.WriteLine($"Saldo actual: {usuario.Saldo}");

partido.Finalizar(ResultadoPartido.Local);
// Resolución de apuesta y cálculo de ganancias

var resolverHandler = new ResolverApuestaHandler();

var resultado = resolverHandler.Handle(apuesta);

Console.WriteLine(resultado);

Console.WriteLine($"Saldo final: {usuario.Saldo}");
# Sistema de Apuestas de Fútbol
link del reporsitorio en git hub: https://github.com/SebastianAlvarez-dev/SistemaApuestas.git
## Descripción

Proyecto académico desarrollado con .NET y Domain-Driven Design (DDD) para modelar el dominio de un sistema de apuestas deportivas de fútbol.

## Objetivo

Implementar la capa de dominio aplicando:

- Entidades
- Enumeraciones
- Eventos de dominio
- Servicios de dominio
- Casos de uso
- Arquitectura en capas

## Tecnologías

- C#
- .NET 10
- Git

## Entidades principales

### 1. Usuario

* Datos:
- Id
- Nombre
- Saldo

### 2. Partido

* Datos:
- Id
- EquipoLocal
- EquipoVisitante
- Resultado
- Finalizado

### 3. Apuesta

* Datos:
- Id
- Usuario
- Partido
- Prediccion
- Monto
- Cuota
- Ganada

## Procesos implementados

### 1. Registro de apuestas

Permite:
- validar saldo del usuario,
- validar estado del partido,
- registrar apuestas deportivas.

### 2. Resolución de apuestas

Permite:
- verificar resultados del partido,
- calcular ganancias,
- actualizar saldo del usuario.

## Eventos de dominio

### ApuestaRegistradaEvento

Evento generado cuando una apuesta es registrada correctamente en el sistema.

## Enumeraciones

### ResultadoPartido

- Local
- Visitante
- Empate

## Arquitectura del proyecto

El sistema está dividido en tres capas principales:

### Dominio
Contiene:
- entidades,
- reglas de negocio,
- eventos de dominio,
- servicios de dominio.

### Aplicacion
Contiene:
- casos de uso,
- handlers,
- comandos.

### Presentacion
Contiene:
- Program.cs,
- ejecución y pruebas del sistema.

## Estructura del proyecto

```text
SistemaApuestas
│
├── Dominio
├── Aplicacion
└── Presentacion
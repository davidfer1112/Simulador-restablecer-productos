
# Simulador-restablecer-productos

Simulador-restablecer-productos es una aplicación .NET que simula un sistema de reabastecimiento de productos. Responde a las solicitudes de reabastecimiento enviadas desde la aplicación `taller2.net`.

## Requisitos

- .NET 8.0 SDK o superior
- [Repositorio del taller2.net](https://github.com/samiralejandro/taller2.net)

## Configuración

1. Clona el repositorio:

    ```sh
    git clone https://github.com/davidfer1112/Simulador-restablecer-productos
    cd ReplenishmentSimulator
    ```

2. Restaura los paquetes NuGet y ejecuta la aplicación:

    ```sh
    dotnet restore
    dotnet run
    ```

## Endpoints

- **POST** `/api/replenishment` - Simula la respuesta del sistema de reabastecimiento.

## Dependencia

Este proyecto es independiente, pero está diseñado para trabajar en conjunto con `taller2.net`. Asegúrate de que `taller2.net` esté configurado para enviar solicitudes a este servicio.



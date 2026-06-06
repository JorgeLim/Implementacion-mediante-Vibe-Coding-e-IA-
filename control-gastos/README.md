# 🏢 Sistema Web de Control de Gastos Empresariales

> **Proyecto académico** desarrollado mediante **Vibe Coding** e **Inteligencia Artificial**, implementando una API REST con **Clean Architecture** en .NET 10.

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-12-239120?style=flat-square&logo=csharp)](https://learn.microsoft.com/dotnet/csharp/)
[![Swagger](https://img.shields.io/badge/Swagger-UI-85EA2D?style=flat-square&logo=swagger)](https://swagger.io/)
[![Clean Architecture](https://img.shields.io/badge/Architecture-Clean-blue?style=flat-square)]()

---

## 📋 Descripción

Sistema de gestión de gastos empresariales que permite el control de áreas organizacionales, centros de costo, roles de usuarios y presupuestos. Construido con una **API REST** en ASP.NET Core, siguiendo estrictamente los principios de **Clean Architecture** (Arquitectura Limpia) y separación de responsabilidades.

---

## 🏗️ Arquitectura

El proyecto está organizado en 4 capas siguiendo los principios de **Clean Architecture**:

```
control-gastos/
└── src/
    ├── Domain/            ← Entidades del negocio (núcleo)
    ├── Application/       ← Casos de uso, DTOs, interfaces de servicios
    ├── Infrastructure/    ← Implementaciones de repositorios (en memoria)
    └── Presentation/      ← Controladores API, configuración, Swagger UI
```

### Diagrama de dependencias

```
Presentation
    ↓
Application  ←  Infrastructure
    ↓
  Domain
```

> **Regla clave:** Las capas superiores solo dependen de las capas inferiores. `Infrastructure` implementa las interfaces definidas en `Application`, nunca al revés.

---

## 📦 Módulos implementados

| Módulo | Entidad | Endpoints |
|---|---|---|
| 👤 **Usuarios** | `Usuario` | `GET /api/v1/usuarios` · `GET /api/v1/usuarios/{id}` |
| 🏢 **Áreas** | `Area` | `GET /api/v1/areas` · `GET /api/v1/areas/{id}` |
| 🛡️ **Roles** | `Rol` | `GET /api/v1/roles` · `GET /api/v1/roles/{id}` |
| 📊 **Centros de Costo** | `CentroCosto` | `GET /api/v1/centroscosto` · `GET /api/v1/centroscosto/{id}` |
| 💰 **Presupuestos** | `Presupuesto` | `GET /api/v1/presupuestos` · `GET /api/v1/presupuestos/{id}` |

---

## 🗂️ Estructura de archivos

```
src/
├── Domain/
│   └── Entities/
│       ├── Area.cs
│       ├── CentroCosto.cs
│       ├── Presupuesto.cs
│       ├── Rol.cs
│       └── Usuario.cs
│
├── Application/
│   ├── DTOs/
│   │   ├── AreaDto.cs
│   │   ├── CentroCostoDto.cs
│   │   ├── PresupuestoDto.cs
│   │   ├── RolDto.cs
│   │   └── UsuarioDto.cs
│   ├── Interfaces/
│   │   ├── IAreaRepository.cs
│   │   ├── IAreaService.cs
│   │   ├── ICentroCostoRepository.cs
│   │   ├── ICentroCostoService.cs
│   │   ├── IPresupuestoRepository.cs
│   │   ├── IPresupuestoService.cs
│   │   ├── IRolRepository.cs
│   │   ├── IRolService.cs
│   │   ├── IUsuarioRepository.cs
│   │   └── IUsuarioService.cs
│   └── Services/
│       ├── AreaService.cs
│       ├── CentroCostoService.cs
│       ├── PresupuestoService.cs
│       ├── RolService.cs
│       └── UsuarioService.cs
│
├── Infrastructure/
│   └── Repositories/
│       ├── AreaRepository.cs
│       ├── CentroCostoRepository.cs
│       ├── PresupuestoRepository.cs
│       ├── RolRepository.cs
│       └── UsuarioRepository.cs
│
└── Presentation/
    ├── Controllers/
    │   ├── ApiController.cs
    │   ├── AreasController.cs
    │   ├── CentrosController.cs
    │   ├── PresupuestosController.cs
    │   ├── RolesController.cs
    │   └── UsuarioController.cs
    ├── wwwroot/swagger-ui/
    │   ├── custom.css       ← Estilos personalizados de Swagger
    │   └── custom.js        ← Sidebar dinámico y filtros
    └── Program.cs
```

---

## 🚀 Cómo ejecutar el proyecto

### Requisitos previos

- [.NET SDK 10.0](https://dotnet.microsoft.com/download) o superior
- Git

### Pasos

```bash
# 1. Clonar el repositorio
git clone https://github.com/JorgeLim/Implementacion-mediante-Vibe-Coding-e-IA-.git

# 2. Navegar a la carpeta del proyecto
cd "Implementacion-mediante-Vibe-Coding-e-IA-/control-gastos"

# 3. Restaurar dependencias
dotnet restore

# 4. Compilar el proyecto
dotnet build

# 5. Ejecutar la API
cd src/Presentation
dotnet run
```

### Acceder a la documentación

Una vez ejecutado, abre tu navegador en:

```
http://localhost:{puerto}/swagger
```

> El puerto se mostrará en la consola al iniciar la aplicación.

---

## 🖥️ Swagger UI Personalizado

El proyecto incluye una interfaz de documentación personalizada sobre Swagger UI que incluye:

- **Barra lateral de navegación** — Filtra los endpoints por módulo con un solo clic
- **Botones de verbo HTTP** con colores semánticos (`GET` azul, `POST` verde, `PUT` naranja, `DELETE` rojo)
- **Barra de búsqueda** — Filtra endpoints en tiempo real por nombre o ruta
- **Botón Repositorio** — Acceso directo al código fuente en GitHub

---

## 🔧 Tecnologías usadas

| Tecnología | Versión | Uso |
|---|---|---|
| ASP.NET Core | 10.0 | Framework principal de la API |
| C# | 12 | Lenguaje de programación |
| Swashbuckle (Swagger) | 6.5 | Documentación automática de la API |
| Newtonsoft.Json | 8.0 | Serialización JSON |
| Repositorio en memoria | — | Simulación de base de datos |

---

## 📐 Patrones y principios aplicados

- ✅ **Clean Architecture** — Separación estricta de capas
- ✅ **Dependency Injection** — IoC container de ASP.NET Core
- ✅ **Repository Pattern** — Abstracción del acceso a datos
- ✅ **DTO Pattern** — Separación entre entidades de dominio y contratos de API
- ✅ **Interface Segregation** — Interfaces específicas por dominio
- ✅ **Single Responsibility** — Cada clase tiene una sola responsabilidad

---

## 👨‍💻 Autor

**JorgeLim**  
Proyecto desarrollado con asistencia de Inteligencia Artificial (Vibe Coding)  

[![GitHub](https://img.shields.io/badge/GitHub-JorgeLim-181717?style=flat-square&logo=github)](https://github.com/JorgeLim)

---

## 📄 Licencia

Este proyecto es de uso académico y educativo.

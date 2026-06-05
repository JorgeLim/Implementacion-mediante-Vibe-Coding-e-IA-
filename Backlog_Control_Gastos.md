# Backlog Inicial Priorizado – Sistema de Control de Gastos

## 1. Resumen ejecutivo del backlog

### Visión del proyecto
Sistema web empresarial para gestión de gastos, CFDI, presupuestos, aprobaciones y auditoría.

### Criterio de priorización
1. Base técnica mínima
2. Seguridad y autenticación
3. Catálogos organizacionales
4. Captura de gastos
5. Aprobaciones
6. Presupuesto
7. CFDI y documentos
8. Reportes
9. Auditoría
10. Hardening

### Estrategia incremental
Construcción mediante slices verticales pequeños, verificables e integrables.

---

## 2. Supuestos de trabajo

- Empresa única (single tenant)
- Autenticación propia
- Flujo inicial:
  - Borrador
  - Pendiente de aprobación
  - Aprobado
  - Rechazado
  - Procesado
- Presupuesto por área, año y mes

---

## 3. Huecos, ambigüedades o contradicciones

### Funcionales
- No existe entidad de pagos aunque el research menciona autorización de pago.
- No existe modelo para órdenes de compra ni 3-Way Match.

### Técnicos
- Frontend no completamente definido.
- Estrategia de almacenamiento documental no definida.

### Datos
- Catálogos sin contenido semilla.
- Reglas de deducibilidad no documentadas.

### Seguridad
- Política de contraseñas no definida.
- Expiración de sesión no definida.

---

## 4. Backlog inicial priorizado

| ID | Item | Tipo | Prioridad | Tamaño |
|-----|------|------|------------|---------|
| FND-01 | Configuración base proyecto | Foundation | Crítica | XS |
| FND-02 | Migración inicial BD | Foundation | Crítica | S |
| SEC-01 | Entidad usuarios | Seguridad | Crítica | S |
| SEC-02 | Login | Seguridad | Crítica | S |
| SEC-03 | Roles y autorización base | Seguridad | Crítica | S |
| CAT-01 | Catálogo de roles | Catálogo | Alta | XS |
| CAT-02 | Catálogo de áreas | Catálogo | Alta | XS |
| CAT-03 | Catálogo centros de costo | Catálogo | Alta | XS |
| CAT-04 | Categorías de gasto | Catálogo | Alta | XS |
| CAT-05 | Catálogo conceptos | Catálogo | Alta | XS |
| CAT-06 | Catálogo deducibilidad | Catálogo | Alta | XS |
| CAT-07 | Catálogo proveedores | Catálogo | Alta | S |
| CAT-08 | Estatus gasto | Catálogo | Alta | XS |
| GTO-01 | Crear gasto borrador | Full Slice | Crítica | S |
| GTO-02 | Agregar detalle gasto | Full Slice | Crítica | S |
| GTO-03 | Cálculo automático totales | Backend | Crítica | XS |
| GTO-04 | Consulta mis gastos | Frontend | Alta | XS |
| FLW-01 | Enviar aprobación | Flujo | Alta | XS |
| FLW-02 | Bandeja aprobador | Flujo | Alta | S |
| FLW-03 | Aprobar gasto | Flujo | Alta | XS |
| FLW-04 | Rechazar gasto | Flujo | Alta | XS |
| PRE-01 | Catálogo presupuestos | Presupuesto | Alta | S |
| PRE-02 | Consulta disponibilidad | Presupuesto | Alta | S |
| PRE-03 | Validación suficiencia | Presupuesto | Alta | S |
| CFDI-01 | Carga XML CFDI | Archivos | Alta | S |
| CFDI-02 | Extracción datos CFDI | Backend | Alta | M |
| DOC-01 | Adjuntar documentos | Archivos | Media | S |
| REP-01 | Reporte gastos aprobados | Reporte | Media | S |
| REP-02 | Exportación XLSX/CSV | Reporte | Media | XS |
| AUD-01 | Bitácora acciones gasto | Auditoría | Alta | S |
| AUD-02 | Auditoría catálogos | Auditoría | Media | S |
| HRD-01 | Restricciones edición | Hardening | Media | XS |
| HRD-02 | Validaciones seguridad | Hardening | Media | S |

---

## 5. Agrupación por fases

### Fase 1 – Fundación Técnica
FND-01, FND-02, SEC-01, SEC-02, SEC-03

### Fase 2 – Estructura Organizacional
CAT-01 a CAT-08

### Fase 3 – Captura de Gastos
GTO-01 a GTO-04

### Fase 4 – Aprobaciones
FLW-01 a FLW-04

### Fase 5 – Presupuesto
PRE-01 a PRE-03

### Fase 6 – CFDI y Documentos
CFDI-01, CFDI-02, DOC-01

### Fase 7 – Reportes
REP-01, REP-02

### Fase 8 – Auditoría
AUD-01, AUD-02

### Fase 9 – Hardening
HRD-01, HRD-02

---

## 6. Secuencia recomendada

1. FND-01
2. FND-02
3. SEC-01
4. SEC-02
5. SEC-03
6. CAT-02
7. CAT-03
8. CAT-08
9. GTO-01
10. GTO-02

Primer incremento recomendado:

**FND-01 – Configuración base proyecto**

---

## 7. Items demasiado grandes

### CFDI-02
- CFDI-02A Lectura XML
- CFDI-02B UUID
- CFDI-02C Emisor
- CFDI-02D Montos

### REP-01
- REP-01A Consulta
- REP-01B Filtro fecha
- REP-01C Filtro área

### AUD-01
- AUD-01A Creación
- AUD-01B Cambio estado
- AUD-01C Consulta bitácora

---

## 8. Primeros items para IA desarrolladora

1. FND-01
2. FND-02
3. SEC-01
4. SEC-02
5. SEC-03
6. CAT-02
7. CAT-03
8. CAT-08
9. GTO-01
10. GTO-02

Estos desbloquean la captura funcional de gastos y la base completa del sistema.

# Evidencia de prompt en ChatGPT
https://chatgpt.com/share/6a22278d-5190-83e8-975c-9aa54ed04680

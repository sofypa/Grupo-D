# Proyecto de Gestión de Notas

Este sistema permite a estudiantes gestionar sus notas por materia y categoría, con generación de reportes en PDF.

## Requisitos

- Visual Studio 2022 o superior
- .NET 8.0 (Windows)
- RDLC Report Viewer instalado
- Paquetes NuGet necesarios:
  - Microsoft.Reporting.WinForms

## Estructura del proyecto

- `ReportesNotas/InformeNotas.rdlc`: archivo de diseño del reporte
- `bin/Debug/net8.0-windows/`: carpeta donde se genera el PDF
- Imágenes de logos incluidas en el reporte

## Cómo generar el reporte

1. Filtra las notas por materia y categoría
2. Haz clic en **Generar PDF**
3. El archivo se guarda en tu carpeta de Documentos

## Verificación

- El archivo `InformeNotas.rdlc` debe tener:
  - Parámetros: `SubtituloReporte`, `PromedioReporte`
  - Dataset llamado `DataSet1` con columnas: `Materia`, `Categoria`, `Nota`, `total_posible`, `Comentario`

# API de League of Legends

## Descripción general
Esta API de League of Legends permite a los desarrolladores interactuar con los datos del juego de forma eficiente. Desarrollada con prácticas modernas en C#, aprovecha diversos patrones de diseño para ofrecer una arquitectura limpia y fácil de mantener.

## Tecnologías utilizadas
- **C#**: El lenguaje de programación principal para la creación de la API.

- **SQL Server**: Se utiliza para el almacenamiento y la recuperación de datos.

- **CQRS (Separación de Responsabilidades de Comandos y Consultas)**: Separa las operaciones de lectura y escritura para una mayor escalabilidad y mantenimiento.

- **Patrón de Repositorio**: Abstrae la lógica de acceso a los datos, promoviendo la separación de responsabilidades.

- **Patrón de Especificación**: Encapsula las reglas de negocio para aplicar la lógica de validación de forma fluida.

- **Patrón de Resultado**: Estandariza las respuestas de la API, ofreciendo resultados claros tanto para el éxito como para el error.

- **Arquitectura Limpia**: Organiza el código para mejorar la capacidad de prueba y la separación de responsabilidades. - **FluentValidation**: Proporciona una interfaz fluida para las reglas de validación, garantizando la integridad de los datos.

- **Serilog**: Implementa el registro estructurado para una mejor gestión y análisis de los registros.

- **Límite de velocidad**: Controla el número de solicitudes para evitar el uso indebido de la API.

- **DTOs (Objetos de Transferencia de Datos)**: Simplifica la transferencia de datos entre la API y los usuarios, reduciendo la sobrecarga.

- **Paginación con filtrado y ordenación**: Mejora la eficiencia de la recuperación de datos, permitiendo a los clientes solicitar subconjuntos de datos específicos.

## Funcionalidades
- **Recuperación de datos**: Consulta estadísticas de juego, información de jugadores y detalles de partidos.

- **Validación**: Garantiza que los datos entrantes cumplan con los criterios definidos antes de su procesamiento.

- **Registro**: Captura datos operativos críticos para la resolución de problemas y el análisis.

- **Escalabilidad**: Diseñado para gestionar múltiples solicitudes de forma eficiente mediante CQRS y limitación de velocidad.

## Primeros pasos
1. Clona el repositorio: `git clone https://github.com/juanmelgarl/Api-De-League-Of-Leguends.git`
2. Instala las dependencias: con dotnet build y run



<img width="958" height="415" alt="{2D5D3974-9696-4706-A277-41108411EB2B}" src="https://github.com/user-attachments/assets/3d6b0176-d89d-4513-9a6f-7031e85fecf8" />
<img width="924" height="482" alt="{54F8C24F-72FF-4746-AA0F-ADF727404961}" src="https://github.com/user-attachments/assets/061116bd-4431-46a2-96c9-caf4e2f6246c" />
<img width="928" height="456" alt="{168DED97-1DD4-4B01-A41C-DAC08CEBB064}" src="https://github.com/user-attachments/assets/75b25ae3-336c-4ec0-a259-b81f4355e3e4" />



3. Configuración: Configura la cadena de conexión de SQL Server en el archivo `appsettings.json`.

4. Ejecuta la API: Ejecuta la aplicación y accede a la API

## Contribuciones
¡Se agradecen las contribuciones! Envía una solicitud de extracción o abre una incidencia para cualquier mejora.

## Licencia
Este proyecto está bajo la licencia MIT.

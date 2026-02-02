# Frontend – Variación Mensual de Fondos Fintual

Este proyecto corresponde al frontend de una aplicación que muestra la variación mensual
de los fondos de inversión de Fintual de forma gráfica e interactiva.

El objetivo principal fue aprender y aplicar buenas prácticas modernas de Angular,
enfocándose en la visualización de datos y el manejo del estado.


## ¿Qué se hizo?

- Se desarrolló el frontend usando **Angular 21**, utilizando componentes standalone y
  manejo de estado con **Signals**.
- El frontend **no consume directamente la API pública de Fintual**.  
  En su lugar, se utiliza un **backend desarrollado en C# (.NET)** que entrega los datos
  ya transformados y listos para ser mostrados.
- Se implementaron **filtros por fondo y rango de fechas**, permitiendo al usuario decidir
  qué información visualizar.


## Visualización de datos

- Se utilizó **Chart.js** para generar el gráfico de la variación mensual (%), mostrando
  de forma clara cómo cambia el valor del fondo mes a mes.
- Debajo del gráfico se agregó una **tabla**, lo que permite revisar los datos con mayor
  detalle (precio inicial, precio final y variación por mes).


## Estilos

- Se utilizó **Tailwind CSS** para simplificar el manejo de estilos y evitar escribir CSS
  personalizado innecesario.
- Esto permitió concentrarse más en la lógica y estructura del proyecto que en el diseño.


## Decisiones técnicas

- Se separó la lógica de negocio en el backend para mantener el frontend más simple.
- Se usaron **Signals** en lugar de Observables en la vista para manejar el estado de carga,
  errores y datos de forma más clara.

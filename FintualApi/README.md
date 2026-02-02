# Backend – API para Variación Mensual de Fondos Fintual

El objetivo principal del backend es **centralizar la lógica de negocio** y entregar los datos ya procesados al frontend.

## ¿Qué se hizo?

- Se desarrolló una API REST en C# usando ASP.NET Core (.NET).
- El backend consume la **API pública de Fintual** para obtener los precios diarios de los fondos.
- A partir de esos datos, se calcula la **variación mensual**, comparando el primer y último valor disponible de cada mes.
- El backend expone un endpoint que devuelve la información lista para ser utilizada
  por el frontend.

## Cálculo de la variación mensual

Para cada mes:
- Se agrupan los valores diarios por año y mes.
- Se toma el **primer precio** y el **último precio** disponible del mes.
- Se aplica la fórmula:
  variación = (precio_fin - precio_inicio) / precio_inicio * 100

Con ello logramos que la carga del frontend no sea calcular y solo se centre en la vista.

## Decisiones técnicas

- Se decidió usar un backend intermedio en lugar de consumir la API de Fintual directamente desde el frontend, para mantener la lógica de negocio separada.
- Por otra parte nos evitamos problemas de CORs que puedan haber en caso de consumir directamente en el navegador.
- Se utilizaron **DTOs** para enviar solo la información necesaria al frontend, vitando exponer datos innecesarios.
- La lógica de consumo de la API externa y los cálculos se separaron en **servicios**, manteniendo los controladores simples.
- Se utilizó **HttpClient** para realizar las llamadas a la API de Fintual.
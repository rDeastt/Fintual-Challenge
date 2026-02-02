# Fintual-Challenge
Proyecto full Stack Utilizando la API publica de Fintual, adicional querys de bases de datos

Este proyecto obtiene información histórica de los fondos de inversión de Fintual y calcula
la variación mensual del valor cuota, mostrando los resultados de forma gráfica e interactiva.

La solución está dividida en un **backend en .NET** y un **frontend en Angular 21**.
  - Backend carpeta "FintualApi"
  - Frontend carpeta "fintual-app"

# Explicación de la solución
La arquitectura sigue un enfoque desacoplado:

- El **backend** consume la API pública de Fintual, procesa los datos y calcula la variación mensual.
- El **frontend** consume la API propia del backend y se encarga únicamente de la visualización,filtros y experiencia de usuario.

## Cómo ejecutar el proyecto
### 🔹 Backend (.NET Web API)

**Requisitos:**
- .NET SDK 8
- Visual Studio (recomendado)

**Pasos:**
1. Abrir la solución del backend en Visual Studio
<img width="1091" height="700" alt="image" src="https://github.com/user-attachments/assets/bd99ebb1-1adc-476f-b622-1a5eccb97427" />

2. Seleccionar el perfil **HTTPS**
<img width="862" height="490" alt="image" src="https://github.com/user-attachments/assets/2be8511c-ff83-48cb-b25a-25290da6521b" />
  
3. Ejecutar el proyecto (▶️ https)

El backend quedará disponible en:
  https://localhost:7245/
Se  podra utilizar swagger para realizar pruebas unitarias de la API en:
  https://localhost:7245/swagger/index.html
<img width="1805" height="1193" alt="image" src="https://github.com/user-attachments/assets/3380f1da-7a57-410e-b569-bbea8827e1b1" />

### 🔹 Frontend (Angular 21)
**Requisitos:**
- Node.js (v18 o superior)
- Angular CLI

**Pasos:**
1. Abrir una terminal en la carpeta del frontend
<img width="817" height="570" alt="image" src="https://github.com/user-attachments/assets/cd0757b9-a068-4594-b35b-7cbd1de1fadc" />

2. Instalar dependencias utilizando "npm install"
<img width="1772" height="635" alt="image" src="https://github.com/user-attachments/assets/18c3999b-e63b-43a0-b942-a8c25d673aa4" />

3. Ejecutar el proyecto con "ng serve -o", el frontend estará disponible en:
   http://localhost:4200/
<img width="1445" height="1123" alt="image" src="https://github.com/user-attachments/assets/0fa3968e-327d-4c36-9b1b-b6136e28d548" />

**Proeycto ejecutado correctamente:**
<img width="1553" height="1312" alt="image" src="https://github.com/user-attachments/assets/886d2f3e-3625-49fd-8759-3c18d53431c0" />

# Query SQL
Se realizo querys SQL respecto a lo siguiente:
- El total de aportes y retiros para diciembre de 2021
- Cantidad y Monto promedio de aportes y rescates por fecha.
- El nombre y apellido del usuario con más aportes



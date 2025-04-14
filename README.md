# 🩺 Sistema de Gestión Clínica CheckSalud - Aplicación de Escritorio, Web y MVC

Este proyecto es una solución completa para la gestión de una clínica médica, compuesta por una **aplicación de escritorio**, una **aplicación web** y un **módulo MVC**, diseñada para facilitar el manejo de médicos, pacientes, consultas, empresas y análisis clínicos. Cada módulo está enfocado en brindar funcionalidades específicas con interfaces intuitivas.

---

## 🖥️ Aplicación de Escritorio

### 📋 Menú Principal

Al iniciar sesión, se presenta un menú principal con acceso a los módulos de **Mantenimientos** y **Consultas**.

  ![image](https://github.com/user-attachments/assets/9ea9da3c-80b7-4fcc-89b8-c664fe75971f)

---

### 🔧 Módulo de Mantenimientos
  ![image](https://github.com/user-attachments/assets/bc202a60-cea9-4810-8128-9f8edf20d58b)


#### 👨‍⚕️ Médico


* Visualización general de médicos registrados
  ![image](https://github.com/user-attachments/assets/39b74859-e2e9-4bd1-be3f-a75c38820eff)

  
* **Agregar Médico**: ingreso de nuevos médicos al sistema  
  ![image](https://github.com/user-attachments/assets/abbb65ae-b566-4446-8560-c7473a238493)

  
* **Actualizar Médico**: modificar datos de médicos existentes  
  ![image](https://github.com/user-attachments/assets/2f42575d-07af-4b0a-88d6-15575f32c4bd)

  ![image](https://github.com/user-attachments/assets/1c89ba33-2a6f-4ae9-ad64-b8f13afb678e)


#### 🧑 Paciente

* Visualización de pacientes registrados
  ![image](https://github.com/user-attachments/assets/204fc71b-23d9-4ff5-8831-e8bfe054ad4c)


* **Agregar Paciente**: permite registrar un nuevo paciente  
  ![image](https://github.com/user-attachments/assets/a3d71ec1-adfe-4881-af08-70ca44c61f69)

* **Actualizar Paciente**: editar la información de pacientes existentes  
  ![image](https://github.com/user-attachments/assets/f3e850ec-d60a-4316-84e8-1a28a19053dc)

  ![image](https://github.com/user-attachments/assets/833c9dc6-f87e-4f3c-9af0-a5a462db9beb)

  
---

### 📊 Módulo de Consultas
  ![image](https://github.com/user-attachments/assets/5e3742ac-d7bd-4e59-8b97-c034858a92a8)

#### 📄 Listar Consultas por Paciente

* Permite listar todas las consultas de un paciente filtrando por **estado**  
  ![image](https://github.com/user-attachments/assets/9258fd3b-d986-4112-be1a-122817b2cf22)

#### 🗓️ Obtener Consultas por Fecha

* Muestra todas las consultas realizadas en un rango de fechas  
  ![image](https://github.com/user-attachments/assets/bef8cc56-ded1-4df4-accc-9922e0eeb4ac)

  
#### 🧪 Consulta por Especialidad

* Consulta estadística que muestra cuántas consultas se realizaron por **especialidad** entre dos fechas  
  ![image](https://github.com/user-attachments/assets/6ea38901-01de-4670-9af4-b8f92101ce55)

#### 🧑‍⚕️ Consultas Asignadas a Médico

* Muestra todas las consultas asignadas a un médico, con su estado actual (pendiente, finalizada, etc.)  
  ![image](https://github.com/user-attachments/assets/54bb1f10-85c8-40c5-9029-a81aca512aac)

---

## 🌐 Aplicación Web - Descripción Funcional

Este módulo permite al personal médico o administrativo trabajar desde la web para realizar tareas específicas.
  ![image](https://github.com/user-attachments/assets/731361a1-36ad-494b-b839-8ec2210271c0)


### 🏢 Mantenimiento Empresa

* **Agregar Empresa**: formulario para registrar una nueva empresa
  ![image](https://github.com/user-attachments/assets/9886791c-cfe1-472c-b453-9eefa704036f)

* **Actualizar Empresa**: modificación de información empresarial  
  ![image](https://github.com/user-attachments/assets/e208a318-086b-4331-b465-1e253eb44da4)
  ![image](https://github.com/user-attachments/assets/00b8d6fb-7437-49e5-89e3-f2640366268e)



### 🧾 Resultados Médicos
  ![image](https://github.com/user-attachments/assets/c535aec5-08db-4284-a1ef-2677e1260115)


* **Agregar Resultado**: ingreso de resultados de análisis para un paciente  
  ![image](https://github.com/user-attachments/assets/216cc1e1-7c16-44f2-a540-06f597dbc38e)

* **Actualizar Resultado**: modificación de resultados previamente guardados  
  ![image](https://github.com/user-attachments/assets/24f430a5-9e82-49f1-abde-e7d37f6442f3)
  ![image](https://github.com/user-attachments/assets/f7fdf542-cfef-4b24-9b0a-8c9d9b252329)

---

## 🌐 Aplicación MVC - Descripción Funcional

Módulo desarrollado en arquitectura **MVC**, especializado en el manejo de análisis clínicos.

### 🔬 Mantenimiento de Análisis

* Visualización general de los análisis registrados
  ![image](https://github.com/user-attachments/assets/7d210138-c270-4cab-bd4d-3942256e40e8)


### ➕ Agregar Análisis

* Formulario para registrar un nuevo análisis  
  ![image](https://github.com/user-attachments/assets/0905daf7-306c-44fb-8421-e48507b0c8ea)

### 🔄 Actualizar Análisis

* Edición de análisis existentes en el sistema  
  ![image](https://github.com/user-attachments/assets/46504576-d895-4db1-ae14-1f4905e4bd1a)
  ![image](https://github.com/user-attachments/assets/a8fedddc-ba1d-4548-b4ce-f0ac766c395b)

---

## 🧰 Tecnologías Utilizadas

* **C# y Windows Forms** (Aplicación de Escritorio)
* **ASP.NET Web Forms ** (Aplicación Web)
* **ASP.NET MVC** (Aplicación MVC)
* **SQL Server** para gestión de datos
* **Entity Framework** como ORM
* **HTML/CSS/Bootstrap** para la interfaz web

---

## ✅ Funcionalidades Clave

* Gestión de médicos y pacientes
* Control de consultas por filtros diversos
* Registro de resultados médicos
* Integración de estadísticas por especialidad
* Multiplataforma: escritorio, web y MVC

---

gestion-ckeck-salud

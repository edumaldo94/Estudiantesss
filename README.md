# 🎓 Sistema de Gestión de Estudiantes  

Aplicación de escritorio en **C# (WinForms, .NET Framework 4.7.2)** para gestionar estudiantes con soporte de base de datos **MySQL** mediante **LinqToDB**.  
Permite registrar, buscar, actualizar, eliminar y paginar estudiantes, incluyendo imágenes asociadas.  

---

## ✨ Características  

- ✅ Registro de estudiantes con validación de campos.  
- ✏️ Edición y eliminación de registros.  
- 📑 Paginación de resultados en el **DataGridView**.  
- 🔍 Búsqueda por **Id, nombre, apellido o email**.  
- 🖼️ Carga y visualización de imágenes de estudiantes.  
- 🖥️ Interfaz intuitiva y fácil de usar.  

---

## 🛠️ Requisitos  

- [Visual Studio 2022](https://visualstudio.microsoft.com/)  
- [.NET Framework 4.7.2](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472)  
- [MySQL Server](https://dev.mysql.com/downloads/mysql/) (local o remoto)  
- Paquetes NuGet:  
  - `LinqToDB`  
  - `MySql.Data`  
  - `System.Runtime.CompilerServices.Unsafe`  
  - `System.Threading.Tasks.Extensions`  
  - `Microsoft.Bcl.AsyncInterfaces`  

---

## ⚙️ Instalación  

### 1️⃣ Clonar el repositorio  
```bash
git clone <https://github.com/edumaldo94/Estudiantesss.git>
```
### 2️⃣ Configurar la base de datos
```bash
Crear la base de datos en MySQL:

CREATE DATABASE estudiantes;
USE estudiantes;

CREATE TABLE Estudiante (
   Id INT PRIMARY KEY AUTO_INCREMENT,
   nid VARCHAR(50),
   nombre VARCHAR(100),
   apellido VARCHAR(100),
   email VARCHAR(100),
   image LONGBLOB
);
```
### 3. Configurar la cadena de conexión
Editar el archivo App.config y actualizar la cadena de conexión PDHN1 con los datos de tu servidor MySQL:
```bash
<connectionStrings>
  <add name="PDHN1" 
       connectionString="Server=tu_servidor;Database=estudiantes;Uid=tu_usuario;Pwd=tu_contraseña;" 
       providerName="MySql.Data.MySqlClient"/>
</connectionStrings>
```
### 4. Restaurar paquetes NuGet
En Visual Studio, hacer clic derecho en la solución y seleccionar "Restaurar paquetes NuGet".

### 5. Compilar y ejecutar
Abrir la solución en Visual Studio 2022, compilar y ejecutar el proyecto.

## 💡 Uso
```bash
Registrar estudiante
Completa todos los campos en el formulario

Haz clic en el botón "Registrar"

Buscar estudiante
Utiliza el campo de búsqueda en la interfaz

Filtra por N°Id, nombre, apellido o email

Editar/Eliminar
Selecciona un estudiante en la tabla

Utiliza los botones "Editar" o "Eliminar"

Paginación
Ajusta el número de registros por página

Navega entre páginas con los controles de paginación
```
### 📁 Estructura del Proyecto
```bash
Estudiantess/
├── Logica/          # Lógica de negocio y validaciones
├── Data/            # Acceso a datos y modelos
├── Library/         # Utilidades (validación, manejo de imágenes)
└── Forms/           # Formularios de la aplicación
```
### 📄 Licencia
Este proyecto se distribuye bajo la licencia MIT. Consulta el archivo LICENSE para más detalles.

Nota: Si tienes problemas con la conexión a MySQL, asegúrate de que el servidor esté activo y que el usuario/contraseña sean correctos. Para dudas o mejoras, abre un issue en el repositorio.

## Características del diseño:
```bash
- **Encabezado visual atractivo** con iconos y badges de tecnologías utilizadas
- **Secciones bien organizadas** con emojis para una mejor identificación visual
- **Código formateado** con sintaxis highlighting para SQL y XML
- **Estructura clara** que facilita la lectura y navegación
- **Elementos visuales** que resaltan las partes importantes
```
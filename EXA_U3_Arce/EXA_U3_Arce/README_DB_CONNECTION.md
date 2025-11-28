# Guía de Configuración de Base de Datos

Si deseas ejecutar este proyecto en otra computadora, es probable que necesites actualizar la cadena de conexión a la base de datos.

## 1. Ubicación del Archivo de Configuración
El archivo que contiene la configuración de la conexión es **`Web.config`**, ubicado en la raíz del proyecto.

## 2. Qué Cambiar
Busca la sección `<connectionStrings>` dentro de `Web.config`. Verás una línea similar a esta:

```xml
<add name="AppDbContext" 
     connectionString="Data Source=.\MSSQLSERVER1;Initial Catalog=EXA_U3_ArceDB;Integrated Security=True" 
     providerName="System.Data.SqlClient" />
```

Debes modificar el valor de `connectionString` según tu entorno:

### Opción A: Autenticación de Windows (Recomendado Localmente)
Si usas tu usuario de Windows para entrar a SQL Server:
*   **Data Source**: Cambia `.\MSSQLSERVER1` por el nombre de tu servidor SQL.
    *   Ejemplos comunes: `.` (punto), `(local)`, `.\SQLEXPRESS`, `LOCALHOST`.
    *   Puedes ver el nombre del servidor al abrir SQL Server Management Studio (SSMS).
*   **Integrated Security**: Déjalo en `True`.

### Opción B: Autenticación de SQL Server
Si tienes un usuario y contraseña específicos para la base de datos:
*   **Data Source**: El nombre de tu servidor.
*   **Integrated Security**: Cámbialo a `False`.
*   **User ID**: Tu usuario de SQL (ej. `sa`).
*   **Password**: Tu contraseña.

Ejemplo:
```xml
connectionString="Data Source=NOMBRE_SERVIDOR;Initial Catalog=EXA_U3_ArceDB;Integrated Security=False;User ID=sa;Password=tu_password"
```

## 3. Verificación
1. Asegúrate de que el servicio de SQL Server esté corriendo.
2. Asegúrate de que la base de datos `EXA_U3_ArceDB` exista en el nuevo servidor.
3. Si tienes problemas, revisa que el protocolo TCP/IP esté habilitado en el "SQL Server Configuration Manager".

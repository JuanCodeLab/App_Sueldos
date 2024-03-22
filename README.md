# Taller de Programación

Este repositorio contiene el trabajo práctico solicitado por el docente para considerar nota final de proyecto en taller.
El proyecto consiste en una aplicacion simple de formularios basada en C# con controles CRUD sobre una base de datos SQL.

Detalles del Curso:
Módulo: Taller de Programación
Profesor: Carlos Emmot
Estudiante: Juan Carlos Diaz Palma

---

## Detalles del contenido

Dentro de las presentes carpetas de este repositorio se puede encontrar el diagrama de clases correspondiente a nuestra aplicación el cual fue solicitado por el docente como parte del trabajo de presentación.
Además del contenido del programa, también se incluye la estructura de la base de datos a utilizar a modo de ejemplo para poder trabajar con esta dentro de la aplicación.

---

## Detalles de la aplicación

### Información

La aplicación consiste en un programa en donde existen dos tipos de usuarios, un Administrador que tiene la característica de agregar nuevos trabajadores a la base de datos y un Usuario que se encargará de administrar los datos.
Para poder gestionar dichos procesos se generaron distintas pantallas de vistas para cada proceso.

*Cabe considerar que el cliente ficticio solicitó de la siguiente manera el accionar de la aplicación.*

### Arquitectura

Para generar un trabajo más ordenado, pero manteniendo un patrón simple, rápido y efectivo de trabajo, se decide relacionar el sistema por una arquitectura por capas. 
Se realiza un modelo simple de Presentación, Lógica, Acceso a datos y Base de Datos. Relacionando así a cada una de las clases y formularios en su capa respectiva.

### Vistas y procesos del programa 

• Vista de inicio de sesion: Formulario donde usuario ingresará sus datos; nombre de usuario y contraseña (admin 1234 y user 1234 por defecto en la base de datos).
• Vista de integracion de empleados: Si una cuenta Administrador inicia sesion dentro del programa ingresará a una vista unica donde podrá agregar nuevos empleados a la base de datos.
• Vista de Visualizacion de empleados registrados: Si una cuenta Usuario incia sesion dentro del programa ingresará a una vista unica donde este podrá revisar los datos de los empleados registrados.
• Vista de Calculo de Sueldo de empleados registrados: Si una cuenta Usuario da click dentro de uno de los empleados de la tabla anteriormente indicada, el Usuario podrá visualizar una vista de cálculo de sueldo donde podrá especificar las horas trabajadas, horas extras, fondo de salud y administración de fondos de pensiones de este.
Con esta información el programa realizará un calculo matematico simple para otorgar el sueldo bruto del trabajador y su sueldo liquido. Informacion que podra ser guardada por el Usuario si este la necesita.

---

# Conclusión

En el análisis del código proporcionado y las discusiones anteriores sobre la aplicación de sueldos, se evidenció un enfoque orientado a objetos en el diseño del sistema, donde se definieron clases para representar entidades clave como empleados y cálculos relacionados con los sueldos. Además, se utilizó el enfoque de Windows Forms para construir la interfaz de usuario. 

El código presentado reveló una interacción compleja entre diferentes componentes del sistema, como formularios, clases de cálculo y acceso a datos. Se utilizó la lógica de base de datos para realizar operaciones como inserción, actualización y eliminación de registros de empleados. Además, se implementó lógica de cálculo para determinar los sueldos brutos y líquidos de los empleados, considerando los descuentos de AFP y de salud.




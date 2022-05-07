# 🚀 Primer Parcial - Programacion Orientada Objetos. 🚀

## 🏋️ Ejercicio - Gimnacio. 🏋️


## Descripcion del proyecto: 📓

*   ###  General: El proyecto es la representacion de un gimnacio y sus sistema de inscripcion a clases.
    Las clases que conforman al mismo son:

    1-  Persona: es una clase abstracta que tiene los miembros abstractos Nombre, Apellido, Dni.

    2-  Alumno: es una clase la cual hereda de Persona, la cual hace un override de las propiedades Nombre, Apellido, Dni. Ademas tiene un miembro ListaClases, la cual es una lista de las clases a las que se encuentra inscripto. 
    Tiene un constructor en donde popula las propiedades Nombre, Apellido y Dni y crea una lista del tipo Clase.
    Cuenta con los metodos InscribirAClase, el cual realiza la inscripcion a las clases y ListarClases el cual Lista las clases a las que esta inscripto.
    Esta clase ademas implementa el metodo Pagar que hereda de la interfaz IPagador.

    3-  Profesor: clase que hereda de la clase Persona, cuenta con las propiedades Basicas que hereda y hace override de Persona, ClasesACargo la cual es una lista del tipo Clase que tiene las clases que tiene a su cargo, Posee un constructor para popular las propiedades basicas, crear una nueva lista de Clase y asicgar una clase correspondiente al profesor.
    Implementa el metodo Cobrar que hereda de la interfaz ICobrador y el metodo AsignarClase que hereda de la interfaz IAsignable.

    4-  Diciplina: La cual representa una diciplia de una Clase, tiene las propiedades Nombre y Descripcion y un constructor para pupular estas propiedades.

    5-  Clase: cuenta con las propiedades CantInscriptos, Nombre, Dias, Horario, Diciplina, ValorCuota. Por medio del construcor popula estas propiedades y ademas Implementa el metodo SumarInscripto que hereda de la Interfaz IInscribible.

    6-  Presentacion: Ademas cuenta con la clase Presentacion la cual se utilizo para crear la presentacion que se puede ver al correr el programa, Tiene la propiedad RutaPresentacion, la cual contiene la ruta para el archivo de presentacion, el metodo IniciarPresentacion el cual ejecuta la presentacion y un constructor el cual popula la propuedad RutaPresentacion con la ruta correspondiente.

    El proyecto tambien cuenta con las Interfaces:

    1-  IAsignable: El cual tiene el metodo AsignarClase.
    2-  ICobrador: El cual tiene el metodo Cobrar.
    3-  IPagador: El cual tiene el metodo Pagar.

*   ### Presentacion: El proyecto tiene una presentacion customizable mediante la modificacion del archivo presentacion.csv.

    *   En caso de que el archivo "presentacion.csv" no se encuentre disponible, se producira una exepcion la cual sera capturada y devolvera una presentacion basica por defecto.

*   ### Programa: El programa al ejecutarlo mostrara una presentacion e ira guiando al usuario para su uso.


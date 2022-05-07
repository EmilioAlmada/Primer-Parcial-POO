using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Biblioteca;
namespace Programa_Gym
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creacion de Diciplinas:
            Diciplina Spinning = new Diciplina("Spininning", "Clase con Bicicletas Fijas donde se trabaja la resistencia");
            Diciplina Zumba = new Diciplina("Zumba", "Clase para mejorar la condicion fisica bailando - bajo impacto -");
            Diciplina Boxeo = new Diciplina("Boxeo", "Entrenamiento de Sparring adaptados segun distintos niveles");
            Diciplina Taekwondo = new Diciplina("Taekwondo", "Arte Marcial, ideal para entrenamiento fisico y defensa personal");
            Diciplina Natacion = new Diciplina("Natacion", "Clases de natacion guiadas, divididas segun niveles y objetivos");
            Diciplina Yoga = new Diciplina("Yoga", "Clase ideal para lograr una mejor relajacion y mejorar la flexibilidad");

            // Creacion de las Clases del Gimnacio:
            Clase ClaseSpinning = new Clase("Clase Spining", "Lunes Y Viernes", "18:00hs", Spinning, 1500);
            Clase ClaseZumba = new Clase("Clase Zumba", "Martes Y Jueves", "16:00hs", Zumba, 1000);
            Clase ClaseBoxeo = new Clase("Clase Boxeo", "Miercoles Y Viernes", "17:00hs", Boxeo, 1800);
            Clase ClaseTaekwondo = new Clase("Clase Taekwondo", "Martes Y Jueves", "19:00hs", Taekwondo, 1900);
            Clase ClaseNatacion = new Clase("Clase Natacion", "Lunes, Martes, Miercoles y Viernes", "11:00hs", Natacion, 3000);
            Clase ClaseYoga = new Clase("Clase Yoga", "Lunes y Miercoles", "10:00hs", Yoga, 1200);

            //Creacion de los profesores
            Profesor ProfesorSpinning = new Profesor("Juan", "Sanchez", 11111111, ClaseSpinning);
            Profesor ProfesorZumba = new Profesor("Maria", "Gimenez", 22222222, ClaseZumba);
            Profesor ProfesorBoxeo = new Profesor("Roberto", "Ramos", 33333333, ClaseBoxeo);
            Profesor ProfesorTaekwondo = new Profesor("Romualdo", "Ramirez", 44444444, ClaseTaekwondo);
            Profesor ProfesorNatacion = new Profesor("Natalia", "Gonzales", 55555555, ClaseNatacion);
            Profesor ProfesorYoga = new Profesor("Pedro", "Rodriges", 66666666, ClaseYoga);

            // Creacion de alumnos
            Alumno Alumno1 = new Alumno("Pepe", "Garibaldi", 77777777);
            Alumno Alumno2 = new Alumno("Miguel", "Sanchez", 88888888);
            Alumno Alumno3 = new Alumno("Martina", "Rios", 99999999);
            Alumno Alumno4 = new Alumno("Gonzalo", "Lamana", 10101010);

            var InicioDelPrograma = new Presentacion();
            InicioDelPrograma.IniciarPresentacion();

            // Inscripcion del primer alumno a la clase de natacion
            Console.WriteLine($"Presione Enter para inscribir al Alumno uno a la clase de natacion:");
            Console.ReadLine();
            Alumno1.InscribirAClase(ClaseNatacion);
            Console.WriteLine($"El alumno {Alumno1.Nombre} {Alumno1.Apellido} se encuentra inscripto a la/s clase/s:");
            Alumno1.ListarClases();
            Console.WriteLine($"Aqui esta el comprobante de pago de la inscripcion:");
            Alumno1.Pagar();

            // Inscripcion del segundo alumno a la clase de boxeo
            Console.WriteLine($"Exelente - Ahora precione Enter para inscribir a {Alumno2.Nombre} a la clase de Boxeo:");
            Console.ReadLine();
            Alumno2.InscribirAClase(ClaseBoxeo);
            Console.WriteLine($"El alumno {Alumno2.Nombre} {Alumno2.Apellido} se encuentra inscripto a la/s clase/s:");
            Alumno2.ListarClases();
            Console.WriteLine($"Aqui esta el comprobante de pago de la inscripcion:");
            Alumno2.Pagar();
            Console.ReadLine();

            // Inscripcion del tercer Alumno
            int opcionClase = 0;
            Console.WriteLine($"{Alumno3.Nombre} no sabe si inscribirse a la clase de Zumba o de Spinning, ayudalo/a a tomar la decision:");
            Console.WriteLine($"Ingresa el numero para seleccionar una opcion:");
            Console.WriteLine($"1-Zumba");
            Console.WriteLine($"2-Spinning");

            try
            {
                opcionClase = Convert.ToInt16(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                opcionClase = 3;
            }

            switch (opcionClase)
            {
                case 1:
                    Alumno3.InscribirAClase(ClaseZumba);
                    break;
                case 2:
                    Alumno3.InscribirAClase(ClaseSpinning);
                    break;
                default:
                    Alumno3.InscribirAClase(ClaseZumba);
                    Console.WriteLine($"De acuerdo, como tampoco te podias decidir...");
                    break;
            }
            Console.WriteLine($"{Alumno3.Nombre} se inscribio a:");
            Alumno3.ListarClases();
            Console.WriteLine($"Aqui esta el comprobante de pago de la inscripcion:");
            Alumno3.Pagar();
            Console.ReadLine();

            // Inscripcion del tercer Alumno
            Alumno4.InscribirAClase(ClaseTaekwondo);
            Console.WriteLine($"{Alumno4.Nombre} quiere inscribirse a 2 clases:");
            Console.WriteLine($"Ya se anoto en Taekwondo, ¿Que otra clase le recomendas?:");
            Console.WriteLine($"Ingrese la opcion correspondiente:");
            Console.WriteLine($"1-Zumba");
            Console.WriteLine($"2-Spinning");
            Console.WriteLine($"3-Natacion");
            Console.WriteLine($"4-Yoga");
            Console.WriteLine($"5-Boxeo");

            try
            {
                opcionClase = Convert.ToInt16(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                opcionClase = 6;
            }

            switch (opcionClase)
            {
                case 1:
                    Alumno4.InscribirAClase(ClaseZumba);
                    break;
                case 2:
                    Alumno4.InscribirAClase(ClaseSpinning);
                    break;
                case 3:
                    Alumno4.InscribirAClase(ClaseNatacion);
                    break;
                case 4:
                    Alumno4.InscribirAClase(ClaseYoga);
                    break;
                case 5:
                    Alumno4.InscribirAClase(ClaseBoxeo);
                    break;
                default:
                    Alumno4.InscribirAClase(ClaseYoga);
                    Console.WriteLine($"De acuerdo, como tampoco te podias decidir...");
                    break;
            }
            Console.WriteLine($"{Alumno4.Nombre} se inscribio a:");
            Alumno4.ListarClases();
            Console.WriteLine($"Aqui esta el comprobante de pago de la inscripcion:");
            Alumno4.Pagar();
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"¡Llego fin de mes!");
            Console.WriteLine($"Los profesores deben cobrar su sueldo:");
            Console.ForegroundColor = ConsoleColor.Gray;

            List<Profesor> Profesores = new List<Profesor>();
            Profesores.Add(ProfesorBoxeo);
            Profesores.Add(ProfesorZumba);
            Profesores.Add(ProfesorTaekwondo);
            Profesores.Add(ProfesorYoga);
            Profesores.Add(ProfesorSpinning);
            Profesores.Add(ProfesorNatacion);

            foreach (var profesor in Profesores)
            {
                profesor.Cobrar();
            }
        }
    }
}

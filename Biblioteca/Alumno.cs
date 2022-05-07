using System;
using System.Collections.Generic;
namespace Biblioteca
{

    public class Alumno : Persona, IPagador
    {
        public Alumno() { }

        public Alumno(string nombre, string apellido, int dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            ListaClases = new List<Clase>();
        }

        public override string Nombre { get; set; }
        public override string Apellido { get; set; }
        public override int Dni { get; set; }
        private List<Clase> ListaClases { get; set; }

        public void InscribirAClase(Clase clase)
        {
            ListaClases.Add(clase);
            clase.SumarInscripto();
        }

        public void ListarClases()
        {
            foreach (var clase in ListaClases)
            {
                Console.WriteLine($"{clase.Nombre}, Horarios: {clase.Dias} a las {clase.Horario}");
            }
        }
        public void Pagar()
        {
            double totalAPagar = 0;

            foreach (var clase in ListaClases)
            {
                totalAPagar += clase.ValorCuota;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"--Comrobante de pago--");
            Console.WriteLine($"| Total: ${totalAPagar}        |");
            Console.WriteLine($"----------------------");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

}
using System;
using System.Collections.Generic;
namespace Biblioteca
{
    public class Profesor : Persona, ICobrador, IAsignable
    {
        public Profesor() { }

        public Profesor(string nombre, string apellido, int dni, Clase clase) : base(nombre, apellido, dni)
        {
            ClasesACargo = new List<Clase>();
            AsignarClase(clase);
        }

        public override string Nombre { get; set; }
        public override string Apellido { get; set; }
        public override int Dni { get; set; }
        public List<Clase> ClasesACargo { get; set; }


        public void Cobrar()
        {
            double totalACobrar = 0;
            double subtotal = 0;
            foreach (var clase in ClasesACargo)
            {
                subtotal = (clase.CantInscriptos * clase.ValorCuota);
                totalACobrar += subtotal * 0.6; //El Gimnacio se queda con el 40% 
            }
            Console.WriteLine($"Liquidacion de sueldo de {Nombre} {Apellido}: ${totalACobrar}");
        }

        public void AsignarClase(Clase clase)
        {
            ClasesACargo.Add(clase);
        }
    }
}
namespace Biblioteca
{
    public abstract class Persona
    {

        public Persona(){}

        public Persona(string nombre,string apellido, int dni){
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }
        public abstract string Nombre { get; set; }
        public abstract string Apellido { get; set; }
        public abstract int Dni { get; set; }
    }
}
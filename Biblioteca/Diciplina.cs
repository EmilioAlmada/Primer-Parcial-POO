namespace Biblioteca
{
    public sealed class Diciplina
    {
        public Diciplina(){}
        public Diciplina(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
        string Nombre { get; set; }
        string Descripcion { get; set; }
    }
}
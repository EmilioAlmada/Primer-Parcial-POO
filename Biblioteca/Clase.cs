namespace Biblioteca

{
    public class Clase : IInscribible
    {
        public Clase() { }

        public Clase(string nombre, string dias, string horario, Diciplina diciplina, double valorCuota)
        {
            Nombre = nombre;
            Dias = dias;
            Horario = horario;
            Diciplina = diciplina;
            ValorCuota = valorCuota;
        }

        public void SumarInscripto()
        {
            CantInscriptos++;
        }
        public int CantInscriptos { get; set; }
        public string Nombre { get; set; }
        public string Dias { get; set; }
        public string Horario { get; set; }
        public Diciplina Diciplina { get; set; }
        public double ValorCuota { get; set; }
    }
}
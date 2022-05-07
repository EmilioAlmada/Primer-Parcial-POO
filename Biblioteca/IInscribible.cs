namespace Biblioteca
{
    public interface IInscribible
    {
        int CantInscriptos { get; set; }
        void SumarInscripto();
    }
}
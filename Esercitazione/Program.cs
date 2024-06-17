namespace Esercitazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta a = new Atleta();
            a.Nome = "Davide";
            a.Cognome = "Frattini";
            a.Sport = "piangere";
            a.descrizione();
        }
    }
}

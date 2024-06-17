using System.Runtime.CompilerServices;

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

            Dipendente b = new Dipendente();
            b.Nome = "Francesco";
            b.Cognome = "Facchinetti";
            b.Azienda = "Nessuna";
            b.descrizionedipendente();

            Animale c = new Animale();
            c.Nome = "Wolly";
            c.Specie = "cane";
            c.descrizioneAnimale();

            Veicolo d = new Veicolo();
            d.Veicol = "macchina";
            d.Marca = "opel";
            d.descrizioneVeicolo();
        }
    }
}

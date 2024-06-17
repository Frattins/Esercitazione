using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    internal class Atleta
    {
        string nome;
        string cognome;
        string sport;


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public void descrizione()
        {
            Console.WriteLine(nome);
            Console.WriteLine(cognome);
            Console.WriteLine(sport);
            Console.WriteLine("Mi chiamo" + nome + " " + cognome + " e pratico " + sport););
        }

    }
}

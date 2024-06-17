using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    internal class Animale
    {
        string nome;
        string specie;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Specie
        {
            get { return specie; }
            set { specie = value; }
        }

        public void descrizioneAnimale()
        {
            Console.WriteLine("il suo nome è" + "" + nome + "" + "ed è un " + "" + specie);
        }

 
    }
}

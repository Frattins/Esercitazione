using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    internal class Dipendente
    {
        string nome;
        string cognome;
        string azienda;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }
        public string Azienda
        {
            get { return azienda; }
            set { azienda = value; }
        }

        public void descrizionedipendente()
        {
            Console.WriteLine(nome);
            Console.WriteLine(cognome);
            Console.WriteLine(azienda);
            Console.WriteLine("Mi chiamo" + "" + nome + " " + cognome + " e lavoro in " + azienda);
        }
    }

}

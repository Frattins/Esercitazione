using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    internal class Veicolo
    {
        string marca;
        string veicolo;



        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Veicol
        {
            get { return veicolo; }
            set { veicolo = value; }
        }


        public void descrizioneVeicolo()
        {
            Console.WriteLine("Questa è una" + "" + veicolo + "" + "della" + marca);

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanikowie
{
    class Mechanik
    {
        public string Imię;
        public string Nazwisko;
        public int Rok_Zatrudnienia;
        public decimal Stawka;

        public static List<Mechanik> mechanikowie = new List<Mechanik>();

        public override string ToString()
        {
            return Imię + " " + Nazwisko + " " + "(" + Stawka + " zł/godz)";
        }

    }
}

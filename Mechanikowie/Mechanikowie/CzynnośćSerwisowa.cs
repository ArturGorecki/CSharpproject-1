using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanikowie
{
    class CzynnośćSerwisowa
    {
        public string Numer_Rejestracyjny;
        public DateTime Data_Naprawy;
        public Mechanik Mechanik;
        public decimal Koszt_Części;
        public int Czas_Pracy;

        public static List<CzynnośćSerwisowa> Naprawy = new List<CzynnośćSerwisowa>();

        public decimal Koszt => Koszt_Części + Czas_Pracy * Mechanik.Stawka;
    }
}

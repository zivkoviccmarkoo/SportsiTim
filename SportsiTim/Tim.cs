using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsiTim
{
    internal class Tim
    {
        public string ID { get; set; }
        public string ImeKluba { get; set; }
        public string Trener { get; set; }
        public int GodinaUsnutka { get; set; }

        public override string ToString()
        {
            return "Ime kluba " + ImeKluba + "Trener " + Trener + "Godina osnutka" + GodinaUsnutka;
        }
        public int CompareTo(object obj)
        {
            int rez = this.ImeKluba.CompareTo(((Tim)obj).ImeKluba);
            if (rez == 0)
                rez = this.Trener.CompareTo(((Tim)obj).Trener);
            return rez;

        }

    }
}

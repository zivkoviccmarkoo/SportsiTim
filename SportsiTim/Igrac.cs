using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsiTim
{
    internal class Igrac
    {
        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string adresa { get; set; }
        public override string ToString()
        {
            return  Prezime + " - " +Ime+ " - " + adresa;

        }
        public int CompareTo(object obj)
        {
            int rez = this.Prezime.CompareTo(((Igrac)obj).Prezime);
            return rez;

        }
    }
}

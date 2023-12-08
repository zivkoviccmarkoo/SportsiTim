using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsiTim
{
    internal class Trenira 
    {
        public Igrac igrac { get; set; }
        public Tim tim { get; set; }
        public DateTime DatumPrikljicivanjaTimu { get; set; }
        public int CjenaIgraca { get; set; }
        public override string ToString()
        {
            return "Igarc " + igrac + "Tim " + tim + "Datum priključivanja timu" + DatumPrikljicivanjaTimu;
        }
        public int CompareTo(object obj)
        {
            int rez = this.DatumPrikljicivanjaTimu.CompareTo(((Trenira)obj).DatumPrikljicivanjaTimu);

            return rez;



        }

    }

   
}

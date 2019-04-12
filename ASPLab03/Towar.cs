using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPLab03
{
    class Towar
    {
        private string name;
        private double netto;
        private int ilosc;
        private string typ;

        public Towar(string name, double netto, int ilosc, string typ)
        {
            this.name = name;
            this.netto = netto;
            this.ilosc = ilosc;
            this.typ = typ;
        }

        public Towar(string name, double netto, int ilosc) : this(name, netto, ilosc, "unknown")
        {
            
        }

        public Towar(string name, double netto) : this(name, netto, 0, "unknown")
        {

        }

        public Towar(string name) : this(name, 0, 0, "unknown")
        {

        }

        public double Brutto
        {
            get
            {
                return netto * 1.23;
            }

            set
            {
                netto = value / 1.23;
            }
        }

        public override string ToString()
        {
            return netto + " - " + Brutto;
        }
    }
}

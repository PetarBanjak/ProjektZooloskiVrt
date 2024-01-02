using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt___Zooloski_vrt.Model
{
    internal class Zaposlenici: IComparable
    {

        private string ime;
        private string prezime;
        private int godine;
        private string radni_polozaj;

        public string Ime { get { return ime; } set { this.ime = value; } }
        public string Prezime { get { return prezime; } set { this.prezime = value; } }
        public int Godine { get { return godine; } set { this.godine = value; } }
        public string Radni_Polozaj { get { return radni_polozaj; } set { radni_polozaj = value; } }

        public int CompareTo(object obj)
        {

            int rez = this.Prezime.CompareTo(((Zaposlenici)obj).prezime);
            if (rez == 0)
            {
                rez = this.Ime.CompareTo(((Zaposlenici)obj).ime);
                return rez;
            }

            return rez;

        }

        public override string ToString() => this.Prezime + ", " + this.Ime;

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt___Zooloski_vrt.Model
{
    internal class Zivotinje
    {

        private string zivotinjska_vrsta;
        private string vrsta;
        private string pasmina;
        private string prehrana;
        private int serijski_broj;

        public string Zivotinjska_Vrsta { get { return zivotinjska_vrsta; } set { this.zivotinjska_vrsta = value; } }
        public string Vrsta { get { return vrsta; } set { this.vrsta = value; } }
        public string Pasmina { get { return pasmina; } set { this.pasmina = value; } }
        public string Prehrana { get { return prehrana; } set { prehrana = value; } }
        public int Serijski_Broj { get { return serijski_broj; } set { serijski_broj = value; } }

        public int CompareTo(object obj)
        {

            int rez = this.Serijski_Broj.CompareTo(((Zivotinje)obj).serijski_broj);

            return rez;

        }

        public override string ToString() => this.Vrsta + " " + this.Pasmina + " \n " + this.Serijski_Broj;

    }
}

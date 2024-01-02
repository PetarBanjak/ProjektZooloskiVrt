using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt___Zooloski_vrt.Model
{
    internal class Nastamba: IComparable
    {

        private string ime;
        private string zivotinje;
        private int broj_zivotinja;
        private string velicina;
        private Zaposlenici zaposlenik;
        private Zivotinje zivotinja;
        private int serijski_broj;


        public string Ime { get { return ime; } set { this.ime = value; } }
        public string Zivotinje { get { return zivotinje; } set { this.zivotinje = value; } }
        public int Broj_Zivotinja { get { return broj_zivotinja; } set { this.broj_zivotinja = value; } }
        public string Velicina { get { return velicina; } set { velicina = value; } }
        public Zaposlenici Zaposlenici { get { return zaposlenik; } set { zaposlenik = value; } }
        public Zivotinje Zivotinja { get { return zivotinja; } set { zivotinja = value; } }
        public int Serijski_Broj { get { return serijski_broj; } set { this.serijski_broj = value; } }

        public int CompareTo(object obj)
        {

            int rez = this.Serijski_Broj.CompareTo(((Nastamba)obj).serijski_broj);

            return rez;

        }

        public override string ToString() => this.Zivotinje + "\n" + this.Broj_Zivotinja + "\n" + this.Velicina;

    }
}

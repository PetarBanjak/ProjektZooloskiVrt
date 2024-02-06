using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt___Zooloski_vrt.Model
{
    internal class PodatkovniKontekst
    {
        private List<Zaposlenici> _zaposlenici;
        public List<Zaposlenici> zaposlenici { get { return this._zaposlenici;} }

        public PodatkovniKontekst()
        {

            this._zaposlenici = UcitajZaposlenike();

        }

        private string datZaposlenici = "zaposlenici.dat";


        private List<Zaposlenici> UcitajZaposlenike()
        {
            List<Zaposlenici> zaposlenici = new List<Zaposlenici>();

            if (File.Exists(datZaposlenici))
            {
                using (StreamReader sr = new StreamReader(datZaposlenici))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        string[] polja = line.Split('|');

                        Zaposlenici z = new Zaposlenici();
                        z.Ime = polja[0];
                        z.Prezime = polja[1];
                        z.Godine = int.Parse(polja[2]);
                        z.Radni_Polozaj = polja[3];

                        zaposlenici.Add(z);

                    }
                }
            }

            return zaposlenici;

        }

        public void SpremiZaposlenike()
        {

            using (StreamWriter sw = new StreamWriter(datZaposlenici))
            {
                foreach (Zaposlenici z in this.zaposlenici)
                {
                    sw.WriteLine($"{z.Ime}, {z.Prezime}, {z.Godine}, {z.Radni_Polozaj}");
                }

            }

        }

    }
}

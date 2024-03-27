using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt___Zooloski_vrt.Model
{
    internal class podatkovniKontekst
    {
        private List<Zaposlenici> _zaposlenici;
        public List<Zaposlenici> zaposlenici { get { return this._zaposlenici;} }

        public podatkovniKontekst()
        {

            this._zaposlenici = UcitajZaposlenike();

        }

        private string datZaposlenici = @"C:\Users\Ucenik\Downloads\ProjektZooloskiVrt-master\Projekt - Zooloski vrt\zaposlenici.dat";


        public List<Zaposlenici> UcitajZaposlenike()
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

                        Zaposlenici z = new Zaposlenici(polja[0], polja[1], int.Parse(polja[2]), polja[3]);

                        zaposlenici.Add(z);

                    }
                    sr.Close();
                }
            }


            return zaposlenici;

        }

        public void SpremiZaposlenike(Zaposlenici zap)
        {
            this.zaposlenici.Add(zap);
            using (StreamWriter sw = new StreamWriter(datZaposlenici))
            {
                foreach (Zaposlenici z in this.zaposlenici)
                {
                    sw.WriteLine($"{z.Ime}|{z.Prezime}|{z.Godine}|{z.Radni_Polozaj}");
                }

                sw.Close();
            }
            
        }

        public void ObrisiZaposlenika(Zaposlenici zap)
        {
           

            using (StreamWriter sw = new StreamWriter(datZaposlenici))
            {
                foreach (Zaposlenici z in this.zaposlenici)
                {
                    if (z.Ime.Equals(zap.Ime)&& z.Prezime.Equals(zap.Prezime) && z.Godine.Equals(zap.Godine) && z.Radni_Polozaj.Equals(zap.Radni_Polozaj)) continue;
                    else sw.WriteLine($"{z.Ime}|{z.Prezime}|{z.Godine}|{z.Radni_Polozaj}");
                }

                sw.Close();
            }

        }


    }
}

using Projekt___Zooloski_vrt.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt___Zooloski_vrt
{
    public partial class Zaposlenici : Form
    {

        List<Model.Zaposlenici> zaposleniciPrikaz = new List<Model.Zaposlenici>();
        podatkovniKontekst podatkovnikontekst;
        bool searched=false;
        public Zaposlenici()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            new Zaposlenici_adder().Show();
        }

        private void addZap()
        {

            podatkovniKontekst podatkovniKontekst = new podatkovniKontekst();

            listBox2.Items.Clear();
            List<Model.Zaposlenici> zaposleni = podatkovniKontekst.UcitajZaposlenike();


            if (zaposleniciPrikaz.Count > 0 || searched)
            {
                foreach (Model.Zaposlenici zap in zaposleniciPrikaz)
                {
                    listBox2.Items.Add(zap);
                }
            }

            else
            {
                foreach (Model.Zaposlenici zap in zaposleni)
                {
                    listBox2.Items.Add(zap);
                }

            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           // addZap();

        }

        private void Zaposlenici_Load(object sender, EventArgs e)
        {

            addZap();

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searched = true;
            zaposleniciPrikaz.Clear();

            podatkovnikontekst = new podatkovniKontekst();

            List<Model.Zaposlenici> zaposleniciKomplet = podatkovnikontekst.UcitajZaposlenike();

            foreach (Model.Zaposlenici zap in zaposleniciKomplet)
                if (zap.Prezime.Contains(searchBox.Text.ToLower())) zaposleniciPrikaz.Add(zap);

            addZap();




        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {

            zaposleniciPrikaz.Clear();
            podatkovnikontekst = new podatkovniKontekst();
            List<Model.Zaposlenici> zaposleniciFilter = this.podatkovnikontekst.UcitajZaposlenike();

            if (filterBox.SelectedItem.ToString() == "Godine")
            {
                zaposleniciFilter.Sort((z1, z2) => z2.Godine.CompareTo(z1.Godine));
                
                foreach (Model.Zaposlenici zap in zaposleniciFilter)
                {
                    zaposleniciPrikaz.Add(zap);
                }
            }

            if (filterBox.SelectedItem.ToString() == "Ime")
            {

                zaposleniciFilter.Sort((z1, z2) => z2.Ime.CompareTo(z1.Ime));
                zaposleniciFilter.Reverse();
                foreach (Model.Zaposlenici zap in zaposleniciFilter)
                {
                    zaposleniciPrikaz.Add(zap);
                }
            }
            addZap();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            podatkovniKontekst podatkovni = new podatkovniKontekst();

            if (listBox2.SelectedIndex == -1) return;
            else {

                Model.Zaposlenici zap = listBox2.SelectedItem as Model.Zaposlenici;

                podatkovni.ObrisiZaposlenika(zap);

                    }
            zaposleniciPrikaz = podatkovni.UcitajZaposlenike();
            addZap();
        }

      
    }
}

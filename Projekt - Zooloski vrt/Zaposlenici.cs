using Projekt___Zooloski_vrt.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt___Zooloski_vrt
{
    public partial class Zaposlenici : Form
    {

        List<Model.Zaposlenici> zaposleniciPrikaz = new List<Model.Zaposlenici>();
        podatkovniKontekst podatkovnikontekst;
        public Zaposlenici()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            new Zaposlenici_adder().Show();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Zaposlenici_Load(object sender, EventArgs e)
        {

            podatkovniKontekst podatkovniKontekst = new podatkovniKontekst();

            listBox2.Items.Clear();
            List<Model.Zaposlenici> zaposleni = podatkovniKontekst.UcitajZaposlenike();

            foreach (Model.Zaposlenici zap in zaposleni)
            {
                listBox2.Items.Add(zap);

            }

            if(zaposleniciPrikaz.Count > 0)
            {
                foreach(Model.Zaposlenici zap in zaposleniciPrikaz)
                {
                    listBox2.Items.Add(zap);
                }
            }

            else
            {
                foreach(Model.Zaposlenici zap in zaposleni)
                {
                    listBox2.Items.Add(zap);
                }

            }
            
            
            



        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            zaposleniciPrikaz.Clear();

            podatkovnikontekst = new podatkovniKontekst();

            List<Model.Zaposlenici> zaposleniciKomplet = podatkovnikontekst.UcitajZaposlenike();

                foreach (Model.Zaposlenici zap in zaposleniciKomplet)
                    if (zap.Ime.Contains(searchBox.Text.ToLower())) zaposleniciPrikaz.Add(zap);
                    else if (zap.Prezime.Contains(searchBox.Text.ToLower())) zaposleniciPrikaz.Add(zap);
                    else if (zap.Radni_Polozaj.Contains(searchBox.Text.ToLower())) zaposleniciPrikaz.Add(zap);
            






        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {

            zaposleniciPrikaz.Clear();
            List<Model.Zaposlenici> zaposleniciFilter = this.podatkovnikontekst.UcitajZaposlenike();

            rasponFiltera.Visible = true;

            


        }

        
    }
}

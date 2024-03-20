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
    public partial class Zaposlenici_adder : Form
    {

        podatkovniKontekst podatkovniKontekst;
        Model.Zaposlenici zaposlenik;
        public Zaposlenici_adder()
        {
            InitializeComponent();

            this.podatkovniKontekst = new podatkovniKontekst();
        }

        private void zivotinja_add_Click(object sender, EventArgs e)
        {

            this.zaposlenik = new Model.Zaposlenici(this.ime.Text, this.prezime.Text, int.Parse(this.godine.Text), this.radni_polozaj.Text);
            this.podatkovniKontekst.SpremiZaposlenike(this.zaposlenik);

            Close();

        }
    }
}

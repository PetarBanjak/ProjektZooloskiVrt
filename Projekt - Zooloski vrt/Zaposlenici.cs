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

        List<Zaposlenici> zaposleniciPrikaz = new List<Zaposlenici>();
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
                foreach(Zaposlenici zap in zaposleniciPrikaz)
                {
                    listBox2.Items.Add(zap);
                }
            }
            
            
            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            

        }
    }
}

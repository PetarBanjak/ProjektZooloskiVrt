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
    public partial class nastamba : Form
    {
        public nastamba()
        {
            InitializeComponent();
        }

        private void zaposlenici_Click(object sender, EventArgs e)
        {

            new Zaposlenici().Show();

        }

        private void zivotinje_Click(object sender, EventArgs e)
        {

            new Zivotinje().Show();

        }

        private void exit_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);

        }

        private void twoListBox_Click(object sender, EventArgs e)
        {

            new Zaposlenici_i_zivotinje().Show();

        }

        private void edit3_Click(object sender, EventArgs e)
        {
            new Zaposlenici_i_zivotinje().Show();
        }
    }
}

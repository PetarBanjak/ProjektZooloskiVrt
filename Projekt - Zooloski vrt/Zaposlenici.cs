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
        public Zaposlenici()
        {
            InitializeComponent();
        }


        private void add_Click(object sender, EventArgs e)
        {
            new Edit().Show();
        }

        private void edit_Click(object sender, EventArgs e)
        {

            new Edit().Show();

        }
    }
}

﻿using Projekt___Zooloski_vrt.Model;
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
    public partial class Zivotinje : Form
    {
        public Zivotinje()
        {
            InitializeComponent();
        }

        private void add3_Click(object sender, EventArgs e)
        {
            new Zivotinje_adder().Show();
        }
    }
    }

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baza_programului
{
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
        }

        public static int cod;

        private void Koch_Click(object sender, EventArgs e)
        {
            Panza f2 = new Panza();
            cod = 1;
            f2.ShowDialog();
        }
    }
}
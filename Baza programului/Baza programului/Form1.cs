using System;
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

        Panza f2 = new Panza();

        public static int cod;
        public string text;
        public static int nivel;

        private void Koch_Click(object sender, EventArgs e)
        {
            
            cod = 1;
            text = nivelul.Text;
            nivel = Int32.Parse(nivelul.Text);
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e ) // Sierpinski
        {
           
            cod = 2;
            text = nivelul.Text;
            nivel = Int32.Parse(nivelul.Text);
            f2.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cod = 3;
            text = nivelul.Text;
            nivel = Int32.Parse(nivelul.Text);
            f2.ShowDialog();
        }
    }
}

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
    public partial class Panza : Form
    {
        public Panza()
        {
            InitializeComponent();
        }

        double r = Math.Sqrt(3) / 6;

        public void fulg(int n, int xa, int ya, int xb, int yb, Graphics gobject, Pen pen)
        {
            int xc, yc, xm, ym, xd, yd;
            if (n > 1)
            {

                xm = Convert.ToInt32((xa + xb) / 2 + r * (ya - yb));
                ym = Convert.ToInt32((ya + yb) / 2 + r * (xb - xa));
                xc = (2 * xa + xb) / 3;
                yc = (2 * ya + yb) / 3;
                xd = (xa + 2 * xb) / 3;
                yd = (ya + 2 * yb) / 3;
                fulg(n - 1, xa, ya, xc, yc, gobject, pen);
                fulg(n - 1, xc, yc, xm, ym, gobject, pen);
                fulg(n - 1, xm, ym, xd, yd, gobject, pen);
                fulg(n - 1, xd, yd, xb, yb, gobject, pen);
            }
            else
                gobject.DrawLine(pen, xa, ya, xb, yb);

        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Meniu obiect = new Meniu();

            Graphics gobject = canvas.CreateGraphics();
            Pen pen = new Pen(Color.Gray, 4);
            
            if (Meniu.cod==1)
            {
                fulg(13, 300, 10, 100, 356, gobject, pen);
                fulg(13, 100, 356, 500, 356, gobject, pen);
                fulg(13, 500, 356, 300, 10, gobject, pen);




            }
        }
    }
}

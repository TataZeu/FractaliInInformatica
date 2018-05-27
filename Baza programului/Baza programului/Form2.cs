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

        // Draw a triangle between the points.
        private void DrawTriangle(Graphics gr, int level,
            PointF top_point, PointF left_point, PointF right_point,Pen pen)
        {
            // See if we should stop.
            if (level == 0)
            {
                // Fill the triangle.
                PointF[] points =
                {
            top_point, right_point, left_point
        };
                gr.FillPolygon(Brushes.Blue, points);
            }
            else
            {
                // Find the edge midpoints.
                PointF left_mid = new PointF(
                    (top_point.X + left_point.X) / 2f,
                    (top_point.Y + left_point.Y) / 2f);
                PointF right_mid = new PointF(
                    (top_point.X + right_point.X) / 2f,
                    (top_point.Y + right_point.Y) / 2f);
                PointF bottom_mid = new PointF(
                    (left_point.X + right_point.X) / 2f,
                    (left_point.Y + right_point.Y) / 2f);

                // Recursively draw smaller triangles.
                DrawTriangle(gr, level - 1,
                    top_point, left_mid, right_mid,pen);
                DrawTriangle(gr, level - 1,
                    left_mid, left_point, bottom_mid,pen);
                DrawTriangle(gr, level - 1,
                    right_mid, bottom_mid, right_point,pen);
            }
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
            else
             if(Meniu.cod==2)
            {
                PointF x = new PointF(300, 10);
                PointF y = new PointF(100,400);
                PointF z = new PointF(500, 400);
                DrawTriangle(gobject, 5, x, y, z,pen);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Baza_programului
{
    class MamaFractal 
    {

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

        
        public void DrawTriangle(Graphics gr, int level,PointF top_point, PointF left_point, PointF right_point, Pen pen)
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
                    top_point, left_mid, right_mid, pen);
                DrawTriangle(gr, level - 1,
                    left_mid, left_point, bottom_mid, pen);
                DrawTriangle(gr, level - 1,
                    right_mid, bottom_mid, right_point, pen);
            }
        }

        public void Patrat(int x,int y,int R,int level, Graphics gobject,Brush brush1,Brush brush2,int culoare)
        {
            

            if (level>0)
            {
                Patrat(x - R/2, y + R/2, R / 2,level-1,gobject,brush1,brush2,culoare+1);
                Patrat(x - R/2, y - R/2, R / 2,level-1,gobject,brush1,brush2,culoare+1);
                Patrat(x + R/2, y - R/2, R / 2,level-1,gobject,brush1,brush2,culoare+1);
                Patrat(x + R/2, y + R/2, R / 2,level-1,gobject,brush1,brush2,culoare+1); 



                if(culoare%2==0)
                 gobject.FillRectangle(brush1, x - R / 2, y - R / 2, R, R);
               else
                  gobject.FillRectangle(brush2, x - R / 2, y - R / 2, R, R); 

               
              
            }

        } 

        public void copac(float x1, float y1,float x2,float y2)
        {
            
            
        }

    }
}

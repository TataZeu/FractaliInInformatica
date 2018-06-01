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
        int culoare = 1;
      

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Meniu obiect = new Meniu();
            MamaFractal mamaobj = new MamaFractal();

            Graphics gobject = canvas.CreateGraphics();
            Pen pen = new Pen(Color.Red, 4);
            SolidBrush brush1 = new SolidBrush(Color.Red);
            SolidBrush brush2 = new SolidBrush(Color.Green);


            

            if (Meniu.cod==1)
            {
                mamaobj.fulg(Meniu.nivel, 300, 10, 100, 356, gobject, pen); 
                mamaobj.fulg(Meniu.nivel, 100, 356, 500, 356, gobject, pen); 
                mamaobj.fulg(Meniu.nivel, 500, 356, 300, 10, gobject, pen);

            } 
            else
             if(Meniu.cod==2)
            {
                PointF x = new PointF(300, 10);
                PointF y = new PointF(100,400);
                PointF z = new PointF(500, 400);
                mamaobj.DrawTriangle(gobject,Meniu.nivel, x, y, z,pen);
               
            }
            else 
                if(Meniu.cod==3)
            {
                mamaobj.Patrat(450, 300, 200, Meniu.nivel, gobject, brush1,brush2,culoare);
            }
        }
    }
}

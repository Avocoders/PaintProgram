using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.Figure
{
    public class Poligon : IFigur
    {
        Point point;
        List <Point> poligon = new List<Point>();
        int n = 0;

        public List<Point> Drow(int x1, int y1, int x2, int y2, int nAngle)
        {
            int n_ = nAngle;
            int r = Convert.ToInt32(Math.Sqrt(Math.Abs((x2 - x1) * (x2 - x1)) + Math.Abs((y2 - y1) * (y2 - y1))));
            //int x = x1 + Convert.ToInt32(r * Math.Cos(0 * Math.PI / 180));
            //int y = y1 + Convert.ToInt32(r * Math.Sin(0 * Math.PI / 180)); 
            int aPol = 180*(n_ - 2)/n_;
            int bPol = 180 - aPol;

            for (int i = 0; i<360; i+=bPol)
            {
                int xNext = x1 + Convert.ToInt32(r * Math.Cos(i * Math.PI / 180));
                int yNext = y1 + Convert.ToInt32(r * Math.Sin(i * Math.PI / 180));

                //q.DrawLine(xNext, yNext, x, y);
                //x = xNext;
                //y = yNext;

                point = new Point(xNext, yNext);
                poligon.Add(point);
                n++;
            }
            return poligon;
        }
    }
}

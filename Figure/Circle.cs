using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp7.Figure
{
    public class Сircle : IFigur
    {
        Point point;
        

        int n=0;
        List<Point> points;
        public override List<Point> Drow(int x1, int y1, int x2, int y2, int nAngle)
        {
            points = new List<Point>();
            double r =(double) Math.Sqrt(Math.Abs((x2 - x1)* (x2 - x1)) + Math.Abs((y2 - y1)* (y2 - y1)));
            centr = new Point(x1, y1);


            for (double i = 0; i < 360; i= i+2)
            {
                int xNext = x1 + Convert.ToInt32(r * Math.Cos(i * Math.PI / 180));
                int yNext = y1 + Convert.ToInt32(r * Math.Sin(i * Math.PI / 180));
                point = new Point(xNext, yNext);
                points.Add(point);
                n++;
            }
            return points;
        }

        public override void ChangeFigurePosition(int dX, int dY)
        {
            for (int i = 0; i < points.Count; i++)
            {
                points[i] = new Point(points[i].X + dX, points[i].Y + dY);
            }
            centr = new Point(centr.X + dX, centr.Y + dY);
        }

        public override void ZoomingFigure(int dX, int dY)
        {
            

        }

        public override bool CheckForMatches(int x1, int y1, int x2, int y2, int c, int [] ExPoints) 
        {
            bool point = true;
            Сircle New = new Сircle();
            List<Point> NewPointCircle = New.Drow(x1, y1, x2, y2, 0);
            for (int i = 0; i < ExPoints.Length; i += 2)
            {
                Point a = new Point(ExPoints[i], ExPoints[i + 1]);
                if (!NewPointCircle.Contains(a))
                {
                    point = false;
                }
            }
            return point;
        }

       
    }
}

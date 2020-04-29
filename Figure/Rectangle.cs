using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.Figure
{
    
    public class Rectangl : IFigur
    {

        public override List<Point> Drow(int x1, int y1, int x2, int y2, int nAngle)
        {
            int cx, cy;

            cx = (x2 - x1) / 2;
            cy = (y2 - y1) / 2;

            centr = new Point(cx, cy);

            points = new List<Point>();
            points.Add(new Point(x1, y1));
            points.Add(new Point(x2, y1));
            points.Add(new Point(x2, y2));  
            points.Add(new Point(x1, y2));
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

        public override bool CheckForMatches(int x1, int y1, int x2, int y2, int c, int[] ExPoints)
        {
            bool point = true;
            Rectangl New = new Rectangl();
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
        //public override Point CenterFigure11(List<Point> points)
        //{
        //    Point centr;
        //    Point point1 = points[0];
        //    Point point2 = points[2];
        //    int cx, cy;

        //    cx = (point2.X - point1.X) / 2;
        //    cy = (point2.Y - point1.Y) / 2;

        //    centr = new Point(cx, cy);
        //    return centr;
        //}
    }
}

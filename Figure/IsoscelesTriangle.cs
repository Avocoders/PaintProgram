using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.Figure
{
    public class IsoscelesTriangle : IFigur
    {
        public override List<Point> Drow(int x1, int y1, int x2, int y2, int nAngle)
        {
            points = new List<Point>();
            int y3 = 0;
            int x3 = 0;
            int dx = Math.Abs(x2 - x1);
            
            

            if (x2 > x1)
            {
                x3 = x1 + 2 * dx;
                y3 = y1;
            }
            else
            {
                x3 = x1 - 2 * dx;
                y3 = y1;
            }

            int a = Convert.ToInt32(Math.Sqrt(Math.Abs((x2 - x1) * (x2 - x1)) + Math.Abs((y2 - y1) * (y2 - y1))));
            int b = Convert.ToInt32(Math.Sqrt(Math.Abs((x3 - x1) * (x3 - x1)) + Math.Abs((y3 - y1) * (y3 - y1))));
            int r = Convert.ToInt32(b / 2 * Math.Sqrt((2 * a - b) / (2 * a + b)));
            int cx, cy;
            cx = Convert.ToInt32((x3 - x1) / 2);

            if (y2 < y1)
            {
                cy = Convert.ToInt32((y2 - y1) + r);
            }
            else
            {
                cy = Convert.ToInt32((y2 - y1) - r);
            }

            centr = new Point(cx, cy);

            if (y3 > 0)
            {
                points.Add(new Point(x1, y1));
                points.Add(new Point(x2, y2));
                points.Add(new Point(x3, y3));
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

        public override bool CheckForMatches(int x1, int y1, int x2, int y2,int c, int[] ExPoints)
        {
            bool point = true;
            IsoscelesTriangle New = new IsoscelesTriangle();
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
        //    Point point2 = points[1];
        //    Point point3 = points[2];
        //    int cx, cy;

        //    int a = Convert.ToInt32(Math.Sqrt(Math.Abs((point2.X - point1.X) * (point2.X - point1.X)) + Math.Abs((point2.Y - point1.Y) * (point2.Y - point1.Y))));
        //    int b = Convert.ToInt32(Math.Sqrt(Math.Abs((point3.X - point1.X) * (point3.X - point1.X)) + Math.Abs((point3.Y - point1.Y) * (point3.Y - point1.Y))));
        //    int r = Convert.ToInt32(b / 2 * Math.Sqrt((2 * a - b) / (2 * a + b)));

        //    cx = Convert.ToInt32((point3.X - point1.X) / 2);

        //    if (point2.Y < point1.Y)
        //    {
        //        cy = Convert.ToInt32((point2.X - point1.X) + r);
        //    }
        //    else 
        //    {
        //        cy = Convert.ToInt32((point2.X - point1.X) - r);
        //    }
            
        //    centr = new Point(cx, cy);
        //    return centr;
        //}
    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp7.Figure
{
    public class Square : IFigur
    {
        List<Point> points;
        public override List<Point> Drow(int x1, int y1, int x2, int y2, int nAngle)
        {
            points = new List<Point>();
            int cx, cy;

            int dx = Math.Abs(x2 - x1);

            if (x2 > x1 && y2 > y1)
            {
                x2 = x1 + dx;
                y2 = y1 + dx;
                cx = x1 + dx / 2;
                cy = y1 + dx / 2;

            }
            else if (x2 > x1 && y2 < y1)
            {
                x2 = x1 + dx;
                y2 = y1 - dx;
                cx = x1 + dx / 2;
                cy = y1 - dx / 2;
            }
            else if (x2 < x1 && y2 > y1)
            {
                x2 = x1 - dx;
                y2 = y1 + dx;
                cx = x1 - dx / 2;
                cy = y1 + dx / 2;
            }
            else
            {
                x2 = x1 - dx;
                y2 = y1 - dx;
                cx = x1 - dx / 2;
                cy = y1 - dx / 2;
            }
            centr = new Point(cx, cy);

            points.Add(new Point(x1, y1));
            points.Add(new Point(x2, y1));
            points.Add(new Point(x2, y2));
            points.Add(new Point(x1, y2));

            return points;
        }

        public override bool CheckForMatches(int x1, int y1, int x2, int y2,int c, int[] ExPoints)
        {
            bool point = true;
            Square New = new Square();
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

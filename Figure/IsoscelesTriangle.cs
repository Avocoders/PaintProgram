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
        List<Point> points;
        public override List<Point> Drow(int x1, int y1, int x2, int y2, int nAngle)
        {
            points = new List<Point>();
            int cx, cy;
            int y3 = 0;
            int x3 = 0;
            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);

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
          
            cx =x1+ Convert.ToInt32((x3 - x1) / 2);

            if (y2 < y1)
            {
                cy = y1 - dy/3;
            }
            else
            {
                cy = y1 + dy / 3;
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
    }
}

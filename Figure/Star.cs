using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.Figure
{
    public class Star:IFigur
    {
        List<Point> points;
        public override List<Point> Drow(int x1, int y1, int x2, int y2, int nAngle)
        {
            points = new List<Point>();
            int n_ = nAngle;
            int r = Convert.ToInt32(Math.Sqrt(Math.Abs((x2 - x1) * (x2 - x1)) + Math.Abs((y2 - y1) * (y2 - y1)))); 
            int aPol = 180 * (n_ - 2) / n_;
            int bPol = 180 - aPol;
            centr = new Point(x1, y1);
            for (int i = 0; i < 360; i += bPol)
            {
                int xFirst = x1 + Convert.ToInt32(r * Math.Cos(i * Math.PI / 180));
                int yFirst = y1 + Convert.ToInt32(r * Math.Sin(i * Math.PI / 180));
                int xNext = x1 + Convert.ToInt32(r/2 * Math.Cos((i+bPol/2) * Math.PI / 180));
                int yNext = y1 + Convert.ToInt32(r/2 * Math.Sin((i + bPol / 2) * Math.PI / 180));

                points.Add(new Point(xFirst, yFirst));
                points.Add(new Point(xNext, yNext));                
            }
            return points;
        }

        public override bool CheckForMatches(int x1, int y1, int x2, int y2, int c, int[] ExPoints)
        {
            bool point = true;
            Star New = new Star();
            List<Point> NewPointCircle = New.Drow(x1, y1, x2, y2, c);
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

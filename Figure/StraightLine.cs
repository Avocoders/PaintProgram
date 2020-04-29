using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.Figure
{
    class StraightLine : IFigur
    {
        List<Point> points;
        public override List<Point> Drow(int x1, int y1, int x2, int y2, int nAngle)
        {
            points = new List<Point>();
            //q.DrawLine(x1, y1, x2, y2);
            points.Add(new Point(x1, y1));
            points.Add(new Point(x2, y2));

            return points;
        }

        public override void ChangeFigurePosition(int dX, int dY)
        {
            for (int i = 0; i < points.Count; i++)
            {
                points[i] = new Point(points[i].X + dX, points[i].Y + dY);
            }
        }

        public override bool CheckForMatches(int x1, int y1, int x2, int y2,int c, int[] ExPoints)
        {
            bool point = true;
            StraightLine New = new StraightLine();
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

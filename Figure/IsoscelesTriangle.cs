﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.Figure
{
    public class IsoscelesTriangle : IFigur
    {
        List <Point> points;

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
            if (y3 > 0)
            {
                points.Add(new Point(x1, y1));
                points.Add(new Point(x2, y2));
                points.Add(new Point(x3, y3));

                //q.DrawLine(x2, y2, x1, y1);
                //q.DrawLine(x3, y3, x2, y2);
                //q.DrawLine(x1, y1, x3, y3);
            }
            return points;
        }

        public override void ChangeFigurePosition(int dX, int dY)
        {
            for (int i = 0; i < points.Count; i++)
            {
                points[i] = new Point(points[i].X + dX, points[i].Y + dY);
            }
        }
    }
}

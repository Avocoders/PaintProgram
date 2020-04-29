﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class UnPoligon : Drower
    {
        //List<Point> points ;
        int n = 0;
        public UnPoligon(Brush brush, IFigur figur, IFill fill) : base(brush, figur, fill)
        {
        }

        public override void Draw(Point point, Point point2, int nAngle, CreatedFigure cf)
        {
            //if (points == null)
            if (points == null)
            {
                points = new List<Point>();
                points.Add(point);
                brush.SetDot(point.X, point.Y);
            }
            else
            {
                brush.DrawLine(points[n].X, points[n].Y, point2.X, point2.Y);
                points.Add(point);
                n++;
            }
        }

        public override void Draw(CreatedFigure cf)
        {
            for (int i = 0; i < points.Count - 1; i++)
            {
                brush.DrawLine(points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            }
        }
    }
}

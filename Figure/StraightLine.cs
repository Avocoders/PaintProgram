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
        List <Point> straightLine ;

        public List<Point> Drow(int x1, int y1, int x2, int y2, int nAngle)
        {
            straightLine = new List<Point>();
            //q.DrawLine(x1, y1, x2, y2);
            straightLine.Add(new Point(x1, y1));
            straightLine.Add(new Point(x2, y2));

            return straightLine;
        }
    }
}

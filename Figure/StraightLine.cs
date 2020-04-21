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
        Brush q;
        List <Point> square;
        public StraightLine(Brush bruch)
        {
            q = bruch;
        }

        public void Drow(int x1, int y1, int x2, int y2, int nAngle)
        {
            //q.DrawLine(x1, y1, x2, y2);
            square.Add(new Point(x1, y1));
            square.Add(new Point(x2, y2));
        }
    }
}

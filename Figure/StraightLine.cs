using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.Figure
{
    class StraightLine : IFigur
    {
        Brush q;

        public StraightLine(Brush bruch)
        {
            q = bruch;
        }

        public void Drow(int x1, int y1, int x2, int y2)
        {
            q.DrawLine(x1, y1, x2, y2);
        }
    }
}

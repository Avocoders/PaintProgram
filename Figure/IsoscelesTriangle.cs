using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.Figure
{
    public class IsoscelesTriangle : IFigur
    {
        Brush q;

        public IsoscelesTriangle(Brush bruch)
        {
            q = bruch;
        }
        public void Drow(int x1, int y1, int x2, int y2)
        {
            int y3 = 0;
            int x3 = 0;
            int dx = Math.Abs(x2 - x1);
            int dy = dx/2;

            if (x2 > x1)
            {
                y3 = y1 - dy;
                x3 = x1 + dx / 2;
            }
            else 
            {
                y3 = y1 - dy;
                x3 = x1 - dx / 2;
            }
            if (y3 > 0)
            {
                q.DrawLine(x2, y1, x1, y1);
                q.DrawLine(x3, y3, x2, y1);
                q.DrawLine(x1, y1, x3, y3);
            }
        }
    }
}

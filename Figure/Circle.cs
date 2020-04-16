using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.Figure
{
    public class Сircle : IFigur
    {
        Brush q;
        public Сircle(Brush bruch)
        {
            q = bruch;
        }
        public void Drow(int x1, int y1, int x2, int y2)
        {
            int r = Convert.ToInt32(Math.Sqrt(Math.Abs((x2 - x1)* (x2 - x1)) + Math.Abs((y2 - y1)* (y2 - y1))));
            int x = x1 + Convert.ToInt32(r * Math.Cos(0 * Math.PI / 180));
            int y = y1 + Convert.ToInt32(r * Math.Sin(0 * Math.PI / 180)); ;

            for (int i = 1; i < 360; i++)
            {
                int xNext = x1 + Convert.ToInt32(r * Math.Cos(i * Math.PI / 180));
                int yNext = y1 + Convert.ToInt32(r * Math.Sin(i * Math.PI / 180));
                q.DrawLine(xNext, yNext, x, y);
                x = xNext;
                y = yNext;
            }
        }

    }
}

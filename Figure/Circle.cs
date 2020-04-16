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
            int r = Convert.ToInt32(Math.Sqrt(Math.Abs((x2 * x2 - x1 * x1)) + Math.Abs((y2 * y2 - y1 * y1))));
            int rad = r;
            int xNext = 0;
            int yNext = 0;

            for (int i = 0; i < 361; i++)
            {
                xNext = x1 + Convert.ToInt32(rad * Math.Cos(i * 3.14159 / 180));
                yNext = y1 + Convert.ToInt32(rad * Math.Sin(i * 3.14159 / 180));
                q.DrawLine(xNext, yNext, x2, y2);
                x2 = xNext;
                y2 = yNext;
            }
        }

    }
}

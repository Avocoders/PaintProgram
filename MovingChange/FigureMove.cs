using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.MovingChange
{
    public class FigureMove : IMovingChange
    {
        SingleBitmap move = SingleBitmap.Create();

        public void ChangeFigure(Point p)
        {
            throw new NotImplementedException();
        }

        public void FindPoint(Point p)
        {
            foreach (Figure f in figures)
            {
                if (f.points.Contains(p))
                    return f;
            }

            return null;
        }
    }
}

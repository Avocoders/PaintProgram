using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7.MovingChange
{
    public class FigureMove : IMovingChange
    {
        SingleBitmap move = SingleBitmap.Create();
        Point keepP;
        IFigur figur;
        public void ChangeFigure(Point p)
        {
            int dx, dy;
            dx = p.X - keepP.X;
            dy = p.Y - keepP.Y;
            figur.ChangeFigurePosition(dx,dy);
            keepP = p;
        }

        public int FindMainPoint(Point p)
        {
            throw new NotImplementedException();
        }

        public IFigur FindPoint(Point p)
        {
            foreach (IFigur f in move.listOfFigure)
            {
                foreach (Point t in f.points)
                {
                    if (Math.Abs(t.X - p.X) <= 10 && Math.Abs(t.Y - p.Y) <= 10)
                    {
                        keepP = p;
                        figur = f;
                        return f;
                    }
                }
            }
            return null;
        }

        public void PointChangeMode(PictureBox pictureBox)
        {
            throw new NotImplementedException();
        }
    }
}

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
        CreatedFigure cf;
                
        public void ChangeFigure(Point p)
        {
            int dx, dy;
            dx = p.X - keepP.X;
            dy = p.Y - keepP.Y;
            for (int i = 0; i < cf.poin.Count; i++)
            {
                cf.poin[i] = new Point(cf.poin[i].X + dx, cf.poin[i].Y + dy);
            }
            cf.centr = new Point(cf.centr.X + dx, cf.centr.Y + dy);
            keepP = p;
        }

        public int FindMainPoint(Point p)
        {
            throw new NotImplementedException();
        }

        public CreatedFigure FindPoint(Point p)
        {
            for (int i = -10; i <= 10; i++)
            {
                for (int j = -10; j <= 10; j++)
                {
                    Point g = new Point(p.X + i, p.Y + j);
                    foreach (CreatedFigure f in move.listOfFigure)
                    {
                        if (f.poin.Contains(g))
                        {
                            cf = f;
                            keepP = p;
                            return cf;
                        }
                    }
                }
            }
            return null;
        }

        public Point FirstPoint(Point p)
        {
            throw new NotImplementedException();
        }

        public void PointChangeMode(PictureBox pictureBox)
        {
            throw new NotImplementedException();
        }
    }
}

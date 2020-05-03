using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7.MovingChange
{
    class GranMove : IMovingChange
    {
        SingleBitmap move = SingleBitmap.Create();
        CreatedFigure q;
        Point keepP;
        int index;

        public void ChangeFigure(Point p)
        {
            int dx, dy;
            dx = p.X - keepP.X;
            dy = p.Y - keepP.Y;
            if (!(index + 1 >= q.poin.Count))
            {
                for (int i = index; i <= index + 1; i++)
                {
                    q.poin[i] = new Point(q.poin[i].X + dx, q.poin[i].Y + dy);
                }
            }
            else
            {
                q.poin[index] = new Point(q.poin[index].X + dx, q.poin[index].Y + dy);
                q.poin[0] = new Point(q.poin[0].X + dx, q.poin[0].Y + dy);
            }            
            q.centr = new Point(q.centr.X + dx, q.centr.Y + dy);
            keepP = p;
        }

        public int FindMainPoint(Point p)
        {
            if (q.poin.Contains(p))
            {
                index = q.poin.IndexOf(p);
                return q.poin.IndexOf(p);
            }
            return -1;
        }

        public CreatedFigure FindPoint(Point p)
        {
            foreach (CreatedFigure f in move.listOfFigure)
            {
                if (f.poin.Contains(p))
                {
                    keepP = p;
                    q = f;
                    return f;
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

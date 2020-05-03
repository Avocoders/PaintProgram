using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7.Figure;

namespace WindowsFormsApp7.MovingChange
{
    public class TigersTurn : IMovingChange
    {
        SingleBitmap move = SingleBitmap.Create();
        Point keepP;
        CreatedFigure cf;
        Point x;

        public void ChangeFigure(Point p)
        {
            
            x = cf.centr;

            int dx = p.X - x.X;
            int dy = p.Y - x.Y;
            int j = 0;
                
            if (dx > 0 || dy > 0)
                {
                    j+=30;
                }
                
            else if (dx < 0 || dy < 0)
                {
                        j-=30;
                }

            int da = j;            
            for (int i = 0; i < cf.poin.Count; i++)
            {                
                int newPointX = Convert.ToInt32((double)x.X + ((double)cf.poin[i].X - (double)x.X) * Math.Cos((double)da * Math.PI / 180) - ((double)cf.poin[i].Y - x.Y) * Math.Sin((double)da * Math.PI / 180));
                int newPointY = Convert.ToInt32((double)x.Y + ((double)cf.poin[i].Y - (double)x.Y) * Math.Cos((double)da * Math.PI / 180) + ((double)cf.poin[i].X - x.X) * Math.Sin((double)da * Math.PI / 180));
                cf.poin[i] = new Point(newPointX, newPointY);
            }
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
                            return f;
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

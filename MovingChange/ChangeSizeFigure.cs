using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7.Figure;

namespace WindowsFormsApp7.MovingChange
{
    public class ChangeSizeFigure : IMovingChange
    {
        SingleBitmap move = SingleBitmap.Create();
        Point keepP;
        CreatedFigure cf;
        Point x;
        double a;
        double b;
        public void ChangeFigure(Point p)
        {
            x = cf.centr;
            int dx, dy;

            dx = Math.Abs(p.X - keepP.X);
            dy = Math.Abs(p.Y - keepP.Y);
            
            double rCentr = (double)Math.Sqrt(Math.Abs((p.X - x.X) * (p.X - x.X)) + Math.Abs((p.Y - x.Y) * (p.Y - x.Y)));
            double rKeepP = (double)Math.Sqrt(Math.Abs((keepP.X - x.X) * (keepP.X - x.X)) + Math.Abs((keepP.Y - x.Y) * (keepP.Y - x.Y)));
            double r = (double)Math.Sqrt(Math.Abs(dx * dx) + Math.Abs(dy * dy))/*rCentr-rKeepP*/;


            if (rCentr > rKeepP)
            {
                for (int i = 0; i < cf.poin.Count; i++)
                {
                    double dxPoint, dyPoint, rPoint;
                    dxPoint = (double)Math.Abs(cf.poin[i].X - x.X);
                    dyPoint = (double)Math.Abs(cf.poin[i].Y - x.Y);
                    rPoint = (double)Math.Sqrt((dxPoint * dxPoint) + (dyPoint * dyPoint));
                    if (rPoint != 0)
                    {
                        a = (double)(cf.poin[i].X - x.X) / rPoint;
                        b = (double)(cf.poin[i].Y - x.Y) / rPoint;
                    }
                    cf.poin[i] = new Point(Convert.ToInt32(x.X + (rPoint + r) * a), Convert.ToInt32(x.Y + (rPoint + r) * b));
                }
            }
            else if(rCentr < rKeepP) 
            {
                for (int i = 0; i < cf.poin.Count; i++)
                {
                    double dxPoint, dyPoint, rPoint;
                    dxPoint = (double)Math.Abs(cf.poin[i].X - x.X);
                    dyPoint = (double)Math.Abs(cf.poin[i].Y - x.Y);
                    rPoint = (double)Math.Sqrt((dxPoint * dxPoint) + (dyPoint * dyPoint));
                    if (rPoint != 0)
                    {
                        a = (double)(cf.poin[i].X - x.X) / rPoint;
                         b = (double)(cf.poin[i].Y - x.Y) / rPoint;
                    }
                    
                    cf.poin[i] = new Point(Convert.ToInt32(x.X + (rPoint - r) * a), Convert.ToInt32(x.Y + (rPoint - r) * b));
                }
            }
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

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
        
        public void ChangeFigure(Point p)
        {
            if (cf.figur is Сircle)
            {
                cf.figur.Drow(cf.start.X, cf.start.Y, p.X, p.Y,1);
            }
            else
            {                                               
                double xmax = cf.poin[0].X, xmin = cf.poin[0].X, ymax = cf.poin[0].Y, ymin = cf.poin[0].Y;
                for (int i = 0; i < cf.poin.Count; i++)
                {
                    if (xmax < cf.poin[i].X)
                    { xmax = cf.poin[i].X; }
                    if (xmin > cf.poin[i].X)
                    { xmin = cf.poin[i].X; }
                    if (ymax < cf.poin[i].Y)
                    { ymax = cf.poin[i].Y; }
                    if (ymin > cf.poin[i].Y)
                    { ymin = cf.poin[i].Y; }
                }                
                double keepPW = keepP.X - xmin;
                double keepPH = keepP.Y - ymin;
                double delW = p.X - xmin - keepPW;
                double delH = p.Y - ymin - keepPH;
                for (int i = 0; i < cf.poin.Count; i++)
                {
                    int newX = Convert.ToInt32((cf.poin[i].X - xmin) / keepPW * delW + cf.poin[i].X);
                    int newY = Convert.ToInt32((cf.poin[i].Y - ymin) / keepPH * delH + cf.poin[i].Y);
                    cf.poin[i] = new Point(newX, newY);
                }
                keepP = p;
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

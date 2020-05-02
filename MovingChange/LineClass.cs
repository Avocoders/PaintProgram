using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7.MovingChange
{
    class LineClass : IMovingChange
    {
        SingleBitmap move = SingleBitmap.Create();
        Point keepP;        
        CreatedFigure cf;
        public List<Point> pointList = new List<Point>();

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
            
            foreach (CreatedFigure f in move.listOfFigure)
            {
                for (int l = 0; l < f.poin.Count - 1; l++)
                {     
                    for (int g = f.poin[l].X; g < f.poin[l+1].X; g++)
                    {
                        for (int m = f.poin[l].Y; m < f.poin[l+1].Y; m++)
                        {
                            Point a = new Point(g, m);
                            if(f.poin.Contains(a))
                            {
                                cf = f;
                                return f;
                            }
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

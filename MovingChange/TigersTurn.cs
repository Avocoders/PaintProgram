using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            double r = (double)Math.Sqrt((keepP.X - x.X) * (keepP.X - x.X) + (keepP.Y - x.Y) * (keepP.Y - x.Y));
            double rP = (double)Math.Sqrt((p.X - x.X) * (p.X - x.X) + (p.Y - x.Y) * (p.Y - x.Y));
            double aP = (double)Math.Abs(Math.Acos((p.X - x.X) / rP) * 180 / Math.PI-90);
            double aKeepP = (double)Math.Abs(Math.Acos((keepP.X - x.X) / r) * 180 / Math.PI-90); 
            double da = (double)Math.Abs(aP - aKeepP);

            for (int i = 0; i < cf.poin.Count; i++)
            {

                if (cf.poin[i].X > x.X && cf.poin[i].Y < x.Y)
                {
                    int newPointX = Convert.ToInt32(x.X + (cf.poin[i].X - x.X) * Math.Cos(da * Math.PI / 180) - (cf.poin[i].Y - x.Y) * Math.Sin(da * Math.PI / 180)); 
                    int newPointY = Convert.ToInt32(x.Y + (cf.poin[i].Y - x.Y) * Math.Cos(da * Math.PI / 180) + (cf.poin[i].X - x.X) * Math.Sin(da * Math.PI / 180)); 
                    cf.poin[i] = new Point(newPointX, newPointY);
                }
                else if (cf.poin[i].X > x.X && cf.poin[i].Y > x.Y)
                {
                    int newPointX = Convert.ToInt32(x.X + (cf.poin[i].X - x.X) * Math.Cos(da * Math.PI / 180) - (cf.poin[i].Y - x.Y) * Math.Sin(da * Math.PI / 180)); 
                    int newPointY = Convert.ToInt32(x.Y + (cf.poin[i].Y - x.Y) * Math.Cos(da * Math.PI / 180) + (cf.poin[i].X - x.X) * Math.Sin(da * Math.PI / 180)); 
                    cf.poin[i] = new Point(newPointX, newPointY);
                }
                else if (cf.poin[i].X < x.X && cf.poin[i].Y > x.Y)
                {
                    int newPointX = Convert.ToInt32(x.X + (cf.poin[i].X - x.X) * Math.Cos(da * Math.PI / 180) - (cf.poin[i].Y - x.Y) * Math.Sin(da * Math.PI / 180)); 
                    int newPointY = Convert.ToInt32(x.Y + (cf.poin[i].Y - x.Y) * Math.Cos(da * Math.PI / 180) + (cf.poin[i].X - x.X) * Math.Sin(da * Math.PI / 180)); 
                    cf.poin[i] = new Point(newPointX, newPointY);
                }
                else if (cf.poin[i].X < x.X && cf.poin[i].Y < x.Y)
                {
                    int newPointX = Convert.ToInt32(x.X+ (cf.poin[i].X-x.X) * Math.Cos(da * Math.PI / 180)- (cf.poin[i].Y - x.Y) * Math.Sin(da * Math.PI / 180)); 
                    int newPointY = Convert.ToInt32(x.Y + (cf.poin[i].Y - x.Y) * Math.Cos(da * Math.PI / 180) + (cf.poin[i].X - x.X) * Math.Sin(da * Math.PI / 180)); 
                    cf.poin[i] = new Point(newPointX, newPointY);
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

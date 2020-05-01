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
        //IFigur figur;
        Point x;

        public void ChangeFigure(Point p)
        {
            x = cf.figur.centr;
            int dx, dy;
            //dx = Math.Abs(Math.Abs(p.X - x.X) - Math.Abs(keepP.Y - x.Y));
            //dy = Math.Abs(Math.Abs(p.Y - x.Y) - Math.Abs(keepP.Y - x.Y));

            dx = Math.Abs(p.X - keepP.X);
            dy = Math.Abs(p.Y - keepP.Y);
            int r = Convert.ToInt32(Math.Sqrt(Math.Abs(dx * dx) + Math.Abs(dy * dy)));


            for (int i = 0; i < cf.poin.Count; i++)
            {
                int dxPoint, dyPoint, rPoint;
                dxPoint = Math.Abs(cf.poin[i].X - x.X);
                dyPoint = Math.Abs(cf.poin[i].Y - x.Y);
                rPoint = Convert.ToInt32(Math.Sqrt((dxPoint * dxPoint) + (dyPoint * dyPoint)));
                int a = Convert.ToInt32((cf.poin[i].X - x.X) / rPoint);
                int b = Convert.ToInt32((cf.poin[i].Y - x.Y) / rPoint);
                cf.poin[i] = new Point(x.X + (r + rPoint) * a, x.Y + (r + rPoint) * b);

                //int a = Math.Abs(cf.poin[i].X - x.X);
                //int b = Math.Abs(cf.poin[i].Y - x.Y);

                //if (cf.poin[i].X > x.X && cf.poin[i].Y > x.Y)
                //{
                //    cf.poin[i] = new Point(x.X + a + dx, x.Y + b + dy);
                //}
                //else if (cf.poin[i].X > x.X && cf.poin[i].Y < x.Y)
                //{
                //    cf.poin[i] = new Point(x.X + a + dx, x.Y - b - dy);
                //}
                //else if (cf.poin[i].X < x.X && cf.poin[i].Y < x.Y)
                //{
                //    cf.poin[i] = new Point(x.X - a - dx, x.Y - b - dy);
                //}
                //else if (cf.poin[i].X < x.X && cf.poin[i].Y > x.Y)
                //{
                //    cf.poin[i] = new Point(x.X - a - dx, x.Y + b + dy);
                //}
                //else if (cf.poin[i].X == x.X && cf.poin[i].Y != x.Y)
                //{
                //    if (cf.poin[i].Y > x.Y)
                //    {
                //        cf.poin[i] = new Point(x.X, x.Y + b + dy);
                //    }
                //    else
                //    {
                //        cf.poin[i] = new Point(x.X, x.Y - b - dy);
                //    }
                //}
                //else if (cf.poin[i].X != x.X && cf.poin[i].Y == x.Y)
                //{
                //    if (cf.poin[i].X > x.X)
                //    {
                //        cf.poin[i] = new Point(x.X + a + dx, x.Y);
                //    }
                //    else
                //    {
                //        cf.poin[i] = new Point(x.X - a - dx, x.Y);
                //    }
                //}
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
                            return cf;
                        }
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

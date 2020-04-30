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


        //for (int i = 0; i<points.Count; i++)
        //   {
        //       points[i] = new Point(centr.X+((points[i].X-centr.X) + dX), centr.Y+((points[i].Y-centr.Y) + dY));
        //   }

        public void ChangeFigure(Point p)
        {
            int dx, dy;
            dx = Math.Abs(p.X - keepP.X);
            dy = Math.Abs(p.Y - keepP.Y);            
            x = cf.figur.centr;
            for (int i = 0; i < cf.poin.Count; i++)
            {
                int a = Math.Abs(cf.poin[i].X - x.X);
                int b = Math.Abs(cf.poin[i].Y - x.Y);

                if (cf.poin[i].X >= x.X && cf.poin[i].Y >= x.Y)
                {
                    cf.poin[i] = new Point(x.X + a + dx, x.Y + b + dy);
                }
                else if (cf.poin[i].X >= x.X && cf.poin[i].Y <= x.Y)
                {
                    cf.poin[i] = new Point(x.X + a + dx, x.Y - b - dy);
                }
                else if (cf.poin[i].X <= x.X && cf.poin[i].Y <= x.Y)
                {
                    cf.poin[i] = new Point(x.X - a - dx, x.Y - b - dy);
                }
                else if (cf.poin[i].X <= x.X && cf.poin[i].Y >= x.Y)
                {
                    cf.poin[i] = new Point(x.X - a - dx, x.Y + b + dy);
                }
                //cf.poin[i] = new Point(x.X + ((cf.poin[i].X - x.X) + dx), x.Y + ((cf.poin[i].Y - x.Y) + dy));
            }
            //figur.ZoomingFigure(dx, dy);
            //for (int i = 0; i < cf.poin.Count; i++)
            //{
            //    //cf.poin[i] = new Point(cf.poin[i].X + dx, cf.poin[i].Y + dy);
            //    cf.poin[i] = new Point(centr.X+((cf.poin[i].X-centr.X) + dX), centr.Y+((cf.poin[i].Y-centr.Y) + dY));
            //}
            //keepP = p;
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

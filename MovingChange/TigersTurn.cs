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
   //         if (cf.figur is Ellipse)
   //         {
   ////             X' = Xp + r*cos(Phi+dPhi) = Xp + r*cos(Phi)*cos(dPhi) - r*sin(Phi)*sin(dPhi)
   ////             Y' = Yp + r*sin(Phi+dPhi) = Yp + r*sin(Phi)*cos(dPhi) + r*cos(Phi)*sin(dPhi) 
   //             x = cf.centr;              

   //             double r = (double)Math.Sqrt((keepP.X - x.X) * (keepP.X - x.X) + (keepP.Y - x.Y) * (keepP.Y - x.Y));
   //             double rP = (double)Math.Sqrt((p.X - x.X) * (p.X - x.X) + (p.Y - x.Y) * (p.Y - x.Y));
   //             double aP = (double)Math.Abs(Math.Acos((p.X - x.X) / rP) * 180 / Math.PI);
   //             double aKeepP = (double)Math.Abs(Math.Acos((keepP.X - x.X) / r) * 180 / Math.PI);
   //             double da = (double)Math.Abs(aP - aKeepP);

   //             for (int i = 0; i < cf.poin.Count; i++)
   //             {
   //                 int newPointX = Convert.ToInt32(x.X + (cf.poin[i].X - x.X) * Math.Cos(da * Math.PI / 180) - (cf.poin[i].Y - x.Y) * Math.Sin(da * Math.PI / 180));
   //                 int newPointY = Convert.ToInt32(x.Y + (cf.poin[i].Y - x.Y) * Math.Cos(da * Math.PI / 180) + (cf.poin[i].X - x.X) * Math.Sin(da * Math.PI / 180));
   //                 cf.poin[i] = new Point(newPointX, newPointY);
   //             }
   //             int keepPX = Convert.ToInt32(x.X + (keepP.X - x.X) * Math.Cos(da * Math.PI / 180) - (keepP.Y - x.Y) * Math.Sin(da * Math.PI / 180));
   //             int keepPY = Convert.ToInt32(x.Y + (keepP.Y - x.Y) * Math.Cos(da * Math.PI / 180) + (keepP.X - x.X) * Math.Sin(da * Math.PI / 180));
   //             keepP = new Point(keepPX, keepPY);
   //         }
   //         else 
   //         {
                x = cf.centr;
                double r = (double)Math.Sqrt(((double)keepP.X - (double)x.X) * ((double)keepP.X - (double)x.X) + ((double)keepP.Y - (double)x.Y) * ((double)keepP.Y - (double)x.Y));
                double rP = (double)Math.Sqrt(((double)p.X - (double)x.X) * ((double)p.X - (double)x.X) + ((double)p.Y - x.Y) * ((double)p.Y - x.Y));
                double aP = (double)Math.Abs(Math.Acos(((double)p.X - (double)x.X) / (double)rP) * 180 / Math.PI);
                double aKeepP = (double)Math.Abs(Math.Acos(((double)keepP.X - (double)x.X) / (double)r) * 180 / Math.PI);
                double da = (double)Math.Abs((double)aP - (double)aKeepP);

                for (int i = 0; i < cf.poin.Count; i++)
                {
                    double rPoint= (double)Math.Sqrt(((double)cf.poin[i].X - (double)x.X) * ((double)cf.poin[i].X - (double)x.X) + ((double)cf.poin[i].Y - (double)x.Y) * ((double)cf.poin[i].Y - (double)x.Y));
                    double aCos = (double)((double)cf.poin[i].X - (double)x.X) / (double)rPoint;
                    double aSin = (double)((double)cf.poin[i].Y - (double)x.Y) / (double)rPoint;
                    int newPointX = Convert.ToInt32((double)x.X + (double)rPoint * (double)aCos * (double)Math.Cos(da * Math.PI / 180) - (double)rPoint * (double)aSin * (double)Math.Sin(da * Math.PI / 180));
                    int newPointY = Convert.ToInt32((double)x.Y + (double)rPoint * (double)aSin * (double)Math.Cos(da * Math.PI / 180) + (double)rPoint * (double)aCos * (double)Math.Sin(da * Math.PI / 180));

                //int newPointX = Convert.ToInt32((double)x.X + ((double)cf.poin[i].X - (double)x.X) * Math.Cos((double)da * Math.PI / 180) - ((double)cf.poin[i].Y - x.Y) * Math.Sin((double)da * Math.PI / 180));
                //int newPointY = Convert.ToInt32((double)x.Y + ((double)cf.poin[i].Y - (double)x.Y) * Math.Cos((double)da * Math.PI / 180) + ((double)cf.poin[i].X - x.X) * Math.Sin((double)da * Math.PI / 180));
                    cf.poin[i] = new Point(newPointX, newPointY);
                }
            //int keepPX = Convert.ToInt32((double)x.X + ((double)keepP.X - (double)x.X) * Math.Cos((double)da * Math.PI / 180) - ((double)keepP.Y - (double)x.Y) * Math.Sin((double)da * Math.PI / 180));
            //int keepPY = Convert.ToInt32((double)x.Y + ((double)keepP.Y - (double)x.Y) * Math.Cos((double)da * Math.PI / 180) + ((double)keepP.X - (double)x.X) * Math.Sin((double)da * Math.PI / 180));
            //keepP = new Point(keepPX,keepPY);
            //keepP = p;
            //}
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

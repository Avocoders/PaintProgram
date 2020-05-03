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
    public class PointMove : IMovingChange
    {
        SingleBitmap move = SingleBitmap.Create();
        CreatedFigure q;
        public void ChangeFigure(Point p)
        {            
        }

        public Point FirstPoint(Point p)
        {            
            if (q.poin.Count == 4)
            {
                if (q.poin.IndexOf(p) == 0)
                {
                    return q.poin[2];
                }
                else if (q.poin.IndexOf(p) == 1)
                {
                    return q.poin[3];
                }
                else if (q.poin.IndexOf(p) == 2)
                {
                    return q.poin[0];
                }
                else if (q.poin.IndexOf(p) == 3)
                {
                    return q.poin[1];
                }
            }
            else if (q.poin.Count == 3)
            {
                if (q.poin.IndexOf(p) == 0)
                {
                    return q.poin[1];
                }
                else if (q.poin.IndexOf(p) == 1)
                {
                    return q.poin[0];
                }
                else if (q.poin.IndexOf(p) == 2)
                {
                    return q.poin[0];
                }
            }
            else if (q.poin.Count == 2)
            {
                if (q.poin.IndexOf(p) == 0)
                {
                    return q.poin[1];
                }
                else if (q.poin.IndexOf(p) == 1)
                {
                    return q.poin[0];
                }                
            }
            else if (q.poin.Count > 4)
            {
                int a = q.poin.Count / 2;
                if (q.poin.IndexOf(p) >= a)
                {
                    return q.poin[q.poin.IndexOf(p) - a];
                }
                else
                {
                    return q.poin[q.poin.IndexOf(p) + a];
                }                         
            }
            return q.poin[-1];
        }
       
        public CreatedFigure FindPoint(Point p)
        {
            foreach (CreatedFigure f in move.listOfFigure)
            {
                if (f.poin.Contains(p))
                {
                     q = f;
                    return f;
                }
            }
            return null;
        }

        public int FindMainPoint(Point p)
        {
            if (q.poin.Contains(p))
            {
                return q.poin.IndexOf(p);
            }
            return -1;
        }

        public void PointChangeMode(PictureBox pictureBox)
        {
            
            Brush brush = new Brush();
            brush.SetColor(Color.Red);           
            move.DrowAllFigure();            

            foreach (CreatedFigure f in move.listOfFigure)
            {
                foreach (Point t in f.poin)
                {
                    for (int i = -3; i <= 3; i++)
                    {
                        Point p1 = new Point(t.X - 3, t.Y + i);
                        Point p2 = new Point(t.X + 3, t.Y + i);                        
                        brush.DrawLine(p1.X, p1.Y, p2.X, p2.Y);                        
                    }
                }
            }            
        }
    }
}

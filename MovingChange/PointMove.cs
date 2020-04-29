using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7.MovingChange
{
    public class PointMove : IMovingChange
    {
        SingleBitmap move = SingleBitmap.Create();           
        public void ChangeFigure(Point p)
        {                              
        }
       CreatedFigure q;
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
           // move.GetBrush(brush,drower);
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

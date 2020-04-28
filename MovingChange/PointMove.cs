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

        public Drower FindPoint(Point p)
        {
            foreach (Drower f in move.listOfFigure)
            {
                if (f.points.Contains(p))
                {
                    Drower q = f;
                    return f;
                }
            }

            return null;
        }

        public int FindMainPoint(Point p)
        {
            foreach (Drower f in move.listOfFigure)
            {
                if (f.points.Contains(p))
                {
                    return f.points.IndexOf(p);
                }
            }
            return -1;
        }

        public void PointChangeMode(PictureBox pictureBox)
        {
            
            Brush brush = new Brush();
            brush.SetColor(Color.Red);
            move.GetBrush(brush);
            move.DrowAllFigure();            

            foreach (Drower f in move.listOfFigure)
            {
                foreach (Point t in f.points)
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

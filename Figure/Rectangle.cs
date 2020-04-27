using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.Figure
{
    
    public class Rectangl : IFigur
    {
        List<Point> rectangl ;

        public void ChangeFigurePosition(Point n)
        {
            throw new NotImplementedException();
        }

        public List<Point> Drow(int x1, int y1, int x2, int y2, int nAngle)
        {
            rectangl = new List<Point>();
            rectangl.Add(new Point(x1, y1));
            rectangl.Add(new Point(x2, y1));
            rectangl.Add(new Point(x2, y2));
            rectangl.Add(new Point(x1, y2));
            //rectangl.Add(new Point(x1, y1));
            //q.DrawLine(x2, y1 ,x1, y1);
            //q.DrawLine(x2, y2, x2, y1);
            //q.DrawLine(x1, y2, x2, y2);
            //q.DrawLine(x1, y1, x1, y2);
            return rectangl;
        }
    }
}

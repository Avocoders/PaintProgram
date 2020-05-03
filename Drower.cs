using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public abstract class Drower
    {        
        public Brush brush;
        public IFigur figure;
        public IFill fill;
        public List<Point> points;

        public Drower(Brush brush, IFigur figur, IFill fill) 
        {
            this.brush = brush;
            this.figure = figur;
            this.fill = fill;
            points = new List<Point>();
        }
        
        public abstract void Draw(Point point1, Point point2,int nAngle,CreatedFigure cf);

        public abstract void Draw(CreatedFigure cf);
    }
}

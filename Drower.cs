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
        public Drower(Brush brush, IFigur figur) 
        {
            this.brush = brush;
            this.figure = figur;
        }
        public abstract void Draw(Point point1, Point point2);
    }
}

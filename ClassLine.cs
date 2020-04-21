using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class ClassLine : Drower
    {
        public ClassLine(Brush brush, IFigur figur) : base(brush, null)
        {

        }
        public override void Draw(Point point1, Point point2)
        {
            brush.DrawLine(point1.X, point1.Y, point2.X, point2.Y);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class ClassLine : Drower
    {
        public ClassLine(Brush brush, IFigur figur, IFill fill): base(brush, null, null) 
        {
            points = new List<Point>();
           
        }
        
        public override void Draw(Point point1, Point point2,int nAngle) 
        {
            brush.DrawLine(point1.X, point1.Y, point2.X, point2.Y);
            points.Add(point1);
            points.Add(point2);
        }

        public override void Draw()
        {
            for(int i = 0; i<points.Count-1;i++)
            {
                brush.DrawLine(points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            }
        }
    }
}

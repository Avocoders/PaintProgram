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
        
        public override void Draw(Point point1, Point point2,int nAngle, CreatedFigure cf) 
        {
            brush.DrawLine(point1.X, point1.Y, point2.X, point2.Y);
            cf.poin.Add(point1);
            cf.poin.Add(point2);
        }

        public override void Draw(CreatedFigure cf)
        {
            for(int i = 0; i<cf.poin.Count-2;i++)
            {
                brush.DrawLine(cf.poin[i].X, cf.poin[i].Y, cf.poin[i + 1].X, cf.poin[i + 1].Y);                
            }
        }
    }
}

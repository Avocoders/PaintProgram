using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class UnPoligon : Drower
    {
        List<Point> points ;        
        int n = 0;

        public UnPoligon(Brush brush, IFigur figur, IFill fill) : base(brush, figur, fill)
        {
        }

        public override void Draw(Point point, Point point2, int nAngle, CreatedFigure cf)
        {            
            if (points == null)
            {
                points = new List<Point>();
                cf.poin.Add(point);
                brush.SetDot(point.X, point.Y);
            }
            else
            {
                brush.DrawLine(cf.poin[n].X, cf.poin[n].Y, point2.X, point2.Y);
                cf.poin.Add(point);
                n++;
            }
        }

        public override void Draw(CreatedFigure cf)
        {
            for (int i = 0; i < cf.poin.Count - 1; i++)
            {
                brush.DrawLine(cf.poin[i].X, cf.poin[i].Y, cf.poin[i + 1].X, cf.poin[i + 1].Y);
            }
            brush.DrawLine(cf.poin[0].X, cf.poin[0].Y, cf.poin[cf.poin.Count - 1].X, cf.poin[cf.poin.Count - 1].Y);
        }
    }
}

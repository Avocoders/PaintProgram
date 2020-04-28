using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class ClassFigure : Drower
    {
        
        public ClassFigure(Brush brush, IFigur figur, IFill fill) : base(brush, figur, fill) 
        {
        
        }
        public override void Draw(Point first, Point last,int nAngle)
        {
            points = figure.Drow(first.X, first.Y, last.X, last.Y, nAngle);
            for(int i = 0; i<points.Count-1;i++)
            {
                brush.DrawLine(points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            }
            brush.DrawLine(points[0].X, points[0].Y, points[points.Count-1].X, points[points.Count-1].Y);
            int x = (points[0].X + points[points.Count / 3].X + points[2 * points.Count / 3].X) / 3;//ищем куда лить
            int y = (points[0].Y + points[points.Count / 3].Y + points[2 * points.Count / 3].Y) / 3;
            if (fill != null)
            {
                fill.SetColor(x, y);
                fill.Casting(x, y);
            }
        }

        public override void Draw()
        {
            for (int i = 0; i < points.Count - 1; i++)
            {
                brush.DrawLine(points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            }
            brush.DrawLine(points[0].X, points[0].Y, points[points.Count - 1].X, points[points.Count - 1].Y);
            int x = (points[0].X + points[points.Count / 3].X + points[2 * points.Count / 3].X) / 3;//ищем куда лить
            int y = (points[0].Y + points[points.Count / 3].Y + points[2 * points.Count / 3].Y) / 3;
            if (fill != null)
            {
                fill.SetColor(x, y);
                fill.Casting(x, y);
            }
        }
    }
}

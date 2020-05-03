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

        public override void Draw(Point first, Point last,int nAngle,CreatedFigure cf)
        {
            cf.poin = cf.figur.Drow(first.X, first.Y, last.X, last.Y, nAngle);
            cf.f = first;
            cf.centr = cf.figur.centr;
            cf.start = cf.figur.start;
            cf.l = last;
            for(int i = 0; i<cf.poin.Count-1;i++)
            {
                brush.DrawLine(cf.poin[i].X, cf.poin[i].Y, cf.poin[i + 1].X, cf.poin[i + 1].Y);
            }
            brush.DrawLine(cf.poin[0].X, cf.poin[0].Y, cf.poin[cf.poin.Count-1].X, cf.poin[cf.poin.Count-1].Y);
            int x = (cf.poin[0].X + cf.poin[cf.poin.Count / 3].X + cf.poin[2 * cf.poin.Count / 3].X) / 3;//ищем куда лить
            int y = (cf.poin[0].Y + cf.poin[cf.poin.Count / 3].Y + cf.poin[2 * cf.poin.Count / 3].Y) / 3;
            if (cf.fill != null)
            {
                fill.SetColor(x, y);
                fill.Casting(x, y);
            }
        }

        public override void Draw(CreatedFigure cf)
        {
            for (int i = 0; i < cf.poin.Count - 1; i++)
            {
                brush.DrawLine(cf.poin[i].X, cf.poin[i].Y, cf.poin[i + 1].X, cf.poin[i + 1].Y);
            }
            if (cf.figur != null)
            {
                brush.DrawLine(cf.poin[0].X, cf.poin[0].Y, cf.poin[cf.poin.Count - 1].X, cf.poin[cf.poin.Count - 1].Y);
            }
            
            int x = (cf.poin[0].X + cf.poin[cf.poin.Count / 3].X + cf.poin[2 * cf.poin.Count / 3].X) / 3;//ищем куда лить
            int y = (cf.poin[0].Y + cf.poin[cf.poin.Count / 3].Y + cf.poin[2 * cf.poin.Count / 3].Y) / 3;
            if (cf.fill != null)
            {
                fill.SetColor(x, y);
                fill.Casting(x, y);
            }
        }
    }
}

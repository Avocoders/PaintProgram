using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class CreatedFigure
    {
        public List<Point> poin;
        public IFigur figur;
        public  Brush brush;
        public IFill fill;
        public Point centr;
        public Point f;
        public Point l;
        public Point start;

        public CreatedFigure(Brush brush, IFigur figur, IFill fill)
        {
            this.brush = brush;
            this.figur = figur;
            this.fill = fill;
            poin = new List<Point>();
            centr = new Point();
            f = new Point();
            l = new Point();
        }

        public void SetPoint(List<Point> po)
        {
            poin = po;
        }

    }
}

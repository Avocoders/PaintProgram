using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public abstract class IFigur
    {
        public List<Point> points;
        public Point centr;
        public Point start;

        public abstract List<Point> Drow(int x1, int y1, int x2, int y2, int nAngle) ;

        public abstract bool CheckForMatches(int x1, int y1, int x2, int y2, int c, int[] ExPoints);
    }
}

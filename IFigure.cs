using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public interface IFigur
    {
     List<Point> Drow(int x1, int y1, int x2, int y2, int nAngle);
    void ChangeFigurePosition(Point n);
    }
}

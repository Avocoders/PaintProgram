using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public interface IMovingChange
    {
        void FindPoint(Point p);
        void ChangeFigure(Point p);
    }
}

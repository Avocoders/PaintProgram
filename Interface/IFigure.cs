using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.Interface
{
    interface IFigure
    {
        Bitmap DrawFigure(int x, int y, Color color);
    }
}

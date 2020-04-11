using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp7;

namespace WindowsFormsApp7.Interface
{
    class Line : IFigure
    {
        int Width, Height;
        Bitmap bitmap;
        public Line(int x, int y)
        {
            Width = x;
            Height = y;
            bitmap = new Bitmap(Width, Height);
        }
        public Bitmap DrawFigure(int x, int y, Color color)
        {
            bitmap.SetPixel(x, y,color);
            return bitmap;
        }
    }
}

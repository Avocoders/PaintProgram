using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.Fill
{
    public class TwoColorFill : IFill
    {        
        SingleBitmap q = SingleBitmap.Create();        
        Color fillColor;
        Color startColor;

        public TwoColorFill(Color fillColor)
        {
            this.fillColor = fillColor;
        }

        public void SetColor(int x, int y)
        {
            startColor = q.bitFigure.GetPixel(x, y);
        }

        public void Casting(int x, int y)
        {

            if (fillColor.ToArgb() != startColor.ToArgb())
            {
                int leftX = x;
                int rightX = x;
                while (q.bitFigure.GetPixel(leftX - 1, y) == startColor && leftX > 1)
                {
                    leftX--;
                }
                while (q.bitFigure.GetPixel(rightX + 1, y) == startColor && rightX < q.bitFigure.Width - 2)
                {
                    rightX++;
                }

                for (int i = leftX; i <= rightX; i++)
                {
                    q.bitFigure.SetPixel(i, y, fillColor);
                }

                for (int i = leftX; i <= rightX; i++)
                {
                    if (q.bitFigure.GetPixel(i, y - 1) == startColor && y > 1)
                    {
                        Casting(i, y - 1);
                    }
                    if (q.bitFigure.GetPixel(i, y + 1) == startColor && y < q.bitFigure.Height - 2)
                    {
                        Casting(i, y + 1);
                    }
                }
            }
        }
    }
}

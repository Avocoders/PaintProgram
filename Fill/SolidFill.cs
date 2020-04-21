﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.Fill
{
    public class SolidFill : IFill
    {
        int x, y;
        SingleBitmap q = SingleBitmap.Create();
        Color color = Color.Black;
        Color fillColor;
        public SolidFill(Color fillColor)
        {
            this.fillColor = fillColor;
        }
        public void Casting(int x, int y)
        {
            Color startColor = q.bitmap.GetPixel(x,y);
            int leftX = x;
            int rightX = x;
            while(q.bitmap.GetPixel(leftX-1, y)== startColor && leftX>1)
            {
                leftX--;
            }
            while (q.bitmap.GetPixel(rightX + 1, y) == startColor && rightX < q.bitmap.Width-2)
            {
                rightX++;
            }

            for (int i = leftX; i<=rightX; i++)
            {
                q.bitmap.SetPixel(i, y,fillColor);
            }

            for (int i = leftX; i <= rightX; i++)
            {
                if (q.bitmap.GetPixel(i, y - 1) == startColor && y>1)
                {
                    Casting(i, y - 1); 
                }
                if (q.bitmap.GetPixel(i, y + 1) == startColor && y < q.bitmap.Height-2)
                {
                    Casting(i, y + 1);
                }
            }

        }
    }
}

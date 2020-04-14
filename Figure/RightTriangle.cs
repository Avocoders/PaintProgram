﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.Figure
{
    public class RightTriangle : IFigur
    {
        Brush q;
        public RightTriangle(Brush bruch)
        {
            q = bruch;
        }
        public void Drow(int x1, int y1, int x2, int y2)
        {            
            q.DrawLine(x2, y2, x1, y1);
            q.DrawLine(x1, y2, x2, y2);
            q.DrawLine(x1, y1, x1, y2);
        }
    }
}

﻿using System;
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
        public override void Draw(Point point1, Point point2)
        {
            throw new NotImplementedException();
        }
    }
}

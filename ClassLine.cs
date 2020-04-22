﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class ClassLine : Drower
    {
        public ClassLine(Brush brush, IFigur figur, IFill fill): base(brush, null, null) 
        {
           
        }
        public override void Draw(Point point1, Point point2,int nAngle) 
        {
            brush.DrawLine(point1.X, point1.Y, point2.X, point2.Y);
        }
    }
}

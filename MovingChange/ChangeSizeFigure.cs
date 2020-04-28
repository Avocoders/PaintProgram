using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7.MovingChange
{
    class ChangeSizeFigure : IMovingChange
    {
        SingleBitmap move = SingleBitmap.Create();
        public void ChangeFigure(Point p)
        {
            throw new NotImplementedException();
        }

        public int FindMainPoint(Point p)
        {
            throw new NotImplementedException();
        }

        public Drower FindPoint(Point p)
        {
            foreach(Drower f in move.listOfFigure)
            {
                if (f.points.Contains(p))
                {
                    IFigur q = f.figure;
                    return f;
                }
            }

            return null;
        }

        public void PointChangeMode(PictureBox pictureBox)
        {
           // foreach(Point p in )

        }
    }
}

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

        public CreatedFigure FindPoint(Point p)
        {
            foreach(CreatedFigure f in move.listOfFigure)
            {
                if (f.poin.Contains(p))
                {
                    IFigur q = f.figur;
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

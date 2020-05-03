using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public interface IMovingChange
    {
        CreatedFigure FindPoint(Point p);

        void ChangeFigure(Point p);

        int FindMainPoint(Point p);

        void PointChangeMode(PictureBox pictureBox);

        Point FirstPoint(Point p);
    }
}

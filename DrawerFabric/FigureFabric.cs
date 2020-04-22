using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.DrawerFabric
{
    public class FigureFabric : AbstractFabric
    {
        public override Drower CreateDrower(IFigur selectedFigur)
        {
            Brush brush = new Brush(); // selectedColor, selectedSize
            abstractDrower = new ClassFigure(brush, selectedFigur, null); // IFill fill
            return abstractDrower;
        }
    }
}

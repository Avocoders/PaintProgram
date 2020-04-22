using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.DrawerFabric
{
    public class LineFabric : AbstractFabric
    {
        public override Drower CreateDrower(IFigur selectedFigur) // selectedColor, selectedSize
        {
            Brush brush = new Brush(); // selectedColor, selectedSize
            abstractDrower = new ClassLine(brush, null, null); // IFill fill
            return abstractDrower;
        }
    }
}

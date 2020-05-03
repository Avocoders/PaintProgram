using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.DrawerFabric
{
    class UncommonPoligon : AbstractFabric
    {
        public override Drower CreateDrower(IFigur selectedFigur, Brush brush, IFill fill)
        {
            abstractDrower = new UnPoligon(brush, selectedFigur, fill); 
            return abstractDrower;
        }
    }
}

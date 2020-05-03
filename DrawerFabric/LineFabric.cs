using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.DrawerFabric
{
    public class LineFabric : AbstractFabric
    {
        public override Drower CreateDrower(IFigur selectedFigur, Brush brush, IFill fill) 
        {            
            abstractDrower = new ClassLine(brush, null, null); 
            return abstractDrower;
        }
    }
}

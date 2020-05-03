using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.DrawerFabric
{
    public abstract class AbstractFabric
    {
        public Drower abstractDrower;
        abstract public Drower CreateDrower(IFigur selectedFigur, Brush brush, IFill fill); 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.IteratorAndCompositePattern
{
    public interface IMenu
    {
        IEnumerable<MenuItem> GetMenu();
    }
}

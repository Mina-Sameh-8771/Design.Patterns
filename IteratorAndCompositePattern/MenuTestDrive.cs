using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.IteratorAndCompositePattern
{
    public class MenuTestDrive
    {
        public static void main()
        {
            IEnumerable<IMenu> menusData = new List<IMenu>() 
            {
                new PancakeHouseMenu(),
                new DinerMenu()
            };

            Waitress waitress = new Waitress(menusData);
            waitress.printMenu();
        }
    }
}

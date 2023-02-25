using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.IteratorAndCompositePattern
{
    public class Waitress
    {
        IEnumerable<IMenu> menusData;
        public Waitress(IEnumerable<IMenu> menusData)
        {
            this.menusData = menusData;
        }


        public void printMenu()
        {
            foreach(var menuData in menusData)
            {
                printMenu(menuData.GetMenu());
            }
        }
        private void printMenu(IEnumerable<MenuItem> iterator)
        {
            foreach(var menuItem in iterator)
            {
                Console.Write(menuItem.getName() + ", ");
                Console.Write(menuItem.getPrice() + " -- ");
                Console.WriteLine(menuItem.getDescription());
            }
        }
    }
}

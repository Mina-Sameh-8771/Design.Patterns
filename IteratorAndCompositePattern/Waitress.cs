using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.IteratorAndCompositePattern
{
    public class Waitress
    {
        IMenu pancakeHouseMenu;
        IMenu dinerMenu;
        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }
        public void printMenu()
        {
            var pancakeMenuItems = pancakeHouseMenu.GetMenu();
            var dinerMenuItems = dinerMenu.GetMenu();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            printMenu(pancakeMenuItems);


            Console.WriteLine("\nLUNCH");
            printMenu(dinerMenuItems);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.StatePattern
{
    public class GumballMachineTestDrive
    {
        public static void main()
        {
            GumballMachine gumballMachine = new GumballMachine(5);
            Console.WriteLine(gumballMachine);
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            Console.WriteLine(gumballMachine);
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            Console.WriteLine(gumballMachine);
            Console.WriteLine(gumballMachine.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.StatePattern
{
    public class SoldOutState : IState
    {
        GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("You can’t eject, you haven’t inserted a quarter yet");
        }

        public void insertQuarter()
        {
            Console.WriteLine("You can’t insert a quarter, the machine is sold out");
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.StatePattern
{
    public class GumballMachine 
    {
        IState soldOutState;
        IState noQuarterState;
        IState hasQuarterState;
        IState soldState;
        IState state;
        IState winnerState;

        int count = 0;

        public GumballMachine(int numberGumballs)
        {
            state = soldOutState;

            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);
            count = numberGumballs;
            if (numberGumballs > 0)
            {
                state = noQuarterState;
            }
        }

        

        public void insertQuarter()
        {
            state.insertQuarter();
        }

        public void ejectQuarter()
        {
            state.ejectQuarter();
        }

        public void turnCrank()
        {
            state.turnCrank();
            state.dispense();
        }

        public void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (count != 0)
            {
                count = count - 1;
            }
        }

        public void setState(IState state)
        {
            this.state = state;
        }

        public IState getNoQuarterState()
        {
            return noQuarterState;
        }

        public IState getSoldOutState()
        {
            return soldOutState;
        }
        
        public IState getSoldState()
        {
            return soldState;
        }
        
        public IState getWinnerState()
        {
            return winnerState;
        }
        
        public IState getHasQuarterState()
        {
            return hasQuarterState;
        }

        public int getCount()
        {
            return count;
        }


        public override string ToString()
        {
            return $"Gumball Machine Has {count}";
        }

    }
}

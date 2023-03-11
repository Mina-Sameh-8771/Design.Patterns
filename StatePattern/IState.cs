using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.StatePattern
{
    public interface IState
    {
        void insertQuarter();
        void ejectQuarter();
        void turnCrank();
        void dispense();
    }
}

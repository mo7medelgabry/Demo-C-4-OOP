using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_C_4_OOP.Interfaces
{
    internal class SeriesBy3 : ISeries
    {
        public int Current { get ; set ; }

        public void GetNext()
        {
            Current += 3;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}

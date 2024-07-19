using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_C_4_OOP.Interfaces
{
    internal interface IMyType
    {  
        public int Id { get; set; }

        public void MYFun(int x);

        public void Print()
        {
            Console.WriteLine("Hello Default Method From Interface");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_C_4_OOP.Interfaces
{
    internal class MyType : IMyType
    {
        public int Id { get; set; }


        public void MYFun(int x)
        {
            Console.WriteLine($"Hello Route: {x} Id: {Id}");
        }
    }
}

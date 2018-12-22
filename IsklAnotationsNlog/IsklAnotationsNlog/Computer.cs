using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsklAnotationsNlog
{
    abstract class Computer : IComparable
    {
        protected string Titles;
        public int Cost;

        protected Computer(string titles, int cost)
        {
            Titles = titles;
            Cost = cost;
        }

        public int CompareTo(object obj)
        {
            var computer = (Computer)obj;
            return Cost - Computer.Cost;
        }

        public abstract string Info();

        public void Print()
        {
            Console.WriteLine(Info());

        }

    }
}
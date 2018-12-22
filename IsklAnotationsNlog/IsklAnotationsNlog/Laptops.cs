using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsklAnotationsNlog
{
    class Laptops : Computer
    {
        protected string OS;
        protected string Country;

        public Laptops (string os, string country, string titles, int cost) : base(titles, cost)
        {
            this.OS = os;
            this.Country = country;
        }
        public override string Info()
        {
            return Country + " " + OS + " " + Titles + " " + Cost;
        }
    }
}
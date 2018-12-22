using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsklAnotationsNlog
{
    class Dell : Laptops
    {
        protected string Brend;
        protected string HDD;

        public Dell (string brend, string hdd, string os, string country, string titles, int cost) : base(os, country, titles, cost)
        {
            this.Brend = brend;
            this.HDD = hdd;
        }

        public override string Info()
        {
            return "Бренд - " + Brend + "Жесткий диск ГБ - " + HDD + ", ОС  - " + OS + ", Страна производитель - " + Country + ", Название модели - " + Titles + ", Цена - " + Cost;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsklAnotationsNlog
{
    public class OOP
    {
        public void Launch ()
        {
            Dell laptop_2 = new Dell ("Dell", "500 GB", "Windows 10", "Китай","g3422", 21000);
            Console.WriteLine(laptop_2.Info());
            Asus laptop_1 = new Asus ("Asus", "320 GB", "Windows 7, "Вьетнам","x52n", 15000);
            Console.WriteLine(laptop_1.Info());
            Console.ReadLine();
        }
    }
}
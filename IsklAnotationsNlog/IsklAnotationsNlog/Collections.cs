using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsklAnotationsNlog
{
    public class Collections
    {
        public void Collection()
        {
            int ProductCost()
            {
                Nlog logir = new Nlog();
                Console.WriteLine("Введите стоимость продукта: ");
                try { return Convert.ToInt32(Console.ReadLine()); }

                catch
                {
                    Console.WriteLine("Error: Можно использовать только числовые значения!");
                    logir.Numbers();

                    return ProductCost();
                }
            }

            Asus laptop_1 = new Asus ("Asus", "320 GB", "Windows 7, "Вьетнам", "x52n", ProductCost());
            Dell laptop_2 = new Dell ("Dell","500 GB", "Windows 10", "Китай", "g3422", 21000);
            List<Computer> objectList = new List<Computer>();
            objectList.Add(laptop_1);
            objectList.Add(laptop_2);
            objectList.Sort((x, y) => x.Cost.CompareTo(y.Cost));
            objectList.ForEach(t => t.Print());
            Console.ReadLine();
        }
    }
}
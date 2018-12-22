using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace IsklAnotationsNlog
{
    class Program
    {
           static void Main(string[] args)
        {
            Nlog log = new Nlog();
            log.Launchprograms();
            GetAttribute(typeof(Program));
            OOP deistv = new OOP();
            deistv.Launch();
            Collections col = new Collections();
            col.Collection();
            log.Closeprogram();
        }

        public static void GetAttribute(Type g)
        {
           ProviderAttribute attribute = (ProviderAttribute)Attribute.GetCustomAttribute(g, typeof(ProviderAttribute));
            Console.WriteLine("Название поставщика: {0}", attribute.Title);
            Console.WriteLine("Город: {0}", attribute.City);
            Console.WriteLine("Страна: {0}", attribute.Country);

        }
    }
}
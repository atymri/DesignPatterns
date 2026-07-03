using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        public static void Main()
        {
            var wild = FactoryProvider.GetFactory("wild");
            wild.GetDog().AboutMe();
            wild.GetCat().AboutMe();

            var farm = FactoryProvider.GetFactory("pet");
            farm.GetDog().AboutMe();
            farm.GetCat().AboutMe();

            Console.WriteLine("hello");
        }
    }
}

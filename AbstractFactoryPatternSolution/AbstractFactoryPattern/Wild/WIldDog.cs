using AbstractFactoryPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Wild
{
    internal class WIldDog : IDog
    {
        public void AboutMe()
            => Console.WriteLine("wild dog, bark!");
    }
}

using AbstractFactoryPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Wild
{
    public class WildCat : ICat
    {
        public void AboutMe()
            => Console.WriteLine("wild cat, run");
    }
}

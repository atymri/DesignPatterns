using AbstractFactoryPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Pet
{
    public class PetCat : ICat
    {
        public void AboutMe()
            => Console.WriteLine("pet cat, mew");
    }
}

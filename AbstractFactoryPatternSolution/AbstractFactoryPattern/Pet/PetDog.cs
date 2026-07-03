using AbstractFactoryPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Pet
{
    public class PetDog : IDog
    {
        public void AboutMe()
            => Console.WriteLine("pet dog, bark!");
    }
}

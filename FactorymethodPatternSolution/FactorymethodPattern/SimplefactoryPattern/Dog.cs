using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorymethodPattern.SimplefactoryPattern
{
    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Im just a dog, so, i guess BARK!");
        }
    }
}

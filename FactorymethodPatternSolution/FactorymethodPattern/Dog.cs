using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorymethodPattern
{
    internal class Dog : IAnimal
    {
        public void Talk()
            => Console.WriteLine("I'm a dog, I can bark.");
    }
}

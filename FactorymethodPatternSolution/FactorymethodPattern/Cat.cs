
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorymethodPattern
{
    internal class Cat : IAnimal
    {
        public void Talk()
            => Console.WriteLine("I'm just a cat, I don't talk much, but I can meow.");
    }
}

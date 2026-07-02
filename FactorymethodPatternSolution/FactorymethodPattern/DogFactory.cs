using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorymethodPattern
{
    internal class DogFactory : AnimalFactory
    {
        public override IAnimal MakeAnimal()
            => new Dog();
        public override IAnimal MakeAnimal(string type)
            => MakeAnimal();
    }
}

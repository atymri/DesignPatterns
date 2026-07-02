using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorymethodPattern
{
    internal class CatFactory : AnimalFactory
    {
        public override IAnimal MakeAnimal()
            => new Cat();

        public override IAnimal MakeAnimal(string type)
            => MakeAnimal();
    }
}
